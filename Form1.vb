Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim stfno(4) As Long

        stfno(4) = Val(TextBox1.Text)

        If stfno(4) <= 9999 Then
            MsgBox("WELCOME!")
            Form2.Show()

        Else
            MsgBox("Please enter again!")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox1.Focus()

    End Sub
End Class
