<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frappe
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
        Me.txt_descuentoFrapp = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.txt_totalFrapp = New System.Windows.Forms.TextBox()
        Me.txt_compraporFrapp = New System.Windows.Forms.TextBox()
        Me.txt_precioUniFrapp = New System.Windows.Forms.TextBox()
        Me.txt_cantidadFrapp = New System.Windows.Forms.TextBox()
        Me.txt_descripFrapp = New System.Windows.Forms.TextBox()
        Me.txt_codigoFrapp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.bt_eliminar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bt_añadir = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dg_frappe = New System.Windows.Forms.DataGridView()
        CType(Me.dg_frappe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(712, 333)
        Me.Button9.Margin = New System.Windows.Forms.Padding(2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(107, 50)
        Me.Button9.TabIndex = 101
        Me.Button9.Text = "Regresar"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'txt_descuentoFrapp
        '
        Me.txt_descuentoFrapp.Location = New System.Drawing.Point(145, 258)
        Me.txt_descuentoFrapp.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_descuentoFrapp.Name = "txt_descuentoFrapp"
        Me.txt_descuentoFrapp.Size = New System.Drawing.Size(125, 20)
        Me.txt_descuentoFrapp.TabIndex = 100
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 258)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "Descuento"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(486, 408)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(125, 20)
        Me.TextBox7.TabIndex = 97
        '
        'txt_totalFrapp
        '
        Me.txt_totalFrapp.Location = New System.Drawing.Point(145, 224)
        Me.txt_totalFrapp.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_totalFrapp.Name = "txt_totalFrapp"
        Me.txt_totalFrapp.Size = New System.Drawing.Size(125, 20)
        Me.txt_totalFrapp.TabIndex = 96
        '
        'txt_compraporFrapp
        '
        Me.txt_compraporFrapp.Location = New System.Drawing.Point(145, 189)
        Me.txt_compraporFrapp.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_compraporFrapp.Name = "txt_compraporFrapp"
        Me.txt_compraporFrapp.Size = New System.Drawing.Size(125, 20)
        Me.txt_compraporFrapp.TabIndex = 95
        '
        'txt_precioUniFrapp
        '
        Me.txt_precioUniFrapp.Location = New System.Drawing.Point(145, 153)
        Me.txt_precioUniFrapp.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_precioUniFrapp.Name = "txt_precioUniFrapp"
        Me.txt_precioUniFrapp.Size = New System.Drawing.Size(125, 20)
        Me.txt_precioUniFrapp.TabIndex = 94
        '
        'txt_cantidadFrapp
        '
        Me.txt_cantidadFrapp.Location = New System.Drawing.Point(145, 116)
        Me.txt_cantidadFrapp.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cantidadFrapp.Name = "txt_cantidadFrapp"
        Me.txt_cantidadFrapp.Size = New System.Drawing.Size(125, 20)
        Me.txt_cantidadFrapp.TabIndex = 93
        '
        'txt_descripFrapp
        '
        Me.txt_descripFrapp.Location = New System.Drawing.Point(145, 73)
        Me.txt_descripFrapp.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_descripFrapp.Name = "txt_descripFrapp"
        Me.txt_descripFrapp.Size = New System.Drawing.Size(125, 20)
        Me.txt_descripFrapp.TabIndex = 92
        '
        'txt_codigoFrapp
        '
        Me.txt_codigoFrapp.Location = New System.Drawing.Point(145, 31)
        Me.txt_codigoFrapp.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_codigoFrapp.Name = "txt_codigoFrapp"
        Me.txt_codigoFrapp.Size = New System.Drawing.Size(125, 20)
        Me.txt_codigoFrapp.TabIndex = 91
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(388, 408)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Total Devengado"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(242, 392)
        Me.Button8.Margin = New System.Windows.Forms.Padding(2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(99, 46)
        Me.Button8.TabIndex = 89
        Me.Button8.Text = "Enviar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(370, 333)
        Me.Button7.Margin = New System.Windows.Forms.Padding(2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(99, 46)
        Me.Button7.TabIndex = 87
        Me.Button7.Text = "Buscar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'bt_eliminar
        '
        Me.bt_eliminar.Location = New System.Drawing.Point(253, 333)
        Me.bt_eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(99, 46)
        Me.bt_eliminar.TabIndex = 85
        Me.bt_eliminar.Text = "Eliminar"
        Me.bt_eliminar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(145, 333)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 46)
        Me.Button2.TabIndex = 84
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'bt_añadir
        '
        Me.bt_añadir.Location = New System.Drawing.Point(26, 333)
        Me.bt_añadir.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_añadir.Name = "bt_añadir"
        Me.bt_añadir.Size = New System.Drawing.Size(99, 46)
        Me.bt_añadir.TabIndex = 83
        Me.bt_añadir.Text = "Añadir"
        Me.bt_añadir.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 224)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 192)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Compra por :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 156)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Precio Unitario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 119)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Codigo"
        '
        'dg_frappe
        '
        Me.dg_frappe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_frappe.Location = New System.Drawing.Point(311, 23)
        Me.dg_frappe.Name = "dg_frappe"
        Me.dg_frappe.Size = New System.Drawing.Size(524, 275)
        Me.dg_frappe.TabIndex = 102
        '
        'Frappe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 469)
        Me.Controls.Add(Me.dg_frappe)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.txt_descuentoFrapp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.txt_totalFrapp)
        Me.Controls.Add(Me.txt_compraporFrapp)
        Me.Controls.Add(Me.txt_precioUniFrapp)
        Me.Controls.Add(Me.txt_cantidadFrapp)
        Me.Controls.Add(Me.txt_descripFrapp)
        Me.Controls.Add(Me.txt_codigoFrapp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.bt_eliminar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.bt_añadir)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Frappe"
        Me.Text = "Frappe"
        CType(Me.dg_frappe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button9 As Button
    Friend WithEvents txt_descuentoFrapp As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents txt_totalFrapp As TextBox
    Friend WithEvents txt_compraporFrapp As TextBox
    Friend WithEvents txt_precioUniFrapp As TextBox
    Friend WithEvents txt_cantidadFrapp As TextBox
    Friend WithEvents txt_descripFrapp As TextBox
    Friend WithEvents txt_codigoFrapp As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents bt_eliminar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents bt_añadir As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dg_frappe As DataGridView
End Class
