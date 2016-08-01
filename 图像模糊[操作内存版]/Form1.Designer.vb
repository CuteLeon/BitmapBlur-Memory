<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Test4 = New System.Windows.Forms.Button()
        Me.Test3 = New System.Windows.Forms.Button()
        Me.Test2 = New System.Windows.Forms.Button()
        Me.Test1 = New System.Windows.Forms.Button()
        Me.SetPixel = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SetPixel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(540, 360)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Test4
        '
        Me.Test4.ForeColor = System.Drawing.Color.Red
        Me.Test4.Image = CType(resources.GetObject("Test4.Image"), System.Drawing.Image)
        Me.Test4.Location = New System.Drawing.Point(547, 129)
        Me.Test4.Name = "Test4"
        Me.Test4.Size = New System.Drawing.Size(75, 33)
        Me.Test4.TabIndex = 13
        Me.Test4.Text = "Test-4"
        Me.Test4.UseVisualStyleBackColor = True
        '
        'Test3
        '
        Me.Test3.ForeColor = System.Drawing.Color.Red
        Me.Test3.Image = CType(resources.GetObject("Test3.Image"), System.Drawing.Image)
        Me.Test3.Location = New System.Drawing.Point(547, 90)
        Me.Test3.Name = "Test3"
        Me.Test3.Size = New System.Drawing.Size(75, 33)
        Me.Test3.TabIndex = 12
        Me.Test3.Text = "Test-3"
        Me.Test3.UseVisualStyleBackColor = True
        '
        'Test2
        '
        Me.Test2.ForeColor = System.Drawing.Color.Red
        Me.Test2.Image = CType(resources.GetObject("Test2.Image"), System.Drawing.Image)
        Me.Test2.Location = New System.Drawing.Point(547, 51)
        Me.Test2.Name = "Test2"
        Me.Test2.Size = New System.Drawing.Size(75, 33)
        Me.Test2.TabIndex = 11
        Me.Test2.Text = "Test-2"
        Me.Test2.UseVisualStyleBackColor = True
        '
        'Test1
        '
        Me.Test1.ForeColor = System.Drawing.Color.Red
        Me.Test1.Image = CType(resources.GetObject("Test1.Image"), System.Drawing.Image)
        Me.Test1.Location = New System.Drawing.Point(547, 12)
        Me.Test1.Name = "Test1"
        Me.Test1.Size = New System.Drawing.Size(75, 33)
        Me.Test1.TabIndex = 10
        Me.Test1.Text = "Test-1"
        Me.Test1.UseVisualStyleBackColor = True
        '
        'SetPixel
        '
        Me.SetPixel.Location = New System.Drawing.Point(549, 195)
        Me.SetPixel.Name = "SetPixel"
        Me.SetPixel.Size = New System.Drawing.Size(58, 21)
        Me.SetPixel.TabIndex = 16
        Me.SetPixel.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(549, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "模糊半径："
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(547, 242)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 300
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 362)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SetPixel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Test4)
        Me.Controls.Add(Me.Test3)
        Me.Controls.Add(Me.Test2)
        Me.Controls.Add(Me.Test1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "图像模糊[操作内存版]"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SetPixel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Test4 As Button
    Friend WithEvents Test3 As Button
    Friend WithEvents Test2 As Button
    Friend WithEvents Test1 As Button
    Friend WithEvents SetPixel As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
End Class
