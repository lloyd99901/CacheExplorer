Public Class Settings
    Private Sub OKaybutton_Click(sender As Object, e As EventArgs) Handles OKaybutton.Click
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Settings.ini", CheckBox1.Checked & vbNewLine & ComboBox1.Text, False)
        If CheckBox1.Checked = True Then
            Form1.BuildInformationLabel.Text = "DEBUG MODE - LunarHunter"
        Else
            Form1.BuildInformationLabel.Text = Form1.programver & " - LunarHunter"
        End If
    End Sub
    'Purple DarkTone: 40, 40, 70
    'Purple LightTone: 50, 50, 80
    'purple listbox,text and Combo: 30, 30, 60
    'purplebutton: 60, 60, 100

    'gray DarkTone: 64, 64, 64
    'gray LightTone: Gray
    'gray listbox,text and Combo: Gray
    'gray button: DimGray

    'Light DarkTone: DarkGray
    'Light LightTone: 224, 224, 224
    'Light listbox,text and Combo: Gray
    'Light button: 224, 224, 224
    'Panel2: Dark
    'Panel4: Light
    'Panel3: Dark
End Class