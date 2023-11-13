''TODO
'[]Fix File IO
'[]Create parts inventory file
'[]make validation for other controls
'[]add part
'[]Remove part


Public Class InventorySystemForm

    Private inventoryItems As New List(Of String())
    Private fileName As String = "..\..\partsInventory.txt"

    'Custom Methods
    ''' <summary>
    ''' Sets up the default values
    ''' </summary>
    Sub SetDefaults()

    End Sub

    ''' <summary>
    ''' Loads the parts inventory file. If file is not present dialog box opens
    ''' </summary>
    Private Sub LoadInventoryFile()
        'Dim fileName As String = "..\..\partsInventory.txt"
        Dim fileNumber As Integer = FreeFile()
        Dim currentField As String = ""
        Dim currentRecord() As String
        Try
            FileOpen(fileNumber, Me.fileName, OpenMode.Input)
            Do Until EOF(fileNumber)
                'For i = 0 To 6
                '    Input(fileNumber, currentField)
                '    currentRecord &= currentField & ", "
                'Next
                'currentRecord = Split(LineInput(fileNumber), ",")
                currentRecord = Split(Replace(LineInput(fileNumber), Chr(34), ""), ",")
                Me.inventoryItems.Add(currentRecord)
                'currentRecord = ""
            Loop
            FileClose(fileNumber)

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

        If errormessage <> "" Then
            MsgBox(errrorMessage)
        End If
        Return isValid
    End Function

    Sub AppendRecordToFile(newRecord() As String, fileName As String)
        Dim fileNumber As Integer = FreeFile()
        'Dim temp() As String
        'temp = Split(newRecord, ",")

        'AppendRecordToFile(vbCrLf, "..\..\temp.txt")
        Try
            FileOpen(fileNumber, fileName, OpenMode.Append)
            'iterate through the record array
            'Append each field to the file
            'For Each field In temp
            '    Write(fileNumber, field)
            'Next
            WriteLine(fileNumber)
            Write(fileNumber, newRecord)
            FileClose(fileNumber)
        Catch ex As Exception
            MsgBox("In file append Got: " & vbCrLf & ex.Message)
        End Try
    End Sub


    'Event Handlers
    Private Sub InventorySystemForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadInventoryFile()
        SetDefaults()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitTopMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click, UpdateTopMenuItem.Click, UpdateContextMenuItem.Click
        If ValidateUserInputs() Then
            Dim temp() As String = {54321, DescriptionTextBox.Text, PartNumberTextBox.Text, LocationTextBox.Text, VendorTextBox.Text, ManufactureTextBox.Text, DataSheetTextBox.Text}
            inventoryItems.Add(temp)
            'add record
            'inventoryItems.Add($"{"12345"}, {DescriptionTextBox.Text}, {PartNumberTextBox.Text}, {LocationTextBox.Text}, {VendorTextBox.Text}, {ManufactureTextBox.Text}, {DataSheetTextBox.Text}")
            'TODO add record to file
            'backup file first use of the day
            'mark with new file or temp file
            AppendRecordToFile(inventoryItems.Last, "..\..\temp.txt")
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearTopMenuItem.Click, ClearContextMenuItem.Click
        SetDefaults()
    End Sub

    Private Sub AboutTopMenuItem_Click(sender As Object, e As EventArgs) Handles AboutTopMenuItem.Click
        Me.Hide()
        AboutForm.Show()
    End Sub
End Class
