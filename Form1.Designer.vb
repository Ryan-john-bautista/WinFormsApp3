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
        lb1 = New Label()
        lb2 = New Label()
        lb3 = New Label()
        ck1 = New CheckBox()
        ck2 = New CheckBox()
        ck3 = New CheckBox()
        cb1 = New ComboBox()
        gb1 = New GroupBox()
        rb1 = New RadioButton()
        rb2 = New RadioButton()
        btn1 = New Button()
        gb1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lb1
        ' 
        lb1.AutoSize = True
        lb1.Location = New Point(143, 149)
        lb1.Name = "lb1"
        lb1.Size = New Size(47, 15)
        lb1.TabIndex = 0
        lb1.Text = "Course:"
        ' 
        ' lb2
        ' 
        lb2.AutoSize = True
        lb2.Location = New Point(348, 149)
        lb2.Name = "lb2"
        lb2.Size = New Size(54, 15)
        lb2.TabIndex = 1
        lb2.Text = "Hobbies:"
        ' 
        ' lb3
        ' 
        lb3.AutoSize = True
        lb3.Location = New Point(597, 149)
        lb3.Name = "lb3"
        lb3.Size = New Size(48, 15)
        lb3.TabIndex = 2
        lb3.Text = "Gender:"
        ' 
        ' ck1
        ' 
        ck1.AutoSize = True
        ck1.Location = New Point(178, 101)
        ck1.Name = "ck1"
        ck1.Size = New Size(59, 19)
        ck1.TabIndex = 3
        ck1.Text = "Sports"
        ck1.UseVisualStyleBackColor = True
        ' 
        ' ck2
        ' 
        ck2.AutoSize = True
        ck2.Location = New Point(336, 101)
        ck2.Name = "ck2"
        ck2.Size = New Size(69, 19)
        ck2.TabIndex = 4
        ck2.Text = "Reading"
        ck2.UseVisualStyleBackColor = True
        ' 
        ' ck3
        ' 
        ck3.AutoSize = True
        ck3.Location = New Point(541, 101)
        ck3.Name = "ck3"
        ck3.Size = New Size(58, 19)
        ck3.TabIndex = 5
        ck3.Text = "Music"
        ck3.UseVisualStyleBackColor = True
        ' 
        ' cb1
        ' 
        cb1.DropDownStyle = ComboBoxStyle.DropDownList
        cb1.FormattingEnabled = True
        cb1.Items.AddRange(New Object() {"BSIT", "BSA", "BECED", "BSOA", "BSHM", "BSCS"})
        cb1.Location = New Point(336, 41)
        cb1.Name = "cb1"
        cb1.Size = New Size(121, 23)
        cb1.TabIndex = 6
        ' 
        ' gb1
        ' 
        gb1.Controls.Add(rb2)
        gb1.Controls.Add(rb1)
        gb1.Location = New Point(302, 180)
        gb1.Name = "gb1"
        gb1.Size = New Size(200, 100)
        gb1.TabIndex = 7
        gb1.TabStop = False
        gb1.Text = "GroupBox1"
        ' 
        ' rb1
        ' 
        rb1.AutoSize = True
        rb1.Location = New Point(27, 19)
        rb1.Name = "rb1"
        rb1.Size = New Size(51, 19)
        rb1.TabIndex = 0
        rb1.TabStop = True
        rb1.Text = "Male"
        rb1.UseVisualStyleBackColor = True
        ' 
        ' rb2
        ' 
        rb2.AutoSize = True
        rb2.Location = New Point(27, 44)
        rb2.Name = "rb2"
        rb2.Size = New Size(63, 19)
        rb2.TabIndex = 1
        rb2.TabStop = True
        rb2.Text = "Female"
        rb2.UseVisualStyleBackColor = True
        ' 
        ' btn1
        ' 
        btn1.Location = New Point(361, 292)
        btn1.Name = "btn1"
        btn1.Size = New Size(75, 23)
        btn1.TabIndex = 8
        btn1.Text = "Show Result"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn1)
        Controls.Add(gb1)
        Controls.Add(cb1)
        Controls.Add(ck3)
        Controls.Add(ck2)
        Controls.Add(ck1)
        Controls.Add(lb3)
        Controls.Add(lb2)
        Controls.Add(lb1)
        Name = "Form1"
        Text = "Form1"
        gb1.ResumeLayout(False)
        gb1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lb1 As Label
    Friend WithEvents lb2 As Label
    Friend WithEvents lb3 As Label
    Friend WithEvents ck1 As CheckBox
    Friend WithEvents ck2 As CheckBox
    Friend WithEvents ck3 As CheckBox
    Friend WithEvents cb1 As ComboBox
    Friend WithEvents gb1 As GroupBox
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents btn1 As Button

End Class
