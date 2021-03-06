﻿Public Class Customer
    ' Sophia. 25/07/2015
    ' Have added the method to add a new customer.
    ' added Items property.


    Private adapter As New new_Maverick_Car_RentalDataSetTableAdapters.CustomerTableAdapter
    Public Shared Property ErrorMessage As String
    Public Function AddCustomer(org As String, firstName As String, midName As String, lastName As String, DL As Integer, street As String, city As String, state As String, zip As String, phone As String, age As String) As Boolean
        Try
            ErrorMessage = String.Empty
            adapter.Insert(org, firstName, midName, lastName, DL, street, city, state, zip, phone, age)
            Return True
        Catch ex As Exception
            ErrorMessage = ex.Message
            Return False
        End Try
    End Function
    Public ReadOnly Property Items As DataTable
        Get
            Return adapter.GetData
        End Get
    End Property

End Class
