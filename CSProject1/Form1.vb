Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, num3, num4, num5 As Integer
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        num3 = TextBox3.Text
        num4 = TextBox4.Text
        num5 = TextBox5.Text

        Dim grades As New List(Of Integer) From {num1, num2, num3, num4, num5}
        Dim average As Double = grades.Average()

        Output.Text = average

        If grades.All(Function(g) g >= 85) AndAlso average > 90 Then
            Honor.Text = "Dean's Lister"
        ElseIf grades.All(Function(g) g >= 95) AndAlso average >= 90 Then
            Honor.Text = "President's Lister"
        Else
            Honor.Text = "No Honor"
        End If

    End Sub

End Class
