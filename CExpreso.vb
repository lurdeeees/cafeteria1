Public Class CExpreso
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Menu1.Show()
    End Sub

    Private Sub CExpreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dg_Cexpreso.Columns.Add("codigo", "Código")
        dg_Cexpreso.Columns.Add("descripcion", "Descripcion")
        dg_Cexpreso.Columns.Add("cantidad", "Cantidad")
        dg_Cexpreso.Columns.Add("precio unitario", "Precio Unitario")
        dg_Cexpreso.Columns.Add("compra por", "Compra por: ")
        dg_Cexpreso.Columns.Add("total", "Total")
        dg_Cexpreso.Columns.Add("descuento", "Descuento")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_añadirCE.Click
        dg_Cexpreso.Rows.Add(txt_codigoCE.Text, txt_descripcionCE.Text, txt_cantidadCE.Text, txt_precioUnitarioCE.Text, txt_comparaporCE.Text, txt_totalCE.Text, txt_descuentoCE.Text)
        txt_codigoCE.Text = String.Empty
        txt_descripcionCE.Text = String.Empty
        txt_cantidadCE.Text = String.Empty
        txt_precioUnitarioCE.Text = String.Empty
        txt_comparaporCE.Text = String.Empty
        txt_totalCE.Text = String.Empty
        txt_descuentoCE.Text = String.Empty
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        dg_Cexpreso.Rows.RemoveAt(fila)
    End Sub

    Private Sub dg_Cexpreso_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_Cexpreso.CellContentClick

    End Sub
    Public fila As Integer
    Private Sub dg_Cexpreso_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_Cexpreso.CellClick
        fila = 0
        dg_Cexpreso.CurrentCell.RowIndex.ToString()
    End Sub

    Private Sub bt_buscar_Click(sender As Object, e As EventArgs) Handles bt_buscar.Click
        Me.Hide()
        BuscarCExpreso.Show()
    End Sub

    Private Sub txt_cantidadCE_TextChanged(sender As Object, e As EventArgs) Handles txt_cantidadCE.TextChanged

    End Sub

    Private Sub txt_cantidadCE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidadCE.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub

    Private Sub txt_precioUnitarioCE_TextChanged(sender As Object, e As EventArgs) Handles txt_precioUnitarioCE.TextChanged

    End Sub

    Private Sub txt_precioUnitarioCE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precioUnitarioCE.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub

    Private Sub txt_totalCE_TextChanged(sender As Object, e As EventArgs) Handles txt_totalCE.TextChanged

    End Sub

    Private Sub txt_totalCE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_totalCE.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub

    Private Sub txt_descuentoCE_TextChanged(sender As Object, e As EventArgs) Handles txt_descuentoCE.TextChanged

    End Sub

    Private Sub txt_descuentoCE_Paint(sender As Object, e As PaintEventArgs) Handles txt_descuentoCE.Paint

    End Sub

    Private Sub txt_descuentoCE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_descuentoCE.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub
End Class