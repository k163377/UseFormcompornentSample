Public Class CompornentBase
    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        '別のフォームに設定するための準備
        With Me
            .TopLevel = False
            .Visible = True
        End With
    End Sub
End Class
