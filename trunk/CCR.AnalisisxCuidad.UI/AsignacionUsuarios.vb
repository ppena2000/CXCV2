Imports CCR.AnalisisxCuidad.BL
Imports System.Linq
Imports CCR.AnalisisxCuidad.BE
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraGrid.GridControl
Imports DevExpress.XtraGrid.Views.Grid
Imports CCR.AnalisisxCuidad.Support
Imports DevExpress.XtraEditors

Public Class AsignacionUsuarios

#Region "Variables Globales"

    Private ultimasMediciones As New List(Of Medicion)
    Private perMesEstudio As Integer

#End Region

#Region "Manejo de Eventos"

    Private Sub AsignacionUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarMediciones()
        CargarGrilla(perMesEstudio)
    End Sub

    Private Sub cbxMedicion_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxMedicion.SelectionChangeCommitted
        Dim mesEstudio As Integer
        mesEstudio = Convert.ToInt32(cbxMedicion.SelectedValue.ToString())
        CargarGrilla(mesEstudio)
    End Sub

    Private Sub btnAplicarMedicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicarMedicion.Click
        CopiarAsignacionMesAnterior()
    End Sub

    Private Sub rpItemUsuario_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rpItemUsuario.EditValueChanged
        Dim idTCCRAvance As New Integer
        Dim codigoUsuario As Int16
        Dim rowHandle = gvZonas.FocusedRowHandle
        idTCCRAvance = Convert.ToInt32(gvZonas.GetRowCellValue(rowHandle, colIdTCCRCCAvance))
        Dim valor As Object = TryCast(sender, LookUpEdit).EditValue
        codigoUsuario = Convert.ToInt16(valor)
        AsignaUsuarioACuidad(idTCCRAvance, codigoUsuario)
    End Sub

    Private Sub gvZonas_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles gvZonas.RowCellStyle
        Dim view As GridView = sender
        If e.Column.FieldName = colAlertas.FieldName Then
            Dim avance As Integer = view.GetRowCellValue(e.RowHandle, colAlertas)
            If avance > 0 Then
                e.Appearance.BackColor = Color.Red
            End If
        ElseIf e.Column.FieldName = colEstado.FieldName Then
            Dim etiqueta As String = view.GetRowCellValue(e.RowHandle, colEstado)
            Select Case etiqueta
                Case Constants.ESTADO_ASIGNACION_OK
                    e.Appearance.BackColor = Color.LightSeaGreen
                Case Constants.ESTADO_ASIGNACION_PENDIENTE
                    e.Appearance.BackColor = Color.Gold
                Case Else
            End Select
        End If
    End Sub

#End Region

#Region "Metodos Internos"

    Private Sub CargarGrilla(ByVal perMesEstudio As Integer)
        Dim zonaSujetaRevisionBl As New ZonaSujetaRevisionBL
        Dim listaCounsultaZonas As New List(Of ZonaSujetaRevision)
        Try
            listaCounsultaZonas = zonaSujetaRevisionBl.ConsultaZonasSujetasRevision(perMesEstudio).ToList()
            If listaCounsultaZonas.Any() Then
                grdZonasAnalisis.DataSource = listaCounsultaZonas
                sisStatus.Caption = "La información se cargó de manera exitosa"
                CargarUsuariosConsistencia()
            Else
                sisStatus.Caption = "No se encontro información de zonas que coincidan con la medición"
            End If
        Catch ex As Exception
            sisStatus.Caption = "Ocurrío un error en el proceso." + ex.Message
        End Try
    End Sub

    Private Function CargarUltimasMediciones() As List(Of Medicion)
        Dim zonaSujetaRevisionBl As New ZonaSujetaRevisionBL
        Try
            ultimasMediciones = zonaSujetaRevisionBl.ObtenerUltimasTresMediciones().ToList()
            perMesEstudio = ultimasMediciones.SingleOrDefault(Function(p) p.Estado = True).Medicion
        Catch ex As Exception
            sisStatus.Caption = "Ocurrío un error en el proceso." + ex.Message
        End Try
        Return ultimasMediciones
    End Function

    Private Sub CargarMediciones()
        cbxMedicion.DataSource = CargarUltimasMediciones()
        cbxMedicion.ValueMember = "Medicion"
        cbxMedicion.DisplayMember = "Medicion"
    End Sub

    Private Sub AsignaUsuarioACuidad(ByVal idTCCRCC_Avance As Integer, ByVal codigoUsuario As Int16)
        Dim zonaSujetaRevisionBl As New ZonaSujetaRevisionBL
        Try
            Dim exito = zonaSujetaRevisionBl.ActualizaAvanceUsuario(perMesEstudio, idTCCRCC_Avance, codigoUsuario)

            If exito = 0 Then
                siStatus.Caption = "La asignación del usuario a la cuidad se realizó con éxito"
            Else
                siStatus.Caption = "No se pudo asignar el usuario a la cuidad."
            End If

        Catch ex As Exception
            sisStatus.Caption = "Ocurrío un error en el proceso." + ex.Message
        End Try
    End Sub

    Private Sub CargarUsuariosConsistencia()
        Try
            Dim zonaSujetaRevisionBl As New ZonaSujetaRevisionBL
            rpItemUsuario.DataSource = zonaSujetaRevisionBl.ObtenerUsuarioConsistencia().ToList()
            rpItemUsuario.ValueMember = "CodigoUsuario"
            rpItemUsuario.DisplayMember = "NombreUsuario"
            rpItemUsuario.BestFit()
        Catch ex As Exception
            sisStatus.Caption = "Ocurrío un error en el proceso." + ex.Message
        End Try
    End Sub

    Private Sub CopiarAsignacionMesAnterior()
        AsignaUsuarioACuidad(0, 0)
    End Sub

#End Region

End Class