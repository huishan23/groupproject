Public Class Form2


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Sheet1TableAdapter.Fill(Me._Database3DataSet.Sheet1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
        Form1.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Chart1.Series("Labour Force(WP)").Points.AddXY("1987", 13.6)
  
        Me.Chart1.Series("Labour Force(WP)").Points.AddXY("1988", 13.8)


        Me.Chart1.Series("Labour Force(WP)").Points.AddXY("1989", 14.7)

        Me.Chart1.Series("Labour Force(WP)").Points.AddXY("2000", 26.7)


        Me.Chart1.Series("Labour Force(WP)").Points.AddXY("2005", 32.2)
        Me.Chart1.Series("Labour Force(WP)").Points.AddXY("2009", 37.6)
        Me.Chart1.Series("Labour Force(WP)").Points.AddXY("2016", 38.9)


    End Sub
End Class