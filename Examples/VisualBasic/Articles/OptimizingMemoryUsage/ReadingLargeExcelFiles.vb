'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Cells. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace Aspose.Cells.Examples.Articles.OptimizingMemoryUsage
    Public Class ReadingLargeExcelFiles
        Public Shared Sub Main()
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            'Specify the LoadOptions
            Dim opt As New LoadOptions()
            'Set the memory preferences
            opt.MemorySetting = MemorySetting.MemoryPreference

            'Instantiate the Workbook
            'Load the Big Excel file having large Data set in it
            Dim wb As New Workbook(dataDir & "Book1.xlsx", opt)

        End Sub
    End Class
End Namespace