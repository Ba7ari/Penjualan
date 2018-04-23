<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKwitansi
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtNokwt = New System.Windows.Forms.TextBox
        Me.txtTglkwt = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNofaktur = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTglfaktur = New System.Windows.Forms.TextBox
        Me.btnBrowseFaktur = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtTglsp = New System.Windows.Forms.TextBox
        Me.txtNosp = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblGrand = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtKdplg = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtNmplg = New System.Windows.Forms.TextBox
        Me.txtAlamat = New System.Windows.Forms.TextBox
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.Label18 = New System.Windows.Forms.Label
        Me.lvw = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblGrand)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.lvw)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(597, 453)
        Me.Panel1.TabIndex = 138
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SlateGray
        Me.Panel2.Controls.Add(Me.txtNokwt)
        Me.Panel2.Controls.Add(Me.txtTglkwt)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Location = New System.Drawing.Point(12, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(251, 76)
        Me.Panel2.TabIndex = 185
        '
        'txtNokwt
        '
        Me.txtNokwt.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtNokwt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNokwt.ForeColor = System.Drawing.SystemColors.Window
        Me.txtNokwt.Location = New System.Drawing.Point(65, 13)
        Me.txtNokwt.MaxLength = 8
        Me.txtNokwt.Name = "txtNokwt"
        Me.txtNokwt.ReadOnly = True
        Me.txtNokwt.Size = New System.Drawing.Size(175, 23)
        Me.txtNokwt.TabIndex = 106
        '
        'txtTglkwt
        '
        Me.txtTglkwt.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtTglkwt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTglkwt.ForeColor = System.Drawing.SystemColors.Window
        Me.txtTglkwt.Location = New System.Drawing.Point(65, 41)
        Me.txtTglkwt.MaxLength = 20
        Me.txtTglkwt.Name = "txtTglkwt"
        Me.txtTglkwt.ReadOnly = True
        Me.txtTglkwt.Size = New System.Drawing.Size(175, 23)
        Me.txtTglkwt.TabIndex = 113
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.Window
        Me.Label21.Location = New System.Drawing.Point(6, 16)
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
        Me.Label22.Location = New System.Drawing.Point(6, 45)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 13)
        Me.Label22.TabIndex = 109
        Me.Label22.Text = "Tanggal"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNofaktur)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtTglfaktur)
        Me.GroupBox1.Controls.Add(Me.btnBrowseFaktur)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtTglsp)
        Me.GroupBox1.Controls.Add(Me.txtNosp)
        Me.GroupBox1.Location = New System.Drawing.Point(270, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 129)
        Me.GroupBox1.TabIndex = 181
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Faktur"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "Tgl. Faktur"
        '
        'txtNofaktur
        '
        Me.txtNofaktur.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNofaktur.Location = New System.Drawing.Point(82, 19)
        Me.txtNofaktur.MaxLength = 8
        Me.txtNofaktur.Name = "txtNofaktur"
        Me.txtNofaktur.Size = New System.Drawing.Size(114, 20)
        Me.txtNofaktur.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Tanggal SP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 140
        Me.Label4.Text = "No. Faktur"
        '
        'txtTglfaktur
        '
        Me.txtTglfaktur.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTglfaktur.Location = New System.Drawing.Point(82, 45)
        Me.txtTglfaktur.MaxLength = 20
        Me.txtTglfaktur.Name = "txtTglfaktur"
        Me.txtTglfaktur.ReadOnly = True
        Me.txtTglfaktur.Size = New System.Drawing.Size(150, 20)
        Me.txtTglfaktur.TabIndex = 139
        '
        'btnBrowseFaktur
        '
        Me.btnBrowseFaktur.Location = New System.Drawing.Point(202, 17)
        Me.btnBrowseFaktur.Name = "btnBrowseFaktur"
        Me.btnBrowseFaktur.Size = New System.Drawing.Size(30, 23)
        Me.btnBrowseFaktur.TabIndex = 138
        Me.btnBrowseFaktur.Text = "..."
        Me.btnBrowseFaktur.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 135
        Me.Label5.Text = "No. SP"
        '
        'txtTglsp
        '
        Me.txtTglsp.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTglsp.Location = New System.Drawing.Point(82, 97)
        Me.txtTglsp.MaxLength = 20
        Me.txtTglsp.Name = "txtTglsp"
        Me.txtTglsp.ReadOnly = True
        Me.txtTglsp.Size = New System.Drawing.Size(150, 20)
        Me.txtTglsp.TabIndex = 134
        '
        'txtNosp
        '
        Me.txtNosp.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNosp.Location = New System.Drawing.Point(82, 71)
        Me.txtNosp.MaxLength = 8
        Me.txtNosp.Name = "txtNosp"
        Me.txtNosp.ReadOnly = True
        Me.txtNosp.Size = New System.Drawing.Size(150, 20)
        Me.txtNosp.TabIndex = 123
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(13, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(570, 3)
        Me.Label3.TabIndex = 138
        '
        'lblGrand
        '
        Me.lblGrand.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblGrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrand.ForeColor = System.Drawing.Color.Lime
        Me.lblGrand.Location = New System.Drawing.Point(432, 380)
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 129)
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
        Me.txtKdplg.TabIndex = 1
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
        Me.txtAlamat.Size = New System.Drawing.Size(231, 44)
        Me.txtAlamat.TabIndex = 78
        '
        'btnPrint
        '
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(194, 416)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(100, 23)
        Me.btnPrint.TabIndex = 133
        Me.btnPrint.Text = "Cetak..."
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(88, 416)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 23)
        Me.btnSave.TabIndex = 132
        Me.btnSave.Text = "Simpan"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(406, 416)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 23)
        Me.btnClose.TabIndex = 131
        Me.btnClose.Text = "Keluar"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(300, 416)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 23)
        Me.btnClear.TabIndex = 130
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.SlateGray
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Window
        Me.Label18.Location = New System.Drawing.Point(369, 380)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 22)
        Me.Label18.TabIndex = 129
        Me.Label18.Text = "Total"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lvw
        '
        Me.lvw.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvw.FullRowSelect = True
        Me.lvw.Location = New System.Drawing.Point(12, 241)
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
        'frmKwitansi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(596, 451)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(604, 485)
        Me.Name = "frmKwitansi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cetak Kwitansi"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblGrand As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtKdplg As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNmplg As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtTglkwt As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtNokwt As System.Windows.Forms.TextBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lvw As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNofaktur As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTglfaktur As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseFaktur As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTglsp As System.Windows.Forms.TextBox
    Friend WithEvents txtNosp As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
