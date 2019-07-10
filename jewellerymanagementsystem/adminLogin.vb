Imports System.Text.RegularExpressions
Imports System.Data.OleDb




Public Class adminLogin
    Private EmailValid As Boolean
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub ValidateEmail()

        'Set Up Reg Exp Pattern To Allow Most Characters, And No Special Characters
        Dim reEmail As Regex = New Regex("([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\." + _
        ")|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})", _
        RegexOptions.IgnoreCase _
        Or RegexOptions.CultureInvariant _
        Or RegexOptions.IgnorePatternWhitespace _
        Or RegexOptions.Compiled _
        )

        Dim blnPossibleMatch As Boolean = reEmail.IsMatch(txtEmail.Text)

        If blnPossibleMatch Then

            'Check If Entered Email Is In Correct Format
            If Not txtEmail.Text.Equals(reEmail.Match(txtEmail.Text).ToString) Then

                MessageBox.Show("Invalid Email Address!")

            Else

                EmailValid = True 'Email is Perfect

            End If

        Else 'Not A Match To Pattern

            EmailValid = False 'Set Boolean Variable To False

            MessageBox.Show("Invalid Email Address!") 'Inform User

            txtEmail.Clear() 'Clear Textbox

            txtEmail.Focus() 'Set Focus To TextBox

        End If

    End Sub

    Private Sub txtEmail_LostFocus(sender As Object, e As System.EventArgs) Handles txtEmail.LostFocus

        ValidateEmail() 'Check Email Validity

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub AdminToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem1.Click
        Me.Hide()
        Dim loginAdmin As New adminLogin
        loginAdmin.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim registerCustomer As New CustomerRegister
        registerCustomer.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "C:\jewellerymanagementsystem\jewel.accdb"
        connString = provider & dataFile

        If myConnection.State = ConnectionState.Open Then
            myConnection.Close()
        End If

        myConnection.ConnectionString = connString
        myConnection.Open()

        'the query:
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [admins] WHERE [username] = '" & txtEmail.Text & "' AND [password] = '" & TextBox2.Text & "'", myConnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim userFound As Boolean = False
        ' the following variables will hold the user first and last name if found.
        Dim FirstName As String = ""
        Dim LastName As String = ""

        'if found:
        While dr.Read
            userFound = True
            FirstName = dr("FirstName").ToString
            LastName = dr("LastName").ToString
        End While

        'checking the result
        If userFound = True Then
            Me.Hide()
            adminHome.Show()
            adminHome.Label1.Text = "Welcome " & FirstName & " " & LastName
        Else
            MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid Login")
        End If

    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Me.Hide()
        Dim customerPortal As New CustomerLogin
        customerPortal.Show(Me)
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        Me.Hide()
        Dim loginSupplier As New supplierLogin
        loginSupplier.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Version 0.1", "About", _
        MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

   


    
    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
