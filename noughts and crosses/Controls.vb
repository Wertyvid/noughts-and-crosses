Public Class DrawButton
    Inherits Button
    Public identity As String
    Public positionInGrid(1) As Integer


    Sub New(setIdentity As String, column As Integer, row As Integer, Optional interactable As Boolean = True)
        Dock = DockStyle.Fill
        positionInGrid(0) = column
        positionInGrid(1) = row
        Enabled = interactable
        identity = setIdentity
    End Sub

    Sub New(setIdentity As String, column As Integer, row As Integer, eventHandler As EventHandler, Optional interactable As Boolean = True)
        Dock = DockStyle.Fill
        positionInGrid(0) = column
        positionInGrid(1) = row
        Enabled = interactable
        identity = setIdentity
        AddHandler Click, eventHandler
    End Sub

End Class
