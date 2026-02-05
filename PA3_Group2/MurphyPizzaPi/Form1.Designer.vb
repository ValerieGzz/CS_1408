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
        txtPizzaDiameterInput = New TextBox()
        Label2 = New Label()
        lblNumberOfSlices = New Label()
        ctnCalculateSlices = New Button()
        btnClear = New Button()
        btnExit = New Button()
        StatusStrip1 = New StatusStrip()
        lblStatus = New ToolStripStatusLabel()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(95, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(295, 32)
        Label1.TabIndex = 0
        Label1.Text = "Diameter of Pizza (inches):"
        ' 
        ' txtPizzaDiameterInput
        ' 
        txtPizzaDiameterInput.Location = New Point(396, 99)
        txtPizzaDiameterInput.Name = "txtPizzaDiameterInput"
        txtPizzaDiameterInput.Size = New Size(245, 39)
        txtPizzaDiameterInput.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(188, 164)
        Label2.Name = "Label2"
        Label2.Size = New Size(202, 32)
        Label2.TabIndex = 2
        Label2.Text = "Number of Slices:"
        ' 
        ' lblNumberOfSlices
        ' 
        lblNumberOfSlices.BorderStyle = BorderStyle.Fixed3D
        lblNumberOfSlices.Location = New Point(396, 164)
        lblNumberOfSlices.Name = "lblNumberOfSlices"
        lblNumberOfSlices.Size = New Size(245, 32)
        lblNumberOfSlices.TabIndex = 3
        ' 
        ' ctnCalculateSlices
        ' 
        ctnCalculateSlices.Location = New Point(110, 254)
        ctnCalculateSlices.Name = "ctnCalculateSlices"
        ctnCalculateSlices.Size = New Size(150, 46)
        ctnCalculateSlices.TabIndex = 4
        ctnCalculateSlices.Text = "&Calculate"
        ctnCalculateSlices.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(312, 254)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(150, 46)
        btnClear.TabIndex = 5
        btnClear.Text = "C&lear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(514, 254)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(150, 46)
        btnExit.TabIndex = 6
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(32, 32)
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblStatus})
        StatusStrip1.Location = New Point(0, 339)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(779, 22)
        StatusStrip1.TabIndex = 7
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
        ClientSize = New Size(779, 361)
        Controls.Add(StatusStrip1)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(ctnCalculateSlices)
        Controls.Add(lblNumberOfSlices)
        Controls.Add(Label2)
        Controls.Add(txtPizzaDiameterInput)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Pizza Slice Calculator"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPizzaDiameterInput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNumberOfSlices As Label
    Friend WithEvents ctnCalculateSlices As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel

End Class
