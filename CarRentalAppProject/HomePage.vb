Public Class HomePage

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'changed to test github
    End Sub

    Private Sub UpdateCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateCustomerToolStripMenuItem.Click

    End Sub

    Private Sub UpdateInventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateInventoryToolStripMenuItem.Click

    End Sub

    Private Sub NewRentalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewRentalToolStripMenuItem.Click
        frmNewRental.Show()

    End Sub

    Private Sub UpdateRentalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateRentalToolStripMenuItem.Click

    End Sub
End Class
