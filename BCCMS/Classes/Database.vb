Imports System.IO

Public Class Database
    Protected connection As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Directory.GetCurrentDirectory() & "\\cms.mdb;Persist Security Info=False")
End Class
