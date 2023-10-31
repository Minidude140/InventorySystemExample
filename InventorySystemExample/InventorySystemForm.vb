Public Class InventorySystemForm
    'Custom Methods
    Sub SetDefaults()

    End Sub

    Private Sub LoadInventoryFile()
        Dim fileName As String = "partsInventory.txt"
        Dim fileNumber As Integer = FreeFile()
        Try
            FileOpen(fileNumber, fileName, OpenMode.Input)
        Catch ioException As IO.IOException
            With OpenFileDialog
                .Reset()
                .InitialDirectory = "..\"
                .FileName = ""
                .DefaultExt = ".txt"
                .AddExtension = True
                .Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
                .ShowDialog()
            End With
        Catch ex As Exception

        End Try
    End Sub


    'Event Handlers
    Private Sub InventorySystemForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadInventoryFile()
        SetDefaults()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
