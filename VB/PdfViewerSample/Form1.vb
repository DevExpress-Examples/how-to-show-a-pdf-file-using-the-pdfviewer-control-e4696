Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.PdfViewer1.LoadDocument("..\..\Report.pdf")
    End Sub
End Class