Public Class FrmPlayerMenu
    Dim identity As String
    Dim game As Game
    Dim grid As TableLayoutPanel

    Sub New(setIdentity As String, setGame As Game)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        identity = setIdentity
        game = setGame
        Text = identity
        game.FillVisualGrid(TblLayGameGrid)
    End Sub



End Class