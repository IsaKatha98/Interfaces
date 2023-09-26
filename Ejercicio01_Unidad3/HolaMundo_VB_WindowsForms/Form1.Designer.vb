<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ButtonSaludo = New Button()
        Txt1 = New TextBox()
        SuspendLayout()
        ' 
        ' ButtonSaludo
        ' 
        ButtonSaludo.Location = New Point(351, 230)
        ButtonSaludo.Name = "ButtonSaludo"
        ButtonSaludo.Size = New Size(108, 57)
        ButtonSaludo.TabIndex = 0
        ButtonSaludo.Text = "Saludo" & vbCrLf
        ButtonSaludo.UseVisualStyleBackColor = True
        ' 
        ' Txt1
        ' 
        Txt1.Location = New Point(275, 187)
        Txt1.Name = "Txt1"
        Txt1.Size = New Size(250, 23)
        Txt1.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Txt1)
        Controls.Add(ButtonSaludo)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonSaludo As Button
    Friend WithEvents Txt1 As TextBox
End Class
