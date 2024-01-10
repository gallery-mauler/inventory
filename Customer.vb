' Customer.vb

Public Class Customer
    Private _customerId As Integer
    Private _name As String
    Private _cart As New List(Of Product)

    Public Sub New(customerId As Integer, name As String)
        _customerId = customerId
        _name = name
    End Sub

    Public Sub AddToCart(product As Product)
        _cart.Add(product)
    End Sub

    Public Sub DisplayCart()
        Console.WriteLine($"Shopping Cart for Customer ID: {_customerId}, Name: {_name}")
        For Each product In _cart
            product.Display()
        Next
    End Sub
End Class
