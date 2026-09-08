<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmmain
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Lbl_Runtime = New System.Windows.Forms.Label()
        Me.Lbl_break = New System.Windows.Forms.Label()
        Me.Lbl_runtime_stopwatch = New System.Windows.Forms.Label()
        Me.Lbl_break_stopwatch = New System.Windows.Forms.Label()
        Me.Lbl_status = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(378, 37)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(522, 326)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(18, 394)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(882, 326)
        Me.TextBox2.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(924, 37)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1197, 680)
        Me.DataGridView1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(924, 18)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Lbl_Runtime
        '
        Me.Lbl_Runtime.AutoSize = True
        Me.Lbl_Runtime.Location = New System.Drawing.Point(26, 37)
        Me.Lbl_Runtime.Name = "Lbl_Runtime"
        Me.Lbl_Runtime.Size = New System.Drawing.Size(73, 20)
        Me.Lbl_Runtime.TabIndex = 4
        Me.Lbl_Runtime.Text = "Runtime:"
        '
        'Lbl_break
        '
        Me.Lbl_break.AutoSize = True
        Me.Lbl_break.Location = New System.Drawing.Point(26, 69)
        Me.Lbl_break.Name = "Lbl_break"
        Me.Lbl_break.Size = New System.Drawing.Size(55, 20)
        Me.Lbl_break.TabIndex = 5
        Me.Lbl_break.Text = "Break:"
        '
        'Lbl_runtime_stopwatch
        '
        Me.Lbl_runtime_stopwatch.AutoSize = True
        Me.Lbl_runtime_stopwatch.Location = New System.Drawing.Point(133, 37)
        Me.Lbl_runtime_stopwatch.Name = "Lbl_runtime_stopwatch"
        Me.Lbl_runtime_stopwatch.Size = New System.Drawing.Size(71, 20)
        Me.Lbl_runtime_stopwatch.TabIndex = 6
        Me.Lbl_runtime_stopwatch.Text = "00:00:00"
        '
        'Lbl_break_stopwatch
        '
        Me.Lbl_break_stopwatch.AutoSize = True
        Me.Lbl_break_stopwatch.Location = New System.Drawing.Point(133, 69)
        Me.Lbl_break_stopwatch.Name = "Lbl_break_stopwatch"
        Me.Lbl_break_stopwatch.Size = New System.Drawing.Size(71, 20)
        Me.Lbl_break_stopwatch.TabIndex = 7
        Me.Lbl_break_stopwatch.Text = "00:00:00"
        '
        'Lbl_status
        '
        Me.Lbl_status.AutoSize = True
        Me.Lbl_status.Location = New System.Drawing.Point(133, 99)
        Me.Lbl_status.Name = "Lbl_status"
        Me.Lbl_status.Size = New System.Drawing.Size(56, 20)
        Me.Lbl_status.TabIndex = 8
        Me.Lbl_status.Text = "Status"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2139, 735)
        Me.Controls.Add(Me.Lbl_status)
        Me.Controls.Add(Me.Lbl_break_stopwatch)
        Me.Controls.Add(Me.Lbl_runtime_stopwatch)
        Me.Controls.Add(Me.Lbl_break)
        Me.Controls.Add(Me.Lbl_Runtime)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmmain"
        Me.Text = "frmmain"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Lbl_Runtime As Label
    Friend WithEvents Lbl_break As Label
    Friend WithEvents Lbl_runtime_stopwatch As Label
    Friend WithEvents Lbl_break_stopwatch As Label
    Friend WithEvents Lbl_status As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
