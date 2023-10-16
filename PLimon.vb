Public Class PLimon
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Menu1.Show()
    End Sub

    Private Sub PLimon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dg_Plimon.Columns.Add("codigo", "Código")
        dg_Plimon.Columns.Add("descripcion", "Descripcion")
        dg_Plimon.Columns.Add("cantidad", "Cantidad")
        dg_Plimon.Columns.Add("precio unitario", "Precio Unitario")
        dg_Plimon.Columns.Add("compra por", "Compra por: ")
        dg_Plimon.Columns.Add("total", "Total")
        dg_Plimon.Columns.Add("descuento", "Descuento")
    End Sub

    Private Sub bt_añadir_Click(sender As Object, e As EventArgs) Handles bt_añadir.Click
        dg_Plimon.Rows.Add(txt_codigoPlimon.Text, txt_descripcionPlimon.Text, txt_cantidadPlimon.Text, txt_preciouniPlimon.Text, txt_compraporPlimon.Text, txt_totalPlimon.Text, txt_descuentoPlimon.Text)
        txt_codigoPlimon.Text = String.Empty
        txt_descripcionPlimon.Text = String.Empty
        txt_cantidadPlimon.Text = String.Empty
        txt_preciouniPlimon.Text = String.Empty
        txt_compraporPlimon.Text = String.Empty
        txt_totalPlimon.Text = String.Empty
        txt_descuentoPlimon.Text = String.Empty
    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        dg_Plimon.Rows.RemoveAt(fila)
    End Sub

    Public fila As Integer
    Private Sub dg_Plimon_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_Plimon.CellClick
        fila = 0
        dg_Plimon.CurrentCell.RowIndex.ToString()
    End Sub

    Private Sub bt_buscar_Click(sender As Object, e As EventArgs) Handles bt_buscar.Click
        Me.Hide()
        BuscarPlimon.Show()
    End Sub

    Private Sub txt_cantidadPlimon_TextChanged(sender As Object, e As EventArgs) Handles txt_cantidadPlimon.TextChanged

    End Sub

    Private Sub txt_cantidadPlimon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidadPlimon.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub

    Private Sub txt_preciouniPlimon_TextChanged(sender As Object, e As EventArgs) Handles txt_preciouniPlimon.TextChanged

    End Sub

    Private Sub txt_preciouniPlimon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_preciouniPlimon.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub

    Private Sub txt_totalPlimon_TextChanged(sender As Object, e As EventArgs) Handles txt_totalPlimon.TextChanged

    End Sub

    Private Sub txt_totalPlimon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_totalPlimon.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub

    Private Sub txt_descuentoPlimon_TextChanged(sender As Object, e As EventArgs) Handles txt_descuentoPlimon.TextChanged

    End Sub

    Private Sub txt_descuentoPlimon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_descuentoPlimon.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub
End Class