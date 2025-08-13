Public Class FrmPlayerMenu
    Dim identity As String
    Dim WithEvents game As Game
    Dim grid As TableLayoutPanel

    Sub New(setIdentity As String, setGame As Game)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        identity = setIdentity
        game = setGame
        Text = identity
        If identity = "Noughts" Then
            game.FillVisualGrid(TblLayGameGrid, identity)
        Else
            game.FillVisualGrid(TblLayGameGrid, identity, False)
        End If

    End Sub

    Sub game_TurnTaken(eventIdentity As String) Handles game.TurnTaken
        If identity = eventIdentity Then
            game.FillVisualGrid(TblLayGameGrid, identity, False)
        Else
            game.FillVisualGrid(TblLayGameGrid, identity)
        End If
    End Sub

    Sub game_GameWon(winner As String) Handles game.GameWon
        game.FillVisualGrid(TblLayGameGrid, identity, False)
    End Sub

    Sub game_Draw() Handles game.Draw
        game.FillVisualGrid(TblLayGameGrid, identity, False)
    End Sub
End Class