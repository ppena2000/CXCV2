Imports CCR.AnalisisxCuidad.BE
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports CCR.AnalisisxCuidad.Support
Imports System.IO
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Columns
Imports System.Linq
Imports CCR.AnalisisxCuidad.BL
Imports DevExpress.XtraTreeList

Module CCGlobales
    Public giIndicador As Integer
    Public giSubIndicador As Integer
    Public giCodigoZona As Integer
    Public giCodigoUsuario As Integer
    Public giMedicion As Integer
    Public gsTituloIndicador As String
    Public gsTituloIndicadorPrincipal As String
    Public gsTituloIndicadorSecundario As String
    Public gsSkinName As String
    Public gaPestanasActivas As String
    Public giIdMedicionZona As Integer
    Public gsNombreZona As String
    ' Definir con presicion la cantidad de indicares para definir el arreglo...
    Public giInidicadorActivo As Integer
    ' Arreglo para mantener la variables de la sesion actual ...
    Public giPrincipalLoad As Integer
    Public gaIndicadoresAbiertos(21) As String
    Public gaIndicadoresParametros(21) As String
    Public gaIndicadoresFilaPrincipal(21) As String
    Public gaIndicadoresFilaSecundaria(21) As String
    'Public gaIndicadoresAbiertosEncuesta(21) As String  'Aqui se guarda el o los codigos de encuesta abiertas por cada indicador
    Public gaIndicadoresBotones(21) As String
    Public Indicador As Indicadores
    Public giGridActivo As Integer
    Public gstrCodigoNegocio As String
    Public gstrIdNegocioSku As String
    Public giMostrarEncuesta As Integer
    Public gbCierreTotal As Boolean = False
    Public gbRecargarGilla As Boolean = False
    Public gbLoadSistema As Boolean = True
    Public gbLoadIndicador As Boolean = True
    Public gifrmPrincipalWidth As Integer
    Public gbEncuestaExistenCambios As Boolean = False   'Solo se debe usar para activar/desactivar el boton GRABAR de Encuesta.
    ' Public gsvCCRCC_GrillaPrincipalPlantilla01 As String
    Private _EstadoIndicadoresGlobales As List(Of Indicadores)
    Public Property EstadoIndicadoresGlobales() As List(Of Indicadores)
        Get
            Return _EstadoIndicadoresGlobales
        End Get
        Set(ByVal value As List(Of Indicadores))
            _EstadoIndicadoresGlobales = value
        End Set
    End Property

    Public Function PCCRCC_Zona_Sel(ByVal piMedicionZona As Integer)
        Dim lsRetorna As String = "", liMedicion As Integer = 0
        Dim strConnString As String = Global.CCRCCV2.My.MySettings.Default.BDPECCRCCConnectionString

        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()

        Try

            cmd.CommandType = CommandType.StoredProcedure

            cmd.CommandText = "PCCRCC_Zona_Sel"
            cmd.CommandTimeout = 5 * 60 '
            cmd.Parameters.Add("@IdMedicionZona", SqlDbType.Int).Value = piMedicionZona
            cmd.Parameters.Add("@RETORNA", SqlDbType.Char).Value = lsRetorna
            cmd.Parameters("@RETORNA").Size = 40
            cmd.Parameters("@RETORNA").Direction = ParameterDirection.Output
            cmd.Parameters.Add("@MEDICION", SqlDbType.Int).Value = liMedicion
            cmd.Parameters("@MEDICION").Direction = ParameterDirection.Output
            cmd.Connection = con


            con.Open()

            cmd.ExecuteNonQuery()

            gsNombreZona = cmd.Parameters("@RETORNA").Value
            giMedicion = cmd.Parameters("@MEDICION").Value


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            con.Dispose()
        End Try

        Return LTrim(RTrim(gsNombreZona))

    End Function

    Public Sub CCRCC_EjecutaProcedimiento(ByVal psNombreSP As String, ByVal piNumeroParametros As Integer, ByVal paParametros As Array, ByRef piRetorno As Int16)
        ' Dim strConnString As String = "Data Source=192.168.1.8;Initial Catalog=BDPECCRCC;User ID=sa;Password=123456789.,"
        Dim strConnString As String = Global.CCRCCV2.My.MySettings.Default.BDPECCRCCConnectionString

        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure

        cmd.CommandText = psNombreSP
        cmd.CommandTimeout = 5 * 60 ' HASTA 5 minutos

        'If Not IsNothing(paParametros.Length) Then
        For i As Integer = 1 To piNumeroParametros
            Select Case paParametros(i - 1, 1)
                Case "BigInt"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.BigInt).Value = paParametros(i - 1, 2)
                Case "Int"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.Int).Value = paParametros(i - 1, 2)
                Case "SmallInt"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.SmallInt).Value = paParametros(i - 1, 2)
                Case "Char"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.Char).Value = paParametros(i - 1, 2)
                Case "TinyInt"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.TinyInt).Value = paParametros(i - 1, 2)
                Case "Real"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.Real).Value = paParametros(i - 1, 2)
                Case "Decimal"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.Decimal).Value = paParametros(i - 1, 2)
                Case "Money"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.Money).Value = paParametros(i - 1, 2)
                Case "Bit"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.Bit).Value = paParametros(i - 1, 2)
                Case "Date"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.Date).Value = paParametros(i - 1, 2)
                Case "DateTime"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.DateTime).Value = paParametros(i - 1, 2)
            End Select

        Next
        If piRetorno > 0 Then
            cmd.Parameters("@RETORNA").Direction = ParameterDirection.Output
        End If

        'End If


        cmd.Connection = con

        Try
            con.Open()

            cmd.ExecuteNonQuery()
            If piRetorno > 0 Then
                piRetorno = cmd.Parameters("@RETORNA").Value
            End If

        Catch ex As Exception
            Throw ex
        Finally
            con.Close()
            con.Dispose()
        End Try
    End Sub

    Public Function FCCRCC_FilasSeleccionadas(ByVal oView As GridView) As String
        Dim aIds(oView.SelectedRowsCount()) As String

        Dim I As Integer
        For I = 0 To oView.SelectedRowsCount() - 1
            If (oView.GetSelectedRows()(I) >= 0) Then

                aIds(I) = oView.GetDataRow(oView.GetSelectedRows()(I)).Item(0).ToString

            End If
        Next

        Return Join(aIds, ",")

    End Function


    Public Function FCCRCC_GuardaPlantillas(ByVal liIndicador As Integer, ByRef oDM As DevExpress.XtraBars.Docking.DockManager, ByRef oView1 As GridView, ByRef oView2 As GridView) As Boolean
        Dim sNombreXml As String
        Try
            sNombreXml = cPrefijoPlantillaDockMan & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000" & LTrim(liIndicador.ToString), 6)
            oDM.SaveLayoutToXml(cCarpetaTrabajo & sNombreXml)

            sNombreXml = cPrefijoPlantillaG01 & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000" & LTrim(liIndicador.ToString), 6)
            oView1.SaveLayoutToXml(cCarpetaTrabajo & sNombreXml)

            sNombreXml = cPrefijoPlantillaG02 & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000" & LTrim(liIndicador.ToString), 6)
            oView2.SaveLayoutToXml(cCarpetaTrabajo & sNombreXml)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function FCCRCC_RecuperaPlantillas(ByVal liIndicador As Integer, ByRef oDM As DevExpress.XtraBars.Docking.DockManager, ByRef oView1 As GridView, ByRef oView2 As GridView) As Boolean
        Dim sNombreXml As String

        Try
            'sNombreXml = cPrefijoPlantillaDockMan & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000", 3)
            sNombreXml = cPrefijoPlantillaDockMan & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000" & LTrim(liIndicador.ToString), 6)
            If (File.Exists(cCarpetaTrabajo & sNombreXml)) And Not (File.Exists(cCarpetaTrabajo & cArchivoReset)) Then
                oDM.RestoreLayoutFromXml(cCarpetaTrabajo & sNombreXml)
            End If

            sNombreXml = cPrefijoPlantillaG01 & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000" & LTrim(liIndicador.ToString), 6)
            If (File.Exists(cCarpetaTrabajo & sNombreXml)) And Not (File.Exists(cCarpetaTrabajo & cArchivoReset)) Then
                oView1.RestoreLayoutFromXml(cCarpetaTrabajo & sNombreXml)
            End If

            sNombreXml = cPrefijoPlantillaG02 & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000" & LTrim(liIndicador.ToString), 6)
            If (File.Exists(cCarpetaTrabajo & sNombreXml)) And Not (File.Exists(cCarpetaTrabajo & cArchivoReset)) Then
                oView2.RestoreLayoutFromXml(cCarpetaTrabajo & sNombreXml)
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function PCCRCC_CongelarColumnas(ByRef oView As GridView) As Boolean
        Dim iColumna As Integer, k As Integer
        Dim ViewInfo As GridViewInfo = CType(oView.GetViewInfo(), GridViewInfo)

        iColumna = oView.FocusedColumn.VisibleIndex
        'Limpia los posibles congelados..
        For k = 0 To ViewInfo.ColumnsInfo.ColumnsCount
            oView.Columns(k).Fixed = FixedStyle.None
            'Cngela hasta la columna actual
            If oView.Columns(k).VisibleIndex < iColumna Then
                oView.Columns(k).Fixed = FixedStyle.Left
            End If
        Next
        ''Cngela hasta la columna actual
        'For k = 0 To iColumna - 1
        '    oView.Columns(k).Fixed = FixedStyle.Left
        'Next


    End Function

    Public Sub PCCRCC_SkuEstadisticas(ByRef oGrid As DevExpress.XtraGrid.GridControl, ByRef oTreeList As DevExpress.XtraTreeList.TreeList)
        Dim sID As String, lCodigoSku As Integer
        Dim oDataRowView As DataRowView
        ' Dim oDataRow As DataRow
        Dim iRowHandle As Integer

        Dim sID_Varios As String = "", sSku As String = "", liIdEncuestaCategoriaSkuOrigen As Integer = 0
        Dim GridView As GridView
        Dim lTreeList As TreeList

        ' liIdEncuestaCategoriaSkuOrigen  obtiene valor cuando se esta invocando este procedimientos desde una encuesta, de lo contrario sera cero...

        sID = 1

        If (Not oTreeList Is Nothing) Then

            ' sID = oTreeList.FocusedNode(oTreeList.Columns("CodigoSku")).ToString()

            lCodigoSku = oTreeList.FocusedNode(oTreeList.Columns("CodigoSku"))
            liIdEncuestaCategoriaSkuOrigen = oTreeList.FocusedNode(oTreeList.Columns("IdEncuestaCategoriaSku"))
            'siIdEncuestaCategoriaSkuOrigen
            sID = lCodigoSku.ToString

        Else
            iRowHandle = (CType(oGrid.FocusedView, DevExpress.XtraGrid.Views.Base.ColumnView)).FocusedRowHandle
            oDataRowView = oGrid.FocusedView.GetRow(iRowHandle)
            sID = oDataRowView("IdMedicionZonaSku")
            lCodigoSku = oDataRowView("CodigoSku")
            sSku = oDataRowView("Sku")

            GridView = oGrid.Views(0)
            sID_Varios = FCCRCC_FilasSeleccionadas(GridView)

        End If




        'FALTA MP
        If sID > 0 Then
            Dim frmPopup As New frmSkuEstadistica


            'frmPopup.Text = "Sku: " & sID.ToString
            'frmPopup.lblSku.Text = "Propiedades y Estadisticas del Sku: " & sID.ToString
            'frmPopup.siCodigoSku = sID

            frmPopup.Text = "Sku: " & lCodigoSku.ToString
            frmPopup.lblSku.Text = "Propiedades y Estadisticas del Sku: (" & lCodigoSku.ToString & ") " & sSku
            frmPopup.siCodigoSku = lCodigoSku
            frmPopup.ssCadenaIdSkus = sID_Varios
            frmPopup.siIndicadorOrigen = giInidicadorActivo
            frmPopup.siIdEncuestaCategoriaSkuOrigen = liIdEncuestaCategoriaSkuOrigen

            frmPopup.siIdMedicionZona = giIdMedicionZona
            frmPopup.MdiParent = frmPrincipal
            frmPopup.WindowState = FormWindowState.Normal

            frmPopup.Show()

        End If



    End Sub

    Public Sub PCCRCC_SkuPropiedades(ByRef oGrid As DevExpress.XtraGrid.GridControl, ByRef oTreeList As DevExpress.XtraTreeList.TreeList)
        ' ''Dim sID As String
        ' ''Dim oDataRowView As DataRowView
        '' '' Dim oDataRow As DataRow
        ' ''Dim iRowHandle As Integer

        ' ''iRowHandle = (CType(oGrid.FocusedView, DevExpress.XtraGrid.Views.Base.ColumnView)).FocusedRowHandle
        ' ''oDataRowView = oGrid.FocusedView.GetRow(iRowHandle)
        ' ''sID = oDataRowView("CodigoSku")

        '' ''FALTA MP
        ' ''If sID > 0 Then
        ' ''    Dim frmPopup As New frmSkuEstadistica

        ' ''    'frmPopup.MdiParent = Me
        ' ''    frmPopup.lblId1.Text = sID.ToString
        ' ''    frmPopup.lblId2.Text = "detalle del sku"

        ' ''    frmPopup.WindowState = FormWindowState.Normal

        ' ''    frmPopup.Show()
        ' ''End If

    End Sub

    Friend Sub PCCRCC_LlamaPlantillas(ByVal piIndicador As Integer, ByVal piSubIndicador As Integer)
        Dim lVoveraCargar As Boolean

        giIndicador = piIndicador
        giSubIndicador = piSubIndicador
        Indicador = EstadoIndicadoresGlobales.SingleOrDefault(Function(p) p.IdIndicador = piIndicador)
        lVoveraCargar = True
        If gaIndicadoresAbiertos(piIndicador) = "1" Then
            For Each f As Form In Application.OpenForms
                If f.Tag = piIndicador Then
                    If gaIndicadoresParametros(piIndicador) = giIdMedicionZona Then
                        lVoveraCargar = False
                        f.Activate()
                    Else
                        f.Close()
                        Exit Sub
                    End If
                End If
            Next
        End If
        If lVoveraCargar Then
            gaIndicadoresAbiertos(piIndicador) = "1"
            gaIndicadoresParametros(piIndicador) = giIdMedicionZona

            Select Case Indicador.FrmPlantilla
                Case "frmPlantilla01"

                    Dim frmIndicador01 As New frmPlantilla01
                    frmIndicador01.MdiParent = frmPrincipal
                    PCCRCC_CargaUltimaPersonalizacion(frmIndicador01)
                    frmIndicador01.Show()

                Case "frmPlantilla02"
                    Dim frmIndicador01 As New frmPlantilla02
                    frmIndicador01.MdiParent = frmPrincipal
                    PCCRCC_CargaUltimaPersonalizacion(frmIndicador01)
                    frmIndicador01.Show()

                Case "frmPlantilla03"
                    Dim frmIndicador01 As New frmPlantilla03
                    frmIndicador01.MdiParent = frmPrincipal
                    ' CargaUltimaPersonalizacion(frmIndicador01)
                    frmIndicador01.Show()

                Case "frmPlantilla04"
                    Dim frmIndicador01 As New frmPlantilla04
                    frmIndicador01.MdiParent = frmPrincipal
                    PCCRCC_CargaUltimaPersonalizacion(frmIndicador01)
                    frmIndicador01.Show()

                Case "frmPlantilla05"
                    Dim frmIndicador01 As New frmPlantilla05
                    frmIndicador01.MdiParent = frmPrincipal
                    PCCRCC_CargaUltimaPersonalizacion(frmIndicador01)
                    frmIndicador01.Show()
                    ' Aumentar mas case por cada plantilla diferente ... segun la tabla TCCRCC_Indicadores ....

                Case "frmPlantilla09"
                    Dim frmIndicador01 As New frmPlantilla09
                    frmIndicador01.MdiParent = frmPrincipal
                    PCCRCC_CargaUltimaPersonalizacion(frmIndicador01)
                    frmIndicador01.Show()

                Case "frmRangos"
                    Dim frmIndicador01 As New frmRangos
                    frmIndicador01.MdiParent = frmPrincipal
                    PCCRCC_CargaUltimaPersonalizacion(frmIndicador01)
                    frmIndicador01.Show()

                Case "frmPlantillaEnc"
                    Dim frmIndicador01 As New frmPlantillaEnc
                    frmIndicador01.MdiParent = frmPrincipal
                    PCCRCC_CargaUltimaPersonalizacion(frmIndicador01)
                    frmIndicador01.Show()
                Case Else
                    Dim frmIndicador01 As New frmPlantilla01
                    frmIndicador01.MdiParent = frmPrincipal
                    PCCRCC_CargaUltimaPersonalizacion(frmIndicador01)
                    frmIndicador01.Show()
            End Select
        End If
    End Sub

    Private Sub PCCRCC_CargaUltimaPersonalizacion(ByRef frm As Object)
        Dim liIndicadorFrm As Integer
        Dim sNombreXml As String

        liIndicadorFrm = CInt(frm.Tag)
        sNombreXml = cPrefijoPlantillaDockMan & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000" & LTrim(liIndicadorFrm.ToString), 6)

        If (File.Exists(cCarpetaTrabajo & sNombreXml)) Then
            frm.DockManager2.RestoreLayoutFromXml(cCarpetaTrabajo & sNombreXml)
        End If


    End Sub

    Public Function PCCRCC_ReemplazaEstadoBoton(ByVal cadenaEstados As String, ByVal estadoBoton As Boolean, ByVal posicionBoton As Integer) As String
        'Return cadenaEstados.Substring(0, cBtnVenta - 1) + IIf(estadoBoton, "2", "1") + cadenaEstados.Substring(posicionBoton, cadenaEstados.Length - (posicionBoton))
        Return cadenaEstados.Substring(0, posicionBoton - 1) + IIf(estadoBoton, "2", "1") + cadenaEstados.Substring(posicionBoton, cadenaEstados.Length - (posicionBoton))
    End Function

    Public Sub PCCRCC_LimpiaPersonalizacion(ByVal liIndicadorForm As Integer)

        If Not gbCierreTotal Then
            gaIndicadoresAbiertos(liIndicadorForm) = "0"
            gaIndicadoresParametros(liIndicadorForm) = ""
            gaIndicadoresFilaPrincipal(liIndicadorForm) = 0
            gaIndicadoresFilaSecundaria(liIndicadorForm) = 0
            gaIndicadoresBotones(liIndicadorForm) = ""
        End If

    End Sub

    Public Sub PCCRCC_EncuestaReplicaEncuesta_Multi(ByRef oGrid As DevExpress.XtraGrid.GridControl, ByRef oTreeList As DevExpress.XtraTreeList.TreeList, ByVal piBoton As Integer, ByVal piIndicador As Integer)
        Dim bRetorna As Boolean = False, iRetorna As Int16 = 0
        Dim sID As String
        Dim GridView As GridView



        Try

            GridView = oGrid.Views(0)
            sID = FCCRCC_FilasSeleccionadas(GridView)


            Dim aParametros(4, 2) As String

            aParametros(0, 0) = "@lsIds"
            aParametros(0, 1) = "Char"
            aParametros(0, 2) = sID

            aParametros(1, 0) = "@Boton"
            aParametros(1, 1) = "SmallInt"
            aParametros(1, 2) = piBoton


            aParametros(2, 0) = "pintIdIndicador"
            aParametros(2, 1) = "SmallInt"
            aParametros(2, 2) = piIndicador

            aParametros(3, 0) = "@IdGrilla"
            aParametros(3, 1) = "SmallInt"
            aParametros(3, 2) = giGridActivo


            CCRCC_EjecutaProcedimiento("PCCRCC_EncuestaReplicaEncuesta_Multi_Upd", 4, aParametros, iRetorna)


        Catch ex As Exception
            Throw ex
        Finally

            gbRecargarGilla = True

            '' ReloadGridPrincipal()
            'oGrid.RefreshDataSource()
            'oGrid.Refresh()

        End Try


    End Sub


    'PCCRCC_EditSkuCanal
    Public Sub PCCRCC_EditSkuCanal(ByRef oGrid As DevExpress.XtraGrid.GridControl, ByRef oTreeList As DevExpress.XtraTreeList.TreeList, ByVal piBoton As Integer, ByVal piIndicador As Integer)
        Dim bRetorna As Boolean = False, iRetorna As Int16 = 0
        Dim sID As String, pdValor As String
        Dim sCamposEditables As String
        Dim GridView As GridView

        sCamposEditables = ",P0_Precio,P0_CmpFac,P0_InvFac,P0_VtaFac,"
        If Not IsNothing(oGrid) Then
            GridView = oGrid.Views(0)
            If sCamposEditables.Contains("," + GridView.FocusedColumn.FieldName + ",") Then

                pdValor = InputBox("Digite el nuevo valor para las celdas de [" + GridView.FocusedColumn.Caption + "]", "Edicion Especial", 0)

                If Not IsNumeric(pdValor) Then
                    Exit Sub
                End If

                Try
                    sID = FCCRCC_FilasSeleccionadas(GridView)

                    Dim aParametros(4, 2) As String

                    aParametros(0, 0) = "@lsIds"
                    aParametros(0, 1) = "Char"
                    aParametros(0, 2) = sID

                    aParametros(1, 0) = "@sCampo"
                    aParametros(1, 1) = "Char"
                    aParametros(1, 2) = GridView.FocusedColumn.FieldName

                    aParametros(2, 0) = "pintIdIndicador"
                    aParametros(2, 1) = "SmallInt"
                    aParametros(2, 2) = piIndicador

                    aParametros(3, 0) = "@IdGrilla"
                    aParametros(3, 1) = "SmallInt"
                    aParametros(3, 2) = giGridActivo

                    aParametros(4, 0) = "@dValor"
                    aParametros(4, 1) = "Decimal"
                    aParametros(4, 2) = Convert.ToDecimal(pdValor)

                    CCRCC_EjecutaProcedimiento("PCCRCC_EditSkuCanal_Upd", 5, aParametros, iRetorna)


                Catch ex As Exception
                    Throw ex
                Finally

                    gbRecargarGilla = True
                    frmPrincipal.siStatus.Caption = "La Edicion se hizo correctamente!"
                End Try

                Exit Sub

            End If

        End If

        MsgBox("Esta opcion esta habilitado solo para los indicadores 11 y 12 a nivel de la Grilla secundaria" + vbCrLf + "Y para ciertas columnas del periodo actual", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Edicion Especial A nivel negocios por Sku Canal")


    End Sub



    Public Sub PCCRCC_EncuestaCambiarEstadoMulti(ByRef oGrid As DevExpress.XtraGrid.GridControl, ByRef oTreeList As DevExpress.XtraTreeList.TreeList, ByVal piBoton As Integer, ByVal piIndicador As Integer)
        Dim bRetorna As Boolean = False
        Dim iRetorna As Int16 = 0 'NO ES NECESARIO...
        Dim sID As String = ""
        Dim GridView As GridView
        Dim lTreeList As TreeList

        Dim sComentario As String, sEstadoNegocio As String = ""



        'Control de las excepciones...
        '--+P V1.011 20150921
        'If giGridActivo = 2 And (giInidicadorActivo = cSkusFueraDeRango Or giInidicadorActivo = cPreciosFueraDeRango) Then



        'MsgBox("Esta opcion NO APLICA en esta grilla o no ha elegido un Negocio especifico", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "CCRCC - Indicadores por Sku Canal")


        'Exit Sub
        'End If

        If IsNothing(oGrid) Then        ' A nivel Encuesta
            lTreeList = oTreeList
            sID = lTreeList.Tag
        End If
        If IsNothing(oTreeList) Then    ' A nivel Resumen
            GridView = oGrid.Views(0)
            sID = FCCRCC_FilasSeleccionadas(GridView)
        End If

        ' GridView = oGrid.Views(0)

        Select Case piBoton
            Case cbtnActivar
                sEstadoNegocio = "Activar Registro"
            Case cbtnCambiarEstadoAtipico
                sEstadoNegocio = "Poner Atipico"
            Case cbtnCambiarEstadoNoProcesa
                sEstadoNegocio = "Poner No Procesa"
            Case cBtnSupervisionMarca
                sEstadoNegocio = "Marcar para Supervision"
            Case cBtnSupervisionValidar
                sEstadoNegocio = "Validar Supervision"
            Case cbtnActivarSupervision
                sEstadoNegocio = "Activar datos de Supervision"
            Case cbtnEnviaSupervision
                sEstadoNegocio = "Envio a Supervision"

        End Select

        If Not sID > "" Then
            frmPrincipal.siStatus.Caption = "No se realizo nigun cambio! porque no se encontro codigo de Negocio seleccionado..."
            Exit Sub
        End If

        'Confirmar la accion?
        sComentario = InputBox("Esta a punto de " + sEstadoNegocio + "," + vbCrLf + "a uno o mas registros, por favor ingrese un motivo", "Ingreso de Comentario", "")
        If sComentario = "" Then
            frmPrincipal.siStatus.Caption = "Cambio de estado NO SE REALIZÓ, porque no se ingreso ningun comentario..."
            Exit Sub
        End If



        Try

            '  sID = FCCRCC_FilasSeleccionadas(GridView)
            Dim aParametros(5, 2) As String

            aParametros(0, 0) = "@lsIds"
            aParametros(0, 1) = "Char"
            aParametros(0, 2) = sID

            aParametros(1, 0) = "@pBoton"
            aParametros(1, 1) = "SmallInt"
            aParametros(1, 2) = piBoton

            aParametros(2, 0) = "pintIdIndicador"
            aParametros(2, 1) = "SmallInt"
            aParametros(2, 2) = piIndicador

            aParametros(3, 0) = "@IdGrilla"
            aParametros(3, 1) = "SmallInt"
            aParametros(3, 2) = giGridActivo

            aParametros(4, 0) = "@sComentario"
            aParametros(4, 1) = "Char"
            aParametros(4, 2) = sEstadoNegocio + " " + sComentario

            CCRCC_EjecutaProcedimiento("PCCRCC_EncuestaCambiarEstadoMulti_Upd", 5, aParametros, iRetorna)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            '' ReloadGridPrincipal()
            'oGrid.RefreshDataSource()
            'oGrid.Refresh()
            gbRecargarGilla = True
        End Try

        ''Comentado por Paul
        'Dim bRetorna As Boolean = False
        'Dim sID As String
        'Dim GridView As GridView
        'Try
        '    GridView = oGrid.Views(0)
        '    sID = FCCRCC_FilasSeleccionadas(GridView)
        '    Dim plantilla As New PlantillasBL
        '    plantilla.CambiarEstadoMultiplesEncuestas(sID, If(piBoton = cbtnCambiarEstadoAtipico, 6, If(piBoton = cbtnCambiarEstadoNoProcesa, 7, 5)), piIndicador, giGridActivo)
        'Catch ex As Exception
        '    Throw ex
        'Finally

        '    gbRecargarGilla = True

        '    'oGrid.RefreshDataSource()
        '    'oGrid.Refresh()
        'End Try
    End Sub


    Public Sub PCCRCC_EncuestaCambiarEstadoMulti_OK(ByRef sId As String, ByVal piBoton As Integer, ByVal piIndicador As Integer)
        Dim bRetorna As Boolean = False
        Dim iRetorna As Int16 = 0 'NO ES NECESARIO...
        ' Dim sID As String = ""
        

        Dim sComentario As String = "", sEstadoNegocio As String = ""
 
        'Control de las excepciones...
        If giGridActivo = 1 And (giInidicadorActivo = cSkusFueraDeRango Or giInidicadorActivo = cPreciosFueraDeRango) Or Not sId > "" Then

            MsgBox("Esta opcion NO APLICA en esta grilla o no ha elegido un Negocio especifico", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "CCRCC - Cambio de Estado de Negocio")
            'GridView1.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("")

            Exit Sub
        End If
 

        ' GridView = oGrid.Views(0)

        Select Case piBoton
            Case cbtnActivar
                sEstadoNegocio = "Activar Registro"
            Case cbtnCambiarEstadoAtipico
                sEstadoNegocio = "Poner Atipico"
            Case cbtnCambiarEstadoNoProcesa
                sEstadoNegocio = "Poner No Procesa"
            Case cBtnSupervisionMarca
                sEstadoNegocio = "Marcar para Supervision"
            Case cBtnSupervisionValidar
                sEstadoNegocio = "Validar Supervision"
            Case cbtnActivarSupervision
                sEstadoNegocio = "Activar datos de Supervision"


        End Select
 

        If piBoton <> cbtnEnviaSupervision Or piBoton <> cBtnSupervisionValidar Then
            'Confirmar la accion?
            sComentario = InputBox("Esta a punto de " + sEstadoNegocio + "," + vbCrLf + "a uno o mas registros, por favor ingrese un motivo ... " + vbCrLf + "NOTA: Recuerde que si tiene abierta alguna Encuesta, debe volver a abrir para que se refleje el nuevo estado", "Ingreso de Comentario", "")
            If sComentario = "" Then
                frmPrincipal.siStatus.Caption = "Cambio de estado NO SE REALIZÓ, porque no se ingreso ningun comentario..."
                Exit Sub
            End If
        End If

     

        Try

            '  sID = FCCRCC_FilasSeleccionadas(GridView)
            Dim aParametros(5, 2) As String

            aParametros(0, 0) = "@lsIds"
            aParametros(0, 1) = "Char"
            aParametros(0, 2) = sId

            aParametros(1, 0) = "@pBoton"
            aParametros(1, 1) = "SmallInt"
            aParametros(1, 2) = piBoton

            aParametros(2, 0) = "pintIdIndicador"
            aParametros(2, 1) = "SmallInt"
            aParametros(2, 2) = piIndicador

            aParametros(3, 0) = "@IdGrilla"
            aParametros(3, 1) = "SmallInt"
            aParametros(3, 2) = giGridActivo

            aParametros(4, 0) = "@sComentario"
            aParametros(4, 1) = "Char"
            aParametros(4, 2) = sEstadoNegocio + " por " + sComentario

            CCRCC_EjecutaProcedimiento("PCCRCC_EncuestaCambiarEstadoMulti_Upd", 5, aParametros, iRetorna)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            gbRecargarGilla = True

        End Try

    End Sub


    Public Function MensajeError(ByVal mensaje As String, ByVal exepcion As String) As String
        Return String.Format(mensaje, exepcion)
    End Function


    Public Function FCCRCC_EncuestaConsultaExistenciaTemporal() As Int16
        Dim bRetorna As Boolean = False, iRetorna As Int16

        Try
            iRetorna = 1
            Dim aParametros(1, 2) As String

            aParametros(0, 0) = "@RETORNA"
            aParametros(0, 1) = "SmallInt"
            aParametros(0, 2) = iRetorna

            CCRCC_EjecutaProcedimiento("PCCRCC_EncuestaConsultaExistenciaTemporal", 1, aParametros, iRetorna)


        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return iRetorna

    End Function


End Module