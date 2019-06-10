Imports System

Module Conversion
    Sub Main()
        Dim medida As Double
        Dim unidad As Byte
        Console.WriteLine("Elija una medida: " & vbCrLf & "1)Pie" & vbCrLf & "2)Pulgada" & vbCrLf & "3)Yarda" & vbCrLf & "4)Cm" & vbCrLf & "5)Metros")
        unidad = Console.ReadLine()
        Console.WriteLine("Ingrese el valor de la medida")
        medida = Console.ReadLine()
        Select Case unidad
            Case 1 'pie
                Console.WriteLine("{0} Pies", medida)
                Console.WriteLine("{0} Pulgadas", medida * 12)
                Console.WriteLine("{0} Yarda", medida / 3)
                Console.WriteLine("{0} Cm", medida * 12 * 2.54)
                Console.WriteLine("{0} Metros", medida * 12 * 2.54 / 100)
            Case 2 'Pulgada
                Console.WriteLine("{0} Pies", medida / 12)
                Console.WriteLine("{0} Pulgadas", medida)
                Console.WriteLine("{0} Yarda", medida / 12 / 3)
                Console.WriteLine("{0} Cm", medida * 2.54)
                Console.WriteLine("{0} Metros", medida * 2.54 / 100)
            Case 3 'Yarda
                Console.WriteLine("{0} Pies", medida * 3)
                Console.WriteLine("{0} Pulgadas", medida * 3 * 12)
                Console.WriteLine("{0} Yarda", medida)
                Console.WriteLine("{0} Cm", medida * 3 * 12 * 2.54)
                Console.WriteLine("{0} Metros", medida * 3 * 12 * 2.54 / 100)
            Case 4 'Cm
                Console.WriteLine("{0} Pies", medida / 2.54 / 12)
                Console.WriteLine("{0} Pulgadas", medida / 2.54)
                Console.WriteLine("{0} Yarda", medida / 2.54 / 12 / 3)
                Console.WriteLine("{0} Cm", medida)
                Console.WriteLine("{0} Metros", medida / 100)
            Case 5 ' Metros
                Console.WriteLine("{0} Pies", medida * 100 / 2.54 / 12)
                Console.WriteLine("{0} Pulgadas", medida * 100 / 2.54)
                Console.WriteLine("{0} Yarda", medida * 100 / 2.54 / 12 / 3)
                Console.WriteLine("{0} Cm", medida * 100)
                Console.WriteLine("{0} Metros", medida)
            Case Else
                Console.WriteLine("El numero ingresado no corresponde a una medida sugerida(1 a 5)")
        End Select
    End Sub
End Module
