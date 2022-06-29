Public Class Rectangle
    Private sngWidth As Single      ' To hold the width
    Private sngLength As Single     ' To hold the length
    Private sngArea As Single       ' To hold the area

    ' Constructor
    Public Sub New()
        sngWidth = 0.0F
        sngLength = 0.0F
        sngArea = 0.0F
    End Sub

    ' Width property
    Public Property Width As Single
        Get
            Return sngWidth
        End Get
        Set(ByVal value As Single)
            sngWidth = value
        End Set
    End Property

    ' Length property
    Public Property Length As Single
        Get
            Return (sngLength)
        End Get
        Set(ByVal value As Single)
            sngLength = value
        End Set
    End Property

    ' Read-Only Area property
    Public ReadOnly Property Area As Single
        Get
            CalcArea()
            Return sngArea
        End Get
    End Property

    ' CalcArea method
    Private Sub CalcArea()
        sngArea = sngLength * sngWidth
    End Sub
End Class
