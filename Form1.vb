Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub join_Click(sender As Object, e As EventArgs) Handles join.Click
        Process.Start("D:\Games\GTA San Andreas\samp.exe", "rp.valrisegaming.com:7777 -n" + RichTextBox1.Text)
        Application.Exit()

    End Sub
End Class
