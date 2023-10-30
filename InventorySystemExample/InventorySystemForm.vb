Public Class InventorySystemForm
    'Custom Methods
    Sub SetDefaults()

    End Sub


    'Event Handlers
    Private Sub InventorySystemForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
