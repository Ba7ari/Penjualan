<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFaktur
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
        Me.txtNosp = New System.Windows.Forms.TextBox
        Me.btnBrowsePesan = New System.Windows.Forms.Button
        Me.txtTglsp = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lvw = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.Label18 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtNofaktur = New System.Windows.Forms.TextBox
        Me.txtTglfaktur = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblGrand = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtKdplg = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtNmplg = New System.Windows.Forms.TextBox
        Me.txtAlamat = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNosp
        '
        Me.txtNosp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNosp.Location = New System.Drawing.Point(85, 21)
        Me.txtNosp.MaxLength = 8
        Me.txtNosp.Name = "txtNosp"
        Me.txtNosp.Size = New System.Drawing.Size(114, 20)
        Me.txtNosp.TabIndex = 0
        '
        'btnBrowsePesan
        '
        Me.btnBrowsePesan.Location = New System.Drawing.Point(205, 19)
        Me.btnBrowsePesan.Name = "btnBrowsePesan"
        Me.btnBrowsePesan.Size = New System.Drawing.Size(30, 23)
        Me.btnBrowsePesan.TabIndex = 117
        Me.btnBrowsePesan.Text = "..."
        Me.btnBrowsePesan.UseVisualStyleBackColor = True
        '
        'txtTglsp
        '
        Me.txtTglsp.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTglsp.Location = New System.Drawing.Point(85, 47)
        Me.txtTglsp.MaxLength = 20
        Me.txtTglsp.Name = "txtTglsp"
        Me.txtTglsp.ReadOnly = True
        Me.txtTglsp.Size = New System.Drawing.Size(150, 20)
        Me.txtTglsp.TabIndex = 120
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "No. SP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Tanggal SP"
        '
        'lvw
        '
        Me.lvw.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvw.FullRowSelect = True
        Me.lvw.Location = New System.Drawing.Point(14, 236)
        Me.lvw.Name = "lvw"
        Me.lvw.Size = New System.Drawing.Size(570, 136)
        Me.lvw.TabIndex = 127
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
        Me.ColumnHeader3.Width = 113
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
        Me.ColumnHeader5.Width = 113
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.SlateGray
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Window
        Me.Label18.Location = New System.Drawing.Point(371, 375)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 22)
        Me.Label18.TabIndex = 129
        Me.Label18.Text = "Total"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(89, 412)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 23)
        Me.btnSave.TabIndex = 132
        Me.btnSave.Text = "Simpan"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(407, 412)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 23)
        Me.btnClose.TabIndex = 131
        Me.btnClose.Text = "Keluar"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(301, 412)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 23)
        Me.btnClear.TabIndex = 130
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(195, 412)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(100, 23)
        Me.btnPrint.TabIndex = 133
        Me.btnPrint.Text = "Cetak..."
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTglsp)
        Me.GroupBox1.Controls.Add(Me.txtNosp)
        Me.GroupBox1.Controls.Add(Me.btnBrowsePesan)
        Me.GroupBox1.Location = New System.Drawing.Point(272, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 125)
        Me.GroupBox1.TabIndex = 134
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesanan"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.txtNofaktur)
        Me.Panel1.Controls.Add(Me.txtTglfaktur)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblGrand)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.lvw)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(-2, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(597, 453)
        Me.Panel1.TabIndex = 137
        '
        'txtNofaktur
        '
        Me.txtNofaktur.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtNofaktur.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNofaktur.ForeColor = System.Drawing.SystemColors.Window
        Me.txtNofaktur.Location = New System.Drawing.Point(79, 21)
        Me.txtNofaktur.MaxLength = 8
        Me.txtNofaktur.Name = "txtNofaktur"
        Me.txtNofaktur.ReadOnly = True
        Me.txtNofaktur.Size = New System.Drawing.Size(175, 23)
        Me.txtNofaktur.TabIndex = 106
        '
        'txtTglfaktur
        '
        Me.txtTglfaktur.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtTglfaktur.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTglfaktur.ForeColor = System.Drawing.SystemColors.Window
        Me.txtTglfaktur.Location = New System.Drawing.Point(79, 50)
        Me.txtTglfaktur.MaxLength = 20
        Me.txtTglfaktur.Name = "txtTglfaktur"
        Me.txtTglfaktur.ReadOnly = True
        Me.txtTglfaktur.Size = New System.Drawing.Size(175, 23)
        Me.txtTglfaktur.TabIndex = 113
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.SlateGray
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.Window
        Me.Label21.Location = New System.Drawing.Point(20, 26)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 13)
        Me.Label21.TabIndex = 108
        Me.Label21.Text = "Nomer"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.SlateGray
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.Window
        Me.Label22.Location = New System.Drawing.Point(20, 55)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 13)
        Me.Label22.TabIndex = 109
        Me.Label22.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SlateGray
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(14, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(252, 77)
        Me.Label4.TabIndex = 139
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(14, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(570, 3)
        Me.Label3.TabIndex = 138
        '
        'lblGrand
        '
        Me.lblGrand.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblGrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrand.ForeColor = System.Drawing.Color.Lime
        Me.lblGrand.Location = New System.Drawing.Point(434, 375)
        Me.lblGrand.Name = "lblGrand"
        Me.lblGrand.Size = New System.Drawing.Size(150, 22)
        Me.lblGrand.TabIndex = 137
        Me.lblGrand.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtKdplg)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtNmplg)
        Me.GroupBox2.Controls.Add(Me.txtAlamat)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 125)
        Me.GroupBox2.TabIndex = 136
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pelanggan"
        '
        'txtKdplg
        '
        Me.txtKdplg.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtKdplg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKdplg.Location = New System.Drawing.Point(112, 21)
        Me.txtKdplg.MaxLength = 7
        Me.txtKdplg.Name = "txtKdplg"
        Me.txtKdplg.ReadOnly = True
        Me.txtKdplg.Size = New System.Drawing.Size(128, 20)
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
        'frmFaktur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(594, 451)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(602, 485)
        Me.Name = "frmFaktur"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cetak Faktur"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNosp As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowsePesan As System.Windows.Forms.Button
    Friend WithEvents txtTglsp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lvw As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtTglfaktur As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtNofaktur As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtKdplg As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNmplg As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents lblGrand As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
