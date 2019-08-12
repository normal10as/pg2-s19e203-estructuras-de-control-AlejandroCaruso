Imports System

Module Fibonacci
    Sub Main()
        Dim primero, segundo, numero As Int16
        primero = 0
        segundo = 1
        Console.WriteLine("1) {0}", primero)
        Console.WriteLine("2) {0}", segundo)
        For x = 1 To 18
            numero = primero + segundo
            Console.WriteLine("{1}) {0}", numero, (x + 2))
            primero = segundo
            segundo = numero
        Next
    End Sub
End Module
