Public Class Inventory
    'Member Variables
    Private strInvNumber As String 'Invoice number
    Private strDescription As String
    Private dblCost As Double
    Private dblRetail As Double
    Private intOnHand As Integer

    'Contructor
    Public Sub New()
        Debug.WriteLine("Inventory object being created.")
        strInvNumber = "(unknown)"
        strDescription = "(unknown)"
        dblCost = 0.0
        dblRetail = 0.0
        intOnHand = 0
    End Sub

    Public Property InvNumber() As String
        Get
            Return strInvNumber
        End Get
        Set(value As String)
            strInvNumber = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return strDescription
        End Get
        Set(value As String)
            strDescription = value
        End Set
    End Property

    Public Property Cost() As Double
        Get
            Return dblCost
        End Get
        Set(value As Double)
            dblCost = value
        End Set
    End Property

    Public Property Retail() As Double
        Get
            Return dblRetail
        End Get
        Set(value As Double)
            dblRetail = value
        End Set
    End Property

    Public Property OnHand() As Integer
        Get
            Return intOnHand
        End Get
        Set(value As Integer)
            intOnHand = value
        End Set
    End Property

End Class
