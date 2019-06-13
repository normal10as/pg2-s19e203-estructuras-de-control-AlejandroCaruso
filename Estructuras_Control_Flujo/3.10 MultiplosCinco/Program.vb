Imports System.Math

Module MultiplosCinco
    Sub Main()
        Dim valor1, valor2, multiplosCinco As Int16
        Console.WriteLine("Ingrese dos valores (el menor primero)")
        valor1 = Console.ReadLine()
        valor2 = Console.ReadLine()
        multiplosCinco = UsandoFor(valor1, valor2)
        Console.WriteLine("Hay {0} multiplos de 5 entre {1} y {2}", multiplosCinco, valor1, valor2)
        multiplosCinco = DoLoopWhile(valor1, valor2)
        Console.WriteLine("Hay {0} multiplos de 5 entre {1} y {2}", multiplosCinco, valor1, valor2)
        multiplosCinco = DoLoopUntil(valor1, valor2)
        Console.WriteLine("Hay {0} multiplos de 5 entre {1} y {2}", multiplosCinco, valor1, valor2)
        multiplosCinco = DoWhileLoop(valor1, valor2)
        Console.WriteLine("Hay {0} multiplos de 5 entre {1} y {2}", multiplosCinco, valor1, valor2)
        multiplosCinco = DoUntilLoop(valor1, valor2)
        Console.WriteLine("Hay {0} multiplos de 5 entre {1} y {2}", multiplosCinco, valor1, valor2)

    End Sub

    Function UsandoFor(inicio, fin) As Short
        Dim cantidad As Short = 0
        Console.WriteLine("Usando For")
        For y = inicio To fin
            If y Mod 5 = 0 Then
                cantidad += 1
            End If
        Next
        Return cantidad
    End Function
    Function DoLoopWhile(inicio, fin) As Short
        Dim cantidad As Short = 0
        Console.WriteLine("Usando Do ... Loop While")
        Do
            If inicio Mod 5 = 0 Then
                cantidad += 1
            End If
            inicio += 1
        Loop While inicio <= fin
        Return cantidad
    End Function

    Function DoWhileLoop(inicio, fin) As Short
        Dim cantidad As Short = 0
        Console.WriteLine("Usando Do While ... Loop")
        Do While inicio <= fin
            If inicio Mod 5 = 0 Then
                cantidad += 1
            End If
            inicio += 1
        Loop
        Return cantidad
    End Function

    Function DoUntilLoop(inicio, fin) As Short
        Dim cantidad As Short = 0
        Console.WriteLine("Usando Do Until ... Loop")
        Do Until inicio > fin
            If inicio Mod 5 = 0 Then
                cantidad += 1
            End If
            inicio += 1
        Loop
        Return cantidad
    End Function
    Function DoLoopUntil(inicio, fin) As Short
        Dim cantidad As Short = 0
        Console.WriteLine("Usando Do ... Loop Until")
        Do
            If inicio Mod 5 = 0 Then
                cantidad += 1
            End If
            inicio += 1
        Loop Until inicio > fin
        Return cantidad
    End Function
    'Al introducir el tope menor a 5 tira como si hubiese 1. 
End Module
