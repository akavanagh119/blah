Public Class YourStyle

    'delcaring variables for shoe prices etc. 
    Dim dblClassic As Double = 54.49
    Dim dblRetro As Double = 49.5
    Dim dblVintage As Double = 44.99
    Dim dblQuarter As Double = 8.99
    Dim dblVamp As Double = 14.99
    Dim dblEyestay As Double = 5
    Dim dblHeel As Double = 4.99
    Dim dblHeelBack As Double = 6.49
    Dim dblLaces As Double = 4
    Dim dblLogo As Double = 0.18
    Dim dblText As Double = 0.45
    Dim dblAddChar As Double = 0.05
    Dim dblVat As Double = 0.23

    Private Sub YourStyle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        FrmCustomisation.Show()
        Me.Hide()
    End Sub
End Class
