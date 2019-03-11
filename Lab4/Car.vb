Option Strict On
Public Class Car

    Private Shared carCount As Integer
    Private carIdentificationNumber As Integer = 0
    Private carModel As String = String.Empty
    Private carMake As String = String.Empty
    Private carPrice As Double = 0
    Private carYear As Integer = 0
    Private carNew As Boolean = False


    Public Sub New()
        carCount += 1
        carIdentificationNumber = carCount
    End Sub


    Public Sub New(model As String, make As String, price As Double, year As Integer, cnew As Boolean)
        Me.New()
        carModel = model
        carMake = make
        carPrice = price
        carYear = year
        carNew = cnew
    End Sub


    Public ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property

    Public ReadOnly Property IndentificationNumber() As Integer
        Get
            Return carIdentificationNumber
        End Get
    End Property

    Public Property NewC() As Boolean
        Get
            Return carNew
        End Get
        Set(ByVal value As Boolean)
            carNew = value
        End Set
    End Property

    Public Property Price() As Double
        Get
            Return carPrice
        End Get
        Set(ByVal value As Double)
            carPrice = value
        End Set
    End Property

    Public ReadOnly Property Year() As Integer
        Get
            Return carYear
        End Get
    End Property

    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(ByVal value As String)
            carModel = value
        End Set
    End Property

    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(ByVal value As String)
            carMake = value
        End Set
    End Property

    Public Function GetSalutation() As String

        Return "Hi my car model is " & carModel & " the year of the car is " & carYear & " The price id " & carPrice & ", " & IIf(carNew = True, "The car is new", "The car is not new").ToString()
    End Function
End Class
