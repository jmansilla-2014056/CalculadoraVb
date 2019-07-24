
Class Calculadora
    Dim _text As New TextBox()


    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        _text.FontSize = 20
        _text.VerticalAlignment = Windows.VerticalAlignment.Stretch
        _text.HorizontalAlignment = Windows.HorizontalAlignment.Stretch
        _text.TextAlignment = TextAlignment.Right
        _text.TextWrapping = TextWrapping.Wrap
        _text.IsEnabled = False

        Cabeza.Children.Add(_text)

        Dim _mc As New Button()
        _mc.Height = 27.5
        _mc.Width = 36
        _mc.Content = "MC"
        _mc.VerticalAlignment = Windows.VerticalAlignment.Top


        Abajo.Children.Add(_mc)
        Grid.SetColumn(_mc, 0)

        Dim _mr As New Button()
        _mr.Height = 27.5
        _mr.Width = 36
        _mr.Content = "MR"
        _mr.VerticalAlignment = Windows.VerticalAlignment.Top
        Abajo.Children.Add(_mr)
        Grid.SetRow(_mr, 0)
        Grid.SetColumn(_mr, 1)

        Dim _ms As New Button()
        _ms.Height = 27.5
        _ms.Width = 36
        _ms.Content = "MS"
        _ms.VerticalAlignment = Windows.VerticalAlignment.Top
        Abajo.Children.Add(_ms)
        Grid.SetRow(_ms, 0)
        Grid.SetColumn(_ms, 2)

        Dim _mp As New Button()
        _mp.Height = 27.5
        _mp.Width = 36
        _mp.Content = "M+"
        _mp.VerticalAlignment = Windows.VerticalAlignment.Top
        Abajo.Children.Add(_mp)
        Grid.SetRow(_mp, 0)
        Grid.SetColumn(_mp, 3)

        Dim _mn As New Button()
        _mn.Height = 27.5
        _mn.Width = 36
        _mn.Content = "M-"
        _mn.VerticalAlignment = Windows.VerticalAlignment.Top
        Abajo.Children.Add(_mn)
        Grid.SetRow(_mn, 0)
        Grid.SetColumn(_mn, 4)

        Dim _ds As New Button()
        _ds.Height = 27.5
        _ds.Width = 36
        _ds.Content = "←"
        _ds.VerticalAlignment = Windows.VerticalAlignment.Top
        Abajo.Children.Add(_ds)
        Grid.SetRow(_ds, 1)
        Grid.SetColumn(_ds, 0)

        Dim _ce As New Button()
        _ce.Height = 27.5
        _ce.Width = 36
        _ce.Content = "CE"
        _ce.VerticalAlignment = Windows.VerticalAlignment.Top
        Abajo.Children.Add(_ce)
        Grid.SetRow(_ce, 1)
        Grid.SetColumn(_ce, 1)

        Dim _c As New Button()
        _c.Height = 27.5
        _c.Width = 36
        _c.Content = "C"
        _c.VerticalAlignment = Windows.VerticalAlignment.Top
        Abajo.Children.Add(_c)
        Grid.SetRow(_c, 1)
        Grid.SetColumn(_c, 2)

        Dim _mm As New Button()
        _mm.Height = 27.5
        _mm.Width = 36
        _mm.Content = "±"
        _mm.VerticalAlignment = Windows.VerticalAlignment.Top
        Abajo.Children.Add(_mm)
        Grid.SetRow(_mm, 1)
        Grid.SetColumn(_mm, 3)

        Dim _r As New Button()
        _r.Height = 27.5
        _r.Width = 36
        _r.Content = "√"
        _r.VerticalAlignment = Windows.VerticalAlignment.Top
        Abajo.Children.Add(_r)
        Grid.SetRow(_r, 1)
        Grid.SetColumn(_r, 4)

        Dim _b7 As New Button()
        _b7.Height = 27.5
        _b7.Width = 36
        _b7.Content = "7"
        _b7.VerticalAlignment = Windows.VerticalAlignment.Top
        Abajo.Children.Add(_b7)
        Grid.SetRow(_b7, 2)
        Grid.SetColumn(_b7, 0)

        Dim _b8 As New Button()
        _b8.Height = 27.5
        _b8.Width = 36
        _b8.Content = "8"
        _b8.VerticalAlignment = Windows.VerticalAlignment.Top
        Abajo.Children.Add(_b8)
        Grid.SetRow(_b8, 2)
        Grid.SetColumn(_b8, 1)

        Dim _b9 As New Button()
        _b9.Height = 27.5
        _b9.Width = 36
        _b9.Content = "9"
        _b9.VerticalAlignment = Windows.VerticalAlignment.Top
        Abajo.Children.Add(_b9)
        Grid.SetRow(_b9, 2)
        Grid.SetColumn(_b9, 2)

        Dim _bd As New Button()
        _bd.Height = 27.5
        _bd.Width = 36
        _bd.Content = "/"
        _bd.VerticalAlignment = Windows.VerticalAlignment.Top
        Abajo.Children.Add(_bd)
        Grid.SetRow(_bd, 2)
        Grid.SetColumn(_bd, 3)

        Dim _bp As New Button()
        _bp.Height = 27.5
        _bp.Width = 36
        _bp.Content = "%"
        _bp.VerticalAlignment = Windows.VerticalAlignment.Top
        Abajo.Children.Add(_bp)
        Grid.SetRow(_bp, 2)
        Grid.SetColumn(_bp, 4)

        Dim _b4 As New Button()
        _b4.Height = 27.5
        _b4.Width = 36
        _b4.Content = "4"
        _b4.VerticalAlignment = Windows.VerticalAlignment.Top
        Abajo.Children.Add(_b4)
        Grid.SetRow(_b4, 3)
        Grid.SetColumn(_b4, 0)

        Dim _b5 As New Button()
        _b5.Height = 27.5
        _b5.Width = 36
        _b5.Content = "5"
        _b5.VerticalAlignment = Windows.VerticalAlignment.Top
        Abajo.Children.Add(_b5)
        Grid.SetRow(_b5, 3)
        Grid.SetColumn(_b5, 1)

        Dim _b6 As New Button()
        _b6.Height = 27.5
        _b6.Width = 36
        _b6.Content = "6"
        _b6.VerticalAlignment = Windows.VerticalAlignment.Top
        Abajo.Children.Add(_b6)
        Grid.SetRow(_b6, 3)
        Grid.SetColumn(_b6, 2)

        Dim _bm As New Button()
        _bm.Height = 27.5
        _bm.Width = 36
        _bm.Content = "*"
        _bm.VerticalAlignment = Windows.VerticalAlignment.Top
        Abajo.Children.Add(_bm)
        Grid.SetRow(_bm, 3)
        Grid.SetColumn(_bm, 3)

        Dim _bu As New Button()
        _bu.Height = 27.5
        _bu.Width = 36
        _bu.Content = "1/x"
        _bu.VerticalAlignment = Windows.VerticalAlignment.Top
        Abajo.Children.Add(_bu)
        Grid.SetRow(_bu, 3)
        Grid.SetColumn(_bu, 4)

        Dim _b1 As New Button()

        _b1.Height = 27.5
        _b1.Width = 36
        _b1.Content = "1"
        _b1.VerticalAlignment = Windows.VerticalAlignment.Top
        Abajo.Children.Add(_b1)
        Grid.SetRow(_b1, 4)
        Grid.SetColumn(_b1, 0)

        Dim _b2 As New Button()
        _b2.Height = 27.5
        _b2.Width = 36
        _b2.Content = "2"
        _b2.VerticalAlignment = Windows.VerticalAlignment.Top
        Abajo.Children.Add(_b2)
        Grid.SetRow(_b2, 4)
        Grid.SetColumn(_b2, 1)

        Dim _b3 As New Button()
        _b3.Height = 27.5
        _b3.Width = 36
        _b3.Content = "3"
        _b3.VerticalAlignment = Windows.VerticalAlignment.Top
        Abajo.Children.Add(_b3)
        Grid.SetRow(_b3, 4)
        Grid.SetColumn(_b3, 2)

        Dim _br As New Button()
        _br.Height = 27.5
        _br.Width = 36
        _br.Content = "-"
        _br.VerticalAlignment = Windows.VerticalAlignment.Top
        Abajo.Children.Add(_br)
        Grid.SetRow(_br, 4)
        Grid.SetColumn(_br, 3)

        Dim _bi As New Button()
        _bi.Height = (27.5 * 2 + 5)
        _bi.Width = 36
        _bi.Content = "="
        _bi.VerticalAlignment = Windows.VerticalAlignment.Top
        Abajo.Children.Add(_bi)
        Grid.SetRow(_bi, 4)
        Grid.SetColumn(_bi, 4)

        Dim _b0 As New Button()
        _b0.Height = 27
        _b0.Width = (36 * 2 + 5)
        _b0.Content = "0"
        _b0.VerticalAlignment = Windows.VerticalAlignment.Bottom
        _b0.HorizontalAlignment = Windows.HorizontalAlignment.Left
        pies.Children.Add(_b0)
        Grid.SetRow(_b0, 0)
        Grid.SetColumn(_b0, 0)

        Dim _bc As New Button()
        _bc.Height = 27
        _bc.Width = 36
        _bc.Content = "."
        _bc.VerticalAlignment = Windows.VerticalAlignment.Bottom
        _bc.HorizontalAlignment = Windows.HorizontalAlignment.Left
        pies.Children.Add(_bc)
        Grid.SetRow(_bc, 0)
        Grid.SetColumn(_bc, 1)

        Dim _ba As New Button()
        _ba.Height = 27
        _ba.Width = 36
        _ba.Content = "+"
        _ba.VerticalAlignment = Windows.VerticalAlignment.Bottom
        _ba.HorizontalAlignment = Windows.HorizontalAlignment.Right
        pies.Children.Add(_ba)
        Grid.SetRow(_ba, 0)
        Grid.SetColumn(_ba, 1)

        AddHandler Abajo.KeyDown, AddressOf TextBox1_KeyPress

        'Numeros
        AddHandler _b0.Click, AddressOf Me.b0_Click
        AddHandler _b1.Click, AddressOf Me.b1_Click
        AddHandler _b2.Click, AddressOf Me.b2_Click
        AddHandler _b3.Click, AddressOf Me.b3_Click
        AddHandler _b4.Click, AddressOf Me.b4_Click
        AddHandler _b5.Click, AddressOf Me.b5_Click
        AddHandler _b6.Click, AddressOf Me.b6_Click
        AddHandler _b7.Click, AddressOf Me.b7_Click
        AddHandler _b8.Click, AddressOf Me.b8_Click
        AddHandler _b9.Click, AddressOf Me.b9_Click

        'Operaciones y punto decimal
        AddHandler _bm.Click, AddressOf Me.bm_Click
        AddHandler _bd.Click, AddressOf Me.bd_Click
        AddHandler _ba.Click, AddressOf Me.ba_Click
        AddHandler _br.Click, AddressOf Me.br_Click
        AddHandler _bc.Click, AddressOf Me.bc_Click
        AddHandler _bp.Click, AddressOf Me.bp_Click
        AddHandler _bu.Click, AddressOf Me.bu_Click
        AddHandler _r.Click, AddressOf Me.r_Click

        'Resto
        AddHandler _c.Click, AddressOf Me.c_Click
        AddHandler _ce.Click, AddressOf Me.ce_Click
        AddHandler _ds.Click, AddressOf Me.ds_Click
        AddHandler _mm.Click, AddressOf Me.mm_Click
        AddHandler _bi.Click, AddressOf Me.bi_Click

    End Sub

    Private Sub b0_Click(sender As System.Object, e As System.Windows.RoutedEventArgs)
        _text.AppendText("0")
    End Sub

    Private Sub b1_Click(sender As System.Object, e As System.Windows.RoutedEventArgs)
        _text.AppendText("1")
    End Sub

    Private Sub b2_Click(sender As System.Object, e As System.Windows.RoutedEventArgs)
        _text.AppendText("2")
    End Sub

    Private Sub b3_Click(sender As System.Object, e As System.Windows.RoutedEventArgs)
        _text.AppendText("3")
    End Sub

    Private Sub b4_Click(sender As System.Object, e As System.Windows.RoutedEventArgs)
        _text.AppendText("4")
    End Sub

    Private Sub b5_Click(sender As System.Object, e As System.Windows.RoutedEventArgs)
        _text.AppendText("5")
    End Sub

    Private Sub b6_Click(sender As System.Object, e As System.Windows.RoutedEventArgs)
        _text.AppendText("6")
    End Sub

    Private Sub b7_Click(sender As System.Object, e As System.Windows.RoutedEventArgs)
        _text.AppendText("7")
    End Sub

    Private Sub b8_Click(sender As System.Object, e As System.Windows.RoutedEventArgs)
        _text.AppendText("8")
    End Sub

    Private Sub b9_Click(sender As System.Object, e As System.Windows.RoutedEventArgs)
        _text.AppendText("9")
    End Sub

    Private Sub bm_Click(sender As System.Object, e As System.Windows.RoutedEventArgs)
        _text.AppendText("*")
    End Sub

    Private Sub bd_Click(sender As System.Object, e As System.Windows.RoutedEventArgs)
        _text.AppendText("/")
    End Sub

    Private Sub ba_Click(sender As System.Object, e As System.Windows.RoutedEventArgs)
        _text.AppendText("+")
    End Sub

    Private Sub br_Click(sender As System.Object, e As System.Windows.RoutedEventArgs)
        _text.AppendText("-")
    End Sub

    Private Sub bc_Click(sender As System.Object, e As System.Windows.RoutedEventArgs)
        _text.AppendText(".")
    End Sub

    Private Sub bp_Click(sender As System.Object, e As System.Windows.RoutedEventArgs)
        _text.AppendText("%")
    End Sub

    Private Sub r_Click(sender As System.Object, e As System.Windows.RoutedEventArgs)
        _text.AppendText("√")
    End Sub

    Private Sub c_Click(sender As System.Object, e As System.Windows.RoutedEventArgs)
        _text.Clear()
    End Sub

    Private Sub ds_Click(sender As System.Object, e As System.Windows.RoutedEventArgs)
        If (_text.Text.ToString.Length > 0) Then
            _text.Text = _text.Text.ToString.Remove(_text.Text.ToString.Length - 1, 1)
        End If
    End Sub

    Private Sub ce_Click(sender As System.Object, e As System.Windows.RoutedEventArgs)
        For index As Integer = 1 To _text.Text.ToString.Length
            If (_text.Text.EndsWith("0") Or _text.Text.EndsWith("1") Or _text.Text.EndsWith("2") Or _text.Text.EndsWith("3") Or _text.Text.EndsWith("4") Or _text.Text.EndsWith("5") And _text.Text.ToString.Length > 0) Then
                _text.Text = _text.Text.ToString.Remove(_text.Text.ToString.Length - 1, 1)
            ElseIf (_text.Text.EndsWith("6") Or _text.Text.EndsWith("7") Or _text.Text.EndsWith("8") Or _text.Text.EndsWith("9") Or _text.Text.EndsWith("%") Or _text.Text.EndsWith(".") And _text.Text.ToString.Length > 0) Then
                _text.Text = _text.Text.ToString.Remove(_text.Text.ToString.Length - 1, 1)
            End If
        Next
    End Sub

    Private Sub mm_Click(sender As System.Object, e As System.Windows.RoutedEventArgs)
        If (_text.Text.StartsWith("-")) Then
            _text.Text = _text.Text.Remove(0, 1)
            _text.Text = _text.Text.ToString.Replace("*-", "w").Replace("*", "z").Replace("/-", "u").Replace("/", "v").Replace("+", "y").Replace("-", "x").Replace("x", "+").Replace("y", "-").Replace("w", "*").Replace("z", "*-").Replace("u", "/").Replace("v", "/-")
        Else
            _text.Text = "-" + _text.Text.ToString.Replace("*-", "w").Replace("*", "z").Replace("/-", "u").Replace("/", "v").Replace("+", "y").Replace("-", "x").Replace("x", "+").Replace("y", "-").Replace("w", "*").Replace("z", "*-").Replace("u", "/").Replace("v", "/-")
        End If
    End Sub

    Private Sub bi_Click(sender As System.Object, e As System.Windows.RoutedEventArgs)
        Dim _Leer As String
        _text.Text = "0+" + _text.Text
        _Leer = (_text.Text).Replace("1-", "1+-").Replace("2-", "2+-").Replace("3-", "3+-").Replace("4-", "4+-").Replace("5-", "5+-").Replace("6-", "6+-").Replace("7-", "7+-").Replace("8-", "8+-").Replace("9-", "9+-").Replace("0-", "0+-").Replace("%", "*1/100").Replace("%", "*1/100").Replace("+√", "+2√").Replace("+-√", "+-2√").Replace("*√", "*2√").Replace("/√", "/2√").Replace("/-√", "/-2√").Replace("*-√", "*-2√")
        _text.Text = Segundo(_Leer).ToString
    End Sub

    Private Sub bu_Click(sender As System.Object, e As System.Windows.RoutedEventArgs)
        Dim _Leer As String
        _text.Text = "0+" + _text.Text
        _Leer = (_text.Text).Replace("1-", "1+-").Replace("2-", "2+-").Replace("3-", "3+-").Replace("4-", "4+-").Replace("5-", "5+-").Replace("6-", "6+-").Replace("7-", "7+-").Replace("8-", "8+-").Replace("9-", "9+-").Replace("0-", "0+-").Replace("%", "*1/100").Replace("%", "*1/100").Replace("+√", "2√").Replace("+-√", "+-2√").Replace("*√", "*2√").Replace("/√", "/2√").Replace("/-√", "/-2√").Replace("*-√", "*-2√")
        _text.Text = (1 / Segundo(_Leer)).ToString
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As KeyEventArgs)
        Dim _Leer As String
        If (e.Key = Key.D9 Or e.Key = Key.NumPad9) Then
            _text.AppendText("9")
        ElseIf (e.Key = Key.D8 Or e.Key = Key.NumPad8) Then
            _text.AppendText("8")
        ElseIf (e.Key = Key.D7 Or e.Key = Key.NumPad7) Then
            _text.AppendText("7")
        ElseIf (e.Key = Key.D6 Or e.Key = Key.NumPad6) Then
            _text.AppendText("6")
        ElseIf (e.Key = Key.D5 Or e.Key = Key.NumPad5) Then
            _text.AppendText("5")
        ElseIf (e.Key = Key.D4 Or e.Key = Key.NumPad4) Then
            _text.AppendText("4")
        ElseIf (e.Key = Key.D3 Or e.Key = Key.NumPad3) Then
            _text.AppendText("3")
        ElseIf (e.Key = Key.D2 Or e.Key = Key.NumPad2) Then
            _text.AppendText("2")
        ElseIf (e.Key = Key.D1 Or e.Key = Key.NumPad1) Then
            _text.AppendText("1")
        ElseIf (e.Key = Key.D0 Or e.Key = Key.NumPad0) Then
            _text.AppendText("0")
        ElseIf (e.Key = Key.Divide) Then
            _text.AppendText("/")
        ElseIf (e.Key = Key.Multiply) Then
            _text.AppendText("*")
        ElseIf (e.Key = Key.Subtract) Then
            _text.AppendText("-")
        ElseIf (e.Key = Key.Add) Then
            _text.AppendText("+")
        ElseIf (e.Key = Key.Back) Then
            If (_text.Text.ToString.Length > 0) Then
                _text.Text = _text.Text.ToString.Remove(_text.Text.ToString.Length - 1, 1)
            End If
        ElseIf (e.Key = Key.Enter) Then
            _text.Text = "0+" + _text.Text
            _Leer = (_text.Text).Replace("1-", "1+-").Replace("2-", "2+-").Replace("3-", "3+-").Replace("4-", "4+-").Replace("5-", "5+-").Replace("6-", "6+-").Replace("7-", "7+-").Replace("8-", "8+-").Replace("9-", "9+-").Replace("0-", "0+-").Replace("%", "*1/100").Replace("+√", "+2√").Replace("+-√", "+-2√").Replace("*√", "*2√").Replace("/√", "/2√").Replace("/-√", "/-2√").Replace("*-√", "*-2√")
            _text.Text = Segundo(_Leer).ToString
        End If
    End Sub

    Function Primero(ByVal cadena As String) As Double
        Dim _operar As New ArrayList
        Dim _Totalultado As Double
        For a As Integer = 0 To (cadena.Length - 1)
            If (cadena.Chars(a) = "*" And Not a = 0) Or (cadena.Chars(a) = "/" And Not a = 0) Or (cadena.Chars(a) = "√" And Not a = 0) Then
                _operar.Add(cadena.Chars(a))
                cadena = Strings.Replace(cadena, cadena.Chars(a), "_", 1, 1)
            End If
        Next
        Dim _chars() = cadena.Split("_")
        _Totalultado = Double.Parse(_chars.GetValue(0))
        Dim x As Integer = 1
        For Each it As Char In _operar
            Select Case it
                Case "√"
                    _Totalultado = _chars.GetValue(x) ^ (1 / _Totalultado)
            End Select
            Select Case it
                Case "*"
                    _Totalultado = _Totalultado * _chars.GetValue(x)
                Case "/"
                    _Totalultado = _Totalultado / _chars.GetValue(x)
            End Select
            x = x + 1
        Next
        Return _Totalultado
    End Function

    Function Segundo(ByVal cadena As String) As Double
        Dim _operar As New ArrayList
        Dim _Totalultado As Double
        For a As Integer = 0 To (cadena.Length - 1)
            If (cadena.Chars(a) = "+" And Not a = 0) Then
                _operar.Add(cadena.Chars(a))
                cadena = Strings.Replace(cadena, cadena.Chars(a), "_", 1, 1)
            End If
        Next
        Dim _chars = cadena.Split("_")
        For it As Integer = 0 To _chars.Length - 1
            If _chars(it).Contains("*") Or _chars(it).Contains("/") Or _chars(it).Contains("√") Then
                _chars(it) = Primero(_chars(it))
            End If
        Next
        _Totalultado = _chars(0)
        Dim x As Integer = 1
        For Each it As Char In _operar
            Select Case it
                Case "+"
                    _Totalultado = _Totalultado + _chars(x)
            End Select
            x = x + 1
        Next
        Return _Totalultado
    End Function


End Class
