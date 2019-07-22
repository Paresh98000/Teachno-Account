<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Select_Company
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
        Me.Lst_Company = New System.Windows.Forms.ListBox()
        Me.Btn_Select = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lst_Company
        '
        Me.Lst_Company.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lst_Company.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_Company.FormattingEnabled = True
        Me.Lst_Company.ItemHeight = 25
        Me.Lst_Company.Location = New System.Drawing.Point(0, 0)
        Me.Lst_Company.Name = "Lst_Company"
        Me.Lst_Company.Size = New System.Drawing.Size(284, 154)
        Me.Lst_Company.TabIndex = 0
        '
        'Btn_Select
        '
        Me.Btn_Select.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Select.Location = New System.Drawing.Point(106, 218)
        Me.Btn_Select.Name = "Btn_Select"
        Me.Btn_Select.Size = New System.Drawing.Size(75, 31)
        Me.Btn_Select.TabIndex = 1
        Me.Btn_Select.Text = "Select"
        Me.Btn_Select.UseVisualStyleBackColor = True
        '
        'Select_Company
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Btn_Select)
        Me.Controls.Add(Me.Lst_Company)
        Me.Name = "Select_Company"
        Me.Text = "Select_Company"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lst_Company As ListBox
    Friend WithEvents Btn_Select As Button
End Class
