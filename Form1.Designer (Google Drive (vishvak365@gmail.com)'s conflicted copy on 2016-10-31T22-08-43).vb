<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblScoreAway = New System.Windows.Forms.Label()
        Me.lblScoreHome = New System.Windows.Forms.Label()
        Me.lblQuarter = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(420, 317)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblScoreAway
        '
        Me.lblScoreAway.AutoSize = True
        Me.lblScoreAway.BackColor = System.Drawing.Color.Black
        Me.lblScoreAway.Font = New System.Drawing.Font("Impact", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreAway.ForeColor = System.Drawing.Color.White
        Me.lblScoreAway.Location = New System.Drawing.Point(293, 72)
        Me.lblScoreAway.Name = "lblScoreAway"
        Me.lblScoreAway.Size = New System.Drawing.Size(42, 48)
        Me.lblScoreAway.TabIndex = 3
        Me.lblScoreAway.Text = "0"
        '
        'lblScoreHome
        '
        Me.lblScoreHome.AutoSize = True
        Me.lblScoreHome.BackColor = System.Drawing.Color.Black
        Me.lblScoreHome.Font = New System.Drawing.Font("Impact", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreHome.ForeColor = System.Drawing.Color.White
        Me.lblScoreHome.Location = New System.Drawing.Point(293, 144)
        Me.lblScoreHome.Name = "lblScoreHome"
        Me.lblScoreHome.Size = New System.Drawing.Size(42, 48)
        Me.lblScoreHome.TabIndex = 4
        Me.lblScoreHome.Text = "0"
        '
        'lblQuarter
        '
        Me.lblQuarter.AutoSize = True
        Me.lblQuarter.BackColor = System.Drawing.Color.Black
        Me.lblQuarter.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuarter.ForeColor = System.Drawing.Color.White
        Me.lblQuarter.Location = New System.Drawing.Point(181, 211)
        Me.lblQuarter.Name = "lblQuarter"
        Me.lblQuarter.Size = New System.Drawing.Size(81, 60)
        Me.lblQuarter.TabIndex = 5
        Me.lblQuarter.Text = "1st"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(466, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 43)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "+1 Home"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(466, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 43)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "+1 Away"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(623, 41)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(151, 43)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "-1 Away"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(623, 90)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(151, 43)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "-1 Away"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(466, 139)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(77, 43)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "1st"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(697, 139)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(77, 43)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "2nd"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(549, 139)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(142, 43)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "Clr All"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(463, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "© Vishvak Seenichamy Venkatesan "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(463, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Barron Collier Sports Network live"
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(466, 197)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(148, 48)
        Me.Button8.TabIndex = 19
        Me.Button8.Text = "Over Time"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(623, 197)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(148, 48)
        Me.Button9.TabIndex = 20
        Me.Button9.Text = "Shoot Out"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(787, 341)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.lblQuarter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblScoreHome)
        Me.Controls.Add(Me.lblScoreAway)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000, 1000)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(200, 200)
        Me.Name = "Form1"
        Me.Text = "Soccer Score Bug"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblScoreAway As Label
    Friend WithEvents lblScoreHome As Label
    Friend WithEvents lblQuarter As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Timer1 As Timer
End Class
