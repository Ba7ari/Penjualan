<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPesanan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPesanan))
        Me.txtKdbrg = New System.Windows.Forms.TextBox
        Me.btnBrowseBarang = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnBrowsePlg = New System.Windows.Forms.Button
        Me.txtKdplg = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtNmplg = New System.Windows.Forms.TextBox
        Me.txtAlamat = New System.Windows.Forms.TextBox
        Me.txtJmlpsn = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.lvw = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HapusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.txtNosp = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtTglsp = New System.Windows.Forms.TextBox
        Me.btnAddList = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblGrand = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnUndo = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtKdbrg
        '
        Me.txtKdbrg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKdbrg.Location = New System.Drawing.Point(92, 21)
        Me.txtKdbrg.MaxLength = 7
        Me.txtKdbrg.Name = "txtKdbrg"
        Me.txtKdbrg.Size = New System.Drawing.Size(100, 20)
        Me.txtKdbrg.TabIndex = 76
        '
        'btnBrowseBarang
        '
        Me.btnBrowseBarang.Location = New System.Drawing.Point(198, 19)
        Me.btnBrowseBarang.Name = "btnBrowseBarang"
        Me.btnBrowseBarang.Size = New System.Drawing.Size(30, 23)
        Me.btnBrowseBarang.TabIndex = 75
        Me.btnBrowseBarang.Text = "..."
        Me.btnBrowseBarang.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Kode Barang"
        '
        'btnBrowsePlg
        '
        Me.btnBrowsePlg.Location = New System.Drawing.Point(210, 19)
        Me.btnBrowsePlg.Name = "btnBrowsePlg"
        Me.btnBrowsePlg.Size = New System.Drawing.Size(30, 23)
        Me.btnBrowsePlg.TabIndex = 86
        Me.btnBrowsePlg.Text = "..."
        Me.btnBrowsePlg.UseVisualStyleBackColor = True
        '
        'txtKdplg
        '
        Me.txtKdplg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKdplg.Location = New System.Drawing.Point(112, 21)
        Me.txtKdplg.MaxLength = 7
        Me.txtKdplg.Name = "txtKdplg"
        Me.txtKdplg.Size = New System.Drawing.Size(92, 20)
        Me.txtKdplg.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 13)
        Me.Label14.TabIndex = 80
        Me.Label14.Text = "Kode Pelanggan"
        '
        'txtNmplg
        '
        Me.txtNmplg.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNmplg.Location = New System.Drawing.Point(9, 47)
        Me.txtNmplg.MaxLength = 30
        Me.txtNmplg.Name = "txtNmplg"
        Me.txtNmplg.ReadOnly = True
        Me.txtNmplg.Size = New System.Drawing.Size(231, 20)
        Me.txtNmplg.TabIndex = 77
        '
        'txtAlamat
        '
        Me.txtAlamat.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAlamat.Location = New System.Drawing.Point(9, 73)
        Me.txtAlamat.MaxLength = 100
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.ReadOnly = True
        Me.txtAlamat.Size = New System.Drawing.Size(231, 40)
        Me.txtAlamat.TabIndex = 78
        '
        'txtJmlpsn
        '
        Me.txtJmlpsn.Location = New System.Drawing.Point(92, 47)
        Me.txtJmlpsn.MaxLength = 3
        Me.txtJmlpsn.Name = "txtJmlpsn"
        Me.txtJmlpsn.Size = New System.Drawing.Size(50, 20)
        Me.txtJmlpsn.TabIndex = 88
        Me.txtJmlpsn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 13)
        Me.Label15.TabIndex = 91
        Me.Label15.Text = "Qty"
        '
        'lvw
        '
        Me.lvw.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvw.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvw.FullRowSelect = True
        Me.lvw.Location = New System.Drawing.Point(14, 238)
        Me.lvw.Name = "lvw"
        Me.lvw.Size = New System.Drawing.Size(566, 136)
        Me.lvw.TabIndex = 94
        Me.ToolTip1.SetToolTip(Me.lvw, "Klik kanan untuk membatalkan atau pergunakan tombol 'Undo'.")
        Me.lvw.UseCompatibleStateImageBehavior = False
        Me.lvw.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Kode Barang"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama Barang"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Harga Satuan"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 111
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Jml Psn"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Total Harga"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 111
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HapusToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(116, 26)
        '
        'HapusToolStripMenuItem
        '
        Me.HapusToolStripMenuItem.Name = "HapusToolStripMenuItem"
        Me.HapusToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.HapusToolStripMenuItem.Text = "Hapus"
        '
        'btnSave
        '
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(142, 416)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 23)
        Me.btnSave.TabIndex = 105
        Me.btnSave.Text = "Simpan"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(354, 416)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 23)
        Me.btnClose.TabIndex = 104
        Me.btnClose.Text = "Keluar"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(248, 416)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 23)
        Me.btnClear.TabIndex = 103
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtNosp
        '
        Me.txtNosp.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtNosp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNosp.ForeColor = System.Drawing.SystemColors.Window
        Me.txtNosp.Location = New System.Drawing.Point(64, 12)
        Me.txtNosp.MaxLength = 8
        Me.txtNosp.Name = "txtNosp"
        Me.txtNosp.ReadOnly = True
        Me.txtNosp.Size = New System.Drawing.Size(175, 23)
        Me.txtNosp.TabIndex = 106
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.Window
        Me.Label21.Location = New System.Drawing.Point(5, 15)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 13)
        Me.Label21.TabIndex = 108
        Me.Label21.Text = "Nomer"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.Window
        Me.Label22.Location = New System.Drawing.Point(5, 44)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 13)
        Me.Label22.TabIndex = 109
        Me.Label22.Text = "Tanggal"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBrowsePlg)
        Me.GroupBox1.Controls.Add(Me.txtKdplg)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtNmplg)
        Me.GroupBox1.Controls.Add(Me.txtAlamat)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 125)
        Me.GroupBox1.TabIndex = 110
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pelanggan"
        '
        'txtTglsp
        '
        Me.txtTglsp.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtTglsp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTglsp.ForeColor = System.Drawing.SystemColors.Window
        Me.txtTglsp.Location = New System.Drawing.Point(64, 40)
        Me.txtTglsp.MaxLength = 20
        Me.txtTglsp.Name = "txtTglsp"
        Me.txtTglsp.ReadOnly = True
        Me.txtTglsp.Size = New System.Drawing.Size(175, 23)
        Me.txtTglsp.TabIndex = 113
        '
        'btnAddList
        '
        Me.btnAddList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddList.Location = New System.Drawing.Point(376, 209)
        Me.btnAddList.Name = "btnAddList"
        Me.btnAddList.Size = New System.Drawing.Size(100, 23)
        Me.btnAddList.TabIndex = 114
        Me.btnAddList.Text = "Pesan"
        Me.btnAddList.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtKdbrg)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnBrowseBarang)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtJmlpsn)
        Me.GroupBox2.Location = New System.Drawing.Point(272, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(308, 96)
        Me.GroupBox2.TabIndex = 116
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Barang"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblGrand)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnUndo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnAddList)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.lvw)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Location = New System.Drawing.Point(-2, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(596, 453)
        Me.Panel1.TabIndex = 120
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SlateGray
        Me.Panel2.Controls.Add(Me.txtNosp)
        Me.Panel2.Controls.Add(Me.txtTglsp)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Location = New System.Drawing.Point(15, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(251, 76)
        Me.Panel2.TabIndex = 201
        '
        'lblGrand
        '
        Me.lblGrand.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblGrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrand.ForeColor = System.Drawing.Color.Lime
        Me.lblGrand.Location = New System.Drawing.Point(430, 377)
        Me.lblGrand.Name = "lblGrand"
        Me.lblGrand.Size = New System.Drawing.Size(150, 22)
        Me.lblGrand.TabIndex = 197
        Me.lblGrand.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.SlateGray
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Window
        Me.Label18.Location = New System.Drawing.Point(367, 377)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 22)
        Me.Label18.TabIndex = 196
        Me.Label18.Text = "Total"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(15, 410)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(566, 3)
        Me.Label4.TabIndex = 195
        '
        'btnUndo
        '
        Me.btnUndo.Image = CType(resources.GetObject("btnUndo.Image"), System.Drawing.Image)
        Me.btnUndo.Location = New System.Drawing.Point(14, 380)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(30, 23)
        Me.btnUndo.TabIndex = 193
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(15, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(566, 3)
        Me.Label3.TabIndex = 120
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.StripAmpersands = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Tips"
        '
        'frmPesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(592, 451)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(600, 485)
        Me.Name = "frmPesanan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entry Data Pesanan"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtKdbrg As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseBarang As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBrowsePlg As System.Windows.Forms.Button
    Friend WithEvents txtKdplg As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNmplg As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtJmlpsn As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lvw As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtNosp As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HapusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTglsp As System.Windows.Forms.TextBox
    Friend WithEvents btnAddList As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnUndo As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblGrand As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
