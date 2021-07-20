Public Class Form1
    Dim no1 As Decimal
    Dim no2 As Decimal
    Dim op As Integer = 0 '8=add, 1=subtract, 2=multiply, 3=division, 4=square root, 5=square, 6=cube 7=cube root
    Dim result As Decimal
    Dim op_pressed As Boolean
    Dim subString As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles negate.Click
        If TextBox1.Text <> "0" Then
            If Not TextBox1.Text.Contains("-") Then
                TextBox1.Text = "-" + TextBox1.Text
            Else
                TextBox1.Text = Mid(TextBox1.Text, 2)
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Click on 'OK' to delete this app.")
    End Sub
    Private Sub one_Click(sender As Object, e As EventArgs) Handles one.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text = TextBox1.Text + "1"
        ElseIf TextBox1.Text = "0" Then
            TextBox1.Text = "1"
        End If
    End Sub

    Private Sub two_Click(sender As Object, e As EventArgs) Handles two.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text = TextBox1.Text + "2"
        ElseIf TextBox1.Text = "0" Then
            TextBox1.Text = "2"
        End If
    End Sub

    Private Sub three_Click(sender As Object, e As EventArgs) Handles three.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text = TextBox1.Text + "3"
        ElseIf TextBox1.Text = "0" Then
            TextBox1.Text = "3"
        End If
    End Sub

    Private Sub four_Click(sender As Object, e As EventArgs) Handles four.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text = TextBox1.Text + "4"
        ElseIf TextBox1.Text = "0" Then
            TextBox1.Text = "4"
        End If
    End Sub

    Private Sub five_Click(sender As Object, e As EventArgs) Handles five.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text = TextBox1.Text + "5"
        ElseIf TextBox1.Text = "0" Then
            TextBox1.Text = "5"
        End If
    End Sub

    Private Sub six_Click(sender As Object, e As EventArgs) Handles six.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text = TextBox1.Text + "6"
        ElseIf TextBox1.Text = "0" Then
            TextBox1.Text = "6"
        End If
    End Sub

    Private Sub seven_Click(sender As Object, e As EventArgs) Handles seven.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text = TextBox1.Text + "7"
        ElseIf TextBox1.Text = "0" Then
            TextBox1.Text = "7"
        End If
    End Sub

    Private Sub eight_Click(sender As Object, e As EventArgs) Handles eight.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text = TextBox1.Text + "8"
        ElseIf TextBox1.Text = "0" Then
            TextBox1.Text = "8"
        End If
    End Sub

    Private Sub nine_Click(sender As Object, e As EventArgs) Handles nine.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text = TextBox1.Text + "9"
        ElseIf TextBox1.Text = "0" Then
            TextBox1.Text = "9"
        End If
    End Sub

    Private Sub multiply_Click(sender As Object, e As EventArgs) Handles multiply.Click

    End Sub

    Private Sub inverse_Click(sender As Object, e As EventArgs) Handles inverse.Click

    End Sub

    Private Sub square_Click(sender As Object, e As EventArgs) Handles square.Click
        TextBox1.Text = TextBox1.Text * TextBox1.Text
    End Sub


    Private Sub division_Click(sender As Object, e As EventArgs) Handles division.Click

    End Sub

    Private Sub square_root_Click(sender As Object, e As EventArgs) Handles square_root.Click

    End Sub

    Private Sub decimal_point_Click(sender As Object, e As EventArgs) Handles decimal_point.Click
        If Not TextBox1.Text.Contains(".") Then
            TextBox1.Text = TextBox1.Text + "."
        End If
    End Sub

    Private Sub zero_Click(sender As Object, e As EventArgs) Handles zero.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text = TextBox1.Text + "0"
        End If
    End Sub

    Private Sub btn_backspace_Click(sender As Object, e As EventArgs) Handles btn_backspace.Click
        If TextBox1.Text.Length = 1 Then
            TextBox1.Text = "0"
        ElseIf TextBox1.Text.Length = 2 And TextBox1.Text.Contains("-") Then
            TextBox1.Text = "0"
        ElseIf TextBox1.Text <> "0" Then
            TextBox1.Text = Microsoft.VisualBasic.Strings.Left(TextBox1.Text, TextBox1.Text.Length - 1)
        End If
    End Sub

    Private Sub ce_Click(sender As Object, e As EventArgs) Handles ce.Click
        TextBox1.Text = "0"
    End Sub

    Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        TextBox1.Text = "0"
        If op_pressed = True Then
            calculate(no1, Val(TextBox1.Text), op)
        End If
        no1 = Val(TextBox1.Text)
        op = 8
        op_pressed = True
    End Sub

    Private Sub equal_to_sign_Click(sender As Object, e As EventArgs) Handles equal_to_sign.Click
        no2 = Val(TextBox1.Text)
        calculate(no1, no2, op)
    End Sub
    Private Sub calculate(digi1, digi2, oper)
        If oper = 8 Then
            TextBox1.Text = Val(digi1) + Val(digi2)
            no1 = TextBox1.Text
            op = 0
        End If
    End Sub

End Class
