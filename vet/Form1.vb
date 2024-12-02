Public Class Form1

    Dim CurWidth As Integer = Me.Width
    Dim CuRHeight As Integer = Me.Height

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If (Me.Height < 489) Then
            Exit Sub
        End If

        Dim RatioHeight As Double = (Me.Height - CuRHeight) / CuRHeight
        Dim RatioWidth As Double = (Me.Width - CurWidth) / CurWidth

        For Each CtrL As Control In Controls
            CtrL.Width += CtrL.Width * RatioWidth
            CtrL.Left += CtrL.Left * RatioWidth
            CtrL.Top += CtrL.Top * RatioHeight
            CtrL.Height += CtrL.Height * RatioHeight
        Next

        CuRHeight = Me.Height
        CurWidth = Me.Width
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
