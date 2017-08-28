Public Class Form1
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    Dim scoreAway As Integer
    Dim scoreHome As Integer
    Dim setsAways As Integer
    Dim setsHomes As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        scoreAway += 1
        lblScoreAway.Text = scoreAway
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        scoreAway -= 1
        lblScoreAway.Text = scoreAway
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        scoreHome += 1
        lblScoreHome.Text = scoreHome
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        scoreHome -= 1
        lblScoreHome.Text = scoreHome
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        setsAways += 1
        setsAway.Text = setsAways
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        setsAway.Text = "2nd"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        setsAways = 0
        setsHomes = 0
        setsAway.Text = "0"
        setsHome.Text = "0"
        scoreHome = 0
        scoreAway = 0
        lblScoreAway.Text = scoreAway
        lblScoreHome.Text = scoreHome

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub lblScoreHome_Click(sender As Object, e As EventArgs) Handles lblScoreHome.Click

    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs)
        setsAway.Text = "OT"
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs)
        setsAway.Text = "SO"
    End Sub

    Private Sub lblScoreAway_Click(sender As Object, e As EventArgs) Handles lblScoreAway.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (GetAsyncKeyState(49)) Then
            scoreAway += 1
            lblScoreAway.Text = scoreAway
        End If
        If (GetAsyncKeyState(50)) Then
            scoreHome += 1
            lblScoreHome.Text = scoreHome
        End If
        If (GetAsyncKeyState(51)) Then
            setsAways += 1
            setsAway.Text = setsAways
        End If
        If (GetAsyncKeyState(52)) Then
            setsHomes += 1
            setsHome.Text = setsHomes
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick


    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        setsAways -= 1
        setsAway.Text = setsAways
    End Sub

    Private Sub Button8_Click_2(sender As Object, e As EventArgs) Handles Button8.Click
        setsHomes += 1
        setsHome.Text = setsHomes
    End Sub

    Private Sub Button9_Click_2(sender As Object, e As EventArgs) Handles Button9.Click
        setsHomes -= 1
        setsHome.Text = setsHomes
    End Sub
End Class
