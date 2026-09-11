Module Module1

    Sub Main()

        'IMPRIMIR UN TEXTO EN CONSOLA
        Console.WriteLine("Hola mundo!")

        'ESPERAR LA RESPUESTA DEL USUARIO
        Console.ReadLine()

        '========================================================================================

        'DECLARACION DE VARIABLES
        Dim numero As Integer
        Dim texto As String

        'DAR VALOR A LAS VARIABLES
        numero = 1
        texto = "hola"

        '========================================================================================

        'DECLARACION DE VARIABLES
        Dim valor1 As Double = 3
        Dim valor2 As Double = 10
        Dim resulSuma As Integer
        Dim resulResta As Integer
        Dim resulMultiplicacion As Integer
        Dim resulDivision As Double
        Dim resulExponente As Integer

        'OPERACION DE VARIABLES
        resulSuma = valor1 + valor2             'operador suma
        resulResta = valor1 - valor2            'operador resta
        resulMultiplicacion = valor1 * valor2   'operador multiplicacion
        resulDivision = valor1 / valor2         'operador division
        resulExponente = valor1 ^ valor2        'operador exponente

        Console.WriteLine("La suma de " & valor1 & " y " & valor2 & " es: " & resulSuma)
        Console.WriteLine("La resta de " & valor1 & " y " & valor2 & " es: " & resulResta)
        Console.WriteLine("La multiplicacion de " & valor1 & " y " & valor2 & " es: " & resulMultiplicacion)
        Console.WriteLine("La division de " & valor1 & " y " & valor2 & " es: " & resulDivision)
        Console.WriteLine("La exponencial de " & valor1 & " y " & valor2 & " es: " & resulExponente)

        '========================================================================================
        'OBTENER Y GUARDAR LOS DATOS QUE INGRESE EL USUARIO
        Dim numero1 As Integer
        Console.WriteLine("Introduzca un numero: ")
        numero1 = Console.ReadLine()
        Console.WriteLine("Su numero es: " & numero1)

        '========================================================================================
        'CONDICIONALES
        Console.WriteLine("Menu Principal")
        Console.WriteLine("Opciones:")
        Console.WriteLine("1. Opcion 01")
        Console.WriteLine("2. Opcion 02")
        Console.WriteLine("3. Opcion 03")
        Console.WriteLine("4. Salir")
        Console.WriteLine()

        Console.WriteLine("Elige para la estructura if: ")
        Dim opcionUsuarioIf As Integer = CInt(Console.ReadLine)

        'ESTRUCTURA CONDICIONAL IF-IFELSE-ELSE ANIDADA
        If opcionUsuarioIf = 1 Then
            Console.WriteLine("Elegiste la opcion 1 [if]")
        ElseIf opcionUsuarioIf = 2 Then
            Console.WriteLine("Elegiste la opcion 2 [if]")
        ElseIf opcionUsuarioIf = 3 Then
            Console.WriteLine("Elegiste la opcion 3 [if]")
        ElseIf opcionUsuarioIf = 4 Then
            Console.WriteLine("Elegiste la opcion 4 [if]")
        Else
            Console.WriteLine("Fuera del rango de opciones [if]")
        End If



        Console.WriteLine("Elige para la estructura case: ")
        Dim opcionUsuariocase As Integer = CInt(Console.ReadLine)

        'ESTRUCTURA CONDICIONAL CASE
        Select Case opcionUsuariocase
            Case 1
                Console.WriteLine("Elegiste la opcion 1 [case]")
            Case 2
                Console.WriteLine("Elegiste la opcion 2 [case]")
            Case 3
                Console.WriteLine("Elegiste la opcion 3 [case]")
            Case 4
                Console.WriteLine("Elegiste la opcion 4 [case]")
            Case Else
                Console.WriteLine("Fuera del rango de opciones [case]")
        End Select

        '========================================================================================



    End Sub

End Module
