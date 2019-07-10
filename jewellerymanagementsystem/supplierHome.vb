Imports System.Data.OleDb
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient

Public Class supplierHome
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\jewellerymanagementsystem\jewel.accdb;")
    Dim cmd As New OleDbCommand
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
        Dim supplierHome As New supplierHome
        supplierHome.Show()
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

        result = InputBox("Enter Id", "Product Deletion") 'The variable is assigned the value entered in the InputBox
        Try
            

            con.Open()
            cmd.Connection = con

            cmd.CommandText = "DELETE FROM [products] where ID =" & result & ""
            ' System.Windows.Forms.MessageBox.Show(cmd.CommandText)
            cmd.ExecuteNonQuery()
            System.Windows.Forms.MessageBox.Show("Product Deleted")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("Product Deletion Failed.")
        End Try


    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        Me.Hide()
        Dim supplierAddProduct As New supplierAddProduct
        supplierAddProduct.Show()
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
        'TODO: This line of code loads data into the 'OrdersViewsAll.orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter.Fill(Me.OrdersViewsAll.orders)
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

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.SuppliersTableAdapter.Fill(Me.SuppliersViewData.suppliers)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        Dim supplierLogin As New supplierLogin
        supplierLogin.Show()
    End Sub

    Private Sub FillToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Me.Hide()
        Dim supplierViewProduct As New supplierViewProduct
        supplierViewProduct.Show()
    End Sub

    Private Sub FillToolStripButton1_Click(sender As Object, e As EventArgs) Handles FillToolStripButton1.Click
        Try
            Me.OrdersTableAdapter.Fill(Me.OrdersViewsAll.orders)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim result As String

        result = InputBox("Enter Id", "Product Id to Update") 'The variable is assigned the value entered in the InputBox
        Dim price As String
        price = InputBox("Enter New Price", "Product New Price")
        Try
            con.Open()
            cmd.Connection = con

            cmd.CommandText = "UPDATE [products] SET [pprice] ='" & price & "' where ID =" & result & ""
            ' System.Windows.Forms.MessageBox.Show(cmd.CommandText)
            cmd.ExecuteNonQuery()
            System.Windows.Forms.MessageBox.Show("Product Price Updated")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("Product Price Update Failed.")
        End Try
    End Sub
End Class
