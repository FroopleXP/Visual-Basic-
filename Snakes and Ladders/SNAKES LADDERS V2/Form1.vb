Public Class Form1


    Dim rndNum As Integer
    Dim jumpDist As Integer
    Dim playerMove As Integer
    Dim x1 As Integer
    Dim x2 As Integer
    Dim numGenerator As New Random

    Dim plrOneMove As Boolean
    Dim plrTwoMove As Boolean
    Dim reverse1 As Boolean
    Dim reverse2 As Boolean
    Dim moveUp As Boolean
    Dim keyPressCheck As Boolean
    Dim lastRowCheckOne As Boolean
    Dim lastRowCheckTwo As Boolean

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        ' LISTENING FOR KEY PRESS
        If e.KeyCode = Keys.R Then

            If keyPressCheck = False Then
                playerMoveFunc()

            Else
                ' NOTHING NEEDS TO HAPPEN HERE
            End If

        ElseIf e.KeyCode = Keys.P Then

            Dim msgBoxRetry As New MsgBoxResult
            msgBoxRetry = MsgBox("Are sure you want to restart?", MsgBoxStyle.YesNo)

            If msgBoxRetry = MsgBoxResult.Yes Then
                ' RESTART GAME
                initialise()
            End If

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        keyPressCheck = False
        plrTurnDisp.BackgroundImage = My.Resources.roll

        ' START PLAYING THE MAIN GAME MUSIC
        My.Computer.Audio.Play(My.Resources.background, AudioPlayMode.BackgroundLoop)

        ' AT FIRST WE DISABLE THE MOVE BUTTON TO STOP THE PLAYER FROM MOVING WITH A GIVEN DIE VALUE

        ' WE ALSO NEED TO SET THE JUMP DISTANCE IN PIXELS FOR THE PLAYER TO MOVE
        jumpDist = 39
        x1 = 1
        x2 = 1

        ' UPDATE THE PLAYER LOCATION BOARD

        plrOneMove = True
        plrTwoMove = False
        moveUp = False

    End Sub

    Private Sub plrOneMoveTimer_Tick(sender As Object, e As EventArgs) Handles plrOneMoveTimer.Tick

        If playerMove = rndNum Then
            plrOneMove = False
            plrTwoMove = True
            keyPressCheck = False
            plrTurnDisp.BackgroundImage = My.Resources.roll_plr_two
            plrOneWinCheck()

            If x1 >= 94 Then
                lastRowCheckOne = True
            End If

            plrOneLadderCheck()
            plrOneSnakeCheck()
            plrOneMoveTimer.Stop()
        Else
            ' CHECK IF THE PLAYER NEEDS TO MOVE ON THE Y AXIS
            If x1 Mod 10 = 0 And x1 <> 0 Then

                ' NOW WE CALL THE TIMER TO MOVE THE PLAYER UP ONE   
                plrOneMoveUp.Start()
                plrOneMoveTimer.Stop()

            Else

                If reverse1 = False Then

                    ' NOW WE MOVE THE PLAYER COUNTER    
                    plrOneCounter.Location = New Point(plrOneCounter.Location.X + jumpDist, plrOneCounter.Location.Y)

                    ' CHECK IF THE PLAYER HAS USED ALL THEIR MOVES
                    playerMove = playerMove + 1

                    ' UPDATE THE PLAYER LOCATION BOARD
                    x1 = x1 + 1

                ElseIf reverse1 = True Then

                    ' NOW WE MOVE THE PLAYER COUNTER    
                    plrOneCounter.Location = New Point(plrOneCounter.Location.X - jumpDist, plrOneCounter.Location.Y)

                    ' CHECK IF THE PLAYER HAS USED ALL THEIR MOVES
                    playerMove = playerMove + 1

                    ' UPDATE THE PLAYER LOCATION BOARD
                    x1 = x1 + 1

                End If
            End If
        End If

    End Sub

    Private Sub plrTwoMoveTimer_Tick(sender As Object, e As EventArgs) Handles plrTwoMoveTimer.Tick

        If playerMove = rndNum Then
            plrTwoMove = False
            plrOneMove = True
            keyPressCheck = False
            plrTurnDisp.BackgroundImage = My.Resources.roll_plr_one
            plrTwoWinCheck()

            If x2 >= 94 Then
                lastRowCheckTwo = True
            End If

            plrTwoLadderCheck()
            plrTwoSnakeCheck()
            plrTwoMoveTimer.Stop()
        Else

            ' CHECK IF PLAYER TWO NEEDS TO MOVE UP ONE ON THE Y AXIS
            If x2 Mod 10 = 0 And x2 <> 0 Then

                ' NOW WE CALL TEH TIMER TO MOVE THE PLAYER UP ONE
                plrTwoMoveUp.Start() ' NOTE: THIS NEEDS CREATING
                plrTwoMoveTimer.Stop()

            Else

                If reverse2 = False Then

                    ' ACTUALLY MOVING PLAYER TWO'S COUNTER
                    plrTwoCounter.Location = New Point(plrTwoCounter.Location.X + jumpDist, plrTwoCounter.Location.Y)

                    ' CHECK IF THE PLAYER HAS USED ALL OF THEIR MOVES
                    playerMove = playerMove + 1

                    ' UPDATE PLAYER LOCATION BOARD
                    x2 = x2 + 1

                ElseIf reverse2 = True Then

                    plrTwoCounter.Location = New Point(plrTwoCounter.Location.X - jumpDist, plrTwoCounter.Location.Y)

                    ' CHECK IF THE PLAYER HAS USED ALL OF THEIR MOVES
                    playerMove = playerMove + 1

                    ' UPDATE PLAYER LOCATION BOARD
                    x2 = x2 + 1

                End If

            End If

        End If

    End Sub

    Private Sub plrOneMoveUp_Tick(sender As Object, e As EventArgs) Handles plrOneMoveUp.Tick

        ' NOW THAT THE TIMER IS ACTIVATED, WE CAN MOVE THE PLAYER UP
        plrOneCounter.Location = New Point(plrOneCounter.Location.X, plrOneCounter.Location.Y - jumpDist)

        If reverse1 = False Then
            reverse1 = True
        ElseIf reverse1 = True Then
            reverse1 = False
        End If

        playerMove = playerMove + 1

        ' UPDATE THE PLAYER LOCATION BOARD
        x1 = x1 + 1

        plrOneMoveUp.Stop()
        plrOneMoveTimer.Start()

    End Sub

    Private Sub plrTwoMoveUp_Tick(sender As Object, e As EventArgs) Handles plrTwoMoveUp.Tick

        plrTwoCounter.Location = New Point(plrTwoCounter.Location.X, plrTwoCounter.Location.Y - jumpDist)

        ' ACTIVATING THE REVERSE SWITCH RESPECTIVELY
        If reverse2 = False Then
            reverse2 = True
        ElseIf reverse2 = True Then
            reverse2 = False
        End If

        playerMove = playerMove + 1

        ' UPDATE PLAYER TWO'S LOCATION BOARD
        x2 = x2 + 1

        plrTwoMoveUp.Stop()
        plrTwoMoveTimer.Start()

    End Sub

    Function playerMoveFunc()

        keyPressCheck = True

        ' HERE WE GENERATE THE RANDOM NUMBER FOR THE DIE ROLL
        rndNum = Val(numGenerator.Next(0, 6) + 1)

        ' NOW WE DISPLAY THE NUMBER TO THE LABEL
        Select Case (rndNum)

            Case 1
                DICE.BackgroundImage = My.Resources._1
            Case 2
                DICE.BackgroundImage = My.Resources._2
            Case 3
                DICE.BackgroundImage = My.Resources._3
            Case 4
                DICE.BackgroundImage = My.Resources._4
            Case 5
                DICE.BackgroundImage = My.Resources._5
            Case 6
                DICE.BackgroundImage = My.Resources._6

        End Select

        ' NOW WE DISABLE THE RNDNUMBTN TO STOP MULTIPLE DIE THROWS


        Threading.Thread.Sleep(100)

        playerMove = Nothing

        ' FIRST WE NEED TO CHECK WHICH PLAYERS' GO IT IS
        If plrOneMove = True Then

            ' CHECKING IF PLAYERONE IS ON THE LAST ROW
            If lastRowCheckOne = True Then

                Dim blocksLeft As Integer

                blocksLeft = 100 - x1

                If rndNum > blocksLeft Then
                    MsgBox("Unlucky, you must roll a " & blocksLeft & " to win!", MsgBoxStyle.Information)
                    plrOneMove = False
                    plrTwoMove = True
                    keyPressCheck = False
                    plrTurnDisp.BackgroundImage = My.Resources.roll_plr_two
                    plrOneMoveTimer.Stop()
                Else
                    ' START PLAYER ONE'S GO
                    plrOneMoveTimer.Start()
                End If
            Else

                ' START PLAYER ONE'S GO
                plrOneMoveTimer.Start()

            End If

        ElseIf plrTwoMove = True Then

            ' CHECKING IF PLAYERTWO IS ON THE LAST ROW
            If lastRowCheckTwo = True Then

                Dim blocksLeft As Integer

                blocksLeft = 100 - x2

                If rndNum > blocksLeft Then
                    MsgBox("Unlucky, you must roll a " & blocksLeft & " to win!", MsgBoxStyle.Information)
                    plrTwoMove = False
                    plrOneMove = True
                    keyPressCheck = False
                    plrTurnDisp.BackgroundImage = My.Resources.roll_plr_one
                    plrTwoMoveTimer.Stop()
                Else

                    ' START PLAYER TWO'S GO
                    plrTwoMoveTimer.Start()

                End If
            Else

                ' START PLAYER TWO'S GO
                plrTwoMoveTimer.Start()
            End If

        End If

    End Function

    Function plrOneLadderCheck()

        Dim pic As Image = My.Resources.plrOneCounter

        ' CHECKING FOR LADDER ONE
        If x1 = 19 Then

            plrOneCounter.Location = New Point(200, 120)

            x1 = 76
            reverse1 = True
        Else

            ' CHECKING FOR LADDER TWO
            If x1 = 8 Then
                plrOneCounter.Location = New Point(239, 198)
                x1 = 55
                reverse1 = True
            Else

                ' CHECKING FOR LADDER THREE
                If x1 = 32 Then
                    plrOneCounter.Location = New Point(356, 42)
                    x1 = 92
                    reverse1 = True
                End If
            End If
        End If

    End Function

    Function plrTwoLadderCheck()

        ' CHECKING FOR LADDER ONE
        If x2 = 19 Then
            plrTwoCounter.Location = New Point(200, 120)
            x2 = 76
            reverse2 = True
        Else

            ' CHECKING FOR LADDER TWO
            If x2 = 8 Then
                plrTwoCounter.Location = New Point(239, 198)
                x2 = 55
                reverse2 = True
            Else

                ' CHECKING FOR LADDER THREE
                If x2 = 32 Then
                    plrTwoCounter.Location = New Point(356, 42)
                    x2 = 92
                    reverse2 = True
                End If
            End If
        End If

    End Function

    Function plrOneSnakeCheck()

        ' CHECKING FOR SNAKE ONE
        If x1 = 97 Then
            plrOneCounter.Location = New Point(83, 198)
            x1 = 59
            reverse1 = True
        Else

            ' CHECKING FOR SNAKE TWO
            If x1 = 56 Then
                plrOneCounter.Location = New Point(161, 393)
                x1 = 4
                reverse1 = False
            Else

                ' CHECKING FOR SNAKE THREE
                If x1 = 88 Then
                    plrOneCounter.Location = New Point(317, 276)
                    x1 = 33
                    reverse1 = True
                End If
            End If
        End If

    End Function

    Function plrTwoSnakeCheck()

        ' CHECKING FOR SNAKE ONE
        If x2 = 97 Then
            plrTwoCounter.Location = New Point(83, 198)
            x2 = 59
            reverse2 = True
        Else

            ' CHECKING FOR SNAKE TWO
            If x2 = 56 Then
                plrTwoCounter.Location = New Point(161, 393)
                x2 = 4
                reverse2 = False
            Else

                ' CHECKING FOR SNAKE THREE
                If x2 = 88 Then
                    plrTwoCounter.Location = New Point(317, 276)
                    x2 = 33
                    reverse2 = True
                End If
            End If
        End If

    End Function

    Function plrOneWinCheck()

        If x1 = 100 Then
            plrOneMoveTimer.Stop()
            MsgBox("Congratulations, player 1. You won!", MsgBoxStyle.Exclamation)

            Dim msgBoxRetry As New MsgBoxResult
            msgBoxRetry = MsgBox("Would you like to play again?", MsgBoxStyle.YesNoCancel, MsgBoxStyle.Information)

            If msgBoxRetry = MsgBoxResult.Yes Then
                ' RESTART GAME
                initialise()
            ElseIf msgBoxRetry = MsgBoxResult.No Then
                'END GAME
                Me.Close()
            ElseIf msgBoxRetry = MsgBoxResult.Cancel Then
                'END GAME  
                Me.Close()
            End If

        End If

    End Function

    Function plrTwoWinCheck()

        If x2 = 100 Then
            plrTwoMoveTimer.Stop()
            MsgBox("Congratulations, player 2. You won!")

            Dim msgBoxRetry As New MsgBoxResult
            msgBoxRetry = MsgBox("Would you like to play again?", MsgBoxStyle.YesNoCancel, MsgBoxStyle.Information)

            If msgBoxRetry = MsgBoxResult.Yes Then
                ' RESTART GAME
                initialise()
            ElseIf msgBoxRetry = MsgBoxResult.No Then
                'END GAME
                Me.Close()
            ElseIf msgBoxRetry = MsgBoxResult.Cancel Then
                'END GAME  
                Me.Close()
            End If
        End If

    End Function

    Function initialise()

        keyPressCheck = False
        plrTurnDisp.BackgroundImage = My.Resources.roll

        ' START PLAYING THE MAIN GAME MUSIC
        My.Computer.Audio.Play(My.Resources.background, AudioPlayMode.BackgroundLoop)

        ' AT FIRST WE DISABLE THE MOVE BUTTON TO STOP THE PLAYER FROM MOVING WITH A GIVEN DIE VALUE

        ' WE ALSO NEED TO SET THE JUMP DISTANCE IN PIXELS FOR THE PLAYER TO MOVE
        jumpDist = 39
        x1 = 1
        x2 = 1

        ' UPDATE THE PLAYER LOCATION BOARD

        plrOneMove = True
        plrTwoMove = False
        moveUp = False
        reverse1 = False
        reverse2 = False

        plrOneCounter.Location = New Point(44, 393)
        plrTwoCounter.Location = New Point(44, 393)

    End Function

End Class
