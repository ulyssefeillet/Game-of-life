Public Class ParametresUI
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim moteurNbLignes As Integer
        Dim moteurNbColonnes As Integer
        Moteur.getInstance().getTailleGrille(moteurNbLignes, moteurNbColonnes)

        'Initialisation des textboxs
        NbLignes.Text = moteurNbLignes
        NbColonnes.Text = moteurNbColonnes

        'Initialisation des limites
        NaissanceMin.Value = Moteur.getInstance().getMinNaissance()
        NaissanceMax.Value = Moteur.getInstance().getMaxNaissance()
        VivreMin.Value = Moteur.getInstance().getMinMort() + 1
        VivreMax.Value = Moteur.getInstance().getMaxMort() - 1

    End Sub

    Private Sub NaissanceMin_ValueChanged(sender As Object, e As EventArgs) Handles NaissanceMin.ValueChanged
        'Changer si necessaire la valeur max
        If NaissanceMin.Value > NaissanceMax.Value Then NaissanceMax.Value = NaissanceMin.Value
    End Sub

    Private Sub NaissanceMax_ValueChanged(sender As Object, e As EventArgs) Handles NaissanceMax.ValueChanged
        'Changer si necessaire la valeur min
        If NaissanceMax.Value < NaissanceMin.Value Then NaissanceMin.Value = NaissanceMax.Value
    End Sub

    Private Sub VivreMin_ValueChanged(sender As Object, e As EventArgs) Handles VivreMin.ValueChanged
        'Changer si necessaire la valeur max
        If VivreMin.Value > VivreMax.Value Then VivreMax.Value = VivreMin.Value
    End Sub

    Private Sub VivreMax_ValueChanged(sender As Object, e As EventArgs) Handles VivreMax.ValueChanged
        'Changer si necessaire la valeur min
        If VivreMax.Value < VivreMin.Value Then VivreMin.Value = VivreMax.Value
    End Sub

    Private Sub bOk_Click(sender As Object, e As EventArgs) Handles bOk.Click

        Dim value As String

        'NbLignes
        value = NbLignes.Text
        Dim IntValue As Integer

        Try
            IntValue = Convert.ToDecimal(value)
        Catch ex As Exception
            IntValue = 30
        End Try

        Moteur.getInstance().setNbLignes(IntValue)

        'NbColonnes
        value = NbColonnes.Text

        Try
            IntValue = Convert.ToDecimal(value)
        Catch ex As Exception
            IntValue = 30
        End Try

        Moteur.getInstance().setNbColonnes(IntValue)

        MoteurUI.RetaillePictureBox()

        ' Invalide le pictureBox pour redessiner la grille aux dernieres dimensions
        MoteurUI.PictureBox1.Invalidate()

        'Regles
        Dim naissanceMin = Me.NaissanceMin.Value
        Dim naissanceMax = Me.NaissanceMax.Value

        'Garde les valeurs dans un domaine O-8
        If naissanceMin < 1 Then naissanceMin = 0
        If naissanceMax > 8 Then naissanceMax = 8

        Dim vivreMin = Me.VivreMin.Value
        Dim vivreMax = Me.VivreMax.Value

        Dim mortMin = naissanceMin - 1
        Dim mortMax = vivreMax + 1

        If vivreMin < naissanceMin Then mortMin = vivreMin - 1
        If naissanceMax > vivreMax Then mortMax = naissanceMax + 1

        Moteur.getInstance().setRegle(mortMin, mortMax, naissanceMin, naissanceMax)

        Me.Close()

    End Sub

End Class