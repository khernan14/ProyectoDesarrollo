Imports Support

Public Class FrmWelcome
    Private Sub FrmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = ActiveUser.NombreEmpleado & ", " & ActiveUser.ApellidoEmpleado 'Mostramos los datos del usuario'
        circularBar.Value = 0
        Me.Opacity = 0 'Iniciamos la opacidad en 0'
        timer1.Start() 'Iniciamos el temporizador 1'
    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        If (circularBar.Value > 0 And circularBar.Value <= 45) Then
            lblMessage.Text = "Cargando..."
        ElseIf (circularBar.Value > 45 And circularBar.Value <= 68) Then
            lblMessage.Text = "Espere un momento..."
        Else
            lblMessage.Text = "Iniciando Fomulario Principal."
        End If
        circularBar.Value += 1
        circularBar.Text = circularBar.Value.ToString()
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        End If
        If circularBar.Value = 100 Then
            timer1.Stop()
            timer2.Start()
        End If
    End Sub

    Private Sub timer2_Tick(sender As Object, e As EventArgs) Handles timer2.Tick
        Me.Opacity -= 0.1
        If Me.Opacity = 0 Then
            timer2.Stop()
            Me.Close()
        End If
    End Sub
End Class