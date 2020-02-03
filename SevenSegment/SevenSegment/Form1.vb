Public Class Form1

    Dim counter As Byte = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim btn1 As Button = Button1

        If Button1.Text = "Start" Then

            Timer1.Start()
            Button1.Text = "Stop"
            btn1.BackColor = Color.Red

        ElseIf Button1.Text = "Stop" Then

            Timer1.Stop()
            counter += 0
            Button1.Text = "Start"
            btn1.BackColor = Color.Green

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        counter += 1

        If counter = 1 Then

            lbl1.BackColor = Color.Blue
            lbl2.BackColor = Color.Blue
            lbl3.BackColor = Color.Blue
            lbl4.BackColor = Color.Blue
            lbl5.BackColor = Color.Blue
            lbl6.BackColor = Color.Blue
            lbl7.BackColor = Color.LightGray
            lbl8.BackColor = Color.LightGray

        ElseIf counter = 2 Then

            lbl1.BackColor = Color.LightGray
            lbl2.BackColor = Color.Blue
            lbl3.BackColor = Color.Blue
            lbl4.BackColor = Color.LightGray
            lbl5.BackColor = Color.LightGray
            lbl6.BackColor = Color.LightGray
            lbl7.BackColor = Color.LightGray
            lbl8.BackColor = Color.LightGray

        ElseIf counter = 3 Then

            lbl1.BackColor = Color.Blue
            lbl2.BackColor = Color.Blue
            lbl3.BackColor = Color.LightGray
            lbl4.BackColor = Color.Blue
            lbl5.BackColor = Color.Blue
            lbl6.BackColor = Color.LightGray
            lbl7.BackColor = Color.Blue
            lbl8.BackColor = Color.LightGray

        ElseIf counter = 4 Then

            lbl1.BackColor = Color.Blue
            lbl2.BackColor = Color.Blue
            lbl3.BackColor = Color.Blue
            lbl4.BackColor = Color.Blue
            lbl5.BackColor = Color.LightGray
            lbl6.BackColor = Color.LightGray
            lbl7.BackColor = Color.Blue
            lbl8.BackColor = Color.LightGray

        ElseIf counter = 5 Then

            lbl1.BackColor = Color.LightGray
            lbl2.BackColor = Color.Blue
            lbl3.BackColor = Color.Blue
            lbl4.BackColor = Color.LightGray
            lbl5.BackColor = Color.LightGray
            lbl6.BackColor = Color.Blue
            lbl7.BackColor = Color.Blue
            lbl8.BackColor = Color.LightGray

        ElseIf counter = 6 Then

            lbl1.BackColor = Color.Blue
            lbl2.BackColor = Color.LightGray
            lbl3.BackColor = Color.Blue
            lbl4.BackColor = Color.Blue
            lbl5.BackColor = Color.LightGray
            lbl6.BackColor = Color.Blue
            lbl7.BackColor = Color.Blue
            lbl8.BackColor = Color.LightGray

        ElseIf counter = 7 Then

            lbl1.BackColor = Color.Blue
            lbl2.BackColor = Color.LightGray
            lbl3.BackColor = Color.Blue
            lbl4.BackColor = Color.Blue
            lbl5.BackColor = Color.Blue
            lbl6.BackColor = Color.Blue
            lbl7.BackColor = Color.Blue
            lbl8.BackColor = Color.LightGray

        ElseIf counter = 8 Then

            lbl1.BackColor = Color.Blue
            lbl2.BackColor = Color.Blue
            lbl3.BackColor = Color.Blue
            lbl4.BackColor = Color.LightGray
            lbl5.BackColor = Color.LightGray
            lbl6.BackColor = Color.LightGray
            lbl7.BackColor = Color.LightGray
            lbl8.BackColor = Color.LightGray

        ElseIf counter = 9 Then

            lbl1.BackColor = Color.Blue
            lbl2.BackColor = Color.Blue
            lbl3.BackColor = Color.Blue
            lbl4.BackColor = Color.Blue
            lbl5.BackColor = Color.Blue
            lbl6.BackColor = Color.Blue
            lbl7.BackColor = Color.Blue
            lbl8.BackColor = Color.LightGray

        ElseIf counter = 10 Then

            lbl1.BackColor = Color.Blue
            lbl2.BackColor = Color.Blue
            lbl3.BackColor = Color.Blue
            lbl4.BackColor = Color.Blue
            lbl5.BackColor = Color.LightGray
            lbl6.BackColor = Color.Blue
            lbl7.BackColor = Color.Blue
            lbl8.BackColor = Color.LightGray

            counter = 0

        End If

    End Sub

End Class
