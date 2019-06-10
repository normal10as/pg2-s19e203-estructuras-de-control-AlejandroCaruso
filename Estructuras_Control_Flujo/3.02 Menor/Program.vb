Imports System

Module Menor
    Sub Main()
        Dim valor1, valor2, valor3 As Byte
        Console.WriteLine("Ingrese primer valor")
        valor1 = Console.ReadLine()
        Console.WriteLine("Ingrese segundo valor")
        valor2 = Console.ReadLine()
        Console.WriteLine("Ingrese tercer valor")
        valor3 = Console.ReadLine()
        If valor1 < valor2 And valor1 < valor3 Then
            Console.WriteLine("El menor valor es {0}", valor1)
        ElseIf valor2 < valor3 Then
            Console.WriteLine("El menor valor es {0}", valor2)
        Else
            Console.WriteLine("El menor valor es {0}", valor3)
        End If
    End Sub
End Module
