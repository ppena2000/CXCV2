Public Module Constants

#Region "Constantes App"
    Public Const APP_NAME As String = "CCRCC"
#End Region

#Region "Valores Indicadores"
    Public Const cCategoriasCanalNuevos As Integer = 1
    Public Const cCategoriasCanalNRegs As Integer = 2
    Public Const cMuestrasFueradeRango As Integer = 3
    Public Const cNegociosRegularesSindatos As Integer = 4
    Public Const cContratosSinReemplazo As Integer = 5
    Public Const cNegociosCategoriasFueradeRango As Integer = 6
    Public Const cNegociosCategoriasNSkus As Integer = 7
    Public Const cSkusNuevos As Integer = 8
    Public Const cPosiblesSkusDescontinuados As Integer = 9
    Public Const cSkusSuspendidosConDatos As Integer = 10
    Public Const cSkusFueraDeRango As Integer = 11
    Public Const cPreciosFueraDeRango As Integer = 12
    Public Const cSinStock As Integer = 13
    Public Const cPresencia As Integer = 14
    Public Const cGestionDeRangos As Integer = 15
    Public Const cGestionDeSupervision As Integer = 16
    Public Const cPanelDeControl As Integer = 17
    Public Const cControlDeAvance As Integer = 18
    Public Const cErrores As Integer = 19
    Public Const cEncuesta As Integer = 20
    Public Const cCategorias As Integer = 21
#End Region

#Region "Valores Internos"
    Public Const ESTADO_ASIGNACION_OK As String = "OK"
    Public Const ESTADO_ASIGNACION_PENDIENTE As String = "Pendiente"
    Public Const CADENA_CONEXION_KEY As String = "CCRCnStr"
#End Region


#Region "Mensajes Aplicacion"
    Public Const INFORMACION_EXITO As String = "La información se cargó de manera exitosa"
    Public Const BUSQUEDA_SIN_COINCIDENCIAS As String = "No se encontro información de zonas que coincidan con la medición"
    Public Const ERROR_PROCESO As String = "Ocurrió un error en el proceso. '{0}'"
    Public Const ERROR_MOSTRAR_ENCUESTA As String = "Ocurrió un error al momento de mostrar la información. '{0}'"
    Public Const ERROR_ACTUALIZAR_ENCUESTA As String = "Ocurrió un error en la actualización de la encuesta. '{0}'"
    Public Const NO_SE_ENCONTRO_INFORMACION As String = "No se encontro información relacionada con el negocio seleccionado"
    Public Const ENCUESTA_ACTUALIZACION_EXITO As String = "La encuesta se actualizó con éxito."
    Public Const SELECCIONAR_REGISTRO As String = "Debe seleccionar al menos un registro"
    Public Const ENCUESTA_REPLICA_EXITO As String = "La encuesta se replico con éxito."
    Public Const ENCUESTA_REPLICA_ERROR As String = "No se pudo replicar los valores de la encuesta anterior."
    Public Const SKU_REPLICA_EXITO As String = "Los valores del SKU se replicaron con éxito."
    Public Const SKU_REPLICA_ERROR As String = "No se pudo replicar los valores del sku anterior."
    Public Const VACIAR_CARPETA_TRABAJO As String = "Se vacio la carpeta de trabajo"
    Public Const ACCION_INTERRUMPIDA As String = "No se completo la acción"
#End Region

