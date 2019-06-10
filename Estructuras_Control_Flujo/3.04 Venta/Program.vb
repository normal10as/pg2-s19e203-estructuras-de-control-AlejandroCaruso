Imports System

Module Venta
    Sub Main()
        Dim cantidad As Int16
        Dim precio, descuento, montoDescontado, total, subtotal As Double
        Dim porcentajeDescuento As String
        Console.WriteLine("Ingrese la cantidad a comprar")
        cantidad = Console.ReadLine()
        Console.WriteLine("Ingrese el precio del producto")
        precio = Console.ReadLine()
        descuento = 0
        porcentajeDescuento = "0%"
        If cantidad >= 10 And cantidad <= 50 Then
            descuento = 0.05
            porcentajeDescuento = "5%"
        ElseIf cantidad >= 51 And cantidad <= 250 Then
            descuento = 0.1
            porcentajeDescuento = "10%"
        ElseIf cantidad > 250 Then
            descuento = 0.2
            porcentajeDescuento = "20%"
        End If
        subtotal = cantidad * precio
        montoDescontado = subtotal * descuento
        total = subtotal - montoDescontado
        Console.WriteLine("Subtotal: ${0},00 ", subtotal)
        Console.WriteLine("Descuento: {0}  (${1},00)", porcentajeDescuento, montoDescontado)
        Console.WriteLine("Total: ${0},00", total)
    End Sub
End Module
