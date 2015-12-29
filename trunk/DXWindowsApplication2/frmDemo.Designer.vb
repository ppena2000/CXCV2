<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDemo
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
        Me.UcEncuestaNegocios1 = New CCRCCV2.ucEncuestaNegocios
        Me.SuspendLayout()
        '
        'UcEncuestaNegocios1
        '
        Me.UcEncuestaNegocios1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcEncuestaNegocios1.Location = New System.Drawing.Point(0, 0)
        Me.UcEncuestaNegocios1.Name = "UcEncuestaNegocios1"
        Me.UcEncuestaNegocios1.Size = New System.Drawing.Size(1305, 564)
        Me.UcEncuestaNegocios1.TabIndex = 0
        '
        'frmDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1305, 564)
        Me.Controls.Add(Me.UcEncuestaNegocios1)
        Me.Name = "frmDemo"
        Me.Text = "frmDemo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcEncuestaNegocios1 As CCRCCV2.ucEncuestaNegocios
End Class
