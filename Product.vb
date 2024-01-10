' Product.vb

Public Class Product
    Private _productId As Integer
    Private _name As String
    Private _price As Double

    Public Sub New(productId As Integer, name As String, price As Double)
        _productId = productId
        _name = name
        _price = price
    End Sub

    Public Sub Display()
        Console.WriteLine($"Product ID: {_productId}, Name: {_name}, Price: ${_price}")
    End Sub
End Class
