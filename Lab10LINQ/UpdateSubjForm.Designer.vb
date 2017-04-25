<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateSubjForm
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
        Me.Combo_subj = New System.Windows.Forms.ComboBox()
        Me.Txt_subj_name = New System.Windows.Forms.TextBox()
        Me.Txt_subj_unit = New System.Windows.Forms.TextBox()
        Me.tn_updateSubj = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Combo_subj
        '
        Me.Combo_subj.FormattingEnabled = True
        Me.Combo_subj.Location = New System.Drawing.Point(101, 12)
        Me.Combo_subj.Name = "Combo_subj"
        Me.Combo_subj.Size = New System.Drawing.Size(160, 21)
        Me.Combo_subj.TabIndex = 0
        '
        'Txt_subj_name
        '
        Me.Txt_subj_name.Location = New System.Drawing.Point(101, 39)
        Me.Txt_subj_name.Name = "Txt_subj_name"
        Me.Txt_subj_name.Size = New System.Drawing.Size(160, 20)
        Me.Txt_subj_name.TabIndex = 1
        '
        'Txt_subj_unit
        '
        Me.Txt_subj_unit.Location = New System.Drawing.Point(101, 65)
        Me.Txt_subj_unit.Name = "Txt_subj_unit"
        Me.Txt_subj_unit.Size = New System.Drawing.Size(160, 20)
        Me.Txt_subj_unit.TabIndex = 2
        '
        'tn_updateSubj
        '
        Me.tn_updateSubj.Location = New System.Drawing.Point(71, 105)
        Me.tn_updateSubj.Name = "tn_updateSubj"
        Me.tn_updateSubj.Size = New System.Drawing.Size(141, 23)
        Me.tn_updateSubj.TabIndex = 3
        Me.tn_updateSubj.Text = "แก้ไขรายวิชา"
        Me.tn_updateSubj.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "รหัสรายวิชา"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ชื่อวิชา"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "หน่วยกิต"
        '
        'UpdateSubjForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 158)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tn_updateSubj)
        Me.Controls.Add(Me.Txt_subj_unit)
        Me.Controls.Add(Me.Txt_subj_name)
        Me.Controls.Add(Me.Combo_subj)
        Me.Name = "UpdateSubjForm"
        Me.Text = "UpdateSubjForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Combo_subj As ComboBox
    Friend WithEvents Txt_subj_name As TextBox
    Friend WithEvents Txt_subj_unit As TextBox
    Friend WithEvents tn_updateSubj As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
