<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TBprocesso = New System.Windows.Forms.TextBox()
        Me.Bkill = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TBprocesso
        '
        Me.TBprocesso.Location = New System.Drawing.Point(13, 13)
        Me.TBprocesso.Name = "TBprocesso"
        Me.TBprocesso.Size = New System.Drawing.Size(229, 20)
        Me.TBprocesso.TabIndex = 0
        '
        'Bkill
        '
        Me.Bkill.Location = New System.Drawing.Point(13, 58)
        Me.Bkill.Name = "Bkill"
        Me.Bkill.Size = New System.Drawing.Size(75, 23)
        Me.Bkill.TabIndex = 1
        Me.Bkill.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 97)
        Me.Controls.Add(Me.Bkill)
        Me.Controls.Add(Me.TBprocesso)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(270, 136)
        Me.MinimumSize = New System.Drawing.Size(270, 136)
        Me.Name = "Form1"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TASK  KILL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBprocesso As TextBox
    Friend WithEvents Bkill As Button
End Class
