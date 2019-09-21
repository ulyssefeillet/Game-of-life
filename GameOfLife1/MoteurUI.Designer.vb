<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MoteurUI
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Executer = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GridPanel = New System.Windows.Forms.Panel()
        Me.Reset = New System.Windows.Forms.Button()
        Me.ExecGroupBox = New System.Windows.Forms.GroupBox()
        Me.ConfigGroupBox = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExecGroupBox.SuspendLayout()
        Me.ConfigGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(34, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 51)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Executer pas à pas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(12, 30)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(1600, 940)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(689, 607)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(128, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 51)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Randomize cells"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Executer
        '
        Me.Executer.Location = New System.Drawing.Point(132, 99)
        Me.Executer.Name = "Executer"
        Me.Executer.Size = New System.Drawing.Size(74, 52)
        Me.Executer.TabIndex = 4
        Me.Executer.Text = "Executer en séquence"
        Me.Executer.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(30, 225)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(176, 52)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Arrêt"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.AutoSize = True
        Me.Button5.Location = New System.Drawing.Point(30, 32)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(176, 37)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Paramètres"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(30, 177)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(176, 23)
        Me.ProgressBar1.TabIndex = 11
        '
        'GridPanel
        '
        Me.GridPanel.AutoScroll = True
        Me.GridPanel.AutoSize = True
        Me.GridPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GridPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GridPanel.Location = New System.Drawing.Point(12, 24)
        Me.GridPanel.Name = "GridPanel"
        Me.GridPanel.Size = New System.Drawing.Size(2, 2)
        Me.GridPanel.TabIndex = 12
        '
        'Reset
        '
        Me.Reset.Location = New System.Drawing.Point(30, 23)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(78, 51)
        Me.Reset.TabIndex = 13
        Me.Reset.Text = "Remise à zéro"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'ExecGroupBox
        '
        Me.ExecGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExecGroupBox.Controls.Add(Me.Button4)
        Me.ExecGroupBox.Controls.Add(Me.Button1)
        Me.ExecGroupBox.Controls.Add(Me.Reset)
        Me.ExecGroupBox.Controls.Add(Me.ProgressBar1)
        Me.ExecGroupBox.Controls.Add(Me.Button2)
        Me.ExecGroupBox.Controls.Add(Me.Executer)
        Me.ExecGroupBox.Location = New System.Drawing.Point(735, 24)
        Me.ExecGroupBox.Name = "ExecGroupBox"
        Me.ExecGroupBox.Size = New System.Drawing.Size(237, 296)
        Me.ExecGroupBox.TabIndex = 14
        Me.ExecGroupBox.TabStop = False
        Me.ExecGroupBox.Text = "Execution"
        '
        'ConfigGroupBox
        '
        Me.ConfigGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConfigGroupBox.Controls.Add(Me.Button5)
        Me.ConfigGroupBox.Location = New System.Drawing.Point(735, 345)
        Me.ConfigGroupBox.Name = "ConfigGroupBox"
        Me.ConfigGroupBox.Size = New System.Drawing.Size(237, 100)
        Me.ConfigGroupBox.TabIndex = 15
        Me.ConfigGroupBox.TabStop = False
        Me.ConfigGroupBox.Text = "Configuration"
        '
        'MoteurUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 676)
        Me.Controls.Add(Me.ConfigGroupBox)
        Me.Controls.Add(Me.ExecGroupBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GridPanel)
        Me.Name = "MoteurUI"
        Me.Text = "Jeu de la vie"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExecGroupBox.ResumeLayout(False)
        Me.ConfigGroupBox.ResumeLayout(False)
        Me.ConfigGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Executer As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents GridPanel As Panel
    Friend WithEvents Reset As Button
    Friend WithEvents ExecGroupBox As GroupBox
    Friend WithEvents ConfigGroupBox As GroupBox
End Class
