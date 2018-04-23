Option Strict On
Public Class frmBrowse
    Private _table As Integer, _keyValue As String
    Dim cBarang As New ctlBarang
    Dim cPelanggan As New ctlPelanggan
    Dim cNk As New ctlNotaKontan
    Dim cPesanan As New ctlPesanan
    Dim cFaktur As New ctlFaktur
    Dim cKwitansi As New ctlKwitansi
    Dim cSj As New ctlSJ

#Region "Properties"
    Public WriteOnly Property table() As Integer
        Set(ByVal value As Integer)
            _table = value
        End Set
    End Property

    Public ReadOnly Property keyValue() As String
        Get
            Return _keyValue
        End Get
    End Property

    Public ReadOnly Property fld() As String
        Get
            Return gM.fieldValue(cboFilter.Text)
        End Get
    End Property
#End Region

#Region "ListViewHeader"
    Private Sub AddLvwColumns()
        With lvw.Columns
            .Clear()
            Select Case _table
                Case Is = gM.dbTable.Barang
                    .Add("Kode Barang", 90)
                    .Add("Nama Barang", 90)
                    .Add("Satuan", 90)
                    .Add("Harga Satuan", 90, HorizontalAlignment.Right)
                    .Add("Stok", 90, HorizontalAlignment.Right)
                    .Add("Kode Sub Kategori", 90)
                Case Is = gM.dbTable.Pelanggan
                    .Add("Kode Pelanggan", 90)
                    .Add("Nama Pelanggan", 90)
                    .Add("Alamat", 90)
                    .Add("No. Telepon", 90)
                Case Is = gM.dbTable.Pesanan
                    .Add("No. SP", 90)
                    .Add("Tgl. SP", 90)
                    .Add("Kode Pelanggan", 90)
                Case Is = gM.dbTable.Faktur
                    .Add("No. Faktur", 90)
                    .Add("Tgl. Faktur", 90)
                    .Add("No. SP", 90)
                Case Is = gM.dbTable.Kwitansi
                    .Add("No. Kwitansi", 90)
                    .Add("Tgl. Kwitansi", 90)
                    .Add("No. Faktur", 90)
                Case Is = gM.dbTable.SJ
                    .Add("No. SJ", 90)
                    .Add("Tgl. SJ", 90)
                    .Add("No. Polisi", 90)
                    .Add("No. Faktur", 90)
            End Select
        End With
    End Sub
#End Region

#Region "FillComboBox"
    Private Sub AddCboItems()
        With cboFilter.Items
            .Clear()
            Select Case _table
                Case Is = gM.dbTable.Barang
                    .Add("Kode Barang")
                    .Add("Nama Barang")
                    .Add("Kode Sub Kategori")
                Case Is = gM.dbTable.Pelanggan
                    .Add("Kode Pelanggan")
                    .Add("Nama Pelanggan")
                    .Add("Alamat")
                Case Is = gM.dbTable.Pesanan
                    .Add("No. SP")
                    .Add("Kode Pelanggan")
                Case Is = gM.dbTable.Faktur
                    .Add("No. Faktur")
                    .Add("No. SP")
                Case Is = gM.dbTable.Kwitansi
                    .Add("No. Kwitansi")
                    .Add("No. Faktur")
                Case Is = gM.dbTable.SJ
                    .Add("No. SJ")
                    .Add("No. Polisi")
                    .Add("No. Faktur")
            End Select
        End With
    End Sub
#End Region

