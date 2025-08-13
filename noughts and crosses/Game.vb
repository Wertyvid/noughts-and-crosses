Public Class Game
    Dim grid(2, 2) As String
    Dim crossImage As Image = Image.FromFile("cross.png")
    Dim noughtImage As Image = Image.FromFile("nought.png")

    Sub New()
        grid = {{"Empty", "Empty", "Empty"}, {"Empty", "Empty", "Empty"}, {"Empty", "Empty", "Empty"}}
    End Sub

    Sub FillVisualGrid(ByRef grid As TableLayoutPanel)
        grid.Controls.Clear()
        For column As Integer = 0 To 2
            For row As Integer = 0 To 2
                grid.Controls.Add(GetControlForGridValue(column, row), column, row)
            Next
        Next
    End Sub

    Function GetControlForGridValue(column As Integer, row As Integer) As Control
        If grid(column, row) = "Empty" Then
            Return New DrawButton(column, row)
        ElseIf grid(column, row) = "Noughts" Then
            Dim newPicture = New PictureBox()
            newPicture.Dock = DockStyle.Fill
            newPicture.Image = noughtImage
            Return newPicture
        ElseIf grid(column, row) = "Crosses" Then
            Dim newPicture = New PictureBox()
            newPicture.Dock = DockStyle.Fill
            newPicture.Image = crossImage
            Return newPicture
        Else
            Return New Label()
        End If
    End Function
End Class
