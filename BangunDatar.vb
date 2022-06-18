Public Class BangunDatar
    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        luas.Text = panjang.Text * lebar.Text
        keliling.Text = (2 * panjang.Text) + (2 * lebar.Text)
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        luas.Text = ""
        keliling.Text = ""
        panjang.Text = ""
        lebar.Text = ""
    End Sub
End Class