#Region "FillListView"
    Private Sub fillLvwPelanggan(ByVal arrLst As ArrayList)
        lvw.Items.Clear()
        If arrLst.Count > 0 Then
            Dim i As Integer
            For i = 0 To arrLst.Count - 1
                Dim objData As Pelanggan = CType(arrLst(i), Pelanggan)
                With lvw.Items.Add(objData.kdPlg)
                    .SubItems.Add(objData.nmPlg)
                    .SubItems.Add(objData.alamat)
                    .SubItems.Add(objData.telp)
                End With
            Next
        End If
    End Sub

    Private Sub fillLvwBarang(ByVal arrLst As ArrayList)
        lvw.Items.Clear()
        If arrLst.Count > 0 Then
            Dim i As Integer
            For i = 0 To arrLst.Count - 1
                Dim objData As Barang = CType(arrLst(i), Barang)
                With lvw.Items.Add(objData.kdBrg)
                    .SubItems.Add(objData.nmBrg)
                    .SubItems.Add(objData.satuan)
                    .SubItems.Add(FormatNumber(CInt(objData.harga), 0))
                    .SubItems.Add(objData.stok.ToString)
                    .SubItems.Add(objData.kdSub)
                End With
            Next
        End If
    End Sub

    Private Sub fillLvwPesanan(ByVal arrLst As ArrayList)
        lvw.Items.Clear()
        If arrLst.Count > 0 Then
            Dim i As Integer
            For i = 0 To arrLst.Count - 1
                Dim objData As Pesanan = CType(arrLst(i), Pesanan)
                With lvw.Items.Add(objData.noSp)
                    .SubItems.Add(objData.tglSp.ToShortDateString)
                    .SubItems.Add(objData.kdPlg)
                End With
            Next
        End If
    End Sub

    Private Sub fillLvwFaktur(ByVal arrLst As ArrayList)
        lvw.Items.Clear()
        If arrLst.Count > 0 Then
            Dim i As Integer
            For i = 0 To arrLst.Count - 1
                Dim objData As Faktur = CType(arrLst(i), Faktur)
                With lvw.Items.Add(objData.noFaktur)
                    .SubItems.Add(objData.tglFaktur.ToShortDateString)
                    .SubItems.Add(objData.noSp)
                End With
            Next
        End If
    End Sub

    Private Sub fillLvwKwitansi(ByVal arrLst As ArrayList)
        lvw.Items.Clear()
        If arrLst.Count > 0 Then
            Dim i As Integer
            For i = 0 To arrLst.Count - 1
                Dim objData As Kwitansi = CType(arrLst(i), Kwitansi)
                With lvw.Items.Add(objData.noKwt)
                    .SubItems.Add(objData.tglKwt.ToShortDateString)
                    .SubItems.Add(objData.noFaktur)
                End With
            Next
        End If
    End Sub

    Private Sub fillLvwSJ(ByVal arrLst As ArrayList)
        lvw.Items.Clear()
        If arrLst.Count > 0 Then
            Dim i As Integer
            For i = 0 To arrLst.Count - 1
                Dim objData As SJ = CType(arrLst(i), SJ)
                With lvw.Items.Add(objData.noSj)
                    .SubItems.Add(objData.tglSj.ToShortDateString)
                    .SubItems.Add(objData.noPol)
                    .SubItems.Add(objData.noFaktur)
                End With
            Next
        End If
    End Sub
#End Region

    Private Sub frmBrowse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, txtKey.KeyDown, lvw.KeyDown
        gM.cekLockKeysOnKeyDown(e)
    End Sub

    Private Sub frmBrowse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddLvwColumns()
        AddCboItems()
        cboFilter.SelectedIndex = 0
    End Sub

    Private Sub btnAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAll.Click
        Select Case _table
            Case Is = gM.dbTable.Barang
                fillLvwBarang(cBarang.arrAll)
            Case Is = gM.dbTable.Pelanggan
                fillLvwPelanggan(cPelanggan.arrAll)
            Case Is = gM.dbTable.Pesanan
                fillLvwPesanan(cPesanan.arrAll)
            Case Is = gM.dbTable.Faktur
                fillLvwFaktur(cFaktur.arrAll)
            Case Is = gM.dbTable.Kwitansi
                fillLvwKwitansi(cKwitansi.arrAll)
            Case Is = gM.dbTable.SJ
                fillLvwSJ(cSj.arrAll)
        End Select
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click, lvw.DoubleClick
        Try
            _keyValue = lvw.SelectedItems(0).SubItems(0).Text
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Pilih data yang akan diproses", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtKey_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKey.KeyPress
        gM.noInject(e)
    End Sub

    Private Sub txtKey_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKey.TextChanged
        If txtKey.Text.Trim = String.Empty Then
            lvw.Items.Clear()
            Exit Sub
        End If
        Select Case _table
            Case Is = gM.dbTable.Barang
                fillLvwBarang(cBarang.arrByPrefix(fld, txtKey.Text.Trim))
            Case Is = gM.dbTable.Pelanggan
                fillLvwPelanggan(cPelanggan.arrByPrefix(fld, txtKey.Text.Trim))
            Case Is = gM.dbTable.Pesanan
                fillLvwPesanan(cPesanan.arrByPrefix(fld, txtKey.Text.Trim))
            Case Is = gM.dbTable.Faktur
                fillLvwFaktur(cFaktur.arrByPrefix(fld, txtKey.Text.Trim))
            Case Is = gM.dbTable.Kwitansi
                fillLvwKwitansi(cKwitansi.arrByPrefix(fld, txtKey.Text.Trim))
            Case Is = gM.dbTable.SJ
                fillLvwSJ(cSj.arrByPrefix(fld, txtKey.Text.Trim))
        End Select
    End Sub

    Private Sub cboFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFilter.SelectedIndexChanged
        txtKey.Clear()
    End Sub

    Private Sub frmBrowse_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim i As Integer
        For i = 0 To lvw.Columns.Count - 1
            If Me.Width > My.Computer.Screen.WorkingArea.Width * 2 / 3 Then
                lvw.Columns(i).Width = 150
            Else
                lvw.Columns(i).Width = 90
            End If
        Next
    End Sub

    Private Sub lvw_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvw.SelectedIndexChanged

    End Sub
End Class