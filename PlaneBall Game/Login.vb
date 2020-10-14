'Programmer: Axel
'Date: 15/01/18
'Final Project: PlaneBall Game.
'Description: To use everything that I have learned in this course to make a cool game.

Public Class Login

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'Activates the game.
        Game.Show()
        'Disables the start button.
        btnStart.Enabled = False
        'Enables the done button.
        btnDone.Enabled = True
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        End     'Ends game.
    End Sub

    Private Sub btnAgain_Click(sender As Object, e As EventArgs) Handles btnAgain.Click
        'Allows user to play the game again.
        Game.Show()
        btnAgain.Enabled = False
    End Sub
End Class
