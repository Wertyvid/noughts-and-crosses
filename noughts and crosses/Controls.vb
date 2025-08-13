Public Class DrawButton
    Inherits Button
    Dim positionInGrid(1) As Integer

    Sub New(column As Integer, row As Integer)
        Dock = DockStyle.Fill
        positionInGrid(0) = column
        positionInGrid(1) = row
    End Sub
End Class
