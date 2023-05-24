Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UI.PivotGrid

Namespace WindowsFormsApplication1

    Public Partial Class XtraReport1
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private gr As Graphics = Graphics.FromHwnd(IntPtr.Zero)

        Private Sub xrPivotGrid1_CustomRowHeight(ByVal sender As Object, ByVal e As PivotCustomRowHeightEventArgs)
            e.RowHeight = 0
            For i As Integer = 0 To e.ColumnCount - 1
                Dim value As String = e.GetRowCellValue(i).ToString()
                Dim size As SizeF = gr.MeasureString(value, TryCast(e.DataField, XRPivotGridField).Appearance.Cell.Font, e.DataField.Width)
                Dim height As Integer = Convert.ToInt32(size.Height + 0.5)
                e.RowHeight = If(e.RowHeight > height, e.RowHeight, height)
            Next
        End Sub
    End Class
End Namespace
