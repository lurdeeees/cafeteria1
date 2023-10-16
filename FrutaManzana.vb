Public Class FrutaManzana
    Private Sub FrutaManzana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dg_pmanzana.Columns.Add("codigo", "Código")
        dg_pmanzana.Columns.Add("descripcion", "Descripcion")
        dg_pmanzana.Columns.Add("cantidad", "Cantidad")
        dg_pmanzana.Columns.Add("precio unitario", "Precio Unitario")
        dg_pmanzana.Columns.Add("compra por", "Compra por: ")
        dg_pmanzana.Columns.Add("total", "Total")
        dg_pmanzana.Columns.Add("descuento", "Descuento")
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Menu1.Show()
    End Sub

    Private Sub bt_añadir_Click(sender As Object, e As EventArgs) Handles bt_añadir.Click
        dg_pmanzana.Rows.Add(txt_codigoM.Text, txt_descripM.Text, txt_cantidadM.Text, txt_precioUniM.Text, txt_compraporM.Text, txt_totalM.Text, txt_descuentoM.Text)
        txt_codigoM.Text = String.Empty
        txt_descripM.Text = String.Empty
        txt_cantidadM.Text = String.Empty
        txt_precioUniM.Text = String.Empty
        txt_compraporM.Text = String.Empty
        txt_totalM.Text = String.Empty
        txt_descuentoM.Text = String.Empty
    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        dg_pmanzana.Rows.RemoveAt(fila)
    End Sub

    Private Sub dg_pmanzana_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_pmanzana.CellContentClick

    End Sub
    Public fila As Integer
    Private Sub dg_pmanzana_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_pmanzana.CellClick
        fila = 0
        dg_pmanzana.CurrentCell.RowIndex.ToString()
    End Sub

    Private Sub bt_buscar_Click(sender As Object, e As EventArgs) Handles bt_buscar.Click
        Me.Hide()
        BuscarPManzana.Show()
    End Sub

    Private Sub txt_cantidadM_TextChanged(sender As Object, e As EventArgs) Handles txt_cantidadM.TextChanged

    End Sub

    Private Sub txt_cantidadM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidadM.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub

    Private Sub txt_precioUniM_TextChanged(sender As Object, e As EventArgs) Handles txt_precioUniM.TextChanged

    End Sub

    Private Sub txt_precioUniM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precioUniM.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub

    Private Sub txt_compraporM_TextChanged(sender As Object, e As EventArgs) Handles txt_compraporM.TextChanged

    End Sub

    Private Sub txt_compraporM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_compraporM.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub

    Private Sub txt_totalM_TextChanged(sender As Object, e As EventArgs) Handles txt_totalM.TextChanged

    End Sub

    Private Sub txt_totalM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_totalM.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub

    Private Sub txt_descuentoM_TextChanged(sender As Object, e As EventArgs) Handles txt_descuentoM.TextChanged

    End Sub

    Private Sub txt_descuentoM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_descuentoM.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub
End Class