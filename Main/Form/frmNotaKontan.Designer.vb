<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotaKontan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotaKontan))
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtNonk = New System.Windows.Forms.TextBox
        Me.txtTglnk = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.lblGrand = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lvw = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HapusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.txtKdbrg = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnBrowseBarang = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtJmlbeli = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnUndo = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtKembali = New System.Windows.Forms.TextBox
        Me.txtBayar = New System.Windows.Forms.TextBox
        Me.btnAddList = New System.Windows.Forms.Button
        Me.btnCalc = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(141, 418)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 23)
        Me.btnSave.TabIndex = 136
        Me.btnSave.Text = "Cetak"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(353, 418)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 23)
        Me.btnClose.TabIndex = 135
        Me.btnClose.Text = "Keluar"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(247, 418)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 23)
        Me.btnClear.TabIndex = 134
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SlateGray
        Me.Panel2.Controls.Add(Me.txtNonk)
        Me.Panel2.Controls.Add(Me.txtTglnk)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(251, 76)
        Me.Panel2.TabIndex = 202
        '
        'txtNonk
        '
        Me.txtNonk.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtNonk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNonk.ForeColor = System.Drawing.SystemColors.Window
        Me.txtNonk.Location = New System.Drawing.Point(64, 12)
        Me.txtNonk.MaxLength = 8
        Me.txtNonk.Name = "txtNonk"
        Me.txtNonk.ReadOnly = True
        Me.txtNonk.Size = New System.Drawing.Size(175, 23)
        Me.txtNonk.TabIndex = 106
        '
        'txtTglnk
        '
        Me.txtTglnk.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtTglnk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTglnk.ForeColor = System.Drawing.SystemColors.Window
        Me.txtTglnk.Location = New System.Drawing.Point(64, 40)
        Me.txtTglnk.MaxLength = 20
        Me.txtTglnk.Name = "txtTglnk"
        Me.txtTglnk.ReadOnly = True
        Me.txtTglnk.Size = New System.Drawing.Size(175, 23)
        Me.txtTglnk.TabIndex = 113
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
        'lblGrand
        '
        Me.lblGrand.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblGrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrand.ForeColor = System.Drawing.Color.Lime
        Me.lblGrand.Location = New System.Drawing.Point(269, 37)
        Me.lblGrand.Name = "lblGrand"
        Me.lblGrand.Size = New System.Drawing.Size(309, 51)
        Me.lblGrand.TabIndex = 203
        Me.lblGrand.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SlateGray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(269, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(309, 25)
        Me.Label2.TabIndex = 204
        Me.Label2.Text = "TOTAL"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lvw
        '
        Me.lvw.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvw.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvw.FullRowSelect = True
        Me.lvw.Location = New System.Drawing.Point(12, 91)
        Me.lvw.Name = "lvw"
        Me.lvw.Size = New System.Drawing.Size(566, 191)
        Me.lvw.TabIndex = 205
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
        Me.ColumnHeader4.Text = "Jml Beli"
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
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 48)
        '
        'HapusToolStripMenuItem
        '
        Me.HapusToolStripMenuItem.Name = "HapusToolStripMenuItem"
        Me.HapusToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HapusToolStripMenuItem.Text = "Hapus"
        '
        'txtKdbrg
        '
        Me.txtKdbrg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKdbrg.Location = New System.Drawing.Point(224, 293)
        Me.txtKdbrg.MaxLength = 7
        Me.txtKdbrg.Name = "txtKdbrg"
        Me.txtKdbrg.Size = New System.Drawing.Size(100, 20)
        Me.txtKdbrg.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(138, 296)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 206
        Me.Label3.Text = "Kode Barang"
        '
        'btnBrowseBarang
        '
        Me.btnBrowseBarang.Location = New System.Drawing.Point(330, 291)
        Me.btnBrowseBarang.Name = "btnBrowseBarang"
        Me.btnBrowseBarang.Size = New System.Drawing.Size(30, 23)
        Me.btnBrowseBarang.TabIndex = 207
        Me.btnBrowseBarang.Text = "..."
        Me.btnBrowseBarang.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(366, 296)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 13)
        Me.Label15.TabIndex = 210
        Me.Label15.Text = "Jml Beli"
        '
        'txtJmlbeli
        '
        Me.txtJmlbeli.Location = New System.Drawing.Point(422, 293)
        Me.txtJmlbeli.MaxLength = 3
        Me.txtJmlbeli.Name = "txtJmlbeli"
        Me.txtJmlbeli.Size = New System.Drawing.Size(50, 20)
        Me.txtJmlbeli.TabIndex = 209
        Me.txtJmlbeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(13, 404)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(566, 3)
        Me.Label4.TabIndex = 213
        '
        'btnUndo
        '
        Me.btnUndo.Image = CType(resources.GetObject("btnUndo.Image"), System.Drawing.Image)
        Me.btnUndo.Location = New System.Drawing.Point(12, 291)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(30, 23)
        Me.btnUndo.TabIndex = 212
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(12, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(566, 3)
        Me.Label5.TabIndex = 214
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 372)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 218
        Me.Label6.Text = "Kembali"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 343)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 217
        Me.Label7.Text = "Dibayar"
        '
        'txtKembali
        '
        Me.txtKembali.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKembali.Location = New System.Drawing.Point(67, 367)
        Me.txtKembali.MaxLength = 11
        Me.txtKembali.Name = "txtKembali"
        Me.txtKembali.ReadOnly = True
        Me.txtKembali.Size = New System.Drawing.Size(150, 22)
        Me.txtKembali.TabIndex = 216
        '
        'txtBayar
        '
        Me.txtBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBayar.Location = New System.Drawing.Point(67, 338)
        Me.txtBayar.MaxLength = 11
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(150, 22)
        Me.txtBayar.TabIndex = 215
        '
        'btnAddList
        '
        Me.btnAddList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddList.Location = New System.Drawing.Point(478, 291)
        Me.btnAddList.Name = "btnAddList"
        Me.btnAddList.Size = New System.Drawing.Size(100, 23)
        Me.btnAddList.TabIndex = 219
        Me.btnAddList.Text = "Add"
        Me.btnAddList.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalc.Location = New System.Drawing.Point(478, 366)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(100, 23)
        Me.btnCalc.TabIndex = 220
        Me.btnCalc.Text = "Kalkulator"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.StripAmpersands = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Tips"
        '
        'frmNotaKontan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(594, 453)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnAddList)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtKembali)
        Me.Controls.Add(Me.txtBayar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.txtKdbrg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnBrowseBarang)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtJmlbeli)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblGrand)
        Me.Controls.Add(Me.lvw)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClear)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmNotaKontan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cetak Nota Kontan"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtNonk As System.Windows.Forms.TextBox
    Friend WithEvents txtTglnk As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblGrand As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lvw As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtKdbrg As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBrowseBarang As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtJmlbeli As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnUndo As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtKembali As System.Windows.Forms.TextBox
    Friend WithEvents txtBayar As System.Windows.Forms.TextBox
    Friend WithEvents btnAddList As System.Windows.Forms.Button
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HapusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
