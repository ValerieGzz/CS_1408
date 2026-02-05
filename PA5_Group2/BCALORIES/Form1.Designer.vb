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
        cboSpeeds = New ComboBox()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        lstOut = New ListBox()
        btnDisplayData = New Button()
        btnExit = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' cboSpeeds
        ' 
        cboSpeeds.DropDownStyle = ComboBoxStyle.DropDownList
        cboSpeeds.FormattingEnabled = True
        cboSpeeds.Items.AddRange(New Object() {"Low", "Medium", "High"})
        cboSpeeds.Location = New Point(395, 87)
        cboSpeeds.Name = "cboSpeeds"
        cboSpeeds.Size = New Size(242, 40)
        cboSpeeds.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(122, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(244, 45)
        Label1.TabIndex = 1
        Label1.Text = "Treadmill speed"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lstOut)
        GroupBox1.Location = New Point(27, 182)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(762, 575)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Calories Burned Information"
        ' 
        ' lstOut
        ' 
        lstOut.FormattingEnabled = True
        lstOut.HorizontalScrollbar = True
        lstOut.Location = New Point(36, 55)
        lstOut.Name = "lstOut"
        lstOut.Size = New Size(691, 484)
        lstOut.TabIndex = 0
        ' 
        ' btnDisplayData
        ' 
        btnDisplayData.Location = New Point(178, 783)
        btnDisplayData.Name = "btnDisplayData"
        btnDisplayData.Size = New Size(225, 78)
        btnDisplayData.TabIndex = 3
        btnDisplayData.Text = "&Display Data"
        btnDisplayData.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(425, 783)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(225, 78)
        btnExit.TabIndex = 4
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(828, 901)
        Controls.Add(btnExit)
        Controls.Add(btnDisplayData)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(cboSpeeds)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Calories Burned"
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboSpeeds As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstOut As ListBox
    Friend WithEvents btnDisplayData As Button
    Friend WithEvents btnExit As Button

End Class
