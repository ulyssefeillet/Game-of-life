'Jeu de la vie 
'Ulysse Feillet / Nicolas Laurent
'IUT d'Orsay TP 2I

Imports GameOfLife1

Public Class MoteurUI

    Private tileHeight = 20
    Private tileWidth = 20

    Private bStop As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Shown

        RetaillePictureBox()

        Dim moteur As Moteur
        moteur = moteur.getInstance()

    End Sub


    Private Sub PictureBox1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DrawGrid(Moteur.getInstance())

    End Sub


    Private Sub PictureBox1_Paint(sender As Object, e As EventArgs) Handles MyBase.Paint

        DrawGrid(Moteur.getInstance())


    End Sub

    Private Sub PictureBox1_Resize()
        PictureBox1.Width = 20
        PictureBox1.Height = 20
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Moteur.getInstance().etatSuivant()
        DrawGrid(Moteur.getInstance())
    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick

        Dim xPixel = e.Location.X
        Dim yPixel = e.Location.Y

        Dim cellCoordinates = Moteur.getInstance().getCelluleCoordinatesFromPixel(xPixel, yPixel)
        Moteur.getInstance().inverseCell(cellCoordinates)

        DrawCell(Moteur.getInstance(), cellCoordinates.x, cellCoordinates.y)

    End Sub

    Private Sub DrawGrid(ByRef moteur As Moteur)

        'vue
        Dim internalTileXBorder = 4
        Dim internalTileYBorder = 4

        Dim gridPen = New Pen(Color.FromArgb(255, 0, 0, 150))

        Dim moteurNbLignes As Integer
        Dim moteurNbColonnes As Integer
        moteur.getTailleGrille(moteurNbLignes, moteurNbColonnes)

        Dim size1 = New Size(tileWidth - internalTileXBorder, tileHeight - internalTileYBorder)

        'Affichage des lignes
        For ligne = 0 To moteurNbLignes
            Dim p1 = New Point(0, ligne * tileHeight)
            Dim p2 = New Point(tileWidth * moteurNbColonnes, ligne * tileWidth)

            PictureBox1.CreateGraphics.DrawLine(gridPen, p1, p2)
        Next

        'Affichage des colonnes
        For colonne = 0 To moteurNbColonnes
            Dim p1 = New Point(colonne * tileWidth, 0)
            Dim p2 = New Point(colonne * tileHeight, moteurNbLignes * tileHeight)

            PictureBox1.CreateGraphics.DrawLine(gridPen, p1, p2)
        Next

        'affichage de l'etat des cellules
        For ligne = 0 To moteurNbLignes - 1

            For colonne = 0 To moteurNbColonnes - 1
                DrawCell(moteur, ligne, colonne)
            Next
        Next

    End Sub

    'affichage de l'etat de la cellule
    Private Sub DrawCell(ByRef moteur As Moteur, ligne As Integer, colonne As Integer)

        'vue
        Dim internalTileXBorder = 4
        Dim internalTileYBorder = 4

        Dim whiteBrush = New SolidBrush(Color.White)
        Dim blackBrush = New SolidBrush(Color.Black)

        Dim emptyPen = New Pen(Color.FromArgb(0, 0, 0, 0))
        Dim gridPen = New Pen(Color.FromArgb(255, 0, 0, 150))
        Dim cellPen = New Pen(Color.FromArgb(255, 0, 150, 0))
        Dim size1 = New Size(tileWidth - internalTileXBorder, tileHeight - internalTileYBorder)

        Dim font = New Drawing.Font("Times New Roman", 6, FontStyle.Regular)

        Dim pointCourant = New Point((colonne * tileWidth) + (internalTileXBorder / 2), (ligne * tileHeight) + (internalTileYBorder / 2))
        Dim rectangleCourant = New Rectangle(pointCourant, size1)

        If moteur.getEtatCellule(ligne, colonne) = True Then

            PictureBox1.CreateGraphics.FillRectangle(blackBrush, rectangleCourant)

        Else
            PictureBox1.CreateGraphics.FillRectangle(whiteBrush, rectangleCourant)
        End If

    End Sub

    Public Sub RetaillePictureBox()

        'Recuperer la taille en cellules
        Dim nbLigne As Integer
        Dim nbColonne As Integer
        Moteur.getInstance.getTailleGrille(nbLigne, nbColonne)

        'Deduire la taille de la zone a afficher
        Dim viewWidth = (nbColonne * tileWidth) + 4
        Dim viewHeight = (nbLigne * tileHeight) + 4

        PictureBox1.Size = New Drawing.Size(viewWidth, viewHeight)

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Moteur.getInstance().randomize()
        DrawGrid(Moteur.getInstance())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Executer.Click
        bStop = False
        Dim i = 0
        Dim max = 200

        While i < max And Not bStop
            Moteur.getInstance().etatSuivant()
            DrawGrid(Moteur.getInstance())

            ProgressBar1.Value = i * 100 / max
            i = i + 1

            Application.DoEvents()

        End While

        ProgressBar1.Value = 0

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        bStop = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ParametresUI.Show()
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        Moteur.getInstance().resetCells()
        DrawGrid(Moteur.getInstance())
    End Sub

End Class

'
' Classe Moteur
'

