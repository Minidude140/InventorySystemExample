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
    Function ValidateUserInputs() As Boolean
        Dim isValid As Boolean = True
        Dim errrorMessage As String
        'If DataSheetTextBox.Text = "" Then
        '    isValid = False
        '    MsgBox("DataSheet is required")
        '    DataSheetTextBox.Focus()
        'End If
        'If ManufactureTextBox.Text = "" Then
        '    isValid = False
        '    MsgBox("Manufacture is required")
        '    ManufactureTextBox.Focus()
        'End If
        'If VendorTextBox.Text = "" Then
        '    isValid = False
        '    MsgBox("Vendor is required")
        '    VendorTextBox.Focus()
        'End If
        'If LocationTextBox.Text = "" Then
        '    isValid = False
        '    MsgBox("Location is required")
        '    LocationTextBox.Focus()
        'End If
        'If PartNumberTextBox.Text = "" Then
        '    isValid = False
        '    MsgBox("Part Number is required")
        '    PartNumberTextBox.Focus()
        'End If
        'If DescriptionTextBox.Text = "" Then
        '    isValid = False
        '    MsgBox("Description is required")
        '    DescriptionTextBox.Focus()
        'End If

        For Each Thingy As TextBox In RecordInfoGroupBox.Controls.OfType(Of TextBox)
            If isValid = True Then
                Thingy.Focus()
            End If
            If Thingy.Text = "" Then
                isValid = False
                errrorMessage &= $"{Thingy.Name.ToString} is required{vbCrLf}"
            End If
        Next
        MsgBox(errrorMessage)
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
