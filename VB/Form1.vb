Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace WindowsFormsApplication1

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim report As XtraReport1 = New XtraReport1()
            Dim tool As ReportPrintTool = New ReportPrintTool(report)
            tool.ShowPreviewDialog()
        End Sub
    End Class
End Namespace
