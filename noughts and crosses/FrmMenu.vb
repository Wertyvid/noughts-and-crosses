Public Class FrmMenu
    Dim WithEvents noughtsForm As FrmPlayerMenu
    Dim WithEvents crossesForm As FrmPlayerMenu
    Dim winStats As WinStats = New WinStats()
    Sub StartNewGame() Handles BtnStart.Click
        Dim game As New Game()
        noughtsForm = New FrmPlayerMenu("Noughts", game, winStats.noughtsWins)
        crossesForm = New FrmPlayerMenu("Crosses", game, winStats.crossesWins)
        noughtsForm.Show()
        crossesForm.Show()

    End Sub

    Sub noughtsForm_Won() Handles noughtsForm.Won
        winStats.noughtsWins += 1
    End Sub

    Sub crossesForm_Won() Handles crossesForm.Won
        winStats.crossesWins += 1
    End Sub
End Class


Public Class WinStats
    Public crossesWins As Integer = 0
    Public noughtsWins As Integer = 0
End Class
