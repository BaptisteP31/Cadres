Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.Reload()
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

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Coeff As Decimal
        Dim selectedItemF = ComboBox1.SelectedIndex
        Dim façon As String
        façon = "/"

        Dim selectedItem = ComboBox1.SelectedIndex

        If selectedItemF = 0 Then 'Cadre Simple, Verre Normal
            My.Settings.Coeff0 = NumericUpDown1.Value

        ElseIf selectedItemF = 1 Then 'Cadre Simple, ARTGLASS
            My.Settings.Coeff1 = NumericUpDown1.Value

        ElseIf selectedItemF = 2 Then 'Cadre Simple, Verre Normal, Collage 1.5
            My.Settings.Coeff2 = NumericUpDown1.Value

        ElseIf selectedItemF = 3 Then 'Cadre Simple, ARTGLASS, Collage 1.5
            My.Settings.Coeff3 = NumericUpDown1.Value

        ElseIf selectedItemF = 4 Then 'Cadre Simple, Verre Normal, Collage 2.5
            My.Settings.Coeff4 = NumericUpDown1.Value

        ElseIf selectedItemF = 5 Then 'Cadre Simple, ARTGLASS, Collage 2.5
            My.Settings.Coeff5 = NumericUpDown1.Value

        ElseIf selectedItemF = 6 Then
            MessageBox.Show("Veuillez sélectionner un type de cadre valide ", "Type de Cadre non valide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox1.SelectedIndex = 7

        ElseIf selectedItemF = 7 Then 'Cadre passe partout, Verre Normal, 1 passe
            My.Settings.Coeff7 = NumericUpDown1.Value

        ElseIf selectedItemF = 8 Then 'Cadre passe partout, ARTGLASS, 1 passe
            My.Settings.Coeff8 = NumericUpDown1.Value

        ElseIf selectedItemF = 9 Then 'Cadre passe partout, Verre Normal, 2 passes
            My.Settings.Coeff9 = NumericUpDown1.Value

        ElseIf selectedItemF = 10 Then 'Cadre passe partout, ARTGLASS, 2 passes
            My.Settings.Coeff10 = NumericUpDown1.Value

        ElseIf selectedItemF = 11 Then 'Cadre passe partout, Verre Normal, 3 passes
            My.Settings.Coeff11 = NumericUpDown1.Value

        ElseIf selectedItemF = 12 Then 'Cadre passe partout, ARTGLASS, 3 passes
            My.Settings.Coeff12 = NumericUpDown1.Value

        ElseIf selectedItemF = 13 Then
            MessageBox.Show("Veuillez sélectionner un type de cadre valide ", "Type de Cadre non valide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox1.SelectedIndex = 14

        ElseIf selectedItemF = 14 Then 'Cadre ML , Verre Normal
            My.Settings.Coeff14 = NumericUpDown1.Value

        ElseIf selectedItemF = 15 Then 'Cadre ML, ARTGLASS
            My.Settings.Coeff15 = NumericUpDown1.Value

        ElseIf selectedItemF = 16 Then 'Cadre ML, Verre Normal, 1 p+b+p
            My.Settings.Coeff15 = NumericUpDown1.Value

        ElseIf selectedItemF = 17 Then 'Cadre ML, ARTGLASS'
            My.Settings.Coeff16 = NumericUpDown1.Value

        ElseIf selectedItemF = 18 Then 'Cadre ML, 30/10e
            My.Settings.Coeff17 = NumericUpDown1.Value

        ElseIf selectedItemF = 19 Then 'Cadre ML, ARTGLASS''
            My.Settings.Coeff18 = NumericUpDown1.Value

        ElseIf selectedItemF = 20 Then
            MessageBox.Show("Veuillez sélectionner un type de cadre valide ", "Type de Cadre non valide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox1.SelectedIndex = 21

        ElseIf selectedItemF = 21 Then 'Cadre entre 2 verres, 2 verres simple
            My.Settings.Coeff21 = NumericUpDown1.Value

        ElseIf selectedItemF = 22 Then 'Cadre entre 2 verres, ARTGLASS
            My.Settings.Coeff22 = NumericUpDown1.Value

        ElseIf selectedItemF = 23 Then 'Cadre entre 2 verres, 2 verre/verre
            My.Settings.Coeff23 = NumericUpDown1.Value

        ElseIf selectedItemF = 24 Then 'Cadre entre 2 verres, ARTGLASS'
            My.Settings.Coeff24 = NumericUpDown1.Value

        ElseIf selectedItemF = 25 Then 'Cadre entre 2 verres, ML inversé
            My.Settings.Coeff25 = NumericUpDown1.Value

        ElseIf selectedItemF = 26 Then 'Cadre entre 2 verres, ARTGLASS''
            My.Settings.Coeff26 = NumericUpDown1.Value

        ElseIf selectedItemF = 27 Then
            MessageBox.Show("Veuillez sélectionner un type de cadre valide ", "Type de Cadre non valide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox1.SelectedIndex = 28

        ElseIf selectedItemF = 28 Then 'Boitage, simple
            My.Settings.Coeff28 = NumericUpDown1.Value

        ElseIf selectedItemF = 29 Then 'Boitage, ARTGLASS
            My.Settings.Coeff29 = NumericUpDown1.Value

        ElseIf selectedItemF = 30 Then 'Boitage, simple, collage 1.5
            My.Settings.Coeff30 = NumericUpDown1.Value

        ElseIf selectedItemF = 31 Then 'Boitage, ARTGLASS, collage 1.5
            My.Settings.Coeff31 = NumericUpDown1.Value

        ElseIf selectedItemF = 32 Then 'Boitage, simple, collage 2.5
            My.Settings.Coeff32 = NumericUpDown1.Value

        ElseIf selectedItemF = 33 Then 'Boitage, ARTGLASS, collage 2.5
            My.Settings.Coeff33 = NumericUpDown1.Value

        ElseIf selectedItemF = 34 Then 'Boitage, simple, 2 passes
            My.Settings.Coeff34 = NumericUpDown1.Value

        ElseIf selectedItemF = 35 Then 'Boitage, ARTGLASS, 2 passes
            My.Settings.Coeff35 = NumericUpDown1.Value

        ElseIf selectedItemF = 36 Then 'Boitage Verre
            My.Settings.Coeff36 = NumericUpDown1.Value

        ElseIf selectedItemF = 37 Then 'Boitage, ARTGLASS'
            My.Settings.Coeff37 = NumericUpDown1.Value

        ElseIf selectedItemF = 38 Then
            MessageBox.Show("Veuillez sélectionner un type de cadre valide ", "Type de Cadre non valide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox1.SelectedIndex = 39

        ElseIf selectedItemF = 39 Then 'Broderie, Canevas, Peinture sur toile, simple
            My.Settings.Coeff39 = NumericUpDown1.Value

        ElseIf selectedItemF = 40 Then 'Broderie, Canevas, Peinture sur toile, ARTGLASS
            My.Settings.Coeff40 = NumericUpDown1.Value

        ElseIf selectedItemF = 41 Then
            MessageBox.Show("Veuillez sélectionner un type de cadre valide ", "Type de Cadre non valide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox1.SelectedIndex = 42

        ElseIf selectedItemF = 42 Then 'Passe partout en chemise, simple
            My.Settings.Coeff42 = NumericUpDown1.Value

        ElseIf selectedItemF = 43 Then 'Passe partout en chemise, ARTGLASS
            My.Settings.Coeff43 = NumericUpDown1.Value

        ElseIf selectedItemF = 44 Then 'Passe partout en chemise, simple, 30/10e
            My.Settings.Coeff44 = NumericUpDown1.Value

        ElseIf selectedItemF = 45 Then 'Passe partout en chemise, ARTGLASS, 30/10e
            My.Settings.Coeff45 = NumericUpDown1.Value

        ElseIf selectedItemF = 46 Then
            MessageBox.Show("Veuillez sélectionner un type de cadre valide ", "Type de Cadre non valide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox1.SelectedIndex = 47

        ElseIf selectedItemF = 47 Then 'Châssis et traverse, Châssis
            My.Settings.Coeff47 = NumericUpDown1.Value

        ElseIf selectedItemF = 48 Then 'Châssis et traverse, Châssis, Traverse
            My.Settings.Coeff48 = NumericUpDown1.Value

        ElseIf selectedItemF = 49 Then 'Châssis et traverse, Caisse amé.
            My.Settings.Coeff49 = NumericUpDown1.Value

        ElseIf selectedItemF = 50 Then 'Châssis et traverse, Caisse amé., Cache clous
            My.Settings.Coeff50 = NumericUpDown1.Value

        End If

        MsgBox("Coefficient sauvegardé", MsgBoxStyle.Information, "Information")
        closing()
        Me.Close()
    End Sub

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        closing()
    End Sub

    Sub closing()
        My.Settings.Save()
        Form1.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim Coeff As Decimal
        Dim selectedItemF = ComboBox1.SelectedIndex
        Dim façon As String
        façon = "/"

        Dim selectedItem = ComboBox1.SelectedIndex

        If selectedItemF = 0 Then 'Cadre Simple, Verre Normal
            NumericUpDown1.Value = My.Settings.Coeff0

        ElseIf selectedItemF = 1 Then 'Cadre Simple, ARTGLASS
            NumericUpDown1.Value = My.Settings.Coeff1

        ElseIf selectedItemF = 2 Then 'Cadre Simple, Verre Normal, Collage 1.5
            NumericUpDown1.Value = My.Settings.Coeff2

        ElseIf selectedItemF = 3 Then 'Cadre Simple, ARTGLASS, Collage 1.5
            NumericUpDown1.Value = My.Settings.Coeff3

        ElseIf selectedItemF = 4 Then 'Cadre Simple, Verre Normal, Collage 2.5
            NumericUpDown1.Value = My.Settings.Coeff4

        ElseIf selectedItemF = 5 Then 'Cadre Simple, ARTGLASS, Collage 2.5
            NumericUpDown1.Value = My.Settings.Coeff5

        ElseIf selectedItemF = 6 Then
            MessageBox.Show("Veuillez sélectionner un type de cadre valide ", "Type de Cadre non valide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox1.SelectedIndex = 7

        ElseIf selectedItemF = 7 Then 'Cadre passe partout, Verre Normal, 1 passe
            NumericUpDown1.Value = My.Settings.Coeff7

        ElseIf selectedItemF = 8 Then 'Cadre passe partout, ARTGLASS, 1 passe
            NumericUpDown1.Value = My.Settings.Coeff8

        ElseIf selectedItemF = 9 Then 'Cadre passe partout, Verre Normal, 2 passes
            NumericUpDown1.Value = My.Settings.Coeff9

        ElseIf selectedItemF = 10 Then 'Cadre passe partout, ARTGLASS, 2 passes
            NumericUpDown1.Value = My.Settings.Coeff10

        ElseIf selectedItemF = 11 Then 'Cadre passe partout, Verre Normal, 3 passes
            NumericUpDown1.Value = My.Settings.Coeff11

        ElseIf selectedItemF = 12 Then 'Cadre passe partout, ARTGLASS, 3 passes
            NumericUpDown1.Value = My.Settings.Coeff12

        ElseIf selectedItemF = 13 Then
            MessageBox.Show("Veuillez sélectionner un type de cadre valide ", "Type de Cadre non valide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox1.SelectedIndex = 14

        ElseIf selectedItemF = 14 Then 'Cadre ML , Verre Normal
            NumericUpDown1.Value = My.Settings.Coeff14

        ElseIf selectedItemF = 15 Then 'Cadre ML, ARTGLASS
            NumericUpDown1.Value = My.Settings.Coeff15

        ElseIf selectedItemF = 16 Then 'Cadre ML, Verre Normal, 1 p+b+p
            NumericUpDown1.Value = My.Settings.Coeff15

        ElseIf selectedItemF = 17 Then 'Cadre ML, ARTGLASS'
            NumericUpDown1.Value = My.Settings.Coeff16

        ElseIf selectedItemF = 18 Then 'Cadre ML, 30/10e
            NumericUpDown1.Value = My.Settings.Coeff17

        ElseIf selectedItemF = 19 Then 'Cadre ML, ARTGLASS''
            NumericUpDown1.Value = My.Settings.Coeff18

        ElseIf selectedItemF = 20 Then
            MessageBox.Show("Veuillez sélectionner un type de cadre valide ", "Type de Cadre non valide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox1.SelectedIndex = 21

        ElseIf selectedItemF = 21 Then 'Cadre entre 2 verres, 2 verres simple
            NumericUpDown1.Value = My.Settings.Coeff21

        ElseIf selectedItemF = 22 Then 'Cadre entre 2 verres, ARTGLASS
            NumericUpDown1.Value = My.Settings.Coeff22

        ElseIf selectedItemF = 23 Then 'Cadre entre 2 verres, 2 verre/verre
            NumericUpDown1.Value = My.Settings.Coeff23

        ElseIf selectedItemF = 24 Then 'Cadre entre 2 verres, ARTGLASS'
            NumericUpDown1.Value = My.Settings.Coeff24

        ElseIf selectedItemF = 25 Then 'Cadre entre 2 verres, ML inversé
            NumericUpDown1.Value = My.Settings.Coeff25

        ElseIf selectedItemF = 26 Then 'Cadre entre 2 verres, ARTGLASS''
            NumericUpDown1.Value = My.Settings.Coeff26

        ElseIf selectedItemF = 27 Then
            MessageBox.Show("Veuillez sélectionner un type de cadre valide ", "Type de Cadre non valide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox1.SelectedIndex = 28

        ElseIf selectedItemF = 28 Then 'Boitage, simple
            NumericUpDown1.Value = My.Settings.Coeff28

        ElseIf selectedItemF = 29 Then 'Boitage, ARTGLASS
            NumericUpDown1.Value = My.Settings.Coeff29

        ElseIf selectedItemF = 30 Then 'Boitage, simple, collage 1.5
            NumericUpDown1.Value = My.Settings.Coeff30

        ElseIf selectedItemF = 31 Then 'Boitage, ARTGLASS, collage 1.5
            NumericUpDown1.Value = My.Settings.Coeff31

        ElseIf selectedItemF = 32 Then 'Boitage, simple, collage 2.5
            NumericUpDown1.Value = My.Settings.Coeff32

        ElseIf selectedItemF = 33 Then 'Boitage, ARTGLASS, collage 2.5
            NumericUpDown1.Value = My.Settings.Coeff33

        ElseIf selectedItemF = 34 Then 'Boitage, simple, 2 passes
            NumericUpDown1.Value = My.Settings.Coeff34

        ElseIf selectedItemF = 35 Then 'Boitage, ARTGLASS, 2 passes
            NumericUpDown1.Value = My.Settings.Coeff35

        ElseIf selectedItemF = 36 Then 'Boitage Verre
            NumericUpDown1.Value = My.Settings.Coeff36

        ElseIf selectedItemF = 37 Then 'Boitage, ARTGLASS'
            NumericUpDown1.Value = My.Settings.Coeff37

        ElseIf selectedItemF = 38 Then
            MessageBox.Show("Veuillez sélectionner un type de cadre valide ", "Type de Cadre non valide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox1.SelectedIndex = 39

        ElseIf selectedItemF = 39 Then 'Broderie, Canevas, Peinture sur toile, simple
            NumericUpDown1.Value = My.Settings.Coeff39

        ElseIf selectedItemF = 40 Then 'Broderie, Canevas, Peinture sur toile, ARTGLASS
            NumericUpDown1.Value = My.Settings.Coeff40

        ElseIf selectedItemF = 41 Then
            MessageBox.Show("Veuillez sélectionner un type de cadre valide ", "Type de Cadre non valide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox1.SelectedIndex = 42

        ElseIf selectedItemF = 42 Then 'Passe partout en chemise, simple
            NumericUpDown1.Value = My.Settings.Coeff42

        ElseIf selectedItemF = 43 Then 'Passe partout en chemise, ARTGLASS
            NumericUpDown1.Value = My.Settings.Coeff43

        ElseIf selectedItemF = 44 Then 'Passe partout en chemise, simple, 30/10e
            NumericUpDown1.Value = My.Settings.Coeff44

        ElseIf selectedItemF = 45 Then 'Passe partout en chemise, ARTGLASS, 30/10e
            NumericUpDown1.Value = My.Settings.Coeff45

        ElseIf selectedItemF = 46 Then
            MessageBox.Show("Veuillez sélectionner un type de cadre valide ", "Type de Cadre non valide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ComboBox1.SelectedIndex = 47

        ElseIf selectedItemF = 47 Then 'Châssis et traverse, Châssis
            NumericUpDown1.Value = My.Settings.Coeff47

        ElseIf selectedItemF = 48 Then 'Châssis et traverse, Châssis, Traverse
            NumericUpDown1.Value = My.Settings.Coeff48

        ElseIf selectedItemF = 49 Then 'Châssis et traverse, Caisse amé.
            NumericUpDown1.Value = My.Settings.Coeff49

        ElseIf selectedItemF = 50 Then 'Châssis et traverse, Caisse amé., Cache clous
            NumericUpDown1.Value = My.Settings.Coeff50

        End If
    End Sub
End Class