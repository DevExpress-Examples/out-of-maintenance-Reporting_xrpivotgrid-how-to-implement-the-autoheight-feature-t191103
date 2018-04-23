using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace WindowsFormsApplication1
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
        }
        Graphics gr = Graphics.FromHwnd(IntPtr.Zero);
        private void xrPivotGrid1_CustomRowHeight(object sender, DevExpress.XtraReports.UI.PivotGrid.PivotCustomRowHeightEventArgs e)
        {
            e.RowHeight = 0;
            for (int i = 0; i < e.ColumnCount; i++)
            {
                string value = e.GetRowCellValue(i).ToString();
                SizeF size = gr.MeasureString(value, e.DataField.Appearance.Cell.Font, e.DataField.Width);
                int height = Convert.ToInt32(size.Height + 0.5);
                e.RowHeight = e.RowHeight > height?e.RowHeight : height;
            }
        }

    }
}
