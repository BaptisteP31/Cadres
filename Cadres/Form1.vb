Public Class Form1
    Dim Prix As Decimal
    Dim Coeff = 1
    Dim Prix1 As Decimal = 0
    Dim Prix2 As Decimal = 0
    Dim Prix3 As Decimal = 0
    Dim Prix4 As Decimal = 0
    Dim Total As Decimal = 0
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.Reload()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selectedItemF = ComboBox1.SelectedIndex
        Dim façon As String
        façon = "/"

        Dim selectedItem = ComboBox1.SelectedIndex

        If selectedItemF = 0 Then 'Cadre Simple, Verre Normal
            façon = "16,20,25,30"
            Coeff = My.Settings.Coeff0

        ElseIf selectedItemF = 1 Then 'Cadre Simple, ARTGLASS
            façon = "16,20,25,30"
            Coeff = My.Settings.Coeff1

        ElseIf selectedItemF = 2 Then 'Cadre Simple, Verre Normal, Collage 1.5
            façon = "25,35"
            Coeff = My.Settings.Coeff2

        ElseIf selectedItemF = 3 Then 'Cadre Simple, ARTGLASS, Collage 1.5
            façon = "25.35"
            Coeff = My.Settings.Coeff3

        ElseIf selectedItemF = 4 Then 'Cadre Simple, Verre Normal, Collage 2.5
            façon = "25,35"
            Coeff = My.Settings.Coeff4

        ElseIf selectedItemF = 5 Then 'Cadre Simple, ARTGLASS, Collage 2.5
            façon = "25,35"
            Coeff = My.Settings.Coeff5

        ElseIf selectedItemF = 6 Then
            MessageBox.Show("Veuillez sélectionner un type de cadre valide ", "Type de Cadre non valide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox1.SelectedIndex = 7

        ElseIf selectedItemF = 7 Then 'Cadre passe partout, Verre Normal, 1 passe
            façon = "20"
            Coeff = My.Settings.Coeff7

        ElseIf selectedItemF = 8 Then 'Cadre passe partout, ARTGLASS, 1 passe
            façon = "20"
            Coeff = My.Settings.Coeff8

        ElseIf selectedItemF = 9 Then 'Cadre passe partout, Verre Normal, 2 passes
            façon = "25"
            Coeff = My.Settings.Coeff9

        ElseIf selectedItemF = 10 Then 'Cadre passe partout, ARTGLASS, 2 passes
            façon = "25"
            Coeff = My.Settings.Coeff10

        ElseIf selectedItemF = 11 Then 'Cadre passe partout, Verre Normal, 3 passes
            façon = "30"
            Label12.Text = façon
            Coeff = My.Settings.Coeff11
            Label6.Text = Coeff

        ElseIf selectedItemF = 12 Then 'Cadre passe partout, ARTGLASS, 3 passes
            façon = "30"
            Coeff = My.Settings.Coeff12

        ElseIf selectedItemF = 13 Then
            MessageBox.Show("Veuillez sélectionner un type de cadre valide ", "Type de Cadre non valide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox1.SelectedIndex = 14

        ElseIf selectedItemF = 14 Then 'Cadre ML , Verre Normal
            façon = "30"
            Coeff = My.Settings.Coeff14

        ElseIf selectedItemF = 15 Then 'Cadre ML, ARTGLASS
            façon = "30"
            Coeff = My.Settings.Coeff15

        ElseIf selectedItemF = 16 Then 'Cadre ML, Verre Normal, 1 p+b+p
            façon = "40"
            Coeff = My.Settings.Coeff16

        ElseIf selectedItemF = 17 Then 'Cadre ML, ARTGLASS'
            façon = "40"
            Coeff = My.Settings.Coeff17

        ElseIf selectedItemF = 18 Then 'Cadre ML, 30/10e
            façon = "40,60,90"
            Coeff = My.Settings.Coeff18

        ElseIf selectedItemF = 19 Then 'Cadre ML, ARTGLASS''
            façon = "40,60,90"
            Coeff = My.Settings.Coeff19

        ElseIf selectedItemF = 20 Then
            MessageBox.Show("Veuillez sélectionner un type de cadre valide ", "Type de Cadre non valide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox1.SelectedIndex = 21

        ElseIf selectedItemF = 21 Then 'Cadre entre 2 verres, 2 verres simple
            façon = "25"
            Coeff = My.Settings.Coeff21

        ElseIf selectedItemF = 22 Then 'Cadre entre 2 verres, ARTGLASS
            façon = "25"
            Coeff = My.Settings.Coeff22


        ElseIf selectedItemF = 23 Then 'Cadre entre 2 verres, 2 verre/verre
            façon = "30"
            Coeff = My.Settings.Coeff23


        ElseIf selectedItemF = 24 Then 'Cadre entre 2 verres, ARTGLASS'
            façon = "30"
            Coeff = My.Settings.Coeff24

        ElseIf selectedItemF = 25 Then 'Cadre entre 2 verres, ML inversé
            façon = "30,38"
            Coeff = My.Settings.Coeff25

        ElseIf selectedItemF = 26 Then 'Cadre entre 2 verres, ARTGLASS''
            façon = "30,38"
            Coeff = My.Settings.Coeff26

        ElseIf selectedItemF = 27 Then
            MessageBox.Show("Veuillez sélectionner un type de cadre valide ", "Type de Cadre non valide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox1.SelectedIndex = 28

        ElseIf selectedItemF = 28 Then 'Boitage, simple
            façon = "30"
            Coeff = My.Settings.Coeff28

        ElseIf selectedItemF = 29 Then 'Boitage, ARTGLASS
            façon = "30"
            Coeff = My.Settings.Coeff29

        ElseIf selectedItemF = 30 Then 'Boitage, simple, collage 1.5
            façon = "30"
            Coeff = My.Settings.Coeff30

        ElseIf selectedItemF = 31 Then 'Boitage, ARTGLASS, collage 1.5
            façon = "30"
            Coeff = My.Settings.Coeff31

        ElseIf selectedItemF = 32 Then 'Boitage, simple, collage 2.5
            façon = "30"
            Coeff = My.Settings.Coeff32

        ElseIf selectedItemF = 33 Then 'Boitage, ARTGLASS, collage 2.5
            façon = "30"
            Coeff = My.Settings.Coeff33

        ElseIf selectedItemF = 34 Then 'Boitage, simple, 2 passes
            façon = "30"
            Coeff = My.Settings.Coeff34

        ElseIf selectedItemF = 35 Then 'Boitage, ARTGLASS, 2 passes
            façon = "30"
            Coeff = My.Settings.Coeff35

        ElseIf selectedItemF = 36 Then 'Boitage Verre
            façon = "45"
            Coeff = My.Settings.Coeff36

        ElseIf selectedItemF = 37 Then 'Boitage, ARTGLASS'
            façon = "45"
            Coeff = My.Settings.Coeff37

        ElseIf selectedItemF = 38 Then
            MessageBox.Show("Veuillez sélectionner un type de cadre valide ", "Type de Cadre non valide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox1.SelectedIndex = 39

        ElseIf selectedItemF = 39 Then 'Broderie, Canevas, Peinture sur toile, simple
            façon = "20,25,30,50"
            Coeff = My.Settings.Coeff39

        ElseIf selectedItemF = 40 Then 'Broderie, Canevas, Peinture sur toile, ARTGLASS
            façon = "20,25,30,50"
            Coeff = My.Settings.Coeff40

        ElseIf selectedItemF = 41 Then
            MessageBox.Show("Veuillez sélectionner un type de cadre valide ", "Type de Cadre non valide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox1.SelectedIndex = 42

        ElseIf selectedItemF = 42 Then 'Passe partout en chemise, simple
            façon = "20"
            Coeff = My.Settings.Coeff42

        ElseIf selectedItemF = 43 Then 'Passe partout en chemise, ARTGLASS
            façon = "20"
            Coeff = My.Settings.Coeff43

        ElseIf selectedItemF = 44 Then 'Passe partout en chemise, simple, 30/10e
            façon = "25"
            Coeff = My.Settings.Coeff44

        ElseIf selectedItemF = 45 Then 'Passe partout en chemise, ARTGLASS, 30/10e
            façon = "25"
            Coeff = My.Settings.Coeff45

        ElseIf selectedItemF = 46 Then
            MessageBox.Show("Veuillez sélectionner un type de cadre valide ", "Type de Cadre non valide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox1.SelectedIndex = 47

        ElseIf selectedItemF = 47 Then 'Châssis et traverse, Châssis
            façon = "/"
            Coeff = My.Settings.Coeff47

        ElseIf selectedItemF = 48 Then 'Châssis et traverse, Châssis, Traverse
            façon = "/"
            Coeff = My.Settings.Coeff48

        ElseIf selectedItemF = 49 Then 'Châssis et traverse, Caisse amé.
            façon = "/"
            Coeff = My.Settings.Coeff49

        ElseIf selectedItemF = 50 Then 'Châssis et traverse, Caisse amé., Cache clous
            façon = "/"
            Coeff = My.Settings.Coeff50

        End If

        If selectedItem = 47 Then
            NumericUpDown6.Visible = False
            NumericUpDown7.Visible = False
            NumericUpDown3.Enabled = False

        ElseIf selectedItem = 48 Then
            NumericUpDown6.Visible = True
            NumericUpDown7.Visible = True
            NumericUpDown3.Enabled = False

        ElseIf selectedItem = 49 Then
            NumericUpDown6.Visible = False
            NumericUpDown7.Visible = False
            NumericUpDown3.Enabled = False

        ElseIf selectedItem = 50 Then
            NumericUpDown6.Visible = True
            NumericUpDown7.Visible = True
            NumericUpDown3.Enabled = False

        Else
            NumericUpDown6.Visible = False
            NumericUpDown7.Visible = False
            NumericUpDown3.Enabled = True

        End If

        Label12.Text = façon
        Label6.Text = Coeff


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cadre simple
        ComboBox1.Items.Insert(0, "Cadre Simple, Verre Normal")
        ComboBox1.Items.Insert(1, "Cadre Simple, ARTGLASS")
        ComboBox1.Items.Insert(2, "Cadre Simple, Verre Normal, Collage 1.5")
        ComboBox1.Items.Insert(3, "Cadre Simple, ARTGLASS, Collage 1.5")
        ComboBox1.Items.Insert(4, "Cadre Simple, Verre Normal, Collage 2.5")
        ComboBox1.Items.Insert(5, "Cadre Simple, ARTGLASS, Collage 2.5")

        'Séparation
        ComboBox1.Items.Insert(6, "----------------------------------------")

        'Cadre passe partoutInsert
        ComboBox1.Items.Insert(7, "Cadre passe partout, Verre Normal, 1 passe")
        ComboBox1.Items.Insert(8, "Cadre passe partout, ARTGLASS, 1 passe")
        ComboBox1.Items.Insert(9, "Cadre passe partout, Verre Normal, 2 passes")
        ComboBox1.Items.Insert(10, "Cadre passe partout, ARTGLASS, 2 passes")
        ComboBox1.Items.Insert(11, "Cadre passe partout, Verre Normal, 3 passes")
        ComboBox1.Items.Insert(12, "Cadre passe partout, ARTGLASS, 3 passes")

        'Séparation
        ComboBox1.Items.Insert(13, "----------------------------------------")

        'Cadre avec M.Louise
        ComboBox1.Items.Insert(14, "Cadre ML , Verre Normal")
        ComboBox1.Items.Insert(15, "Cadre ML, ARTGLASS")
        ComboBox1.Items.Insert(16, "Cadre ML, Verre Normal, 1 p+b+p")
        ComboBox1.Items.Insert(17, "Cadre ML, ARTGLASS'")
        ComboBox1.Items.Insert(18, "Cadre ML, 30/10e")
        ComboBox1.Items.Insert(19, "Cadre ML, ARTGLASS''")

        'Séparation
        ComboBox1.Items.Insert(20, "----------------------------------------")

        'Cadre entre 2 verres
        ComboBox1.Items.Insert(21, "Cadre entre 2 verres, 2 verres simple")
        ComboBox1.Items.Insert(22, "Cadre entre 2 verres, ARTGLASS")
        ComboBox1.Items.Insert(23, "Cadre entre 2 verres, 2 verre/verre")
        ComboBox1.Items.Insert(24, "Cadre entre 2 verres, ARTGLASS'")
        ComboBox1.Items.Insert(25, "Cadre entre 2 verres, ML inversé")
        ComboBox1.Items.Insert(26, "Cadre entre 2 verres, ARTGLASS''")

        'Séparation
        ComboBox1.Items.Insert(27, "----------------------------------------")

        'Boitage
        ComboBox1.Items.Insert(28, "Boitage, simple")
        ComboBox1.Items.Insert(29, "Boitage, ARTGLASS")
        ComboBox1.Items.Insert(30, "Boitage, simple, collage 1.5")
        ComboBox1.Items.Insert(31, "Boitage, ARTGLASS, collage 1.5")
        ComboBox1.Items.Insert(32, "Boitage, simple, collage 2.5")
        ComboBox1.Items.Insert(33, "Boitage, ARTGLASS, collage 2.5")
        ComboBox1.Items.Insert(34, "Boitage, simple, 2 passes")
        ComboBox1.Items.Insert(35, "Boitage, ARTGLASS, 2 passes")
        ComboBox1.Items.Insert(36, "Boitage Verre")
        ComboBox1.Items.Insert(37, "Boitage, ARTGLASS'")

        'Séparation
        ComboBox1.Items.Insert(38, "----------------------------------------")

        'Broderie, Canevas, Peinture sur toile
        ComboBox1.Items.Insert(39, "Broderie, Canevas, Peinture sur toile, simple")
        ComboBox1.Items.Insert(40, "Broderie, Canevas, Peinture sur toile, ARTGLASS")

        'Séparation
        ComboBox1.Items.Insert(41, "----------------------------------------")

        'Passe partout en chemise
        ComboBox1.Items.Insert(42, "Passe partout en chemise, simple")
        ComboBox1.Items.Insert(43, "Passe partout en chemise, ARTGLASS")
        ComboBox1.Items.Insert(44, "Passe partout en chemise, simple, 30/10e")
        ComboBox1.Items.Insert(45, "Passe partout en chemise, ARTGLASS, 30/10e")

        'Séparation
        ComboBox1.Items.Insert(46, "----------------------------------------")

        'Châssis et traverse
        ComboBox1.Items.Insert(47, "Châssis et traverse, Châssis")
        ComboBox1.Items.Insert(48, "Châssis et traverse, Châssis, Traverse")
        ComboBox1.Items.Insert(49, "Châssis et traverse, Caisse amé.")
        ComboBox1.Items.Insert(50, "Châssis et traverse, Caisse amé., Cache clous")

        ComboBox1.SelectedIndex = 0

        My.Settings.Reload()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FPrix()
        Label13.Text = Prix
        Prix1 = Prix
        FTotal()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FPrix()
        Label14.Text = Prix
        Prix2 = Prix
        FTotal()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FPrix()
        Label15.Text = Prix
        Prix3 = Prix
        FTotal()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FPrix()
        Label16.Text = Prix
        Prix4 = Prix
        FTotal()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.Show()
        Me.Close()
    End Sub

    Sub FPrix()
        Dim Longueur = NumericUpDown1.Value
        Dim Largeur = NumericUpDown2.Value
        Dim Chutes = NumericUpDown3.Value
        Dim PBaguette = NumericUpDown4.Value
        Dim Façon = NumericUpDown5.Value
        Dim Longueur2 = NumericUpDown6.Value
        Dim Largeur2 = NumericUpDown7.Value

        If ComboBox1.SelectedIndex = 47 Then
            Prix = PBaguette * ((Longueur + Largeur) * 2) + Façon

        ElseIf ComboBox1.SelectedIndex = 48 Then
            Prix = (PBaguette * ((Longueur + Largeur) * 2) + Façon) + (PBaguette * (Longueur2 + Largeur2))

        ElseIf ComboBox1.SelectedIndex = 49 Then
            Prix = PBaguette * ((Longueur + Largeur) * 2) + Façon

        ElseIf ComboBox1.SelectedIndex = 50 Then
            Prix = (PBaguette * ((Longueur2 + Largeur2) * 2) + Façon) + PBaguette * ((Longueur + Largeur) * 2) + Façon

        Else
            Prix = (2 * (Longueur + Largeur) + Chutes) * PBaguette + (Longueur * Largeur * Coeff) + Façon
        End If

    End Sub

    Sub FTotal()
        Total = Prix1 + Prix2 + Prix3 + Prix4
        Label17.Text = Total
        Label20.Text = Total + 0.2 * Total
    End Sub
End Class