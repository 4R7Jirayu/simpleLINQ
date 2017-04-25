Public Class UpdateSubjForm
    Dim db As New DataClassesStudentDataContext()

    Private Sub UpdateSubjForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showdataSubj()
    End Sub

    Private Sub showdataSubj()
        Dim query_subj = From s1 In db.Subjects
                         Select s1.subj_id, s1.subj_name, s1.unit

        Combo_subj.DataSource = query_subj.ToList
        Combo_subj.ValueMember = "subj_id"
        Combo_subj.DisplayMember = "subj_id"

        ' Txt_subj_name.Text

    End Sub

    Private Sub Combo_subj_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Combo_subj.SelectionChangeCommitted

    End Sub

    Private Sub Combo_subj_SelectedValueChanged(sender As Object, e As EventArgs) Handles Combo_subj.SelectedValueChanged

    End Sub

    Private Sub Combo_subj_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_subj.SelectedIndexChanged

    End Sub

    Private Sub Combo_subj_CursorChanged(sender As Object, e As EventArgs) Handles Combo_subj.CursorChanged

    End Sub

    Private Sub tn_updateSubj_Click(sender As Object, e As EventArgs) Handles tn_updateSubj.Click
        Dim mysubj As New Subject
        mysubj.subj_id = Combo_subj.SelectedValue.ToString()
        mysubj.subj_id = Txt_subj_name.Text
        mysubj.unit = Txt_subj_unit.Text

        db.Subjects.InsertOnSubmit(mysubj)

        Try
            db.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            db.Subjects.DeleteOnSubmit(mysubj)
            Exit Sub
        End Try
        MessageBox.Show("แก้ไขข้อมูลเรียบร้อย")
        Me.Close()
        Main.show_data()
    End Sub
End Class