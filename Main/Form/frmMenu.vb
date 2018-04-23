Option Strict On
Public Class frmMenu
    Private Sub EntryDataBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryDataBarangToolStripMenuItem.Click
        Dim frm As New frmBarang
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub EntryDataPelangganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryDataPelangganToolStripMenuItem.Click
        Dim frm As New frmPelanggan
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub EntryDataKendaraanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryDataKendaraanToolStripMenuItem.Click
        Dim frm As New frmDaftar
        frm.MdiParent = Me
        frm.table = gM.dbTable.Kendaraan
        frm.Show()
    End Sub

    Private Sub EntryDataPesananToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryDataPesananToolStripMenuItem.Click
        Dim frm As New frmPesanan
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CetakFakturToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakFakturToolStripMenuItem.Click
        Dim frm As New frmFaktur
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CetakSuratJalanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakSuratJalanToolStripMenuItem.Click
        Dim frm As New frmSJ
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CetakKwitansiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakKwitansiToolStripMenuItem.Click
        Dim frm As New frmKwitansi
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Benar ingin keluar dari aplikasi?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub EntryDataRekeningToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryDataRekeningToolStripMenuItem.Click
        Dim frm As New frmDaftar
        frm.MdiParent = Me
        frm.table = gM.dbTable.Rekening
        frm.Show()
    End Sub

    Private Sub LaporanPenjualanPesanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPenjualanPesanToolStripMenuItem.Click
        Dim frm As New frmCetak2
        frm.rptName = "rptPenjualanPesan"
        frm.ShowDialog()
    End Sub

    Private Sub LaporanPengirimanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPengirimanToolStripMenuItem.Click
        Dim frm As New frmCetak2
        frm.rptName = "rptPengiriman"
        frm.ShowDialog()
    End Sub

    Private Sub LaporanData10BarangTerlarisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanData10BarangTerlarisToolStripMenuItem.Click
        Dim frm As New frmCetak2
        frm.rptName = "rptTopTen"
        frm.ShowDialog()
    End Sub

    Private Sub LaporanDataBarangTidakLakuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanDataBarangTidakLakuToolStripMenuItem.Click
        Dim frm As New frmCetak2
        frm.rptName = "rptNotSaleable"
        frm.ShowDialog()
    End Sub

    Private Sub JurnalUmumToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JurnalUmumToolStripMenuItem.Click
        Dim frm As New frmCetak2
        frm.rptName = "rptJurnalUmum"
        frm.ShowDialog()
    End Sub

    Private Sub JurnalPenerimaanKasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JurnalPenerimaanKasToolStripMenuItem.Click
        Dim frm As New frmCetak2
        frm.rptName = "rptPenerimaanKas"
        frm.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmAbout
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub frmMenu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.KeluarToolStripMenuItem.PerformClick()
        End If
    End Sub

    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, MyBase.GotFocus
        MyBase.Focus()
        gM.cekLockKeys()
        lblStatus.Text = "Ready"
        lblTgl.Text = Today.ToShortDateString
    End Sub

    Private Sub frmMenu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        gM.cekLockKeysOnKeyDown(e)
    End Sub

    Private Sub CetakNotaKontanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakNotaKontanToolStripMenuItem.Click
        Dim frm As New frmNotaKontan
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub LaporanPenjualanKontanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPenjualanKontanToolStripMenuItem.Click
        Dim frm As New frmCetak2
        frm.rptName = "rptPenjualanKontan"
        frm.ShowDialog()
    End Sub

    Private Sub ToolStripSeparator2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSeparator2.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim frm As New frmAbout
        frm.MdiParent = Me
        frm.Show()

    End Sub
End Class