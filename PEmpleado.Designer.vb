<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PEmpleado
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bt_añadir = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bt_eliminar = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_CodigoEmpleado = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_sueldo = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_devengado = New System.Windows.Forms.TextBox()
        Me.txt_boniIncentiva = New System.Windows.Forms.TextBox()
        Me.txt_TDevengado = New System.Windows.Forms.TextBox()
        Me.txt_descuento = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.dg_datos = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dg_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo Empleado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 109)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 145)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sueldo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 182)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Bonificación Incentiva"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 219)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Devengado"
        '
        'bt_añadir
        '
        Me.bt_añadir.Location = New System.Drawing.Point(11, 332)
        Me.bt_añadir.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_añadir.Name = "bt_añadir"
        Me.bt_añadir.Size = New System.Drawing.Size(99, 46)
        Me.bt_añadir.TabIndex = 6
        Me.bt_añadir.Text = "Añadir"
        Me.bt_añadir.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(342, 332)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 46)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'bt_eliminar
        '
        Me.bt_eliminar.Location = New System.Drawing.Point(239, 332)
        Me.bt_eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(99, 46)
        Me.bt_eliminar.TabIndex = 8
        Me.bt_eliminar.Text = "Eliminar"
        Me.bt_eliminar.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(458, 332)
        Me.Button7.Margin = New System.Windows.Forms.Padding(2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(99, 46)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "Buscar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(458, 392)
        Me.Button8.Margin = New System.Windows.Forms.Padding(2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(99, 46)
        Me.Button8.TabIndex = 13
        Me.Button8.Text = "Enviar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(587, 409)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Total Devengado"
        '
        'txt_CodigoEmpleado
        '
        Me.txt_CodigoEmpleado.Location = New System.Drawing.Point(142, 20)
        Me.txt_CodigoEmpleado.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_CodigoEmpleado.Name = "txt_CodigoEmpleado"
        Me.txt_CodigoEmpleado.Size = New System.Drawing.Size(125, 20)
        Me.txt_CodigoEmpleado.TabIndex = 15
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(142, 66)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(125, 20)
        Me.txt_nombre.TabIndex = 16
        '
        'txt_sueldo
        '
        Me.txt_sueldo.Location = New System.Drawing.Point(142, 138)
        Me.txt_sueldo.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_sueldo.Name = "txt_sueldo"
        Me.txt_sueldo.Size = New System.Drawing.Size(125, 20)
        Me.txt_sueldo.TabIndex = 18
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(142, 106)
        Me.txt_apellido.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(125, 20)
        Me.txt_apellido.TabIndex = 17
        '
        'txt_devengado
        '
        Me.txt_devengado.Location = New System.Drawing.Point(142, 219)
        Me.txt_devengado.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_devengado.Name = "txt_devengado"
        Me.txt_devengado.Size = New System.Drawing.Size(125, 20)
        Me.txt_devengado.TabIndex = 20
        '
        'txt_boniIncentiva
        '
        Me.txt_boniIncentiva.Location = New System.Drawing.Point(142, 179)
        Me.txt_boniIncentiva.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_boniIncentiva.Name = "txt_boniIncentiva"
        Me.txt_boniIncentiva.Size = New System.Drawing.Size(125, 20)
        Me.txt_boniIncentiva.TabIndex = 19
        '
        'txt_TDevengado
        '
        Me.txt_TDevengado.Location = New System.Drawing.Point(692, 406)
        Me.txt_TDevengado.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_TDevengado.Name = "txt_TDevengado"
        Me.txt_TDevengado.Size = New System.Drawing.Size(125, 20)
        Me.txt_TDevengado.TabIndex = 21
        '
        'txt_descuento
        '
        Me.txt_descuento.Location = New System.Drawing.Point(142, 247)
        Me.txt_descuento.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_descuento.Name = "txt_descuento"
        Me.txt_descuento.Size = New System.Drawing.Size(125, 20)
        Me.txt_descuento.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 256)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Descuento"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(821, 332)
        Me.Button9.Margin = New System.Windows.Forms.Padding(2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(107, 50)
        Me.Button9.TabIndex = 25
        Me.Button9.Text = "Regresar"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'dg_datos
        '
        Me.dg_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_datos.Location = New System.Drawing.Point(307, 20)
        Me.dg_datos.Name = "dg_datos"
        Me.dg_datos.Size = New System.Drawing.Size(632, 285)
        Me.dg_datos.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(127, 332)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 46)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 457)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dg_datos)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.txt_descuento)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_TDevengado)
        Me.Controls.Add(Me.txt_devengado)
        Me.Controls.Add(Me.txt_boniIncentiva)
        Me.Controls.Add(Me.txt_sueldo)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_CodigoEmpleado)
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
        Me.Name = "PEmpleado"
        Me.Text = "Planilla Empleado"
        CType(Me.dg_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents bt_añadir As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents bt_eliminar As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_CodigoEmpleado As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_sueldo As TextBox
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents txt_devengado As TextBox
    Friend WithEvents txt_boniIncentiva As TextBox
    Friend WithEvents txt_TDevengado As TextBox
    Friend WithEvents txt_descuento As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents dg_datos As DataGridView
    Friend WithEvents Button1 As Button
End Class
