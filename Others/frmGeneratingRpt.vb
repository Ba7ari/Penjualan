Option Strict On
Public Class frmGeneratingRpt
    Private _rptName, _field, _keyValue As String
    Private _akurat As Boolean
    Private _dibayar, _kembali As Double
    Private _tglAwal, _tglAkhir As Date
    Dim cPelanggan As New ctlPelanggan
    Dim cBarang As New ctlBarang
    Dim cNk As New ctlNotaKontan
    Dim cFaktur As New ctlFaktur
    Dim cKwitansi As New ctlKwitansi
    Dim cSj As New ctlSJ
    Dim cPesanan As New ctlPesanan
    Dim cJurnal As New ctlJurnal

#Region "Properties"
    Public WriteOnly Property rptName() As String
        Set(ByVal value As String)
            _rptName = value
        End Set
    End Property

    Public WriteOnly Property field() As String
        Set(ByVal value As String)
            _field = value
        End Set
    End Property

    Public WriteOnly Property keyValue() As String
        Set(ByVal value As String)
            _keyValue = value
        End Set
    End Property

    Public WriteOnly Property akurat() As Boolean
        Set(ByVal value As Boolean)
            _akurat = value
        End Set
    End Property

    Public WriteOnly Property tglAwal() As Date
        Set(ByVal value As Date)
            _tglAwal = value
        End Set
    End Property

    Public WriteOnly Property tglAkhir() As Date
        Set(ByVal value As Date)
            _tglAkhir = value
        End Set
    End Property

    Public WriteOnly Property dibayar() As Double
        Set(ByVal value As Double)
            _dibayar = value
        End Set
    End Property

    Public WriteOnly Property kembali() As Double
        Set(ByVal value As Double)
            _kembali = value
        End Set
    End Property
