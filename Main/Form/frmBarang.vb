Option Strict On
Public Class frmBarang
    Dim cBarang As New ctlBarang
    Dim cKategori As New ctlKategori
    Dim cSubKategori As New ctlSubKategori

    Private Sub frmBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillCboKdSub()
        fillCboKdKategori1()
    End Sub

#Region "TabPage1"
    Private Sub mulai()
        gM.resCtrlTxt(Me)
        txtKdbrg.Text = "(Auto Generate)"
        btnSave.Text = "Simpan"
        btnDelete.Enabled = False
    End Sub

    Private Sub fill()
        With cBarang
            If btnSave.Text = "Simpan" Then
                .kdBrg = .autoNum
            Else
                .kdBrg = txtKdbrg.Text
            End If
            .nmBrg = txtNmbrg.Text
            .satuan = txtSatuan.Text
            .harga = CInt(txtHarga.Text)
            .stok = CInt(txtStok.Text)
            .kdSub = cboKdsub.Text
        End With
    End Sub

    Private Sub fillCboKdSub()
        With cboKdsub
            .Items.Clear()
            .Items.Add("Silakan Pilih")
            Dim arrLst As ArrayList = cSubKategori.arrAll
            If arrLst.Count > 0 Then
                Dim i As Integer
                For i = 0 To arrLst.Count - 1
                    Dim objData As SubKategori = CType(arrLst(i), SubKategori)
                    .Items.Add(objData.kdSub)
                Next
            End If
        End With
    End Sub

    Private Function txtEmpty() As Boolean
        If cboKdsub.SelectedIndex = 0 Or txtNmbrg.Text.Trim = String.Empty Or _
            txtSatuan.Text.Trim = String.Empty Or _
            Val(txtHarga.Text) = 0 Or Val(txtStok.Text) = 0 Then
            Return True
        End If
        Return False
    End Function

    Private Sub TabPage1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage1.Enter
        mulai()
    End Sub

    Private Sub frmBarang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, txtHarga.KeyDown, txtKdbrg.KeyDown, txtKdkategori2.KeyDown, txtKdsub1.KeyDown, txtNmbrg.KeyDown, txtNmkategori1.KeyDown, txtNmkategori2.KeyDown, txtNmsub.KeyDown, txtNmsub1.KeyDown, txtSatuan.KeyDown, txtStok.KeyDown
        gM.cekLockKeysOnKeyDown(e)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtEmpty() Then
            MessageBox.Show("Data yang diinput harus lengkap", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            fill()
            With cBarang
                If btnSave.Text = "Simpan" Then
                    If .insert() Then
                        MessageBox.Show("Data berhasil disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    If .update() Then
                        MessageBox.Show("Data berhasil diupdate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End With
            mulai()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        fill()
        If MessageBox.Show("Benar data akan dihapus?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If cBarang.delete() Then
                mulai()
            End If
        End If
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim frm As New frmBrowse
        With frm
            .table = gM.dbTable.Barang
            .ShowDialog()
            If .keyValue <> String.Empty Then
                txtKdbrg.Text = .keyValue
            End If
        End With
    End Sub

    Private Sub txtHarga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHarga.KeyPress, txtStok.KeyPress
        gM.numOnly(e)
    End Sub

    Private Sub txtHarga_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHarga.TextChanged
        With txtHarga
            If Val(.Text) > 0 Then
                .Text = FormatNumber(.Text, 0)
            End If
            .Select(.TextLength, .TextLength)
        End With
    End Sub

    Private Sub cboKdsub_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboKdsub.SelectedIndexChanged
        cSubKategori.getByKey("kdsub", cboKdsub.Text)
        txtNmsub.Text = cSubKategori.nmSub
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim frm As New frmCetak1
        frm.rptName = "rptBarang"
        frm.ShowDialog()
    End Sub

    Private Sub txtKdbrg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKdbrg.TextChanged
        With cBarang
            .getByKey("kdbrg", txtKdbrg.Text)
            txtNmbrg.Text = .nmBrg
            txtSatuan.Text = .satuan
            txtHarga.Text = FormatNumber(.harga, 0)
            txtStok.Text = .stok.ToString
            cboKdsub.Text = .kdSub
        End With
        btnSave.Text = "Update"
        btnDelete.Enabled = True
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        mulai()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click, btnClose1.Click, btnClose2.Click
        Me.Dispose()
    End Sub
#End Region

#Region "TabPage2"
    Private Sub mulai1()
        fillLvw1()
        gM.resCtrlTxt(Me)
        txtKdsub1.Text = "(Auto Generate)"
        btnEdit1.Enabled = True
    End Sub

    Private Sub fill1()
        With cSubKategori
            If btnSave1.Text = "Simpan" Then
                .kdSub = .autoNum
            Else
                .kdSub = txtKdsub1.Text
            End If
            .nmSub = txtNmsub1.Text
            .kdKategori = cboKdkategori1.Text
        End With
    End Sub

    Private Sub fillCboKdKategori1()
        With cboKdkategori1
            .Items.Clear()
            .Items.Add("Silakan Pilih")
            Dim arrLst As ArrayList = cKategori.arrAll
            If arrLst.Count > 0 Then
                Dim i As Integer
                For i = 0 To arrLst.Count - 1
                    Dim objData As Kategori = CType(arrLst(i), Kategori)
                    .Items.Add(objData.kdKategori)
                Next
            End If
        End With
    End Sub

    Private Sub fillLvw1()
        lvw1.Items.Clear()
        Dim arrLst As ArrayList = cSubKategori.arrAll
        If arrLst.Count > 0 Then
            Dim i As Integer
            For i = 0 To arrLst.Count - 1
                Dim objData As SubKategori = CType(arrLst(i), SubKategori)
                With lvw1.Items.Add(objData.kdSub)
                    .SubItems.Add(objData.nmSub)
                    .SubItems.Add(objData.kdKategori)
                End With
            Next
        End If
    End Sub

    Function txtEmpty1() As Boolean
        If cboKdkategori1.SelectedIndex = 0 Or txtNmsub1.Text.Trim = String.Empty Then
            Return True
        End If
        Return False
    End Function

    Private Sub TabPage2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub TabPage2_CursorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage2.CursorChanged

    End Sub

    Private Sub TabPage2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage2.Enter
        mulai1()
    End Sub

    Private Sub btnSave1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave1.Click
        If txtEmpty1() Then
            MessageBox.Show("Data yang diinput harus lengkap", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            fill1()
            With cSubKategori
                If btnSave1.Text = "Simpan" Then
                    If .insert() Then
                        MessageBox.Show("Data berhasil disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    If .update() Then
                        MessageBox.Show("Data berhasil diupdate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
                mulai1()
            End With
        End If
    End Sub

    Private Sub btnEdit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit1.Click, EditToolStripMenuItem.Click, lvw1.DoubleClick
        With lvw1
            If .SelectedItems.Count = 0 Then
                MessageBox.Show("Pilih data yang akan diedit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim i As Integer = .SelectedIndices(0)
                txtKdsub1.Text = .Items(i).Text
                txtNmsub1.Text = .Items(i).SubItems(1).Text
                cboKdkategori1.Text = .Items(i).SubItems(2).Text
                cKategori.getByKey("kdkategori", cboKdkategori1.Text)
                txtNmkategori1.Text = cKategori.nmKategori
                btnEdit1.Enabled = False
            End If
        End With
    End Sub

    Private Sub btnDelete1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete1.Click
        fill1()
        If MessageBox.Show("Benar data akan dihapus?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If cSubKategori.delete() Then
                mulai1()
            End If
        End If
    End Sub

    Private Sub btnEdit1_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit1.EnabledChanged
        If btnEdit1.Enabled = True Then
            Me.EditToolStripMenuItem.Enabled = True
            btnDelete1.Enabled = False
            btnSave1.Text = "Simpan"
        Else
            Me.EditToolStripMenuItem.Enabled = False
            btnDelete1.Enabled = True
            btnSave1.Text = "Update"
        End If
    End Sub

    Private Sub cboKdkategori1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboKdkategori1.SelectedIndexChanged
        cKategori.getByKey("kdkategori", cboKdkategori1.Text)
        txtNmkategori1.Text = cKategori.nmKategori
    End Sub

    Private Sub btnClear1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear1.Click
        mulai1()
    End Sub
#End Region

#Region "TabPage3"
    Private Sub mulai2()
        btnEdit2.Enabled = True
        gM.resCtrlTxt(Me)
        fillLvw2()
        txtKdkategori2.Text = "(Auto Generate)"
    End Sub

    Private Sub fill2()
        With cKategori
            If btnSave2.Text = "Simpan" Then
                .kdKategori = .autoNum
            Else
                .kdKategori = txtKdkategori2.Text
            End If
            .nmKategori = txtNmkategori2.Text
        End With
    End Sub

    Private Sub fillLvw2()
        lvw2.Items.Clear()
        Dim arrLst As ArrayList = cKategori.arrAll
        If arrLst.Count > 0 Then
            Dim i As Integer
            For i = 0 To arrLst.Count - 1
                Dim objData As Kategori = CType(arrLst(i), Kategori)
                With lvw2.Items.Add(objData.kdKategori)
                    .SubItems.Add(objData.nmKategori)
                End With
            Next
        End If
    End Sub

    Private Sub TabPage3_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage3.Enter
        mulai2()
    End Sub

    Private Sub btnSave2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave2.Click
        If txtNmkategori2.Text.Trim = String.Empty Then
            MessageBox.Show("Data yang diinput harus lengkap", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            fill2()
            With cKategori
                If btnSave2.Text = "Simpan" Then
                    If .insert() Then
                        MessageBox.Show("Data berhasil disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    If .update() Then
                        MessageBox.Show("Data berhasil diupdate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
                mulai2()
            End With
        End If
    End Sub

    Private Sub btnEdit2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit2.Click, EditToolStripMenuItem1.Click, lvw2.DoubleClick
        With lvw2
            If .SelectedItems.Count = 0 Then
                MessageBox.Show("Pilih data yang akan diedit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim i As Integer = .SelectedIndices(0)
                txtKdkategori2.Text = .Items(i).Text
                txtNmkategori2.Text = .Items(i).SubItems(1).Text
                btnEdit2.Enabled = False
            End If
        End With
    End Sub

    Private Sub btnDelete2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete2.Click
        fill2()
        If MessageBox.Show("Benar data akan dihapus?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If cKategori.delete() Then
                mulai2()
            End If
        End If
    End Sub

    Private Sub btnEdit2_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit2.EnabledChanged
        If btnEdit2.Enabled = True Then
            Me.EditToolStripMenuItem1.Enabled = True
            btnDelete2.Enabled = False
            btnSave2.Text = "Simpan"
        Else
            Me.EditToolStripMenuItem1.Enabled = False
            btnDelete2.Enabled = True
            btnSave2.Text = "Update"
        End If
    End Sub

    Private Sub btnClear2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear2.Click
        mulai2()
    End Sub
#End Region

    Private Sub txtKdkategori2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKdkategori2.TextChanged

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub lvw1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvw1.SelectedIndexChanged

    End Sub

    Private Sub txtNmbrg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNmbrg.TextChanged

    End Sub
End Class