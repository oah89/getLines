Public Class Groupe
    Private _idGroup As Integer
    Private _numGroup As String
    Private _groupName As String

    Public Sub New(idGroupe As Integer, numGroup As String, groupName As String)
        _idGroup = idGroupe
        _numGroup = numGroup
        _groupName = groupName
    End Sub

    Public Sub New()
    End Sub
    Public Property idGroup() As Integer
        Get
            Return _idGroup
        End Get
        Set(ByVal value As Integer)
            _idGroup = value
        End Set
    End Property
    Public Property numGroup() As String
        Get
            Return _numGroup
        End Get
        Set(ByVal value As String)
            _numGroup = value
        End Set
    End Property


    Public Property groupName() As String
        Get
            Return _groupName
        End Get
        Set(ByVal value As String)
            _groupName = value
        End Set
    End Property



End Class
