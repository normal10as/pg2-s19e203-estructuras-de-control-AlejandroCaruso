Imports System

Module DiasMes
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
        Dim mes As Byte
        Dim anio As Double
        Console.WriteLine("Ingresar mes")
        mes = Console.ReadLine()
        Select Case mes
            Case 1
                Console.WriteLine("El mes {0} tiene 31 dias", Meses.Enero)
            Case 3
                Console.WriteLine("El mes {0} tiene 31 dias", Meses.Marzo)
            Case 5
                Console.WriteLine("El mes {0} tiene 31 dias", Meses.Mayo)
            Case 7
                Console.WriteLine("El mes {0} tiene 31 dias", Meses.Julio)
            Case 8
                Console.WriteLine("El mes {0} tiene 31 dias", Meses.Agosto)
            Case 10
                Console.WriteLine("El mes {0} tiene 31 dias", Meses.Octubre)
            Case 12
                Console.WriteLine("El mes {0} tiene 31 dias", Meses.Diciembre)
            Case 4
                Console.WriteLine("El mes {0} tiene 30 dias", Meses.Abril)
            Case 6
                Console.WriteLine("El mes {0} tiene 30 dias", Meses.Junio)
            Case 9
                Console.WriteLine("El mes {0} tiene 30 dias", Meses.Septiembre)
            Case 11
                Console.WriteLine("El mes {0} tiene 30 dias", Meses.Noviembre)
            Case 2
                Console.WriteLine("Ingrese el año")
                anio = Console.ReadLine()
                If anio Mod 4.0 = 0 And (anio Mod 100.0 <> 0 Or anio Mod 400.0 = 0) Then
                    Console.WriteLine("El mes {0} tiene 29 dias", Meses.Febrero)
                Else
                    Console.WriteLine("El mes {0} tiene 28 dias", Meses.Febrero)
                End If
        End Select

    End Sub
End Module
