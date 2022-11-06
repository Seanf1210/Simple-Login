Public Class Form1
    'Project Simple Login
    'Author Sean Farkas
    'Version 1.0
    'Created: 2022-11-02
    'Description
    ' The Simple login project uses hard coded IDs and Passwords to
    ' authenticate the user and if the creditenals do not matcth then
    ' the program runs through a process to reset the password

    'Lines 12-21 Create the variables that will be used throughout the form
    Dim mother As String = "Smith"     'Variable for mothers maiden name
    Dim petName As String = "Dog"       'Variable for dogs name
    'Hard coded user ID and password for users
    Dim ID1 As String = "Emily.LostID"
    Dim ID2 As String = "George.HammingItUp"
    Dim ID3 As String = "Peter.Pumpkin"
    Dim ID4 As String = "Anna.Banana"
    Dim PWD As Integer = 1234
    'Variable to keep track of attempts
    Dim attempts As Integer = 0

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'After the button is clicked the login function will run determining if the username
        'and password match. If not the attempt counter goes up to three then begins the authentication
        'process
        login(txtUserID.Text, Integer.Parse(txtPW.Text))
        If attempts = 3 Then
            'Disable the main form to prevent user to keep attempting to login
            Me.Enabled = False
            If (checkMomName() = True) And (checkPetName() = True) Then
                'This If loop uses two functions to verify authentication questions if the are
                'wrong the program will terminate
                If (resetPass() = True) Then
                    'This If loop executes after the security questions are properly answererd
                    'allowing usering to reset password and attempt to log back in and resets the attempts
                    Me.Enabled = True
                    lblAttempts.Text = "Attempts"
                    attempts = 0
                End If
            End If
        End If
    End Sub

    Private Function login(ByVal USERID As String, ByVal PASSWORD As Integer) As Boolean
        'this function is used to validate user ID and password using a case statement
        Dim success As Boolean = False
        Select Case USERID
            Case ID1
                If PASSWORD = PWD Then
                    'If user ID and Password are valid login is successful
                    Form2.Show()
                Else
                    'This section resets text boxes and increases the attempt counter
                    MessageBox.Show("Wrong ID or Password")
                    attempts = attempts + 1
                    txtUserID.Text = ""
                    txtPW.Text = ""
                    lblAttempts.Text = "Attempts:" & attempts
                End If
            Case ID2
                If PASSWORD = PWD Then
                    'If user ID and Password are valid login is successful
                    Form2.Show()
                Else
                    'This section resets text boxes and increases the attempt counter
                    MessageBox.Show("Wrong ID or Password")
                    attempts = attempts + 1
                    txtUserID.Text = ""
                    txtPW.Text = ""
                    lblAttempts.Text = "Attempts:" & attempts
                End If
            Case ID3
                If PASSWORD = PWD Then
                    'If user ID and Password are valid login is successful
                    Form2.Show()
                Else
                    'This section resets text boxes and increases the attempt counter
                    MessageBox.Show("Wrong ID or Password")
                    attempts = attempts + 1
                    txtUserID.Text = ""
                    txtPW.Text = ""
                    lblAttempts.Text = "Attempts:" & attempts
                End If
            Case ID4
                If PASSWORD = PWD Then
                    'If user ID and Password are valid login is successful
                    Form2.Show()
                Else
                    'This section resets text boxes and increases the attempt counter
                    MessageBox.Show("Wrong ID or Password")
                    attempts = attempts + 1
                    txtUserID.Text = ""
                    txtPW.Text = ""
                    lblAttempts.Text = "Attempts:" & attempts
                End If
            Case Else
                'This section is used if a improper user ID is used and resets the form not adding
                'to the attempt conter
                MessageBox.Show("User ID Does not exist!")
                txtUserID.Text = ""
                txtPW.Text = ""
        End Select
    End Function

    Private Function checkMomName() As Boolean
        'This function valdiates the security question and will terminate the program if the
        'answer is wrong
        Dim success As Boolean = False
        Dim name As String = InputBox("Mothers's maiden name?", "Authentication Question 1",)
        If mother = name Then
            success = True
        Else
            success = False
            MessageBox.Show("Wrong Answer Closing Portal", "Authentication Error")
            Me.Close()
        End If
        Return success
        'returns the boolean to the button click function used in the IF loop
    End Function

    Private Function checkPetName() As Boolean
        'This function valdiates the security question and will terminate the program if the
        'answer is wrong
        Dim success As Boolean = False
        Dim name As String = InputBox("Pet's First Name?", "Authentication Question 2",)
        If petName = name Then
            success = True
        Else
            success = False
            MessageBox.Show("Wrong Answer Closing Portal", "Authentication Error")
            Me.Close()
        End If
        Return success
        'returns the boolean to the button click function used in the IF loop
    End Function

    Private Function resetPass() As Boolean
        'function used to reset the password for the user
        Dim success As Boolean = False
        'uses a loop to ensure the user inputs two passwords that match else
        'the will have to keep entering and re-entering a new password until they match
        Do
            Dim newPassOne As String = InputBox("Enter new Password(Numbers Only)", "Password Reset")
            Dim Passrepeat As String = InputBox("Repeat Password(Numbers Only)", "Repeat Password")

            If newPassOne = Passrepeat Then
                success = True
                PWD = newPassOne
                MessageBox.Show("Password has been reset!", "Congrats!")
            Else
                success = False
                MessageBox.Show("Passwords do not match!", "Password Error")
            End If
        Loop Until success = True
        Return success
    End Function
End Class
