Public Class MPrima
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Me.Hide()
        InterfazAdmin.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles bt_buscar.Click
        Me.Hide()
        BuscarMPrima.Show()
    End Sub

    Private Sub MPrima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dg_datosMP.Columns.Add("codigo", "Código")
        dg_datosMP.Columns.Add("descripcion", "Descripcion")
        dg_datosMP.Columns.Add("cantidad", "Cantidad")
        dg_datosMP.Columns.Add("precio", "Precio")
        dg_datosMP.Columns.Add("compra por", "Compra por: ")
        dg_datosMP.Columns.Add("total", "Total")
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        InterfazAdmin.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_AñadirMP.Click
        dg_datosMP.Rows.Add(txt_codigo.Text, txt_descripcion.Text, txt_cantidad.Text, txt_preci.Text, txt_comprapor.Text, txt_total.Text)
        txt_codigo.Text = String.Empty
        txt_descripcion.Text = String.Empty
        txt_cantidad.Text = String.Empty
        txt_preci.Text = String.Empty
        txt_comprapor.Text = String.Empty
        txt_total.Text = String.Empty

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        dg_datosMP.Rows.RemoveAt(fila)
    End Sub

    Private Sub dg_datosMP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_datosMP.CellContentClick

    End Sub

    Private Sub dg_datosMP_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dg_datosMP.CellEnter

    End Sub

    Public fila As Integer
    Private Sub dg_datosMP_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_datosMP.CellClick
        fila = 0
        dg_datosMP.CurrentCell.RowIndex.ToString()
    End Sub

    Private Sub txt_cantidad_TextChanged(sender As Object, e As EventArgs) Handles txt_cantidad.TextChanged

    End Sub

    Private Sub txt_cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub

    Private Sub txt_preci_TextChanged(sender As Object, e As EventArgs) Handles txt_preci.TextChanged

    End Sub

    Private Sub txt_preci_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_preci.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub

    Private Sub txt_total_TextChanged(sender As Object, e As EventArgs) Handles txt_total.TextChanged

    End Sub

    Private Sub txt_total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_total.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo se puede ingresar números")

        End If
    End Sub
End Class