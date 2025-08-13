Public Class Game
    Dim grid(2, 2) As String
    Dim crossImage As Image = Image.FromFile("cross.png")
    Dim noughtImage As Image = Image.FromFile("nought.png")

    Event TurnTaken(identity As String)

    Sub New()
        grid = {{"Empty", "Empty", "Empty"}, {"Empty", "Empty", "Empty"}, {"Empty", "Empty", "Empty"}}
    End Sub

    Sub FillVisualGrid(ByRef grid As TableLayoutPanel, identity As String, Optional interactable As Boolean = True)
        grid.Controls.Clear()
        For column As Integer = 0 To 2
            For row As Integer = 0 To 2
                grid.Controls.Add(GetControlForGridValue(column, row, identity, interactable), column, row)
            Next
        Next
    End Sub

    Function GetControlForGridValue(column As Integer, row As Integer, identity As String, interactable As Boolean) As Control
        If grid(column, row) = "Empty" Then
            Return New DrawButton(identity, column, row, AddressOf DrawSymbol, interactable)
        ElseIf grid(column, row) = "Noughts" Then
            Return GetSymbolPicture(Image.FromFile("nought.png"))
        ElseIf grid(column, row) = "Crosses" Then
            Return GetSymbolPicture(Image.FromFile("cross.png"))
        Else
            Return New Label()
        End If
    End Function

    Function GetSymbolPicture(image As Image) As PictureBox
        Dim newPicture = New PictureBox()
        newPicture.Dock = DockStyle.Fill
        newPicture.Image = crossImage
        Return newPicture
    End Function

    Sub DrawSymbol(sender As DrawButton, e As EventArgs)
        MessageBox.Show(sender.identity)
        grid(sender.positionInGrid(0), sender.positionInGrid(1)) = sender.identity

    End Sub
End Class
