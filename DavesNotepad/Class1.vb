Public Class AClass

    Private Sub DoSomething()

    End Sub

    Private Function ReturnAString() As String
        Dim ReturnValue As String = ""

        Return ReturnValue
    End Function

    ' Externally, the variable name should describe what it is for, not what it is.
    ' To find out what a variable is, Intelli-Sense helps us, so don't call things
    '     names like strName or NameString or similar.
    Private Sub DoSomethingWithThis(ByVal Name As String, ByVal Age As Integer)
        Dim MyValue As Integer = 0
        ' Internally, the name standard is a little relaxed,
        ' and I am happy for you to do basically whatever you are happy with

    End Sub

End Class
