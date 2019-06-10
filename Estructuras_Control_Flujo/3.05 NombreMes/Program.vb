Imports System

Module NombreMes
    Enum Meses
        Enero = 1
        Febrero
        Marzo
        Abril
        Mayo
        Junio
        Julio
        Agosto
        Septiembre
        Octubre
        Noviembre
        Diciembre
    End Enum
    Sub Main()
        Dim valor As Byte
        Console.WriteLine("Ingrese el numero de mes (1 a 12)")
        valor = Console.ReadLine()
        Select Case valor
            Case 1
                Console.WriteLine(Meses.Enero & ") " & Meses.Enero.ToString())
            Case 2
                Console.WriteLine(Meses.Febrero & ") " & Meses.Febrero.ToString())
            Case 3
                Console.WriteLine(Meses.Marzo & ") " & Meses.Marzo.ToString())
            Case 4
                Console.WriteLine(Meses.Abril & ") " & Meses.Abril.ToString())
            Case 5
                Console.WriteLine(Meses.Mayo & ") " & Meses.Mayo.ToString())
            Case 6
                Console.WriteLine(Meses.Junio & ") " & Meses.Junio.ToString())
            Case 7
                Console.WriteLine(Meses.Julio & ") " & Meses.Julio.ToString())
            Case 8
                Console.WriteLine(Meses.Agosto & ") " & Meses.Agosto.ToString())
            Case 9
                Console.WriteLine(Meses.Septiembre & ") " & Meses.Septiembre.ToString())
            Case 10
                Console.WriteLine(Meses.Octubre & ") " & Meses.Octubre.ToString())
            Case 11
                Console.WriteLine(Meses.Noviembre & ") " & Meses.Noviembre.ToString())
            Case 12
                Console.WriteLine(Meses.Diciembre & ") " & Meses.Diciembre.ToString())
            Case Else
                Console.WriteLine("No se ingresó un numero valido (1 a 12)")
        End Select
    End Sub
End Module
