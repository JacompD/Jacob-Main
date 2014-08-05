Public Class Form1

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Отключить кнопку 'Search' при запуске программы

        If TextBox1.Text = "" Then

            Button1.Enabled = False

        Else

            Button1.Enabled = True

        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        'При вводе текста в поле поиска, listbox будет выделить или выбрать подходящего слова.

        Dim Item As String = TextBox1.Text.ToString()

        Dim index As Integer = ListBox1.FindString(Item)

        If index = -1 Then

            ListBox1.SelectedIndex = ListBox1.SelectedIndex

        Else

            ListBox1.SetSelected(index, True)

        End If

        If TextBox1.Text = "" Then

            Button1.Enabled = False

        Else

            Button1.Enabled = True

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'После ввода слова и при нажатии на кнопку 'Search' пользователем, получаются его синонимы в большом текстовом поле.

        'Кнопка 'Search' также принимает клавишу ввода 'ENTER', как триггер с кнопкой "Search"

        TextBox2.Clear()

        If TextBox1.Text = "about" And RadioButton1.Checked = True Then

            TextBox2.Text = "almost" & vbCrLf & "approximately" & vbCrLf & "around" & vbCrLf & "concerning" & vbCrLf & "more or less" & vbCrLf & "nearly" & vbCrLf & "or so" & vbCrLf & "regarding" & vbCrLf & "roughly"

        ElseIf TextBox1.Text = "begin" And RadioButton1.Checked = True Then

            TextBox2.Text = "commence" & vbCrLf & "set out" & vbCrLf & "start" & vbCrLf & "start out"

        ElseIf TextBox1.Text = "connect" And RadioButton1.Checked = True Then

            TextBox2.Text = "associate" & vbCrLf & "link" & vbCrLf & "relate"

        ElseIf TextBox1.Text = "dedicate" And RadioButton1.Checked = True Then

            TextBox2.Text = "commit" & vbCrLf & "devote" & vbCrLf & "give"

        ElseIf TextBox1.Text = "earth" And RadioButton1.Checked = True Then

            TextBox2.Text = "Earth" & vbCrLf & "ground" & vbCrLf & "land" & vbCrLf & "world"

        ElseIf TextBox1.Text = "fantastic" And RadioButton1.Checked = True Then

            TextBox2.Text = "tremendous" & vbCrLf & "wonderful"

        ElseIf TextBox1.Text = "grasp" And RadioButton1.Checked = True Then

            TextBox2.Text = "comprehend" & vbCrLf & "grip"

        ElseIf TextBox1.Text = "hint" And RadioButton1.Checked = True Then

            TextBox2.Text = "clue" & vbCrLf & "suggest"

        ElseIf TextBox1.Text = "imagine" And RadioButton1.Checked = True Then

            TextBox2.Text = "conceive of" & vbCrLf & "guess" & vbCrLf & "suppose" & vbCrLf & "think"

        ElseIf TextBox1.Text = "joy" And RadioButton1.Checked = True Then

            TextBox2.Text = "delight" & vbCrLf & "gladness" & vbCrLf & "pleasure" & vbCrLf & "rejoice"

        ElseIf TextBox1.Text = "know" And RadioButton1.Checked = True Then

            TextBox2.Text = "experience" & vbCrLf & "recognise"

        ElseIf TextBox1.Text = "last" And RadioButton1.Checked = True Then

            TextBox2.Text = "end" & vbCrLf & "final"

        ElseIf TextBox1.Text = "maintain" And RadioButton1.Checked = True Then

            TextBox2.Text = "assert" & vbCrLf & "exert" & vbCrLf & "hold" & vbCrLf & "keep" & vbCrLf & "preserve"

        ElseIf TextBox1.Text = "notwithstanding" And RadioButton1.Checked = True Then

            TextBox2.Text = "despite" & vbCrLf & "however" & vbCrLf & "nevertheless"

        ElseIf TextBox1.Text = "operate" And RadioButton1.Checked = True Then

            TextBox2.Text = "control" & vbCrLf & "function" & vbCrLf & "work"

        ElseIf TextBox1.Text = "provide" And RadioButton1.Checked = True Then

            TextBox2.Text = "allow for" & vbCrLf & "render" & vbCrLf & "supply"

        ElseIf TextBox1.Text = "quiet" And RadioButton1.Checked = True Then

            TextBox2.Text = "calm" & vbCrLf & "sient" & vbCrLf & "still"

        ElseIf TextBox1.Text = "remark" And RadioButton1.Checked = True Then

            TextBox2.Text = "comment" & vbCrLf & "mention" & vbCrLf & "note" & vbCrLf & "observe" & vbCrLf & "point out"

        ElseIf TextBox1.Text = "sure" And RadioButton1.Checked = True Then

            TextBox2.Text = "certain" & vbCrLf & "yes"

        ElseIf TextBox1.Text = "twosome" And RadioButton1.Checked = True Then

            TextBox2.Text = "couple" & vbCrLf & "pair"

        ElseIf TextBox1.Text = "uninjured" And RadioButton1.Checked = True Then

            TextBox2.Text = "safe" & vbCrLf & "sound"

        ElseIf TextBox1.Text = "vague" And RadioButton1.Checked = True Then

            TextBox2.Text = "dim" & vbCrLf & "faint" & vbCrLf & "obscure" & vbCrLf & "shadowy" & vbCrLf & "undefined" & vbCrLf & "wispy"

        ElseIf TextBox1.Text = "withstand" And RadioButton1.Checked = True Then

            TextBox2.Text = "defy" & vbCrLf & "resist"

        ElseIf TextBox1.Text = "xylophonist" And RadioButton1.Checked = True Then

            TextBox2.Text = "percussionist"

        ElseIf TextBox1.Text = "yet" And RadioButton1.Checked = True Then

            TextBox2.Text = "however" & vbCrLf & "nevertheless" & vbCrLf & "so far" & vbCrLf & "still"

        ElseIf TextBox1.Text = "zenith" And RadioButton1.Checked = True Then

            TextBox2.Text = "apex" & vbCrLf & "celestial point" & vbCrLf & "climax" & vbCrLf & "peak"

        ElseIf TextBox1.Text = "abat" And RadioButton2.Checked = True Then

            TextBox2.Text = "aérer"

        ElseIf TextBox1.Text = "ballottine" And RadioButton2.Checked = True Then

            TextBox2.Text = "bisou"

        ElseIf TextBox1.Text = "capitalisation" And RadioButton2.Checked = True Then

            TextBox2.Text = "chamoisette"

        ElseIf TextBox1.Text = "déforestation" And RadioButton2.Checked = True Then

            TextBox2.Text = "désavantageuse"

        ElseIf TextBox1.Text = "échauffourée" And RadioButton2.Checked = True Then

            TextBox2.Text = "empoisonnement"

        ElseIf TextBox1.Text = "faucheur" And RadioButton2.Checked = True Then

            TextBox2.Text = "fosse"

        ElseIf TextBox1.Text = "galvanoplastie" And RadioButton2.Checked = True Then

            TextBox2.Text = "grandir"

        ElseIf TextBox1.Text = "herméticité" And RadioButton2.Checked = True Then

            TextBox2.Text = "ilotisme"

        ElseIf TextBox1.Text = "ils" And RadioButton2.Checked = True Then

            TextBox2.Text = "individualiser"

        ElseIf TextBox1.Text = "kamikaze" And RadioButton2.Checked = True Then

            TextBox2.Text = "locuteur"

        ElseIf TextBox1.Text = "locution" And RadioButton2.Checked = True Then

            TextBox2.Text = "margouillis"

        ElseIf TextBox1.Text = "margoulette" And RadioButton2.Checked = True Then

            TextBox2.Text = "militant"

        ElseIf TextBox1.Text = "ocelot" And RadioButton2.Checked = True Then

            TextBox2.Text = "papillonnage"

        ElseIf TextBox1.Text = "papillonnant" And RadioButton2.Checked = True Then

            TextBox2.Text = "périastre"

        ElseIf TextBox1.Text = "ramenard" And RadioButton2.Checked = True Then

            TextBox2.Text = "rehausser"

        ElseIf TextBox1.Text = "salamalec" And RadioButton2.Checked = True Then

            TextBox2.Text = "servitude"

        ElseIf TextBox1.Text = "tétraplégique" And RadioButton2.Checked = True Then

            TextBox2.Text = "tremblotement"

        ElseIf TextBox1.Text = "vélarium" And RadioButton2.Checked = True Then

            TextBox2.Text = "zigzagant"

        ElseIf TextBox1.Text = "zigzaguer" And RadioButton2.Checked = True Then

            TextBox2.Text = "zzz"

        Else

            'A message box will show up if the entered word is not found

            MsgBox("Error...!!! No matching results were found in the chosen language." & vbCrLf & "" & vbCrLf & " Please, make sure the word you entered is in the database of the chosen language ")

        End If
    End Sub

    Private Sub ListBox1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        TextBox1.Text = ListBox1.SelectedItem

        Button1.PerformClick()
    End Sub

    Private Sub ListBox1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseClick
        TextBox1.Text = ListBox1.SelectedItem

        Button1.PerformClick()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

        'Заполнить поле списка с английскими словами.

        If RadioButton1.Checked = True Then

            ListBox1.Items.Clear()

            TextBox2.Clear()

            TextBox1.Clear()

            ListBox1.Items.Add("about")

            ListBox1.Items.Add("begin")

            ListBox1.Items.Add("connect")

            ListBox1.Items.Add("dedicate")

            ListBox1.Items.Add("earth")

            ListBox1.Items.Add("fantastic")

            ListBox1.Items.Add("grasp")

            ListBox1.Items.Add("hint")

            ListBox1.Items.Add("imagine")

            ListBox1.Items.Add("joy")

            ListBox1.Items.Add("know")

            ListBox1.Items.Add("last")

            ListBox1.Items.Add("maintain")

            ListBox1.Items.Add("notwithstanding")

            ListBox1.Items.Add("operate")

            ListBox1.Items.Add("provide")

            ListBox1.Items.Add("quiet")

            ListBox1.Items.Add("remark")

            ListBox1.Items.Add("sure")

            ListBox1.Items.Add("twosome")

            ListBox1.Items.Add("uninjured")

            ListBox1.Items.Add("vague")

            ListBox1.Items.Add("withstand")

            ListBox1.Items.Add("xylophonist")

            ListBox1.Items.Add("yet")

            ListBox1.Items.Add("zenith")

            'Убедитесь, что слова располагаются в алфавитном порядке

            ListBox1.Sorted = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

        'Заполнить поле списка с  французскими словами.

        If RadioButton2.Checked = True Then

            ListBox1.Items.Clear()

            TextBox2.Clear()

            TextBox1.Clear()

            ListBox1.Items.Add("abat")

            ListBox1.Items.Add("ballottine")

            ListBox1.Items.Add("capitalisation")

            ListBox1.Items.Add("déforestation")

            ListBox1.Items.Add("échauffourée")

            ListBox1.Items.Add("faucheur")

            ListBox1.Items.Add("galvanoplastie")

            ListBox1.Items.Add("herméticité")

            ListBox1.Items.Add("ils")

            ListBox1.Items.Add("kamikaze")

            ListBox1.Items.Add("locution")

            ListBox1.Items.Add("margoulette")

            ListBox1.Items.Add("ocelot")

            ListBox1.Items.Add("papillonnant")

            ListBox1.Items.Add("ramenard")

            ListBox1.Items.Add("salamalec")

            ListBox1.Items.Add("tétraplégique")

            ListBox1.Items.Add("vélarium")

            ListBox1.Items.Add("zigzaguer")

            'Убедитесь, что слова располагаются в алфавитном порядке

            ListBox1.Sorted = True

        End If

    End Sub
End Class
