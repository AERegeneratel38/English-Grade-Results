Public Class Print_Preview


    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
        Beep()


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim myfont As New Font("Arial", 16)
        e.Graphics.DrawString(Form1.Student_s_NameTextBox.Text.ToString, myfont, Brushes.Black, 306, 208)
        e.Graphics.DrawString(Form1.ListeningComboBox.Text.ToString, myfont, Brushes.Black, 590, 391)
        e.Graphics.DrawString(Form1.SpeakingComboBox.Text.ToString, myfont, Brushes.Black, 590, 431)
        e.Graphics.DrawString(Form1.ReadingComboBox.Text.ToString, myfont, Brushes.Black, 590, 471)
        e.Graphics.DrawString(Form1.WritingComboBox.Text.ToString, myfont, Brushes.Black, 590, 511)
        e.Graphics.DrawString(Form1.RemarksTextBox.Text.ToString, myfont, Brushes.Black, New RectangleF(130, 570, 550, 150))
    End Sub

    Private Sub Print_Preview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class