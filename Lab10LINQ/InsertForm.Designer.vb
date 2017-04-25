<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertForm
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
        Me.Combo_name = New System.Windows.Forms.ComboBox()
        Me.Combo_Subj = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown_term = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_year = New System.Windows.Forms.NumericUpDown()
        Me.Btn_Insert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown_term, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_year, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Combo_name
        '
        Me.Combo_name.FormattingEnabled = True
        Me.Combo_name.Location = New System.Drawing.Point(112, 12)
        Me.Combo_name.Name = "Combo_name"
        Me.Combo_name.Size = New System.Drawing.Size(211, 21)
        Me.Combo_name.TabIndex = 0
        '
        'Combo_Subj
        '
        Me.Combo_Subj.FormattingEnabled = True
        Me.Combo_Subj.Location = New System.Drawing.Point(112, 39)
        Me.Combo_Subj.Name = "Combo_Subj"
        Me.Combo_Subj.Size = New System.Drawing.Size(211, 21)
        Me.Combo_Subj.TabIndex = 1
        '
        'NumericUpDown_term
        '
        Me.NumericUpDown_term.Location = New System.Drawing.Point(112, 66)
        Me.NumericUpDown_term.Name = "NumericUpDown_term"
        Me.NumericUpDown_term.Size = New System.Drawing.Size(72, 20)
        Me.NumericUpDown_term.TabIndex = 2
        '
        'NumericUpDown_year
        '
        Me.NumericUpDown_year.Location = New System.Drawing.Point(112, 92)
        Me.NumericUpDown_year.Name = "NumericUpDown_year"
        Me.NumericUpDown_year.Size = New System.Drawing.Size(72, 20)
        Me.NumericUpDown_year.TabIndex = 3
        '
        'Btn_Insert
        '
        Me.Btn_Insert.Location = New System.Drawing.Point(96, 118)
        Me.Btn_Insert.Name = "Btn_Insert"
        Me.Btn_Insert.Size = New System.Drawing.Size(164, 23)
        Me.Btn_Insert.TabIndex = 4
        Me.Btn_Insert.Text = "เพิ่มข้อมูลการลงทะเบียน"
        Me.Btn_Insert.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ชื่อนักศึกษา"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "รายวิชา"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "เทอม"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ปีการศึกษา"
        '
        'InsertForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 165)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Insert)
        Me.Controls.Add(Me.NumericUpDown_year)
        Me.Controls.Add(Me.NumericUpDown_term)
        Me.Controls.Add(Me.Combo_Subj)
        Me.Controls.Add(Me.Combo_name)
        Me.Name = "InsertForm"
        Me.Text = "InsertForm"
        CType(Me.NumericUpDown_term, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_year, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Combo_name As ComboBox
    Friend WithEvents Combo_Subj As ComboBox
    Friend WithEvents NumericUpDown_term As NumericUpDown
    Friend WithEvents NumericUpDown_year As NumericUpDown
    Friend WithEvents Btn_Insert As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
