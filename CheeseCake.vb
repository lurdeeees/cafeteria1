Public Class CheeseCake
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Menu1.Show()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txt_cantidadcheesecake.TextChanged

    End Sub

    Private Sub CheeseCake_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dg_cheesecake.Columns.Add("codigo", "Código")
        dg_cheesecake.Columns.Add("descripcion", "Descripcion")
        dg_cheesecake.Columns.Add("cantidad", "Cantidad")
        dg_cheesecake.Columns.Add("precio unitario", "Precio Unitario")
        dg_cheesecake.Columns.Add("compra por", "Compra por: ")
        dg_cheesecake.Columns.Add("total", "Total")
        dg_cheesecake.Columns.Add("descuento", "Descuento")
    End Sub

    Private Sub bt_añadir_Click(sender As Object, e As EventArgs) Handles bt_añadir.Click
        dg_cheesecake.Rows.Add(txt_codigocheesecake.Text, txt_descripcheesecake.Text, txt_cantidadcheesecake.Text, txt_preciounicheesecake.Text, txt_compraporcheesecake.Text, txt_totalcheesecake.Text, txt_descuentocheesecake.Text)
        txt_codigocheesecake.Text = String.Empty
        txt_descripcheesecake.Text = String.Empty
        txt_cantidadcheesecake.Text = String.Empty
        txt_preciounicheesecake.Text = String.Empty
        txt_compraporcheesecake.Text = String.Empty
        txt_totalcheesecake.Text = String.Empty
        txt_descuentocheesecake.Text = String.Empty
    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        dg_cheesecake.Rows.RemoveAt(fila)
    End Sub

    Private Sub dg_cheesecake_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_cheesecake.CellContentClick

    End Sub
    Public fila As Integer
    Private Sub dg_cheesecake_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_cheesecake.CellClick
        fila = 0
        dg_cheesecake.CurrentCell.RowIndex.ToString()
    End Sub

    Private Sub bt_buscar_Click(sender As Object, e As EventArgs) Handles bt_buscar.Click
        Me.Hide()
        BuscarCheesacake.Show()
    End Sub

    Private Sub bt_guardar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bt_modificar_Click(sender As Object, e As EventArgs) Handles bt_modificar.Click

    End Sub

    Private Sub txt_cantidadcheesecake_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidadcheesecake.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub

    Private Sub txt_preciounicheesecake_TextChanged(sender As Object, e As EventArgs) Handles txt_preciounicheesecake.TextChanged

    End Sub

    Private Sub txt_preciounicheesecake_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_preciounicheesecake.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub

    Private Sub txt_totalcheesecake_TextChanged(sender As Object, e As EventArgs) Handles txt_totalcheesecake.TextChanged

    End Sub

    Private Sub txt_totalcheesecake_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_totalcheesecake.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub

    Private Sub txt_descuentocheesecake_TextChanged(sender As Object, e As EventArgs) Handles txt_descuentocheesecake.TextChanged

    End Sub

    Private Sub txt_descuentocheesecake_MouseEnter(sender As Object, e As EventArgs) Handles txt_descuentocheesecake.MouseEnter

    End Sub

    Private Sub txt_descuentocheesecake_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_descuentocheesecake.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub
End Class