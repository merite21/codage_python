Public Class Frmprincipal
    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AnimauxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnimauxToolStripMenuItem.Click
        Dim Frmanimaux As New Frmanimaux
        Frmanimaux.ShowDialog()

    End Sub
End Class
