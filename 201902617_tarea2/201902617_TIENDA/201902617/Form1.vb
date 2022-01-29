Imports System.Math

Public Class Form1

    Const precioArroz As Double = 2.0
    Const precioFrijol As Double = 1.75
    Const precioAzucar As Double = 2.5
    Const IVA As Double = 0.12

    Dim pagoSinIVA As Double = 0
    Dim valorIVA As Double = 0
    Dim pagocConIVA As Double = 0
    Dim Descuento As Double = 0
    Dim pagoFinal As Double = 0


    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        pagoSinIVA = Round((Val(lbsarroz.Text) * precioArroz) + (Val(lbsfrijol.Text) * precioFrijol) + (Val(lbsazucar.Text) * precioAzucar), 2)

        valorIVA = Round((pagoSinIVA * IVA), 2)
        pagocConIVA = Round((pagoSinIVA + valorIVA), 2)
        Descuento = Round((pagocConIVA * 0.025), 3)
        pagoFinal = Round((pagocConIVA - Descuento), 2)

        lblR1.Text = pagoSinIVA
        lblR2.Text = valorIVA
        lblR3.Text = pagocConIVA
        lblR4.Text = Descuento
        lblR5.Text = pagoFinal
    End Sub

    Private Sub BtnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar.Click
        pagoSinIVA = 0
        valorIVA = 0
        pagocConIVA = 0
        Descuento = 0
        pagoFinal = 0
        lblR1.Text = 0
        lblR2.Text = 0
        lblR3.Text = 0
        lblR4.Text = 0
        lblR5.Text = 0
        lbsarroz.Text = 0
        lbsfrijol.Text = 0
        lbsazucar.Text = 0

    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub

    Private Sub lbsarroz_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lbsarroz.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub lbsfrijol_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lbsfrijol.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub lbsazucar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lbsazucar.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    
End Class
