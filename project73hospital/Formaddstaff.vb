Public Class Formaddstaff
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub StaffsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StaffsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB73DataSet)

    End Sub

    Private Sub Formaddstaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB73DataSet.Staffs' table. You can move, or remove it, as needed.
        Me.StaffsTableAdapter.Fill(Me.DB73DataSet.Staffs)

    End Sub

    Private Sub StaffsComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub
End Class