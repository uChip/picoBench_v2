<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetupForm
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Communications = New System.Windows.Forms.TabPage()
        Me.SaveState = New System.Windows.Forms.TabPage()
        Me.State2FacDfltsBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SaveStateBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.AcceptBtn = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Communications.SuspendLayout()
        Me.SaveState.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Communications)
        Me.TabControl1.Controls.Add(Me.SaveState)
        Me.TabControl1.Location = New System.Drawing.Point(1, 9)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(205, 293)
        Me.TabControl1.TabIndex = 3
        '
        'Communications
        '
        Me.Communications.BackColor = System.Drawing.SystemColors.Control
        Me.Communications.Controls.Add(Me.AcceptBtn)
        Me.Communications.Controls.Add(Me.Label4)
        Me.Communications.Controls.Add(Me.ComboBox1)
        Me.Communications.Location = New System.Drawing.Point(4, 22)
        Me.Communications.Name = "Communications"
        Me.Communications.Padding = New System.Windows.Forms.Padding(3)
        Me.Communications.Size = New System.Drawing.Size(197, 267)
        Me.Communications.TabIndex = 0
        Me.Communications.Text = "Communications"
        '
        'SaveState
        '
        Me.SaveState.BackColor = System.Drawing.SystemColors.Control
        Me.SaveState.Controls.Add(Me.State2FacDfltsBtn)
        Me.SaveState.Controls.Add(Me.Label3)
        Me.SaveState.Controls.Add(Me.SaveStateBtn)
        Me.SaveState.Controls.Add(Me.Label2)
        Me.SaveState.Location = New System.Drawing.Point(4, 22)
        Me.SaveState.Name = "SaveState"
        Me.SaveState.Padding = New System.Windows.Forms.Padding(3)
        Me.SaveState.Size = New System.Drawing.Size(197, 267)
        Me.SaveState.TabIndex = 1
        Me.SaveState.Text = "Save State"
        '
        'State2FacDfltsBtn
        '
        Me.State2FacDfltsBtn.Location = New System.Drawing.Point(63, 210)
        Me.State2FacDfltsBtn.Name = "State2FacDfltsBtn"
        Me.State2FacDfltsBtn.Size = New System.Drawing.Size(75, 23)
        Me.State2FacDfltsBtn.TabIndex = 3
        Me.State2FacDfltsBtn.Text = "Restore"
        Me.State2FacDfltsBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 65)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Clicking the Restore button below will return all picoBench hardware settings to " & _
    "their factory defaults and save them to non-volatile memory in the picoBench har" & _
    "dware."
        '
        'SaveStateBtn
        '
        Me.SaveStateBtn.Location = New System.Drawing.Point(63, 95)
        Me.SaveStateBtn.Name = "SaveStateBtn"
        Me.SaveStateBtn.Size = New System.Drawing.Size(75, 23)
        Me.SaveStateBtn.TabIndex = 1
        Me.SaveStateBtn.Text = "Save"
        Me.SaveStateBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 78)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Clicking the Save button below will write the current settings into non-volatile " & _
    "memory in the picoBench hardware.  These settings will then be used to initializ" & _
    "e the picoBench on the next power up."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Select COM Port"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(31, 85)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(134, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'AcceptBtn
        '
        Me.AcceptBtn.Location = New System.Drawing.Point(61, 162)
        Me.AcceptBtn.Name = "AcceptBtn"
        Me.AcceptBtn.Size = New System.Drawing.Size(75, 23)
        Me.AcceptBtn.TabIndex = 8
        Me.AcceptBtn.Text = "Accept"
        Me.AcceptBtn.UseVisualStyleBackColor = True
        '
        'SetupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(204, 301)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SetupForm"
        Me.Text = "Setup"
        Me.TabControl1.ResumeLayout(False)
        Me.Communications.ResumeLayout(False)
        Me.Communications.PerformLayout()
        Me.SaveState.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Communications As System.Windows.Forms.TabPage
    Friend WithEvents SaveState As System.Windows.Forms.TabPage
    Friend WithEvents State2FacDfltsBtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SaveStateBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AcceptBtn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
