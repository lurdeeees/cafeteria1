Public Class PedidosClientes
    Public a, total As Double

    Private Sub BtnCalcula_Click(sender As Object, e As EventArgs) Handles BtnCalcula.Click
        TextBox1.Clear()
        If CEG.Checked = True Then
            a = 15
            total = total + a
        End If
        If CEM.Checked = True Then
            a = 10
            total = total + a
        End If
        If CEP.Checked = True Then
            a = 7
            total = total + a
        End If
        If CMG.Checked = True Then
            a = 16
            total = total + a
        End If
        If CMM.Checked = True Then
            a = 11
            total = total + a
        End If
        If CMP.Checked = True Then
            a = 8
            total = total + a
        End If
        If FG.Checked = True Then
            a = 20
            total = total + a
        End If
        If FM.Checked = True Then
            a = 15
            total = total + a
        End If
        If PL.Checked = True Then
            a = 65
            total = total + a
        End If
        If PM.Checked = True Then
            a = 60
            total = total + a
        End If
        If PCHEESAKE.Checked = True Then
            a = 70
            total = total + a
        End If
        TextBox1.Clear()
        TextBox1.Text = "Q" & total
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        total = 0
        TextBox1.Clear()
        ListaBox.Items.Clear()
        CEG.Checked = False
        CEM.Checked = False
        CEP.Checked = False
        CMG.Checked = False
        CMM.Checked = False
        CMP.Checked = False
        FG.Checked = False
        FM.Checked = False
        PL.Checked = False
        PM.Checked = False
        PCHEESAKE.Checked = False

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PedidosClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnOrden_Click(sender As Object, e As EventArgs) Handles BtnOrden.Click
        ListaBox.Items.Clear()
        If CEG.Checked = True Then
            ListaBox.Items.Add(ListMenu.Items(0))
        End If
        If CEM.Checked = True Then
            ListaBox.Items.Add(ListMenu.Items(1))
        End If
        If CEP.Checked = True Then
            ListaBox.Items.Add(ListMenu.Items(2))
        End If
        If CMG.Checked = True Then
            ListaBox.Items.Add(ListMenu.Items(3))
        End If
        If CMM.Checked = True Then
            ListaBox.Items.Add(ListMenu.Items(4))
        End If
        If CMP.Checked = True Then
            ListaBox.Items.Add(ListMenu.Items(5))
        End If
        If FG.Checked = True Then
            ListaBox.Items.Add(ListMenu.Items(6))
        End If
        If FM.Checked = True Then
            ListaBox.Items.Add(ListMenu.Items(7))
        End If
        If PL.Checked = True Then
            ListaBox.Items.Add(ListMenu.Items(8))
        End If
        If PM.Checked = True Then
            ListaBox.Items.Add(ListMenu.Items(9))
        End If
        If PCHEESAKE.Checked = True Then
            ListaBox.Items.Add(ListMenu.Items(10))
        End If
    End Sub
End Class