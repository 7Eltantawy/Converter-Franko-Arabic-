Public Class Form1


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ''الحروف المركبة
        RichTextBox1.Text = RichTextBox1.Text.Replace("kh", "خ")
        RichTextBox1.Text = RichTextBox1.Text.Replace("sh", "ش")
        RichTextBox1.Text = RichTextBox1.Text.Replace("co", "كُ")
        RichTextBox1.Text = RichTextBox1.Text.Replace("Co", "كُ")
        RichTextBox1.Text = RichTextBox1.Text.Replace("3’", "غ")

        ''الارقام
        RichTextBox1.Text = RichTextBox1.Text.Replace("2", "ئ")
        RichTextBox1.Text = RichTextBox1.Text.Replace("3", "ع")
        RichTextBox1.Text = RichTextBox1.Text.Replace("4", "ش")
        RichTextBox1.Text = RichTextBox1.Text.Replace("5", "خ")
        RichTextBox1.Text = RichTextBox1.Text.Replace("6", "ت")
        RichTextBox1.Text = RichTextBox1.Text.Replace("7", "ح")
        RichTextBox1.Text = RichTextBox1.Text.Replace("8", "غ")
        RichTextBox1.Text = RichTextBox1.Text.Replace("9", "س")

        ''الحروف الصغيرة
        RichTextBox1.Text = RichTextBox1.Text.Replace("a", "ا")
        RichTextBox1.Text = RichTextBox1.Text.Replace("b", "ب")
        RichTextBox1.Text = RichTextBox1.Text.Replace("c", "س")
        RichTextBox1.Text = RichTextBox1.Text.Replace("d", "د")
        RichTextBox1.Text = RichTextBox1.Text.Replace("e", "ا")
        RichTextBox1.Text = RichTextBox1.Text.Replace("f", "ف")
        RichTextBox1.Text = RichTextBox1.Text.Replace("g", "ج")
        RichTextBox1.Text = RichTextBox1.Text.Replace("h", "ه")
        RichTextBox1.Text = RichTextBox1.Text.Replace("i", "ي")
        RichTextBox1.Text = RichTextBox1.Text.Replace("j", "ع")
        RichTextBox1.Text = RichTextBox1.Text.Replace("k", "ك")
        RichTextBox1.Text = RichTextBox1.Text.Replace("l", "ل")
        RichTextBox1.Text = RichTextBox1.Text.Replace("m", "م")
        RichTextBox1.Text = RichTextBox1.Text.Replace("n", "ن")
        RichTextBox1.Text = RichTextBox1.Text.Replace("o", "و")
        RichTextBox1.Text = RichTextBox1.Text.Replace("p", "ب")
        RichTextBox1.Text = RichTextBox1.Text.Replace("q", "ك")
        RichTextBox1.Text = RichTextBox1.Text.Replace("r", "ر")
        RichTextBox1.Text = RichTextBox1.Text.Replace("s", "س")
        RichTextBox1.Text = RichTextBox1.Text.Replace("t", "ت")
        RichTextBox1.Text = RichTextBox1.Text.Replace("u", "ع")
        RichTextBox1.Text = RichTextBox1.Text.Replace("v", "ف")
        RichTextBox1.Text = RichTextBox1.Text.Replace("w", "و")
        RichTextBox1.Text = RichTextBox1.Text.Replace("x", "ع")
        RichTextBox1.Text = RichTextBox1.Text.Replace("y", "ي")
        RichTextBox1.Text = RichTextBox1.Text.Replace("z", "ز")

        ''الحروف الكبيرة
        RichTextBox1.Text = RichTextBox1.Text.Replace("A", "ا")
        RichTextBox1.Text = RichTextBox1.Text.Replace("B", "ب")
        RichTextBox1.Text = RichTextBox1.Text.Replace("C", "س")
        RichTextBox1.Text = RichTextBox1.Text.Replace("D", "ض")
        RichTextBox1.Text = RichTextBox1.Text.Replace("E", "ا")
        RichTextBox1.Text = RichTextBox1.Text.Replace("F", "ف")
        RichTextBox1.Text = RichTextBox1.Text.Replace("G", "ج")
        RichTextBox1.Text = RichTextBox1.Text.Replace("H", "ح")
        RichTextBox1.Text = RichTextBox1.Text.Replace("I", "ي")
        RichTextBox1.Text = RichTextBox1.Text.Replace("J", "ع")
        RichTextBox1.Text = RichTextBox1.Text.Replace("K", "ك")
        RichTextBox1.Text = RichTextBox1.Text.Replace("L", "ل")
        RichTextBox1.Text = RichTextBox1.Text.Replace("M", "م")
        RichTextBox1.Text = RichTextBox1.Text.Replace("N", "ن")
        RichTextBox1.Text = RichTextBox1.Text.Replace("O", "و")
        RichTextBox1.Text = RichTextBox1.Text.Replace("P", "ب")
        RichTextBox1.Text = RichTextBox1.Text.Replace("Q", "ك")
        RichTextBox1.Text = RichTextBox1.Text.Replace("R", "ر")
        RichTextBox1.Text = RichTextBox1.Text.Replace("S", "ص")
        RichTextBox1.Text = RichTextBox1.Text.Replace("T", "ت")
        RichTextBox1.Text = RichTextBox1.Text.Replace("U", "ع")
        RichTextBox1.Text = RichTextBox1.Text.Replace("V", "ف")
        RichTextBox1.Text = RichTextBox1.Text.Replace("W", "و")
        RichTextBox1.Text = RichTextBox1.Text.Replace("X", "ع")
        RichTextBox1.Text = RichTextBox1.Text.Replace("Y", "ي")
        RichTextBox1.Text = RichTextBox1.Text.Replace("Z", "ز")

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.Text = "Red" Then
            RichTextBox1.ForeColor = Color.Red
        ElseIf ComboBox1.Text = "Green" Then
            RichTextBox1.ForeColor = Color.Green
        ElseIf ComboBox1.Text = "Yellow" Then
            RichTextBox1.ForeColor = Color.Yellow
        ElseIf ComboBox1.Text = "Blue" Then
            RichTextBox1.ForeColor = Color.Blue
        ElseIf ComboBox1.Text = "Black" Then
            RichTextBox1.ForeColor = Color.Black
        ElseIf ComboBox1.Text = "White" Then
            RichTextBox1.ForeColor = Color.White
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

        If ComboBox2.Text = "Red" Then
            RichTextBox1.BackColor = Color.Red
        ElseIf ComboBox2.Text = "Green" Then
            RichTextBox1.BackColor = Color.Green
        ElseIf ComboBox2.Text = "Yellow" Then
            RichTextBox1.BackColor = Color.Yellow
        ElseIf ComboBox2.Text = "Blue" Then
            RichTextBox1.BackColor = Color.Blue
        ElseIf ComboBox2.Text = "Black" Then
            RichTextBox1.BackColor = Color.Black
        ElseIf ComboBox2.Text = "Gray" Then
            RichTextBox1.BackColor = Color.Gray
        ElseIf ComboBox2.Text = "White" Then
            RichTextBox1.BackColor = Color.White

        End If
    End Sub

    Private Sub HScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar1.Scroll

        RichTextBox1.Font = New System.Drawing.Font(" Tahoma", HScrollBar1.Value + 1, FontStyle.Regular)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        RichTextBox2.Text = RichTextBox2.Text.Replace("`", "ذ")
        RichTextBox2.Text = RichTextBox2.Text.Replace("q", "ض")
        RichTextBox2.Text = RichTextBox2.Text.Replace("w", "ص")
        RichTextBox2.Text = RichTextBox2.Text.Replace("e", "ث")
        RichTextBox2.Text = RichTextBox2.Text.Replace("r", "ق")
        RichTextBox2.Text = RichTextBox2.Text.Replace("t", "ف")
        RichTextBox2.Text = RichTextBox2.Text.Replace("y", "غ")
        RichTextBox2.Text = RichTextBox2.Text.Replace("u", "ع")
        RichTextBox2.Text = RichTextBox2.Text.Replace("i", "ه")
        RichTextBox2.Text = RichTextBox2.Text.Replace("o", "خ")
        RichTextBox2.Text = RichTextBox2.Text.Replace("p", "ح")
        RichTextBox2.Text = RichTextBox2.Text.Replace("[", "ج")
        RichTextBox2.Text = RichTextBox2.Text.Replace("]", "د")
        RichTextBox2.Text = RichTextBox2.Text.Replace("'", "ط")
        RichTextBox2.Text = RichTextBox2.Text.Replace(";", "ك")
        RichTextBox2.Text = RichTextBox2.Text.Replace("l", "م")
        RichTextBox2.Text = RichTextBox2.Text.Replace("k", "ن")
        RichTextBox2.Text = RichTextBox2.Text.Replace("j", "ت")
        RichTextBox2.Text = RichTextBox2.Text.Replace("h", "ا")
        RichTextBox2.Text = RichTextBox2.Text.Replace("g", "ل")
        RichTextBox2.Text = RichTextBox2.Text.Replace("f", "ب")
        RichTextBox2.Text = RichTextBox2.Text.Replace("d", "ي")
        RichTextBox2.Text = RichTextBox2.Text.Replace("s", "س")
        RichTextBox2.Text = RichTextBox2.Text.Replace("a", "ش")
        RichTextBox2.Text = RichTextBox2.Text.Replace("/", "ظ")
        RichTextBox2.Text = RichTextBox2.Text.Replace(".", "ز")
        RichTextBox2.Text = RichTextBox2.Text.Replace(",", "و")
        RichTextBox2.Text = RichTextBox2.Text.Replace("m", "ة")
        RichTextBox2.Text = RichTextBox2.Text.Replace("n", "ى")
        RichTextBox2.Text = RichTextBox2.Text.Replace("b", "لا")
        RichTextBox2.Text = RichTextBox2.Text.Replace("v", "ر")
        RichTextBox2.Text = RichTextBox2.Text.Replace("c", "ؤ")
        RichTextBox2.Text = RichTextBox2.Text.Replace("x", "ء")
        RichTextBox2.Text = RichTextBox2.Text.Replace("z", "ئ") '''''
        RichTextBox2.Text = RichTextBox2.Text.Replace("T", "لإ")
        RichTextBox2.Text = RichTextBox2.Text.Replace("Y", "إ")
        RichTextBox2.Text = RichTextBox2.Text.Replace("H", "أ")
        RichTextBox2.Text = RichTextBox2.Text.Replace("G", "لأ")
        RichTextBox2.Text = RichTextBox2.Text.Replace("N", "آ")
        RichTextBox2.Text = RichTextBox2.Text.Replace("B", "لآ")
        RichTextBox2.Text = RichTextBox2.Text.Replace("Z", "ْ~")
      
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox4.Text = "Red" Then
            RichTextBox2.ForeColor = Color.Red
        ElseIf ComboBox4.Text = "Green" Then
            RichTextBox2.ForeColor = Color.Green
        ElseIf ComboBox4.Text = "Yellow" Then
            RichTextBox2.ForeColor = Color.Yellow
        ElseIf ComboBox4.Text = "Blue" Then
            RichTextBox2.ForeColor = Color.Blue
        ElseIf ComboBox4.Text = "Black" Then
            RichTextBox2.ForeColor = Color.Black
        ElseIf ComboBox4.Text = "White" Then
            RichTextBox2.ForeColor = Color.White
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.Text = "Red" Then
            RichTextBox2.BackColor = Color.Red
        ElseIf ComboBox3.Text = "Green" Then
            RichTextBox2.BackColor = Color.Green
        ElseIf ComboBox3.Text = "Yellow" Then
            RichTextBox2.BackColor = Color.Yellow
        ElseIf ComboBox3.Text = "Blue" Then
            RichTextBox2.BackColor = Color.Blue
        ElseIf ComboBox3.Text = "Black" Then
            RichTextBox2.BackColor = Color.Black
        ElseIf ComboBox3.Text = "Gray" Then
            RichTextBox2.BackColor = Color.Gray
        ElseIf ComboBox3.Text = "White" Then
            RichTextBox2.BackColor = Color.White
        End If
    End Sub

    Private Sub HScrollBar2_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar2.Scroll
        RichTextBox2.Font = New System.Drawing.Font(" Tahoma", HScrollBar2.Value + 1, FontStyle.Regular)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HScrollBar2.Value = RichTextBox2.Font.Size
        HScrollBar1.Value = RichTextBox1.Font.Size
    End Sub
End Class
