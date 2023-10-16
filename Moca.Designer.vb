<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Moca
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.txt_descuentoMoca = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_TotalDevengado = New System.Windows.Forms.TextBox()
        Me.txt_totalMoca = New System.Windows.Forms.TextBox()
        Me.txt_compraporMoca = New System.Windows.Forms.TextBox()
        Me.txt_precioUniMoca = New System.Windows.Forms.TextBox()
        Me.txt_cantidadMoca = New System.Windows.Forms.TextBox()
        Me.txt_descripMoca = New System.Windows.Forms.TextBox()
        Me.txt_codigoMoca = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bt_enviar = New System.Windows.Forms.Button()
        Me.bt_buscar = New System.Windows.Forms.Button()
        Me.bt_eliminar = New System.Windows.Forms.Button()
        Me.bt_modificar = New System.Windows.Forms.Button()
        Me.bt_añadir = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dg_moca = New System.Windows.Forms.DataGridView()
        CType(Me.dg_moca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(720, 316)
        Me.Button9.Margin = New System.Windows.Forms.Padding(2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(107, 50)
        Me.Button9.TabIndex = 126
        Me.Button9.Text = "Regresar"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'txt_descuentoMoca
        '
        Me.txt_descuentoMoca.Location = New System.Drawing.Point(130, 251)
        Me.txt_descuentoMoca.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_descuentoMoca.Name = "txt_descuentoMoca"
        Me.txt_descuentoMoca.Size = New System.Drawing.Size(125, 20)
        Me.txt_descuentoMoca.TabIndex = 125
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 251)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 124
        Me.Label8.Text = "Descuento"
        '
        'txt_TotalDevengado
        '
        Me.txt_TotalDevengado.Location = New System.Drawing.Point(457, 392)
        Me.txt_TotalDevengado.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_TotalDevengado.Name = "txt_TotalDevengado"
        Me.txt_TotalDevengado.Size = New System.Drawing.Size(125, 20)
        Me.txt_TotalDevengado.TabIndex = 122
        '
        'txt_totalMoca
        '
        Me.txt_totalMoca.Location = New System.Drawing.Point(130, 217)
        Me.txt_totalMoca.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_totalMoca.Name = "txt_totalMoca"
        Me.txt_totalMoca.Size = New System.Drawing.Size(125, 20)
        Me.txt_totalMoca.TabIndex = 121
        '
        'txt_compraporMoca
        '
        Me.txt_compraporMoca.Location = New System.Drawing.Point(130, 185)
        Me.txt_compraporMoca.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_compraporMoca.Name = "txt_compraporMoca"
        Me.txt_compraporMoca.Size = New System.Drawing.Size(125, 20)
        Me.txt_compraporMoca.TabIndex = 120
        '
        'txt_precioUniMoca
        '
        Me.txt_precioUniMoca.Location = New System.Drawing.Point(130, 150)
        Me.txt_precioUniMoca.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_precioUniMoca.Name = "txt_precioUniMoca"
        Me.txt_precioUniMoca.Size = New System.Drawing.Size(125, 20)
        Me.txt_precioUniMoca.TabIndex = 119
        '
        'txt_cantidadMoca
        '
        Me.txt_cantidadMoca.Location = New System.Drawing.Point(130, 112)
        Me.txt_cantidadMoca.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cantidadMoca.Name = "txt_cantidadMoca"
        Me.txt_cantidadMoca.Size = New System.Drawing.Size(125, 20)
        Me.txt_cantidadMoca.TabIndex = 118
        '
        'txt_descripMoca
        '
        Me.txt_descripMoca.Location = New System.Drawing.Point(130, 72)
        Me.txt_descripMoca.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_descripMoca.Name = "txt_descripMoca"
        Me.txt_descripMoca.Size = New System.Drawing.Size(125, 20)
        Me.txt_descripMoca.TabIndex = 117
        '
        'txt_codigoMoca
        '
        Me.txt_codigoMoca.Location = New System.Drawing.Point(130, 26)
        Me.txt_codigoMoca.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_codigoMoca.Name = "txt_codigoMoca"
        Me.txt_codigoMoca.Size = New System.Drawing.Size(125, 20)
        Me.txt_codigoMoca.TabIndex = 116
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(363, 399)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "Total Devengado"
        '
        'bt_enviar
        '
        Me.bt_enviar.Location = New System.Drawing.Point(250, 382)
        Me.bt_enviar.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_enviar.Name = "bt_enviar"
        Me.bt_enviar.Size = New System.Drawing.Size(99, 46)
        Me.bt_enviar.TabIndex = 114
        Me.bt_enviar.Text = "Enviar"
        Me.bt_enviar.UseVisualStyleBackColor = True
        '
        'bt_buscar
        '
        Me.bt_buscar.Location = New System.Drawing.Point(331, 322)
        Me.bt_buscar.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_buscar.Name = "bt_buscar"
        Me.bt_buscar.Size = New System.Drawing.Size(99, 46)
        Me.bt_buscar.TabIndex = 112
        Me.bt_buscar.Text = "Buscar"
        Me.bt_buscar.UseVisualStyleBackColor = True
        '
        'bt_eliminar
        '
        Me.bt_eliminar.Location = New System.Drawing.Point(217, 322)
        Me.bt_eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(99, 46)
        Me.bt_eliminar.TabIndex = 110
        Me.bt_eliminar.Text = "Eliminar"
        Me.bt_eliminar.UseVisualStyleBackColor = True
        '
        'bt_modificar
        '
        Me.bt_modificar.Location = New System.Drawing.Point(114, 322)
        Me.bt_modificar.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Size = New System.Drawing.Size(99, 46)
        Me.bt_modificar.TabIndex = 109
        Me.bt_modificar.Text = "Modificar"
        Me.bt_modificar.UseVisualStyleBackColor = True
        '
        'bt_añadir
        '
        Me.bt_añadir.Location = New System.Drawing.Point(11, 322)
        Me.bt_añadir.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_añadir.Name = "bt_añadir"
        Me.bt_añadir.Size = New System.Drawing.Size(99, 46)
        Me.bt_añadir.TabIndex = 108
        Me.bt_añadir.Text = "Añadir"
        Me.bt_añadir.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 217)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 185)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Compra por :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 153)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Precio Unitario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 115)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 72)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Codigo"
        '
        'dg_moca
        '
        Me.dg_moca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_moca.Location = New System.Drawing.Point(296, 33)
        Me.dg_moca.Name = "dg_moca"
        Me.dg_moca.Size = New System.Drawing.Size(531, 278)
        Me.dg_moca.TabIndex = 127
        '
        'Moca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 458)
        Me.Controls.Add(Me.dg_moca)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.txt_descuentoMoca)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_TotalDevengado)
        Me.Controls.Add(Me.txt_totalMoca)
        Me.Controls.Add(Me.txt_compraporMoca)
        Me.Controls.Add(Me.txt_precioUniMoca)
        Me.Controls.Add(Me.txt_cantidadMoca)
        Me.Controls.Add(Me.txt_descripMoca)
        Me.Controls.Add(Me.txt_codigoMoca)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.bt_enviar)
        Me.Controls.Add(Me.bt_buscar)
        Me.Controls.Add(Me.bt_eliminar)
        Me.Controls.Add(Me.bt_modificar)
        Me.Controls.Add(Me.bt_añadir)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Moca"
        Me.Text = "Moca"
        CType(Me.dg_moca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button9 As Button
    Friend WithEvents txt_descuentoMoca As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_TotalDevengado As TextBox
    Friend WithEvents txt_totalMoca As TextBox
    Friend WithEvents txt_compraporMoca As TextBox
    Friend WithEvents txt_precioUniMoca As TextBox
    Friend WithEvents txt_cantidadMoca As TextBox
    Friend WithEvents txt_descripMoca As TextBox
    Friend WithEvents txt_codigoMoca As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents bt_enviar As Button
    Friend WithEvents bt_buscar As Button
    Friend WithEvents bt_eliminar As Button
    Friend WithEvents bt_modificar As Button
    Friend WithEvents bt_añadir As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dg_moca As DataGridView
End Class
