Imports CCR.AnalisisxCuidad.BE
Imports CCR.AnalisisxCuidad.DAL

Public Class ZonaSujetaRevisionBL
    Public Sub New()

    End Sub
    ''' <summary>
    ''' Recupera las zonas planificadas para su revision por Consistencia por Ciudad 
    ''' </summary>
    ''' <param name="periodoMesEstudio">Mes de estudio</param>
    ''' <returns>Lista de las zonas sujetas a revision</returns>
    ''' <remarks></remarks>
    Public Function ConsultaZonasSujetasRevision(ByVal periodoMesEstudio As Integer) As IList(Of ZonaSujetaRevision)
        Dim zonaRevisionDAO As New ZonaSujetaRevisionDAO
        Return zonaRevisionDAO.ConsultaZonasSujetasRevision(periodoMesEstudio)
    End Function
    ''' <summary>
    ''' Actualiza el avance de los usuarios
    ''' </summary>
    ''' <param name="periodoMesEstudio">Mes de estudio</param>
    ''' <param name="idTCCRCC_Avance">Id del registro de la cuidad a donde va a ser asignado el usuario</param>
    ''' <param name="codigoUsuario">Código del usuario que va a ser asignado a una determinada cuidad</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ActualizaAvanceUsuario(ByVal periodoMesEstudio As Integer, ByVal idTCCRCC_Avance As Integer, ByVal codigoUsuario As Int16) As Byte
        Dim zonaRevisionDAO As New ZonaSujetaRevisionDAO
        Return zonaRevisionDAO.ActualizaAvanceUsuario(periodoMesEstudio, idTCCRCC_Avance, codigoUsuario)
    End Function
    ''' <summary>
    ''' Devuelve las ultimas tres mediciones. La medicion activa tiene el parametro de Estado = 1
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerUltimasTresMediciones() As IList(Of Medicion)
        Dim zonaRevisionDAO As New ZonaSujetaRevisionDAO
        Return zonaRevisionDAO.ObtenerUltimasTresMediciones()
    End Function
    ''' <summary>
    ''' Devuelve la lista de usuarios que pueden ser asignados a las cuidades
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerUsuarioConsistencia() As IList(Of UsuarioConsistencia)
        Dim usuarioDAO As New UsuarioConsistenciaDAO
        Return usuarioDAO.ObtenerUsuarioConsistencia()
    End Function
    ''' <summary>
    ''' Actualiza la fecha Meta de los usuarios seleccionados
    ''' </summary>
    ''' <param name="idMedicionZona"></param>
    ''' <param name="fechaUsuario"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ActualizaFechaObjetivo(ByVal idMedicionZona As Integer, ByVal fechaUsuario As DateTime) As Int16
        Dim zonaDAO As New ZonaSujetaRevisionDAO
        Return zonaDAO.ActualizaFechaObjetivo(idMedicionZona, fechaUsuario)
    End Function

    Public Function ListaEstados() As List(Of Estados)
        Dim zonaSujeta As New ZonaSujetaRevisionDAO
        Return zonaSujeta.ListaEstados()
    End Function
End Class
