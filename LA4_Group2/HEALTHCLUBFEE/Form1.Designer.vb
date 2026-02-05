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
        GroupBox1 = New GroupBox()
        radSenior = New RadioButton()
        radStudent = New RadioButton()
        radChild = New RadioButton()
        radAdult = New RadioButton()
        GroupBox2 = New GroupBox()
        chkTrainer = New CheckBox()
        chkKarate = New CheckBox()
        chkYoga = New CheckBox()
        GroupBox3 = New GroupBox()
        txtMonths = New TextBox()
        Label1 = New Label()
        GroupBox4 = New GroupBox()
        lblTotalFee = New Label()
        lblMonthlyFee = New Label()
        Label3 = New Label()
        Label2 = New Label()
        btnCalculate = New Button()
        btnClear = New Button()
        btnExit = New Button()
        StatusStrip1 = New StatusStrip()
        lblStatus = New ToolStripStatusLabel()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(radSenior)
        GroupBox1.Controls.Add(radStudent)
        GroupBox1.Controls.Add(radChild)
        GroupBox1.Controls.Add(radAdult)
        GroupBox1.Location = New Point(27, 29)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(327, 286)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Type of Membership"
        ' 
        ' radSenior
        ' 
        radSenior.Location = New Point(38, 206)
        radSenior.Name = "radSenior"
        radSenior.Size = New Size(203, 36)
        radSenior.TabIndex = 3
        radSenior.Text = "S&enior Citizen"
        radSenior.UseVisualStyleBackColor = True
        ' 
        ' radStudent
        ' 
        radStudent.Location = New Point(38, 158)
        radStudent.Name = "radStudent"
        radStudent.Size = New Size(203, 36)
        radStudent.TabIndex = 2
        radStudent.Text = "&Student"
        radStudent.UseVisualStyleBackColor = True
        ' 
        ' radChild
        ' 
        radChild.Location = New Point(38, 110)
        radChild.Name = "radChild"
        radChild.Size = New Size(266, 36)
        radChild.TabIndex = 1
        radChild.Text = "Chil&d (12 && Under)"
        radChild.UseVisualStyleBackColor = True
        ' 
        ' radAdult
        ' 
        radAdult.Checked = True
        radAdult.Location = New Point(38, 62)
        radAdult.Name = "radAdult"
        radAdult.Size = New Size(203, 36)
        radAdult.TabIndex = 0
        radAdult.TabStop = True
        radAdult.Text = "Standard &Adult"
        radAdult.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(chkTrainer)
        GroupBox2.Controls.Add(chkKarate)
        GroupBox2.Controls.Add(chkYoga)
        GroupBox2.Location = New Point(379, 29)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(400, 286)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Options"
        ' 
        ' chkTrainer
        ' 
        chkTrainer.AutoSize = True
        chkTrainer.Location = New Point(92, 185)
        chkTrainer.Name = "chkTrainer"
        chkTrainer.Size = New Size(214, 36)
        chkTrainer.TabIndex = 2
        chkTrainer.Text = "&Personal Trainer"
        chkTrainer.UseVisualStyleBackColor = True
        ' 
        ' chkKarate
        ' 
        chkKarate.AutoSize = True
        chkKarate.Location = New Point(92, 124)
        chkKarate.Name = "chkKarate"
        chkKarate.Size = New Size(113, 36)
        chkKarate.TabIndex = 1
        chkKarate.Text = "&Karate"
        chkKarate.UseVisualStyleBackColor = True
        ' 
        ' chkYoga
        ' 
        chkYoga.AutoSize = True
        chkYoga.Location = New Point(92, 63)
        chkYoga.Name = "chkYoga"
        chkYoga.Size = New Size(97, 36)
        chkYoga.TabIndex = 0
        chkYoga.Text = "&Yoga"
        chkYoga.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(txtMonths)
        GroupBox3.Controls.Add(Label1)
        GroupBox3.Location = New Point(27, 321)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(327, 257)
        GroupBox3.TabIndex = 1
        GroupBox3.TabStop = False
        GroupBox3.Text = "Membership Length"
        ' 
        ' txtMonths
        ' 
        txtMonths.Location = New Point(53, 174)
        txtMonths.Name = "txtMonths"
        txtMonths.Size = New Size(200, 39)
        txtMonths.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(51, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(216, 70)
        Label1.TabIndex = 0
        Label1.Text = "Enter the Number of Months:"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(lblTotalFee)
        GroupBox4.Controls.Add(lblMonthlyFee)
        GroupBox4.Controls.Add(Label3)
        GroupBox4.Controls.Add(Label2)
        GroupBox4.Location = New Point(379, 321)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(400, 257)
        GroupBox4.TabIndex = 2
        GroupBox4.TabStop = False
        GroupBox4.Text = "Membership Fees"
        ' 
        ' lblTotalFee
        ' 
        lblTotalFee.BorderStyle = BorderStyle.Fixed3D
        lblTotalFee.Location = New Point(204, 158)
        lblTotalFee.Name = "lblTotalFee"
        lblTotalFee.Size = New Size(166, 32)
        lblTotalFee.TabIndex = 3
        ' 
        ' lblMonthlyFee
        ' 
        lblMonthlyFee.BorderStyle = BorderStyle.Fixed3D
        lblMonthlyFee.Location = New Point(204, 103)
        lblMonthlyFee.Name = "lblMonthlyFee"
        lblMonthlyFee.Size = New Size(166, 32)
        lblMonthlyFee.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(119, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 32)
        Label3.TabIndex = 1
        Label3.Text = "Total:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(35, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(154, 32)
        Label2.TabIndex = 0
        Label2.Text = "Monthly Fee:"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(125, 649)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(150, 46)
        btnCalculate.TabIndex = 3
        btnCalculate.Text = "C&alculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(308, 649)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(150, 46)
        btnClear.TabIndex = 4
        btnClear.Text = "Clea&r"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(491, 649)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(150, 46)
        btnExit.TabIndex = 5
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(32, 32)
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblStatus})
        StatusStrip1.Location = New Point(0, 748)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(823, 22)
        StatusStrip1.TabIndex = 6
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' lblStatus
        ' 
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(0, 12)
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(823, 770)
        Controls.Add(StatusStrip1)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Membership Fee Calculator"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radAdult As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents radSenior As RadioButton
    Friend WithEvents radStudent As RadioButton
    Friend WithEvents radChild As RadioButton
    Friend WithEvents chkTrainer As CheckBox
    Friend WithEvents chkKarate As CheckBox
    Friend WithEvents chkYoga As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMonths As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMonthlyFee As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents lblTotalFee As Label

End Class
