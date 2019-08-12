Imports System

Module Descuento
    Sub Main()
        Dim cantidad, descuento As Int16
        Dim precioUnitario, precioTotal, subtotal, valorDescontado As Decimal
        Do
            Console.WriteLine("Ingrese la cantidad (0=Salir)")
            cantidad = Console.ReadLine()
            Console.WriteLine("Ingrese el precio unitario")
            precioUnitario = Console.ReadLine()
            Select Case cantidad
                Case 1 To 9
                    descuento = 0
                Case 10 To 50
                    descuento = 5
                Case 51 To 250
                    descuento = 10
                Case Is > 250
                    descuento = 20
            End Select
            subtotal = cantidad * precioUnitario
            valorDescontado = subtotal * descuento / 100
            precioTotal = subtotal - valorDescontado
            If cantidad <> 0 And cantidad < 10 Then
                Console.WriteLine("Cantidad: {0}", cantidad)
                Console.WriteLine("Precio unitario: ${0}", precioUnitario)
                Console.WriteLine("Precio final: ${0}", precioTotal)
            ElseIf cantidad <> 0 And cantidad >= 9 Then
                Console.WriteLine("Cantidad: {0}", cantidad)
                Console.WriteLine("Precio unitario: ${0}", precioUnitario)
                Console.WriteLine("Subtotal: ${0}", subtotal)
                Console.WriteLine("Descuento ({1}%): ${0}", valorDescontado, descuento)
                Console.WriteLine("Precio final: ${0}", precioTotal)
            Else
                Console.WriteLine("Cantidad Incorrecta")
            End If
        Loop Until cantidad = 0
    End Sub
End Module
