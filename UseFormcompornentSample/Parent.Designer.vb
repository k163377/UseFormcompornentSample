<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Parent
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MyCompornent = New UseFormcompornentSample.CompornentBase()
        Me.SuspendLayout()
        '
        'MyCompornent
        '
        Me.MyCompornent.BackColor = System.Drawing.Color.SpringGreen
        Me.MyCompornent.ClientSize = New System.Drawing.Size(200, 100)
        Me.MyCompornent.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MyCompornent.Location = New System.Drawing.Point(81, 73)
        Me.MyCompornent.Name = "MyCompornent"
        Me.MyCompornent.Text = "Form1"
        '
        'Parent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MyCompornent)
        Me.Name = "Parent"
        Me.Text = "Parent"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MyCompornent As CompornentBase
End Class
