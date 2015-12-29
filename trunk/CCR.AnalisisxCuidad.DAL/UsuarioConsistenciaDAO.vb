Imports CCR.AnalisisxCuidad.BE
Imports System.Data.SqlClient

Public Class UsuarioConsistenciaDAO : Inherits ConnectionHelper
    Public Sub New()
    End Sub

    Public Function ObtenerUsuarioConsistencia() As IList(Of UsuarioConsistencia)
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader

        Using sqlCn As SqlConnection = ObtenerInstancia()
            cmd = New SqlCommand()
            cmd.Connection = sqlCn
            cmd.CommandText = "PCCRCC_UsuariosConsistencia_Sel"
            cmd.CommandType = CommandType.StoredProcedure

            Try
                sqlCn.Open()
                reader = cmd.ExecuteReader()
                Dim listaUsuarios As New List(Of UsuarioConsistencia)

                If reader.HasRows Then
                    While reader.Read()
                        Dim usuarioConsistencia As New UsuarioConsistencia
                        usuarioConsistencia.CodigoUsuario = reader.GetInt16(reader.GetOrdinal("CodigoUsuario"))
                        usuarioConsistencia.NombreUsuario = reader.GetString(reader.GetOrdinal("NombreUsuario"))
                        usuarioConsistencia.RowNumber = reader.GetInt64(reader.GetOrdinal("RowNumber"))
                        listaUsuarios.Add(usuarioConsistencia)
                    End While
                End If
                Return listaUsuarios
            Catch ex As Exception
                Throw ex
            End Try
        End Using
    End Function

    Public Function VerificaTipoUsuario() As Boolean
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader
        Dim isAdministrator As Boolean
        Using sqlCn As SqlConnection = ObtenerInstancia()
            cmd = New SqlCommand()
            cmd.Connection = sqlCn
            cmd.CommandText = "PCCRCC_Usuario_Tipo_Sel"
            cmd.CommandType = CommandType.StoredProcedure

            Try
                sqlCn.Open()
                reader = cmd.ExecuteReader()


                If reader.HasRows Then
                    While reader.Read()
                        Dim usuarioConsistencia As New UsuarioConsistencia
                        isAdministrator = reader.GetBoolean(reader.GetOrdinal("Administrador"))
                    End While
                End If
                Return isAdministrator
            Catch ex As Exception
                Throw ex
            End Try
        End Using
    End Function
End Class
