Public NotInheritable Class AboutBox

    Private Sub AboutBox_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lbluser.Text = My.User.Name
    End Sub
End Class
