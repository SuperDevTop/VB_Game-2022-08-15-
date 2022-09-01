<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Menu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRecentResults = New System.Windows.Forms.Button()
        Me.btnPastResults = New System.Windows.Forms.Button()
        Me.btnPlayGames = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnTeacher = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(853, 30)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(54, 26)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'btnRecentResults
        '
        Me.btnRecentResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecentResults.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRecentResults.Location = New System.Drawing.Point(257, 345)
        Me.btnRecentResults.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRecentResults.Name = "btnRecentResults"
        Me.btnRecentResults.Size = New System.Drawing.Size(333, 55)
        Me.btnRecentResults.TabIndex = 12
        Me.btnRecentResults.Text = "Recent Results"
        Me.btnRecentResults.UseVisualStyleBackColor = True
        '
        'btnPastResults
        '
        Me.btnPastResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPastResults.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnPastResults.Location = New System.Drawing.Point(257, 282)
        Me.btnPastResults.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPastResults.Name = "btnPastResults"
        Me.btnPastResults.Size = New System.Drawing.Size(333, 55)
        Me.btnPastResults.TabIndex = 13
        Me.btnPastResults.Text = "Past Results"
        Me.btnPastResults.UseVisualStyleBackColor = True
        '
        'btnPlayGames
        '
        Me.btnPlayGames.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayGames.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnPlayGames.Location = New System.Drawing.Point(257, 156)
        Me.btnPlayGames.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPlayGames.Name = "btnPlayGames"
        Me.btnPlayGames.Size = New System.Drawing.Size(333, 55)
        Me.btnPlayGames.TabIndex = 14
        Me.btnPlayGames.Text = "Play Games 1.0"
        Me.btnPlayGames.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTitle.Location = New System.Drawing.Point(160, 86)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(486, 39)
        Me.lblTitle.TabIndex = 15
        Me.lblTitle.Text = "Teachers Cloud Health Menu"
        '
        'btnTeacher
        '
        Me.btnTeacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeacher.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnTeacher.Location = New System.Drawing.Point(257, 219)
        Me.btnTeacher.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTeacher.Name = "btnTeacher"
        Me.btnTeacher.Size = New System.Drawing.Size(333, 55)
        Me.btnTeacher.TabIndex = 16
        Me.btnTeacher.Text = "Teacher Console"
        Me.btnTeacher.UseVisualStyleBackColor = True
        '
        'Frm_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(853, 443)
        Me.Controls.Add(Me.btnTeacher)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnPlayGames)
        Me.Controls.Add(Me.btnPastResults)
        Me.Controls.Add(Me.btnRecentResults)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnRecentResults As Button
    Friend WithEvents btnPastResults As Button
    Friend WithEvents btnPlayGames As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnTeacher As Button
End Class
