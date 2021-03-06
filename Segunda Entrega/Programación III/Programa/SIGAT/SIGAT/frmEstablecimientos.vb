﻿Public Class frmEstablecimientos

    Private Sub frmEstablecimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
        MsgBox("Los teléfonos se modifican independientemente de los demás datos.")
        'Cargar los establecimientos en el combo box
        Busquedas.cargarestablecimientos(cbo_Establecimientos)
    End Sub

    Private Sub cmd_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Buscar.Click
        If cbo_Establecimientos.Text.Equals("") Then 'Si esta vacio
            'Preguntar si desea crear uno nuevo
            If MsgBox("No selecciono ningun establecimiento. ¿Desea ingresar uno nuevo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                'Habilitar/Inhabilitar objetos
                cmd_Buscar.Enabled = False
                group_Establecimiento.Enabled = True
                group_Propietario.Enabled = True
                cmd_Agregar.Enabled = True
                cmd_Modificar.Enabled = False
                cmd_Eliminar.Enabled = False
                cmd_Parametros.Enabled = True
                'Limpiar datos establecimiento
                cbo_Establecimientos.Text = ""
                txt_NomEstablecimiento.Text = ""
                txt_DirEstablecimiento.Text = ""
                cbo_DptoEstablecimiento.Text = ""
                txt_NroDicose.Text = ""
                txt_NroRut.Text = ""
                txt_NroBps.Text = ""
                txt_Superficie.Text = ""
                txt_LimiteAnimales.Text = ""
                cbo_TelefonosEstablecimiento.Items.Clear()
                cbo_TelefonosEstablecimiento.Text = ""
                txt_NombrePropietario.Text = ""
                txt_ApellidoPropietario.Text = ""
                txt_Cedula.Text = ""
                txt_DirPropietario.Text = ""
                cbo_DptoPropietario.Text = ""
                cbo_TelefonosPropietario.Text = ""
                cbo_TelefonosPropietario.Items.Clear()
            Else 'Si no desea crear uno nuevo
                MsgBox("Seleccione un establecimiento de la lista o ingrese el nombre correctamente.")
            End If
        Else 'Si contiene un establecimiento
            Busquedas.guardarnrodicose(cbo_Establecimientos.Text)
            Busquedas.buscarestablecimiento(cbo_Establecimientos.Text)
        End If
    End Sub

    Private Sub txt_NroDicose_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NroDicose.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txt_NroRut_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NroRut.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txt_NroBps_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NroBps.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txt_Superficie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Superficie.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txt_LimiteAnimales_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_LimiteAnimales.KeyPress
        solonumeros(e)
    End Sub

    Private Sub cbo_TelefonosEstablecimiento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_TelefonosEstablecimiento.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txt_Cedula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cedula.KeyPress
        solonumeros(e)
    End Sub

    Private Sub cbo_TelefonosPropietario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_TelefonosPropietario.KeyPress
        solonumeros(e)
    End Sub

    Private Sub cmd_AgregarTelefono1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_AgregarTelefono1.Click

    End Sub

    Private Sub cmd_BorrarTelefono1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_BorrarTelefono1.Click

    End Sub

    Private Sub cmd_AgregarTelefono2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_AgregarTelefono2.Click

    End Sub

    Private Sub cmd_BorrarTelefono2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_BorrarTelefono2.Click

    End Sub

    Private Sub cmd_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Agregar.Click

    End Sub

    Private Sub cmd_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Modificar.Click

    End Sub

    Private Sub cmd_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Eliminar.Click

    End Sub

    Private Sub cmd_Parametros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Parametros.Click

    End Sub

    Private Sub cmd_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Cancelar.Click
        If cmd_Buscar.Enabled.Equals(False) Then 'Si se esta creando un establecimiento
            If MsgBox("¿Desea cancelar el ingreso del establecimiento?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else 'Si no se esta creando un establecimiento
            Me.Close()
        End If
    End Sub

End Class