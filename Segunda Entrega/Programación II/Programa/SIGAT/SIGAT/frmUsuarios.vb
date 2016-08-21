﻿Public Class frmUsuarios

    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub txt_Cedula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cedula.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txt_Cedula2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cedula2.KeyPress
        solonumeros(e)
    End Sub

    Private Sub cbo_Telefonos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_Telefonos.KeyPress
        solonumeros(e)
    End Sub

    Private Sub cmd_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Buscar.Click
        If txt_Cedula.Text.Equals("") Then
            MsgBox("Error, no ingreso ninguna cédula.")
        Else
            panel_Usuario.Enabled = True
            cmd_Modificar.Enabled = True
            txt_Cedula2.Text = txt_Cedula.Text
        End If
    End Sub

    Private Sub cmd_AgregarTel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_AgregarTel.Click

    End Sub

    Private Sub cmd_EliminarTel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_EliminarTel.Click

    End Sub

    Private Sub cmd_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Modificar.Click

    End Sub

    Private Sub cmd_Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Volver.Click
        Me.Close()
    End Sub
End Class