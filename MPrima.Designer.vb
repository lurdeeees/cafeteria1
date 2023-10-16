<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MPrima
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txt_totalMP = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_preci = New System.Windows.Forms.TextBox()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.bt_buscar = New System.Windows.Forms.Button()
        Me.bt_eliminar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bt_AñadirMP = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.dg_datosMP = New System.Windows.Forms.DataGridView()
        Me.txt_comprapor = New System.Windows.Forms.TextBox()
        CType(Me.dg_datosMP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_totalMP
        '
        Me.txt_totalMP.Location = New System.Drawing.Point(644, 386)
        Me.txt_totalMP.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_totalMP.Name = "txt_totalMP"
        Me.txt_totalMP.Size = New System.Drawing.Size(125, 20)
        Me.txt_totalMP.TabIndex = 46
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(159, 238)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(125, 20)
        Me.txt_total.TabIndex = 45
        '
        'txt_preci
        '
        Me.txt_preci.Location = New System.Drawing.Point(159, 150)
        Me.txt_preci.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_preci.Name = "txt_preci"
        Me.txt_preci.Size = New System.Drawing.Size(125, 20)
        Me.txt_preci.TabIndex = 43
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(159, 114)
        Me.txt_cantidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(125, 20)
        Me.txt_cantidad.TabIndex = 42
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(159, 74)
        Me.txt_descripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(125, 20)
        Me.txt_descripcion.TabIndex = 41
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(159, 28)
        Me.txt_codigo.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(125, 20)
        Me.txt_codigo.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(529, 389)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Total Materia Prima"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(386, 372)
        Me.Button8.Margin = New System.Windows.Forms.Padding(2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(99, 46)
        Me.Button8.TabIndex = 38
        Me.Button8.Text = "Enviar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'bt_buscar
        '
        Me.bt_buscar.Location = New System.Drawing.Point(386, 312)
        Me.bt_buscar.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_buscar.Name = "bt_buscar"
        Me.bt_buscar.Size = New System.Drawing.Size(99, 46)
        Me.bt_buscar.TabIndex = 35
        Me.bt_buscar.Text = "Buscar"
        Me.bt_buscar.UseVisualStyleBackColor = True
        '
        'bt_eliminar
        '
        Me.bt_eliminar.Location = New System.Drawing.Point(271, 312)
        Me.bt_eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(99, 46)
        Me.bt_eliminar.TabIndex = 33
        Me.bt_eliminar.Text = "Eliminar"
        Me.bt_eliminar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(159, 312)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 46)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'bt_AñadirMP
        '
        Me.bt_AñadirMP.Location = New System.Drawing.Point(50, 312)
        Me.bt_AñadirMP.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_AñadirMP.Name = "bt_AñadirMP"
        Me.bt_AñadirMP.Size = New System.Drawing.Size(99, 46)
        Me.bt_AñadirMP.TabIndex = 31
        Me.bt_AñadirMP.Text = "Añadir"
        Me.bt_AñadirMP.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 238)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 202)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Compra por:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 157)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Precio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 117)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Codigo "
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(722, 312)
        Me.Button9.Margin = New System.Windows.Forms.Padding(2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(99, 46)
        Me.Button9.TabIndex = 48
        Me.Button9.Text = "Regresar"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'dg_datosMP
        '
        Me.dg_datosMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_datosMP.Location = New System.Drawing.Point(333, 28)
        Me.dg_datosMP.Name = "dg_datosMP"
        Me.dg_datosMP.Size = New System.Drawing.Size(514, 265)
        Me.dg_datosMP.TabIndex = 49
        '
        'txt_comprapor
        '
        Me.txt_comprapor.Location = New System.Drawing.Point(159, 195)
        Me.txt_comprapor.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_comprapor.Name = "txt_comprapor"
        Me.txt_comprapor.Size = New System.Drawing.Size(125, 20)
        Me.txt_comprapor.TabIndex = 44
        '
        'MPrima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 422)
        Me.Controls.Add(Me.dg_datosMP)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.txt_totalMP)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.txt_comprapor)
        Me.Controls.Add(Me.txt_preci)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.bt_buscar)
        Me.Controls.Add(Me.bt_eliminar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.bt_AñadirMP)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MPrima"
        Me.Text = "Materia Prima"
        CType(Me.dg_datosMP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_totalMP As TextBox
    Friend WithEvents txt_total As TextBox
    Friend WithEvents txt_preci As TextBox
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents bt_buscar As Button
    Friend WithEvents bt_eliminar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents bt_AñadirMP As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents dg_datosMP As DataGridView
    Friend WithEvents txt_comprapor As TextBox
End Class
