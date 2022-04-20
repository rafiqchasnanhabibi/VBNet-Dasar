Public Class Form6
    Private Sub bNext_Click(sender As Object, e As EventArgs) Handles bNext.Click
        ListBox1.Items.Clear()
        For i = 1 To 10
            ListBox1.Items.Add("For Next : " & i)
        Next
    End Sub

    Private Sub bWhile_Click(sender As Object, e As EventArgs) Handles bWhile.Click
        ListBox1.Items.Clear()
        Dim i As Integer = 0
        Do While i <= 10
            ListBox1.Items.Add("Do While : " & i)
            i = i + 1
        Loop
    End Sub

    Private Sub bUntil_Click(sender As Object, e As EventArgs) Handles bUntil.Click
        ListBox1.Items.Clear()
        Dim i As Integer = 0
        Do Until i > 10
            ListBox1.Items.Add("Do Until : " & i)
            i = i + 1
        Loop
    End Sub
End Class