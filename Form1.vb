Public Class Form1
    Dim t1 As Integer = 0
    Dim t7 As Integer = 0
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        selesai()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub
    Sub keadaanawal()
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()
        Timer5.Stop()
        Timer6.Stop()
        Timer7.Stop()
        Timer8.Stop()
        Timer9.Stop()
        Timer10.Stop()
        Timer11.Stop()
        Timer12.Stop()
        Timer13.Stop()
        Timer14.Stop()
        Timer15.Stop()
        Label54.Top = 401
        Label61.Top = 243
        Label60.Top = 180
        Label62.Left = 485
        Label63.Top = 80
        Label64.Top = 110
        Label65.Top = 218
        label0.Visible = True
        label0.Text = "Klik START untuk mulai!"
        start.Visible = True
        waktuanda.Visible = False
        penghitungwaktu.Visible = False
        playagain.Visible = False
        penghitungwaktu.Text = 0
        t7 = 0
        tips.Visible = False
    End Sub
    Private Sub start_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles start.Click
        movetostart()
        Timer1.Start()
        Timer3.Start()
        Timer5.Start()
        Timer8.Start()
        Timer10.Start()
        Timer12.Start()
        Timer14.Start()
        Timer7.Start()
        label0.Text = "Gerakkan mouse ke FINISH!"
        start.Visible = False
        penghitungwaktu.Visible = True
        waktuanda.Visible = True
        tips.Visible = True
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call keadaanawal()
    End Sub
    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        t7 = t7 + 1
        penghitungwaktu.Text = t7 & " " & "detik"
    End Sub
    Private Sub playagain_Click(sender As Object, e As EventArgs) Handles playagain.Click
        Call keadaanawal()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        t1 = t1 + 1
        Label54.Top = Label54.Top + 1
        If Label54.Top = 410 Then
            Timer1.Enabled = False
            Timer2.Enabled = True
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        t1 = t1 + 1
        Label54.Top = Label54.Top - 1
        If Label54.Top = 401 Then
            Timer1.Enabled = True
            Timer2.Enabled = False
        End If
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        t1 = t1 + 1
        Label61.Top -= 1
        If Label61.Top = 218 Then
            Timer3.Enabled = False
            Timer4.Enabled = True
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        t1 = t1 + 1
        Label61.Top += 1
        If Label61.Top = 243 Then
            Timer3.Enabled = True
            Timer4.Enabled = False
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        t1 = t1 + 1
        Label60.Top = Label60.Top - 1
        If Label60.Top = 12 Then
            Timer5.Enabled = False
            Timer6.Enabled = True
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        t1 = t1 + 1
        Label60.Top = Label60.Top + 1
        If Label60.Top = 180 Then
            Timer5.Enabled = True
            Timer6.Enabled = False
        End If
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        t1 = t1 + 1
        Label62.Left = Label62.Left + 1
        If Label62.Left = 590 Then
            Timer8.Enabled = False
            Timer9.Enabled = True
        End If
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        t1 = t1 + 1
        Label62.Left = Label62.Left - 1
        If Label62.Left = 485 Then
            Timer8.Enabled = True
            Timer9.Enabled = False
        End If
    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        t1 = t1 + 1
        Label63.Top = Label63.Top + 1
        If Label63.Top = 350 Then
            Timer10.Enabled = False
            Timer11.Enabled = True
        End If
    End Sub

    Private Sub Timer11_Tick(sender As Object, e As EventArgs) Handles Timer11.Tick
        t1 = t1 + 1
        Label63.Top = Label63.Top - 1
        If Label63.Top = 80 Then
            Timer10.Enabled = True
            Timer11.Enabled = False
        End If
    End Sub

    Private Sub Timer12_Tick(sender As Object, e As EventArgs) Handles Timer12.Tick
        t1 = t1 + 1
        Label64.Top = Label64.Top + 1
        If Label64.Top = 373 Then
            Timer12.Enabled = False
            Timer13.Enabled = True
        End If
    End Sub

    Private Sub Timer13_Tick(sender As Object, e As EventArgs) Handles Timer13.Tick
        t1 = t1 + 1
        Label64.Top = Label64.Top - 1
        If Label64.Top = 110 Then
            Timer12.Enabled = True
            Timer13.Enabled = False
        End If
    End Sub

    Private Sub finish_MouseEnter(sender As Object, e As EventArgs) Handles finish.MouseEnter
        'Form2.Show()

        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()
        Timer5.Stop()
        Timer6.Stop()
        Timer7.Stop()
        Timer8.Stop()
        Timer9.Stop()
        Timer10.Stop()
        Timer11.Stop()
        Timer12.Stop()
        Timer13.Stop()
        Timer14.Stop()
        Timer15.Stop()
        label0.Text = "Klik PLAYAGAIN untuk mulai ulang!"
        tips.Visible = False
        playagain.Visible = True
        Dim result As DialogResult
        result = MsgBox("Selamat, Anda berhasil mencapai FINISH!", vbOK, "Berhasil!")
        If result = DialogResult.OK Then
            selesai()
        End If
    End Sub

    Private Sub movetostart()
        Dim startingpoint = startpoint.Location()
        startingpoint.Offset(300, 135)
        Cursor.Position = PointToScreen(startingpoint)
    End Sub

    Private Sub restartsz1()
        Dim safezone1point = safezone1.Location()
        safezone1point.Offset(350, 115)
        Cursor.Position = PointToScreen(safezone1point)
    End Sub

    Private Sub restartsz2()
        Dim safezone2point = safezone2.Location()
        safezone2point.Offset(350, 115)
        Cursor.Position = PointToScreen(safezone2point)
    End Sub

    Private Sub selesai()
        Dim panelkiri = playagain.Location()
        panelkiri.Offset(100, 20)
        Cursor.Position = PointToScreen(panelkiri)
    End Sub

    Private Sub Timer14_Tick(sender As Object, e As EventArgs) Handles Timer14.Tick
        t1 = t1 + 1
        Label65.Top += 1
        If Label65.Top = 243 Then
            Timer14.Enabled = False
            Timer15.Enabled = True
        End If
    End Sub

    Private Sub Timer15_Tick(sender As Object, e As EventArgs) Handles Timer15.Tick
        t1 = t1 + 1
        Label65.Top -= 1
        If Label65.Top = 218 Then
            Timer14.Enabled = True
            Timer15.Enabled = False
        End If
    End Sub

    Private Sub mousewallstart(sender As Object, e As EventArgs) Handles Label8.MouseEnter, Label75.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label18.MouseEnter, Label16.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter, Label1.MouseEnter
        movetostart()
    End Sub

    Private Sub safezoneenter(sender As Object, e As EventArgs) Handles Label78.MouseEnter, Label76.MouseEnter, Label68.MouseEnter, Label67.MouseEnter, Label66.MouseEnter, Label65.MouseEnter, Label61.MouseEnter, Label58.MouseEnter, Label57.MouseEnter, Label56.MouseEnter, Label55.MouseEnter, Label54.MouseEnter, Label53.MouseEnter, Label51.MouseEnter, Label50.MouseEnter, Label49.MouseEnter, Label48.MouseEnter, Label47.MouseEnter, Label46.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label29.MouseEnter, Label19.MouseEnter, Label17.MouseEnter, Label15.MouseEnter
        restartsz1()
    End Sub

    Private Sub safezone2enter(sender As Object, e As EventArgs) Handles Label79.MouseEnter, Label80.MouseEnter, Label81.MouseEnter, Label77.MouseEnter, Label59.MouseEnter, Label52.MouseEnter, Label28.MouseEnter, Label22.MouseEnter
        restartsz2()
    End Sub
End Class