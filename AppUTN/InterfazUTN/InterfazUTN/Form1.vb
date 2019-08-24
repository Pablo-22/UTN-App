Public Class Form1

    '*********INTERFAZ***************************************

    Private Sub btnRegistrarLlegada_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnRegistrarLlegada.MouseMove
        btnRegistrarLlegada.FlatAppearance.BorderSize = 1 'Originalmente es 0
    End Sub
    Private Sub btnRegistrarLlegada_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRegistrarLlegada.MouseLeave
        btnRegistrarLlegada.FlatAppearance.BorderSize = 0 'Se había cambiado a 1
    End Sub

    Private Sub btnAñadirEmpleado_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnAñadirEmpleado.MouseMove
        btnAñadirEmpleado.FlatAppearance.BorderSize = 1 'Originalmente es 0
    End Sub
    Private Sub btnAñadirEmpleado_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAñadirEmpleado.MouseLeave
        btnAñadirEmpleado.FlatAppearance.BorderSize = 0 'Se había cambiado a 1
    End Sub

    Private Sub btnAsistencias_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnAsistencias.MouseMove
        btnAsistencias.FlatAppearance.BorderSize = 1 'Originalmente es 0
    End Sub
    Private Sub btnAsistencias_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAsistencias.MouseLeave
        btnAsistencias.FlatAppearance.BorderSize = 0 'Se había cambiado a 1
    End Sub

    Private Sub btnRegistrarSalida_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnRegistrarSalida.MouseMove
        btnRegistrarSalida.FlatAppearance.BorderSize = 1 'Originalmente es 0
    End Sub
    Private Sub btnRegistrarSalida_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRegistrarSalida.MouseLeave
        btnRegistrarSalida.FlatAppearance.BorderSize = 0 'Se había cambiado a 1
    End Sub

    Private Sub btnEliminarEmpleado_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnEliminarEmpleado.MouseMove
        btnEliminarEmpleado.FlatAppearance.BorderSize = 1 'Originalmente es 0
    End Sub
    Private Sub btnEliminarEmpleado_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminarEmpleado.MouseLeave
        btnEliminarEmpleado.FlatAppearance.BorderSize = 0 'Se había cambiado a 1
    End Sub

    Private Sub btnEditarRegistro_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnEditarRegistro.MouseMove
        btnEditarRegistro.FlatAppearance.BorderSize = 1 'Originalmente es 0
    End Sub
    Private Sub btnEditarRegistro_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditarRegistro.MouseLeave
        btnEditarRegistro.FlatAppearance.BorderSize = 0 'Se había cambiado a 1
    End Sub
    '*********INTERFAZ***************************************


    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        End
    End Sub

    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.Click
        Timer1.Enabled = True
    End Sub

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    ' If Me.Opacity = 0 Then
    'Me.Close()
    'Timer1.Enabled = False
    ' Else

    'Me.Opacity = Me.Opacity - 10
    'End If
    'End Sub
End Class
