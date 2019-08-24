<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnAñadirEmpleado = New System.Windows.Forms.Button()
        Me.btnEditarRegistro = New System.Windows.Forms.Button()
        Me.btnEliminarEmpleado = New System.Windows.Forms.Button()
        Me.btnRegistrarSalida = New System.Windows.Forms.Button()
        Me.btnAsistencias = New System.Windows.Forms.Button()
        Me.btnRegistrarLlegada = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnAñadirEmpleado
        '
        Me.btnAñadirEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.btnAñadirEmpleado.BackgroundImage = CType(resources.GetObject("btnAñadirEmpleado.BackgroundImage"), System.Drawing.Image)
        Me.btnAñadirEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAñadirEmpleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAñadirEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAñadirEmpleado.FlatAppearance.BorderSize = 0
        Me.btnAñadirEmpleado.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnAñadirEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAñadirEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAñadirEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAñadirEmpleado.Location = New System.Drawing.Point(14, 415)
        Me.btnAñadirEmpleado.Name = "btnAñadirEmpleado"
        Me.btnAñadirEmpleado.Size = New System.Drawing.Size(421, 239)
        Me.btnAñadirEmpleado.TabIndex = 0
        Me.btnAñadirEmpleado.UseVisualStyleBackColor = False
        '
        'btnEditarRegistro
        '
        Me.btnEditarRegistro.BackColor = System.Drawing.Color.Transparent
        Me.btnEditarRegistro.BackgroundImage = CType(resources.GetObject("btnEditarRegistro.BackgroundImage"), System.Drawing.Image)
        Me.btnEditarRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditarRegistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditarRegistro.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEditarRegistro.FlatAppearance.BorderSize = 0
        Me.btnEditarRegistro.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnEditarRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEditarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEditarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarRegistro.Location = New System.Drawing.Point(464, 415)
        Me.btnEditarRegistro.Name = "btnEditarRegistro"
        Me.btnEditarRegistro.Size = New System.Drawing.Size(421, 239)
        Me.btnEditarRegistro.TabIndex = 1
        Me.btnEditarRegistro.UseVisualStyleBackColor = False
        '
        'btnEliminarEmpleado
        '
        Me.btnEliminarEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminarEmpleado.BackgroundImage = CType(resources.GetObject("btnEliminarEmpleado.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEliminarEmpleado.FlatAppearance.BorderSize = 0
        Me.btnEliminarEmpleado.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnEliminarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEliminarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEliminarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarEmpleado.Location = New System.Drawing.Point(917, 415)
        Me.btnEliminarEmpleado.Name = "btnEliminarEmpleado"
        Me.btnEliminarEmpleado.Size = New System.Drawing.Size(421, 239)
        Me.btnEliminarEmpleado.TabIndex = 2
        Me.btnEliminarEmpleado.UseVisualStyleBackColor = False
        '
        'btnRegistrarSalida
        '
        Me.btnRegistrarSalida.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistrarSalida.BackgroundImage = CType(resources.GetObject("btnRegistrarSalida.BackgroundImage"), System.Drawing.Image)
        Me.btnRegistrarSalida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegistrarSalida.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrarSalida.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRegistrarSalida.FlatAppearance.BorderSize = 0
        Me.btnRegistrarSalida.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnRegistrarSalida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRegistrarSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRegistrarSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarSalida.Location = New System.Drawing.Point(917, 150)
        Me.btnRegistrarSalida.Name = "btnRegistrarSalida"
        Me.btnRegistrarSalida.Size = New System.Drawing.Size(421, 239)
        Me.btnRegistrarSalida.TabIndex = 5
        Me.btnRegistrarSalida.UseVisualStyleBackColor = False
        '
        'btnAsistencias
        '
        Me.btnAsistencias.BackColor = System.Drawing.Color.Transparent
        Me.btnAsistencias.BackgroundImage = CType(resources.GetObject("btnAsistencias.BackgroundImage"), System.Drawing.Image)
        Me.btnAsistencias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAsistencias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAsistencias.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAsistencias.FlatAppearance.BorderSize = 0
        Me.btnAsistencias.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnAsistencias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAsistencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAsistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsistencias.Location = New System.Drawing.Point(464, 150)
        Me.btnAsistencias.Name = "btnAsistencias"
        Me.btnAsistencias.Size = New System.Drawing.Size(421, 239)
        Me.btnAsistencias.TabIndex = 4
        Me.btnAsistencias.UseVisualStyleBackColor = False
        '
        'btnRegistrarLlegada
        '
        Me.btnRegistrarLlegada.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistrarLlegada.BackgroundImage = CType(resources.GetObject("btnRegistrarLlegada.BackgroundImage"), System.Drawing.Image)
        Me.btnRegistrarLlegada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegistrarLlegada.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrarLlegada.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRegistrarLlegada.FlatAppearance.BorderSize = 0
        Me.btnRegistrarLlegada.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnRegistrarLlegada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRegistrarLlegada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRegistrarLlegada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarLlegada.Location = New System.Drawing.Point(14, 150)
        Me.btnRegistrarLlegada.Name = "btnRegistrarLlegada"
        Me.btnRegistrarLlegada.Size = New System.Drawing.Size(421, 239)
        Me.btnRegistrarLlegada.TabIndex = 3
        Me.btnRegistrarLlegada.UseVisualStyleBackColor = False
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.Transparent
        Me.btnEnd.BackgroundImage = CType(resources.GetObject("btnEnd.BackgroundImage"), System.Drawing.Image)
        Me.btnEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnd.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEnd.FlatAppearance.BorderSize = 0
        Me.btnEnd.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnEnd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEnd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnd.Location = New System.Drawing.Point(1288, 12)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(48, 46)
        Me.btnEnd.TabIndex = 6
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimizar.BackgroundImage = CType(resources.GetObject("btnMinimizar.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Location = New System.Drawing.Point(1234, 12)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(48, 46)
        Me.btnMinimizar.TabIndex = 7
        Me.btnMinimizar.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1348, 723)
        Me.Controls.Add(Me.btnMinimizar)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnRegistrarSalida)
        Me.Controls.Add(Me.btnAsistencias)
        Me.Controls.Add(Me.btnRegistrarLlegada)
        Me.Controls.Add(Me.btnEliminarEmpleado)
        Me.Controls.Add(Me.btnEditarRegistro)
        Me.Controls.Add(Me.btnAñadirEmpleado)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAñadirEmpleado As System.Windows.Forms.Button
    Friend WithEvents btnEditarRegistro As System.Windows.Forms.Button
    Friend WithEvents btnEliminarEmpleado As System.Windows.Forms.Button
    Friend WithEvents btnRegistrarSalida As System.Windows.Forms.Button
    Friend WithEvents btnAsistencias As System.Windows.Forms.Button
    Friend WithEvents btnRegistrarLlegada As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents btnMinimizar As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
