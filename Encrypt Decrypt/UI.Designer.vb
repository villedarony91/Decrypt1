<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI
    Inherits Telerik.WinControls.UI.RadForm

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
        Me.HighContrastBlackTheme1 = New Telerik.WinControls.Themes.HighContrastBlackTheme()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(92, 23)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(196, 20)
        Me.txtInput.TabIndex = 0
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Location = New System.Drawing.Point(92, 59)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(81, 23)
        Me.btnEncrypt.TabIndex = 1
        Me.btnEncrypt.Text = "Encriptar"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(93, 105)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(195, 20)
        Me.txtOutput.TabIndex = 2
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(208, 59)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(80, 23)
        Me.btnDecrypt.TabIndex = 3
        Me.btnDecrypt.Text = "Desencriptar"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'UI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 163)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "UI"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "UI"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HighContrastBlackTheme1 As Telerik.WinControls.Themes.HighContrastBlackTheme
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents btnDecrypt As System.Windows.Forms.Button
End Class

