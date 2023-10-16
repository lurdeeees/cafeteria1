Public Class MenuInicio
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Me.Hide()
        InicioSesion.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        PedidosClientes.Show()
    End Sub
End Class