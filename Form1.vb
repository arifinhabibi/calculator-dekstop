Public Class Form1

    Private Sub txtInput1_TextChanged(sender As Object, e As EventArgs) Handles txtInput1.TextChanged

    End Sub

    Private Sub txtInput2_TextChanged(sender As Object, e As EventArgs) Handles txtInput2.TextChanged

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Try
            Dim num1 As Double = Convert.ToDouble(txtInput1.Text)
            Dim num2 As Double = Convert.ToDouble(txtInput2.Text)
            Dim result As Double = num1 + num2
            txtHasil.Text = result.ToString()
        Catch ex As Exception
            MessageBox.Show("Please enter valid numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnKurang_Click(sender As Object, e As EventArgs) Handles btnKurang.Click
        Try
            Dim num1 As Double = Convert.ToDouble(txtInput1.Text)
            Dim num2 As Double = Convert.ToDouble(txtInput2.Text)
            Dim result As Double = num1 - num2
            txtHasil.Text = result.ToString()
        Catch ex As Exception
            MessageBox.Show("Please enter valid numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnKali_Click(sender As Object, e As EventArgs) Handles btnKali.Click
        Try
            Dim num1 As Double = Convert.ToDouble(txtInput1.Text)
            Dim num2 As Double = Convert.ToDouble(txtInput2.Text)
            Dim result As Double = num1 * num2
            txtHasil.Text = result.ToString()
        Catch ex As Exception
            MessageBox.Show("Please enter valid numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBagi_Click(sender As Object, e As EventArgs) Handles btnBagi.Click
        Try
            Dim num1 As Double = Convert.ToDouble(txtInput1.Text)
            Dim num2 As Double = Convert.ToDouble(txtInput2.Text)
            Dim result As Double = num1 / num2
            txtHasil.Text = result.ToString()
        Catch ex As Exception
            MessageBox.Show("Please enter valid numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMoreThan_Click(sender As Object, e As EventArgs) Handles btnMoreThan.Click
        Try
            Dim num1 As Double = Convert.ToDouble(txtInput1.Text)
            Dim num2 As Double = Convert.ToDouble(txtInput2.Text)
            Dim result As Boolean = num1 > num2
            txtHasil.Text = result.ToString()
        Catch ex As Exception
            MessageBox.Show("Please enter valid numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLessThan_Click(sender As Object, e As EventArgs) Handles btnLessThan.Click
        Try
            Dim num1 As Double = Convert.ToDouble(txtInput1.Text)
            Dim num2 As Double = Convert.ToDouble(txtInput2.Text)
            Dim result As Boolean = num1 < num2
            txtHasil.Text = result.ToString()
        Catch ex As Exception
            MessageBox.Show("Please enter valid numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtInput1.Clear()
        txtInput2.Clear()
        txtHasil.Clear()
        txtInput1.Focus()
    End Sub
End Class