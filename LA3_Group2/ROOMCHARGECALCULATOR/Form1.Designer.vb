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
        Label3 = New Label()
        lblDateToday = New Label()
        lblTimeToday = New Label()
        GroupBox1 = New GroupBox()
        txtNightlyCharge = New TextBox()
        txtNights = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        additionalChargeGB = New GroupBox()
        txtMisc = New TextBox()
        txtTelephone = New TextBox()
        txtRoomService = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        GroupBox2 = New GroupBox()
        lblTotal = New Label()
        lblTax = New Label()
        lblSubtotal = New Label()
        lblAddCharges = New Label()
        lblRoomCharges = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        btnCalculate = New Button()
        btnClear = New Button()
        btnExit = New Button()
        GroupBox1.SuspendLayout()
        additionalChargeGB.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(319, 49)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(398, 55)
        Label1.TabIndex = 0
        Label1.Text = "Highlander Hotel"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(262, 145)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(155, 32)
        Label2.TabIndex = 1
        Label2.Text = "Today's Date:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(344, 190)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 32)
        Label3.TabIndex = 2
        Label3.Text = "Time:"
        ' 
        ' lblDateToday
        ' 
        lblDateToday.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblDateToday.Location = New Point(422, 145)
        lblDateToday.Margin = New Padding(4, 0, 4, 0)
        lblDateToday.Name = "lblDateToday"
        lblDateToday.Size = New Size(405, 32)
        lblDateToday.TabIndex = 3
        ' 
        ' lblTimeToday
        ' 
        lblTimeToday.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblTimeToday.Location = New Point(422, 190)
        lblTimeToday.Margin = New Padding(4, 0, 4, 0)
        lblTimeToday.Name = "lblTimeToday"
        lblTimeToday.Size = New Size(405, 32)
        lblTimeToday.TabIndex = 4
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtNightlyCharge)
        GroupBox1.Controls.Add(txtNights)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Location = New Point(63, 254)
        GroupBox1.Margin = New Padding(4, 2, 4, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 2, 4, 2)
        GroupBox1.Size = New Size(453, 282)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Room Information"
        ' 
        ' txtNightlyCharge
        ' 
        txtNightlyCharge.BorderStyle = BorderStyle.FixedSingle
        txtNightlyCharge.Location = New Point(234, 160)
        txtNightlyCharge.Margin = New Padding(4, 2, 4, 2)
        txtNightlyCharge.Name = "txtNightlyCharge"
        txtNightlyCharge.Size = New Size(201, 39)
        txtNightlyCharge.TabIndex = 3
        ' 
        ' txtNights
        ' 
        txtNights.BorderStyle = BorderStyle.FixedSingle
        txtNights.Location = New Point(234, 107)
        txtNights.Margin = New Padding(4, 2, 4, 2)
        txtNights.Name = "txtNights"
        txtNights.Size = New Size(201, 39)
        txtNights.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(46, 162)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(180, 32)
        Label5.TabIndex = 1
        Label5.Text = "Nightly Charge:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(137, 109)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 32)
        Label4.TabIndex = 0
        Label4.Text = "Nights:"
        ' 
        ' additionalChargeGB
        ' 
        additionalChargeGB.Controls.Add(txtMisc)
        additionalChargeGB.Controls.Add(txtTelephone)
        additionalChargeGB.Controls.Add(txtRoomService)
        additionalChargeGB.Controls.Add(Label8)
        additionalChargeGB.Controls.Add(Label7)
        additionalChargeGB.Controls.Add(Label6)
        additionalChargeGB.Location = New Point(540, 254)
        additionalChargeGB.Margin = New Padding(4, 2, 4, 2)
        additionalChargeGB.Name = "additionalChargeGB"
        additionalChargeGB.Padding = New Padding(4, 2, 4, 2)
        additionalChargeGB.Size = New Size(453, 282)
        additionalChargeGB.TabIndex = 6
        additionalChargeGB.TabStop = False
        additionalChargeGB.Text = "Additional Charges"
        ' 
        ' txtMisc
        ' 
        txtMisc.BorderStyle = BorderStyle.FixedSingle
        txtMisc.Location = New Point(241, 188)
        txtMisc.Margin = New Padding(4, 2, 4, 2)
        txtMisc.Name = "txtMisc"
        txtMisc.Size = New Size(201, 39)
        txtMisc.TabIndex = 5
        ' 
        ' txtTelephone
        ' 
        txtTelephone.BorderStyle = BorderStyle.FixedSingle
        txtTelephone.Location = New Point(241, 134)
        txtTelephone.Margin = New Padding(4, 2, 4, 2)
        txtTelephone.Name = "txtTelephone"
        txtTelephone.Size = New Size(201, 39)
        txtTelephone.TabIndex = 4
        ' 
        ' txtRoomService
        ' 
        txtRoomService.BorderStyle = BorderStyle.FixedSingle
        txtRoomService.Location = New Point(241, 80)
        txtRoomService.Margin = New Padding(4, 2, 4, 2)
        txtRoomService.Name = "txtRoomService"
        txtRoomService.Size = New Size(201, 39)
        txtRoomService.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(149, 190)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(68, 32)
        Label8.TabIndex = 2
        Label8.Text = "Misc:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(86, 139)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(131, 32)
        Label7.TabIndex = 1
        Label7.Text = "Telephone:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(53, 87)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(164, 32)
        Label6.TabIndex = 0
        Label6.Text = "Room Service:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(lblTotal)
        GroupBox2.Controls.Add(lblTax)
        GroupBox2.Controls.Add(lblSubtotal)
        GroupBox2.Controls.Add(lblAddCharges)
        GroupBox2.Controls.Add(lblRoomCharges)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Location = New Point(184, 565)
        GroupBox2.Margin = New Padding(4, 2, 4, 2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 2, 4, 2)
        GroupBox2.Size = New Size(698, 369)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        GroupBox2.Text = "Total Charges"
        ' 
        ' lblTotal
        ' 
        lblTotal.BorderStyle = BorderStyle.Fixed3D
        lblTotal.Location = New Point(414, 273)
        lblTotal.Margin = New Padding(4, 0, 4, 0)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(201, 32)
        lblTotal.TabIndex = 17
        ' 
        ' lblTax
        ' 
        lblTax.BorderStyle = BorderStyle.Fixed3D
        lblTax.Location = New Point(414, 222)
        lblTax.Margin = New Padding(4, 0, 4, 0)
        lblTax.Name = "lblTax"
        lblTax.Size = New Size(201, 32)
        lblTax.TabIndex = 16
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.BorderStyle = BorderStyle.Fixed3D
        lblSubtotal.Location = New Point(414, 171)
        lblSubtotal.Margin = New Padding(4, 0, 4, 0)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(201, 32)
        lblSubtotal.TabIndex = 15
        ' 
        ' lblAddCharges
        ' 
        lblAddCharges.BorderStyle = BorderStyle.Fixed3D
        lblAddCharges.Location = New Point(414, 117)
        lblAddCharges.Margin = New Padding(4, 0, 4, 0)
        lblAddCharges.Name = "lblAddCharges"
        lblAddCharges.Size = New Size(201, 32)
        lblAddCharges.TabIndex = 14
        ' 
        ' lblRoomCharges
        ' 
        lblRoomCharges.BorderStyle = BorderStyle.Fixed3D
        lblRoomCharges.Location = New Point(414, 66)
        lblRoomCharges.Margin = New Padding(4, 0, 4, 0)
        lblRoomCharges.Name = "lblRoomCharges"
        lblRoomCharges.Size = New Size(201, 32)
        lblRoomCharges.TabIndex = 13
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(245, 273)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(163, 32)
        Label13.TabIndex = 12
        Label13.Text = "Total Charges:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(357, 222)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(52, 32)
        Label12.TabIndex = 11
        Label12.Text = "Tax:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(301, 171)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(108, 32)
        Label11.TabIndex = 10
        Label11.Text = "Subtotal:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(188, 117)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(221, 32)
        Label10.TabIndex = 9
        Label10.Text = "Additional Charges:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(234, 66)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(174, 32)
        Label9.TabIndex = 8
        Label9.Text = "Room Charges:"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(141, 975)
        btnCalculate.Margin = New Padding(4, 2, 4, 2)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(227, 77)
        btnCalculate.TabIndex = 8
        btnCalculate.Text = "C&alculate Charges"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(427, 975)
        btnClear.Margin = New Padding(4, 2, 4, 2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(227, 77)
        btnClear.TabIndex = 9
        btnClear.Text = "Clea&r"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(713, 975)
        btnExit.Margin = New Padding(4, 2, 4, 2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(227, 77)
        btnExit.TabIndex = 10
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1057, 1129)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(GroupBox2)
        Controls.Add(additionalChargeGB)
        Controls.Add(GroupBox1)
        Controls.Add(lblTimeToday)
        Controls.Add(lblDateToday)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(4, 2, 4, 2)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        additionalChargeGB.ResumeLayout(False)
        additionalChargeGB.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDateToday As Label
    Friend WithEvents lblTimeToday As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNights As TextBox
    Friend WithEvents additionalChargeGB As GroupBox
    Friend WithEvents txtNightlyCharge As TextBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents txtRoomService As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMisc As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblRoomCharges As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblAddCharges As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button

End Class
