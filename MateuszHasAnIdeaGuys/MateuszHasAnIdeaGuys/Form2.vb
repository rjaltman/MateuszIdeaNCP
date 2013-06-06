Public Class Form2

    Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" _
    (ByVal lpszCommand As String, ByVal lpszReturnString As String, _
    ByVal cchReturnLength As Long, ByVal hwndCallback As Long) As Long

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim retval As Long
        retval = mciSendString("set CDAudio door closed", "", 0, 0)
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Shell("shutdown /f")
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Shell("cmd.exe")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mciSendString("set CDAudio door open", 0, 0, 0)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim lel As Integer = Convert.ToInt64(TextBox1.Text)
        Dim CDTrayOpen As Boolean = False 'this is global
        Do While Convert.ToInt64(TextBox1.Text) > 0

            'this is in the click event
            If CDTrayOpen Then
                mciSendString("set CDAudio door closed", 0, 0, 0)
                CDTrayOpen = False
            Else
                mciSendString("set CDAudio door open", 0, 0, 0)
                CDTrayOpen = True
            End If

            lel = lel - 1
            TextBox1.Text = lel.ToString
        Loop

    End Sub

    Sub openDatBichhh()
        Dim something As Long
        something = mciSendString("set CDAudio door open", 0, 0, 0)
    End Sub

    Sub closeDatBichhh()
        Dim anotherthing As Long
        anotherthing = mciSendString("set CDAudio door closed", 0, 0, 0)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class