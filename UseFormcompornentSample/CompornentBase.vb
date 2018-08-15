Public Class CompornentBase
    Public Sub New(ByRef parent As Form, ByVal location As Point, Optional ByVal txt As String = "loaded")
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        '別のフォームに設定するための準備
        With Me
            .TopLevel = False
            .Visible = True
            .Location = location
        End With

        parent.Controls.Add(Me) '親コンポーネントに自分を加える

        Button1.Text = txt
    End Sub
End Class
