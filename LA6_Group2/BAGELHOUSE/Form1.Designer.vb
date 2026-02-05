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
        components = New ComponentModel.Container()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        radWheat = New RadioButton()
        radWhite = New RadioButton()
        Panel1 = New Panel()
        GroupBox1 = New GroupBox()
        chkPeach = New CheckBox()
        chkRaspberry = New CheckBox()
        chkBlueberry = New CheckBox()
        chkButter = New CheckBox()
        chkCreamCheese = New CheckBox()
        Panel2 = New Panel()
        GroupBox3 = New GroupBox()
        radCafeAuLait = New RadioButton()
        radCappuccino = New RadioButton()
        radRegCoffee = New RadioButton()
        radNoCoffee = New RadioButton()
        ToolTip1 = New ToolTip(components)
        btnCalculate = New Button()
        btnReset = New Button()
        btnExit = New Button()
        GroupBox4 = New GroupBox()
        lblTotal = New Label()
        lblTax = New Label()
        lblSubtotal = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Panel3 = New Panel()
        GroupBox2.SuspendLayout()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        Panel2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(197, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(667, 73)
        Label1.TabIndex = 1
        Label1.Text = "Brandi's Bagel House"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(radWheat)
        GroupBox2.Controls.Add(radWhite)
        GroupBox2.Location = New Point(32, 37)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(382, 241)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        GroupBox2.Text = "Pick a Bagel"
        ' 
        ' radWheat
        ' 
        radWheat.AutoSize = True
        radWheat.Location = New Point(58, 133)
        radWheat.Name = "radWheat"
        radWheat.Size = New Size(268, 36)
        radWheat.TabIndex = 1
        radWheat.TabStop = True
        radWheat.Text = "Whole Wheat ($1.50)"
        ToolTip1.SetToolTip(radWheat, "Click here to choose a whole wheat bagel.")
        radWheat.UseVisualStyleBackColor = True
        ' 
        ' radWhite
        ' 
        radWhite.AutoSize = True
        radWhite.Checked = True
        radWhite.Location = New Point(58, 69)
        radWhite.Name = "radWhite"
        radWhite.Size = New Size(186, 36)
        radWhite.TabIndex = 0
        radWhite.TabStop = True
        radWhite.Text = "White ($1.25)"
        ToolTip1.SetToolTip(radWhite, "Click here to choose a white bagel.")
        radWhite.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(GroupBox1)
        Panel1.Controls.Add(GroupBox2)
        Panel1.Location = New Point(36, 174)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(464, 755)
        Panel1.TabIndex = 2
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(chkPeach)
        GroupBox1.Controls.Add(chkRaspberry)
        GroupBox1.Controls.Add(chkBlueberry)
        GroupBox1.Controls.Add(chkButter)
        GroupBox1.Controls.Add(chkCreamCheese)
        GroupBox1.Location = New Point(32, 300)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(382, 413)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Pick Your Toppings"
        ' 
        ' chkPeach
        ' 
        chkPeach.AutoSize = True
        chkPeach.Location = New Point(50, 337)
        chkPeach.Name = "chkPeach"
        chkPeach.Size = New Size(226, 36)
        chkPeach.TabIndex = 4
        chkPeach.Text = "Peach Jelly ($.75)"
        ToolTip1.SetToolTip(chkPeach, "Click here to choose peach jelly.")
        chkPeach.UseVisualStyleBackColor = True
        ' 
        ' chkRaspberry
        ' 
        chkRaspberry.AutoSize = True
        chkRaspberry.Location = New Point(50, 272)
        chkRaspberry.Name = "chkRaspberry"
        chkRaspberry.Size = New Size(265, 36)
        chkRaspberry.TabIndex = 3
        chkRaspberry.Text = "Raspberry Jam ($.75)"
        ToolTip1.SetToolTip(chkRaspberry, "Click here to choose raspberry jam.")
        chkRaspberry.UseVisualStyleBackColor = True
        ' 
        ' chkBlueberry
        ' 
        chkBlueberry.AutoSize = True
        chkBlueberry.Location = New Point(50, 207)
        chkBlueberry.Name = "chkBlueberry"
        chkBlueberry.Size = New Size(262, 36)
        chkBlueberry.TabIndex = 2
        chkBlueberry.Text = "Blueberry Jam ($.75)"
        ToolTip1.SetToolTip(chkBlueberry, "Click here to choose blueberry jam.")
        chkBlueberry.UseVisualStyleBackColor = True
        ' 
        ' chkButter
        ' 
        chkButter.AutoSize = True
        chkButter.Location = New Point(50, 142)
        chkButter.Name = "chkButter"
        chkButter.Size = New Size(176, 36)
        chkButter.TabIndex = 1
        chkButter.Text = "Butter ($.25)"
        ToolTip1.SetToolTip(chkButter, "Click here to choose butter.")
        chkButter.UseVisualStyleBackColor = True
        ' 
        ' chkCreamCheese
        ' 
        chkCreamCheese.AutoSize = True
        chkCreamCheese.Location = New Point(50, 77)
        chkCreamCheese.Name = "chkCreamCheese"
        chkCreamCheese.Size = New Size(265, 36)
        chkCreamCheese.TabIndex = 0
        chkCreamCheese.Text = "Cream Cheese ($.50)"
        ToolTip1.SetToolTip(chkCreamCheese, "Click here to choose cream cheese.")
        chkCreamCheese.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(GroupBox3)
        Panel2.Location = New Point(530, 174)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(445, 421)
        Panel2.TabIndex = 3
        ToolTip1.SetToolTip(Panel2, "Click here to choose no coffee.")
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(radCafeAuLait)
        GroupBox3.Controls.Add(radCappuccino)
        GroupBox3.Controls.Add(radRegCoffee)
        GroupBox3.Controls.Add(radNoCoffee)
        GroupBox3.Location = New Point(30, 37)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(385, 356)
        GroupBox3.TabIndex = 0
        GroupBox3.TabStop = False
        GroupBox3.Text = "Want Coffee with That?"
        ' 
        ' radCafeAuLait
        ' 
        radCafeAuLait.AutoSize = True
        radCafeAuLait.Location = New Point(52, 267)
        radCafeAuLait.Name = "radCafeAuLait"
        radCafeAuLait.Size = New Size(243, 36)
        radCafeAuLait.TabIndex = 3
        radCafeAuLait.Text = "Café au lait ($1.75)"
        ToolTip1.SetToolTip(radCafeAuLait, "Click here to choose café au lait.")
        radCafeAuLait.UseVisualStyleBackColor = True
        ' 
        ' radCappuccino
        ' 
        radCappuccino.AutoSize = True
        radCappuccino.Location = New Point(52, 195)
        radCappuccino.Name = "radCappuccino"
        radCappuccino.Size = New Size(248, 36)
        radCappuccino.TabIndex = 2
        radCappuccino.Text = "Cappuccino ($2.00)"
        ToolTip1.SetToolTip(radCappuccino, "Click here to choose cappuccino.")
        radCappuccino.UseVisualStyleBackColor = True
        ' 
        ' radRegCoffee
        ' 
        radRegCoffee.AutoSize = True
        radRegCoffee.Checked = True
        radRegCoffee.Location = New Point(52, 123)
        radRegCoffee.Name = "radRegCoffee"
        radRegCoffee.Size = New Size(281, 36)
        radRegCoffee.TabIndex = 1
        radRegCoffee.TabStop = True
        radRegCoffee.Text = "Regular Coffee ($1.25)"
        ToolTip1.SetToolTip(radRegCoffee, "Click here to choose regular coffee.")
        radRegCoffee.UseVisualStyleBackColor = True
        ' 
        ' radNoCoffee
        ' 
        radNoCoffee.AutoSize = True
        radNoCoffee.Location = New Point(52, 51)
        radNoCoffee.Name = "radNoCoffee"
        radNoCoffee.Size = New Size(104, 36)
        radNoCoffee.TabIndex = 0
        radNoCoffee.Text = "None"
        radNoCoffee.UseVisualStyleBackColor = True
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(113, 987)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(200, 82)
        btnCalculate.TabIndex = 6
        btnCalculate.Text = "&Calculate Total"
        ToolTip1.SetToolTip(btnCalculate, "Click here to calculate the total of the order.")
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(407, 987)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(200, 82)
        btnReset.TabIndex = 7
        btnReset.Text = "&Reset Form"
        ToolTip1.SetToolTip(btnReset, "Click here to clear the form and start over.")
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(694, 987)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(200, 82)
        btnExit.TabIndex = 8
        btnExit.Text = "E&xit"
        ToolTip1.SetToolTip(btnExit, "Click here to exit.")
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(lblTotal)
        GroupBox4.Controls.Add(lblTax)
        GroupBox4.Controls.Add(lblSubtotal)
        GroupBox4.Controls.Add(Label4)
        GroupBox4.Controls.Add(Label3)
        GroupBox4.Controls.Add(Label2)
        GroupBox4.Location = New Point(31, 31)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(385, 255)
        GroupBox4.TabIndex = 4
        GroupBox4.TabStop = False
        GroupBox4.Text = "Price"
        ' 
        ' lblTotal
        ' 
        lblTotal.BorderStyle = BorderStyle.Fixed3D
        lblTotal.Location = New Point(175, 164)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(170, 40)
        lblTotal.TabIndex = 5
        ' 
        ' lblTax
        ' 
        lblTax.BorderStyle = BorderStyle.Fixed3D
        lblTax.Location = New Point(175, 114)
        lblTax.Name = "lblTax"
        lblTax.Size = New Size(170, 40)
        lblTax.TabIndex = 4
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.BorderStyle = BorderStyle.Fixed3D
        lblSubtotal.Location = New Point(175, 60)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(170, 40)
        lblSubtotal.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(86, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 32)
        Label4.TabIndex = 2
        Label4.Text = "Total"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(104, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 32)
        Label3.TabIndex = 1
        Label3.Text = "Tax"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 32)
        Label2.TabIndex = 0
        Label2.Text = "Subtotal"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveCaption
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(GroupBox4)
        Panel3.Location = New Point(530, 617)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(445, 312)
        Panel3.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1008, 1117)
        Controls.Add(btnExit)
        Controls.Add(btnReset)
        Controls.Add(btnCalculate)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        Panel1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radWheat As RadioButton
    Friend WithEvents radWhite As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkPeach As CheckBox
    Friend WithEvents chkRaspberry As CheckBox
    Friend WithEvents chkBlueberry As CheckBox
    Friend WithEvents chkButter As CheckBox
    Friend WithEvents chkCreamCheese As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents radCafeAuLait As RadioButton
    Friend WithEvents radCappuccino As RadioButton
    Friend WithEvents radRegCoffee As RadioButton
    Friend WithEvents radNoCoffee As RadioButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button

End Class
