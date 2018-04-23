Option Strict On
Namespace gM
    Module GlobalModule
        Public ReadOnly connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\penjualan.mdb;"

        Public Enum dbTable
            Barang = 0
            Kategori = 1
            SubKategori = 2
            Kendaraan = 3
            Rekening = 4
            Jurnal = 5
            Pelanggan = 6
            NotaKontan = 7
            Ada = 8
            Pesanan = 9
            Isi = 10
            Faktur = 11
            Kwitansi = 12
            SJ = 13
            Kirim = 14
        End Enum

        Public Function fieldValue(ByVal value As String) As String
            Select Case value
                Case "Kode Barang" : Return "kdbrg"
                Case "Nama Barang" : Return "nmbrg"
                Case "Kode Sub Kategori" : Return "kdsub"
                Case "Kode Pelanggan" : Return "kdplg"
                Case "Nama Pelanggan" : Return "nmplg"
                Case "Alamat" : Return "alamat"
                Case "No. Nota Kontan" : Return "nonk"
                Case "No. SP" : Return "nosp"
                Case "No. Faktur" : Return "nofaktur"
                Case "No. Kwitansi" : Return "nokwt"
                Case "No. SJ" : Return "nosj"
                Case "No. Polisi" : Return "nopol"
                Case "Merk Kendaraan" : Return "merkkend"
                Case "Jumlah Roda" : Return "jmlroda"
                Case "Bahan Bakar" : Return "bahanbakar"
                Case "Kode Rekening" : Return "kdrek"
                Case "Nama Rekening" : Return "nmrek"
                Case Else : Return Nothing
            End Select
        End Function

        Public Sub resCtrlTxt(ByVal parent As Control)
            For Each ctrl As Control In parent.Controls
                If TypeOf ctrl Is TextBox Then
                    ctrl.ResetText()
                End If
                If TypeOf ctrl Is ComboBox Then
                    If DirectCast(ctrl, ComboBox).Items.Count > 0 Then
                        DirectCast(ctrl, ComboBox).SelectedIndex = 0
                    End If
                End If
                If ctrl.TabIndex = 0 Then
                    ctrl.Focus()
                End If
                If ctrl.Controls.Count > 0 Then
                    resCtrlTxt(ctrl)
                End If
            Next
        End Sub

        Public Sub numOnly(ByVal e As KeyPressEventArgs)
            If Not ((Char.IsNumber(e.KeyChar)) Or (Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13)) Then
                e.Handled = True
            End If
        End Sub

        Public Sub noInject(ByVal e As KeyPressEventArgs)
            If e.KeyChar = "'" Or _
               e.KeyChar = "%" Or _
               e.KeyChar = "_" Or _
               e.KeyChar = "[" Then
                e.Handled = True
            End If
        End Sub

        Public Sub cekLockKeys()
            If My.Computer.Keyboard.NumLock Then
                frmMenu.lblNum.Text = "NUM"
            Else
                frmMenu.lblNum.Text = ""
            End If

            If My.Computer.Keyboard.CapsLock Then
                frmMenu.lblCap.Text = "CAP"
            Else
                frmMenu.lblCap.Text = ""
            End If
        End Sub

        Public Sub cekLockKeysOnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = Keys.NumLock Or e.KeyCode = Keys.CapsLock Then
                cekLockKeys()
            End If
        End Sub
    End Module
End Namespace
