Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class supplierAddProduct
    Private EmailValid As Boolean
    Dim bytImage() As Byte
    Dim imagePath As String
    Dim dialog As New OpenFileDialog()
    Dim sFileName As String
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\jewellerymanagementsystem\jewel.accdb;")
    Dim cmd As New OleDbCommand
    Dim result As String

   


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
            Dim ms As New System.IO.MemoryStream
            Dim bmpImage As New Bitmap(PictureBox2.Image)

            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            bytImage = ms.ToArray()
            ms.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try

            con.Open()
            cmd.Connection = con

            ' Load File IN
            My.Computer.FileSystem.WriteAllBytes("C:\jewellerymanagementsystem\jewellerymanagementsystem\UploadedImages\" & sFileName, bytImage, False)


            ' END LOAD OF FILE
            cmd.CommandText = "INSERT INTO [products]([ptype],[pname],[pweight],[ppurity],[pprice],[pwarranty],[barcodeno],[imagePath],[hallmark]) VALUES('" & ptype.Text & "','" & pname.Text + "','" & pweight.Text & "','" & ppurity.Text & "','" & pprice.Text & "','" & pwarranty.Text & "','" & barcodeno.Text & "','" & sFileName.ToString & "','" & hallmarkID.Text & "')"
            'cmd.CommandText = "INSERT INTO [products]([Field1]) VALUES( @image)"
            'cmd.Parameters.AddWithValue("@image", bytImage)
            System.Windows.Forms.MessageBox.Show(cmd.CommandText)
            cmd.ExecuteNonQuery()
            System.Windows.Forms.MessageBox.Show("Products Added")
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

        Dim blnPossibleMatch As Boolean = reEmail.IsMatch(pname.Text)
        If blnPossibleMatch Then
            'Check If Entered Email Is In Correct Format
            If Not pname.Text.Equals(reEmail.Match(pname.Text).ToString) Then
                MessageBox.Show("Invalid Email Address!")
            Else
                EmailValid = True 'Email is Perfect
            End If
        Else 'Not A Match To Pattern
            EmailValid = False 'Set Boolean Variable To False
            MessageBox.Show("Invalid Email Address!") 'Inform User
            pname.Clear() 'Clear Textbox
            pname.Focus() 'Set Focus To TextBox
        End If

    End Sub

    Private Sub supplierEmail_TextChanged(sender As Object, e As EventArgs) Handles pname.LostFocus

    End Sub

    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim adminHome As New adminHome
        adminHome.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim supplierRegister As New supplierRegister
        supplierRegister.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim loginAdmin As New adminLogin
        loginAdmin.Show()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Version 0.1", "About", _
        MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub supplierPassword_TextChanged(sender As Object, e As EventArgs) Handles pweight.TextChanged

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs)
        Dim result As String

        result = InputBox("Enter Id", "Supplier Deletion") 'The variable is assigned the value entered in the InputBox
        Try
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        dialog.Title = "Browse Picture"
        dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox2.Image = Image.FromFile(dialog.FileName)
            sFileName = System.IO.Path.GetFileName(dialog.FileName)
            'MessageBox.Show(sFileName)

        End If
        imagePath = dialog.FileName.ToString
    End Sub

    Private Sub FileSystemWatcher1_Changed(sender As Object, e As IO.FileSystemEventArgs) Handles FileSystemWatcher1.Changed

    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        Me.Hide()
        Dim supplierViewProduct As New supplierViewProduct
        supplierViewProduct.Show()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        Me.Hide()
        Dim supplierAddProduct As New supplierAddProduct
        supplierAddProduct.Show()
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        Me.Hide()
        Dim supplierLogin As New supplierLogin
        supplierLogin.Show()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
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

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        result = InputBox("Enter Id", "Product Price Update") 'The variable is assigned the value entered in the InputBox
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
End Class
