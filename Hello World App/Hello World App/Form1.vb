Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        RadioButton1.Checked = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TabPage1.BackColor = Color.White
        TabPage1.ForeColor = Color.Black
        TabPage2.BackColor = Color.White
        TabPage2.ForeColor = Color.Black
        TabPage3.BackColor = Color.White
        TabPage3.ForeColor = Color.Black
        Panel1.BackColor = Drawing.Color.FromArgb(255, 255, 255)
        Label2.ForeColor = Drawing.Color.FromArgb(24, 24, 24)
        Label2.BackColor = Drawing.Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TabPage1.BackColor = Drawing.Color.FromArgb(24, 24, 24)
        TabPage1.ForeColor = Color.White
        TabPage2.BackColor = Drawing.Color.FromArgb(24, 24, 24)
        TabPage2.ForeColor = Color.White
        TabPage3.BackColor = Drawing.Color.FromArgb(24, 24, 24)
        TabPage3.ForeColor = Color.White
        Label2.ForeColor = Color.White
        Label2.BackColor = Drawing.Color.FromArgb(24, 24, 24)
        Panel1.BackColor = Drawing.Color.FromArgb(24, 24, 24)
        Panel1.ForeColor = Drawing.Color.FromArgb(255, 255, 255)
        Panel1.BackColor = Drawing.Color.FromArgb(24, 24, 24)
        Label2.ForeColor = Drawing.Color.FromArgb(255, 255, 255)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
