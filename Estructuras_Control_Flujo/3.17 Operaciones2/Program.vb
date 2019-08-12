Imports System

Module Operaciones2
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
        imprimir(operaciones.Suma, numero1, numero2)
        imprimir(operaciones.Suma, numero1, numero2, numero3)
        imprimir(operaciones.Suma, numero1, numero2, numero3, numero4)
        imprimir(operaciones.Resta, numero1, numero2)
        imprimir(operaciones.Resta, numero1, numero2, numero3)
        imprimir(operaciones.Resta, numero1, numero2, numero3, numero4)
        imprimir(operaciones.Multiplicacion, numero1, numero2)
        imprimir(operaciones.Multiplicacion, numero1, numero2, numero3)
        imprimir(operaciones.Multiplicacion, numero1, numero2, numero3, numero4)
        imprimir(operaciones.Division, numero1, numero2)
        imprimir(operaciones.Division, numero1, numero2, numero3)
        imprimir(operaciones.Division, numero1, numero2, numero3, numero4)
        imprimir(numero1, numero2)
        imprimir(numero1, numero2, numero3)
        imprimir(numero1, numero2, numero3, numero4)
    End Sub
    Function calcular(op As operaciones, a As Double, b As Double) As Double
        Dim resultado As Double
        Select Case op
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
    Function calcular(op As operaciones, a As Double, b As Double, c As Double) As Double
        Return calcular(op, calcular(op, a, b), c)
    End Function
    Function calcular(op As operaciones, a As Double, b As Double, c As Double, d As Double) As Double
        Return calcular(op, calcular(op, calcular(op, a, b), c), d)
    End Function
    Sub imprimir(op As operaciones, a As Double, b As Double)
        Console.WriteLine("{1}{0}{2}={3}", simbolo(op), a, b, calcular(op, a, b))
    End Sub
    Sub imprimir(op As operaciones, a As Double, b As Double, c As Double)
        Console.WriteLine("{1}{0}{2}{0}{3}={4}", simbolo(op), a, b, c, calcular(op, a, b, c))
    End Sub
    Sub imprimir(op As operaciones, a As Double, b As Double, c As Double, d As Double)
        Console.WriteLine("{1}{0}{2}{0}{3}{0}{4}={5}", simbolo(op), a, b, c, d, calcular(op, a, b, c, d))
    End Sub
    Sub imprimir(a As Double, b As Double)
        Console.WriteLine("{0}+{1}={2}", a, b, calcular(operaciones.Suma, a, b))
    End Sub
    Sub imprimir(a As Double, b As Double, c As Double)
        Console.WriteLine("{0}+{1}+{2}={3}", a, b, c, calcular(operaciones.Suma, a, b, c))
    End Sub
    Sub imprimir(a As Double, b As Double, c As Double, d As Double)
        Console.WriteLine("{0}+{1}+{2}+{3}={4}", a, b, c, d, calcular(operaciones.Suma, a, b, c, d))
    End Sub
    Function simbolo(op As operaciones) As String
        Select Case op
            Case operaciones.Suma
                Return "+"
            Case operaciones.Resta
                Return "-"
            Case operaciones.Multiplicacion
                Return "*"
            Case operaciones.Division
                Return "/"
        End Select
    End Function
End Module
