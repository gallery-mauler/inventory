' ShoppingSystem.vb

Public Class ShoppingSystem
    Private _products As New List(Of Product)
    Private _customers As New List(Of Customer)
    Private _orders As New List(Of Order)

    Public Sub AddProduct(product As Product)
        _products.Add(product)
    End Sub

    Public Sub AddCustomer(customer As Customer)
        _customers.Add(customer)
    End Sub

    Public Sub CreateOrder(customerId As Integer)
        Dim foundCustomer = _customers.FirstOrDefault(Function(c) c.CustomerId = customerId)

        If foundCustomer IsNot Nothing Then
            _orders.Add(New Order(_orders.Count + 1, foundCustomer))
        End If
    End Sub

    Public Sub AddProductToOrder(orderId As Integer, product As Product)
        Dim foundOrder = _orders.FirstOrDefault(Function(o) o.OrderId = orderId)

        If foundOrder IsNot Nothing Then
            foundOrder.AddProductToOrder(product)
        End If
    End Sub

    Public Sub DisplaySystemState()
        Console.WriteLine("Current System State:")

        Console.WriteLine(vbCrLf & "Products:")
        For Each product In _products
            product.Display()
        Next

        Console.WriteLine(vbCrLf & "Customers:")
        For Each customer In _customers
            customer.DisplayCart()
        Next

        Console.WriteLine(vbCrLf & "Orders:")
        For Each order In _orders
            order.DisplayOrder()
            Console.WriteLine()
        Next
    End Sub
End Class
