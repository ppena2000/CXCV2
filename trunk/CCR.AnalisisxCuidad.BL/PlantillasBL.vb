Imports CCR.AnalisisxCuidad.DAL
Imports CCR.AnalisisxCuidad.BE

Public Class PlantillasBL
    Public Sub New()
    End Sub

    Public Function ConsultarPlantillaResumen(ByVal periodo As Integer, ByVal codigoZona As Int16, ByVal idIndicador As Int16, ByVal subIndicador As Int16) As IList(Of PlantillaResumen)
        Try
            Return New PlantillaResumenDAO().ConsultarPlantillaResumen(periodo, codigoZona, idIndicador, subIndicador)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ConsultaPlantillaNegocio(ByVal periodo As Integer, ByVal codigoZona As Int16, ByVal idIndicador As Int16, ByVal subIndicador As Int16) As IList(Of PlantillaNegocio)
        Try
            Return New PlantillaNegocioDAO().ConsultaPlantillaNegocio(periodo, codigoZona, idIndicador, subIndicador)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ConsultarEstadoIndicadores(ByVal pMestado As Decimal, ByVal codigoZona As Int16) As IList(Of Indicadores)
        Try
            Return New IndicadoresDAO().ConsultarEstadoIndicadores(pMestado, codigoZona)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ObtenerEncuesta(ByVal lsIdMedicionZonaCanalNegocios As String) As IList(Of EncuestaXML)
        Try
            Return New EncuestaDAO().ObtenerEncuesta(lsIdMedicionZonaCanalNegocios)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ReplicaSku(ByVal codigosNegocio As String, ByVal tipoReplica As Int16) As Boolean
        Try
            Return New EncuestaDAO().ReplicaSku(codigosNegocio, tipoReplica)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ReplicaEncuesta(ByVal codigosNegocio As String, ByVal tipoReplica As Int16) As Boolean
        Try
            Return New EncuestaDAO().ReplicaEncuesta(codigosNegocio, tipoReplica)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Modifica el estado de la encuesta. Se esta tomando en cuenta que los estados van a ser los siguientes
    ''' 0: Atipico
    ''' 1: Activar Encuesta
    ''' 2: No Procesa
    ''' </summary>
    ''' <param name="lsidEncuestaCategoriaSku"></param>
    ''' <param name="estado"></param>
    ''' <remarks></remarks>
    Public Sub CambiaEstado(ByVal lsidEncuestaCategoriaSku As String, ByVal estado As Int16)
        Try
            Dim encuestaDA = New EncuestaDAO()
            encuestaDA.CambiaEstado(lsidEncuestaCategoriaSku, estado)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function ActualizarEncuestaEditada() As Boolean
        Try
            Return New EncuestaDAO().ActualizarEncuestaEditada()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Actualiza los valores de la encuesta seleccionada. Los valores que son tomados para actualizar son 
    ''' @IdTemporal int, @P0_IAntFac int, @P0_CM1Fac int,  @P0_CM2Fac int, @P0_INVFac int,
    ''' @P0_PREFac int,@Comentarios varchar(100)
    ''' </summary>
    ''' <param name="encuesta"></param>
    ''' <remarks></remarks>
    Public Sub ActualizaEncuestaTemporal(ByVal encuesta As EncuestaXML)
        Try
            Dim encuestaDA = New EncuestaDAO()
            encuestaDA.ActualizaEncuestaTemporal(encuesta)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Elimina la encuesta de trabajo
    ''' </summary>
    ''' <remarks></remarks>
    Public Function VaciarEncuestaEditada() As Boolean
        Try
            Return New EncuestaDAO().VaciarEncuestaEditada()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Devuelve el valor de la ultima medición
    ''' </summary>
    ''' <param name="idMedicionZona"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerUltimaMedicion(ByVal idMedicionZona) As Integer
        Try
            Return New ZonaSujetaRevisionDAO().ObtenerUltimaMedicion(idMedicionZona)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerDatosPlantilla(ByVal spPlantilla As String, ByVal idMedicionZona As Integer, ByVal indicador As Integer, ByVal subIndicador As Integer) As DataTable
        Try
            Return New PlantillaNegocioDAO().ObtenerDatosPlantilla(spPlantilla, idMedicionZona, indicador, subIndicador)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ReplicaEncuestaSeleccionada(ByVal strIdsMedicionZona As String, ByVal boton As Integer)
        Try
            Dim encuestaDA As New EncuestaDAO
            encuestaDA.ReplicaEncuestaSeleccionada(strIdsMedicionZona, boton)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CambiarEstadoMultiplesEncuestas(ByVal lsIds As String, ByVal estadoBoton As Integer, ByVal indicador As Integer, ByVal grdActivo As Integer)
        Try
            Dim encuestaDA As New EncuestaDAO
            encuestaDA.CambiarEstadoMultiplesEncuestas(lsIds, estadoBoton, indicador, grdActivo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Actualiza los SKU que han sidos seleccionados para reemplazo siempre y cuando tengan compra 
    ''' e inventario
    ''' </summary>
    ''' <param name="encuestaReemplazo"></param>
    ''' <remarks></remarks>
    Public Sub ActualizaSkuNegocioInventario(ByVal encuestaReemplazo As SkuReemplazo)
        Try
            Dim encuestaDA As New EncuestaDAO
            encuestaDA.ActualizaSkuNegocioInventario(encuestaReemplazo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
