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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radPizza = New System.Windows.Forms.RadioButton()
        Me.radBurger = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.radFries = New System.Windows.Forms.RadioButton()
        Me.radSalad = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.radCake = New System.Windows.Forms.RadioButton()
        Me.radIceCream = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkPercent = New System.Windows.Forms.CheckBox()
        Me.chkDiscount = New System.Windows.Forms.CheckBox()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.radBurger)
        Me.GroupBox1.Controls.Add(Me.radPizza)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(86, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mains"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.radSalad)
        Me.GroupBox2.Controls.Add(Me.radFries)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(480, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sides"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton3)
        Me.GroupBox3.Controls.Add(Me.radIceCream)
        Me.GroupBox3.Controls.Add(Me.radCake)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(874, 112)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Desserts"
        '
        'radPizza
        '
        Me.radPizza.AutoSize = True
        Me.radPizza.Location = New System.Drawing.Point(6, 19)
        Me.radPizza.Name = "radPizza"
        Me.radPizza.Size = New System.Drawing.Size(107, 20)
        Me.radPizza.TabIndex = 0
        Me.radPizza.TabStop = True
        Me.radPizza.Text = "Pizza ($10.50)"
        Me.radPizza.UseVisualStyleBackColor = True
        '
        'radBurger
        '
        Me.radBurger.AutoSize = True
        Me.radBurger.Location = New System.Drawing.Point(6, 42)
        Me.radBurger.Name = "radBurger"
        Me.radBurger.Size = New System.Drawing.Size(108, 20)
        Me.radBurger.TabIndex = 1
        Me.radBurger.TabStop = True
        Me.radBurger.Text = "Burger ($7.50)"
        Me.radBurger.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 65)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(59, 20)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "None"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'radFries
        '
        Me.radFries.AutoSize = True
        Me.radFries.Location = New System.Drawing.Point(6, 19)
        Me.radFries.Name = "radFries"
        Me.radFries.Size = New System.Drawing.Size(98, 20)
        Me.radFries.TabIndex = 1
        Me.radFries.TabStop = True
        Me.radFries.Text = "Fries ($5.49)"
        Me.radFries.UseVisualStyleBackColor = True
        '
        'radSalad
        '
        Me.radSalad.AutoSize = True
        Me.radSalad.Location = New System.Drawing.Point(6, 42)
        Me.radSalad.Name = "radSalad"
        Me.radSalad.Size = New System.Drawing.Size(104, 20)
        Me.radSalad.TabIndex = 2
        Me.radSalad.TabStop = True
        Me.radSalad.Text = "Salad ($5.49)"
        Me.radSalad.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 65)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(59, 20)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "None"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'radCake
        '
        Me.radCake.AutoSize = True
        Me.radCake.Location = New System.Drawing.Point(6, 19)
        Me.radCake.Name = "radCake"
        Me.radCake.Size = New System.Drawing.Size(107, 20)
        Me.radCake.TabIndex = 1
        Me.radCake.TabStop = True
        Me.radCake.Text = "Cake ($15.99)"
        Me.radCake.UseVisualStyleBackColor = True
        '
        'radIceCream
        '
        Me.radIceCream.AutoSize = True
        Me.radIceCream.Location = New System.Drawing.Point(6, 42)
        Me.radIceCream.Name = "radIceCream"
        Me.radIceCream.Size = New System.Drawing.Size(136, 20)
        Me.radIceCream.TabIndex = 2
        Me.radIceCream.TabStop = True
        Me.radIceCream.Text = "Ice Cream ($12.99)"
        Me.radIceCream.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 65)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(59, 20)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "None"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkDiscount)
        Me.GroupBox4.Controls.Add(Me.chkPercent)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(86, 254)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(988, 100)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Promotions"
        '
        'chkPercent
        '
        Me.chkPercent.AutoSize = True
        Me.chkPercent.Location = New System.Drawing.Point(303, 48)
        Me.chkPercent.Name = "chkPercent"
        Me.chkPercent.Size = New System.Drawing.Size(72, 20)
        Me.chkPercent.TabIndex = 0
        Me.chkPercent.Text = "10% Off"
        Me.chkPercent.UseVisualStyleBackColor = True
        '
        'chkDiscount
        '
        Me.chkDiscount.AutoSize = True
        Me.chkDiscount.Location = New System.Drawing.Point(523, 48)
        Me.chkDiscount.Name = "chkDiscount"
        Me.chkDiscount.Size = New System.Drawing.Size(126, 20)
        Me.chkDiscount.TabIndex = 1
        Me.chkDiscount.Text = "$2 off a meal $15"
        Me.chkDiscount.UseVisualStyleBackColor = True
        '
        'btnPay
        '
        Me.btnPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.Location = New System.Drawing.Point(452, 391)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(75, 23)
        Me.btnPay.TabIndex = 2
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(637, 391)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(72, 16)
        Me.lblPrice.TabIndex = 4
        Me.lblPrice.Text = "Cost: $0.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Restaurant"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 448)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents radBurger As System.Windows.Forms.RadioButton
    Friend WithEvents radPizza As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents radSalad As System.Windows.Forms.RadioButton
    Friend WithEvents radFries As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents radIceCream As System.Windows.Forms.RadioButton
    Friend WithEvents radCake As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkDiscount As System.Windows.Forms.CheckBox
    Friend WithEvents chkPercent As System.Windows.Forms.CheckBox
    Friend WithEvents btnPay As System.Windows.Forms.Button
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
