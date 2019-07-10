<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class supplierViewProduct
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.JewelDataSet = New jewellerymanagementsystem.jewelDataSet()
        Me.JewelDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuppliersViewData = New jewellerymanagementsystem.SuppliersViewData()
        Me.AdminsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JewelDataSet1 = New jewellerymanagementsystem.jewelDataSet1()
        Me.AdminsTableAdapter = New jewellerymanagementsystem.jewelDataSet1TableAdapters.adminsTableAdapter()
        Me.SuppliersTableAdapter = New jewellerymanagementsystem.SuppliersViewDataTableAdapters.suppliersTableAdapter()
        Me.SupplierViewProducts = New jewellerymanagementsystem.supplierViewProducts()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New jewellerymanagementsystem.supplierViewProductsTableAdapters.productsTableAdapter()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ProductsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Productswithimagepath = New jewellerymanagementsystem.productswithimagepath()
        Me.ProductsTableAdapter1 = New jewellerymanagementsystem.productswithimagepathTableAdapters.productsTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hallmark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ptype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pweight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ppurity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pwarranty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barcodeno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.imagePath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.JewelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JewelDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersViewData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JewelDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierViewProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillToolStrip.SuspendLayout()
        CType(Me.ProductsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Productswithimagepath, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Mistral", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(0, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Label1.Size = New System.Drawing.Size(824, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jewellery Management System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(824, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem1, Me.ToolStripMenuItem2, Me.SupplierToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.ToolStripMenuItem1, Me.LogOutToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(72, 22)
        Me.AdminToolStripMenuItem.Text = "Operation"
        '
        'AdminToolStripMenuItem1
        '
        Me.AdminToolStripMenuItem1.Name = "AdminToolStripMenuItem1"
        Me.AdminToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.AdminToolStripMenuItem1.Text = "View Orders"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(157, 22)
        Me.ToolStripMenuItem2.Text = "View Products"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.SupplierToolStripMenuItem.Text = "Add Product"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CustomerToolStripMenuItem.Text = "Delete Product"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.ToolStripMenuItem1.Text = "Update Product"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Mistral", 16.0!)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(0, 72)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Label2.Size = New System.Drawing.Size(824, 39)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "View Products"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'JewelDataSet
        '
        Me.JewelDataSet.DataSetName = "jewelDataSet"
        Me.JewelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JewelDataSetBindingSource
        '
        Me.JewelDataSetBindingSource.DataSource = Me.JewelDataSet
        Me.JewelDataSetBindingSource.Position = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.hallmark, Me.ptype, Me.pname, Me.pweight, Me.ppurity, Me.pprice, Me.pwarranty, Me.barcodeno, Me.imagePath})
        Me.DataGridView1.DataSource = Me.ProductsBindingSource1
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(0, 151)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.Size = New System.Drawing.Size(804, 372)
        Me.DataGridView1.TabIndex = 5
        '
        'SuppliersBindingSource
        '
        Me.SuppliersBindingSource.DataMember = "suppliers"
        Me.SuppliersBindingSource.DataSource = Me.SuppliersViewData
        '
        'SuppliersViewData
        '
        Me.SuppliersViewData.DataSetName = "SuppliersViewData"
        Me.SuppliersViewData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdminsBindingSource
        '
        Me.AdminsBindingSource.DataMember = "admins"
        Me.AdminsBindingSource.DataSource = Me.JewelDataSet1
        '
        'JewelDataSet1
        '
        Me.JewelDataSet1.DataSetName = "jewelDataSet1"
        Me.JewelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdminsTableAdapter
        '
        Me.AdminsTableAdapter.ClearBeforeFill = True
        '
        'SuppliersTableAdapter
        '
        Me.SuppliersTableAdapter.ClearBeforeFill = True
        '
        'SupplierViewProducts
        '
        Me.SupplierViewProducts.DataSetName = "supplierViewProducts"
        Me.SupplierViewProducts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "products"
        Me.ProductsBindingSource.DataSource = Me.SupplierViewProducts
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 111)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(824, 25)
        Me.FillToolStrip.TabIndex = 6
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(26, 22)
        Me.FillToolStripButton.Text = "Fill"
        '
        'ProductsBindingSource1
        '
        Me.ProductsBindingSource1.DataMember = "products"
        Me.ProductsBindingSource1.DataSource = Me.Productswithimagepath
        '
        'Productswithimagepath
        '
        Me.Productswithimagepath.DataSetName = "productswithimagepath"
        Me.Productswithimagepath.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsTableAdapter1
        '
        Me.ProductsTableAdapter1.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'hallmark
        '
        Me.hallmark.DataPropertyName = "hallmark"
        Me.hallmark.HeaderText = "hallmark"
        Me.hallmark.Name = "hallmark"
        Me.hallmark.ReadOnly = True
        '
        'ptype
        '
        Me.ptype.DataPropertyName = "ptype"
        Me.ptype.HeaderText = "ptype"
        Me.ptype.Name = "ptype"
        Me.ptype.ReadOnly = True
        '
        'pname
        '
        Me.pname.DataPropertyName = "pname"
        Me.pname.HeaderText = "pname"
        Me.pname.Name = "pname"
        Me.pname.ReadOnly = True
        '
        'pweight
        '
        Me.pweight.DataPropertyName = "pweight"
        Me.pweight.HeaderText = "pweight"
        Me.pweight.Name = "pweight"
        Me.pweight.ReadOnly = True
        '
        'ppurity
        '
        Me.ppurity.DataPropertyName = "ppurity"
        Me.ppurity.HeaderText = "ppurity"
        Me.ppurity.Name = "ppurity"
        Me.ppurity.ReadOnly = True
        '
        'pprice
        '
        Me.pprice.DataPropertyName = "pprice"
        Me.pprice.HeaderText = "pprice"
        Me.pprice.Name = "pprice"
        Me.pprice.ReadOnly = True
        '
        'pwarranty
        '
        Me.pwarranty.DataPropertyName = "pwarranty"
        Me.pwarranty.HeaderText = "pwarranty"
        Me.pwarranty.Name = "pwarranty"
        Me.pwarranty.ReadOnly = True
        '
        'barcodeno
        '
        Me.barcodeno.DataPropertyName = "barcodeno"
        Me.barcodeno.HeaderText = "barcodeno"
        Me.barcodeno.Name = "barcodeno"
        Me.barcodeno.ReadOnly = True
        '
        'imagePath
        '
        Me.imagePath.DataPropertyName = "imagePath"
        Me.imagePath.HeaderText = "imagePath"
        Me.imagePath.Name = "imagePath"
        Me.imagePath.ReadOnly = True
        '
        'supplierViewProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(824, 570)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "supplierViewProduct"
        Me.Text = "Jewellery Management System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.JewelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JewelDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersViewData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JewelDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierViewProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        CType(Me.ProductsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Productswithimagepath, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents JewelDataSet As jewellerymanagementsystem.jewelDataSet
    Friend WithEvents JewelDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JewelDataSet1 As jewellerymanagementsystem.jewelDataSet1
    Friend WithEvents AdminsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdminsTableAdapter As jewellerymanagementsystem.jewelDataSet1TableAdapters.adminsTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SuppliersViewData As jewellerymanagementsystem.SuppliersViewData
    Friend WithEvents SuppliersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SuppliersTableAdapter As jewellerymanagementsystem.SuppliersViewDataTableAdapters.suppliersTableAdapter
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierViewProducts As jewellerymanagementsystem.supplierViewProducts
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As jewellerymanagementsystem.supplierViewProductsTableAdapters.productsTableAdapter
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Productswithimagepath As jewellerymanagementsystem.productswithimagepath
    Friend WithEvents ProductsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter1 As jewellerymanagementsystem.productswithimagepathTableAdapters.productsTableAdapter
    Friend WithEvents FillToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hallmark As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ptype As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pweight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ppurity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pprice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pwarranty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents barcodeno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents imagePath As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
