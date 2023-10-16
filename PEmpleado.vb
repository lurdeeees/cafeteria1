Public Class PEmpleado
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_añadir.Click
        dg_datos.Rows.Add(txt_CodigoEmpleado.Text, txt_nombre.Text, txt_apellido.Text, txt_sueldo.Text, txt_boniIncentiva.Text, txt_devengado.Text, txt_descuento.Text)
        txt_CodigoEmpleado.Text = String.Empty
        txt_nombre.Text = String.Empty
        txt_apellido.Text = String.Empty
        txt_sueldo.Text = String.Empty
        txt_boniIncentiva.Text = String.Empty
        txt_devengado.Text = String.Empty
        txt_descuento.Text = String.Empty

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dg_datos.Columns.Add("codigo", "Código")
        dg_datos.Columns.Add("nombre", "Nombre")
        dg_datos.Columns.Add("apellido", "Apellido")
        dg_datos.Columns.Add("sueldo", "Sueldo")
        dg_datos.Columns.Add("bonificacion Incentiva", "Bonificación")
        dg_datos.Columns.Add("devengado", "Devengado")
        dg_datos.Columns.Add("descuento", "Descuento")

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        InterfazAdmin.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        BuscarPEmpleado.Show()
    End Sub

    Private Sub dg_datos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_datos.CellContentClick

    End Sub

    Public fila As Integer


    Private Sub dg_datos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_datos.CellClick
        fila = 0
        dg_datos.CurrentCell.RowIndex.ToString()
    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        dg_datos.Rows.RemoveAt(fila)
    End Sub

    Private Sub txt_sueldo_TextChanged(sender As Object, e As EventArgs) Handles txt_sueldo.TextChanged

    End Sub

    Private Sub txt_sueldo_QueryAccessibilityHelp(sender As Object, e As QueryAccessibilityHelpEventArgs) Handles txt_sueldo.QueryAccessibilityHelp

    End Sub

    Private Sub txt_sueldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_sueldo.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub

    Private Sub txt_boniIncentiva_TextChanged(sender As Object, e As EventArgs) Handles txt_boniIncentiva.TextChanged

    End Sub

    Private Sub txt_boniIncentiva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_boniIncentiva.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub

    Private Sub txt_devengado_TextChanged(sender As Object, e As EventArgs) Handles txt_devengado.TextChanged

    End Sub

    Private Sub txt_devengado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_devengado.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub

    Private Sub txt_descuento_TextChanged(sender As Object, e As EventArgs) Handles txt_descuento.TextChanged

    End Sub

    Private Sub txt_descuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_descuento.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub

    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged

    End Sub
End Class