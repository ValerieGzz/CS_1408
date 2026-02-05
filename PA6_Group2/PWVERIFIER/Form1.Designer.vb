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
        Panel1 = New Panel()
        txtInput = New TextBox()
        Label1 = New Label()
        btnVerify = New Button()
        btnClear = New Button()
        btnExit = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.Controls.Add(txtInput)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(121, 71)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1040, 174)
        Panel1.TabIndex = 0
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(332, 70)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(539, 39)
        txtInput.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(129, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 45)
        Label1.TabIndex = 0
        Label1.Text = "Password:"
        ' 
        ' btnVerify
        ' 
        btnVerify.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnVerify.Location = New Point(184, 286)
        btnVerify.Name = "btnVerify"
        btnVerify.Size = New Size(254, 99)
        btnVerify.TabIndex = 1
        btnVerify.Text = "&Verify"
        btnVerify.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(519, 286)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(254, 99)
        btnClear.TabIndex = 2
        btnClear.Text = "C&lear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(851, 286)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(254, 99)
        btnExit.TabIndex = 3
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1283, 437)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnVerify)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnVerify As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button

End Class
