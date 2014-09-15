Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click
        Dim x As String
        x = txtFullName.Text

        Dim x2 As String
        x2 = x.Trim()

        Dim space As Integer
        space = x2.IndexOf(" ")

        Dim fstName As String
        fstName = x2.Substring(0, space)

        txtFirstName.Text = fstName

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
