<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim Student_s_NameLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim ListeningLabel As System.Windows.Forms.Label
        Dim WritingLabel As System.Windows.Forms.Label
        Dim SpeakingLabel As System.Windows.Forms.Label
        Dim ReadingLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.IDNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.English_Grade_ResultsDataSet = New EngGrdRslt.English_Grade_ResultsDataSet()
        Me.Student_s_NameTextBox = New System.Windows.Forms.TextBox()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ListeningComboBox = New System.Windows.Forms.ComboBox()
        Me.WritingComboBox = New System.Windows.Forms.ComboBox()
        Me.SpeakingComboBox = New System.Windows.Forms.ComboBox()
        Me.ReadingComboBox = New System.Windows.Forms.ComboBox()
        Me.Table1TableAdapter = New EngGrdRslt.English_Grade_ResultsDataSetTableAdapters.Table1TableAdapter()
        Me.TableAdapterManager = New EngGrdRslt.English_Grade_ResultsDataSetTableAdapters.TableAdapterManager()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Table1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Table1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        Student_s_NameLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        ListeningLabel = New System.Windows.Forms.Label()
        WritingLabel = New System.Windows.Forms.Label()
        SpeakingLabel = New System.Windows.Forms.Label()
        ReadingLabel = New System.Windows.Forms.Label()
        CType(Me.IDNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.English_Grade_ResultsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Table1BindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(12, 46)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'Student_s_NameLabel
        '
        Student_s_NameLabel.AutoSize = True
        Student_s_NameLabel.Location = New System.Drawing.Point(11, 72)
        Student_s_NameLabel.Name = "Student_s_NameLabel"
        Student_s_NameLabel.Size = New System.Drawing.Size(85, 13)
        Student_s_NameLabel.TabIndex = 3
        Student_s_NameLabel.Text = "Student's Name:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(12, 213)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 13
        RemarksLabel.Text = "Remarks:"
        '
        'ListeningLabel
        '
        ListeningLabel.AutoSize = True
        ListeningLabel.Location = New System.Drawing.Point(12, 100)
        ListeningLabel.Name = "ListeningLabel"
        ListeningLabel.Size = New System.Drawing.Size(52, 13)
        ListeningLabel.TabIndex = 20
        ListeningLabel.Text = "Listening:"
        '
        'WritingLabel
        '
        WritingLabel.AutoSize = True
        WritingLabel.Location = New System.Drawing.Point(12, 183)
        WritingLabel.Name = "WritingLabel"
        WritingLabel.Size = New System.Drawing.Size(43, 13)
        WritingLabel.TabIndex = 21
        WritingLabel.Text = "Writing:"
        '
        'SpeakingLabel
        '
        SpeakingLabel.AutoSize = True
        SpeakingLabel.Location = New System.Drawing.Point(12, 128)
        SpeakingLabel.Name = "SpeakingLabel"
        SpeakingLabel.Size = New System.Drawing.Size(55, 13)
        SpeakingLabel.TabIndex = 22
        SpeakingLabel.Text = "Speaking:"
        '
        'ReadingLabel
        '
        ReadingLabel.AutoSize = True
        ReadingLabel.Location = New System.Drawing.Point(12, 155)
        ReadingLabel.Name = "ReadingLabel"
        ReadingLabel.Size = New System.Drawing.Size(50, 13)
        ReadingLabel.TabIndex = 23
        ReadingLabel.Text = "Reading:"
        '
        'IDNumericUpDown
        '
        Me.IDNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Table1BindingSource, "ID", True))
        Me.IDNumericUpDown.Location = New System.Drawing.Point(102, 39)
        Me.IDNumericUpDown.Name = "IDNumericUpDown"
        Me.IDNumericUpDown.Size = New System.Drawing.Size(34, 20)
        Me.IDNumericUpDown.TabIndex = 2
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.English_Grade_ResultsDataSet
        '
        'English_Grade_ResultsDataSet
        '
        Me.English_Grade_ResultsDataSet.DataSetName = "English_Grade_ResultsDataSet"
        Me.English_Grade_ResultsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Student_s_NameTextBox
        '
        Me.Student_s_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Student's Name", True))
        Me.Student_s_NameTextBox.Location = New System.Drawing.Point(102, 69)
        Me.Student_s_NameTextBox.Name = "Student_s_NameTextBox"
        Me.Student_s_NameTextBox.Size = New System.Drawing.Size(182, 20)
        Me.Student_s_NameTextBox.TabIndex = 4
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(102, 210)
        Me.RemarksTextBox.Multiline = True
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(218, 20)
        Me.RemarksTextBox.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(126, 254)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(158, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Print Preview"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        Me.PrintDocument1.OriginAtMargins = True
        '
        'ListeningComboBox
        '
        Me.ListeningComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Listening", True))
        Me.ListeningComboBox.FormattingEnabled = True
        Me.ListeningComboBox.Items.AddRange(New Object() {"A", "B+", "B", "C", "D", "E"})
        Me.ListeningComboBox.Location = New System.Drawing.Point(103, 97)
        Me.ListeningComboBox.Name = "ListeningComboBox"
        Me.ListeningComboBox.Size = New System.Drawing.Size(50, 21)
        Me.ListeningComboBox.TabIndex = 21
        '
        'WritingComboBox
        '
        Me.WritingComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Writing", True))
        Me.WritingComboBox.FormattingEnabled = True
        Me.WritingComboBox.Items.AddRange(New Object() {"A", "B+", "B", "C", "D", "E"})
        Me.WritingComboBox.Location = New System.Drawing.Point(103, 179)
        Me.WritingComboBox.Name = "WritingComboBox"
        Me.WritingComboBox.Size = New System.Drawing.Size(51, 21)
        Me.WritingComboBox.TabIndex = 22
        '
        'SpeakingComboBox
        '
        Me.SpeakingComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Speaking", True))
        Me.SpeakingComboBox.FormattingEnabled = True
        Me.SpeakingComboBox.Items.AddRange(New Object() {"A", "B+", "B", "C", "D", "E"})
        Me.SpeakingComboBox.Location = New System.Drawing.Point(102, 125)
        Me.SpeakingComboBox.Name = "SpeakingComboBox"
        Me.SpeakingComboBox.Size = New System.Drawing.Size(51, 21)
        Me.SpeakingComboBox.TabIndex = 23
        '
        'ReadingComboBox
        '
        Me.ReadingComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Reading", True))
        Me.ReadingComboBox.FormattingEnabled = True
        Me.ReadingComboBox.Items.AddRange(New Object() {"A", "B+", "B", "C", "D", "E"})
        Me.ReadingComboBox.Location = New System.Drawing.Point(102, 152)
        Me.ReadingComboBox.Name = "ReadingComboBox"
        Me.ReadingComboBox.Size = New System.Drawing.Size(51, 21)
        Me.ReadingComboBox.TabIndex = 24
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Table1TableAdapter = Me.Table1TableAdapter
        Me.TableAdapterManager.UpdateOrder = EngGrdRslt.English_Grade_ResultsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Table1BindingNavigatorSaveItem
        '
        Me.Table1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Table1BindingNavigatorSaveItem.Image = CType(resources.GetObject("Table1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Table1BindingNavigatorSaveItem.Name = "Table1BindingNavigatorSaveItem"
        Me.Table1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Table1BindingNavigatorSaveItem.Text = "Save Data"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Table1BindingNavigator
        '
        Me.Table1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Table1BindingNavigator.BindingSource = Me.Table1BindingSource
        Me.Table1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Table1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Table1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Table1BindingNavigatorSaveItem, Me.toolStripSeparator, Me.toolStripSeparator1})
        Me.Table1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Table1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Table1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Table1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Table1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Table1BindingNavigator.Name = "Table1BindingNavigator"
        Me.Table1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Table1BindingNavigator.Size = New System.Drawing.Size(339, 25)
        Me.Table1BindingNavigator.TabIndex = 0
        Me.Table1BindingNavigator.Text = "BindingNavigator1"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(281, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(46, 23)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "About"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 281)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(ReadingLabel)
        Me.Controls.Add(Me.ReadingComboBox)
        Me.Controls.Add(SpeakingLabel)
        Me.Controls.Add(Me.SpeakingComboBox)
        Me.Controls.Add(WritingLabel)
        Me.Controls.Add(Me.WritingComboBox)
        Me.Controls.Add(ListeningLabel)
        Me.Controls.Add(Me.ListeningComboBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(RemarksLabel)
        Me.Controls.Add(Me.RemarksTextBox)
        Me.Controls.Add(Student_s_NameLabel)
        Me.Controls.Add(Me.Student_s_NameTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDNumericUpDown)
        Me.Controls.Add(Me.Table1BindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "English Grade Results"
        CType(Me.IDNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.English_Grade_ResultsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Table1BindingNavigator.ResumeLayout(False)
        Me.Table1BindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents English_Grade_ResultsDataSet As EngGrdRslt.English_Grade_ResultsDataSet
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table1TableAdapter As EngGrdRslt.English_Grade_ResultsDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents TableAdapterManager As EngGrdRslt.English_Grade_ResultsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Student_s_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ListeningComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents WritingComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SpeakingComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ReadingComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Table1BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Table1BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
