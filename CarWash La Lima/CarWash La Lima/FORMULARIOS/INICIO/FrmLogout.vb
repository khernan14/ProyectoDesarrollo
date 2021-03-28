Public Class FrmLogout
    Private Sub FrmLogout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        circularBar.Value = 0
        Me.Opacity = 0 'Iniciamos la opacidad en 0'
        timer1.Start() 'Iniciamos el temporizador 1'
    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        If (circularBar.Value > 0 And circularBar.Value <= 75) Then
            lblMessage.Text = "Procesando cierre de sesion..."
        Else
            lblMessage.Text = "Sesion Cerrada"
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