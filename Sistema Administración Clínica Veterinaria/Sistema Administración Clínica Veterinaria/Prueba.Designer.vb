<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prueba
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
        Me.txt_prueba = New System.Windows.Forms.TextBox()
        Me.btn_prueba = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_prueba
        '
        Me.txt_prueba.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prueba.Location = New System.Drawing.Point(147, 96)
        Me.txt_prueba.Name = "txt_prueba"
        Me.txt_prueba.Size = New System.Drawing.Size(261, 26)
        Me.txt_prueba.TabIndex = 0
        '
        'btn_prueba
        '
        Me.btn_prueba.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_prueba.Location = New System.Drawing.Point(443, 96)
        Me.btn_prueba.Name = "btn_prueba"
        Me.btn_prueba.Size = New System.Drawing.Size(146, 26)
        Me.btn_prueba.TabIndex = 1
        Me.btn_prueba.Text = "Generar PDF"
        Me.btn_prueba.UseVisualStyleBackColor = True
        '
        'Prueba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_prueba)
        Me.Controls.Add(Me.txt_prueba)
        Me.Name = "Prueba"
        Me.Text = "Prueba"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_prueba As TextBox
    Friend WithEvents btn_prueba As Button
End Class
