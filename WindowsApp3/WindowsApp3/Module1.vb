Imports System
Imports System.IO
Imports System.Text
Module Module1
    Public Sub create()
        Dim path As String = Application.StartupPath & "/records.txt"

        ' Create or overwrite the file.
        Dim fs As FileStream = File.Create(path)

        ' Add text to the file.
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("")
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub
End Module
