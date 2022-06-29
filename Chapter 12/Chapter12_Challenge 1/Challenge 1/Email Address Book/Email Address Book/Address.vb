Public Class Address
    ' Private member variables
    Private strName As String       ' To hold the name
    Private strEmail As String      ' To hold the e-mail address
    Private strPhone As String      ' To hold the phone number
    Private strComments As String   ' To hold the comments

    ' Constructor
    Public Sub New()
        strName = String.Empty
        strEmail = String.Empty
        strPhone = String.Empty
        strComments = String.Empty
    End Sub

    ' Name property
    Public Property Name() As String
        Get
            Return strName
        End Get
        Set(ByVal value As String)
            strName = value
        End Set
    End Property

    ' Email property
    Public Property Email As String
        Get
            Return strEmail
        End Get
        Set(ByVal value As String)
            strEmail = value
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

    ' Commenents property
    Public Property Comments As String
        Get
            Return strComments
        End Get
        Set(ByVal value As String)
            strComments = value
        End Set
    End Property
End Class
