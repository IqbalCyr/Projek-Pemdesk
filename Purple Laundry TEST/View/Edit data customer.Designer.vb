<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_data_customer
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
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Label4 = New Label()
        Button1 = New Button()
        Panel1 = New Panel()
        Button2 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nama Lengkap"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 84)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(404, 27)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 2
        Label2.Text = "No Telepon"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(12, 137)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(404, 27)
        TextBox2.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 167)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 20)
        Label3.TabIndex = 4
        Label3.Text = "Alamat"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(12, 190)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(404, 27)
        TextBox3.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(160, 20)
        Label4.TabIndex = 6
        Label4.Text = "EDIT DATA CUSTOMER"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(20), CByte(145), CByte(155))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(107, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 48)
        Button1.TabIndex = 7
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(212, 352)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(204, 48)
        Panel1.TabIndex = 8
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.Red
        Button2.Location = New Point(7, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 42)
        Button2.TabIndex = 8
        Button2.Text = "Hapus"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Edit_data_customer
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(441, 441)
        Controls.Add(Panel1)
        Controls.Add(Label4)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        MaximumSize = New Size(459, 488)
        MinimumSize = New Size(459, 488)
        Name = "Edit_data_customer"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Edit_data_customer"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
End Class
