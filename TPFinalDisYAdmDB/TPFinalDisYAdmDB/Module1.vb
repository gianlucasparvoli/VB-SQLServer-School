Module Module1

    Private Const CadenaDeConexion As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=TPFinalDisYAdmDB;Integrated Security=True" 'Conexion a SQLServer

    Public Function AltaBajaModific(ByVal SQL As String) As Boolean
        Dim conexion As SqlClient.SqlConnection
        Dim comando As SqlClient.SqlCommand
        Try
            conexion = New SqlClient.SqlConnection()
            conexion.ConnectionString = CadenaDeConexion
            conexion.Open()

            comando = New SqlClient.SqlCommand()
            comando.Connection = conexion
            comando.CommandType = CommandType.Text
            comando.CommandText = SQL
            comando.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            MessageBox.Show("Error en conexion SQL ABM" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Public Function ConsultarDatos(ByVal SQL As String, ByRef tabla As DataTable) As Boolean
        Dim conexion As SqlClient.SqlConnection
        Dim comando As SqlClient.SqlCommand

        Try
            conexion = New SqlClient.SqlConnection()
            conexion.ConnectionString = CadenaDeConexion
            conexion.Open()

            comando = New SqlClient.SqlCommand()
            comando.Connection = conexion
            comando.CommandType = CommandType.Text
            comando.CommandText = SQL
            tabla = New DataTable
            tabla.Load(comando.ExecuteReader)
            Return True
        Catch ex As Exception
            MessageBox.Show("Error en conexion SQL Consulta" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Public Function FechaInvertida(x As DateTime) As String
        Return x.Date.Month & "/" & x.Date.Day & "/" & x.Date.Year
    End Function

End Module

