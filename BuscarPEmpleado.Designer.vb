<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarPEmpleado
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
        Me.txt_buscarXcodigo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dg_datosBuscar = New System.Windows.Forms.DataGridView()
        CType(Me.dg_datosBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'txt_buscarXcodigo
        '
        Me.txt_buscarXcodigo.Location = New System.Drawing.Point(66, 24)
        Me.txt_buscarXcodigo.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_buscarXcodigo.Name = "txt_buscarXcodigo"
        Me.txt_buscarXcodigo.Size = New System.Drawing.Size(125, 20)
        Me.txt_buscarXcodigo.TabIndex = 45
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 70)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 58)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(110, 70)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 58)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "Regresar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dg_datosBuscar
        '
        Me.dg_datosBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_datosBuscar.Location = New System.Drawing.Point(234, 27)
        Me.dg_datosBuscar.Name = "dg_datosBuscar"
        Me.dg_datosBuscar.Size = New System.Drawing.Size(565, 272)
        Me.dg_datosBuscar.TabIndex = 48
        '
        'BuscarPEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 311)
        Me.Controls.Add(Me.dg_datosBuscar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_buscarXcodigo)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "BuscarPEmpleado"
        Me.Text = "Buscar Planilla Empleados"
        CType(Me.dg_datosBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_buscarXcodigo As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents dg_datosBuscar As DataGridView
End Class
