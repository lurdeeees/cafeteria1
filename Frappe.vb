Public Class Frappe
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Menu1.Show()
    End Sub

    Private Sub Frappe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dg_frappe.Columns.Add("codigo", "Código")
        dg_frappe.Columns.Add("descripcion", "Descripcion")
        dg_frappe.Columns.Add("cantidad", "Cantidad")
        dg_frappe.Columns.Add("precio unitario", "Precio Unitario")
        dg_frappe.Columns.Add("compra por", "Compra por: ")
        dg_frappe.Columns.Add("total", "Total")
        dg_frappe.Columns.Add("descuento", "Descuento")
    End Sub

    Private Sub bt_añadir_Click(sender As Object, e As EventArgs) Handles bt_añadir.Click
        dg_frappe.Rows.Add(txt_codigoFrapp.Text, txt_descripFrapp.Text, txt_cantidadFrapp.Text, txt_precioUniFrapp.Text, txt_compraporFrapp.Text, txt_totalFrapp.Text, txt_descuentoFrapp.Text)
        txt_codigoFrapp.Text = String.Empty
        txt_descripFrapp.Text = String.Empty
        txt_cantidadFrapp.Text = String.Empty
        txt_precioUniFrapp.Text = String.Empty
        txt_compraporFrapp.Text = String.Empty
        txt_totalFrapp.Text = String.Empty
        txt_descuentoFrapp.Text = String.Empty
    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        dg_frappe.Rows.RemoveAt(fila)
    End Sub

    Private Sub dg_frappe_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_frappe.CellContentClick

    End Sub
    Public fila As Integer
    Private Sub dg_frappe_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_frappe.CellClick
        fila = 0
        dg_frappe.CurrentCell.RowIndex.ToString()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        BuscarFrappe.Show()
    End Sub

    Private Sub txt_cantidadFrapp_TextChanged(sender As Object, e As EventArgs) Handles txt_cantidadFrapp.TextChanged

    End Sub

    Private Sub txt_cantidadFrapp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidadFrapp.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub

    Private Sub txt_precioUniFrapp_TextChanged(sender As Object, e As EventArgs) Handles txt_precioUniFrapp.TextChanged

    End Sub

    Private Sub txt_precioUniFrapp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precioUniFrapp.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub

    Private Sub txt_compraporFrapp_TextChanged(sender As Object, e As EventArgs) Handles txt_compraporFrapp.TextChanged

    End Sub

    Private Sub txt_totalFrapp_TextChanged(sender As Object, e As EventArgs) Handles txt_totalFrapp.TextChanged

    End Sub

    Private Sub txt_totalFrapp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_totalFrapp.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub

    Private Sub txt_descuentoFrapp_TextChanged(sender As Object, e As EventArgs) Handles txt_descuentoFrapp.TextChanged

    End Sub

    Private Sub txt_descuentoFrapp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_descuentoFrapp.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub
End Class