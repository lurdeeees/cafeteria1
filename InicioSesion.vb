Public Class InicioSesion
    Dim mensaje As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "gerente" And TextBox2.Text = "1234" Then
            InterfazAdmin.Show()
            Me.Hide()
        Else
            If TextBox1.Text = "trabajador" And TextBox2.Text = "21" Then
                Trabajador.Show()
                Me.Hide()


            Else
                MsgBox("La contraseña es incoreccta", MsgBoxStyle.Exclamation, "Error")
            End If

        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form1 As New Form1
        form1.Show()
    End Sub
End Class