Friend Class Moteur
    Private Shared Instance As Moteur
    Private nbLignes = 30
    Private nbColonnes = 30

    Private minMort = 2
    Private maxMort = 5
    Private minNaissance = 3
    Private maxNaissance = 3

    Private cells(nbLignes, nbColonnes) As Boolean

    Public Shared Function getInstance() As Moteur

        If Instance Is Nothing Then
            Instance = New Moteur()
        End If

        Return Instance

    End Function



    Private Sub initCells()

        'Realloue le tableau de cellules
        ReDim cells(getNbLignes(), getNbColonnes())

        For ligne = 0 To nbLignes - 1
            For colonne = 0 To nbColonnes - 1
                cells(ligne, colonne) = False
            Next
        Next

    End Sub

    Public Sub setRegle(_minMort, _maxMort, _minNaissance, _maxNaissance)

        minMort = _minMort
        maxMort = _maxMort
        minNaissance = _minNaissance
        maxNaissance = _maxNaissance

    End Sub

    ' Engine Interface
    ' Parametres de dimension passés par reference
    Public Sub getTailleGrille(ByRef n As Integer, ByRef m As Integer)
        n = getNbLignes()
        m = getNbColonnes()
    End Sub

    Public Sub setTailleGrille(_nbLignes, _nbColonnes)
        nbLignes = _nbLignes
        nbColonnes = _nbColonnes

        initCells()

        'retailler le PictureBox

    End Sub

    Public Sub resetCells()

        For ligne = 0 To nbLignes - 1
            For colonne = 0 To nbColonnes - 1
                cells(ligne, colonne) = False
            Next
        Next

    End Sub

    Public Sub randomize()

        For ligne = 0 To nbLignes - 1
            For colonne = 0 To nbColonnes - 1
                Dim random As Single
                random = Rnd()
                Dim vie As Boolean

                If random > 0.5 Then
                    vie = True
                Else
                    vie = False
                End If

                cells(ligne, colonne) = vie
            Next
        Next

    End Sub

    'getTailleGrille(entier n, entier m) 
    'Implémenté par getnbLignes et getnbColonnes

    Private Function getNbLignes() As Integer
        Return nbLignes
    End Function

    Private Function getNbColonnes() As Integer
        Return nbColonnes
    End Function

    Public Sub setNbLignes(_nbLignes)
        nbLignes = _nbLignes

        initCells()
    End Sub

    Public Sub setNbColonnes(_nbColonnes)
        nbColonnes = _nbColonnes

        initCells()
    End Sub

    Public Sub etatSuivant()

        Dim cells2(nbLignes, nbColonnes) As Boolean

        For ligne = 0 To nbLignes - 1
            For colonne = 0 To nbColonnes - 1
                ' Etat suivant de chaque cellule
                cells2(ligne, colonne) = etatSuivantCellule(ligne, colonne)
            Next
        Next

        'on copie les valeurs
        cells = cells2
    End Sub

    Private Function etatSuivantCellule(ligne As Integer, colonne As Integer) As Boolean

        Dim nbVoisins = getNbVoisins(ligne, colonne)

        'Naissance
        If nbVoisins >= minNaissance And nbVoisins <= maxNaissance Then
            Return True
        End If

        'Maintien en vie
        If nbVoisins > minMort And nbVoisins < maxMort Then
            Return True
        End If

        'Mort
        Return False

    End Function

    Public Function getNbVoisins(line, col) As Integer
        Dim nbVoisins As Integer

        nbVoisins = 0

        If getEtatCellule(line - 1, col - 1) = True Then
            nbVoisins = nbVoisins + 1
        End If

        If getEtatCellule(line - 1, col) = True Then
            nbVoisins = nbVoisins + 1
        End If

        If getEtatCellule(line - 1, col + 1) = True Then
            nbVoisins = nbVoisins + 1
        End If

        If getEtatCellule(line, col - 1) = True Then
            nbVoisins = nbVoisins + 1
        End If

        If getEtatCellule(line, col + 1) = True Then
            nbVoisins = nbVoisins + 1
        End If

        If getEtatCellule(line + 1, col - 1) = True Then
            nbVoisins = nbVoisins + 1
        End If

        If getEtatCellule(line + 1, col) = True Then
            nbVoisins = nbVoisins + 1
        End If

        If getEtatCellule(line + 1, col + 1) = True Then
            nbVoisins = nbVoisins + 1
        End If

        Return nbVoisins
    End Function

    Public Function getEtatCellule(line, col) As Boolean
        Dim value As Integer
        value = 0

        'erreurs
        If line < 0 Then
            Return 0
        End If

        If line >= nbLignes Then
            Return 0
        End If

        If col < 0 Then
            Return 0
        End If

        If col >= nbColonnes Then
            Return 0
        End If

        Return cells(line, col)
    End Function

    Public Function getCelluleCoordinatesFromPixel(xPixel As Integer, yPixel As Integer) As CellCoordinates
        Dim cellCoordinates = New CellCoordinates()

        Dim tileHeight = 20
        Dim tileWidth = 20

        cellCoordinates.x = (yPixel - tileHeight / 2) / tileHeight
        cellCoordinates.y = (xPixel - tileWidth / 2) / tileWidth

        Return cellCoordinates
    End Function

    Friend Sub inverseCell(cellCoordinates As CellCoordinates)
        If getEtatCellule(cellCoordinates.x, cellCoordinates.y) = True Then
            setEtatCellule(cellCoordinates.x, cellCoordinates.y, False)
        Else
            setEtatCellule(cellCoordinates.x, cellCoordinates.y, True)
        End If

    End Sub

    Private Sub setEtatCellule(x As Integer, y As Integer, etat As Boolean)
        cells(x, y) = etat
    End Sub


    Public Function getMinMort() As Integer
        Return minMort
    End Function

    Public Function getMaxMort() As Integer
        Return maxMort
    End Function

    Public Function getMinNaissance() As Integer
        Return minNaissance
    End Function

    Public Function getMaxNaissance() As Integer
        Return maxNaissance
    End Function

End Class

Friend Class CellCoordinates
    Public x As Integer
    Public y As Integer
End Class
