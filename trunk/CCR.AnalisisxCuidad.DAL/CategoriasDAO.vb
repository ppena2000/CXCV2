Imports CCR.AnalisisxCuidad.BE
Imports System.Data.SqlClient

Public Class CategoriasDAO : Inherits ConnectionHelper
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Lista la categorias
    ''' </summary>
    ''' <param name="idMedicionZona"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListarCategorias(ByVal idMedicionZona As Integer) As IList(Of Categorias)
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader

        Using sqlCn As SqlConnection = ObtenerInstancia()
            cmd = New SqlCommand()
            cmd.Connection = sqlCn
            cmd.CommandText = "PCCRCC_PCCategorias_Sel"
            cmd.CommandType = CommandType.StoredProcedure

            Dim prmMestado As New SqlParameter()
            prmMestado.ParameterName = "@IdMedicionZona"
            prmMestado.DbType = DbType.Int32
            prmMestado.Value = idMedicionZona
            cmd.Parameters.Add(prmMestado)

            Dim retorna As New SqlParameter
            retorna.ParameterName = "@RETORNA"
            retorna.DbType = DbType.Int16
            retorna.Direction = ParameterDirection.Output
            cmd.Parameters.Add(retorna)

            Try
                sqlCn.Open()
                Dim listaCategorias As New List(Of Categorias)
                reader = cmd.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        Dim categorias As New Categorias
                        categorias.CodigoProducto = reader.GetInt32(reader.GetOrdinal("CodigoProducto"))
                        categorias.Categoria = reader.GetString(reader.GetOrdinal("Categoria"))
                        categorias.E0Negocios = reader.GetInt32(reader.GetOrdinal("E0_Negocios"))
                        categorias.E1Pendientes = reader.GetInt32(reader.GetOrdinal("E1_Pendientes"))
                        categorias.E2NegociosEnSupervision = reader.GetInt32(reader.GetOrdinal("E2_NegociosEnSupervision"))
                        categorias.E3NegociosSupervisados = reader.GetInt32(reader.GetOrdinal("E3_NegociosSupervisados"))
                        categorias.E4NegociosCorrejidos = reader.GetInt32(reader.GetOrdinal("E4_NegociosCorregidos"))
                        categorias.E5 = reader.GetInt32(reader.GetOrdinal("E5"))
                        listaCategorias.Add(categorias)
                    End While
                End If
                Return listaCategorias
            Catch ex As Exception
                Throw ex
            End Try
        End Using
    End Function
End Class
