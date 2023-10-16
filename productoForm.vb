Imports System.Data.OleDb

Public Class productoForm
    Private da As OleDbDataAdapter
    Private ds As DataSet

    Private Sub productoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Poblar()

    End Sub
    Private Sub Poblar()
        da = New OleDb.OleDbDataAdapter("select Código, Descripción, Precio, Foto from producto where categoría = 'Frappe'", Conexion)
        ds = New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            DataGridView1.DataSource = Nothing
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If DataGridView1.Rows.Count > 0 Then
            txtID.Text = DataGridView1.CurrentRow.Cells("ID").Value
            txtPrecio.Text = DataGridView1.CurrentRow.Cells("Precio").Value.ToString
            txtDescripcion.Text = DataGridView1.CurrentRow.Cells("Descripcion").Value.ToString
            cboTipo.Text = DataGridView1.CurrentRow.Cells("Categoría").Value.ToString
            txtRuta.Text = DataGridView1.CurrentRow.Cells("Foto").Value.ToString

            PictureBox1.Image = Image.FromFile(txtRuta.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Limpiar()
    End Sub
    Private Sub Limpiar()
        txtID.Text = "0"
        txtDescripcion.Clear()
        txtPrecio.Clear()
        txtRuta.Clear()
        cboTipo.SelectedIndex = -1
        PictureBox1.Image = Nothing

        txtDescripcion.Focus()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtID.Text = "0" Then
            Dim cmd As New OleDb.OleDbCommand("Insert into producto(descripcion, precio, categoria, foto) values('" & txtDescripcion.Text & "','" & txtPrecio.Text) ')
        End If
    End Sub
End Class