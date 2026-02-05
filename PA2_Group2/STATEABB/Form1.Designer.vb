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
        btnVirginia = New Button()
        btnNorthCarolina = New Button()
        btnTexas = New Button()
        btnGeorgia = New Button()
        btnAlabama = New Button()
        btnFlorida = New Button()
        btnExit = New Button()
        lblStateAbb = New Label()
        StatusStrip1 = New StatusStrip()
        lblStatus = New ToolStripStatusLabel()
        lblMessage = New Label()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnVirginia
        ' 
        btnVirginia.Font = New Font("Segoe UI", 12F)
        btnVirginia.Location = New Point(54, 121)
        btnVirginia.Name = "btnVirginia"
        btnVirginia.Size = New Size(263, 62)
        btnVirginia.TabIndex = 0
        btnVirginia.Text = "Virginia"
        btnVirginia.UseVisualStyleBackColor = True
        ' 
        ' btnNorthCarolina
        ' 
        btnNorthCarolina.Font = New Font("Segoe UI", 12F)
        btnNorthCarolina.Location = New Point(54, 202)
        btnNorthCarolina.Name = "btnNorthCarolina"
        btnNorthCarolina.Size = New Size(263, 59)
        btnNorthCarolina.TabIndex = 1
        btnNorthCarolina.Text = "North Carolina"
        btnNorthCarolina.UseVisualStyleBackColor = True
        ' 
        ' btnTexas
        ' 
        btnTexas.Font = New Font("Segoe UI", 12F)
        btnTexas.Location = New Point(54, 277)
        btnTexas.Name = "btnTexas"
        btnTexas.Size = New Size(263, 59)
        btnTexas.TabIndex = 2
        btnTexas.Text = "Texas"
        btnTexas.UseVisualStyleBackColor = True
        ' 
        ' btnGeorgia
        ' 
        btnGeorgia.Font = New Font("Segoe UI", 12F)
        btnGeorgia.Location = New Point(54, 349)
        btnGeorgia.Name = "btnGeorgia"
        btnGeorgia.Size = New Size(263, 56)
        btnGeorgia.TabIndex = 3
        btnGeorgia.Text = "Georgia"
        btnGeorgia.UseVisualStyleBackColor = True
        ' 
        ' btnAlabama
        ' 
        btnAlabama.Font = New Font("Segoe UI", 12F)
        btnAlabama.Location = New Point(54, 423)
        btnAlabama.Name = "btnAlabama"
        btnAlabama.Size = New Size(263, 56)
        btnAlabama.TabIndex = 4
        btnAlabama.Text = "Alabama"
        btnAlabama.UseVisualStyleBackColor = True
        ' 
        ' btnFlorida
        ' 
        btnFlorida.Font = New Font("Segoe UI", 12F)
        btnFlorida.Location = New Point(54, 497)
        btnFlorida.Name = "btnFlorida"
        btnFlorida.Size = New Size(263, 57)
        btnFlorida.TabIndex = 5
        btnFlorida.Text = "Florida"
        btnFlorida.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI", 12F)
        btnExit.Location = New Point(344, 677)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(227, 55)
        btnExit.TabIndex = 6
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblStateAbb
        ' 
        lblStateAbb.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblStateAbb.Location = New Point(54, 31)
        lblStateAbb.Name = "lblStateAbb"
        lblStateAbb.Size = New Size(456, 64)
        lblStateAbb.TabIndex = 8
        lblStateAbb.Text = "State Abbreviation:"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Font = New Font("Segoe UI", 12F)
        StatusStrip1.ImageScalingSize = New Size(32, 32)
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblStatus})
        StatusStrip1.Location = New Point(0, 759)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(893, 38)
        StatusStrip1.TabIndex = 9
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' lblStatus
        ' 
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(0, 28)
        ' 
        ' lblMessage
        ' 
        lblMessage.BorderStyle = BorderStyle.FixedSingle
        lblMessage.Font = New Font("Segoe UI", 12F)
        lblMessage.Location = New Point(344, 599)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(227, 64)
        lblMessage.TabIndex = 10
        lblMessage.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(893, 797)
        Controls.Add(lblMessage)
        Controls.Add(StatusStrip1)
        Controls.Add(lblStateAbb)
        Controls.Add(btnExit)
        Controls.Add(btnFlorida)
        Controls.Add(btnAlabama)
        Controls.Add(btnGeorgia)
        Controls.Add(btnTexas)
        Controls.Add(btnNorthCarolina)
        Controls.Add(btnVirginia)
        Name = "Form1"
        Text = "State Abbriviations"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnVirginia As Button
    Friend WithEvents btnNorthCarolina As Button
    Friend WithEvents btnTexas As Button
    Friend WithEvents btnGeorgia As Button
    Friend WithEvents btnAlabama As Button
    Friend WithEvents btnFlorida As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblStateAbb As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents lblMessage As Label

End Class
