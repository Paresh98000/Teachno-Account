Public Class Select_Company
    Private Sub Select_Company_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_Select_Click(sender As Object, e As EventArgs) Handles Btn_Select.Click
        Me.Visible = False
        Techno_Accounts.Enabled = True
        Techno_Accounts.Activate()
        Techno_Accounts.Lbl_Selected_Company.Text = Lst_Company.SelectedItem
        Techno_Accounts.chng_cmpny()
        Techno_Accounts.Lbl_Company_Header.Text = "-------------------------^ Above Company Selected ^-----------------"
        Me.Close()
    End Sub

End Class