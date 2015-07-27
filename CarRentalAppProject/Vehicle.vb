' Sophia. 26/07/2015
' Have added the method to add a new vehicle.
' added Items property.

Public Class Vehicle
    Private adapter As New new_Maverick_Car_RentalDataSetTableAdapters.VehicleTableAdapter
    Public Shared Property ErrorMessage As String

    Public Function AddVehicle(caterory As String, VIN As String, make As String, model As String, color As String, condition As String, fuelTank As String, available As Boolean, description As String) As Boolean
        Try
            ErrorMessage = String.Empty
            adapter.Insert(caterory, VIN, make, model, color, condition, fuelTank, available, description)
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
