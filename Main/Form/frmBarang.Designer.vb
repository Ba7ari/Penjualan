<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtNmsub = New System.Windows.Forms.TextBox
        Me.txtStok = New System.Windows.Forms.TextBox
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtHarga = New System.Windows.Forms.TextBox
        Me.txtSatuan = New System.Windows.Forms.TextBox
        Me.cboKdsub = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtKdbrg = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtNmbrg = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.txtNmkategori1 = New System.Windows.Forms.TextBox
        Me.lvw1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.txtKdsub1 = New System.Windows.Forms.TextBox
        Me.txtNmsub1 = New System.Windows.Forms.TextBox
        Me.cboKdkategori1 = New System.Windows.Forms.ComboBox
        Me.btnSave1 = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnEdit1 = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnClose1 = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnClear1 = New System.Windows.Forms.Button
        Me.btnDelete1 = New System.Windows.Forms.Button
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.lvw2 = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.txtKdkategori2 = New System.Windows.Forms.TextBox
        Me.btnSave2 = New System.Windows.Forms.Button
        Me.btnEdit2 = New System.Windows.Forms.Button
        Me.btnClose2 = New System.Windows.Forms.Button
        Me.txtNmkategori2 = New System.Windows.Forms.TextBox
        Me.btnClear2 = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.btnDelete2 = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TabControl1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.ContextMenuStrip = Me.ContextMenuStrip2
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(456, 312)
        Me.TabControl1.TabIndex = 1
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem1})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(95, 26)
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(94, 22)
        Me.EditToolStripMenuItem1.Text = "Edit"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.btnClose)
        Me.TabPage1.Controls.Add(Me.btnClear)
        Me.TabPage1.Controls.Add(Me.btnDelete)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(448, 286)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Barang"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txtNmsub)
        Me.Panel2.Controls.Add(Me.txtStok)
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.btnBrowse)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtHarga)
        Me.Panel2.Controls.Add(Me.txtSatuan)
        Me.Panel2.Controls.Add(Me.cboKdsub)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtKdbrg)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtNmbrg)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(15, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(418, 226)
        Me.Panel2.TabIndex = 77
        '
        'txtNmsub
        '
        Me.txtNmsub.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNmsub.Location = New System.Drawing.Point(205, 40)
        Me.txtNmsub.MaxLength = 30
        Me.txtNmsub.Name = "txtNmsub"
        Me.txtNmsub.ReadOnly = True
        Me.txtNmsub.Size = New System.Drawing.Size(196, 20)
        Me.txtNmsub.TabIndex = 98
        '
        'txtStok
        '
        Me.txtStok.Location = New System.Drawing.Point(99, 145)
        Me.txtStok.MaxLength = 3
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(50, 20)
        Me.txtStok.TabIndex = 70
        Me.txtStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnPrint
        '
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(245, 187)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 69
        Me.btnPrint.Text = "Cetak..."
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBrowse.Location = New System.Drawing.Point(326, 187)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 59
        Me.btnBrowse.Text = "Cari..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(16, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(385, 3)
        Me.Label5.TabIndex = 63
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Stok"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Nama Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Kode Barang"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(99, 119)
        Me.txtHarga.MaxLength = 9
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(121, 20)
        Me.txtHarga.TabIndex = 45
        Me.txtHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSatuan
        '
        Me.txtSatuan.Location = New System.Drawing.Point(99, 93)
        Me.txtSatuan.MaxLength = 10
        Me.txtSatuan.Name = "txtSatuan"
        Me.txtSatuan.Size = New System.Drawing.Size(150, 20)
        Me.txtSatuan.TabIndex = 44
        '
        'cboKdsub
        '
        Me.cboKdsub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKdsub.FormattingEnabled = True
        Me.cboKdsub.Location = New System.Drawing.Point(99, 40)
        Me.cboKdsub.Name = "cboKdsub"
        Me.cboKdsub.Size = New System.Drawing.Size(100, 21)
        Me.cboKdsub.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Harga Satuan"
        '
        'txtKdbrg
        '
        Me.txtKdbrg.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtKdbrg.Location = New System.Drawing.Point(99, 14)
        Me.txtKdbrg.MaxLength = 7
        Me.txtKdbrg.Name = "txtKdbrg"
        Me.txtKdbrg.ReadOnly = True
        Me.txtKdbrg.Size = New System.Drawing.Size(100, 20)
        Me.txtKdbrg.TabIndex = 60
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Satuan"
        '
        'txtNmbrg
        '
        Me.txtNmbrg.Location = New System.Drawing.Point(99, 67)
        Me.txtNmbrg.MaxLength = 50
        Me.txtNmbrg.Name = "txtNmbrg"
        Me.txtNmbrg.Size = New System.Drawing.Size(250, 20)
        Me.txtNmbrg.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Sub Kategori"
        '
        'btnSave
        '
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(15, 247)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 23)
        Me.btnSave.TabIndex = 76
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(333, 247)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 23)
        Me.btnClose.TabIndex = 75
        Me.btnClose.Text = "Keluar"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(227, 247)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 23)
        Me.btnClear.TabIndex = 74
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(121, 247)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 23)
        Me.btnDelete.TabIndex = 73
        Me.btnDelete.Text = "Hapus"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtNmkategori1)
        Me.TabPage2.Controls.Add(Me.lvw1)
        Me.TabPage2.Controls.Add(Me.txtKdsub1)
        Me.TabPage2.Controls.Add(Me.txtNmsub1)
        Me.TabPage2.Controls.Add(Me.cboKdkategori1)
        Me.TabPage2.Controls.Add(Me.btnSave1)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.btnEdit1)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.btnClose1)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.btnClear1)
        Me.TabPage2.Controls.Add(Me.btnDelete1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(448, 286)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Sub Kategori"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtNmkategori1
        '
        Me.txtNmkategori1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNmkategori1.Location = New System.Drawing.Point(197, 41)
        Me.txtNmkategori1.MaxLength = 30
        Me.txtNmkategori1.Name = "txtNmkategori1"
        Me.txtNmkategori1.ReadOnly = True
        Me.txtNmkategori1.Size = New System.Drawing.Size(226, 20)
        Me.txtNmkategori1.TabIndex = 97
        '
        'lvw1
        '
        Me.lvw1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvw1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvw1.FullRowSelect = True
        Me.lvw1.Location = New System.Drawing.Point(24, 94)
        Me.lvw1.Name = "lvw1"
        Me.lvw1.Size = New System.Drawing.Size(399, 147)
        Me.lvw1.TabIndex = 96
        Me.lvw1.UseCompatibleStateImageBehavior = False
        Me.lvw1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Kode Sub"
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama Sub"
        Me.ColumnHeader2.Width = 212
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Kode Kategori"
        Me.ColumnHeader3.Width = 90
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(95, 26)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(94, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'txtKdsub1
        '
        Me.txtKdsub1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtKdsub1.Location = New System.Drawing.Point(91, 15)
        Me.txtKdsub1.MaxLength = 4
        Me.txtKdsub1.Name = "txtKdsub1"
        Me.txtKdsub1.ReadOnly = True
        Me.txtKdsub1.Size = New System.Drawing.Size(100, 20)
        Me.txtKdsub1.TabIndex = 86
        '
        'txtNmsub1
        '
        Me.txtNmsub1.Location = New System.Drawing.Point(91, 68)
        Me.txtNmsub1.MaxLength = 30
        Me.txtNmsub1.Name = "txtNmsub1"
        Me.txtNmsub1.Size = New System.Drawing.Size(332, 20)
        Me.txtNmsub1.TabIndex = 85
        '
        'cboKdkategori1
        '
        Me.cboKdkategori1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKdkategori1.FormattingEnabled = True
        Me.cboKdkategori1.Location = New System.Drawing.Point(91, 41)
        Me.cboKdkategori1.Name = "cboKdkategori1"
        Me.cboKdkategori1.Size = New System.Drawing.Size(100, 21)
        Me.cboKdkategori1.TabIndex = 84
        '
        'btnSave1
        '
        Me.btnSave1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave1.Location = New System.Drawing.Point(24, 247)
        Me.btnSave1.Name = "btnSave1"
        Me.btnSave1.Size = New System.Drawing.Size(75, 23)
        Me.btnSave1.TabIndex = 94
        Me.btnSave1.Text = "Save"
        Me.btnSave1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 88
        Me.Label10.Text = "Nama Sub"
        '
        'btnEdit1
        '
        Me.btnEdit1.Enabled = False
        Me.btnEdit1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit1.Location = New System.Drawing.Point(105, 247)
        Me.btnEdit1.Name = "btnEdit1"
        Me.btnEdit1.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit1.TabIndex = 90
        Me.btnEdit1.Text = "Edit"
        Me.btnEdit1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(23, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 89
        Me.Label11.Text = "Kategori"
        '
        'btnClose1
        '
        Me.btnClose1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose1.Location = New System.Drawing.Point(348, 247)
        Me.btnClose1.Name = "btnClose1"
        Me.btnClose1.Size = New System.Drawing.Size(75, 23)
        Me.btnClose1.TabIndex = 93
        Me.btnClose1.Text = "Keluar"
        Me.btnClose1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(23, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "Kode Sub"
        '
        'btnClear1
        '
        Me.btnClear1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear1.Location = New System.Drawing.Point(267, 247)
        Me.btnClear1.Name = "btnClear1"
        Me.btnClear1.Size = New System.Drawing.Size(75, 23)
        Me.btnClear1.TabIndex = 92
        Me.btnClear1.Text = "Clear"
        Me.btnClear1.UseVisualStyleBackColor = True
        '
        'btnDelete1
        '
        Me.btnDelete1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete1.Location = New System.Drawing.Point(186, 247)
        Me.btnDelete1.Name = "btnDelete1"
        Me.btnDelete1.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete1.TabIndex = 91
        Me.btnDelete1.Text = "Hapus"
        Me.btnDelete1.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lvw2)
        Me.TabPage3.Controls.Add(Me.txtKdkategori2)
        Me.TabPage3.Controls.Add(Me.btnSave2)
        Me.TabPage3.Controls.Add(Me.btnEdit2)
        Me.TabPage3.Controls.Add(Me.btnClose2)
        Me.TabPage3.Controls.Add(Me.txtNmkategori2)
        Me.TabPage3.Controls.Add(Me.btnClear2)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.btnDelete2)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(448, 286)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Kategori"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lvw2
        '
        Me.lvw2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvw2.FullRowSelect = True
        Me.lvw2.Location = New System.Drawing.Point(24, 67)
        Me.lvw2.Name = "lvw2"
        Me.lvw2.Size = New System.Drawing.Size(399, 174)
        Me.lvw2.TabIndex = 97
        Me.lvw2.UseCompatibleStateImageBehavior = False
        Me.lvw2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Kode Kategori"
        Me.ColumnHeader4.Width = 90
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Nama Kategori"
        Me.ColumnHeader5.Width = 304
        '
        'txtKdkategori2
        '
        Me.txtKdkategori2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtKdkategori2.Location = New System.Drawing.Point(114, 15)
        Me.txtKdkategori2.MaxLength = 4
        Me.txtKdkategori2.Name = "txtKdkategori2"
        Me.txtKdkategori2.ReadOnly = True
        Me.txtKdkategori2.Size = New System.Drawing.Size(100, 20)
        Me.txtKdkategori2.TabIndex = 85
        '
        'btnSave2
        '
        Me.btnSave2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave2.Location = New System.Drawing.Point(24, 247)
        Me.btnSave2.Name = "btnSave2"
        Me.btnSave2.Size = New System.Drawing.Size(75, 23)
        Me.btnSave2.TabIndex = 92
        Me.btnSave2.Text = "Save"
        Me.btnSave2.UseVisualStyleBackColor = True
        '
        'btnEdit2
        '
        Me.btnEdit2.Enabled = False
        Me.btnEdit2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit2.Location = New System.Drawing.Point(105, 247)
        Me.btnEdit2.Name = "btnEdit2"
        Me.btnEdit2.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit2.TabIndex = 88
        Me.btnEdit2.Text = "Edit"
        Me.btnEdit2.UseVisualStyleBackColor = True
        '
        'btnClose2
        '
        Me.btnClose2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose2.Location = New System.Drawing.Point(348, 247)
        Me.btnClose2.Name = "btnClose2"
        Me.btnClose2.Size = New System.Drawing.Size(75, 23)
        Me.btnClose2.TabIndex = 91
        Me.btnClose2.Text = "Keluar"
        Me.btnClose2.UseVisualStyleBackColor = True
        '
        'txtNmkategori2
        '
        Me.txtNmkategori2.Location = New System.Drawing.Point(114, 41)
        Me.txtNmkategori2.MaxLength = 30
        Me.txtNmkategori2.Name = "txtNmkategori2"
        Me.txtNmkategori2.Size = New System.Drawing.Size(309, 20)
        Me.txtNmkategori2.TabIndex = 84
        '
        'btnClear2
        '
        Me.btnClear2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear2.Location = New System.Drawing.Point(267, 247)
        Me.btnClear2.Name = "btnClear2"
        Me.btnClear2.Size = New System.Drawing.Size(75, 23)
        Me.btnClear2.TabIndex = 90
        Me.btnClear2.Text = "Clear"
        Me.btnClear2.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(21, 44)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 13)
        Me.Label14.TabIndex = 87
        Me.Label14.Text = "Nama Kategori"
        '
        'btnDelete2
        '
        Me.btnDelete2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete2.Location = New System.Drawing.Point(186, 247)
        Me.btnDelete2.Name = "btnDelete2"
        Me.btnDelete2.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete2.TabIndex = 89
        Me.btnDelete2.Text = "Hapus"
        Me.btnDelete2.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(21, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 13)
        Me.Label15.TabIndex = 86
        Me.Label15.Text = "Kode Kategori"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(481, 338)
        Me.Panel1.TabIndex = 2
        '
        'frmBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 337)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entry Data Barang"
        Me.TabControl1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtStok As System.Windows.Forms.TextBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents txtSatuan As System.Windows.Forms.TextBox
    Friend WithEvents cboKdsub As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtKdbrg As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNmbrg As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtNmsub1 As System.Windows.Forms.TextBox
    Friend WithEvents cboKdkategori1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave1 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnEdit1 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnClose1 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnClear1 As System.Windows.Forms.Button
    Friend WithEvents btnDelete1 As System.Windows.Forms.Button
    Friend WithEvents lvw1 As System.Windows.Forms.ListView
    Friend WithEvents txtKdsub1 As System.Windows.Forms.TextBox
    Friend WithEvents txtKdkategori2 As System.Windows.Forms.TextBox
    Friend WithEvents btnSave2 As System.Windows.Forms.Button
    Friend WithEvents btnEdit2 As System.Windows.Forms.Button
    Friend WithEvents btnClose2 As System.Windows.Forms.Button
    Friend WithEvents txtNmkategori2 As System.Windows.Forms.TextBox
    Friend WithEvents btnClear2 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnDelete2 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvw2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtNmsub As System.Windows.Forms.TextBox
    Friend WithEvents txtNmkategori1 As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
