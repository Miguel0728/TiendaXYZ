<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbOnline = New System.Windows.Forms.RadioButton()
        Me.rbPresencial = New System.Windows.Forms.RadioButton()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.txtNumeroProducto = New System.Windows.Forms.TextBox()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblGanancia = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblncomeTax = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCosto = New System.Windows.Forms.Label()
        Me.lblNumProducto = New System.Windows.Forms.Label()
        Me.lblNombreProducto = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero de Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Costo"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.rbOnline)
        Me.GroupBox1.Controls.Add(Me.rbPresencial)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnBorrar)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtCosto)
        Me.GroupBox1.Controls.Add(Me.txtNumeroProducto)
        Me.GroupBox1.Controls.Add(Me.txtNombreProducto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 310)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Articulos"
        '
        'rbOnline
        '
        Me.rbOnline.AutoSize = True
        Me.rbOnline.Location = New System.Drawing.Point(10, 189)
        Me.rbOnline.Name = "rbOnline"
        Me.rbOnline.Size = New System.Drawing.Size(72, 20)
        Me.rbOnline.TabIndex = 12
        Me.rbOnline.TabStop = True
        Me.rbOnline.Text = "Online"
        Me.rbOnline.UseVisualStyleBackColor = True
        '
        'rbPresencial
        '
        Me.rbPresencial.AutoSize = True
        Me.rbPresencial.Location = New System.Drawing.Point(10, 163)
        Me.rbPresencial.Name = "rbPresencial"
        Me.rbPresencial.Size = New System.Drawing.Size(102, 20)
        Me.rbPresencial.TabIndex = 11
        Me.rbPresencial.TabStop = True
        Me.rbPresencial.Text = "Presencial"
        Me.rbPresencial.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(270, 246)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(180, 246)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 9
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(85, 246)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(191, 113)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(123, 22)
        Me.txtCosto.TabIndex = 7
        '
        'txtNumeroProducto
        '
        Me.txtNumeroProducto.Location = New System.Drawing.Point(191, 74)
        Me.txtNumeroProducto.Name = "txtNumeroProducto"
        Me.txtNumeroProducto.Size = New System.Drawing.Size(123, 22)
        Me.txtNumeroProducto.TabIndex = 6
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(191, 36)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(123, 22)
        Me.txtNombreProducto.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.lblDescuento)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lblGanancia)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.lblncomeTax)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblCosto)
        Me.GroupBox2.Controls.Add(Me.lblNumProducto)
        Me.GroupBox2.Controls.Add(Me.lblNombreProducto)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(385, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(382, 310)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'lblDescuento
        '
        Me.lblDescuento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDescuento.Location = New System.Drawing.Point(181, 234)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(157, 25)
        Me.lblDescuento.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 234)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 16)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Descuento"
        '
        'lblGanancia
        '
        Me.lblGanancia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGanancia.Location = New System.Drawing.Point(181, 184)
        Me.lblGanancia.Name = "lblGanancia"
        Me.lblGanancia.Size = New System.Drawing.Size(157, 25)
        Me.lblGanancia.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 16)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Ganancia"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(135, 272)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(133, 25)
        Me.lblTotal.TabIndex = 11
        '
        'lblncomeTax
        '
        Me.lblncomeTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblncomeTax.Location = New System.Drawing.Point(181, 149)
        Me.lblncomeTax.Name = "lblncomeTax"
        Me.lblncomeTax.Size = New System.Drawing.Size(157, 25)
        Me.lblncomeTax.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Income Tax"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 281)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Total"
        '
        'lblCosto
        '
        Me.lblCosto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCosto.Location = New System.Drawing.Point(181, 116)
        Me.lblCosto.Name = "lblCosto"
        Me.lblCosto.Size = New System.Drawing.Size(157, 25)
        Me.lblCosto.TabIndex = 7
        '
        'lblNumProducto
        '
        Me.lblNumProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumProducto.Location = New System.Drawing.Point(181, 79)
        Me.lblNumProducto.Name = "lblNumProducto"
        Me.lblNumProducto.Size = New System.Drawing.Size(157, 25)
        Me.lblNumProducto.TabIndex = 6
        '
        'lblNombreProducto
        '
        Me.lblNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNombreProducto.Location = New System.Drawing.Point(181, 38)
        Me.lblNombreProducto.Name = "lblNombreProducto"
        Me.lblNombreProducto.Size = New System.Drawing.Size(157, 23)
        Me.lblNombreProducto.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nombre de Producto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Numero de Producto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Costo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(301, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(239, 39)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "TIENDA_XYZ"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents txtNumeroProducto As TextBox
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblCosto As Label
    Friend WithEvents lblNumProducto As Label
    Friend WithEvents lblNombreProducto As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblncomeTax As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblGanancia As Label
    Friend WithEvents rbOnline As RadioButton
    Friend WithEvents rbPresencial As RadioButton
    Friend WithEvents lblDescuento As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
