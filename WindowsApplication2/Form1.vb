Public Class Form1

    Private Sub Table1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Table1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.English_Grade_ResultsDataSet)

        MsgBox("The information is saved successfully.")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'English_Grade_ResultsDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.English_Grade_ResultsDataSet.Table1)
        If BindingNavigatorPositionItem.Text = 0 Then
            IDNumericUpDown.Enabled = False
            Student_s_NameTextBox.Enabled = False
            ListeningComboBox.Enabled = False
            SpeakingComboBox.Enabled = False
            WritingComboBox.Enabled = False
            ReadingComboBox.Enabled = False
            RemarksTextBox.Enabled = False
            Table1BindingNavigatorSaveItem.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = False
        Else
            IDNumericUpDown.Enabled = True
            Student_s_NameTextBox.Enabled = True
            ListeningComboBox.Enabled = True
            SpeakingComboBox.Enabled = True
            WritingComboBox.Enabled = True
            ReadingComboBox.Enabled = True
            RemarksTextBox.Enabled = True
            Table1BindingNavigatorSaveItem.Enabled = True
            Button1.Enabled = True
            Button2.Enabled = True

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim myfont As New Font("Arial", 16)
        e.Graphics.DrawString(Me.Student_s_NameTextBox.Text.ToString, myfont, Brushes.Black, 306, 208)
        e.Graphics.DrawString(Me.ListeningComboBox.Text.ToString, myfont, Brushes.Black, 590, 391)
        e.Graphics.DrawString(Me.SpeakingComboBox.Text.ToString, myfont, Brushes.Black, 590, 431)
        e.Graphics.DrawString(Me.ReadingComboBox.Text.ToString, myfont, Brushes.Black, 590, 471)
        e.Graphics.DrawString(Me.WritingComboBox.Text.ToString, myfont, Brushes.Black, 590, 511)
        e.Graphics.DrawString(Me.RemarksTextBox.Text.ToString, myfont, Brushes.Black, New RectangleF(130, 570, 550, 150))

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Beep()
        Print_Preview.Show()
        Hide()



    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        IDNumericUpDown.Enabled = True
        Student_s_NameTextBox.Enabled = True
        ListeningComboBox.Enabled = True
        SpeakingComboBox.Enabled = True
        WritingComboBox.Enabled = True
        ReadingComboBox.Enabled = True
        RemarksTextBox.Enabled = True
        Table1BindingNavigatorSaveItem.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AboutBox1.Show()
    End Sub

    Private Sub Form1_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.HelpButtonClicked
        Beep()
        MsgBox("Thank you for using English Grades Result, powered by AEL Corporation. Now, to use this app, first, click the button labelled as +. Then fill in the necessary details. To look how it is when printed, click the 'print preview' button. To print it, click the button labelled as Print. To save the information, click the button labelled as Save. To search a person's information, type his/her name in the textbox with labelled as What To Search. Then click the button labelled as Find. Then the quested person's name will come in the box. Then click the name and you will get his or her information. Thank you for using. BYE")

    End Sub
End Class
