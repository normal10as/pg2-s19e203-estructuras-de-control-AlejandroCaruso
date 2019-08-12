Imports System

Module Operaciones
    Enum operaciones
        Suma = 1
        Resta
        Multiplicacion
        Division
    End Enum
    Sub Main(args As String())
        Dim numero1, numero2, numero3, numero4 As Double
        numero1 = 17
        numero2 = 9
        numero3 = 4
        numero4 = 2
        Console.WriteLine("{0}+{1} = " & calcular(operaciones.Suma, numero1, numero2), numero1, numero2)
        Console.WriteLine("{0}+{1}+{2} = " & calcular(operaciones.Suma, numero1, numero2, numero3), numero1, numero2, numero3)
        Console.WriteLine("{0}+{1}+{2}+{3} = " & calcular(operaciones.Suma, numero1, numero2, numero3, numero4), numero1, numero2, numero3, numero4)
        Console.WriteLine("{0}*{1} = " & calcular(operaciones.Multiplicacion, numero1, numero2), numero1, numero2)
        Console.WriteLine("{0}*{1}*{2} = " & calcular(operaciones.Multiplicacion, numero1, numero2, numero3), numero1, numero2, numero3)
        Console.WriteLine("{0}*{1}*{2}*{3} = " & calcular(operaciones.Multiplicacion, numero1, numero2, numero3, numero4), numero1, numero2, numero3, numero4)
        Console.WriteLine("{0}-{1} = " & calcular(operaciones.Resta, numero1, numero2), numero1, numero2)
        Console.WriteLine("{0}-{1}-{2} = " & calcular(operaciones.Resta, numero1, numero2, numero3), numero1, numero2, numero3)
        Console.WriteLine("{0}-{1}-{2}-{3} = " & calcular(operaciones.Resta, numero1, numero2, numero3, numero4), numero1, numero2, numero3, numero4)
        Console.WriteLine("{0}/{1} = " & calcular(operaciones.Division, numero1, numero2), numero1, numero2)
        Console.WriteLine("{0}/{1}/{2} = " & calcular(operaciones.Division, numero1, numero2, numero3), numero1, numero2, numero3)
        Console.WriteLine("{0}/{1}/{2}/{3} = " & calcular(operaciones.Division, numero1, numero2, numero3, numero4), numero1, numero2, numero3, numero4)
        Console.WriteLine("{0}?{1} = " & calcular(numero1, numero2), numero1, numero2)
        Console.WriteLine("{0}?{1}?{2} = " & calcular(numero1, numero2, numero3), numero1, numero2, numero3)
        Console.WriteLine("{0}?{1}?{2}?{3} = " & calcular(numero1, numero2, numero3, numero4), numero1, numero2, numero3, numero4)
    End Sub
    Function calcular(operacion As operaciones, a As Double, b As Double) As Double
        Dim resultado As Double
        Select Case operacion
            Case operaciones.Suma
                resultado = a + b
            Case operaciones.Resta
                resultado = a - b
            Case operaciones.Multiplicacion
                resultado = a * b
            Case operaciones.Division
                resultado = a / b
        End Select
        Return resultado
    End Function
    Function calcular(a As Double, b As Double) As Double
        Return a + b
    End Function
    Function calcular(a As Double, b As Double, c As Double) As Double
        Return calcular(calcular(a, b), c)
    End Function
    Function calcular(a As Double, b As Double, c As Double, d As Double) As Double
        Return calcular(calcular(a, b), calcular(c, d))
    End Function
    Function calcular(operacion As operaciones, a As Double, b As Double, c As Double) As Double
        Return calcular(operacion, calcular(operacion, a, b), c)
    End Function
    Function calcular(operacion As operaciones, a As Double, b As Double, c As Double, d As Double) As Double
        Return calcular(operacion, calcular(operacion, a, b), calcular(operacion, c, d))
    End Function
End Module
