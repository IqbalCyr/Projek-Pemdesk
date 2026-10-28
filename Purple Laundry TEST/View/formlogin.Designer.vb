<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formlogin
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
        btnmsk = New Button()
        Cbktsndi = New CheckBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label4 = New Label()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' btnmsk
        ' 
        btnmsk.Location = New Point(167, 288)
        btnmsk.Margin = New Padding(2)
        btnmsk.Name = "btnmsk"
        btnmsk.Size = New Size(322, 27)
        btnmsk.TabIndex = 0
        btnmsk.Text = "MASUK"
        btnmsk.UseVisualStyleBackColor = True
        ' 
        ' Cbktsndi
        ' 
        Cbktsndi.AutoSize = True
        Cbktsndi.Font = New Font("Segoe UI", 7F)
        Cbktsndi.Location = New Point(167, 246)
        Cbktsndi.Margin = New Padding(2)
        Cbktsndi.Name = "Cbktsndi"
        Cbktsndi.Size = New Size(142, 19)
        Cbktsndi.TabIndex = 1
        Cbktsndi.Text = "Tampilkan Kata Sandi"
        Cbktsndi.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(122, 16)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(455, 62)
        Label1.TabIndex = 2
        Label1.Text = "PURPLE LAUNDRY"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F)
        Label2.Location = New Point(167, 123)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 3
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(167, 185)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 20)
        Label3.TabIndex = 4
        Label3.Text = "Kata Sandi"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(167, 146)
        TextBox1.Margin = New Padding(2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(322, 27)
        TextBox1.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(295, 170)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 20)
        Label4.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(167, 207)
        TextBox2.Margin = New Padding(2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(322, 27)
        TextBox2.TabIndex = 7
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' formlogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(640, 360)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Cbktsndi)
        Controls.Add(btnmsk)
        ForeColor = Color.Purple
        Margin = New Padding(2)
        Name = "formlogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "formlogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnmsk As Button
    Friend WithEvents Cbktsndi As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
End Class
