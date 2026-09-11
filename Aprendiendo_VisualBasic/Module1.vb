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

    End Sub

End Module
