using System.Windows.Forms;

namespace Mag_ACClientPatcher.DataGridViewHelpers
{
    class DataGridViewDisableButtonColumn : DataGridViewButtonColumn
    {
        public DataGridViewDisableButtonColumn()
        {
            CellTemplate = new DataGridViewDisableButtonCell();
        }
    }
}
