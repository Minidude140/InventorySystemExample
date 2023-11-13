Public Class AboutForm
    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        InventorySystemForm.Show()
        Me.Close()
    End Sub
End Class