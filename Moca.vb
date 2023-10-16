Public Class Moca
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Menu1.Show()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txt_cantidadMoca.TextChanged

    End Sub

    Private Sub Moca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dg_moca.Columns.Add("codigo", "Código")
        dg_moca.Columns.Add("descripcion", "Descripcion")
        dg_moca.Columns.Add("cantidad", "Cantidad")
        dg_moca.Columns.Add("precio unitario", "Precio Unitario")
        dg_moca.Columns.Add("compra por", "Compra por: ")
        dg_moca.Columns.Add("total", "Total")
        dg_moca.Columns.Add("descuento", "Descuento")
    End Sub

    Private Sub bt_añadir_Click(sender As Object, e As EventArgs) Handles bt_añadir.Click
        dg_moca.Rows.Add(txt_codigoMoca.Text, txt_descripMoca.Text, txt_cantidadMoca.Text, txt_precioUniMoca.Text, txt_compraporMoca.Text, txt_totalMoca.Text, txt_descuentoMoca.Text)
        txt_codigoMoca.Text = String.Empty
        txt_descripMoca.Text = String.Empty
        txt_cantidadMoca.Text = String.Empty
        txt_precioUniMoca.Text = String.Empty
        txt_compraporMoca.Text = String.Empty
        txt_totalMoca.Text = String.Empty
        txt_descuentoMoca.Text = String.Empty
    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        dg_moca.Rows.RemoveAt(fila)
    End Sub

    Private Sub dg_moca_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_moca.CellContentClick

    End Sub
    Public fila As Integer
    Private Sub dg_moca_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_moca.CellClick
        fila = 0
        dg_moca.CurrentCell.RowIndex.ToString()
    End Sub

    Private Sub bt_buscar_Click(sender As Object, e As EventArgs) Handles bt_buscar.Click
        Me.Hide()
        BuscarMoca.Show()
    End Sub

    Private Sub txt_cantidadMoca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidadMoca.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub

    Private Sub txt_precioUniMoca_TextChanged(sender As Object, e As EventArgs) Handles txt_precioUniMoca.TextChanged

    End Sub

    Private Sub txt_precioUniMoca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precioUniMoca.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub

    Private Sub txt_totalMoca_TextChanged(sender As Object, e As EventArgs) Handles txt_totalMoca.TextChanged

    End Sub

    Private Sub txt_totalMoca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_totalMoca.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub

    Private Sub txt_compraporMoca_TextChanged(sender As Object, e As EventArgs) Handles txt_compraporMoca.TextChanged

    End Sub

    Private Sub txt_compraporMoca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_compraporMoca.KeyPress

    End Sub

    Private Sub txt_descuentoMoca_TextChanged(sender As Object, e As EventArgs) Handles txt_descuentoMoca.TextChanged

    End Sub

    Private Sub txt_descuentoMoca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_descuentoMoca.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub
End Class