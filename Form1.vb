Public Class Form1
    Private num As Integer
    Private shawn As String
    Private kamo As String
    Private letssee As String
    Private ayeye As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Update on code")


        num = CInt(InputBox("please give the number ?"))

        shawn = InputBox("what is the name:")


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "Update"
    End Sub
End Class
