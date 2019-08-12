Imports System

Module Deposito
    Private Const interesAnual As Int16 = 36
    Sub Main(args As String())
        Dim meses As Int16
        Dim totalInteres, valorInteres, saldo, total As Decimal
        totalInteres = 0
        Console.Write("Ingrese monto a depositar: ")
        saldo = Console.ReadLine()
        Console.Write("Ingrese cantidad de meses: ")
        meses = Console.ReadLine()
        total = saldo
        Console.WriteLine("Mes | Saldo     |Interes   | Saldo total")
        For x = 1 To meses
            saldo = total
            valorInteres = saldo * interesAnual / 12 / 100
            total = saldo + valorInteres
            totalInteres += valorInteres
            Console.WriteLine(" {0}    {1}    {2}      {3}", x, saldo, valorInteres, total)
        Next
        Console.WriteLine("Total de intereses: ${0}", totalInteres)
    End Sub
End Module
