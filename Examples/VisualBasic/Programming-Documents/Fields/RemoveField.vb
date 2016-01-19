﻿Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Words
Imports Aspose.Words.Fields

Public Class RemoveField
    Public Shared Sub Run()
        ' The path to the documents directory.
        Dim dataDir As String = RunExamples.GetDataDir_WorkingWithFields()

        Dim doc As New Document(dataDir & "Field.RemoveField.doc")

        Dim field As Field = doc.Range.Fields(0)
        ' Calling this method completely removes the field from the document.
        field.Remove()

        Console.WriteLine(vbNewLine & "Field removed from the document successfully." & vbNewLine & "File saved at " + dataDir + "Field.RemoveField.doc")
    End Sub
End Class
