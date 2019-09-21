Imports GameOfLife1

Public Class Form1

    Private tileHeight As Integer
    Private tileWidth As Integer

    Private lifeGame As LifeGame

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Shown

        lifeGame = New LifeGame()

        'Label1.Text = "Hi World"
        'DrawGrid(lifeGame)

    End Sub

    Private Sub PictureBox1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lifeGame = New LifeGame()

        Label1.Text = "PictureBox1_Load"
        DrawGrid(lifeGame)

    End Sub

    Private Sub PictureBox1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        'lifeGame = New LifeGame()

        Label1.Text = "PictureBox1_Shown"
        DrawGrid(lifeGame)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "Jeu démarré"
        lifeGame.run()
        DrawGrid(lifeGame)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.Text = lifeGame.ToString()
    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        'e.Button == MouseButtons.Left
        Dim xPixel = e.Location.X
        Dim yPixel = e.Location.Y
        'MsgBox("Position dans la form : " & xPixel.ToString & " : " & yPixel.ToString)

        Dim cellCoordinates = lifeGame.getCelluleCoordinatesFromPixel(xPixel, yPixel)
        lifeGame.inverseCell(cellCoordinates)

        DrawGrid(lifeGame)


    End Sub

    ' Private Sub PictureBox1_Load(sender As Object, e As EventArgs) Handles PictureBox1.Resize
    'DrawGrid()
    'End Sub

    Private Sub DrawGrid(ByRef lifeGame As LifeGame)

        'vue
        tileHeight = 20
        tileWidth = 20
        Dim internalTileXBorder = 4
        Dim internalTileYBorder = 4

        'Create solid brush 
        Dim whiteBrush = New SolidBrush(Color.White)
        Dim blackBrush = New SolidBrush(Color.Black)

        Dim emptyPen = New Pen(Color.FromArgb(0, 0, 0, 0))
        Dim gridPen = New Pen(Color.FromArgb(255, 0, 0, 150))
        Dim cellPen = New Pen(Color.FromArgb(255, 0, 150, 0))
        Dim size1 = New Size(tileWidth - internalTileXBorder, tileHeight - internalTileYBorder)

        'Affichage des lignes
        For ligne = 0 To lifeGame.getNbLignes()
            Dim p1 = New Point(0, ligne * tileHeight)
            Dim p2 = New Point(tileWidth * lifeGame.getNbColonnes(), ligne * tileHeight)

            PictureBox1.CreateGraphics.DrawLine(gridPen, p1, p2)
        Next

        'Affichage des colonnes
        For colonne = 0 To lifeGame.getNbColonnes()
            Dim p1 = New Point(colonne * tileWidth, 0)
            Dim p2 = New Point(colonne * tileWidth, lifeGame.getNbColonnes() * tileWidth)

            PictureBox1.CreateGraphics.DrawLine(gridPen, p1, p2)
        Next

        'affichage de l'etat des cellules
        For ligne = 0 To lifeGame.getNbLignes() - 1

            For colonne = 0 To lifeGame.getNbColonnes() - 1

                Dim pointCourant = New Point((ligne * tileWidth) + (internalTileXBorder / 2), (colonne * tileHeight) + (internalTileYBorder / 2))
                Dim rectangleCourant = New Rectangle(pointCourant, size1)

                Dim pointVide = New Point(ligne * tileWidth, colonne * tileHeight)
                Dim rectangleVide = New Rectangle(pointCourant, size1)

                If lifeGame.getCell(ligne, colonne) = 1 Then
                    PictureBox1.CreateGraphics.FillRectangle(blackBrush, rectangleCourant)
                    'PictureBox1.CreateGraphics.DrawEllipse(cellPen, rectangleCo'
                Else
                    PictureBox1.CreateGraphics.FillRectangle(whiteBrush, rectangleCourant)
                End If
            Next
        Next


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lifeGame.randomize()
        DrawGrid(lifeGame)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For i = 0 To 100
            lifeGame.run()
            DrawGrid(lifeGame)
        Next
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    ' Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    '    Arret = False
    'End Sub




End Class

Friend Class LifeGame
    Private nbLignes = 48
    Private nbColonnes = 48
    Private cells(nbLignes, nbColonnes) As Integer
    Public Event MouseClick(sender As Object, e As MouseEventArgs)

    Private Sub init()

        For ligne = 0 To nbLignes - 1
            For colonne = 0 To nbColonnes - 1
                cells(ligne, colonne) = 0
            Next
        Next

    End Sub



    'Private Sub MouseHover()
    '  LifeGame.getCell(line, col).BorderStyle = BorderStyle.Fixed3D
    '  Label1.ForeColor = Color.AntiqueWhite
    'End Sub '



    Public Sub randomize()

        For ligne = 0 To nbLignes - 1
            For colonne = 0 To nbColonnes - 1
                Dim random = Rnd()
                cells(ligne, colonne) = Math.Ceiling(random * 2)
            Next
        Next

    End Sub

    Public Function getCell(line, col) As Integer
        Return cells(line, col)
    End Function

    Public Function getNbLignes() As Integer
        Return nbLignes
    End Function

    Public Function getNbColonnes() As Integer
        Return nbColonnes
    End Function

    Public Sub run()

        Dim cells2(nbLignes, nbColonnes) As Integer

        For ligne = 0 To nbLignes - 1
            For colonne = 0 To nbColonnes - 1
                Dim nbVoisins = getNbVoisins(ligne, colonne)
                If nbVoisins >= 2 And nbVoisins <= 4 Then
                    cells2(ligne, colonne) = 1
                Else
                    cells2(ligne, colonne) = 0
                End If
            Next
        Next

        'copy the new values
        cells = cells2
    End Sub

    Public Sub runInf()
        For i = 0 To 100
            run()
        Next

    End Sub


    Public Function getNbVoisins(line, col) As Integer
        Dim nbVoisins As Integer

        nbVoisins = getCellValue(line - 1, col - 1) +
            getCellValue(line - 1, col) +
            getCellValue(line - 1, col + 1) +
            getCellValue(line, col - 1) +
            getCellValue(line, col + 1) +
            getCellValue(line + 1, col - 1) +
            getCellValue(line + 1, col) +
            getCellValue(line + 1, col + 1)

        Return nbVoisins
    End Function

    Public Function getCellValue(line, col) As Integer
        Dim value As Integer
        value = 0

        'error cases
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

        cellCoordinates.x = (xPixel - tileWidth / 2) / tileWidth
        cellCoordinates.y = (yPixel - tileHeight / 2) / tileHeight

        Return cellCoordinates
    End Function

    Friend Sub inverseCell(cellCoordinates As CellCoordinates)
        If getCell(cellCoordinates.x, cellCoordinates.y) = 1 Then
            setCell(cellCoordinates.x, cellCoordinates.y, 0)
        Else
            setCell(cellCoordinates.x, cellCoordinates.y, 1)
        End If

    End Sub

    Private Sub setCell(x As Integer, y As Integer, val As Integer)
        cells(x, y) = val
    End Sub
End Class

Friend Class CellCoordinates
    Public x As Integer
    Public y As Integer
End Class
