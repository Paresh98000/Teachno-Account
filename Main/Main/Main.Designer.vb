<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Techno_Accounts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Tab_Main = New System.Windows.Forms.TabControl()
        Me.Tab_Company = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_Clear = New System.Windows.Forms.Button()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.Btn_Select_Company = New System.Windows.Forms.Button()
        Me.Txt_Address = New System.Windows.Forms.TextBox()
        Me.Lbl_Com_Address = New System.Windows.Forms.Label()
        Me.Txt_Com_Name = New System.Windows.Forms.TextBox()
        Me.Lbl_Name_of_Company = New System.Windows.Forms.Label()
        Me.Btn_CC = New System.Windows.Forms.Button()
        Me.Box_Company = New System.Windows.Forms.GroupBox()
        Me.Lbl_Selected_Company = New System.Windows.Forms.Label()
        Me.Lbl_Com_Names = New System.Windows.Forms.Label()
        Me.Lbl_Company_Header = New System.Windows.Forms.Label()
        Me.Tab_Vouchers = New System.Windows.Forms.TabPage()
        Me.Tab_Sub_Voucher = New System.Windows.Forms.TabControl()
        Me.Tab_Reciept = New System.Windows.Forms.TabPage()
        Me.Lbl_V_Counter = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Btn_Clr_V = New System.Windows.Forms.Button()
        Me.Btn_V_Save = New System.Windows.Forms.Button()
        Me.Label_To_2 = New System.Windows.Forms.Label()
        Me.Label_Dr_2 = New System.Windows.Forms.Label()
        Me.Txt_Cr_2 = New System.Windows.Forms.TextBox()
        Me.Txt_Dr_2 = New System.Windows.Forms.TextBox()
        Me.Txt_A_Cr_2 = New System.Windows.Forms.TextBox()
        Me.Txt_A_Dr_2 = New System.Windows.Forms.TextBox()
        Me.Label_to_1 = New System.Windows.Forms.Label()
        Me.Label_Dr_1 = New System.Windows.Forms.Label()
        Me.Txt_Cr_1 = New System.Windows.Forms.TextBox()
        Me.Txt_Dr_1 = New System.Windows.Forms.TextBox()
        Me.Txt_A_Cr_1 = New System.Windows.Forms.TextBox()
        Me.Txt_A_Dr_1 = New System.Windows.Forms.TextBox()
        Me.Label_To = New System.Windows.Forms.Label()
        Me.Label_Dr = New System.Windows.Forms.Label()
        Me.Label_Credit = New System.Windows.Forms.Label()
        Me.Label_debit = New System.Windows.Forms.Label()
        Me.Lable_Accounts = New System.Windows.Forms.Label()
        Me.Txt_Cr = New System.Windows.Forms.TextBox()
        Me.Txt_Dr = New System.Windows.Forms.TextBox()
        Me.Txt_A_Cr = New System.Windows.Forms.TextBox()
        Me.Txt_A_Dr = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Tab_Purchase = New System.Windows.Forms.TabPage()
        Me.Tab_Sales = New System.Windows.Forms.TabPage()
        Me.Tab_Payment = New System.Windows.Forms.TabPage()
        Me.Tab_Contra = New System.Windows.Forms.TabPage()
        Me.Tab_Accounts_Inventory = New System.Windows.Forms.TabPage()
        Me.Tab_Display = New System.Windows.Forms.TabPage()
        Me.Tab_Setting = New System.Windows.Forms.TabPage()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Tab_Main.SuspendLayout()
        Me.Tab_Company.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Box_Company.SuspendLayout()
        Me.Tab_Vouchers.SuspendLayout()
        Me.Tab_Sub_Voucher.SuspendLayout()
        Me.Tab_Reciept.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_Main
        '
        Me.Tab_Main.Controls.Add(Me.Tab_Company)
        Me.Tab_Main.Controls.Add(Me.Tab_Vouchers)
        Me.Tab_Main.Controls.Add(Me.Tab_Accounts_Inventory)
        Me.Tab_Main.Controls.Add(Me.Tab_Display)
        Me.Tab_Main.Controls.Add(Me.Tab_Setting)
        Me.Tab_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Main.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab_Main.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Main.Multiline = True
        Me.Tab_Main.Name = "Tab_Main"
        Me.Tab_Main.SelectedIndex = 0
        Me.Tab_Main.Size = New System.Drawing.Size(1249, 435)
        Me.Tab_Main.TabIndex = 0
        '
        'Tab_Company
        '
        Me.Tab_Company.BackColor = System.Drawing.SystemColors.Highlight
        Me.Tab_Company.Controls.Add(Me.PictureBox1)
        Me.Tab_Company.Controls.Add(Me.GroupBox1)
        Me.Tab_Company.Controls.Add(Me.Box_Company)
        Me.Tab_Company.ForeColor = System.Drawing.Color.Black
        Me.Tab_Company.Location = New System.Drawing.Point(4, 29)
        Me.Tab_Company.Name = "Tab_Company"
        Me.Tab_Company.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Company.Size = New System.Drawing.Size(1241, 402)
        Me.Tab_Company.TabIndex = 0
        Me.Tab_Company.Text = "Company"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        'Me.PictureBox1.Image = Global.Tally_with_VB.My.Resources.Resources.TeachnoHeart2
        'Me.PictureBox1.InitialImage = Global.Tally_with_VB.My.Resources.Resources.TeachnoHeart1
        Me.PictureBox1.Location = New System.Drawing.Point(388, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(522, 396)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Btn_Clear)
        Me.GroupBox1.Controls.Add(Me.Btn_Save)
        Me.GroupBox1.Controls.Add(Me.Btn_Edit)
        Me.GroupBox1.Controls.Add(Me.Btn_Select_Company)
        Me.GroupBox1.Controls.Add(Me.Txt_Address)
        Me.GroupBox1.Controls.Add(Me.Lbl_Com_Address)
        Me.GroupBox1.Controls.Add(Me.Txt_Com_Name)
        Me.GroupBox1.Controls.Add(Me.Lbl_Name_of_Company)
        Me.GroupBox1.Controls.Add(Me.Btn_CC)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(910, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(328, 396)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "  --- Company Operations --- "
        '
        'Btn_Clear
        '
        Me.Btn_Clear.Location = New System.Drawing.Point(119, 333)
        Me.Btn_Clear.Name = "Btn_Clear"
        Me.Btn_Clear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_Clear.Size = New System.Drawing.Size(75, 27)
        Me.Btn_Clear.TabIndex = 8
        Me.Btn_Clear.Text = "Clear"
        Me.Btn_Clear.UseVisualStyleBackColor = True
        Me.Btn_Clear.Visible = False
        '
        'Btn_Save
        '
        Me.Btn_Save.Location = New System.Drawing.Point(38, 333)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_Save.Size = New System.Drawing.Size(75, 27)
        Me.Btn_Save.TabIndex = 7
        Me.Btn_Save.Text = "Save"
        Me.Btn_Save.UseVisualStyleBackColor = True
        Me.Btn_Save.Visible = False
        '
        'Btn_Edit
        '
        Me.Btn_Edit.Location = New System.Drawing.Point(170, 118)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_Edit.Size = New System.Drawing.Size(106, 27)
        Me.Btn_Edit.TabIndex = 2
        Me.Btn_Edit.Text = "Edit"
        Me.Btn_Edit.UseVisualStyleBackColor = True
        '
        'Btn_Select_Company
        '
        Me.Btn_Select_Company.Location = New System.Drawing.Point(170, 87)
        Me.Btn_Select_Company.Name = "Btn_Select_Company"
        Me.Btn_Select_Company.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_Select_Company.Size = New System.Drawing.Size(106, 27)
        Me.Btn_Select_Company.TabIndex = 1
        Me.Btn_Select_Company.Text = "Select"
        Me.Btn_Select_Company.UseVisualStyleBackColor = True
        '
        'Txt_Address
        '
        Me.Txt_Address.Location = New System.Drawing.Point(145, 222)
        Me.Txt_Address.Multiline = True
        Me.Txt_Address.Name = "Txt_Address"
        Me.Txt_Address.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Address.Size = New System.Drawing.Size(169, 92)
        Me.Txt_Address.TabIndex = 6
        Me.Txt_Address.Visible = False
        '
        'Lbl_Com_Address
        '
        Me.Lbl_Com_Address.AutoSize = True
        Me.Lbl_Com_Address.Location = New System.Drawing.Point(17, 222)
        Me.Lbl_Com_Address.Name = "Lbl_Com_Address"
        Me.Lbl_Com_Address.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lbl_Com_Address.Size = New System.Drawing.Size(122, 20)
        Me.Lbl_Com_Address.TabIndex = 5
        Me.Lbl_Com_Address.Text = "Com. Address :-"
        Me.Lbl_Com_Address.Visible = False
        '
        'Txt_Com_Name
        '
        Me.Txt_Com_Name.Location = New System.Drawing.Point(145, 192)
        Me.Txt_Com_Name.Name = "Txt_Com_Name"
        Me.Txt_Com_Name.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Com_Name.Size = New System.Drawing.Size(169, 26)
        Me.Txt_Com_Name.TabIndex = 4
        Me.Txt_Com_Name.Visible = False
        '
        'Lbl_Name_of_Company
        '
        Me.Lbl_Name_of_Company.AutoSize = True
        Me.Lbl_Name_of_Company.Location = New System.Drawing.Point(4, 195)
        Me.Lbl_Name_of_Company.Name = "Lbl_Name_of_Company"
        Me.Lbl_Name_of_Company.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lbl_Name_of_Company.Size = New System.Drawing.Size(135, 20)
        Me.Lbl_Name_of_Company.TabIndex = 3
        Me.Lbl_Name_of_Company.Text = "Company Name :-"
        Me.Lbl_Name_of_Company.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lbl_Name_of_Company.Visible = False
        '
        'Btn_CC
        '
        Me.Btn_CC.Location = New System.Drawing.Point(170, 57)
        Me.Btn_CC.Name = "Btn_CC"
        Me.Btn_CC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_CC.Size = New System.Drawing.Size(106, 27)
        Me.Btn_CC.TabIndex = 0
        Me.Btn_CC.Text = "Create Company"
        Me.Btn_CC.UseVisualStyleBackColor = True
        '
        'Box_Company
        '
        Me.Box_Company.BackColor = System.Drawing.Color.White
        Me.Box_Company.Controls.Add(Me.Lbl_Selected_Company)
        Me.Box_Company.Controls.Add(Me.Lbl_Com_Names)
        Me.Box_Company.Controls.Add(Me.Lbl_Company_Header)
        Me.Box_Company.Dock = System.Windows.Forms.DockStyle.Left
        Me.Box_Company.ForeColor = System.Drawing.Color.DarkBlue
        Me.Box_Company.Location = New System.Drawing.Point(3, 3)
        Me.Box_Company.Name = "Box_Company"
        Me.Box_Company.Size = New System.Drawing.Size(385, 396)
        Me.Box_Company.TabIndex = 0
        Me.Box_Company.TabStop = False
        Me.Box_Company.Text = " --- Company --- "
        '
        'Lbl_Selected_Company
        '
        Me.Lbl_Selected_Company.AutoSize = True
        Me.Lbl_Selected_Company.Enabled = False
        Me.Lbl_Selected_Company.Location = New System.Drawing.Point(29, 56)
        Me.Lbl_Selected_Company.Name = "Lbl_Selected_Company"
        Me.Lbl_Selected_Company.Size = New System.Drawing.Size(0, 20)
        Me.Lbl_Selected_Company.TabIndex = 0
        '
        'Lbl_Com_Names
        '
        Me.Lbl_Com_Names.AutoSize = True
        Me.Lbl_Com_Names.BackColor = System.Drawing.Color.Gainsboro
        Me.Lbl_Com_Names.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lbl_Com_Names.ForeColor = System.Drawing.Color.SteelBlue
        Me.Lbl_Com_Names.Location = New System.Drawing.Point(18, 180)
        Me.Lbl_Com_Names.Name = "Lbl_Com_Names"
        Me.Lbl_Com_Names.Size = New System.Drawing.Size(155, 20)
        Me.Lbl_Com_Names.TabIndex = 2
        Me.Lbl_Com_Names.Text = "No company created"
        '
        'Lbl_Company_Header
        '
        Me.Lbl_Company_Header.AutoSize = True
        Me.Lbl_Company_Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Company_Header.Location = New System.Drawing.Point(4, 125)
        Me.Lbl_Company_Header.Name = "Lbl_Company_Header"
        Me.Lbl_Company_Header.Size = New System.Drawing.Size(374, 20)
        Me.Lbl_Company_Header.TabIndex = 1
        Me.Lbl_Company_Header.Text = "------------------- No Company is Selected ----------------- "
        '
        'Tab_Vouchers
        '
        Me.Tab_Vouchers.Controls.Add(Me.Tab_Sub_Voucher)
        Me.Tab_Vouchers.Location = New System.Drawing.Point(4, 29)
        Me.Tab_Vouchers.Name = "Tab_Vouchers"
        Me.Tab_Vouchers.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Vouchers.Size = New System.Drawing.Size(1241, 402)
        Me.Tab_Vouchers.TabIndex = 1
        Me.Tab_Vouchers.Text = "Vouchers"
        Me.Tab_Vouchers.UseVisualStyleBackColor = True
        '
        'Tab_Sub_Voucher
        '
        Me.Tab_Sub_Voucher.Controls.Add(Me.Tab_Reciept)
        Me.Tab_Sub_Voucher.Controls.Add(Me.Tab_Purchase)
        Me.Tab_Sub_Voucher.Controls.Add(Me.Tab_Sales)
        Me.Tab_Sub_Voucher.Controls.Add(Me.Tab_Payment)
        Me.Tab_Sub_Voucher.Controls.Add(Me.Tab_Contra)
        Me.Tab_Sub_Voucher.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Sub_Voucher.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab_Sub_Voucher.Location = New System.Drawing.Point(3, 3)
        Me.Tab_Sub_Voucher.Multiline = True
        Me.Tab_Sub_Voucher.Name = "Tab_Sub_Voucher"
        Me.Tab_Sub_Voucher.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tab_Sub_Voucher.SelectedIndex = 0
        Me.Tab_Sub_Voucher.Size = New System.Drawing.Size(1235, 396)
        Me.Tab_Sub_Voucher.TabIndex = 0
        '
        'Tab_Reciept
        '
        Me.Tab_Reciept.BackColor = System.Drawing.Color.Bisque
        Me.Tab_Reciept.Controls.Add(Me.Lbl_V_Counter)
        Me.Tab_Reciept.Controls.Add(Me.Panel1)
        Me.Tab_Reciept.Controls.Add(Me.Label2)
        Me.Tab_Reciept.Controls.Add(Me.Label1)
        Me.Tab_Reciept.Controls.Add(Me.DateTimePicker1)
        Me.Tab_Reciept.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab_Reciept.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Tab_Reciept.Location = New System.Drawing.Point(4, 28)
        Me.Tab_Reciept.Name = "Tab_Reciept"
        Me.Tab_Reciept.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Reciept.Size = New System.Drawing.Size(1227, 364)
        Me.Tab_Reciept.TabIndex = 0
        Me.Tab_Reciept.Text = "Reciept"
        '
        'Lbl_V_Counter
        '
        Me.Lbl_V_Counter.AutoSize = True
        Me.Lbl_V_Counter.BackColor = System.Drawing.Color.Coral
        Me.Lbl_V_Counter.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_V_Counter.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Lbl_V_Counter.Location = New System.Drawing.Point(355, 18)
        Me.Lbl_V_Counter.Name = "Lbl_V_Counter"
        Me.Lbl_V_Counter.Size = New System.Drawing.Size(36, 39)
        Me.Lbl_V_Counter.TabIndex = 1
        Me.Lbl_V_Counter.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Btn_Clr_V)
        Me.Panel1.Controls.Add(Me.Btn_V_Save)
        Me.Panel1.Controls.Add(Me.Label_To_2)
        Me.Panel1.Controls.Add(Me.Label_Dr_2)
        Me.Panel1.Controls.Add(Me.Txt_Cr_2)
        Me.Panel1.Controls.Add(Me.Txt_Dr_2)
        Me.Panel1.Controls.Add(Me.Txt_A_Cr_2)
        Me.Panel1.Controls.Add(Me.Txt_A_Dr_2)
        Me.Panel1.Controls.Add(Me.Label_to_1)
        Me.Panel1.Controls.Add(Me.Label_Dr_1)
        Me.Panel1.Controls.Add(Me.Txt_Cr_1)
        Me.Panel1.Controls.Add(Me.Txt_Dr_1)
        Me.Panel1.Controls.Add(Me.Txt_A_Cr_1)
        Me.Panel1.Controls.Add(Me.Txt_A_Dr_1)
        Me.Panel1.Controls.Add(Me.Label_To)
        Me.Panel1.Controls.Add(Me.Label_Dr)
        Me.Panel1.Controls.Add(Me.Label_Credit)
        Me.Panel1.Controls.Add(Me.Label_debit)
        Me.Panel1.Controls.Add(Me.Lable_Accounts)
        Me.Panel1.Controls.Add(Me.Txt_Cr)
        Me.Panel1.Controls.Add(Me.Txt_Dr)
        Me.Panel1.Controls.Add(Me.Txt_A_Cr)
        Me.Panel1.Controls.Add(Me.Txt_A_Dr)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1221, 284)
        Me.Panel1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(341, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Capation : -"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(432, 208)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(536, 51)
        Me.TextBox1.TabIndex = 22
        '
        'Btn_Clr_V
        '
        Me.Btn_Clr_V.Location = New System.Drawing.Point(228, 222)
        Me.Btn_Clr_V.Name = "Btn_Clr_V"
        Me.Btn_Clr_V.Size = New System.Drawing.Size(58, 38)
        Me.Btn_Clr_V.TabIndex = 24
        Me.Btn_Clr_V.Text = "Clear"
        Me.Btn_Clr_V.UseVisualStyleBackColor = True
        '
        'Btn_V_Save
        '
        Me.Btn_V_Save.Location = New System.Drawing.Point(102, 222)
        Me.Btn_V_Save.Name = "Btn_V_Save"
        Me.Btn_V_Save.Size = New System.Drawing.Size(120, 38)
        Me.Btn_V_Save.TabIndex = 23
        Me.Btn_V_Save.Text = "Save Voucher"
        Me.Btn_V_Save.UseVisualStyleBackColor = True
        '
        'Label_To_2
        '
        Me.Label_To_2.AutoSize = True
        Me.Label_To_2.Location = New System.Drawing.Point(247, 102)
        Me.Label_To_2.Name = "Label_To_2"
        Me.Label_To_2.Size = New System.Drawing.Size(27, 20)
        Me.Label_To_2.TabIndex = 17
        Me.Label_To_2.Text = "To"
        Me.Label_To_2.Visible = False
        '
        'Label_Dr_2
        '
        Me.Label_Dr_2.AutoSize = True
        Me.Label_Dr_2.Location = New System.Drawing.Point(98, 101)
        Me.Label_Dr_2.Name = "Label_Dr_2"
        Me.Label_Dr_2.Size = New System.Drawing.Size(30, 20)
        Me.Label_Dr_2.TabIndex = 15
        Me.Label_Dr_2.Text = "Dr."
        Me.Label_Dr_2.Visible = False
        '
        'Txt_Cr_2
        '
        Me.Txt_Cr_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Cr_2.Location = New System.Drawing.Point(851, 102)
        Me.Txt_Cr_2.Name = "Txt_Cr_2"
        Me.Txt_Cr_2.Size = New System.Drawing.Size(100, 19)
        Me.Txt_Cr_2.TabIndex = 20
        Me.Txt_Cr_2.Visible = False
        '
        'Txt_Dr_2
        '
        Me.Txt_Dr_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Dr_2.Location = New System.Drawing.Point(607, 102)
        Me.Txt_Dr_2.Name = "Txt_Dr_2"
        Me.Txt_Dr_2.Size = New System.Drawing.Size(100, 19)
        Me.Txt_Dr_2.TabIndex = 19
        Me.Txt_Dr_2.Visible = False
        '
        'Txt_A_Cr_2
        '
        Me.Txt_A_Cr_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_A_Cr_2.Location = New System.Drawing.Point(288, 102)
        Me.Txt_A_Cr_2.Name = "Txt_A_Cr_2"
        Me.Txt_A_Cr_2.Size = New System.Drawing.Size(100, 19)
        Me.Txt_A_Cr_2.TabIndex = 18
        Me.Txt_A_Cr_2.Visible = False
        '
        'Txt_A_Dr_2
        '
        Me.Txt_A_Dr_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_A_Dr_2.Location = New System.Drawing.Point(134, 102)
        Me.Txt_A_Dr_2.Name = "Txt_A_Dr_2"
        Me.Txt_A_Dr_2.Size = New System.Drawing.Size(100, 19)
        Me.Txt_A_Dr_2.TabIndex = 16
        Me.Txt_A_Dr_2.Visible = False
        '
        'Label_to_1
        '
        Me.Label_to_1.AutoSize = True
        Me.Label_to_1.Location = New System.Drawing.Point(247, 77)
        Me.Label_to_1.Name = "Label_to_1"
        Me.Label_to_1.Size = New System.Drawing.Size(27, 20)
        Me.Label_to_1.TabIndex = 11
        Me.Label_to_1.Text = "To"
        Me.Label_to_1.Visible = False
        '
        'Label_Dr_1
        '
        Me.Label_Dr_1.AutoSize = True
        Me.Label_Dr_1.Location = New System.Drawing.Point(98, 76)
        Me.Label_Dr_1.Name = "Label_Dr_1"
        Me.Label_Dr_1.Size = New System.Drawing.Size(30, 20)
        Me.Label_Dr_1.TabIndex = 9
        Me.Label_Dr_1.Text = "Dr."
        Me.Label_Dr_1.Visible = False
        '
        'Txt_Cr_1
        '
        Me.Txt_Cr_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Cr_1.Location = New System.Drawing.Point(851, 77)
        Me.Txt_Cr_1.Name = "Txt_Cr_1"
        Me.Txt_Cr_1.Size = New System.Drawing.Size(100, 19)
        Me.Txt_Cr_1.TabIndex = 14
        Me.Txt_Cr_1.Visible = False
        '
        'Txt_Dr_1
        '
        Me.Txt_Dr_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Dr_1.Location = New System.Drawing.Point(607, 77)
        Me.Txt_Dr_1.Name = "Txt_Dr_1"
        Me.Txt_Dr_1.Size = New System.Drawing.Size(100, 19)
        Me.Txt_Dr_1.TabIndex = 13
        Me.Txt_Dr_1.Visible = False
        '
        'Txt_A_Cr_1
        '
        Me.Txt_A_Cr_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_A_Cr_1.Location = New System.Drawing.Point(288, 77)
        Me.Txt_A_Cr_1.Name = "Txt_A_Cr_1"
        Me.Txt_A_Cr_1.Size = New System.Drawing.Size(100, 19)
        Me.Txt_A_Cr_1.TabIndex = 12
        Me.Txt_A_Cr_1.Visible = False
        '
        'Txt_A_Dr_1
        '
        Me.Txt_A_Dr_1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_A_Dr_1.Location = New System.Drawing.Point(134, 77)
        Me.Txt_A_Dr_1.Name = "Txt_A_Dr_1"
        Me.Txt_A_Dr_1.Size = New System.Drawing.Size(100, 19)
        Me.Txt_A_Dr_1.TabIndex = 10
        Me.Txt_A_Dr_1.Visible = False
        '
        'Label_To
        '
        Me.Label_To.AutoSize = True
        Me.Label_To.Location = New System.Drawing.Point(247, 52)
        Me.Label_To.Name = "Label_To"
        Me.Label_To.Size = New System.Drawing.Size(27, 20)
        Me.Label_To.TabIndex = 5
        Me.Label_To.Text = "To"
        '
        'Label_Dr
        '
        Me.Label_Dr.AutoSize = True
        Me.Label_Dr.Location = New System.Drawing.Point(98, 51)
        Me.Label_Dr.Name = "Label_Dr"
        Me.Label_Dr.Size = New System.Drawing.Size(30, 20)
        Me.Label_Dr.TabIndex = 3
        Me.Label_Dr.Text = "Dr."
        '
        'Label_Credit
        '
        Me.Label_Credit.AutoSize = True
        Me.Label_Credit.Location = New System.Drawing.Point(874, 10)
        Me.Label_Credit.Name = "Label_Credit"
        Me.Label_Credit.Size = New System.Drawing.Size(51, 20)
        Me.Label_Credit.TabIndex = 2
        Me.Label_Credit.Text = "Credit"
        '
        'Label_debit
        '
        Me.Label_debit.AutoSize = True
        Me.Label_debit.Location = New System.Drawing.Point(635, 10)
        Me.Label_debit.Name = "Label_debit"
        Me.Label_debit.Size = New System.Drawing.Size(47, 20)
        Me.Label_debit.TabIndex = 1
        Me.Label_debit.Text = "Debit"
        '
        'Lable_Accounts
        '
        Me.Lable_Accounts.AutoSize = True
        Me.Lable_Accounts.Location = New System.Drawing.Point(146, 10)
        Me.Lable_Accounts.Name = "Lable_Accounts"
        Me.Lable_Accounts.Size = New System.Drawing.Size(76, 20)
        Me.Lable_Accounts.TabIndex = 0
        Me.Lable_Accounts.Text = "Accounts"
        '
        'Txt_Cr
        '
        Me.Txt_Cr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Cr.Location = New System.Drawing.Point(851, 52)
        Me.Txt_Cr.Name = "Txt_Cr"
        Me.Txt_Cr.Size = New System.Drawing.Size(100, 19)
        Me.Txt_Cr.TabIndex = 8
        '
        'Txt_Dr
        '
        Me.Txt_Dr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Dr.Location = New System.Drawing.Point(607, 52)
        Me.Txt_Dr.Name = "Txt_Dr"
        Me.Txt_Dr.Size = New System.Drawing.Size(100, 19)
        Me.Txt_Dr.TabIndex = 7
        '
        'Txt_A_Cr
        '
        Me.Txt_A_Cr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_A_Cr.Location = New System.Drawing.Point(288, 52)
        Me.Txt_A_Cr.Name = "Txt_A_Cr"
        Me.Txt_A_Cr.Size = New System.Drawing.Size(100, 19)
        Me.Txt_A_Cr.TabIndex = 6
        '
        'Txt_A_Dr
        '
        Me.Txt_A_Dr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_A_Dr.Location = New System.Drawing.Point(134, 52)
        Me.Txt_A_Dr.Name = "Txt_A_Dr"
        Me.Txt_A_Dr.Size = New System.Drawing.Size(100, 19)
        Me.Txt_A_Dr.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.SandyBrown
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(308, 50)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Reciept Voucher"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(511, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Date : -"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(578, 6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(274, 27)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Tab_Purchase
        '
        Me.Tab_Purchase.Location = New System.Drawing.Point(4, 28)
        Me.Tab_Purchase.Name = "Tab_Purchase"
        Me.Tab_Purchase.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Purchase.Size = New System.Drawing.Size(1227, 364)
        Me.Tab_Purchase.TabIndex = 1
        Me.Tab_Purchase.Text = "Purchase"
        Me.Tab_Purchase.UseVisualStyleBackColor = True
        '
        'Tab_Sales
        '
        Me.Tab_Sales.Location = New System.Drawing.Point(4, 28)
        Me.Tab_Sales.Name = "Tab_Sales"
        Me.Tab_Sales.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Sales.Size = New System.Drawing.Size(1227, 364)
        Me.Tab_Sales.TabIndex = 2
        Me.Tab_Sales.Text = "Sales"
        Me.Tab_Sales.UseVisualStyleBackColor = True
        '
        'Tab_Payment
        '
        Me.Tab_Payment.Location = New System.Drawing.Point(4, 28)
        Me.Tab_Payment.Name = "Tab_Payment"
        Me.Tab_Payment.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Payment.Size = New System.Drawing.Size(1227, 364)
        Me.Tab_Payment.TabIndex = 3
        Me.Tab_Payment.Text = "Payment"
        Me.Tab_Payment.UseVisualStyleBackColor = True
        '
        'Tab_Contra
        '
        Me.Tab_Contra.Location = New System.Drawing.Point(4, 28)
        Me.Tab_Contra.Name = "Tab_Contra"
        Me.Tab_Contra.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Contra.Size = New System.Drawing.Size(1227, 364)
        Me.Tab_Contra.TabIndex = 4
        Me.Tab_Contra.Text = "Contra"
        Me.Tab_Contra.UseVisualStyleBackColor = True
        '
        'Tab_Accounts_Inventory
        '
        Me.Tab_Accounts_Inventory.Location = New System.Drawing.Point(4, 29)
        Me.Tab_Accounts_Inventory.Name = "Tab_Accounts_Inventory"
        Me.Tab_Accounts_Inventory.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Accounts_Inventory.Size = New System.Drawing.Size(1241, 402)
        Me.Tab_Accounts_Inventory.TabIndex = 2
        Me.Tab_Accounts_Inventory.Text = "Accounts & Inventory"
        Me.Tab_Accounts_Inventory.UseVisualStyleBackColor = True
        '
        'Tab_Display
        '
        Me.Tab_Display.Location = New System.Drawing.Point(4, 29)
        Me.Tab_Display.Name = "Tab_Display"
        Me.Tab_Display.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Display.Size = New System.Drawing.Size(1241, 402)
        Me.Tab_Display.TabIndex = 3
        Me.Tab_Display.Text = "Display"
        Me.Tab_Display.UseVisualStyleBackColor = True
        '
        'Tab_Setting
        '
        Me.Tab_Setting.Location = New System.Drawing.Point(4, 29)
        Me.Tab_Setting.Name = "Tab_Setting"
        Me.Tab_Setting.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Setting.Size = New System.Drawing.Size(1241, 402)
        Me.Tab_Setting.TabIndex = 4
        Me.Tab_Setting.Text = "Settings"
        Me.Tab_Setting.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 413)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1249, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ToolStripStatusLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(205, 17)
        Me.ToolStripStatusLabel1.Text = "Welcome to the Teachno Account 1.0"
        '
        'Techno_Accounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1249, 435)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Tab_Main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Techno_Accounts"
        Me.Text = "Teachno_Accounts"
        Me.Tab_Main.ResumeLayout(False)
        Me.Tab_Company.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Box_Company.ResumeLayout(False)
        Me.Box_Company.PerformLayout()
        Me.Tab_Vouchers.ResumeLayout(False)
        Me.Tab_Sub_Voucher.ResumeLayout(False)
        Me.Tab_Reciept.ResumeLayout(False)
        Me.Tab_Reciept.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tab_Main As System.Windows.Forms.TabControl
    Friend WithEvents Tab_Company As System.Windows.Forms.TabPage
    Friend WithEvents Btn_AC As System.Windows.Forms.Button
    Friend WithEvents Btn_SC As System.Windows.Forms.Button
    Friend WithEvents Lbl_Company_Header As System.Windows.Forms.Label
    Friend WithEvents Tab_Vouchers As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Accounts_Inventory As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Display As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Setting As TabPage
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Box_Company As GroupBox
    Friend WithEvents Lbl_Com_Names As Label
    Friend WithEvents Lbl_Selected_Company As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_Clear As Button
    Friend WithEvents Btn_Save As Button
    Friend WithEvents Btn_Edit As Button
    Friend WithEvents Btn_Select_Company As Button
    Friend WithEvents Txt_Address As TextBox
    Friend WithEvents Lbl_Com_Address As Label
    Friend WithEvents Txt_Com_Name As TextBox
    Private WithEvents Lbl_Name_of_Company As Label
    Friend WithEvents Btn_CC As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Tab_Sub_Voucher As TabControl
    Friend WithEvents Tab_Reciept As TabPage
    Friend WithEvents Tab_Purchase As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Tab_Sales As TabPage
    Friend WithEvents Tab_Payment As TabPage
    Friend WithEvents Tab_Contra As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Txt_A_Dr As TextBox
    Friend WithEvents Lable_Accounts As Label
    Friend WithEvents Label_To As Label
    Friend WithEvents Label_Dr As Label
    Friend WithEvents Label_Credit As Label
    Friend WithEvents Label_debit As Label
    Friend WithEvents Txt_A_Cr As TextBox
    Friend WithEvents Txt_Cr As TextBox
    Friend WithEvents Txt_Dr As TextBox
    Friend WithEvents Btn_V_Save As Button
    Friend WithEvents Label_To_2 As Label
    Friend WithEvents Label_Dr_2 As Label
    Friend WithEvents Txt_Cr_2 As TextBox
    Friend WithEvents Txt_Dr_2 As TextBox
    Friend WithEvents Txt_A_Cr_2 As TextBox
    Friend WithEvents Txt_A_Dr_2 As TextBox
    Friend WithEvents Label_to_1 As Label
    Friend WithEvents Label_Dr_1 As Label
    Friend WithEvents Txt_Cr_1 As TextBox
    Friend WithEvents Txt_Dr_1 As TextBox
    Friend WithEvents Txt_A_Cr_1 As TextBox
    Friend WithEvents Txt_A_Dr_1 As TextBox
    Friend WithEvents Btn_Clr_V As Button
    Friend WithEvents Lbl_V_Counter As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
End Class