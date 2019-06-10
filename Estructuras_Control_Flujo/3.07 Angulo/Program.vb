Imports System

Module Angulo
    Sub Main()
        Dim grados As Short
        Console.WriteLine("Ingrese el angulo en grados")
        grados = Console.ReadLine()
        Select Case grados
            Case 1 To 89
                Console.WriteLine("{0}° - Agudo", grados)
            Case 90
                Console.WriteLine("{0}° - Recto", grados)
            Case 91 To 179
                Console.WriteLine("{0}° - Obtuso", grados)
            Case 180
                Console.WriteLine("{0}° -Llano", grados)
            Case 181 To 360
                Console.WriteLine("{0}° -Cóncavo", grados)
            Case Else
                Console.WriteLine("Error")
        End Select
    End Sub
End Module
