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
        Me.Label1 = New System.Windows.Forms.Label
        Me.textGrammar = New System.Windows.Forms.TextBox
        Me.buttonSetGrammar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.textRecognized = New System.Windows.Forms.TextBox
        Me.buttonSpeech = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grammar"
        '
        'textGrammar
        '
        Me.textGrammar.Location = New System.Drawing.Point(12, 25)
        Me.textGrammar.Multiline = True
        Me.textGrammar.Name = "textGrammar"
        Me.textGrammar.Size = New System.Drawing.Size(233, 412)
        Me.textGrammar.TabIndex = 1
        '
        'buttonSetGrammar
        '
        Me.buttonSetGrammar.Enabled = False
        Me.buttonSetGrammar.Location = New System.Drawing.Point(12, 443)
        Me.buttonSetGrammar.Name = "buttonSetGrammar"
        Me.buttonSetGrammar.Size = New System.Drawing.Size(116, 23)
        Me.buttonSetGrammar.TabIndex = 2
        Me.buttonSetGrammar.Text = "Set Grammar"
        Me.buttonSetGrammar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(288, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Recognized"
        '
        'textRecognized
        '
        Me.textRecognized.Location = New System.Drawing.Point(291, 25)
        Me.textRecognized.Multiline = True
        Me.textRecognized.Name = "textRecognized"
        Me.textRecognized.ReadOnly = True
        Me.textRecognized.Size = New System.Drawing.Size(223, 413)
        Me.textRecognized.TabIndex = 4
        '
        'buttonSpeech
        '
        Me.buttonSpeech.Enabled = False
        Me.buttonSpeech.Location = New System.Drawing.Point(291, 443)
        Me.buttonSpeech.Name = "buttonSpeech"
        Me.buttonSpeech.Size = New System.Drawing.Size(228, 23)
        Me.buttonSpeech.TabIndex = 5
        Me.buttonSpeech.Text = "Enable Speech"
        Me.buttonSpeech.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 478)
        Me.Controls.Add(Me.buttonSpeech)
        Me.Controls.Add(Me.textRecognized)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.buttonSetGrammar)
        Me.Controls.Add(Me.textGrammar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents textGrammar As System.Windows.Forms.TextBox
    Friend WithEvents buttonSetGrammar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents textRecognized As System.Windows.Forms.TextBox
    Friend WithEvents buttonSpeech As System.Windows.Forms.Button

End Class
