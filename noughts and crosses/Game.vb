Imports System.Data.Common

Public Class Game
    Dim grid(2, 2) As String
    Dim crossImage As Image = Image.FromFile("cross.png")
    Dim noughtImage As Image = Image.FromFile("nought.png")

    Event TurnTaken(identity As String)
    Event GameWon(identity As String)
    Event Draw()

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
        newPicture.Image = image
        Return newPicture
    End Function

    Sub DrawSymbol(sender As DrawButton, e As EventArgs)
        grid(sender.positionInGrid(0), sender.positionInGrid(1)) = sender.identity
        Dim winningMove = CheckForWin(sender.identity)
        If winningMove Then
            RaiseEvent GameWon(sender.identity)
            MessageBox.Show(sender.identity + " Wins!")
        ElseIf CheckForDraw() Then
            RaiseEvent Draw()
            MessageBox.Show("Draw!")
        Else
            RaiseEvent TurnTaken(sender.identity)
        End If
    End Sub

    Function CheckForWin(identity As String) As Boolean
        If (grid(0, 0) = identity And grid(1, 1) = identity And grid(2, 2) = identity) Or (grid(0, 2) = identity And grid(1, 1) = identity And grid(2, 0) = identity) Then
            Return True
        End If
        For column As Integer = 0 To 2
            If grid(column, 0) = identity And grid(column, 1) = identity And grid(column, 2) = identity Then
                Return True
            End If
        Next
        For row As Integer = 0 To 2
            If grid(0, row) = identity And grid(1, row) = identity And grid(2, row) = identity Then
                Return True
            End If
        Next
        Return False
    End Function

    Function CheckForDraw() As Boolean
        For column As Integer = 0 To 2
            For row As Integer = 0 To 2
                If grid(column, row) = "Empty" Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function
End Class
