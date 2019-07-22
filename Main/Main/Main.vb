Imports System.Data.OleDb
Public Class Techno_Accounts
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim path As String = FileSystem.CurDir
    Dim bin As String
    Dim company_nm() As String
    Dim v_rcpt, v_pymt, v_cntr, v_sl, v_prcs As UInteger
    Private Sub Btn_Save_com_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Techno_Accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Company_fresh()
        v_rcpt = v_pymt = v_cntr = v_sl = v_prcs = 0
    End Sub

    Sub Company_fresh()
        ' set path for Bin folder
        bin = path.Remove(path.LastIndexOf("\"))
        bin += "\"

        ' Getting company info
        company_nm = IO.Directory.GetFiles(bin, "*.mdb")

        ' Checking created company
        If company_nm.Length > 0 Then
            Lbl_Com_Names.Text = vbNullString
            For Each name As String In company_nm
                name = name.Substring(name.LastIndexOf("\") + 1)
                Lbl_Com_Names.Text += " " + name.Remove(name.Length() - 4) + vbNewLine
            Next
        End If

    End Sub

    Private Sub Btn_CC_Click(sender As Object, e As EventArgs) Handles Btn_CC.Click
        Btn_Edit.Visible = False
        Btn_CC.Visible = False
        Btn_Select_Company.Visible = False
        Txt_Com_Name.Visible = True
        Txt_Address.Visible = True
        Lbl_Com_Address.Visible = True
        Lbl_Name_of_Company.Visible = True
        Btn_Clear.Visible = True
        Btn_Save.Visible = True
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        If Txt_Com_Name.Text.Length > 0 Then
            Try
                ' Creating a file
                IO.File.Copy(bin + "Empty.mdb", bin + Txt_Com_Name.Text + ".mdb")

                ' Database Connection
                con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & bin & Txt_Com_Name.Text & ".mdb"
                con.Open()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try

            Txt_Com_Name.Visible = False
            Txt_Address.Visible = False
            Lbl_Com_Address.Visible = False
            Lbl_Name_of_Company.Visible = False
            Btn_Clear.Visible = False
            Btn_Save.Visible = False
            Btn_Edit.Visible = True
            Btn_CC.Visible = True
            Btn_Select_Company.Visible = True
            Lbl_Company_Header.Text = "-----------------------------------------------------"
            Lbl_Selected_Company.Text = Txt_Com_Name.Text & " Company is Selected now."
            Lbl_Selected_Company.Enabled = True
            MsgBox(Txt_Com_Name.Text & " Company is created.", MsgBoxStyle.Information, "Company Operation")
        Else
            MsgBox("Please enter a valid company name.", MsgBoxStyle.Exclamation)
        End If
        Company_fresh()
    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        Txt_Address.Clear()
        Txt_Com_Name.Clear()
    End Sub

    Private Sub Btn_Select_Company_Click(sender As Object, e As EventArgs) Handles Btn_Select_Company.Click
        Me.Enabled = False
        Select_Company.Show()
        ' Checking created company
        If company_nm.Length > 0 Then
            For Each name As String In company_nm
                name = name.Substring(name.LastIndexOf("\") + 1)
                Select_Company.Lst_Company.Items.Add(" " + name.Remove(name.Length() - 4))
            Next
        End If

    End Sub
    Public Sub chng_cmpny()
        con.Dispose()
        Try

            ' Open new connection
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & bin & Lbl_Selected_Company.Text & ".mdb"
            con.Open()

            ' Inserting data
            cmd.Connection = con
            cmd.CommandText = "Insert into Company (Last_Used) values(" & Now.Date & ");"

            ' executing command
            MsgBox("Row effected: " & cmd.ExecuteNonQuery())
            MsgBox("Successfully change company to " + Lbl_Selected_Company.Text)

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Btn_V_Save_Click(sender As Object, e As EventArgs) Handles Btn_V_Save.Click

    End Sub

    Private Sub Tab_Vouchers_Click(sender As Object, e As EventArgs) Handles Tab_Vouchers.Click

    End Sub

    Private Sub Txt_Cr_LostFocus(sender As Object, e As EventArgs) Handles Txt_Cr.LostFocus
        Label_Dr_1.Visible = True
        Txt_A_Dr_1.Visible = True
        Label_to_1.Visible = True
        Txt_A_Cr_1.Visible = True
        Txt_Dr.Visible = True
        Txt_Cr.Visible = True
    End Sub

    Private Sub Tab_Reciept_Click(sender As Object, e As EventArgs) Handles Tab_Reciept.Click

        Try
            con.Open()

        Catch ex As Exception

        End Try

    End Sub

End Class
