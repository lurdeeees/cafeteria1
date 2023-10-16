Imports System.Data.SqlClient

Public Class BuscarPEmpleado


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        PEmpleado.Show()
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dg_datosBuscar.Columns.Add("codigo", "Código")
        dg_datosBuscar.Columns.Add("nombre", "Nombre")
        dg_datosBuscar.Columns.Add("apellido", "Apellido")
        dg_datosBuscar.Columns.Add("sueldo", "Sueldo")
        dg_datosBuscar.Columns.Add("bonificacion Incentiva", "Bonificación")
        dg_datosBuscar.Columns.Add("devengado", "Devengado")
        dg_datosBuscar.Columns.Add("descuento", "Descuento")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


    End Sub

    Private Sub txt_buscarXcodigo_TextChanged(sender As Object, e As EventArgs) Handles txt_buscarXcodigo.TextChanged

    End Sub

    Private Sub txt_buscarXcodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_buscarXcodigo.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub
End Class