<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SNACKS
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
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.springrolls = New System.Windows.Forms.PictureBox()
        Me.greekyogurt = New System.Windows.Forms.PictureBox()
        Me.falafel = New System.Windows.Forms.PictureBox()
        Me.burrito = New System.Windows.Forms.PictureBox()
        Me.confirmation = New System.Windows.Forms.Button()
        Me.clearburrito = New System.Windows.Forms.Button()
        Me.clearfalafel = New System.Windows.Forms.Button()
        Me.clearyogurt = New System.Windows.Forms.Button()
        Me.clearrolls = New System.Windows.Forms.Button()
        Me.snackselection = New System.Windows.Forms.Label()
        Me.lblburrito = New System.Windows.Forms.Label()
        Me.lblfalafel = New System.Windows.Forms.Label()
        Me.lblyogurt = New System.Windows.Forms.Label()
        Me.lblrolls = New System.Windows.Forms.Label()
        Me.Displaymnu = New System.Windows.Forms.Label()
        Me.btnexit = New System.Windows.Forms.Button()
        CType(Me.springrolls, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.greekyogurt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.falafel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.burrito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'springrolls
        '
        Me.springrolls.Image = Global.CH3EX3homework.My.Resources.Resources.Spring_Rolls
        Me.springrolls.Location = New System.Drawing.Point(507, 99)
        Me.springrolls.Name = "springrolls"
        Me.springrolls.Size = New System.Drawing.Size(139, 97)
        Me.springrolls.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.springrolls.TabIndex = 3
        Me.springrolls.TabStop = False
        Me.ToolTip1.SetToolTip(Me.springrolls, "Click Me To Order")
        '
        'greekyogurt
        '
        Me.greekyogurt.Image = Global.CH3EX3homework.My.Resources.Resources.Greek_yogurt
        Me.greekyogurt.Location = New System.Drawing.Point(350, 99)
        Me.greekyogurt.Name = "greekyogurt"
        Me.greekyogurt.Size = New System.Drawing.Size(139, 97)
        Me.greekyogurt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.greekyogurt.TabIndex = 2
        Me.greekyogurt.TabStop = False
        Me.ToolTip1.SetToolTip(Me.greekyogurt, "Click Me To Order")
        '
        'falafel
        '
        Me.falafel.Image = Global.CH3EX3homework.My.Resources.Resources.Falafel
        Me.falafel.Location = New System.Drawing.Point(193, 99)
        Me.falafel.Name = "falafel"
        Me.falafel.Size = New System.Drawing.Size(139, 97)
        Me.falafel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.falafel.TabIndex = 1
        Me.falafel.TabStop = False
        Me.ToolTip1.SetToolTip(Me.falafel, "Click Me To Order")
        '
        'burrito
        '
        Me.burrito.Image = Global.CH3EX3homework.My.Resources.Resources.bean_burrito
        Me.burrito.Location = New System.Drawing.Point(36, 99)
        Me.burrito.Name = "burrito"
        Me.burrito.Size = New System.Drawing.Size(139, 97)
        Me.burrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.burrito.TabIndex = 0
        Me.burrito.TabStop = False
        Me.ToolTip1.SetToolTip(Me.burrito, "Click Me To Order")
        '
        'confirmation
        '
        Me.confirmation.BackColor = System.Drawing.Color.LimeGreen
        Me.confirmation.Enabled = False
        Me.confirmation.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmation.ForeColor = System.Drawing.Color.White
        Me.confirmation.Location = New System.Drawing.Point(350, 403)
        Me.confirmation.Name = "confirmation"
        Me.confirmation.Size = New System.Drawing.Size(145, 53)
        Me.confirmation.TabIndex = 10
        Me.confirmation.Text = "confirmation"
        Me.ToolTip1.SetToolTip(Me.confirmation, "confirm your order")
        Me.confirmation.UseVisualStyleBackColor = False
        '
        'clearburrito
        '
        Me.clearburrito.BackColor = System.Drawing.Color.Red
        Me.clearburrito.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearburrito.ForeColor = System.Drawing.Color.White
        Me.clearburrito.Location = New System.Drawing.Point(38, 266)
        Me.clearburrito.Name = "clearburrito"
        Me.clearburrito.Size = New System.Drawing.Size(120, 36)
        Me.clearburrito.TabIndex = 11
        Me.clearburrito.Text = "clear burrito"
        Me.ToolTip1.SetToolTip(Me.clearburrito, "clear your order")
        Me.clearburrito.UseVisualStyleBackColor = False
        '
        'clearfalafel
        '
        Me.clearfalafel.BackColor = System.Drawing.Color.Red
        Me.clearfalafel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearfalafel.ForeColor = System.Drawing.Color.White
        Me.clearfalafel.Location = New System.Drawing.Point(200, 266)
        Me.clearfalafel.Name = "clearfalafel"
        Me.clearfalafel.Size = New System.Drawing.Size(120, 36)
        Me.clearfalafel.TabIndex = 12
        Me.clearfalafel.Text = "Clear Falafel"
        Me.ToolTip1.SetToolTip(Me.clearfalafel, "clear your order")
        Me.clearfalafel.UseVisualStyleBackColor = False
        '
        'clearyogurt
        '
        Me.clearyogurt.BackColor = System.Drawing.Color.Red
        Me.clearyogurt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearyogurt.ForeColor = System.Drawing.Color.White
        Me.clearyogurt.Location = New System.Drawing.Point(362, 266)
        Me.clearyogurt.Name = "clearyogurt"
        Me.clearyogurt.Size = New System.Drawing.Size(120, 36)
        Me.clearyogurt.TabIndex = 13
        Me.clearyogurt.Text = "Clear Yogurt"
        Me.ToolTip1.SetToolTip(Me.clearyogurt, "clear your order")
        Me.clearyogurt.UseVisualStyleBackColor = False
        '
        'clearrolls
        '
        Me.clearrolls.BackColor = System.Drawing.Color.Red
        Me.clearrolls.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearrolls.ForeColor = System.Drawing.Color.White
        Me.clearrolls.Location = New System.Drawing.Point(524, 266)
        Me.clearrolls.Name = "clearrolls"
        Me.clearrolls.Size = New System.Drawing.Size(120, 36)
        Me.clearrolls.TabIndex = 14
        Me.clearrolls.Text = "Clear Rolls"
        Me.ToolTip1.SetToolTip(Me.clearrolls, "clear your order")
        Me.clearrolls.UseVisualStyleBackColor = False
        '
        'snackselection
        '
        Me.snackselection.AutoSize = True
        Me.snackselection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.snackselection.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.snackselection.ForeColor = System.Drawing.Color.White
        Me.snackselection.Location = New System.Drawing.Point(166, 40)
        Me.snackselection.Name = "snackselection"
        Me.snackselection.Size = New System.Drawing.Size(352, 34)
        Me.snackselection.TabIndex = 4
        Me.snackselection.Text = "Healthy Snack Selection"
        '
        'lblburrito
        '
        Me.lblburrito.AutoSize = True
        Me.lblburrito.Location = New System.Drawing.Point(99, 213)
        Me.lblburrito.Name = "lblburrito"
        Me.lblburrito.Size = New System.Drawing.Size(0, 17)
        Me.lblburrito.TabIndex = 5
        '
        'lblfalafel
        '
        Me.lblfalafel.AutoSize = True
        Me.lblfalafel.Location = New System.Drawing.Point(255, 213)
        Me.lblfalafel.Name = "lblfalafel"
        Me.lblfalafel.Size = New System.Drawing.Size(0, 17)
        Me.lblfalafel.TabIndex = 6
        '
        'lblyogurt
        '
        Me.lblyogurt.AutoSize = True
        Me.lblyogurt.Location = New System.Drawing.Point(411, 213)
        Me.lblyogurt.Name = "lblyogurt"
        Me.lblyogurt.Size = New System.Drawing.Size(0, 17)
        Me.lblyogurt.TabIndex = 7
        '
        'lblrolls
        '
        Me.lblrolls.AutoSize = True
        Me.lblrolls.Location = New System.Drawing.Point(567, 213)
        Me.lblrolls.Name = "lblrolls"
        Me.lblrolls.Size = New System.Drawing.Size(0, 17)
        Me.lblrolls.TabIndex = 8
        '
        'Displaymnu
        '
        Me.Displaymnu.AutoSize = True
        Me.Displaymnu.Location = New System.Drawing.Point(99, 390)
        Me.Displaymnu.Name = "Displaymnu"
        Me.Displaymnu.Size = New System.Drawing.Size(0, 17)
        Me.Displaymnu.TabIndex = 9
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnexit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.White
        Me.btnexit.Location = New System.Drawing.Point(539, 506)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(82, 35)
        Me.btnexit.TabIndex = 15
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'SNACKS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(682, 553)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.clearrolls)
        Me.Controls.Add(Me.clearyogurt)
        Me.Controls.Add(Me.clearfalafel)
        Me.Controls.Add(Me.clearburrito)
        Me.Controls.Add(Me.confirmation)
        Me.Controls.Add(Me.Displaymnu)
        Me.Controls.Add(Me.lblrolls)
        Me.Controls.Add(Me.lblyogurt)
        Me.Controls.Add(Me.lblfalafel)
        Me.Controls.Add(Me.lblburrito)
        Me.Controls.Add(Me.snackselection)
        Me.Controls.Add(Me.springrolls)
        Me.Controls.Add(Me.greekyogurt)
        Me.Controls.Add(Me.falafel)
        Me.Controls.Add(Me.burrito)
        Me.Name = "SNACKS"
        Me.Text = "Healthy Snacks"
        CType(Me.springrolls, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.greekyogurt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.falafel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.burrito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents burrito As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents falafel As PictureBox
    Friend WithEvents greekyogurt As PictureBox
    Friend WithEvents springrolls As PictureBox
    Friend WithEvents snackselection As Label
    Friend WithEvents lblburrito As Label
    Friend WithEvents lblfalafel As Label
    Friend WithEvents lblyogurt As Label
    Friend WithEvents lblrolls As Label
    Friend WithEvents Displaymnu As Label
    Friend WithEvents confirmation As Button
    Friend WithEvents clearburrito As Button
    Friend WithEvents clearfalafel As Button
    Friend WithEvents clearyogurt As Button
    Friend WithEvents clearrolls As Button
    Friend WithEvents btnexit As Button
End Class
