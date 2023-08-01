<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Panel5 = New Panel()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        Panel6 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(415, 504)
        Panel1.TabIndex = 0
        ' 
        ' Panel5
        ' 
        Panel5.Location = New Point(332, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(80, 504)
        Panel5.TabIndex = 1
        ' 
        ' Panel4
        ' 
        Panel4.Location = New Point(247, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(88, 504)
        Panel4.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(160, -2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(90, 506)
        Panel3.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(76, -2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(86, 506)
        Panel2.TabIndex = 0
        ' 
        ' Panel6
        ' 
        Panel6.Location = New Point(0, -2)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(76, 511)
        Panel6.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(412, 504)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
End Class
