<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidosClientes
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
        Me.ListMenu = New System.Windows.Forms.ListBox()
        Me.BtnCalcula = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnOrden = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListaBox = New System.Windows.Forms.ListBox()
        Me.CEG = New System.Windows.Forms.CheckBox()
        Me.CEM = New System.Windows.Forms.CheckBox()
        Me.CEP = New System.Windows.Forms.CheckBox()
        Me.CMG = New System.Windows.Forms.CheckBox()
        Me.CMM = New System.Windows.Forms.CheckBox()
        Me.CMP = New System.Windows.Forms.CheckBox()
        Me.FG = New System.Windows.Forms.CheckBox()
        Me.FM = New System.Windows.Forms.CheckBox()
        Me.PL = New System.Windows.Forms.CheckBox()
        Me.PM = New System.Windows.Forms.CheckBox()
        Me.PCHEESAKE = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ListMenu
        '
        Me.ListMenu.BackColor = System.Drawing.Color.White
        Me.ListMenu.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListMenu.FormattingEnabled = True
        Me.ListMenu.ItemHeight = 16
        Me.ListMenu.Items.AddRange(New Object() {"", "Café Expreso grande " & Global.Microsoft.VisualBasic.ChrW(9) & "Q15.00", "", "Café Expreso mediano " & Global.Microsoft.VisualBasic.ChrW(9) & "Q10.00", "", "Café Expreso pequeño " & Global.Microsoft.VisualBasic.ChrW(9) & "Q7.00", "", "Café Mocca grande " & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Q16.00", "", "Café Mocca mediano" & Global.Microsoft.VisualBasic.ChrW(9) & "Q11.00", "", "Café Mocca pequeño " & Global.Microsoft.VisualBasic.ChrW(9) & "Q8.00", "", "Frappé grande" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Q20.00", "", "Frappé mediano" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Q15.00", "", "Pie gata Persa (de limón)" & Global.Microsoft.VisualBasic.ChrW(9) & "Q65.00", "", "Pie gata Siamés (de manzana)    Q60.00", "", "Pastel gata pinta(cheesecake)" & Global.Microsoft.VisualBasic.ChrW(9) & "Q70.00"})
        Me.ListMenu.Location = New System.Drawing.Point(683, 74)
        Me.ListMenu.Name = "ListMenu"
        Me.ListMenu.Size = New System.Drawing.Size(257, 356)
        Me.ListMenu.TabIndex = 0
        '
        'BtnCalcula
        '
        Me.BtnCalcula.Location = New System.Drawing.Point(12, 461)
        Me.BtnCalcula.Name = "BtnCalcula"
        Me.BtnCalcula.Size = New System.Drawing.Size(116, 29)
        Me.BtnCalcula.TabIndex = 2
        Me.BtnCalcula.Text = "Total"
        Me.BtnCalcula.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(545, 456)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(116, 29)
        Me.BtnLimpiar.TabIndex = 3
        Me.BtnLimpiar.Text = "Limpiar Orden"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnOrden
        '
        Me.BtnOrden.Location = New System.Drawing.Point(667, 456)
        Me.BtnOrden.Name = "BtnOrden"
        Me.BtnOrden.Size = New System.Drawing.Size(116, 29)
        Me.BtnOrden.TabIndex = 4
        Me.BtnOrden.Text = "Tomar Orden"
        Me.BtnOrden.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(789, 456)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(116, 29)
        Me.BtnSalir.TabIndex = 5
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 26)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "ORDEN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(796, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 26)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "MENU"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(134, 466)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 19
        '
        'ListaBox
        '
        Me.ListaBox.FormattingEnabled = True
        Me.ListaBox.Location = New System.Drawing.Point(12, 74)
        Me.ListaBox.Name = "ListaBox"
        Me.ListaBox.Size = New System.Drawing.Size(246, 316)
        Me.ListaBox.TabIndex = 20
        '
        'CEG
        '
        Me.CEG.AutoSize = True
        Me.CEG.Location = New System.Drawing.Point(669, 91)
        Me.CEG.Name = "CEG"
        Me.CEG.Size = New System.Drawing.Size(48, 17)
        Me.CEG.TabIndex = 21
        Me.CEG.Text = "CEG"
        Me.CEG.UseVisualStyleBackColor = True
        '
        'CEM
        '
        Me.CEM.AutoSize = True
        Me.CEM.Location = New System.Drawing.Point(669, 127)
        Me.CEM.Name = "CEM"
        Me.CEM.Size = New System.Drawing.Size(49, 17)
        Me.CEM.TabIndex = 22
        Me.CEM.Text = "CEM"
        Me.CEM.UseVisualStyleBackColor = True
        '
        'CEP
        '
        Me.CEP.AutoSize = True
        Me.CEP.Location = New System.Drawing.Point(669, 161)
        Me.CEP.Name = "CEP"
        Me.CEP.Size = New System.Drawing.Size(47, 17)
        Me.CEP.TabIndex = 23
        Me.CEP.Text = "CEP"
        Me.CEP.UseVisualStyleBackColor = True
        '
        'CMG
        '
        Me.CMG.AutoSize = True
        Me.CMG.Location = New System.Drawing.Point(669, 185)
        Me.CMG.Name = "CMG"
        Me.CMG.Size = New System.Drawing.Size(50, 17)
        Me.CMG.TabIndex = 24
        Me.CMG.Text = "CMG"
        Me.CMG.UseVisualStyleBackColor = True
        '
        'CMM
        '
        Me.CMM.AutoSize = True
        Me.CMM.Location = New System.Drawing.Point(669, 221)
        Me.CMM.Name = "CMM"
        Me.CMM.Size = New System.Drawing.Size(51, 17)
        Me.CMM.TabIndex = 25
        Me.CMM.Text = "CMM"
        Me.CMM.UseVisualStyleBackColor = True
        '
        'CMP
        '
        Me.CMP.AutoSize = True
        Me.CMP.Location = New System.Drawing.Point(669, 254)
        Me.CMP.Name = "CMP"
        Me.CMP.Size = New System.Drawing.Size(49, 17)
        Me.CMP.TabIndex = 26
        Me.CMP.Text = "CMP"
        Me.CMP.UseVisualStyleBackColor = True
        '
        'FG
        '
        Me.FG.AutoSize = True
        Me.FG.Location = New System.Drawing.Point(669, 287)
        Me.FG.Name = "FG"
        Me.FG.Size = New System.Drawing.Size(40, 17)
        Me.FG.TabIndex = 27
        Me.FG.Text = "FG"
        Me.FG.UseVisualStyleBackColor = True
        '
        'FM
        '
        Me.FM.AutoSize = True
        Me.FM.Location = New System.Drawing.Point(669, 321)
        Me.FM.Name = "FM"
        Me.FM.Size = New System.Drawing.Size(41, 17)
        Me.FM.TabIndex = 28
        Me.FM.Text = "FM"
        Me.FM.UseVisualStyleBackColor = True
        '
        'PL
        '
        Me.PL.AutoSize = True
        Me.PL.Location = New System.Drawing.Point(669, 345)
        Me.PL.Name = "PL"
        Me.PL.Size = New System.Drawing.Size(39, 17)
        Me.PL.TabIndex = 29
        Me.PL.Text = "PL"
        Me.PL.UseVisualStyleBackColor = True
        '
        'PM
        '
        Me.PM.AutoSize = True
        Me.PM.Location = New System.Drawing.Point(669, 376)
        Me.PM.Name = "PM"
        Me.PM.Size = New System.Drawing.Size(42, 17)
        Me.PM.TabIndex = 30
        Me.PM.Text = "PM"
        Me.PM.UseVisualStyleBackColor = True
        '
        'PCHEESAKE
        '
        Me.PCHEESAKE.AutoSize = True
        Me.PCHEESAKE.Location = New System.Drawing.Point(669, 413)
        Me.PCHEESAKE.Name = "PCHEESAKE"
        Me.PCHEESAKE.Size = New System.Drawing.Size(90, 17)
        Me.PCHEESAKE.TabIndex = 31
        Me.PCHEESAKE.Text = "PCHEESAKE"
        Me.PCHEESAKE.UseVisualStyleBackColor = True
        '
        'PedidosClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.BackgroundImage = Global.cafeteria.My.Resources.Resources.Gatas_bajo_la_lluvia_logo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(952, 503)
        Me.Controls.Add(Me.ListMenu)
        Me.Controls.Add(Me.PCHEESAKE)
        Me.Controls.Add(Me.PM)
        Me.Controls.Add(Me.PL)
        Me.Controls.Add(Me.FM)
        Me.Controls.Add(Me.FG)
        Me.Controls.Add(Me.CMP)
        Me.Controls.Add(Me.CMM)
        Me.Controls.Add(Me.CMG)
        Me.Controls.Add(Me.CEP)
        Me.Controls.Add(Me.CEM)
        Me.Controls.Add(Me.CEG)
        Me.Controls.Add(Me.ListaBox)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnOrden)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnCalcula)
        Me.DoubleBuffered = True
        Me.Name = "PedidosClientes"
        Me.Text = "PedidosClientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListMenu As ListBox
    Friend WithEvents BtnCalcula As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnOrden As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListaBox As ListBox
    Friend WithEvents CEG As CheckBox
    Friend WithEvents CEM As CheckBox
    Friend WithEvents CEP As CheckBox
    Friend WithEvents CMG As CheckBox
    Friend WithEvents CMM As CheckBox
    Friend WithEvents CMP As CheckBox
    Friend WithEvents FG As CheckBox
    Friend WithEvents FM As CheckBox
    Friend WithEvents PL As CheckBox
    Friend WithEvents PM As CheckBox
    Friend WithEvents PCHEESAKE As CheckBox
End Class
