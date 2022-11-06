Public Class Form2
    'Project Simple Login
    'Author Sean Farkas
    'Version 1.0
    'Created: 2022-11-02
    'Description
    ' The Simple login project uses hard coded IDs and Passwords to
    ' authenticate the user and if the creditenals do not matcth then
    ' the program runs through a process to reset the password.

    Private Sub btnSuccess_Click(sender As Object, e As EventArgs) Handles btnSuccess.Click
        'This button is used to close the program after a successful login
        Form1.Close()
        Me.Close()
    End Sub
End Class