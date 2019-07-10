Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Public Class CustomerLogin
    Private EmailValid As Boolean
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
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
        Dim adminPortal As New adminLogin
        adminPortal.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [customers] WHERE [email] = '" & TextBox1.Text & "' AND [password] = '" & TextBox2.Text & "'", myConnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim userFound As Boolean = False
        ' the following variables will hold the user first and last name if found.
        Dim customername As String = ""
        Dim address As String = ""
        Dim userid As String = ""
        'if found:
        While dr.Read
            userFound = True
            customername = dr("customername").ToString
            address = dr("address").ToString
            userid = dr("email").ToString

        End While

        'checking the result
        If userFound = True Then
            Me.Hide()
            customerSales.Show()
            customerSales.userid = userid
            customerSales.customername = customername
            customerSales.address = address
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
        Dim supplierPortal As New supplierLogin
        supplierPortal.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("version 0.1")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        ToolStripProgressBar1.Value = 20
        ValidateEmail()
        ToolStripProgressBar1.Value = 100

    End Sub
   

    Private Sub ValidateEmail()
        'Set Up Reg Exp Pattern To Allow Most Characters, And No Special Characters
        Dim reEmail As Regex = New Regex("([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\." + _
        ")|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})", _
        RegexOptions.IgnoreCase _
        Or RegexOptions.CultureInvariant _
        Or RegexOptions.IgnorePatternWhitespace _
        Or RegexOptions.Compiled _
        )

        Dim blnPossibleMatch As Boolean = reEmail.IsMatch(TextBox1.Text)

        If blnPossibleMatch Then
            'Check If Entered Email Is In Correct Format
            If Not TextBox1.Text.Equals(reEmail.Match(TextBox1.Text).ToString) Then
                MessageBox.Show("Invalid Email Address!")
            Else
                EmailValid = True 'Email is Perfect
            End If
        Else 'Not A Match To Pattern
            EmailValid = False 'Set Boolean Variable To False
            MessageBox.Show("Invalid Email Address!") 'Inform User
            TextBox1.Clear() 'Clear Textbox
            TextBox1.Focus() 'Set Focus To TextBox

        End If
    End Sub

    Private Sub ToolStripProgressBar1_Click(sender As Object, e As EventArgs) Handles ToolStripProgressBar1.Click

    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub
End Class