#End Region

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(10)
        If ProgressBar1.Value = 80 Then
            Label1.Text = "Silakan Tunggu..."
        ElseIf ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Dispose()
            Me.Close()
        End If
    End Sub

    Private Sub frmGeneratingRpt_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim frm As New frmRptViewer
        Select Case _rptName
            Case Is = "rptPelanggan"
                Dim rpt As New crPelanggan
                If _akurat Then
                    rpt.SetDataSource(cPelanggan.tblByKey(_field, _keyValue))
                Else
                    rpt.SetDataSource(cPelanggan.tblByPrefix(_field, _keyValue))
                End If
                frm.CrystalReportViewer1.ReportSource = rpt
            Case Is = "rptBarang"
                Dim rpt As New crBarang
                If _akurat Then
                    rpt.SetDataSource(cBarang.tblByKey(_field, _keyValue))
                Else
                    rpt.SetDataSource(cBarang.tblByPrefix(_field, _keyValue))
                End If
                frm.CrystalReportViewer1.ReportSource = rpt
                frm.CrystalReportViewer1.Zoom(90)
            Case Is = "rptFaktur"
                Dim rpt As New crFaktur
                cFaktur.noFaktur = _keyValue
                rpt.SetDataSource(cFaktur.tblByPK)
                frm.CrystalReportViewer1.ReportSource = rpt
            Case Is = "rptNotaKontan"
                Dim rpt As New crNotaKontan
                cNk.noNk = _keyValue
                rpt.SetDataSource(cNk.tblByPK)
                rpt.SetParameterValue("dibayar", _dibayar)
                rpt.SetParameterValue("kembali", _kembali)
                frm.CrystalReportViewer1.ReportSource = rpt
            Case Is = "rptKwitansi"
                Dim rpt As New crKwitansi
                cKwitansi.noKwt = _keyValue
                rpt.SetDataSource(cKwitansi.tblByPK)
                frm.CrystalReportViewer1.ReportSource = rpt
            Case Is = "rptSJ"
                Dim rpt As New crSJ
                cSj.noSj = _keyValue
                rpt.SetDataSource(cSj.tblByPK)
                frm.CrystalReportViewer1.ReportSource = rpt
            Case Is = "rptPenjualanKontan"
                Dim rpt As New crPenjualanKontan
                rpt.SetDataSource(cNk.tblPenjualanKontan)
                rpt.SetParameterValue("tglAwal", _tglAwal)
                rpt.SetParameterValue("tglAkhir", _tglAkhir)
                frm.CrystalReportViewer1.ReportSource = rpt
            Case Is = "rptPenjualanPesan"
                Dim rpt As New crPenjualanPesan
                rpt.SetDataSource(cPesanan.tblPenjualanPesan)
                rpt.SetParameterValue("tglAwal", _tglAwal)
                rpt.SetParameterValue("tglAkhir", _tglAkhir)
                frm.CrystalReportViewer1.ReportSource = rpt
                frm.CrystalReportViewer1.Zoom(90)
            Case Is = "rptPengiriman"
                Dim rpt As New crPengiriman
                rpt.SetDataSource(cSj.tblPengiriman)
                rpt.SetParameterValue("tglAwal", _tglAwal)
                rpt.SetParameterValue("tglAkhir", _tglAkhir)
                frm.CrystalReportViewer1.ReportSource = rpt
                frm.CrystalReportViewer1.Zoom(90)
            Case Is = "rptTopTen"
                Dim rpt As New crTopTen
                rpt.SetDataSource(cBarang.tblTopTen(_tglAwal, _tglAkhir))
                rpt.SetParameterValue("tglAwal", _tglAwal)
                rpt.SetParameterValue("tglAkhir", _tglAkhir)
                frm.CrystalReportViewer1.ReportSource = rpt
                frm.CrystalReportViewer1.Zoom(90)
            Case Is = "rptNotSaleable"
                Dim rpt As New crNotSaleable
                rpt.SetDataSource(cBarang.tblNotSaleable(_tglAwal, _tglAkhir))
                rpt.SetParameterValue("tglAwal", _tglAwal)
                rpt.SetParameterValue("tglAkhir", _tglAkhir)
                frm.CrystalReportViewer1.ReportSource = rpt
                frm.CrystalReportViewer1.Zoom(90)
            Case Is = "rptJurnalUmum"
                Dim rpt As New crJurnalUmum
                rpt.SetDataSource(cJurnal.tblJurnalUmum)
                rpt.SetParameterValue("tglAwal", _tglAwal)
                rpt.SetParameterValue("tglAkhir", _tglAkhir)
                frm.CrystalReportViewer1.ReportSource = rpt
                frm.CrystalReportViewer1.Zoom(90)
            Case Is = "rptPenerimaanKas"
                Dim rpt As New crPenerimaanKas
                rpt.SetParameterValue("tglAwal", _tglAwal)
                rpt.SetParameterValue("tglAkhir", _tglAkhir)
                frm.CrystalReportViewer1.ReportSource = rpt
        End Select
        If _rptName = "rptPelanggan" Or _rptName = "rptBarang" Then
            If _keyValue = String.Empty Then
                Select Case _rptName
                    Case Is = "rptPelanggan"
                        Dim rpt As New crPelanggan
                        rpt.SetDataSource(cPelanggan.tblByPrefix(_field, ""))
                        frm.CrystalReportViewer1.ReportSource = rpt
                    Case Is = "rptBarang"
                        Dim rpt As New crBarang
                        rpt.SetDataSource(cBarang.tblByPrefix(_field, ""))
                        frm.CrystalReportViewer1.ReportSource = rpt
                        frm.CrystalReportViewer1.Zoom(90)
                End Select
            End If
        End If
        frm.ShowDialog()
    End Sub

    Private Sub frmGeneratingRpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _rptName = "rptNotaKontan" Then
            Label1.Text = "Saving..."
        Else
            Label1.Text = "Loading..."
        End If
        Timer1.Start()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class