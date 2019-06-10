Imports System

Module Tercero
    Sub Main()
        Dim valor1, valor2, valor3, valor4, valor5 As Int16
        Console.WriteLine("Ingrese 5 valores enteros")
        valor1 = Console.ReadLine()
        valor2 = Console.ReadLine()
        valor3 = Console.ReadLine()
        valor4 = Console.ReadLine()
        valor5 = Console.ReadLine()
        If valor1 > valor2 And valor1 > valor3 And valor1 > valor4 And valor1 > valor5 Then
            Console.WriteLine("El primero es el mayor valor")
        ElseIf valor2 > valor3 And valor2 > valor4 And valor2 > valor5 Then
            Console.WriteLine("El segundo es el mayor valor")
        ElseIf valor3 > valor4 And valor3 > valor5 Then
            Console.WriteLine("El tercero es el mayor valor")
        ElseIf valor4 > valor5 Then
            Console.WriteLine("El cuarto es el mayor valor")
        Else
            Console.WriteLine("El quinto es el mayor valor")
        End If
    End Sub
End Module
