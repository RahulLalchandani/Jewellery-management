Imports System.Data.OleDb
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient

Public Class adminHome

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AdminToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem1.Click
        Me.Hide()
        Dim adminHome As New adminHome
        adminHome.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim registerCustomer As New CustomerRegister
        registerCustomer.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Dim result As String

        result = InputBox("Enter Id", "Supplier Deletion") 'The variable is assigned the value entered in the InputBox
        Try
            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\jewellerymanagementsystem\jewel.accdb;")
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

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        Me.Hide()
        Dim supplierRegister As New supplierRegister
        supplierRegister.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Version 0.1", "About", _
         MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub adminHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SuppliersViewData.suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.SuppliersViewData.suppliers)
        'TODO: This line of code loads data into the 'JewelDataSet1.admins' table. You can move, or remove it, as needed.
        Try
            Me.AdminsTableAdapter.FillBy(Me.JewelDataSet1.admins)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


       

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            Me.SuppliersTableAdapter.Fill(Me.SuppliersViewData.suppliers)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        Dim loginAdmin As New adminLogin
        loginAdmin.Show()
    End Sub

    Private Sub FillToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles FillToolStrip.ItemClicked

    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
