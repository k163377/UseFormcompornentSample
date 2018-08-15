Public Class Parent
    Private Sub Parent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim compo1 = New CompornentBase(Me, New Point(0, 0))
        Dim compo2 = New CompornentBase(Me, New Point(0, 200), "compo2")
    End Sub
End Class