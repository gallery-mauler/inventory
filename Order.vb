' Order.vb

Public Class Order
    Private _orderId As Integer
    Private _customer As Customer
    Private _orderedProducts As New List(Of Product)

    Public Sub New(orderId As Integer, customer As Customer)
        _orderId = orderId
        _customer = customer
    End Sub

    Public Sub AddProductToOrder(product As Product)
        _orderedProducts.Add(product)
    End Sub

    Public Sub DisplayOrder()
        Console.WriteLine($"Order ID: {_orderId}")
        Console.WriteLine("Customer Information:")
        _customer.DisplayCart()
        Console.WriteLine("Ordered Products:")
        For Each product In _orderedProducts
            product.Display()
        Next
    End Sub
End Class
