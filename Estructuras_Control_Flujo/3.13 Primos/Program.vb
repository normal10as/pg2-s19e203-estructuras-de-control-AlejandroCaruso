Imports System

Module Primos
    Sub Main(args As String())
        For x = 2 To 1000
            If x Mod 2 <> 0 And x Mod 3 <> 0 And x Mod 5 <> 0 And x Mod 7 <> 0 Then
                Console.Write("{0} ", x)
            ElseIf x = 2 Or x = 3 Or x = 5 Or x = 7 Then
                Console.Write("{0} ", x)
            End If

        Next
    End Sub
End Module
