Imports System

Module Program
    Sub Main(args As String())
		Dim oRnd = New Random()
		Console.WriteLine("Input a count of elements:")
		Dim nElems As Integer
		Integer.TryParse(Console.ReadLine(), nElems)
		If nElems = 0 Then
			Console.WriteLine("Empty arrays not allowed")
			Console.Read()
			Return
		End If
		Console.WriteLine($"Generating array by filling {nElems}:")
		Dim iNumbers(nElems - 1) As Integer
		For i As Integer = 0 To nElems - 1
			iNumbers(i) = oRnd.Next(1, 100)
			Console.Write(iNumbers(i) & " ")
		Next i
		Dim iMin = iNumbers(0)
		Dim nIndex = 0
		For i As Integer = 1 To nElems - 1
			If iNumbers(i) < iMin Then
				iMin = iNumbers(i)
				nIndex = i
			End If
		Next i
		Console.WriteLine(String.Format(vbCrLf & "Found minimum element:{0} with index {1}", iMin, nIndex))
		Console.Read()
	End Sub
End Module
