Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class customerSales
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\jewellerymanagementsystem\jewel.accdb;")
    Dim cmd As New OleDbCommand
    Public userid As String
    Public customername As String
    Public customeremail As String
    Public address As String
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Public dict As Dictionary(Of Integer, Decimal) = New Dictionary(Of Integer, Decimal)
    Public dictProductName As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)
    Public gross As Decimal
    Public devitCardNo As New TextBox
    Public cvvTB As New TextBox
    Dim f As New Form()
    Public ImageP As String = "C:/jewellerymanagementsystem/jewellerymanagementsystem/UploadedImages/"

    Private Sub Label3_Click(sender As Object, e As EventArgs)

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

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        Me.Hide()
        Dim customerLogin As New CustomerLogin
        customerLogin.Show()
    End Sub

    Private Sub AdminToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem1.Click
        Me.Hide()
        Dim customerSales As New customerSales
        customerSales.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Version 0.1", "About", _
         MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        
    End Sub
  
    Private Sub CustomerRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As String
        'TODO: This line of code loads data into the 'JewelDataSet1.admins' table. You can move, or remove it, as needed.
        Me.AdminsTableAdapter.Fill(Me.JewelDataSet1.admins)
        t = "<html style='background-color:#ffc0c0;'><body>" & _
       "<table><tr style='background-color:#000; color:#fff; padding:3px;'><th>ID</th><th>Type</th><th>Name</th><th>Weight</th><th>Purity</th><th>Price</th><th>Warranty</th><th>Barcode</th><th>Image</th></tr>"

        'InjectScript(My.Computer.FileSystem.ReadAllText("C:\Users\home\Downloads\Simple-Shopping-Cart-Plugin-With-jQuery-Bootstrap-mycart\js\jquery-2.2.3.min.js".ToString))
        'WebBrowser1.Navigate("C:\Users\home\Downloads\Simple-Shopping-Cart-Plugin-With-jQuery-Bootstrap-mycart\index.html")
        'WebBrowser1.Document.InvokeScript("C:\Users\home\Downloads\Simple-Shopping-Cart-Plugin-With-jQuery-Bootstrap-mycart\js\jquery-2.2.3.min.js")
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "C:\jewellerymanagementsystem\jewel.accdb"

        connString = provider & dataFile

        If myConnection.State = ConnectionState.Open Then
            myConnection.Close()
        End If

        myConnection.ConnectionString = connString
        myConnection.Open()

        'the query:
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [products]", myConnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found

        Dim FirstName As String = ""
        Dim address As String = ""

        'if found:
        Dim ID, ptype, pname, pweight, ppurity, pprice, pwarranty, barcodeno, imagePath As String


        While dr.Read
            ID = dr("ID").ToString
            ptype = dr("ptype").ToString
            pname = dr("pname").ToString
            pweight = dr("pweight").ToString
            ppurity = dr("ppurity").ToString
            pprice = dr("pprice").ToString
            pwarranty = dr("pwarranty").ToString
            barcodeno = dr("barcodeno").ToString
            imagePath = dr("imagePath").ToString
            t += "<tr><td style='padding:5px;'>" & ID & "</td><td style='padding:5px;'>" & ptype & "</td><td style='padding:5px;'>" & pname & "</td><td style='padding:5px;'>" & pweight & "</td><td style='padding:5px;'>" & ppurity & "</td><td style='padding:5px;'>" & pprice & "</td><td style='padding:5px;'>" & pwarranty & "</td><td style='padding:5px;'>" & barcodeno & "</td><td style='padding:5px;'><img  width=100 height=100 src='" & ImageP & imagePath & "'></td><td></tr>"
            dict.Add(ID, CDec(pprice))
            dictProductName.Add(ID, pname)
        End While


        WebBrowser1.DocumentText = t


    End Sub

    
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cartId As Integer
        Try
            cartId = CInt(InputBox("Please Enter the id of item to add", "Cart"))
            If cartId = vbNullString Then
                'MsgBox("User canceled!")
            Else
                ListView1.Items.Add(dictProductName(CInt(cartId)))
                'MessageBox.Show(dict(CInt(cartId)).ToString())
                gross += CDec(dict(CInt(cartId)))
                Label5.Text = gross
            End If
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        If Me.ListView1.SelectedItems.Count > 0 Then
            Dim lvi As ListViewItem = Me.ListView1.SelectedItems(0)
            ListView1.Items.Remove(lvi)
            MessageBox.Show(lvi.Text.ToString)
            Dim pair As KeyValuePair(Of Integer, String)
            Dim foundItemId As Integer
            For Each pair In dictProductName
                If pair.Value.ToString = lvi.Text.ToString Then
                    foundItemId = pair.Key
                End If
            Next
            'MessageBox.Show(foundItemId)
            'MessageBox.Show(dict(foundItemId))
            'MessageBox.Show(CDec(dict(foundItemId)))
            Label5.Text = CDec(Label5.Text) - CDec(dict(foundItemId))

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListView1.Items.Clear()
        gross = 0.0
        Label5.Text = gross
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        f.Size = New Point(400, 300)
        Dim MyTextbox As New Label
        MyTextbox.Text = "Make Payment"
        With MyTextbox
            .Size = New Point(100, 20)
            .Location = New Point(20, 20)
        End With
        f.Controls.Add(MyTextbox)

        Dim PriceLabel As New Label
        With PriceLabel
            .Size = New Point(180, 20)
            .Location = New Point(20, 40)
        End With
        PriceLabel.Text = "Total Billable Amount: "
        f.Controls.Add(PriceLabel)

        Dim PriceValue As New TextBox
        PriceValue.Text = gross
        With PriceValue
            .Size = New Point(100, 20)
            .Location = New Point(200, 40)
        End With
        PriceValue.ReadOnly = True
        f.Controls.Add(PriceValue)

        ' Debit Details
        Dim debitDetail As New Label
        debitDetail.Text = "Enter Your Card Details"
        With debitDetail
            .Size = New Point(180, 20)
            .Location = New Point(20, 60)
        End With
        f.Controls.Add(debitDetail)

        Dim debitCardNo As New Label
        With debitCardNo
            .Size = New Point(180, 20)
            .Location = New Point(20, 80)
        End With
        debitCardNo.Text = "Enter Your Card Number "
        f.Controls.Add(debitCardNo)


        With devitCardNo
            .Size = New Point(100, 20)
            .Location = New Point(200, 80)
        End With
        devitCardNo.MaxLength = 12
        f.Controls.Add(devitCardNo)

        'CVV
        Dim cvvLabel As New Label
        With cvvLabel
            .Size = New Point(180, 20)
            .Location = New Point(20, 100)
        End With
        cvvLabel.Text = "Enter Your CVV Number "
        f.Controls.Add(cvvLabel)


        With cvvTB
            .Size = New Point(100, 20)
            .Location = New Point(200, 100)
        End With
        cvvTB.MaxLength = 3
        cvvTB.PasswordChar = "*"
        f.Controls.Add(cvvTB)


        Dim subSales As New Button
        With subSales
            .Size = New Point(100, 20)
            .Location = New Point(20, 140)
        End With

        subSales.Text = "Purchase"
        f.Controls.Add(subSales)

        AddHandler subSales.Click, AddressOf handlePurchase



        f.ShowDialog(Me)
    End Sub

    Public Sub handlePurchase()
        Try
            Dim a As Decimal = CDec(cvvTB.Text)
            Dim b As Decimal = CDec(devitCardNo.Text)
        
        If Len(devitCardNo.Text) = 12 And Len(cvvTB.Text) = 3 Then
            f.Close()

            Dim strItem As String = ""
            Dim docTextBill As String = ""
            Try
                con.Open()
                cmd.Connection = con


                For Each item As ListViewItem In ListView1.Items
                    strItem = strItem & CStr(item.Text.ToString)
                    'System.Windows.Forms.MessageBox.Show(item.Text.ToString)
                Next
                'System.Windows.Forms.MessageBox.Show(strItem)
                cmd.CommandText = "INSERT INTO [orders]([items],[grossprice],[address],[shipto],[dateTime],[status]) VALUES('" & strItem & "','" & CStr(gross) + "','" & address & "','" & userid & "','" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "','placed')"
                'System.Windows.Forms.MessageBox.Show(cmd.CommandText)
                cmd.ExecuteNonQuery()


                    docTextBill = "<!doctype html><html><head> <meta charset='utf-8'> <title>Invoice</title> <style>.invoice-box{max-width:800px; margin:auto; padding:30px; border:1px solid #eee; box-shadow:0 0 10px rgba(0, 0, 0, .15); font-size:16px; line-height:24px; font-family:'Helvetica Neue', 'Helvetica', Helvetica, Arial, sans-serif; color:#555;}.invoice-box table{width:100%; line-height:inherit; text-align:left;}.invoice-box table td{padding:5px; vertical-align:top;}.invoice-box table tr td:nth-child(2){text-align:right;}.invoice-box table tr.top table td{padding-bottom:20px;}.invoice-box table tr.top table td.title{font-size:45px; line-height:45px; color:#333;}.invoice-box table tr.information table td{padding-bottom:40px;}.invoice-box table tr.heading td{background:#eee; border-bottom:1px solid #ddd; font-weight:bold;}.invoice-box table tr.details td{padding-bottom:20px;}.invoice-box table tr.item td{border-bottom:1px solid #eee;}.invoice-box table tr.item.last td{border-bottom:none;}.invoice-box table tr.total td:nth-child(2){border-top:2px solid #eee; font-weight:bold;}@media only screen and (max-width: 600px){.invoice-box table tr.top table td{width:100%; display:block; text-align:center;}.invoice-box table tr.information table td{width:100%; display:block; text-align:center;}}</style></head><body> <div class='invoice-box'> <table cellpadding='0' cellspacing='0'> <tr class='top'> <td colspan='2'> <table> <tr> <td class='title'><img src='" & ImageP & "logo.jpg' width=200 height=150 style='margin-right:20px;'> </td><td> Invoice #: <br>Created:" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & _
                    "<br></td></tr></table> </td></tr><tr class='information'> <td colspan='2'> <table> <tr> <td>" & userid & "<br>" & address & "<br></td>" & _
                    "<td> Nirmal Jewellers Pvt Ltd.<br>UNR 2. 400 093<br>sales@nirmal.com </td></tr></table> </td></tr><tr class='heading'> <td> Payment Method </td><td> Online # </td></tr><tr class='details'> <td> Debit / Credit </td><td>" & gross & "</td></tr><tr class='heading'> <td> Item </td><td> Price </td></tr>" & _
                    ""
                For Each item As ListViewItem In ListView1.Items
                    docTextBill = docTextBill & "<tr class='item'> <td>" & CStr(item.Text.ToString)

                    Dim pair As KeyValuePair(Of Integer, String)
                    Dim foundItemId As Integer
                    For Each pair In dictProductName
                        If pair.Value.ToString = CStr(item.Text.ToString) Then
                            foundItemId = pair.Key
                        End If
                    Next

                    docTextBill = docTextBill & " </td><td>" & dict(foundItemId).ToString

                Next

                docTextBill = docTextBill & " <tr class='total'> <td></td><td>Total: INR " & gross
                docTextBill = docTextBill & "</td></tr><tr class='total'> <td></td><td> <input type='button' value='Print Invoice' onclick='window.print();'> </td></tr></table> </div></body></html>"

                WebBrowser1.DocumentText = docTextBill

                ListView1.Items.Clear()
                Label5.Text = "0.0"
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try





        Else
            MessageBox.Show("Please Fill Out The Correct Details")
        End If
        Catch ex As Exception
            MessageBox.Show("Please Fill Out The Correct Details")
        End Try

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub
End Class
