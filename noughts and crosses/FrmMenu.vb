Public Class FrmMenu
    Sub StartNewGame() Handles BtnStart.Click
        Dim game As New Game()
        Dim noughtsForm = New FrmPlayerMenu("Noughts", game)
        Dim crossesForm = New FrmPlayerMenu("Crosses", game)
        noughtsForm.Show()
        crossesForm.Show()

    End Sub
End Class
