''TODO
'[]Fix File IO
'[]Create parts inventory file
'[]make validation for other controls
'[]add part
'[]Remove part


Public Class InventorySystemForm

    Private inventoryItems As New List(Of String)
    Private fileName As String = "..\..\partsInventory.txt"

    'Custom Methods
    Sub SetDefaults()

    End Sub

    Private Sub LoadInventoryFile()
        'Dim fileName As String = "..\..\partsInventory.txt"
        Dim fileNumber As Integer = FreeFile()
        Dim currentField As String = ""
        Dim currentRecord As String = ""
        Try
            FileOpen(fileNumber, Me.fileName, OpenMode.Input)
            Do Until EOF(fileNumber)
                For i = 0 To 6
                    Input(fileNumber, currentField)
                    currentRecord &= currentField & ", "
                Next
                Me.inventoryItems.Add(currentRecord)
                currentRecord = ""
            Loop

        Catch ioException As IO.IOException
            With OpenFileDialog
                .Reset()
                .InitialDirectory = "..\..\"
                .FileName = ""
                .DefaultExt = ".txt"
                .AddExtension = True
                .Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
                .ShowDialog()
                'TODO check if user clicks ok or cancel
                Me.fileName = fileName
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
        If ValidateUserInputs() Then
            'add record
            inventoryItems.Add($"{"12345"}, {DescriptionTextBox.Text}, {PartNumberTextBox.Text}, {LocationTextBox.Text}, {VendorTextBox.Text}, {ManufactureTextBox.Text}, {DataSheetTextBox.Text}")
            'TODO add record to file
            'backup file first use of the day
            'mark with new file or temp file
        End If
    End Sub
End Class
