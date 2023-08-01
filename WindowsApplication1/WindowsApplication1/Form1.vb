Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim r, g, b As Integer
        Dim thresh As Integer
        thresh = 100

        Dim gray As Integer
        Dim picSource As New Bitmap(PictureBox1.Image)
        Dim picDest = picSource
        PictureBox2.Image = picDest

        For i = 1 To picSource.Width - 1
            For j = 1 To picSource.Height - 1
                r = picSource.GetPixel(i, j).R
                g = picSource.GetPixel(i, j).G
                b = picSource.GetPixel(i, j).B

                gray = CInt((r + g + b) / 3)

                If gray >= thresh Then
                    r = 184
                    g = 220
                    b = 244
                Else
                    r = 0
                    g = 0
                    b = 0
                End If
                picDest.SetPixel(i, j, Color.FromArgb(r, g, b))

            Next
        Next
        For i = 40 To picSource.Width - 180
            For j = 1 To picSource.Height - 1
                r = picSource.GetPixel(i, j).R
                g = picSource.GetPixel(i, j).G
                b = picSource.GetPixel(i, j).B

                gray = CInt((r + g + b) / 3)

                If gray >= thresh Then
                    r = 232
                    g = 168
                    b = 17
                Else
                    r = 0
                    g = 0
                    b = 0
                End If
                picDest.SetPixel(i, j, Color.FromArgb(r, g, b))

            Next
        Next
        For i = 50 To picSource.Width - 90
            For j = 1 To picSource.Height - 1
                r = picSource.GetPixel(i, j).R
                g = picSource.GetPixel(i, j).G
                b = picSource.GetPixel(i, j).B

                gray = CInt((r + g + b) / 3)

                If gray >= thresh Then
                    r = 104
                    g = 202
                    b = 133
                Else
                    r = 0
                    g = 0
                    b = 0
                End If
                picDest.SetPixel(i, j, Color.FromArgb(r, g, b))

            Next
        Next
        For i = 80 To picSource.Width - 90
            For j = 1 To picSource.Height - 1
                r = picSource.GetPixel(i, j).R
                g = picSource.GetPixel(i, j).G
                b = picSource.GetPixel(i, j).B

                gray = CInt((r + g + b) / 3)

                If gray >= thresh Then
                    r = 237
                    g = 94
                    b = 61
                Else
                    r = 0
                    g = 0
                    b = 0
                End If
                picDest.SetPixel(i, j, Color.FromArgb(r, g, b))

            Next
        Next
        For i = 140 To picSource.Width - 50
            For j = 1 To picSource.Height - 1
                r = picSource.GetPixel(i, j).R
                g = picSource.GetPixel(i, j).G
                b = picSource.GetPixel(i, j).B

                gray = CInt((r + g + b) / 3)

                If gray >= thresh Then
                    r = 232
                    g = 168
                    b = 17
                Else
                    r = 0
                    g = 0
                    b = 0
                End If
                picDest.SetPixel(i, j, Color.FromArgb(r, g, b))

            Next
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim keluar As String
        keluar = MsgBox("Are You Sure ?", vbQuestion + vbYesNo, "Confirm")
        If keluar = vbYes Then
            Me.Close()
        ElseIf keluar = vbNo Then
            Exit Sub
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            PictureBox1.SizeMode = PictureBoxSizeMode.Normal
            PictureBox2.SizeMode = PictureBoxSizeMode.Normal
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LinkLabel1.LinkVisited = True
        System.Diagnostics.Process.Start("https://www.facebook.com/fajar.dbrantakan/")
    End Sub
End Class
