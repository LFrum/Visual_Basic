Public Class Customer
    Inherits Person
    ' Private member variables
    Dim intCustomerNumber As Integer
    Dim blnMailingList As Boolean
    Dim strComments As String

    ' Constructor
    Public Sub New()
        intCustomerNumber = 0
        blnMailingList = False
        strComments = String.Empty
    End Sub

    ' CustomerNumber property
    Public Property CustomerNumber As Integer
        Get
            Return intCustomerNumber
        End Get
        Set(ByVal value As Integer)
            intCustomerNumber = value
        End Set
    End Property

    ' MailingList property
    Public Property MailingList As Boolean
        Get
            Return blnMailingList
        End Get
        Set(ByVal value As Boolean)
            blnMailingList = value
        End Set
    End Property

    ' Comments property
    Public Property Comments As String
        Get
            Return strComments
        End Get
        Set(ByVal value As String)
            strComments = value
        End Set
    End Property
End Class
