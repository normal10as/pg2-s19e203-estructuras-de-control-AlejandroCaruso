Imports System

Module Venta2
    Sub Main()
        Dim cantidad As Int16
        Dim precio, descuento, montoDescontado, total, subtotal As Double
        Dim porcentajeDescuento As String
        Console.WriteLine("Ingrese la cantidad a comprar")
        cantidad = Console.ReadLine()
        Console.WriteLine("Ingrese el precio del producto")
        precio = Console.ReadLine()
        Select Case cantidad
            Case 1 To 9
                descuento = 0
                porcentajeDescuento = "0%"
            Case 10 To 50
                descuento = 0.05
                porcentajeDescuento = "5%"
            Case 51 To 250
                descuento = 0.1
                porcentajeDescuento = "10%"
            Case Is > 251
                descuento = 0.2
                porcentajeDescuento = "20%"
            Case Else
                Console.WriteLine("No se Ingreso una cantidad correspondiente")
                descuento = 0
                porcentajeDescuento = "0%"
        End Select
        subtotal = cantidad * precio
        montoDescontado = subtotal * descuento
        total = subtotal - montoDescontado
        Console.WriteLine("Subtotal: ${0},00 ", subtotal)
        Console.WriteLine("Descuento: {0}  (${1},00)", porcentajeDescuento, montoDescontado)
        Console.WriteLine("Total: ${0},00", total)
    End Sub
End Module
