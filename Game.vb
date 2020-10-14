'Programmer: Axel
'Date: 15/01/18
'Final Project: PlaneBall Game.
'Description: To use everything that I have learned in this course to make a cool game.

Public Class Game

    'Represents the baseballs on the form.
    Dim ball(7) As PictureBox

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load in baseballs from the form into the ball array.
        ball(0) = Ball1
        ball(1) = Ball2
        ball(2) = Ball3
        ball(3) = Ball4
        ball(4) = Ball5
        ball(5) = Ball6
        ball(6) = Ball7
        ball(7) = Ball8

    End Sub

    'Listens to the form for key movement.
    Private Sub Game_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'Check to see if up arrow is pressed.
        If e.KeyCode = Keys.Up Then
            'Move player up.
            Plane.Top -= 15
            tmrPlay.Enabled = True
        ElseIf e.KeyCode = Keys.Down Then
            'Move player down.
            Plane.Top += 15
            tmrPlay.Enabled = True
        ElseIf e.KeyCode = Keys.Right Then
            'Move player right.
            Plane.Left += 15
            tmrPlay.Enabled = True
        ElseIf e.KeyCode = Keys.Left Then
            'Move player left.
            Plane.Left -= 15
            tmrPlay.Enabled = True
        End If

    End Sub
    ''' <summary>
    ''' Checks to see if the plane crashes with the baseball.
    ''' </summary>
    ''' <returns>Returns the value of hit to see if they collided.</returns>
    ''' <remarks></remarks>
    Private Function collide() As Boolean
        Dim hit As Boolean = False

        'Checks for a collision of the player with a baseball.
        If Plane.Bounds.IntersectsWith(Ball1.Bounds) Then
            hit = True
            Ball1.Load("explosion.jpg")
        ElseIf Plane.Bounds.IntersectsWith(Ball2.Bounds) Then
            hit = True
            Ball2.Load("explosion.jpg")
        ElseIf Plane.Bounds.IntersectsWith(Ball3.Bounds) Then
            hit = True
            Ball3.Load("explosion.jpg")
        ElseIf Plane.Bounds.IntersectsWith(Ball4.Bounds) Then
            hit = True
            Ball4.Load("explosion.jpg")
        ElseIf Plane.Bounds.IntersectsWith(Ball5.Bounds) Then
            hit = True
            Ball5.Load("explosion.jpg")
        ElseIf Plane.Bounds.IntersectsWith(Ball6.Bounds) Then
            hit = True
            Ball6.Load("explosion.jpg")
        ElseIf Plane.Bounds.IntersectsWith(Ball7.Bounds) Then
            hit = True
            Ball7.Load("explosion.jpg")
        ElseIf Plane.Bounds.IntersectsWith(Ball8.Bounds) Then
            hit = True
            Ball8.Load("explosion.jpg")
        End If

        'Returns the hit value.
        Return hit

    End Function
    ''' <summary>
    ''' Activates the baseballs.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MoveBallPlane()
        'Moves baseballs.
        Ball1.Top += 10
        Ball2.Top += 8
        Ball3.Top += 12
        Ball4.Left += 12
        Ball5.Left += 16
        Ball6.Left -= 14
        Ball7.Top -= 16
        Ball8.Top -= 14

        'Checks to see if baseball 1 is off of the screen.
        If Ball1.Top > Me.Height Then
            Ball1.Top = 0    'Resets at top of form.
        End If

        'Checks to see if baseball 2 is off of the screen.
        If Ball2.Top > Me.Height Then
            Ball2.Top = 0
        End If

        'Checks to see if baseball 3 is off of the screen.
        If Ball3.Top > Me.Height Then
            Ball3.Top = 0
        End If

        'Checks to see if baseball 4 is off of the screen.
        If Ball4.Left > Me.Width Then
            Ball4.Left = 0
        End If

        'Checks to see if baseball 5 is off of the screen.
        If Ball5.Left > Me.Width Then
            Ball5.Left = 0
        End If

        'Checks to see if baseball 6 is off of the screen.
        If Ball6.Left < 0 Then
            Ball6.Left = Me.Width
        End If

        'Checks to see if baseball 7 is off of the screen.
        If Ball7.Top < 0 Then
            Ball7.Top = Me.Height
        End If

        'Checks to see if baseball 7 is off of the screen.
        If Ball8.Top < 0 Then
            Ball8.Top = Me.Height
        End If

        'Checks to see if plane is off of the screen.
        If Plane.Top < 0 Then
            Plane.Top = Me.Height
        End If

        'Checks to see if plane is off of the screen.
        If Plane.Top > Me.Height Then
            Plane.Top = 0
        End If

        'Checks to see if plane is off of the screen.
        If Plane.Left < 0 Then
            Plane.Left = Me.Width
        End If

        'Checks to see if plane is off of the screen.
        If Plane.Left > Me.Width Then
            Plane.Left = 0
        End If

    End Sub

    Private Sub TmrPlay_Tick(sender As Object, e As EventArgs) Handles tmrPlay.Tick
        'Move balls.
        Call MoveBallPlane()

        'Collision of player with baseball.
        If collide() Then
            Plane.Load("explosion.jpg")
            tmrPlay.Enabled = False 'STOP ALL TIMERS
            MsgBox("GAME OVER!") 'display message
            Me.Close() 'end game
            Login.btnAgain.Enabled = True
        End If

    End Sub

    Private Sub Plane_Click(sender As Object, e As EventArgs) Handles Plane.Click

    End Sub
End Class
