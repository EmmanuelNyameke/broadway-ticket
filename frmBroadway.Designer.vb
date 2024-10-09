<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBroadway
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblHeading = New Label()
        picBroadway = New PictureBox()
        lblGroupSize = New Label()
        txtGroupSize = New TextBox()
        grpGroupSize = New GroupBox()
        radGroup25 = New RadioButton()
        radGroup13 = New RadioButton()
        radGroup9 = New RadioButton()
        radGroup1 = New RadioButton()
        lblTotalCost = New Label()
        lblCost = New Label()
        btnCalcCost = New Button()
        btnClear = New Button()
        CType(picBroadway, ComponentModel.ISupportInitialize).BeginInit()
        grpGroupSize.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(361, 9)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(416, 29)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Broadway Tickets Group Discount"
        ' 
        ' picBroadway
        ' 
        picBroadway.Dock = DockStyle.Left
        picBroadway.Image = My.Resources.Resources.broadway
        picBroadway.Location = New Point(0, 0)
        picBroadway.Name = "picBroadway"
        picBroadway.Size = New Size(342, 420)
        picBroadway.SizeMode = PictureBoxSizeMode.StretchImage
        picBroadway.TabIndex = 1
        picBroadway.TabStop = False
        ' 
        ' lblGroupSize
        ' 
        lblGroupSize.AutoSize = True
        lblGroupSize.Font = New Font("Tahoma", 14.25F)
        lblGroupSize.Location = New Point(435, 71)
        lblGroupSize.Name = "lblGroupSize"
        lblGroupSize.Size = New Size(180, 23)
        lblGroupSize.TabIndex = 2
        lblGroupSize.Text = "Number in a Group:"
        ' 
        ' txtGroupSize
        ' 
        txtGroupSize.Font = New Font("Tahoma", 14.25F)
        txtGroupSize.Location = New Point(641, 68)
        txtGroupSize.Name = "txtGroupSize"
        txtGroupSize.Size = New Size(31, 30)
        txtGroupSize.TabIndex = 3
        txtGroupSize.TextAlign = HorizontalAlignment.Center
        ' 
        ' grpGroupSize
        ' 
        grpGroupSize.BackColor = Color.Red
        grpGroupSize.Controls.Add(radGroup25)
        grpGroupSize.Controls.Add(radGroup13)
        grpGroupSize.Controls.Add(radGroup9)
        grpGroupSize.Controls.Add(radGroup1)
        grpGroupSize.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpGroupSize.Location = New Point(488, 127)
        grpGroupSize.Name = "grpGroupSize"
        grpGroupSize.Size = New Size(184, 103)
        grpGroupSize.TabIndex = 4
        grpGroupSize.TabStop = False
        grpGroupSize.Text = "Group Size:"
        ' 
        ' radGroup25
        ' 
        radGroup25.AutoSize = True
        radGroup25.Location = New Point(89, 74)
        radGroup25.Name = "radGroup25"
        radGroup25.Size = New Size(69, 23)
        radGroup25.TabIndex = 3
        radGroup25.TabStop = True
        radGroup25.Text = "25-99"
        radGroup25.UseVisualStyleBackColor = True
        ' 
        ' radGroup13
        ' 
        radGroup13.AutoSize = True
        radGroup13.Location = New Point(89, 28)
        radGroup13.Name = "radGroup13"
        radGroup13.Size = New Size(69, 23)
        radGroup13.TabIndex = 2
        radGroup13.TabStop = True
        radGroup13.Text = "13-24"
        radGroup13.UseVisualStyleBackColor = True
        ' 
        ' radGroup9
        ' 
        radGroup9.AutoSize = True
        radGroup9.Location = New Point(11, 74)
        radGroup9.Name = "radGroup9"
        radGroup9.Size = New Size(60, 23)
        radGroup9.TabIndex = 1
        radGroup9.TabStop = True
        radGroup9.Text = "9-12"
        radGroup9.UseVisualStyleBackColor = True
        ' 
        ' radGroup1
        ' 
        radGroup1.AutoSize = True
        radGroup1.Location = New Point(11, 28)
        radGroup1.Name = "radGroup1"
        radGroup1.Size = New Size(51, 23)
        radGroup1.TabIndex = 0
        radGroup1.TabStop = True
        radGroup1.Text = "1-8"
        radGroup1.UseVisualStyleBackColor = True
        ' 
        ' lblTotalCost
        ' 
        lblTotalCost.AutoSize = True
        lblTotalCost.Font = New Font("Tahoma", 14.25F)
        lblTotalCost.ForeColor = Color.Red
        lblTotalCost.Location = New Point(451, 271)
        lblTotalCost.Name = "lblTotalCost"
        lblTotalCost.Size = New Size(99, 23)
        lblTotalCost.TabIndex = 4
        lblTotalCost.Text = "Total Cost:"
        ' 
        ' lblCost
        ' 
        lblCost.AutoSize = True
        lblCost.Font = New Font("Tahoma", 14.25F)
        lblCost.Location = New Point(589, 271)
        lblCost.Name = "lblCost"
        lblCost.Size = New Size(45, 23)
        lblCost.TabIndex = 5
        lblCost.Text = "Cost"
        ' 
        ' btnCalcCost
        ' 
        btnCalcCost.BackColor = Color.Red
        btnCalcCost.Font = New Font("Tahoma", 12F)
        btnCalcCost.Location = New Point(435, 337)
        btnCalcCost.Name = "btnCalcCost"
        btnCalcCost.Size = New Size(124, 34)
        btnCalcCost.TabIndex = 6
        btnCalcCost.Text = "Calculate Cost"
        btnCalcCost.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Red
        btnClear.Font = New Font("Tahoma", 12F)
        btnClear.Location = New Point(581, 337)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(124, 34)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' frmBroadway
        ' 
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DimGray
        ClientSize = New Size(800, 420)
        Controls.Add(btnClear)
        Controls.Add(btnCalcCost)
        Controls.Add(lblCost)
        Controls.Add(lblTotalCost)
        Controls.Add(grpGroupSize)
        Controls.Add(txtGroupSize)
        Controls.Add(lblGroupSize)
        Controls.Add(picBroadway)
        Controls.Add(lblHeading)
        Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.White
        Name = "frmBroadway"
        Text = "Broadway Tickets Group Discount"
        CType(picBroadway, ComponentModel.ISupportInitialize).EndInit()
        grpGroupSize.ResumeLayout(False)
        grpGroupSize.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picBroadway As PictureBox
    Friend WithEvents lblGroupSize As Label
    Friend WithEvents txtGroupSize As TextBox
    Friend WithEvents grpGroupSize As GroupBox
    Friend WithEvents radGroup25 As RadioButton
    Friend WithEvents radGroup13 As RadioButton
    Friend WithEvents radGroup9 As RadioButton
    Friend WithEvents radGroup1 As RadioButton
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents btnCalcCost As Button
    Friend WithEvents btnClear As Button

End Class
