Imports CCR.AnalisisxCuidad.BE
Imports CCR.AnalisisxCuidad.DAL

Public Class PanelControlBL
    Public Sub New()
    End Sub


    Public Function ListarAlertasSupervision(ByVal idMedicionZona As Integer) As IList(Of AlertasSupervision)
        Dim alertaSupervisionDAO As New AlertasSupervisionDAO
        Try
            Return alertaSupervisionDAO.ListarAlertasSupervision(idMedicionZona)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarCategorias(ByVal idMedicionZona As Integer) As IList(Of Categorias)
        Dim categoriaDAO As New CategoriasDAO
        Try
            Return categoriaDAO.ListarCategorias(idMedicionZona)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerCalendarioMedicion(ByVal idMedicionZona As Integer) As IList(Of Calendario)
        Dim calendarioDAO As New CalendarioMedicionDAO
        Try
            Return calendarioDAO.ObtenerCalendarioMedicion(idMedicionZona)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListasErroresMedicionZona(ByVal idMedicionZona As Integer) As IList(Of ErrorMedicionZona)
        Dim errorMedicionesDAO As New ErrorMedicionZonaDAO
        Try
            Return errorMedicionesDAO.ListasErroresMedicionZona(idMedicionZona)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListaSeleccionIndicadores(ByVal idMedicionZona As Integer) As IList(Of IndicadoresSeleccion)
        Dim indicadorDAO As New IndicadoresDAO
        Try
            Return indicadorDAO.ListaSeleccionIndicadores(idMedicionZona)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerDatosConexion() As DatosConexion
        Try
            Dim objCn = New DatosConexion
            Dim panel As New ConnectionHelper
            objCn.DataBaseName = panel.ObtenerInstancia().Database
            objCn.ServerName = panel.ObtenerInstancia().DataSource
            Return objCn
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function VerificaTipoUsuario() As Boolean
        Dim usuarioDAO As New UsuarioConsistenciaDAO
        Try
            Return usuarioDAO.VerificaTipoUsuario()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ActualizaCalendarioMedicion(ByVal idMedicionZona As Integer, ByVal fechaObjetivo As Date) As Boolean
        Dim calendarioDA As New CalendarioMedicionDAO
        Try
            Return calendarioDA.ActualizaCalendarioMedicion(idMedicionZona, fechaObjetivo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub RecalculaIndicadoresMedicion(ByVal idMedicionZona As Integer)
        Try
            Dim indicadorDA As New IndicadoresDAO
            indicadorDA.RecalculaIndicadoresMedicion(idMedicionZona)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function CargarCalendario(ByVal idMedicionZona As Integer) As DataSet
        Try
            Return New CalendarioMedicionDAO().CargarCalendario(idMedicionZona)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
