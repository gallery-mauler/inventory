' Main.vb

Module Main
    Sub Main()
        ' Create products
        Dim laptop As New Product(1, "Laptop", 800.0)
        Dim smartphone As New Product(2, "Smartphone", 400.0)
        Dim headphones As New Product(3, "Headphones", 50.0)

        ' Create customers
        Dim alice As New Customer(1, "Alice")
        Dim bob As New Customer(2, "Bob")

        ' Create a shopping system
        Dim shoppingSystem As New ShoppingSystem()

        ' Add products to the system
        shoppingSystem.AddProduct(laptop)
        shoppingSystem.AddProduct(smartphone)
        shoppingSystem.AddProduct(headphones)

        ' Add customers to the system
        shoppingSystem.AddCustomer(alice)
        shoppingSystem.AddCustomer(bob)

        ' Create orders
        shoppingSystem.CreateOrder(1)
        shoppingSystem.CreateOrder(2)

        ' Add products to orders
        shoppingSystem.AddProductToOrder(1, laptop)
        shoppingSystem.AddProductToOrder(1, headphones)
        shoppingSystem.AddProductToOrder(2, smartphone)

        ' Display the system state
        shoppingSystem.DisplaySystemState()
    End Sub
End Module
