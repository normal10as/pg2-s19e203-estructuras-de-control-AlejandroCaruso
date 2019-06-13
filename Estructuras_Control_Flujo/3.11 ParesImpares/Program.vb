Imports System

Module ParesImpares
    Sub Main()
        Dim x As Byte = 0
        Dim numero, totales, pares, impares As Int16
        totales = impares = pares = 0
        While x = 0
            Console.WriteLine("Ingrese un numero (0 para salir)")
            numero = Console.ReadLine()
            Select Case numero
                Case Is > 0
                    totales += 1
                    If numero Mod 2 = 0 Then
                        pares += 1
                    Else
                        impares += 1
                    End If
                Case 0
                    x = 1
            End Select
        End While
        Console.WriteLine("Total de numeros: {0}", totales)
        If pares <> 0 And impares <> 0 Then
            Console.WriteLine("Total de pares: {0}", pares)
            Console.WriteLine("Total de impares: {0}", impares)
        ElseIf pares = 0 Then
            Console.WriteLine("Total de impares: {0}", impares)
            Console.WriteLine("No se encontraron pares, son todos impares")
        ElseIf impares = 0 Then
            Console.WriteLine("Total de pares: {0}", pares)
            Console.WriteLine("No se encontraron impares, son todos pares")
        End If
    End Sub
End Module
