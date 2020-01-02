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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Franko = New System.Windows.Forms.TabPage
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.English = New System.Windows.Forms.TabPage
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.HScrollBar2 = New System.Windows.Forms.HScrollBar
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.Franko.SuspendLayout()
        Me.English.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Franko)
        Me.TabControl1.Controls.Add(Me.English)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(873, 751)
        Me.TabControl1.TabIndex = 0
        '
        'Franko
        '
        Me.Franko.BackColor = System.Drawing.SystemColors.Control
        Me.Franko.Controls.Add(Me.RichTextBox1)
        Me.Franko.Controls.Add(Me.Label4)
        Me.Franko.Controls.Add(Me.ComboBox2)
        Me.Franko.Controls.Add(Me.Label3)
        Me.Franko.Controls.Add(Me.HScrollBar1)
        Me.Franko.Controls.Add(Me.Label2)
        Me.Franko.Controls.Add(Me.Label1)
        Me.Franko.Controls.Add(Me.ComboBox1)
        Me.Franko.Controls.Add(Me.Button1)
        Me.Franko.Location = New System.Drawing.Point(4, 22)
        Me.Franko.Name = "Franko"
        Me.Franko.Padding = New System.Windows.Forms.Padding(3)
        Me.Franko.Size = New System.Drawing.Size(865, 725)
        Me.Franko.TabIndex = 0
        Me.Franko.Text = "فرانكو"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 51)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(853, 633)
        Me.RichTextBox1.TabIndex = 21
        Me.RichTextBox1.Text = "فايدة الجزء دا:" & Global.Microsoft.VisualBasic.ChrW(10) & "بيحول الكلام الفرانكو لعربي" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "شكرا لفارس الشربيني اللي عرفني القوا" & _
            "عد"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(137, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Back Color"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Red", "Green", "Blue", "Gray", "Black", "White"})
        Me.ComboBox2.Location = New System.Drawing.Point(213, 13)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(50, 21)
        Me.ComboBox2.TabIndex = 19
        Me.ComboBox2.Text = "White"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(732, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "                                            "
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(735, 13)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(124, 17)
        Me.HScrollBar1.TabIndex = 17
        Me.HScrollBar1.TabStop = True
        Me.HScrollBar1.Value = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(699, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Font"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Text Color"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Red", "Green", "Blue", "Black", "White"})
        Me.ComboBox1.Location = New System.Drawing.Point(79, 14)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(50, 21)
        Me.ComboBox1.TabIndex = 14
        Me.ComboBox1.Text = "Black"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(6, 690)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(853, 29)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "تحويل"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'English
        '
        Me.English.BackColor = System.Drawing.SystemColors.Control
        Me.English.Controls.Add(Me.RichTextBox2)
        Me.English.Controls.Add(Me.Label5)
        Me.English.Controls.Add(Me.ComboBox3)
        Me.English.Controls.Add(Me.Label6)
        Me.English.Controls.Add(Me.HScrollBar2)
        Me.English.Controls.Add(Me.Label7)
        Me.English.Controls.Add(Me.Label8)
        Me.English.Controls.Add(Me.ComboBox4)
        Me.English.Controls.Add(Me.Button2)
        Me.English.Location = New System.Drawing.Point(4, 22)
        Me.English.Name = "English"
        Me.English.Padding = New System.Windows.Forms.Padding(3)
        Me.English.Size = New System.Drawing.Size(865, 725)
        Me.English.TabIndex = 1
        Me.English.Text = "انجليزي"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(6, 51)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(853, 633)
        Me.RichTextBox2.TabIndex = 30
        Me.RichTextBox2.Text = "فايدة الجزء دا " & Global.Microsoft.VisualBasic.ChrW(10) & "لو انت بتكتب عربي و الكيبورد كان انجليزي دا بيحول الكتابة للعربي"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(137, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Back Color"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Red", "Green", "Blue", "Gray", "Black", "White"})
        Me.ComboBox3.Location = New System.Drawing.Point(213, 13)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(50, 21)
        Me.ComboBox3.TabIndex = 28
        Me.ComboBox3.Text = "White"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(732, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "                                            "
        '
        'HScrollBar2
        '
        Me.HScrollBar2.Location = New System.Drawing.Point(735, 13)
        Me.HScrollBar2.Name = "HScrollBar2"
        Me.HScrollBar2.Size = New System.Drawing.Size(124, 17)
        Me.HScrollBar2.TabIndex = 26
        Me.HScrollBar2.TabStop = True
        Me.HScrollBar2.Value = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(699, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 16)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Font"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 16)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Text Color"
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Red", "Green", "Blue", "Black", "White"})
        Me.ComboBox4.Location = New System.Drawing.Point(79, 14)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(50, 21)
        Me.ComboBox4.TabIndex = 23
        Me.ComboBox4.Text = "Black"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(6, 690)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(853, 29)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "تحويل"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 775)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Converter"
        Me.TabControl1.ResumeLayout(False)
        Me.Franko.ResumeLayout(False)
        Me.Franko.PerformLayout()
        Me.English.ResumeLayout(False)
        Me.English.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Franko As System.Windows.Forms.TabPage
    Friend WithEvents English As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents HScrollBar2 As System.Windows.Forms.HScrollBar
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
