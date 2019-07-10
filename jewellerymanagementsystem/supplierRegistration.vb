Public Class CustomerRegister


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim loginCustomer As New CustomerLogin
        loginCustomer.Show()

    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Me.Hide()
        Dim loginCustomer As New CustomerLogin
        loginCustomer.Show()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        Me.Hide()
        Dim loginSupplier As New supplierLogin
        loginSupplier.Show()
    End Sub

    Private Sub AdminToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem1.Click
        Me.Hide()
        Dim loginAdmin As New adminLogin
        loginAdmin.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Version 0.1", "About", _
         MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub
End Class