#Region "Interfaz Principal"
    Public Const cBtnReal As Integer = 1
    Public Const cBtnAnalizada As Integer = 2
    Public Const cBtnVenta As Integer = 3
    Public Const cBtnCompra As Integer = 4
    Public Const cBtnInventario As Integer = 5
    Public Const cBtnPrecio As Integer = 6
    Public Const cBtnSemaforo As Integer = 7
    Public Const cBtnVariacion As Integer = 8
    Public Const cBtnSku As Integer = 9
    Public Const cBtnFrecuencia As Integer = 10
    Public Const cBtnSupervisionMarca As Integer = 11
    'Public Const cBtnSupervisionResumen As Integer = 12
    'Public Const cBtnSupervisionValidar As Integer = 13
    Public Const cBtnEstadistica As Integer = 14
    Public Const cBtnPropiedades As Integer = 15
   
    Public Const cBtnCancelarReplicas As Integer = 19   'no se debe usar
    Public Const cBtnVerDatosValidos As Integer = 20
    Public Const cBtnVerDatosCampo As Integer = 21
    Public Const cBtnVerDatosSupervision As Integer = 22
    Public Const cBtnVerDatosAjustados As Integer = 23
    Public Const cBtnVerTodos As Integer = 24
    Public Const cBtnSemaforoAlertas As Integer = 25
    Public Const cBtnSemaforoOk As Integer = 26
    Public Const cBtnSemaforoTodos As Integer = 27
    Public Const cBtnGestionRangos As Integer = 28

    Public Const cBtnExportaXLS As Integer = 29
    Public Const cBtnExportaPDF As Integer = 30
    Public Const cBtnExportaCSV As Integer = 31
    Public Const cBtnExportaXML As Integer = 32
    Public Const cBtnVistaPrevia As Integer = 35
    Public Const cBtnImprimir As Integer = 36
    Public Const cBtnPanelControl As Integer = 37
    Public Const cBtnControlAvance As Integer = 38
    Public Const cBtnExportaXLSx As Integer = 39

    Public Const cBtnGrabar As Integer = 40
    Public Const cBtnSalir As Integer = 41
    Public Const cBtnSincronizar As Integer = 42


    Public Const cBtnRegistros As Integer = 43
    Public Const cBtnVariablesTodos As Integer = 44
    Public Const cBtnVariablesNinguno As Integer = 45

    'Encuesta
    Public Const cBtnReplicaEncuestaAnterior As Integer = 16
    Public Const cBtnReplicaEncuestaPromedio As Integer = 17
    Public Const cBtnReplicaSkuPromedio As Integer = 18
    'Public Const cbtnAtipico As Integer = 46
    Public Const cbtnCambiarEstadoNoProcesa As Integer = 74
    Public Const cbtnCambiarEstadoAtipico As Integer = 75
    Public Const cbtnActivarSupervision As Integer = 84

    Public Const cbtnVaciar As Integer = 47
    Public Const cbtnActivar As Integer = 48
    Public Const cbtnReplicaSKU As Integer = 49
    'PPM Corregir esto, porque no esta alineado con la base de estados... ver excel...

    'Estados de Negocios
    Public Const cbtnCorrectos As Integer = 60
    Public Const cbtnPendientes As Integer = 61
    Public Const cBtnSupervisionResumen As Integer = 62
    Public Const cbtnEnSupervision As Integer = 63
    Public Const cBtnSupervisionValidar As Integer = 64
    Public Const cbtnValidados As Integer = 65
    Public Const cbtnAtipicos As Integer = 66
    Public Const cbtnNoProcesa As Integer = 67

    Public Const cbtnCongelar As Integer = 71
    Public Const cbtnEstadoTodos As Integer = 72
    Public Const cbtnRecargar As Integer = 73

    Public Const cbtnGestionSupervision As Integer = 79
    Public Const cbtnEnviaSupervision As Integer = 80

    Public Const cbtnSkuActivarRegistro As Integer = 81
    Public Const cbtnSkuPonerAtipico As Integer = 82
    Public Const cbtnSkuPonerNoProcesa As Integer = 83
    Public Const cbtnEditSkuCanal As Integer = 85


#End Region

#Region "Interfaz Principal"
    Public Const cPrefijoPlantillaDockMan As String = "XML_DMI_U"
    Public Const cPrefijoPlantillaRibbon As String = "XML_RIB_U"
    Public Const cCarpetaTrabajo As String = "C:\TMP\"
    Public Const cArchivoReset As String = "CCRCC_Resetea.txt"
    Public Const cPrefijoPlantillaG01 As String = "XML_G01_U"
    Public Const cPrefijoPlantillaG02 As String = "XML_G02_U"
    Public Const cNombre_de_Sistema_y_Version As String = "CCR CC Consistencia por Ciudad v. 1.012"

    ' Cambios Version 1.007
    ' ---------------------------------
    ' - En las encuestas se congelo a la izquierda las columnas TipoDato y Tipo Valido, adicional a la descripcion
    ' - Las ediciones en las encuestas ya no recupera nuevamente la data, mantiene lo ultimo que se edito y graba en el temporal
    ' - Para las palnatillasNeg Se agrego un boton debajo de la grilla principal cuya finalidad es Organizar las grillas principal y secundaria en Horizontal o Vertical.
    ' - Cuando se graban las encuestas editadas, si hay un error Ahora se muestra un Mensage Box (pq la version anterior no mostraba error y daba la apariencia q estaba ok. 
    ' - Se actualizo los estados de los botones para ue el de Envia Supervision, solo este activo en la pestaña Gestion de Supervision.

    ' Cambios Version 1.008
    ' ---------------------------------
    ' - No permite editar la Fecha Meta CXC. Ahora si permite.

    ' Cambios Version 1.010
    ' ---------------------------------
    ' - En la opcion completar skus sale desactivado el botón continuar
    ' - A nivel Encuesta: Se a habilitado la opcion de Ver Estadisticas y la opcion Reemplazar Sku.

    ' Cambios Version 1.011
    ' ---------------------------------
    ' - Cambios a solicitud del usuario, Permitir Activar Negocios directamente desde la Grilla 2 de los indicadores 11 y 12.
    ' - Los cambios esta etiquetados como --+P V1.011 20150921


#End Region

End Module
