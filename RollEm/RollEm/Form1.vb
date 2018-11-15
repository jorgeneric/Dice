Public Class RollEm

    'variables

    Dim P1Pairs As Integer = 1
    Dim P2Pairs As Integer = 1
    Dim P1Wins As Integer = 0
    Dim P2Wins As Integer = 0
    Dim P1Score As Integer
    Dim P2Score As Integer
    Dim FirstRoll As Boolean = True
    Dim P1Roll As Boolean = False
    Dim P2Roll As Boolean = False


    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click

        Dim RandomGenerator As New Random
        Dim random1 As Integer
        Dim random2 As Integer
        Dim Rolled As Integer
        Static player As Integer = 1

        picFirstDie.Image = Nothing
        picSecondDie.Image = Nothing
        lblMessage.Text = "Player " & player.ToString & " rolled"
        btnRoll.Enabled = False
        Me.Refresh()
        System.Threading.Thread.Sleep(1000)

        random1 = RandomGenerator.Next(1, 7)
        random2 = RandomGenerator.Next(1, 7)
        Rolled = random1 + random2



        Select Case random1
            Case 1
                picFirstDie.Image = picOne.Image
            Case 2
                picFirstDie.Image = picTwo.Image
            Case 3
                picFirstDie.Image = picThree.Image
            Case 4
                picFirstDie.Image = picFour.Image
            Case 5
                picFirstDie.Image = picFive.Image
            Case 6
                picFirstDie.Image = picSix.Image
        End Select

        Select Case random2
            Case 1
                picSecondDie.Image = picOne.Image
            Case 2
                picSecondDie.Image = picTwo.Image
            Case 3
                picSecondDie.Image = picThree.Image
            Case 4
                picSecondDie.Image = picFour.Image
            Case 5
                picSecondDie.Image = picFive.Image
            Case 6
                picSecondDie.Image = picSix.Image
        End Select


        If FirstRoll Then
            player = 1
            P1Score = 0
            P2Score = 0
            P1Roll = True
            P1Score = Rolled
            lblMessage.Text = "Player " & player.ToString & " rolled: " & P1Score.ToString
            lblMessage.Visible = True
            FirstRoll = False
        Else
            player = 2
            P2Roll = True
            P2Score = Rolled
            lblMessage.Text = "Player " & player.ToString & " rolled: " & P2Score.ToString
            lblMessage.Visible = True
            If P1Score > P2Score Then
                P1Wins = P1Wins + 1
            Else
                P2Wins = P2Wins + 1
            End If
            FirstRoll = True
        End If

        ' How I made the Pairs win

        If random1 = random2 Then
            lblMessage.Text =
                "Congratulations, Player " & player.ToString
            Dim count As Integer = 1
            Do While count <= 20
                If lblMessage.Visible = True Then
                    lblMessage.Visible = False
                Else
                    lblMessage.Visible = True
                End If
                Me.Refresh()
                System.Threading.Thread.Sleep(100)
                count = count + 1
            Loop
        End If

        If lblMessage.Text = "Congratulations, Player 1" Then
            txtPlayerOnePairs.Text = P1Pairs
            P1Pairs = P1Pairs + 1
        ElseIf lblMessage.Text = "Congratulations, Player 2" Then
            txtPlayerTwoPairs.Text = P2Pairs
            P2Pairs = P2Pairs + 1
        End If

        btnRoll.Enabled = True


        txtOneRoll.Text = Convert.ToString(P1Score)
        txtTwoRoll.Text = Convert.ToString(P2Score)
        txtOneWins.Text = Convert.ToString(P1Wins)
        txtTwoWins.Text = Convert.ToString(P2Wins)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class

