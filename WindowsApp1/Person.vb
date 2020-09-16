Public Class Person


    Public Sub New()
    End Sub

    Private _idPerson As Integer
    Private _cin As String
    Private _nameFirst As String
    Private _nameFamily As String
    Private _adresse As String
    Private _isChef As Boolean
    Private _numBureau As Integer
    Private _idGroup As Integer


    Public Property idGroup() As Integer
        Get
            Return _idGroup
        End Get
        Set(ByVal value As Integer)
            _idGroup = value
        End Set
    End Property

    Public Property numBureau() As Integer
        Get
            Return _numBureau
        End Get
        Set(ByVal value As Integer)
            _numBureau = value
        End Set
    End Property

    Public Property nameFirst() As String
        Get
            Return _nameFirst
        End Get
        Set(ByVal value As String)
            _nameFirst = value
        End Set
    End Property

    Public Property idPerson() As String
        Get
            Return _idPerson
        End Get
        Set(ByVal value As String)
            _idPerson = value
        End Set
    End Property

    Public Property nameFamily() As String
        Get
            Return _nameFamily
        End Get
        Set(ByVal value As String)
            _nameFamily = value
        End Set
    End Property

    Public Property cin() As String
        Get
            Return _cin
        End Get
        Set(ByVal value As String)
            _cin = value
        End Set
    End Property

    Public Property adresse() As String
        Get
            Return _adresse
        End Get
        Set(ByVal value As String)
            _adresse = value
        End Set
    End Property
    Public Property isChef() As Boolean
        Get
            Return _isChef
        End Get
        Set(ByVal value As Boolean)
            _isChef = value
        End Set
    End Property



    Public Sub New(idPerson As Integer, cin As String, nameFirst As String, nameFamily As String, adresse As String, isChef As Boolean)
        Me._idPerson = idPerson
        Me._cin = cin
        Me._nameFirst = nameFirst
        Me._nameFamily = nameFamily
        Me._adresse = adresse
        Me._isChef = isChef
    End Sub

    Public Sub New(idPerson As Integer, cin As String, nameFirst As String, nameFamily As String, adresse As String)
        _idPerson = idPerson
        _cin = cin
        _nameFirst = nameFirst
        _nameFamily = nameFamily
        _adresse = adresse
    End Sub
    Public Sub New(idPerson As Integer, cin As String, nameFirst As String, nameFamily As String)
        _idPerson = idPerson
        _cin = cin
        _nameFirst = nameFirst
        _nameFamily = nameFamily
    End Sub
    Public Sub New(idPerson As Integer, cin As String, nameFirst As String, nameFamily As String, statut As String, numBureau As Integer)
        _idPerson = idPerson
        _cin = cin
        _nameFirst = nameFirst
        _nameFamily = nameFamily
        _numBureau = numBureau
    End Sub
    Public Sub New(idPerson As Integer, cin As String, nameFirst As String, nameFamily As String, idGroup As Integer, numBureau As Integer)
        '  idPerson,cin,nameFirst,nameFamily,idGroup,numBureau
        _idPerson = idPerson
        _cin = cin
        _nameFirst = nameFirst
        _nameFamily = nameFamily
        _idGroup = idGroup
        _numBureau = numBureau
    End Sub

    'Public Function personToString() As String
    '    Return _idPerson & " " & _cin & " " & _nameFirst & " " & nameFamily & " " & adresse & " " & isChef
    'End Function

    'Public Function personToString() As String
    '    Return "C.I.N :" & _cin & vbNewLine & "Prénom : " & _nameFirst & vbNewLine & "Nom : " & nameFamily & vbNewLine & " Adresse : " & adresse
    'End Function

    Public Function personToString() As String
        Return "Prénom : " & _nameFirst & vbNewLine & "Nom     : " & nameFamily
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString
    End Function

    Public Sub New(cin As String, nameFirst As String, nameFamily As String, adresse As String)
        _cin = remplaceSpecialCaracter(cin)
        _nameFirst = remplaceSpecialCaracter(nameFirst)
        _nameFamily = remplaceSpecialCaracter(nameFamily)
        _adresse = remplaceSpecialCaracter(adresse)
        _isChef = 0
    End Sub

    Public Sub New(idPerson As Integer, cin As String, nameFirst As String, nameFamily As String, idGroup As Integer)
        Me.New(idPerson, cin, nameFirst, nameFamily)
        _idGroup = idGroup
    End Sub

    Function remplaceSpecialCaracter(str As String) As String
        ' str = str.Replace(" '", "@_@")

        Return str.Replace("'", "@_@")
    End Function


    'Private _idPerson As Integer
    'Private _cin As String
    'Private _nameFirst As String
    'Private _nameFamily As String
    'Private _adresse As String
    'Private _isChef As Boolean



End Class
