namespace Mag_ACClientPatcher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtACClientExeLocation = new System.Windows.Forms.TextBox();
            this.cmdLocateACClientExe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdRestoreFromBackup = new System.Windows.Forms.Button();
            this.cmdCreateBackup = new System.Windows.Forms.Button();
            this.lblACClientExeStatus = new System.Windows.Forms.Label();
            this.dataGridViewPatches = new System.Windows.Forms.DataGridView();
            this.ClumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPatchState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApply = new Mag_ACClientPatcher.DataGridViewHelpers.DataGridViewDisableButtonColumn();
            this.ColumnRevert = new Mag_ACClientPatcher.DataGridViewHelpers.DataGridViewDisableButtonColumn();
            this.ColumnNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDisableButtonColumn1 = new Mag_ACClientPatcher.DataGridViewHelpers.DataGridViewDisableButtonColumn();
            this.dataGridViewDisableButtonColumn2 = new Mag_ACClientPatcher.DataGridViewHelpers.DataGridViewDisableButtonColumn();
            this.cmdCommitChangesToExe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatches)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACClient.exe Location:";
            // 
            // txtACClientExeLocation
            // 
            this.txtACClientExeLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtACClientExeLocation.Location = new System.Drawing.Point(132, 14);
            this.txtACClientExeLocation.Name = "txtACClientExeLocation";
            this.txtACClientExeLocation.ReadOnly = true;
            this.txtACClientExeLocation.Size = new System.Drawing.Size(765, 20);
            this.txtACClientExeLocation.TabIndex = 1;
            // 
            // cmdLocateACClientExe
            // 
            this.cmdLocateACClientExe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdLocateACClientExe.Location = new System.Drawing.Point(903, 12);
            this.cmdLocateACClientExe.Name = "cmdLocateACClientExe";
            this.cmdLocateACClientExe.Size = new System.Drawing.Size(69, 23);
            this.cmdLocateACClientExe.TabIndex = 2;
            this.cmdLocateACClientExe.Text = "Locate";
            this.cmdLocateACClientExe.UseVisualStyleBackColor = true;
            this.cmdLocateACClientExe.Click += new System.EventHandler(this.cmdLocateACClientExe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ACClient.exe Status:";
            // 
            // cmdRestoreFromBackup
            // 
            this.cmdRestoreFromBackup.Location = new System.Drawing.Point(285, 70);
            this.cmdRestoreFromBackup.Name = "cmdRestoreFromBackup";
            this.cmdRestoreFromBackup.Size = new System.Drawing.Size(147, 23);
            this.cmdRestoreFromBackup.TabIndex = 5;
            this.cmdRestoreFromBackup.Text = "Restore From Backup";
            this.cmdRestoreFromBackup.UseVisualStyleBackColor = true;
            this.cmdRestoreFromBackup.Click += new System.EventHandler(this.cmdRestoreFromBackup_Click);
            // 
            // cmdCreateBackup
            // 
            this.cmdCreateBackup.Location = new System.Drawing.Point(132, 70);
            this.cmdCreateBackup.Name = "cmdCreateBackup";
            this.cmdCreateBackup.Size = new System.Drawing.Size(147, 23);
            this.cmdCreateBackup.TabIndex = 6;
            this.cmdCreateBackup.Text = "Create Backup";
            this.cmdCreateBackup.UseVisualStyleBackColor = true;
            this.cmdCreateBackup.Click += new System.EventHandler(this.cmdCreateBackup_Click);
            // 
            // lblACClientExeStatus
            // 
            this.lblACClientExeStatus.AutoSize = true;
            this.lblACClientExeStatus.Location = new System.Drawing.Point(129, 46);
            this.lblACClientExeStatus.Name = "lblACClientExeStatus";
            this.lblACClientExeStatus.Size = new System.Drawing.Size(105, 13);
            this.lblACClientExeStatus.TabIndex = 7;
            this.lblACClientExeStatus.Text = "lblACClientExeStatus";
            // 
            // dataGridViewPatches
            // 
            this.dataGridViewPatches.AllowUserToAddRows = false;
            this.dataGridViewPatches.AllowUserToDeleteRows = false;
            this.dataGridViewPatches.AllowUserToResizeColumns = false;
            this.dataGridViewPatches.AllowUserToResizeRows = false;
            this.dataGridViewPatches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClumnName,
            this.ColumnPatchState,
            this.ColumnApply,
            this.ColumnRevert,
            this.ColumnNotes});
            this.dataGridViewPatches.Location = new System.Drawing.Point(12, 99);
            this.dataGridViewPatches.Name = "dataGridViewPatches";
            this.dataGridViewPatches.RowHeadersVisible = false;
            this.dataGridViewPatches.Size = new System.Drawing.Size(960, 250);
            this.dataGridViewPatches.TabIndex = 8;
            this.dataGridViewPatches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatches_CellClick);
            // 
            // ClumnName
            // 
            this.ClumnName.HeaderText = "Name";
            this.ClumnName.Name = "ClumnName";
            this.ClumnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ClumnName.Width = 200;
            // 
            // ColumnPatchState
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnPatchState.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnPatchState.HeaderText = "Patch State";
            this.ColumnPatchState.Name = "ColumnPatchState";
            this.ColumnPatchState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnPatchState.Width = 75;
            // 
            // ColumnApply
            // 
            this.ColumnApply.HeaderText = "Apply";
            this.ColumnApply.Name = "ColumnApply";
            this.ColumnApply.Width = 50;
            // 
            // ColumnRevert
            // 
            this.ColumnRevert.HeaderText = "Revert";
            this.ColumnRevert.Name = "ColumnRevert";
            this.ColumnRevert.Width = 50;
            // 
            // ColumnNotes
            // 
            this.ColumnNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNotes.HeaderText = "Notes";
            this.ColumnNotes.Name = "ColumnNotes";
            this.ColumnNotes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewDisableButtonColumn1
            // 
            this.dataGridViewDisableButtonColumn1.HeaderText = "Apply";
            this.dataGridViewDisableButtonColumn1.Name = "dataGridViewDisableButtonColumn1";
            this.dataGridViewDisableButtonColumn1.Width = 50;
            // 
            // dataGridViewDisableButtonColumn2
            // 
            this.dataGridViewDisableButtonColumn2.HeaderText = "Revert";
            this.dataGridViewDisableButtonColumn2.Name = "dataGridViewDisableButtonColumn2";
            this.dataGridViewDisableButtonColumn2.Width = 50;
            // 
            // cmdCommitChangesToExe
            // 
            this.cmdCommitChangesToExe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCommitChangesToExe.Location = new System.Drawing.Point(825, 70);
            this.cmdCommitChangesToExe.Name = "cmdCommitChangesToExe";
            this.cmdCommitChangesToExe.Size = new System.Drawing.Size(147, 23);
            this.cmdCommitChangesToExe.TabIndex = 9;
            this.cmdCommitChangesToExe.Text = "Commit Changes to Exe";
            this.cmdCommitChangesToExe.UseVisualStyleBackColor = true;
            this.cmdCommitChangesToExe.Click += new System.EventHandler(this.cmdCommitChangesToExe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 361);
            this.Controls.Add(this.cmdCommitChangesToExe);
            this.Controls.Add(this.dataGridViewPatches);
            this.Controls.Add(this.lblACClientExeStatus);
            this.Controls.Add(this.cmdCreateBackup);
            this.Controls.Add(this.cmdRestoreFromBackup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdLocateACClientExe);
            this.Controls.Add(this.txtACClientExeLocation);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Form1";
            this.Text = "Mag-AC Client Patcher";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtACClientExeLocation;
        private System.Windows.Forms.Button cmdLocateACClientExe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdRestoreFromBackup;
        private System.Windows.Forms.Button cmdCreateBackup;
        private System.Windows.Forms.Label lblACClientExeStatus;
        private System.Windows.Forms.DataGridView dataGridViewPatches;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPatchState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNotes;
        private DataGridViewHelpers.DataGridViewDisableButtonColumn ColumnApply;
        private DataGridViewHelpers.DataGridViewDisableButtonColumn ColumnRevert;
        private DataGridViewHelpers.DataGridViewDisableButtonColumn dataGridViewDisableButtonColumn1;
        private DataGridViewHelpers.DataGridViewDisableButtonColumn dataGridViewDisableButtonColumn2;
        private System.Windows.Forms.Button cmdCommitChangesToExe;
    }
}

