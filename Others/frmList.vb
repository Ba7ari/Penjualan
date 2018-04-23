Option Strict On
Public Class frmDaftar
    Private _table As Integer
    Dim cRekening As New ctlRekening
    Dim cKendaraan As New ctlKendaraan

#Region "Properties"
    Public WriteOnly Property table() As Integer
        Set(ByVal value As Integer)
            _table = value
        End Set
    End Property

    Public ReadOnly Property fld() As String
        Get
            Return gM.fieldValue(cboFilter.Text)
        End Get
    End Property
#End Region

#Region "ListViewHeader"
    Private Sub AddLvwColums()
        With lvw.Columns
            .Clear()
            Select Case _table
                Case Is = gM.dbTable.Kendaraan
                    .Add("No. Polisi", 90)
                    .Add("Merk Kendaraan", 90)
                    .Add("Jumlah Roda", 90)
                    .Add("Bahan Bakar", 90)
                Case Is = gM.dbTable.Rekening
                    .Add("Kode Rekening", 90)
                    .Add("Nama Rekening", 90)
            End Select
        End With
    End Sub
#End Region

#Region "FillListView"
    Private Sub fillLvwKendaraan(ByVal arrLst As ArrayList)
        lvw.Items.Clear()
        If arrLst.Count > 0 Then
            Dim i As Integer
            For i = 0 To arrLst.Count - 1
                Dim objData As Kendaraan = CType(arrLst(i), Kendaraan)
                With lvw.Items.Add(objData.noPol)
                    .SubItems.Add(objData.merkKend)
                    .SubItems.Add(objData.jmlRoda)
                    .SubItems.Add(objData.bhnBakar)
                End With
            Next
        End If
    End Sub

    Private Sub fillLvwRekening(ByVal arrLst As ArrayList)
        lvw.Items.Clear()
        If arrLst.Count > 0 Then
            Dim i As Integer
            For i = 0 To arrLst.Count - 1
                Dim objData As Rekening = CType(arrLst(i), Rekening)
                With lvw.Items.Add(objData.kdRek)
                    .SubItems.Add(objData.nmRek)
                End With
            Next
        End If
    End Sub
#End Region

#Region "fillComboBox"
    Private Sub AddCboItems()
        With cboFilter.Items
            .Clear()
            Select Case _table
                Case Is = gM.dbTable.Kendaraan
                    .Add("No. Polisi")
                    .Add("Merk Kendaraan")
                    .Add("Jumlah Roda")
                    .Add("Bahan Bakar")
                Case Is = gM.dbTable.Rekening
                    .Add("Kode Rekening")
                    .Add("Nama Rekening")
            End Select
        End With
    End Sub
#End Region

    Private Sub frmList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, lvw.KeyDown, txtKey.KeyDown
        gM.cekLockKeysOnKeyDown(e)
    End Sub

    Private Sub frmList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case _table
            Case Is = gM.dbTable.Kendaraan
                Me.Text = "Daftar Kendaraan"
                btnPrint.Enabled = False
            Case Is = gM.dbTable.Rekening
                Me.Text = "Daftar Rekening"
                btnPrint.Enabled = False
        End Select
        AddLvwColums()
        AddCboItems()
        btnRefresh.PerformClick()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Select Case _table
            Case Is = gM.dbTable.Kendaraan
                Dim frm As New frmKendaraan
                frm.mode = "Insert"
                frm.ShowDialog()
            Case Is = gM.dbTable.Rekening
                Dim frm As New frmRekening
                frm.mode = "Insert"
                frm.ShowDialog()
        End Select
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click, EditToolStripMenuItem.Click, lvw.DoubleClick
        With lvw
            If .SelectedItems.Count = 0 Then
                MessageBox.Show("Pilih data yang akan diedit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Select Case _table
                    Case Is = gM.dbTable.Kendaraan
                        Dim frm As New frmKendaraan
                        frm.mode = "Update"
                        Dim i As Integer = .SelectedIndices(0)
                        frm.txtNopol.Text = .Items(i).Text
                        frm.txtMerkkend.Text = .Items(i).SubItems(1).Text
                        frm.txtJmlroda.Text = .Items(i).SubItems(2).Text
                        frm.txtBhnbakar.Text = .Items(i).SubItems(3).Text
                        frm.ShowDialog()
                    Case Is = gM.dbTable.Rekening
                        Dim frm As New frmRekening
                        frm.mode = "Update"
                        Dim i As Integer = .SelectedIndices(0)
                        frm.txtKdrek.Text = .Items(i).Text
                        frm.txtNmrek.Text = .Items(i).SubItems(1).Text
                        frm.ShowDialog()
                End Select
            End If
        End With
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click, HapusToolStripMenuItem.Click
        If lvw.SelectedItems.Count = 0 Then
            MessageBox.Show("Pilih data yang akan dihapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Select Case _table
                Case Is = gM.dbTable.Kendaraan
                    cKendaraan.noPol = lvw.SelectedItems(0).SubItems(0).Text
                    If MessageBox.Show("Benar data akan dihapus?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        If cKendaraan.delete() Then
                            lvw.SelectedItems(0).Remove()
                        End If
                    End If
                Case Is = gM.dbTable.Rekening
                    cRekening.kdRek = lvw.SelectedItems(0).SubItems(0).Text
                    If MessageBox.Show("Benar data akan dihapus?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        If cRekening.delete() Then
                            lvw.SelectedItems(0).Remove()
                        End If
                    End If
            End Select
        End If
    End Sub

    Private Sub frmList_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim i As Integer
        For i = 0 To lvw.Columns.Count - 1
            If Me.Width > My.Computer.Screen.WorkingArea.Width * 2 / 3 Then
                lvw.Columns(i).Width = 150
            Else
                lvw.Columns(i).Width = 90
            End If
        Next
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Select Case _table
            Case Is = gM.dbTable.Kendaraan
                fillLvwKendaraan(cKendaraan.arrAll)
            Case Is = gM.dbTable.Rekening
                fillLvwRekening(cRekening.arrAll)
        End Select
        cboFilter.SelectedIndex = 0
        txtKey.Clear()
        lblResult.SendToBack()
        btnEdit.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub cboFilter_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFilter.SelectedIndexChanged
        txtKey.Clear()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If txtKey.Text.Trim = String.Empty Then
            lvw.Items.Clear()
            lblResult.BringToFront()
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            Exit Sub
        End If

        Select Case _table
            Case Is = gM.dbTable.Kendaraan
                fillLvwKendaraan(cKendaraan.arrByPrefix(fld, txtKey.Text.Trim))
            Case Is = gM.dbTable.Rekening
                fillLvwRekening(cRekening.arrByPrefix(fld, txtKey.Text.Trim))
        End Select
        lblResult.SendToBack()
        btnEdit.Enabled = True
        btnDelete.Enabled = True

        If lvw.Items.Count = 0 Then
            lblResult.BringToFront()
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            Exit Sub
        End If
    End Sub

    Private Sub txtKey_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKey.KeyPress
        gM.noInject(e)
        If Asc(e.KeyChar) = 13 Then
            btnSearch.PerformClick()
        End If
    End Sub

    Private Sub lvw_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvw.SelectedIndexChanged

    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class