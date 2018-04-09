Public Class Form1

    Private Sub MutlakDegerButton_Click(sender As Object, e As EventArgs) Handles MutlakDegerButton.Click
        Dim Sayi1, Sayi2 As Decimal
        Sayi1 = CDec(Sayi1TextBox.Text)
        Sayi2 = Math.Abs(Sayi1)
        Sayi2TextBox.Text = Sayi2
    End Sub

    Private Sub YukariYuvarlaButton_Click(sender As Object, e As EventArgs) Handles YukariYuvarlaButton.Click
        Dim Sayi1, Sayi2 As Decimal
        Sayi1 = CDec(Sayi1TextBox.Text)
        Sayi2 = Math.Ceiling(Sayi1)
        Sayi2TextBox.Text = Sayi2
    End Sub

    Private Sub AsagiYuvarlaButton_Click(sender As Object, e As EventArgs) Handles AsagiYuvarlaButton.Click
        Dim Sayi1, Sayi2 As Decimal
        Sayi1 = CDec(Sayi1TextBox.Text)
        Sayi2 = Math.Floor(Sayi1)
        Sayi2TextBox.Text = Sayi2
    End Sub

    Private Sub YuvarlaButton_Click(sender As Object, e As EventArgs) Handles YuvarlaButton.Click
        Dim Sayi1, Sayi2 As Decimal
        Sayi1 = CDec(Sayi1TextBox.Text)
        'Sayi2 = Math.Round(Sayi1) 'Tam sayıya yuvarlar
        Sayi2 = Math.Round(Sayi1, 3) 'ondalık basamak hanesini üç hane olacak şekilde yuvarlar
        Sayi2TextBox.Text = Sayi2
    End Sub
End Class
