Public Class Form1
    WithEvents b As Button

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        b = New Button

        b.Size = New Size(75, 23)
        b.Location = New Point(10, 10)
        b.Text = "clique aqui"

        Controls.Add(b)
    End Sub

    Private Sub B_Click(ByVal sender As Object, ByVal e As EventArgs) Handles b.Click
        MessageBox.Show("Hello World")
    End Sub
End Class
