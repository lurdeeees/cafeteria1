<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrutaManzana
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
        Me.bt_añadir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dg_pmanzana = New System.Windows.Forms.DataGridView()
        Me.bt_modificar = New System.Windows.Forms.Button()
        Me.bt_eliminar = New System.Windows.Forms.Button()
        Me.bt_buscar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_codigoM = New System.Windows.Forms.TextBox()
        Me.txt_descripM = New System.Windows.Forms.TextBox()
        Me.txt_cantidadM = New System.Windows.Forms.TextBox()
        Me.txt_precioUniM = New System.Windows.Forms.TextBox()
        Me.txt_compraporM = New System.Windows.Forms.TextBox()
        Me.txt_totalM = New System.Windows.Forms.TextBox()
        Me.txt_descuentoM = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bt_enviar = New System.Windows.Forms.Button()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        CType(Me.dg_pmanzana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_añadir
        '
        Me.bt_añadir.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_añadir.Location = New System.Drawing.Point(43, 315)
        Me.bt_añadir.Name = "bt_añadir"
        Me.bt_añadir.Size = New System.Drawing.Size(103, 36)
        Me.bt_añadir.TabIndex = 0
        Me.bt_añadir.Text = "Añadir"
        Me.bt_añadir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cantidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Precio Unitario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Compra por:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Descuento"
        '
        'dg_pmanzana
        '
        Me.dg_pmanzana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_pmanzana.Location = New System.Drawing.Point(319, 35)
        Me.dg_pmanzana.Name = "dg_pmanzana"
        Me.dg_pmanzana.Size = New System.Drawing.Size(453, 235)
        Me.dg_pmanzana.TabIndex = 8
        '
        'bt_modificar
        '
        Me.bt_modificar.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_modificar.Location = New System.Drawing.Point(172, 313)
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Size = New System.Drawing.Size(103, 36)
        Me.bt_modificar.TabIndex = 9
        Me.bt_modificar.Text = "Modificar"
        Me.bt_modificar.UseVisualStyleBackColor = True
        '
        'bt_eliminar
        '
        Me.bt_eliminar.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_eliminar.Location = New System.Drawing.Point(305, 314)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(103, 36)
        Me.bt_eliminar.TabIndex = 10
        Me.bt_eliminar.Text = "Eliminar"
        Me.bt_eliminar.UseVisualStyleBackColor = True
        '
        'bt_buscar
        '
        Me.bt_buscar.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_buscar.Location = New System.Drawing.Point(437, 313)
        Me.bt_buscar.Name = "bt_buscar"
        Me.bt_buscar.Size = New System.Drawing.Size(103, 36)
        Me.bt_buscar.TabIndex = 11
        Me.bt_buscar.Text = "Buscar"
        Me.bt_buscar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(669, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 36)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_codigoM
        '
        Me.txt_codigoM.Location = New System.Drawing.Point(150, 45)
        Me.txt_codigoM.Name = "txt_codigoM"
        Me.txt_codigoM.Size = New System.Drawing.Size(100, 20)
        Me.txt_codigoM.TabIndex = 13
        '
        'txt_descripM
        '
        Me.txt_descripM.Location = New System.Drawing.Point(150, 78)
        Me.txt_descripM.Name = "txt_descripM"
        Me.txt_descripM.Size = New System.Drawing.Size(100, 20)
        Me.txt_descripM.TabIndex = 14
        '
        'txt_cantidadM
        '
        Me.txt_cantidadM.Location = New System.Drawing.Point(150, 112)
        Me.txt_cantidadM.Name = "txt_cantidadM"
        Me.txt_cantidadM.Size = New System.Drawing.Size(100, 20)
        Me.txt_cantidadM.TabIndex = 15
        '
        'txt_precioUniM
        '
        Me.txt_precioUniM.Location = New System.Drawing.Point(150, 145)
        Me.txt_precioUniM.Name = "txt_precioUniM"
        Me.txt_precioUniM.Size = New System.Drawing.Size(100, 20)
        Me.txt_precioUniM.TabIndex = 16
        '
        'txt_compraporM
        '
        Me.txt_compraporM.Location = New System.Drawing.Point(150, 177)
        Me.txt_compraporM.Name = "txt_compraporM"
        Me.txt_compraporM.Size = New System.Drawing.Size(100, 20)
        Me.txt_compraporM.TabIndex = 17
        '
        'txt_totalM
        '
        Me.txt_totalM.Location = New System.Drawing.Point(150, 214)
        Me.txt_totalM.Name = "txt_totalM"
        Me.txt_totalM.Size = New System.Drawing.Size(100, 20)
        Me.txt_totalM.TabIndex = 18
        '
        'txt_descuentoM
        '
        Me.txt_descuentoM.Location = New System.Drawing.Point(150, 250)
        Me.txt_descuentoM.Name = "txt_descuentoM"
        Me.txt_descuentoM.Size = New System.Drawing.Size(100, 20)
        Me.txt_descuentoM.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(433, 377)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 21)
        Me.Label8.TabIndex = 174
        Me.Label8.Text = "Total Devengado"
        '
        'bt_enviar
        '
        Me.bt_enviar.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_enviar.Location = New System.Drawing.Point(309, 362)
        Me.bt_enviar.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_enviar.Name = "bt_enviar"
        Me.bt_enviar.Size = New System.Drawing.Size(99, 46)
        Me.bt_enviar.TabIndex = 173
        Me.bt_enviar.Text = "Enviar"
        Me.bt_enviar.UseVisualStyleBackColor = True
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(578, 378)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 175
        '
        'FrutaManzana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.bt_enviar)
        Me.Controls.Add(Me.txt_descuentoM)
        Me.Controls.Add(Me.txt_totalM)
        Me.Controls.Add(Me.txt_compraporM)
        Me.Controls.Add(Me.txt_precioUniM)
        Me.Controls.Add(Me.txt_cantidadM)
        Me.Controls.Add(Me.txt_descripM)
        Me.Controls.Add(Me.txt_codigoM)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bt_buscar)
        Me.Controls.Add(Me.bt_eliminar)
        Me.Controls.Add(Me.bt_modificar)
        Me.Controls.Add(Me.dg_pmanzana)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_añadir)
        Me.Name = "FrutaManzana"
        Me.Text = "FrutaManzana"
        CType(Me.dg_pmanzana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_añadir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dg_pmanzana As DataGridView
    Friend WithEvents bt_modificar As Button
    Friend WithEvents bt_eliminar As Button
    Friend WithEvents bt_buscar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_codigoM As TextBox
    Friend WithEvents txt_descripM As TextBox
    Friend WithEvents txt_cantidadM As TextBox
    Friend WithEvents txt_precioUniM As TextBox
    Friend WithEvents txt_compraporM As TextBox
    Friend WithEvents txt_totalM As TextBox
    Friend WithEvents txt_descuentoM As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents bt_enviar As Button
    Friend WithEvents TextBox8 As TextBox
End Class
