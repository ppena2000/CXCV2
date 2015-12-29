Imports CCR.AnalisisxCuidad.Support.Constants
Public Class frmDemo

    Private Sub frmDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UcEncuestaNegocios1.MODCCLocal_Todos(cBtnSincronizar)
    End Sub
End Class