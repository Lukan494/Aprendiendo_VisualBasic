Module Module1

    Sub Main()

        Entrada()

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
        Console.WriteLine()
        Console.WriteLine("Introduzca un numero: ")
        numero1 = Console.ReadLine()
        Console.WriteLine("Su numero es: " & numero1)

        '========================================================================================
        'CONDICIONALES
        Console.WriteLine()
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

        'OPERADORES LOGICOS

        Dim dato1 As Integer = 10
        Dim dato2 As String = "diez"

        'OPERADOR LOGICO AND

        Console.WriteLine("El operador logico AND debes de ingresar los dos datos correctos")
        Console.WriteLine("Ingrese los datos secretos: ")
        Console.WriteLine("Ingrese el numero: ")
        dato1 = Console.ReadLine()
        Console.WriteLine("Ingrese la palabra: ")
        dato2 = Console.ReadLine()
        Console.WriteLine()


        If dato1 = 10 And dato2 = "diez" Then
            Console.WriteLine("Los datos son correctos")
        Else
            Console.WriteLine("Datos Incorrectos")
        End If


        'OPERADOR LOGICO OR
        Console.WriteLine("El operador logico OR debes de ingresar almenos un dato correcto")
        Console.WriteLine("Ingrese los datos secretos: ")
        Console.WriteLine("Ingrese el numero: ")
        dato1 = Console.ReadLine()
        Console.WriteLine("Ingrese la palabra: ")
        dato2 = Console.ReadLine()
        Console.WriteLine()

        If dato1 = 10 Or dato2 = "diez" Then
            Console.WriteLine("Almenos un dato es correcto")
        Else
            Console.WriteLine("Datos Incorrectos")
        End If

        '========================================================================================

        'BLOQUE FOR
        Dim i As Integer
        For i = 0 To 10 'PODEMOS DEFINIR QUE SEA DE UNO EN UNO O DE DOS EN DOS CON EL ARGUMENTO STEP 2
            Console.WriteLine("Bloqur for bucle  nº: " & i)
        Next

        '========================================================================================

        'BLOQUE WHILE

        Dim x As Integer = 0

        'ES UNA ESTRUCTURA DE BUBLE INFINITO, NO PARA
        Console.WriteLine("Bucle infinito")
        'Do
        '    Console.WriteLine(x)
        '    Console.ReadLine()
        '    x += 1
        'Loop


        'CON WHILE LE DAMOS UNA CONDICION
        Console.WriteLine("Bucle con while")
        Do While x < 100
            Console.WriteLine(x)
            x += 1
        Loop

        'CON UNTIL LE DEFINIMOS QUE SEA HASTA QUE CUMPLA CIERTO VALOR
        Console.WriteLine("Bucle con until")
        Do Until x = 100
            Console.WriteLine(x)
            x += 1
        Loop

        '========================================================================================

        'ARRAY

    End Sub

    'METODOS MAS QUE EL MAIN
    Private Sub Entrada()
        Console.WriteLine("ENTRADA DESDE UN METODO EXTERNO")
    End Sub

End Module
