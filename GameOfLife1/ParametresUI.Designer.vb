<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ParametresUI
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NbLignes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NbColonnes = New System.Windows.Forms.TextBox()
        Me.VivreMax = New System.Windows.Forms.NumericUpDown()
        Me.NaissanceMax = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.VivreMin = New System.Windows.Forms.NumericUpDown()
        Me.NaissanceMin = New System.Windows.Forms.NumericUpDown()
        Me.bOk = New System.Windows.Forms.Button()
        CType(Me.VivreMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NaissanceMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.VivreMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NaissanceMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nbr de voisins pour rester en vie"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nbr de voisins pour naître"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Nb lignes"
        '
        'NbLignes
        '
        Me.NbLignes.Location = New System.Drawing.Point(89, 29)
        Me.NbLignes.Name = "NbLignes"
        Me.NbLignes.Size = New System.Drawing.Size(59, 20)
        Me.NbLignes.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Nb Colonnes"
        '
        'NbColonnes
        '
        Me.NbColonnes.Location = New System.Drawing.Point(89, 73)
        Me.NbColonnes.Name = "NbColonnes"
        Me.NbColonnes.Size = New System.Drawing.Size(59, 20)
        Me.NbColonnes.TabIndex = 12
        '
        'VivreMax
        '
        Me.VivreMax.Location = New System.Drawing.Point(323, 73)
        Me.VivreMax.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.VivreMax.Name = "VivreMax"
        Me.VivreMax.Size = New System.Drawing.Size(44, 20)
        Me.VivreMax.TabIndex = 13
        Me.VivreMax.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'NaissanceMax
        '
        Me.NaissanceMax.Location = New System.Drawing.Point(323, 29)
        Me.NaissanceMax.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NaissanceMax.Name = "NaissanceMax"
        Me.NaissanceMax.Size = New System.Drawing.Size(44, 20)
        Me.NaissanceMax.TabIndex = 14
        Me.NaissanceMax.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NbLignes)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.NbColonnes)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 125)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Grille"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.VivreMin)
        Me.GroupBox2.Controls.Add(Me.NaissanceMin)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.NaissanceMax)
        Me.GroupBox2.Controls.Add(Me.VivreMax)
        Me.GroupBox2.Location = New System.Drawing.Point(239, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(373, 125)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Regles de vie"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(293, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Max"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(293, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Max"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(194, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Min"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(194, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Min"
        '
        'VivreMin
        '
        Me.VivreMin.Location = New System.Drawing.Point(224, 73)
        Me.VivreMin.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.VivreMin.Name = "VivreMin"
        Me.VivreMin.Size = New System.Drawing.Size(44, 20)
        Me.VivreMin.TabIndex = 16
        Me.VivreMin.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'NaissanceMin
        '
        Me.NaissanceMin.Location = New System.Drawing.Point(224, 29)
        Me.NaissanceMin.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NaissanceMin.Name = "NaissanceMin"
        Me.NaissanceMin.Size = New System.Drawing.Size(44, 20)
        Me.NaissanceMin.TabIndex = 15
        Me.NaissanceMin.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'bOk
        '
        Me.bOk.Location = New System.Drawing.Point(534, 179)
        Me.bOk.Name = "bOk"
        Me.bOk.Size = New System.Drawing.Size(78, 31)
        Me.bOk.TabIndex = 17
        Me.bOk.Text = "Ok"
        Me.bOk.UseVisualStyleBackColor = True
        '
        'ParametresUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 234)
        Me.Controls.Add(Me.bOk)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ParametresUI"
        Me.Text = "Parametres"
        CType(Me.VivreMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NaissanceMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.VivreMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NaissanceMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NbLignes As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NbColonnes As TextBox
    Friend WithEvents VivreMax As NumericUpDown
    Friend WithEvents NaissanceMax As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents VivreMin As NumericUpDown
    Friend WithEvents NaissanceMin As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents bOk As Button
End Class
