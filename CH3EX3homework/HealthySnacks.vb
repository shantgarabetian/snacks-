Public Class SNACKS
    Dim Click_burrito As Integer = 0
    Dim Click_falafel As Integer = 0
    Dim Click_yogurt As Integer = 0
    Dim Click_rolls As Integer = 0


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub burrito_Click(sender As Object, e As EventArgs) Handles burrito.Click
        confirmation.Enabled = True
        Click_burrito = Click_burrito + 1
        lblburrito.Text = Click_burrito.ToString()
        Displaymnu.Text = " "

    End Sub

    Private Sub falafel_Click(sender As Object, e As EventArgs) Handles falafel.Click
        confirmation.Enabled = True
        Click_falafel = Click_falafel + 1
        lblfalafel.Text = Click_falafel.ToString()
        Displaymnu.Text = " "

    End Sub

    Private Sub greekyogurt_Click(sender As Object, e As EventArgs) Handles greekyogurt.Click
        confirmation.Enabled = True
        Click_yogurt = Click_yogurt + 1
        lblyogurt.Text = Click_yogurt.ToString()
        Displaymnu.Text = " "

    End Sub

    Private Sub springrolls_Click(sender As Object, e As EventArgs) Handles springrolls.Click
        confirmation.Enabled = True
        Click_rolls = Click_rolls + 1
        lblrolls.Text = Click_rolls.ToString()
        Displaymnu.Text = " "


    End Sub

    Private Sub clearburrito_Click(sender As Object, e As EventArgs) Handles clearburrito.Click
        Click_burrito = 0
        lblburrito.Text = " "
    End Sub

    Private Sub clearfalafel_Click(sender As Object, e As EventArgs) Handles clearfalafel.Click
        Click_falafel = 0
        lblfalafel.Text = " "
    End Sub

    Private Sub clearyogurt_Click(sender As Object, e As EventArgs) Handles clearyogurt.Click
        Click_yogurt = 0
        lblyogurt.Text = " "
    End Sub

    Private Sub clearrolls_Click(sender As Object, e As EventArgs) Handles clearrolls.Click
        Click_rolls = 0
        lblrolls.Text = " "
    End Sub

    Private Sub confirmation_Click(sender As Object, e As EventArgs) Handles confirmation.Click
        Displaymnu.Text = " THANK YOU " + Environment.NewLine + " THIS IS YOUR ORDER " + Environment.NewLine
        If Click_burrito >= 1 Then
            Displaymnu.Text = Displaymnu.Text + " BURRITO SNACK : " + Click_burrito.ToString() + Environment.NewLine
            Click_burrito = 0
            lblburrito.Text = " "

        End If
        If Click_falafel >= 1 Then
            Displaymnu.Text = Displaymnu.Text + " FALAFEL SNACK : " + Click_falafel.ToString() + Environment.NewLine
            Click_falafel = 0
            lblfalafel.Text = " "

        End If
        If Click_yogurt >= 1 Then
            Displaymnu.Text = Displaymnu.Text + " GREEK YOGURT : " + Click_yogurt.ToString() + Environment.NewLine
            Click_yogurt = 0
            lblyogurt.Text = " "
        End If
        If Click_rolls >= 1 Then
            Displaymnu.Text = Displaymnu.Text + " SPRING ROLLS : " + Click_rolls.ToString() + Environment.NewLine
            Click_rolls = 0
            lblrolls.Text = " "

        End If
        confirmation.Enabled = False

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Close()
    End Sub
End Class