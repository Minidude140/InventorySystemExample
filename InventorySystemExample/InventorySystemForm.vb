''TODO
'[]Fix File IO
'[]Create parts inventory file
'[]make validation for other controls
'[]add part
'[]Remove part


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

    ''' <summary>
    ''' Checks that all text fields are filled in
    ''' </summary>
    ''' <returns></returns>
    Private Function ValidateUserInputs(Optional ByRef errormessage As String = "") As Boolean
        Dim isValid As Boolean = True
        Dim errrorMessage As String


        For Each Item As TextBox In RecordInfoGroupBox.Controls.OfType(Of TextBox)
            If isValid = True Then
                Item.Focus()
            End If
            If Item.Text = "" Then
                isValid = False
                errrorMessage &= Replace($"{Item.Name.ToString} is required{vbCrLf}", "TextBox", "")
            End If
        Next

        'MsgBox(errrorMessage)
        Return isValid
    End Function


    'Event Handlers
    Private Sub InventorySystemForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadInventoryFile()
        SetDefaults()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        ValidateUserInputs()
    End Sub
End Class
