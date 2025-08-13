<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPlayerMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TblLayMain = New TableLayoutPanel()
        TblLayGameGrid = New TableLayoutPanel()
        TblLayMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' TblLayMain
        ' 
        TblLayMain.ColumnCount = 3
        TblLayMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TblLayMain.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 600F))
        TblLayMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0000076F))
        TblLayMain.Controls.Add(TblLayGameGrid, 1, 0)
        TblLayMain.Dock = DockStyle.Fill
        TblLayMain.Location = New Point(0, 0)
        TblLayMain.Name = "TblLayMain"
        TblLayMain.RowCount = 1
        TblLayMain.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TblLayMain.Size = New Size(800, 600)
        TblLayMain.TabIndex = 0
        ' 
        ' TblLayGameGrid
        ' 
        TblLayGameGrid.ColumnCount = 3
        TblLayGameGrid.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 200F))
        TblLayGameGrid.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 200F))
        TblLayGameGrid.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 200F))
        TblLayGameGrid.Dock = DockStyle.Fill
        TblLayGameGrid.Location = New Point(102, 3)
        TblLayGameGrid.Name = "TblLayGameGrid"
        TblLayGameGrid.RowCount = 3
        TblLayGameGrid.RowStyles.Add(New RowStyle(SizeType.Absolute, 200F))
        TblLayGameGrid.RowStyles.Add(New RowStyle(SizeType.Absolute, 200F))
        TblLayGameGrid.RowStyles.Add(New RowStyle(SizeType.Absolute, 200F))
        TblLayGameGrid.Size = New Size(594, 594)
        TblLayGameGrid.TabIndex = 0
        ' 
        ' FrmPlayerMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 600)
        Controls.Add(TblLayMain)
        Name = "FrmPlayerMenu"
        Text = "PlayerForm"
        TblLayMain.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TblLayMain As TableLayoutPanel
    Friend WithEvents TblLayGameGrid As TableLayoutPanel
End Class
