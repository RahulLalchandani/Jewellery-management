Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class supplierRegister
    Private EmailValid As Boolean

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim loginCustomer As New CustomerLogin
        loginCustomer.Show()

    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim loginCustomer As New CustomerLogin
        loginCustomer.Show()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim loginSupplier As New supplierLogin
        loginSupplier.Show()
    End Sub

    Private Sub AdminToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim loginAdmin As New adminLogin
        loginAdmin.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Version 0.1", "About", _
         MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\jewellerymanagementsystem\jewel.accdb;")
            Dim cmd As New OleDbCommand

            con.Open()
            cmd.Connection = con

            cmd.CommandText = "INSERT INTO [suppliers]([fullname],[emailid],[password],[address]) VALUES('" & namesupplier.Text & "','" & supplierEmail.Text + "','" & supplierPassword.Text & "','" & supplierAddress.Text & "')"
            ' System.Windows.Forms.MessageBox.Show(cmd.CommandText)
            cmd.ExecuteNonQuery()
            System.Windows.Forms.MessageBox.Show("Supplier Added")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub supplierRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        Dim blnPossibleMatch As Boolean = reEmail.IsMatch(supplierEmail.Text)
        If blnPossibleMatch Then
            'Check If Entered Email Is In Correct Format
            If Not supplierEmail.Text.Equals(reEmail.Match(supplierEmail.Text).ToString) Then
                MessageBox.Show("Invalid Email Address!")
            Else
                EmailValid = True 'Email is Perfect
            End If
        Else 'Not A Match To Pattern
            EmailValid = False 'Set Boolean Variable To False
            MessageBox.Show("Invalid Email Address!") 'Inform User
            supplierEmail.Clear() 'Clear Textbox
            supplierEmail.Focus() 'Set Focus To TextBox
        End If

    End Sub

    Private Sub supplierEmail_TextChanged(sender As Object, e As EventArgs) Handles supplierEmail.LostFocus
        ValidateEmail()
    End Sub

    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Me.Hide()
        Dim adminHome As New adminHome
        adminHome.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Me.Hide()
        Dim supplierRegister As New supplierRegister
        supplierRegister.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        Dim loginAdmin As New adminLogin
        loginAdmin.Show()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        MessageBox.Show("Version 0.1", "About", _
        MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub supplierPassword_TextChanged(sender As Object, e As EventArgs) Handles supplierPassword.TextChanged

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Dim result As String

        result = InputBox("Enter Id", "Supplier Deletion") 'The variable is assigned the value entered in the InputBox
        Try
            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\home\Documents\jewellerymanagementsystem\jewel.accdb;")
            Dim cmd As New OleDbCommand

            con.Open()
            cmd.Connection = con

            cmd.CommandText = "DELETE FROM [suppliers] where ID =" & result & ""
            ' System.Windows.Forms.MessageBox.Show(cmd.CommandText)
            cmd.ExecuteNonQuery()
            System.Windows.Forms.MessageBox.Show("Supplier Deleted")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("Supplier Deletion Failed.")
        End Try
    End Sub
End Class
