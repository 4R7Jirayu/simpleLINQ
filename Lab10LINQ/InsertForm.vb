Public Class InsertForm
    Dim db As New DataClassesStudentDataContext()
    Private Sub InsertForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query_std = From std1 In db.Students
                        Select std1.std_id, std1.std_name
        Combo_name.DataSource = query_std.ToList
        Combo_name.ValueMember = "std_id"
        Combo_name.DisplayMember = "std_name"

        Dim query_subj = From s1 In db.Subjects
                         Select s1.subj_id, s1.subj_name
        Combo_Subj.DataSource = query_subj.ToList
        Combo_Subj.ValueMember = "subj_id"
        Combo_Subj.DisplayMember = "subj_name"

        NumericUpDown_term.Minimum = 1
        NumericUpDown_term.Maximum = 2

        NumericUpDown_year.Minimum = 2559
        NumericUpDown_year.Maximum = 2570
    End Sub

    Private Sub Btn_Insert_Click(sender As Object, e As EventArgs) Handles Btn_Insert.Click
        Dim myEroll As New Enroll
        myEroll.std_id = Combo_name.SelectedValue.ToString()
        myEroll.subj_id = Combo_Subj.SelectedValue.ToString()
        myEroll.term = NumericUpDown_term.Value
        myEroll.academic_year = NumericUpDown_year.Value

        db.Enrolls.InsertOnSubmit(myEroll)

        Try
            db.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            db.Enrolls.DeleteOnSubmit(myEroll)
            Exit Sub
        End Try
        MessageBox.Show("เพิ่มข้อมูลเรียบร้อย")
        Me.Close()
        Main.show_data()
    End Sub

    Private Sub Combo_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_name.SelectedIndexChanged

    End Sub
End Class