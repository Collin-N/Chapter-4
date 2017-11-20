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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBPineapple = New System.Windows.Forms.RadioButton()
        Me.RBCheesePizza = New System.Windows.Forms.RadioButton()
        Me.RBPepperoni = New System.Windows.Forms.RadioButton()
        Me.RBSausage = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RBCheese = New System.Windows.Forms.RadioButton()
        Me.RBBaconFlakes = New System.Windows.Forms.RadioButton()
        Me.RBGoldShaveings = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CBBreadSticks = New System.Windows.Forms.CheckBox()
        Me.CBCheeseSticks = New System.Windows.Forms.CheckBox()
        Me.CBCheese = New System.Windows.Forms.CheckBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBPineapple)
        Me.GroupBox1.Controls.Add(Me.RBCheesePizza)
        Me.GroupBox1.Controls.Add(Me.RBPepperoni)
        Me.GroupBox1.Controls.Add(Me.RBSausage)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select your pizza"
        '
        'RBPineapple
        '
        Me.RBPineapple.AutoSize = True
        Me.RBPineapple.Location = New System.Drawing.Point(6, 93)
        Me.RBPineapple.Name = "RBPineapple"
        Me.RBPineapple.Size = New System.Drawing.Size(71, 17)
        Me.RBPineapple.TabIndex = 6
        Me.RBPineapple.TabStop = True
        Me.RBPineapple.Text = "pineapple"
        Me.RBPineapple.UseVisualStyleBackColor = True
        '
        'RBCheesePizza
        '
        Me.RBCheesePizza.AutoSize = True
        Me.RBCheesePizza.Location = New System.Drawing.Point(6, 19)
        Me.RBCheesePizza.Name = "RBCheesePizza"
        Me.RBCheesePizza.Size = New System.Drawing.Size(64, 17)
        Me.RBCheesePizza.TabIndex = 2
        Me.RBCheesePizza.TabStop = True
        Me.RBCheesePizza.Text = "Cheese "
        Me.RBCheesePizza.UseVisualStyleBackColor = True
        '
        'RBPepperoni
        '
        Me.RBPepperoni.AutoSize = True
        Me.RBPepperoni.Location = New System.Drawing.Point(6, 47)
        Me.RBPepperoni.Name = "RBPepperoni"
        Me.RBPepperoni.Size = New System.Drawing.Size(73, 17)
        Me.RBPepperoni.TabIndex = 1
        Me.RBPepperoni.TabStop = True
        Me.RBPepperoni.Text = "Pepperoni"
        Me.RBPepperoni.UseVisualStyleBackColor = True
        '
        'RBSausage
        '
        Me.RBSausage.AutoSize = True
        Me.RBSausage.Location = New System.Drawing.Point(6, 70)
        Me.RBSausage.Name = "RBSausage"
        Me.RBSausage.Size = New System.Drawing.Size(65, 17)
        Me.RBSausage.TabIndex = 3
        Me.RBSausage.TabStop = True
        Me.RBSausage.Text = "sausage"
        Me.RBSausage.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RBCheese)
        Me.GroupBox2.Controls.Add(Me.RBBaconFlakes)
        Me.GroupBox2.Controls.Add(Me.RBGoldShaveings)
        Me.GroupBox2.Location = New System.Drawing.Point(320, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 128)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'RBCheese
        '
        Me.RBCheese.AutoSize = True
        Me.RBCheese.Location = New System.Drawing.Point(9, 93)
        Me.RBCheese.Name = "RBCheese"
        Me.RBCheese.Size = New System.Drawing.Size(88, 17)
        Me.RBCheese.TabIndex = 7
        Me.RBCheese.TabStop = True
        Me.RBCheese.Text = "More Cheese"
        Me.RBCheese.UseVisualStyleBackColor = True
        '
        'RBBaconFlakes
        '
        Me.RBBaconFlakes.AutoSize = True
        Me.RBBaconFlakes.Location = New System.Drawing.Point(6, 19)
        Me.RBBaconFlakes.Name = "RBBaconFlakes"
        Me.RBBaconFlakes.Size = New System.Drawing.Size(86, 17)
        Me.RBBaconFlakes.TabIndex = 4
        Me.RBBaconFlakes.TabStop = True
        Me.RBBaconFlakes.Text = "bacon flakes"
        Me.RBBaconFlakes.UseVisualStyleBackColor = True
        '
        'RBGoldShaveings
        '
        Me.RBGoldShaveings.AutoSize = True
        Me.RBGoldShaveings.Location = New System.Drawing.Point(9, 55)
        Me.RBGoldShaveings.Name = "RBGoldShaveings"
        Me.RBGoldShaveings.Size = New System.Drawing.Size(96, 17)
        Me.RBGoldShaveings.TabIndex = 5
        Me.RBGoldShaveings.TabStop = True
        Me.RBGoldShaveings.Text = "gold shaveings"
        Me.RBGoldShaveings.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CBCheese)
        Me.GroupBox3.Controls.Add(Me.CBCheeseSticks)
        Me.GroupBox3.Controls.Add(Me.CBBreadSticks)
        Me.GroupBox3.Location = New System.Drawing.Point(329, 220)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'CBBreadSticks
        '
        Me.CBBreadSticks.AutoSize = True
        Me.CBBreadSticks.Location = New System.Drawing.Point(6, 19)
        Me.CBBreadSticks.Name = "CBBreadSticks"
        Me.CBBreadSticks.Size = New System.Drawing.Size(81, 17)
        Me.CBBreadSticks.TabIndex = 0
        Me.CBBreadSticks.Text = "Breadsticks"
        Me.CBBreadSticks.UseVisualStyleBackColor = True
        '
        'CBCheeseSticks
        '
        Me.CBCheeseSticks.AutoSize = True
        Me.CBCheeseSticks.Location = New System.Drawing.Point(6, 41)
        Me.CBCheeseSticks.Name = "CBCheeseSticks"
        Me.CBCheeseSticks.Size = New System.Drawing.Size(91, 17)
        Me.CBCheeseSticks.TabIndex = 1
        Me.CBCheeseSticks.Text = "cheese sticks"
        Me.CBCheeseSticks.UseVisualStyleBackColor = True
        '
        'CBCheese
        '
        Me.CBCheese.AutoSize = True
        Me.CBCheese.Location = New System.Drawing.Point(9, 64)
        Me.CBCheese.Name = "CBCheese"
        Me.CBCheese.Size = New System.Drawing.Size(117, 17)
        Me.CBCheese.TabIndex = 2
        Me.CBCheese.Text = "Even More Cheese"
        Me.CBCheese.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(32, 220)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(248, 66)
        Me.lblResult.TabIndex = 1
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(50, 315)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnOrder.TabIndex = 2
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(151, 315)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 361)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RBPineapple As System.Windows.Forms.RadioButton
    Friend WithEvents RBCheesePizza As System.Windows.Forms.RadioButton
    Friend WithEvents RBPepperoni As System.Windows.Forms.RadioButton
    Friend WithEvents RBSausage As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RBCheese As System.Windows.Forms.RadioButton
    Friend WithEvents RBBaconFlakes As System.Windows.Forms.RadioButton
    Friend WithEvents RBGoldShaveings As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CBCheese As System.Windows.Forms.CheckBox
    Friend WithEvents CBCheeseSticks As System.Windows.Forms.CheckBox
    Friend WithEvents CBBreadSticks As System.Windows.Forms.CheckBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnOrder As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
