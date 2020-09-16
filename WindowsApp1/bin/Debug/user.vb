Public Class user






    Private _login As String
    Private _password As String



    Public Sub New(login As String, password As String)
        _login = login
        _password = password
    End Sub
    Public Sub New()
    End Sub

    Public Property login() As String
        Get
            Return _login
        End Get
        Set(ByVal value As String)
            _login = value
        End Set
    End Property


    Public Property password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property


    Function userToString() As String

        Return "login=" & Me.login & vbNewLine & "password=" & Me.password
    End Function


End Class
