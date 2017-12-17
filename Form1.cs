using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

using Mag_ACClientPatcher.DataGridViewHelpers;
using Mag_ACClientPatcher.Properties;

namespace Mag_ACClientPatcher
{
    public partial class Form1 : Form
    {
        private byte[] acClientExeData;

        private string backupFilePath;


        public Form1()
        {
            InitializeComponent();

            txtACClientExeLocation.Text = (string)Settings.Default["ACClientExeLocation"];
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadNewACClientExe();
        }


        private void cmdLocateACClientExe_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                if (!String.IsNullOrEmpty(txtACClientExeLocation.Text))
                {
                    try
                    {
                        var directory = Path.GetDirectoryName(txtACClientExeLocation.Text);

                        if (Directory.Exists(directory))
                            dialog.InitialDirectory = directory;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

                dialog.Filter = "exe files (*.exe)|*.exe";
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtACClientExeLocation.Text = dialog.FileName;
                    Settings.Default["ACClientExeLocation"] = txtACClientExeLocation.Text;
                    Settings.Default.Save();

                    LoadNewACClientExe();
                }
            }
        }

        private void LoadNewACClientExe()
        {
            acClientExeData = null;
            backupFilePath = null;

            lblACClientExeStatus.Text = null;
            cmdCreateBackup.Enabled = false;
            cmdRestoreFromBackup.Enabled = false;

            cmdCommitChangesToExe.Enabled = false;

            dataGridViewPatches.Rows.Clear();

            if (File.Exists(txtACClientExeLocation.Text))
            {
                var fileVersionInfo = FileVersionInfo.GetVersionInfo(txtACClientExeLocation.Text);

                var acClientExeInfo = ACClientExeInfos.FindBy(fileVersionInfo);

                if (acClientExeInfo == null)
                    lblACClientExeStatus.Text = $"Version ????-??    Version: {fileVersionInfo.FileBuildPart}.{fileVersionInfo.FilePrivatePart}    (Unknown)";
                else
                {
                    lblACClientExeStatus.Text = $"Released: {acClientExeInfo.RelaseMonth.Year}-{acClientExeInfo.RelaseMonth.Month}    Version: {acClientExeInfo.FileVersion}    ";

                    // Load the bytes into a local array
                    acClientExeData = File.ReadAllBytes(txtACClientExeLocation.Text);

                    // Determine if we're original or patched
                    using (var md5 = MD5.Create())
                    {
                        var hash = md5.ComputeHash(acClientExeData);

                        var hashAsString = BitConverter.ToString(hash).Replace("-", "").ToUpperInvariant();

                        var directory = Path.GetDirectoryName(txtACClientExeLocation.Text);

                        var backupFileName = $"{Path.GetFileName(txtACClientExeLocation.Text)}.{acClientExeInfo.FileVersion}.original";

                        backupFilePath = Path.Combine(directory, backupFileName);

                        if (acClientExeInfo.MD5Hash == hashAsString)
                        {
                            lblACClientExeStatus.Text += "Original";

                            // Does a backup not exist?
                            if (!File.Exists(backupFilePath))
                                cmdCreateBackup.Enabled = true;

                        }
                        else
                        {
                            lblACClientExeStatus.Text += "Patched";

                            // Do we have a backup to restore from?
                            if (File.Exists(backupFilePath))
                                cmdRestoreFromBackup.Enabled = true;
                        }
                    }

                    var patches = ACClientExePatches.FindBy(fileVersionInfo);

                    if (patches != null)
                    {
                        foreach (var patch in patches)
                        {
                            var index = dataGridViewPatches.Rows.Add(patch.Name, null, "Apply", "Revert", patch.Notes);

                            dataGridViewPatches.Rows[index].Tag = patch;

                            InitDataGridViewRow(index);
                        }
                    }
                }
            }
        }

        private void cmdCreateBackup_Click(object sender, EventArgs e)
        {
            try
            {
                File.Copy(txtACClientExeLocation.Text, backupFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (File.Exists(backupFilePath))
                cmdCreateBackup.Enabled = false;
        }

        private void cmdRestoreFromBackup_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(txtACClientExeLocation.Text);

                File.Copy(backupFilePath, txtACClientExeLocation.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            LoadNewACClientExe();
        }

        private void InitDataGridViewRow(int rowIndex)
        {
            var patch = (Patch)dataGridViewPatches.Rows[rowIndex].Tag;

            var patchState = patch.GetPatchState(acClientExeData);

            ((DataGridViewTextBoxCell)dataGridViewPatches[1, rowIndex]).Value = patchState;

            ((DataGridViewDisableButtonCell)dataGridViewPatches[2, rowIndex]).Enabled = false;
            ((DataGridViewDisableButtonCell)dataGridViewPatches[3, rowIndex]).Enabled = false;

            if (patchState == PatchState.Applied)
                ((DataGridViewDisableButtonCell)dataGridViewPatches[3, rowIndex]).Enabled = true;
            else if (patchState == PatchState.NotApplied)
                ((DataGridViewDisableButtonCell)dataGridViewPatches[2, rowIndex]).Enabled = true;

            dataGridViewPatches.InvalidateCell(2, rowIndex);
            dataGridViewPatches.InvalidateCell(3, rowIndex);
        }

        private void dataGridViewPatches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 2 && e.ColumnIndex != 3)
                return;

            var cell = (DataGridViewDisableButtonCell)dataGridViewPatches[e.ColumnIndex, e.RowIndex];

            if (!cell.Enabled)
                return;

            var patch = (Patch)dataGridViewPatches.Rows[e.RowIndex].Tag;

            if (e.ColumnIndex == 2)
            {
                if (!String.IsNullOrEmpty(patch.ApplyWarning))
                {
                    if (MessageBox.Show(patch.ApplyWarning + Environment.NewLine + Environment.NewLine + "Do you still want to apply this patch?", "Warning", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                }

                patch.Apply(acClientExeData);
            }
            else if (e.ColumnIndex == 3)
                patch.Revert(acClientExeData);

            InitDataGridViewRow(e.RowIndex);

            cmdCommitChangesToExe.Enabled = true;
        }

        private void cmdCommitChangesToExe_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(txtACClientExeLocation.Text);

                File.WriteAllBytes(txtACClientExeLocation.Text, acClientExeData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            LoadNewACClientExe();
        }
    }
}
