<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
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
        Me.lbDisplay = New System.Windows.Forms.Label()
        Me.lvwCar = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.tbModel = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lbDisplay
        '
        Me.lbDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbDisplay.Location = New System.Drawing.Point(40, 380)
        Me.lbDisplay.Name = "lbDisplay"
        Me.lbDisplay.Size = New System.Drawing.Size(330, 60)
        Me.lbDisplay.TabIndex = 20
        '
        'lvwCar
        '
        Me.lvwCar.CheckBoxes = True
        Me.lvwCar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colID, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvwCar.FullRowSelect = True
        Me.lvwCar.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCar.Location = New System.Drawing.Point(2, 133)
        Me.lvwCar.MultiSelect = False
        Me.lvwCar.Name = "lvwCar"
        Me.lvwCar.Size = New System.Drawing.Size(376, 246)
        Me.lvwCar.TabIndex = 19
        Me.lvwCar.UseCompatibleStateImageBehavior = False
        Me.lvwCar.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        '
        'colID
        '
        Me.colID.Text = "ID"
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        Me.colModel.Width = 66
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        Me.colYear.Width = 69
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        Me.colPrice.Width = 56
        '
        'chkNew
        '
        Me.chkNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.Location = New System.Drawing.Point(69, 110)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(53, 24)
        Me.chkNew.TabIndex = 18
        Me.chkNew.Text = "&New:"
        Me.chkNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(37, 87)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(66, 13)
        Me.lblPrice.TabIndex = 16
        Me.lblPrice.Text = "&Price:"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(37, 34)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(66, 13)
        Me.lblModel.TabIndex = 14
        Me.lblModel.Text = "&Model:"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblModel.UseWaitCursor = True
        '
        'lblMake
        '
        Me.lblMake.Location = New System.Drawing.Point(37, 7)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(66, 13)
        Me.lblMake.TabIndex = 12
        Me.lblMake.Text = "Ma&ke: "
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Toyota", "Ford", "Nissan", "BMW", "Mazda", "Mercedes-Benz", "Volkswagen", "Honda", "Chevy", "GMC", "Audi", "Jeep", "Ferrari"})
        Me.cmbMake.Location = New System.Drawing.Point(109, 7)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(121, 21)
        Me.cmbMake.TabIndex = 13
        '
        'tbPrice
        '
        Me.tbPrice.Location = New System.Drawing.Point(109, 84)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(121, 20)
        Me.tbPrice.TabIndex = 17
        '
        'tbModel
        '
        Me.tbModel.Location = New System.Drawing.Point(109, 34)
        Me.tbModel.Name = "tbModel"
        Me.tbModel.Size = New System.Drawing.Size(121, 20)
        Me.tbModel.TabIndex = 15
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(295, 445)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(214, 445)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 22
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(133, 445)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 21
        Me.btnEnter.Text = "&Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(37, 57)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(66, 13)
        Me.lblYear.TabIndex = 24
        Me.lblYear.Text = "&Year:"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1976", "1975", "1974", "1973", "1972", "1971", "1970"})
        Me.cmbYear.Location = New System.Drawing.Point(109, 57)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(121, 21)
        Me.cmbYear.TabIndex = 25
        '
        'frmCarInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 477)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.lbDisplay)
        Me.Controls.Add(Me.lvwCar)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.tbPrice)
        Me.Controls.Add(Me.tbModel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Name = "frmCarInventory"
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbDisplay As Label
    Friend WithEvents lvwCar As ListView
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblMake As Label
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents tbPrice As TextBox
    Friend WithEvents tbModel As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents lblYear As Label
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
End Class
