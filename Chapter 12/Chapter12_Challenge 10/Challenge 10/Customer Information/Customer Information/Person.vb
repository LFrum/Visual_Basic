Public Class Person
    ' Private member variables
    Dim strLastName As String
    Dim strFirstName As String
    Dim strAddress As String
    Dim strCity As String
    Dim strState As String
    Dim strZip As String
    Dim strPhone As String

    ' Constructor
    Public Sub New()
        strLastName = String.Empty
        strFirstName = String.Empty
        strAddress = String.Empty
        strCity = String.Empty
        strState = String.Empty
        strZip = String.Empty
        strPhone = String.Empty
    End Sub

    ' LastName property
    Public Property LastName As String
        Get
            Return strLastName
        End Get
        Set(ByVal value As String)
            strLastName = value
        End Set
    End Property

    ' FirstName property
    Public Property FirstName As String
        Get
            Return strFirstName
        End Get
        Set(ByVal value As String)
            strFirstName = value
        End Set
    End Property

    ' Address property
    Public Property Address As String
        Get
            Return strAddress
        End Get
        Set(ByVal value As String)
            strAddress = value
        End Set
    End Property

    ' City property
    Public Property City As String
        Get
            Return strCity
        End Get
        Set(ByVal value As String)
            strCity = value
        End Set
    End Property

    ' State property
    Public Property State As String
        Get
            Return strState
        End Get
        Set(ByVal value As String)
            strState = value
        End Set
    End Property

    ' Zip property
    Public Property Zip As String
        Get
            Return strZip
        End Get
        Set(ByVal value As String)
            strZip = value
        End Set
    End Property

    ' Phone property
    Public Property Phone As String
        Get
            Return strPhone
        End Get
        Set(ByVal value As String)
            strPhone = value
        End Set
    End Property
End Class
