<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtTitle = New TextBox()
        txtAmount = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        cboCategory = New ComboBox()
        Label5 = New Label()
        datePicker = New DateTimePicker()
        btnADD = New Button()
        UPDATE = New Button()
        DELETE = New Button()
        dvgExpenses = New DataGridView()
        Label6 = New Label()
        txtNotes = New TextBox()
        txtID = New TextBox()
        Label7 = New Label()
        CType(dvgExpenses, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(108, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(658, 86)
        Label1.TabIndex = 0
        Label1.Text = "[ EXPENSE TRACKER ] "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(139, 194)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 15)
        Label2.TabIndex = 1
        Label2.Text = "TITLE: "
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(233, 189)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(121, 23)
        txtTitle.TabIndex = 2
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(476, 189)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(159, 23)
        txtAmount.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(378, 194)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 15)
        Label3.TabIndex = 4
        Label3.Text = "AMOUNT:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(139, 259)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 15)
        Label4.TabIndex = 5
        Label4.Text = "CATEGORY:"
        ' 
        ' cboCategory
        ' 
        cboCategory.FormattingEnabled = True
        cboCategory.Location = New Point(233, 251)
        cboCategory.Name = "cboCategory"
        cboCategory.Size = New Size(121, 23)
        cboCategory.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(381, 259)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 15)
        Label5.TabIndex = 7
        Label5.Text = "DATE: "
        ' 
        ' datePicker
        ' 
        datePicker.Location = New Point(476, 253)
        datePicker.Name = "datePicker"
        datePicker.Size = New Size(200, 23)
        datePicker.TabIndex = 8
        ' 
        ' btnADD
        ' 
        btnADD.Location = New Point(15, 371)
        btnADD.Name = "btnADD"
        btnADD.Size = New Size(229, 28)
        btnADD.TabIndex = 9
        btnADD.Text = "ADD"
        btnADD.UseVisualStyleBackColor = True
        ' 
        ' UPDATE
        ' 
        UPDATE.Location = New Point(290, 371)
        UPDATE.Name = "UPDATE"
        UPDATE.Size = New Size(229, 28)
        UPDATE.TabIndex = 10
        UPDATE.Text = "UPDATE"
        UPDATE.UseVisualStyleBackColor = True
        ' 
        ' DELETE
        ' 
        DELETE.Location = New Point(562, 371)
        DELETE.Name = "DELETE"
        DELETE.Size = New Size(229, 28)
        DELETE.TabIndex = 11
        DELETE.Text = "DELETE"
        DELETE.UseVisualStyleBackColor = True
        ' 
        ' dvgExpenses
        ' 
        dvgExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dvgExpenses.Location = New Point(909, -6)
        dvgExpenses.Name = "dvgExpenses"
        dvgExpenses.Size = New Size(626, 629)
        dvgExpenses.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(210, 318)
        Label6.Name = "Label6"
        Label6.Size = New Size(46, 15)
        Label6.TabIndex = 13
        Label6.Text = "NOTES:"
        ' 
        ' txtNotes
        ' 
        txtNotes.Location = New Point(304, 310)
        txtNotes.Name = "txtNotes"
        txtNotes.Size = New Size(297, 23)
        txtNotes.TabIndex = 14
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(290, 132)
        txtID.Name = "txtID"
        txtID.Size = New Size(271, 23)
        txtID.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(263, 135)
        Label7.Name = "Label7"
        Label7.Size = New Size(21, 15)
        Label7.TabIndex = 16
        Label7.Text = "ID:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1532, 626)
        Controls.Add(Label7)
        Controls.Add(txtID)
        Controls.Add(txtNotes)
        Controls.Add(Label6)
        Controls.Add(dvgExpenses)
        Controls.Add(DELETE)
        Controls.Add(UPDATE)
        Controls.Add(btnADD)
        Controls.Add(datePicker)
        Controls.Add(Label5)
        Controls.Add(cboCategory)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtAmount)
        Controls.Add(txtTitle)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(dvgExpenses, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents datePicker As DateTimePicker
    Friend WithEvents btnADD As Button
    Friend WithEvents UPDATE As Button
    Friend WithEvents DELETE As Button
    Friend WithEvents dvgExpenses As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label7 As Label

End Class
