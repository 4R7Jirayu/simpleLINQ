Public Class Main
    Dim curRow As Integer = 0
    Dim db As New DataClassesStudentDataContext
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query = From s1 In db.Students Select s1.std_id, s1.std_name
        Combo_name.DataSource = query.ToList
        Combo_name.ValueMember = "std_id"
        Combo_name.DisplayMember = "std_name"
        show_data()
    End Sub
    Public Sub show_data()
        Dim db As New DataClassesStudentDataContext()
        Dim query = From e1 In db.Enrolls Where e1.std_id = Combo_name.SelectedValue.ToString()
                    Select e1.subj_id, e1.Subject.subj_name, e1.term, e1.academic_year
        DataGridViewEnroll.DataSource = query.ToList

        DataGridViewEnroll.Columns(0).HeaderText = "รหัสวิชา"
        DataGridViewEnroll.Columns(0).Width = 70
        DataGridViewEnroll.Columns(1).HeaderText = "ชื่อวิชา"
        DataGridViewEnroll.Columns(1).Width = 170
        DataGridViewEnroll.Columns(2).HeaderText = "เทอม"
        DataGridViewEnroll.Columns(2).Width = 70
        DataGridViewEnroll.Columns(3).HeaderText = "ปีการศึกษา"
        DataGridViewEnroll.Columns(3).Width = 100

        curRow = 0
    End Sub

    Private Sub Btn_Show_Click(sender As Object, e As EventArgs) Handles Btn_Show.Click
        show_data()
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        Dim enroll_table As Data.Linq.Table(Of Enroll) = db.GetTable(Of Enroll)()
        Dim query = From e1 In db.Enrolls
                    Where e1.std_id = Combo_name.SelectedValue.ToString() And
                        e1.subj_id = DataGridViewEnroll.Rows(curRow).Cells(0).Value.ToString() And
                        e1.term = DataGridViewEnroll.Rows(curRow).Cells(2).Value.ToString() And
                        e1.academic_year = DataGridViewEnroll.Rows(curRow).Cells(3).Value.ToString()
                    Select e1
        Dim dlgResult As DialogResult
        dlgResult = MessageBox.Show("ต้องการลบข้อมูลหรือไม่", "แจ้งข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dlgResult = Windows.Forms.DialogResult.Yes Then
            Dim EnrollDelete As Enroll = query.First()
            enroll_table.DeleteOnSubmit(EnrollDelete)
            Try
                db.SubmitChanges()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
        End If
        show_data()
        MessageBox.Show("ลบข้อมูลเรียบร้อย")
    End Sub

    Private Sub DataGridViewEnroll_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewEnroll.CellClick
        If e.RowIndex > -1 Then
            curRow = e.RowIndex
        End If
    End Sub

    Private Sub Btn_Insert_Click(sender As Object, e As EventArgs) Handles Btn_Insert.Click
        InsertForm.Show()
    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        UpdateSubjForm.Show()
    End Sub
End Class
