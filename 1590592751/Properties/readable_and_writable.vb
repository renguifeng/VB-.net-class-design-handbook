Imports System

Class Person
  Private MName As String
  Private MDob As DateTime
  Private MEmailAlias As String

  Public Sub New(ByVal Name As String, _
                 ByVal Dob As DateTime)
    MName = Name
    MDob = Dob
  End Sub

  Public Property Name() As String
    Get
      Return MName
    End Get

    Set(ByVal Value As String)
      MName = Value
    End Set
  End Property

  Public ReadOnly Property DOB() As DateTime
    Get
      Return MDob
    End Get
  End Property

  Public WriteOnly Property EmailAlias() As String
    Set(ByVal Value As String)
      MEmailAlias = Value
    End Set
  End Property

  Public ReadOnly Property EmailAddress() As String
    Get
      Return MEmailAlias & "@MyCompany.com"
    End Get
  End Property
End Class

Module ReadableAndWritable
  Sub Main()
    Dim APerson As New Person( _
      "Thomas Peter", New DateTime(1997, 7, 2))

    APerson.Name = "Tom"
    Console.WriteLine("Name: {0}", APerson.Name)

    Console.WriteLine("Date of birth: {0}", _
      APerson.DOB.ToLongDateString)

    APerson.EmailAlias = "Tom.Pete"

    Console.WriteLine("Email address: {0}", _
      APerson.EmailAddress)
    Console.ReadLine()
  End Sub
End Module
