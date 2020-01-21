<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EscapeRoom
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.West = New System.Windows.Forms.TabPage()
        Me.W_N = New System.Windows.Forms.Button()
        Me.W_S = New System.Windows.Forms.Button()
        Me.LblSafe = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.South = New System.Windows.Forms.TabPage()
        Me.S_W = New System.Windows.Forms.Button()
        Me.S_E = New System.Windows.Forms.Button()
        Me.LblWindow = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Window = New System.Windows.Forms.TabPage()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.East = New System.Windows.Forms.TabPage()
        Me.LblDwrBottom = New System.Windows.Forms.Label()
        Me.LblDwrTop = New System.Windows.Forms.Label()
        Me.E_S = New System.Windows.Forms.Button()
        Me.E_N = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.North = New System.Windows.Forms.TabPage()
        Me.LblDoor = New System.Windows.Forms.Label()
        Me.N_E = New System.Windows.Forms.Button()
        Me.N_W = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tmrSeconds = New System.Windows.Forms.Timer(Me.components)
        Me.timer = New System.Windows.Forms.Label()
        Me.West.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.South.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Window.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.East.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.North.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'West
        '
        Me.West.Controls.Add(Me.W_N)
        Me.West.Controls.Add(Me.W_S)
        Me.West.Controls.Add(Me.LblSafe)
        Me.West.Controls.Add(Me.PictureBox5)
        Me.West.Location = New System.Drawing.Point(4, 22)
        Me.West.Name = "West"
        Me.West.Padding = New System.Windows.Forms.Padding(3)
        Me.West.Size = New System.Drawing.Size(802, 424)
        Me.West.TabIndex = 4
        Me.West.Text = "West"
        Me.West.UseVisualStyleBackColor = True
        '
        'W_N
        '
        Me.W_N.Location = New System.Drawing.Point(776, 189)
        Me.W_N.Name = "W_N"
        Me.W_N.Size = New System.Drawing.Size(17, 46)
        Me.W_N.TabIndex = 3
        Me.W_N.Text = ">"
        Me.W_N.UseVisualStyleBackColor = True
        '
        'W_S
        '
        Me.W_S.Location = New System.Drawing.Point(9, 189)
        Me.W_S.Name = "W_S"
        Me.W_S.Size = New System.Drawing.Size(17, 46)
        Me.W_S.TabIndex = 2
        Me.W_S.Text = "<"
        Me.W_S.UseVisualStyleBackColor = True
        '
        'LblSafe
        '
        Me.LblSafe.Image = Global.slave_labor.My.Resources.Resources.safe1
        Me.LblSafe.Location = New System.Drawing.Point(292, 231)
        Me.LblSafe.Name = "LblSafe"
        Me.LblSafe.Size = New System.Drawing.Size(183, 103)
        Me.LblSafe.TabIndex = 9
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.slave_labor.My.Resources.Resources.template
        Me.PictureBox5.Location = New System.Drawing.Point(-4, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(806, 421)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        '
        'South
        '
        Me.South.Controls.Add(Me.S_W)
        Me.South.Controls.Add(Me.S_E)
        Me.South.Controls.Add(Me.LblWindow)
        Me.South.Controls.Add(Me.PictureBox6)
        Me.South.Location = New System.Drawing.Point(4, 22)
        Me.South.Name = "South"
        Me.South.Padding = New System.Windows.Forms.Padding(3)
        Me.South.Size = New System.Drawing.Size(802, 424)
        Me.South.TabIndex = 3
        Me.South.Text = "South"
        Me.South.UseVisualStyleBackColor = True
        '
        'S_W
        '
        Me.S_W.Location = New System.Drawing.Point(776, 189)
        Me.S_W.Name = "S_W"
        Me.S_W.Size = New System.Drawing.Size(17, 46)
        Me.S_W.TabIndex = 3
        Me.S_W.Text = ">"
        Me.S_W.UseVisualStyleBackColor = True
        '
        'S_E
        '
        Me.S_E.Location = New System.Drawing.Point(9, 189)
        Me.S_E.Name = "S_E"
        Me.S_E.Size = New System.Drawing.Size(17, 46)
        Me.S_E.TabIndex = 2
        Me.S_E.Text = "<"
        Me.S_E.UseVisualStyleBackColor = True
        '
        'LblWindow
        '
        Me.LblWindow.Image = Global.slave_labor.My.Resources.Resources.window1
        Me.LblWindow.Location = New System.Drawing.Point(289, 38)
        Me.LblWindow.Name = "LblWindow"
        Me.LblWindow.Size = New System.Drawing.Size(207, 236)
        Me.LblWindow.TabIndex = 9
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.slave_labor.My.Resources.Resources.template
        Me.PictureBox6.Location = New System.Drawing.Point(-4, -3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(802, 421)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 8
        Me.PictureBox6.TabStop = False
        '
        'Window
        '
        Me.Window.Controls.Add(Me.btnBack)
        Me.Window.Controls.Add(Me.PictureBox3)
        Me.Window.Location = New System.Drawing.Point(4, 22)
        Me.Window.Name = "Window"
        Me.Window.Padding = New System.Windows.Forms.Padding(3)
        Me.Window.Size = New System.Drawing.Size(802, 424)
        Me.Window.TabIndex = 2
        Me.Window.Text = "Window"
        Me.Window.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(8, 359)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(146, 48)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.slave_labor.My.Resources.Resources.door__2_
        Me.PictureBox3.Location = New System.Drawing.Point(3, -2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(802, 421)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'East
        '
        Me.East.Controls.Add(Me.LblDwrBottom)
        Me.East.Controls.Add(Me.LblDwrTop)
        Me.East.Controls.Add(Me.E_S)
        Me.East.Controls.Add(Me.E_N)
        Me.East.Controls.Add(Me.PictureBox2)
        Me.East.Location = New System.Drawing.Point(4, 22)
        Me.East.Name = "East"
        Me.East.Padding = New System.Windows.Forms.Padding(3)
        Me.East.Size = New System.Drawing.Size(802, 424)
        Me.East.TabIndex = 1
        Me.East.Text = "East"
        Me.East.UseVisualStyleBackColor = True
        '
        'LblDwrBottom
        '
        Me.LblDwrBottom.Image = Global.slave_labor.My.Resources.Resources.dresser1
        Me.LblDwrBottom.Location = New System.Drawing.Point(289, 293)
        Me.LblDwrBottom.Name = "LblDwrBottom"
        Me.LblDwrBottom.Size = New System.Drawing.Size(204, 20)
        Me.LblDwrBottom.TabIndex = 6
        '
        'LblDwrTop
        '
        Me.LblDwrTop.Image = Global.slave_labor.My.Resources.Resources.dresser1
        Me.LblDwrTop.Location = New System.Drawing.Point(289, 273)
        Me.LblDwrTop.Name = "LblDwrTop"
        Me.LblDwrTop.Size = New System.Drawing.Size(204, 20)
        Me.LblDwrTop.TabIndex = 5
        '
        'E_S
        '
        Me.E_S.Location = New System.Drawing.Point(776, 189)
        Me.E_S.Name = "E_S"
        Me.E_S.Size = New System.Drawing.Size(17, 46)
        Me.E_S.TabIndex = 3
        Me.E_S.Text = ">"
        Me.E_S.UseVisualStyleBackColor = True
        '
        'E_N
        '
        Me.E_N.Location = New System.Drawing.Point(9, 189)
        Me.E_N.Name = "E_N"
        Me.E_N.Size = New System.Drawing.Size(17, 46)
        Me.E_N.TabIndex = 2
        Me.E_N.Text = "<"
        Me.E_N.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.slave_labor.My.Resources.Resources.dresser
        Me.PictureBox2.Location = New System.Drawing.Point(0, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(802, 421)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'North
        '
        Me.North.Controls.Add(Me.LblDoor)
        Me.North.Controls.Add(Me.N_E)
        Me.North.Controls.Add(Me.N_W)
        Me.North.Controls.Add(Me.PictureBox1)
        Me.North.Location = New System.Drawing.Point(4, 22)
        Me.North.Name = "North"
        Me.North.Padding = New System.Windows.Forms.Padding(3)
        Me.North.Size = New System.Drawing.Size(802, 424)
        Me.North.TabIndex = 0
        Me.North.Text = "North"
        Me.North.UseVisualStyleBackColor = True
        '
        'LblDoor
        '
        Me.LblDoor.Image = Global.slave_labor.My.Resources.Resources.door1
        Me.LblDoor.Location = New System.Drawing.Point(315, 105)
        Me.LblDoor.Name = "LblDoor"
        Me.LblDoor.Size = New System.Drawing.Size(167, 216)
        Me.LblDoor.TabIndex = 2
        '
        'N_E
        '
        Me.N_E.Location = New System.Drawing.Point(775, 187)
        Me.N_E.Name = "N_E"
        Me.N_E.Size = New System.Drawing.Size(17, 46)
        Me.N_E.TabIndex = 1
        Me.N_E.Text = ">"
        Me.N_E.UseVisualStyleBackColor = True
        '
        'N_W
        '
        Me.N_W.Location = New System.Drawing.Point(8, 187)
        Me.N_W.Name = "N_W"
        Me.N_W.Size = New System.Drawing.Size(17, 46)
        Me.N_W.TabIndex = 0
        Me.N_W.Text = "<"
        Me.N_W.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.slave_labor.My.Resources.Resources.template
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(802, 421)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.North)
        Me.TabControl1.Controls.Add(Me.East)
        Me.TabControl1.Controls.Add(Me.Window)
        Me.TabControl1.Controls.Add(Me.South)
        Me.TabControl1.Controls.Add(Me.West)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(810, 450)
        Me.TabControl1.TabIndex = 0
        '
        'tmrSeconds
        '
        Me.tmrSeconds.Interval = 1000
        '
        'timer
        '
        Me.timer.AutoSize = True
        Me.timer.Location = New System.Drawing.Point(512, 4)
        Me.timer.Name = "timer"
        Me.timer.Size = New System.Drawing.Size(28, 13)
        Me.timer.TabIndex = 4
        Me.timer.Text = "0:00"
        '
        'EscapeRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 441)
        Me.Controls.Add(Me.timer)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "EscapeRoom"
        Me.Text = "Escape Room"
        Me.West.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.South.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Window.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.East.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.North.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents West As TabPage
    Friend WithEvents South As TabPage
    Friend WithEvents Window As TabPage
    Friend WithEvents East As TabPage
    Friend WithEvents North As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents W_N As Button
    Friend WithEvents W_S As Button
    Friend WithEvents S_W As Button
    Friend WithEvents S_E As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents E_S As Button
    Friend WithEvents E_N As Button
    Friend WithEvents N_E As Button
    Friend WithEvents N_W As Button
    Friend WithEvents tmrSeconds As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LblDoor As Label
    Friend WithEvents LblDwrTop As Label
    Friend WithEvents LblDwrBottom As Label
    Friend WithEvents LblSafe As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents LblWindow As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents timer As Label
End Class
