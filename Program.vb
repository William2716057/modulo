Imports System

Module ModuloCalculator
	Sub main()
		'prompt for user
		Console.WriteLine("First number: ")
		Dim num1 As Integer = CInt(Console.ReadLine())

		Console.Write("Second number")
		Dim num2 As Integer = CInt(Console.ReadLine())

		'Calculate modulo
		Dim result As Integer = num1 Mod num2
		'Display 
		Console.WriteLine("Modulo of " & num1 & " and " & num2 & " = " & result)
	End Sub
End Module