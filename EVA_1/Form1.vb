Public Class Form1


    Private Sub BOTON1_Click(sender As Object, e As EventArgs) Handles BOTON1.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) Or String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MessageBox.Show("Por favor, ingrese valores en ambos cuadros de texto.")
            Return
        End If


        Dim num1 As Double
        Dim num2 As Double
        If Not Double.TryParse(TextBox1.Text, num1) Or Not Double.TryParse(TextBox2.Text, num2) Then
            MessageBox.Show("Por favor, ingrese números válidos.")
            Return
        End If

        ' Obtener la operación seleccionada
        Dim resultado As Double
        Select Case ComboBox1.SelectedItem.ToString()
            Case "Suma"
                resultado = num1 + num2
            Case "Resta"
                resultado = num1 - num2
            Case "Multiplicación"
                resultado = num1 * num2
            Case "División"
                If num2 = 0 Then
                    MessageBox.Show("No se puede dividir por cero.")
                    Return
                End If
                resultado = num1 / num2
            Case Else
                MessageBox.Show("Por favor, seleccione una operación.")
                Return
        End Select

        ' Mostrar el resultado
        MessageBox.Show("El resultado es: " & resultado.ToString())

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
