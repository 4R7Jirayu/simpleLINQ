<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.Btn_Show = New System.Windows.Forms.Button()
        Me.Combo_name = New System.Windows.Forms.ComboBox()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.Btn_Insert = New System.Windows.Forms.Button()
        Me.Btn_Update = New System.Windows.Forms.Button()
        Me.DataGridViewEnroll = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewEnroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Show
        '
        Me.Btn_Show.Location = New System.Drawing.Point(326, 19)
        Me.Btn_Show.Name = "Btn_Show"
        Me.Btn_Show.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Show.TabIndex = 0
        Me.Btn_Show.Text = "แสดง"
        Me.Btn_Show.UseVisualStyleBackColor = True
        '
        'Combo_name
        '
        Me.Combo_name.FormattingEnabled = True
        Me.Combo_name.Location = New System.Drawing.Point(162, 19)
        Me.Combo_name.Name = "Combo_name"
        Me.Combo_name.Size = New System.Drawing.Size(139, 21)
        Me.Combo_name.TabIndex = 1
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Location = New System.Drawing.Point(24, 297)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(132, 23)
        Me.Btn_Delete.TabIndex = 2
        Me.Btn_Delete.Text = "ลบข้อมูลลงทะเบียน"
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'Btn_Insert
        '
        Me.Btn_Insert.Location = New System.Drawing.Point(162, 297)
        Me.Btn_Insert.Name = "Btn_Insert"
        Me.Btn_Insert.Size = New System.Drawing.Size(132, 23)
        Me.Btn_Insert.TabIndex = 3
        Me.Btn_Insert.Text = "เพิ่มข้อมูลลงทะเบียน"
        Me.Btn_Insert.UseVisualStyleBackColor = True
        '
        'Btn_Update
        '
        Me.Btn_Update.Location = New System.Drawing.Point(299, 297)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(132, 23)
        Me.Btn_Update.TabIndex = 4
        Me.Btn_Update.Text = " แก้ไขรายวิชา"
        Me.Btn_Update.UseVisualStyleBackColor = True
        '
        'DataGridViewEnroll
        '
        Me.DataGridViewEnroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewEnroll.Location = New System.Drawing.Point(12, 48)
        Me.DataGridViewEnroll.Name = "DataGridViewEnroll"
        Me.DataGridViewEnroll.Size = New System.Drawing.Size(463, 243)
        Me.DataGridViewEnroll.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ชื่อนักศึกษา"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 332)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewEnroll)
        Me.Controls.Add(Me.Btn_Update)
        Me.Controls.Add(Me.Btn_Insert)
        Me.Controls.Add(Me.Btn_Delete)
        Me.Controls.Add(Me.Combo_name)
        Me.Controls.Add(Me.Btn_Show)
        Me.Name = "Main"
        Me.Text = "Form1"
        CType(Me.DataGridViewEnroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Show As Button
    Friend WithEvents Combo_name As ComboBox
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents Btn_Insert As Button
    Friend WithEvents Btn_Update As Button
    Friend WithEvents DataGridViewEnroll As DataGridView
    Friend WithEvents Label1 As Label
End Class
