Public Class File_Organizer


    '==================================================================================================
    'for Desktop to File:one
    Private Sub RectangleShape9_Click(sender As Object, e As EventArgs) Handles RectangleShape9.Click
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(
                    My.Computer.FileSystem.SpecialDirectories.Desktop,
                   Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "*.docx*")

            Dim foundFileInfo As New System.IO.FileInfo(foundFile)
            My.Computer.FileSystem.MoveFile(foundFile, "C:\Users\100047434\Desktop\WordFiles\" & foundFileInfo.Name)
        Next
    End Sub

    Private Sub RectangleShape13_Click(sender As Object, e As EventArgs) Handles RectangleShape13.Click
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(
                    My.Computer.FileSystem.SpecialDirectories.MyDocuments,
                   Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "*.docx*")

            Dim foundFileInfo As New System.IO.FileInfo(foundFile)
            My.Computer.FileSystem.MoveFile(foundFile, "C:\Users\100047434\Desktop\WordFiles\" & foundFileInfo.Name)
        Next
    End Sub

    '==================================================================================================
    Private Sub RectangleShape100_Click(sender As Object, e As EventArgs) Handles RectangleShape100.Click
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(
                    My.Computer.FileSystem.SpecialDirectories.Desktop,
                   Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "*.accdb*")

            Dim foundFileInfo As New System.IO.FileInfo(foundFile)
            My.Computer.FileSystem.MoveFile(foundFile, "C:\Users\100047434\Desktop\WordFiles\" & foundFileInfo.Name)
        Next
    End Sub

    Private Sub RectangleShape96_Click(sender As Object, e As EventArgs) Handles RectangleShape96.Click
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(
                    My.Computer.FileSystem.SpecialDirectories.MyDocuments,
                   Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "*.accdb*")

            Dim foundFileInfo As New System.IO.FileInfo(foundFile)
            My.Computer.FileSystem.MoveFile(foundFile, "C:\Users\100047434\Desktop\WordFiles\" & foundFileInfo.Name)
        Next
    End Sub
    '==================================================================================================
    Private Sub RectangleShape79_Click(sender As Object, e As EventArgs) Handles RectangleShape79.Click
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(
                    My.Computer.FileSystem.SpecialDirectories.Desktop,
                   Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "*.pdf*")

            Dim foundFileInfo As New System.IO.FileInfo(foundFile)
            My.Computer.FileSystem.MoveFile(foundFile, "C:\Users\100047434\Desktop\WordFiles\" & foundFileInfo.Name)
        Next
    End Sub

    Private Sub RectangleShape75_Click(sender As Object, e As EventArgs) Handles RectangleShape75.Click
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(
                    My.Computer.FileSystem.SpecialDirectories.MyDocuments,
                   Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "*.pdf*")

            Dim foundFileInfo As New System.IO.FileInfo(foundFile)
            My.Computer.FileSystem.MoveFile(foundFile, "C:\Users\100047434\Desktop\WordFiles\" & foundFileInfo.Name)
        Next
    End Sub
    '==================================================================================================
    Private Sub RectangleShape58_Click(sender As Object, e As EventArgs) Handles RectangleShape58.Click
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(
                   My.Computer.FileSystem.SpecialDirectories.Desktop,
                  Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "*.pptx*")

            Dim foundFileInfo As New System.IO.FileInfo(foundFile)
            My.Computer.FileSystem.MoveFile(foundFile, "C:\Users\100047434\Desktop\WordFiles\" & foundFileInfo.Name)
        Next
    End Sub

    Private Sub RectangleShape54_Click(sender As Object, e As EventArgs) Handles RectangleShape54.Click
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(
                   My.Computer.FileSystem.SpecialDirectories.MyDocuments,
                  Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "*.pptx*")

            Dim foundFileInfo As New System.IO.FileInfo(foundFile)
            My.Computer.FileSystem.MoveFile(foundFile, "C:\Users\100047434\Desktop\WordFiles\" & foundFileInfo.Name)
        Next
    End Sub
    '==================================================================================================
    Private Sub RectangleShape36_Click(sender As Object, e As EventArgs) Handles RectangleShape36.Click
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(
                  My.Computer.FileSystem.SpecialDirectories.Desktop,
                 Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "*.xlsx*")

            Dim foundFileInfo As New System.IO.FileInfo(foundFile)
            My.Computer.FileSystem.MoveFile(foundFile, "C:\Users\100047434\Desktop\WordFiles\" & foundFileInfo.Name)
        Next
    End Sub

    Private Sub RectangleShape32_Click(sender As Object, e As EventArgs) Handles RectangleShape32.Click
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(
                  My.Computer.FileSystem.SpecialDirectories.MyDocuments,
                 Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "*.xlsx*")

            Dim foundFileInfo As New System.IO.FileInfo(foundFile)
            My.Computer.FileSystem.MoveFile(foundFile, "C:\Users\100047434\Desktop\WordFiles\" & foundFileInfo.Name)
        Next
    End Sub
    '==================================================================================================

    '
    '██████████████─██████████████───████████████████───██████████████─████████──████████─██████████████─██████████████─
    '██░░░░░░░░░░██─██░░░░░░░░░░██───██░░░░░░░░░░░░██───██░░░░░░░░░░██─██░░░░██──██░░░░██─██░░░░░░░░░░██─██░░░░░░░░░░██─
    ''█░░██████░░██─██░░██████░░██───██░░████████░░██───██░░██████░░██─████░░██──██░░████─██░░██████░░██─██░░██████████─
    ''█░░██──██░░██─██░░██──██░░██───██░░██────██░░██───██░░██──██░░██───██░░░░██░░░░██───██░░██──██░░██─██░░██─────────
    ''█░░██████░░██─██░░██████░░████─██░░████████░░██───██░░██████░░██───████░░░░░░████───██░░██████░░██─██░░██████████─
    ''█░░░░░░░░░░██─██░░░░░░░░░░░░██─██░░░░░░░░░░░░██───██░░░░░░░░░░██─────██░░░░░░██─────██░░░░░░░░░░██─██░░░░░░░░░░██─
    ''█░░██████░░██─██░░████████░░██─██░░██████░░████───██░░██████░░██───████░░░░░░████───██░░██████░░██─██████████░░██─
    ''█░░██──██░░██─██░░██────██░░██─██░░██──██░░██─────██░░██──██░░██───██░░░░██░░░░██───██░░██──██░░██─────────██░░██─
    ''█░░██──██░░██─██░░████████░░██─██░░██──██░░██████─██░░██──██░░██─████░░██──██░░████─██░░██──██░░██─██████████░░██─
    ''█░░██──██░░██─██░░░░░░░░░░░░██─██░░██──██░░░░░░██─██░░██──██░░██─██░░░░██──██░░░░██─██░░██──██░░██─██░░░░░░░░░░██─
    ''█████──██████─████████████████─██████──██████████─██████──██████─████████──████████─██████──██████─██████████████─
    '───────────────────────────────────────────────────────────────────────────────────────────────────────────────────


    '==================================================================================================
    '==================================================================================================
    'PANEL CONTROL 1
    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click
        Panel1.Visible = True
        Panel2.Visible = False

    End Sub

    Private Sub RectangleShape15_Click(sender As Object, e As EventArgs) Handles RectangleShape15.Click
        Panel1.Visible = False
        Panel2.Visible = True
    End Sub

    Private Sub RectangleShape17_Click(sender As Object, e As EventArgs) Handles RectangleShape17.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True
    End Sub

    Private Sub RectangleShape29_Click(sender As Object, e As EventArgs) Handles RectangleShape29.Click
        Panel1.Visible = True
        Panel3.Visible = False
        Panel4.Visible = False
        Panel2.Visible = False
    End Sub

    Private Sub RectangleShape18_Click(sender As Object, e As EventArgs) Handles RectangleShape18.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = True
    End Sub
    '==================================================================================================
    '==================================================================================================
    'PANEL 2
    Private Sub RectangleShape28_Click(sender As Object, e As EventArgs) Handles RectangleShape28.Click
        Panel1.Visible = True
        Panel2.Visible = False
    End Sub

    Private Sub RectanbleShape26_Click(sender As Object, e As EventArgs) Handles RectangleShape26.Click
        Panel2.Visible = True
        Panel1.Visible = False
    End Sub

    Private Sub RectangleShape24_Click(sender As Object, e As EventArgs) Handles RectangleShape24.Click
        Panel3.Visible = True
        Panel1.Visible = False
        Panel2.Visible = False
    End Sub

    Private Sub RectangleShape19_Click(sender As Object, e As EventArgs) Handles RectangleShape19.Click
        Panel2.Visible = True
        Panel3.Visible = False
        Panel1.Visible = False
        Panel4.Visible = False
    End Sub

    Private Sub RectangleShape43_Click(sender As Object, e As EventArgs) Handles RectangleShape43.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = True
    End Sub
    '==================================================================================================
    '==================================================================================================
    'PANEL 3
    Private Sub RectangleShape52_Click(sender As Object, e As EventArgs) Handles RectangleShape52.Click
        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False
    End Sub

    Private Sub RectangleShape49_Click(sender As Object, e As EventArgs) Handles RectangleShape49.Click
        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False
    End Sub

    Private Sub RectangleShape47_Click(sender As Object, e As EventArgs) Handles RectangleShape47.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True
    End Sub

    Private Sub RectangleShape45_Click(sender As Object, e As EventArgs) Handles RectangleShape45.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = True
    End Sub

    Private Sub RectangleShape14_Click(sender As Object, e As EventArgs) Handles RectangleShape14.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = True
    End Sub
    '==================================================================================================
    '==================================================================================================
    'PANEL 4
    Private Sub RectangleShape73_Click(sender As Object, e As EventArgs) Handles RectangleShape73.Click
        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
    End Sub

    Private Sub RectangleShape71_Click(sender As Object, e As EventArgs) Handles RectangleShape71.Click
        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False
        Panel4.Visible = False
    End Sub

    Private Sub RectangleShape69_Click(sender As Object, e As EventArgs) Handles RectangleShape69.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True
        Panel4.Visible = False
    End Sub

    Private Sub RectangleShape67_Click(sender As Object, e As EventArgs) Handles RectangleShape67.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = True
    End Sub

    Private Sub RectangleShape65_Click(sender As Object, e As EventArgs) Handles RectangleShape65.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = True
    End Sub
    '==================================================================================================
    '==================================================================================================
    'PANEL 5
    Private Sub RectangleShape94_Click(sender As Object, e As EventArgs) Handles RectangleShape94.Click
        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False
    End Sub

    Private Sub RectangleShape92_Click(sender As Object, e As EventArgs) Handles RectangleShape92.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False
    End Sub

    Private Sub RectangleShape90_Click(sender As Object, e As EventArgs) Handles RectangleShape90.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True
        Panel4.Visible = False
        Panel5.Visible = False
    End Sub

    Private Sub RectangleShape88_Click(sender As Object, e As EventArgs) Handles RectangleShape88.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = True
        Panel5.Visible = False
    End Sub

    Private Sub RectangleShape86_Click(sender As Object, e As EventArgs) Handles RectangleShape86.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = True
    End Sub

    Private Sub RectangleShape106_Click(sender As Object, e As EventArgs) Handles RectangleShape106.Click
        Me.Close()
    End Sub

    Private Sub RectangleShape107_Click(sender As Object, e As EventArgs) Handles RectangleShape107.Click
        Me.Close()
    End Sub

    Private Sub RectangleShape108_Click(sender As Object, e As EventArgs) Handles RectangleShape108.Click
        Me.Close()
    End Sub

    Private Sub RectangleShape109_Click(sender As Object, e As MouseEventArgs) Handles RectangleShape109.MouseClick
        Me.Close()
    End Sub



    Private Sub RectangleShape110_Click(sender As Object, e As EventArgs) Handles RectangleShape110.Click
        Me.Close()
    End Sub

    Private Sub RectangleShape111_Click(sender As Object, e As EventArgs) Handles RectangleShape111.Click
        MessageBox.Show("𝔸𝔹ℝ𝔸𝕏𝔸𝕊/Version: 1.0.0/ICONS: https://icons8.com/")
        MessageBox.Show(text:=
  "┏━━━┳━━┓┏━━━┳━━━┳━┓┏━┳━━━┳━━━┓
    ┃┏━┓┃┏┓┃┃┏━┓┃┏━┓┣┓┗┛┏┫┏━┓┃┏━┓┃
    ┃┃╋┃┃┗┛┗┫┗━┛┃┃╋┃┃┗┓┏┛┃┃╋┃┃┗━━┓
    ┃┗━┛┃┏━┓┃┏┓┏┫┗━┛┃┏┛┗┓┃┗━┛┣━━┓┃
    ┃┏━┓┃┗━┛┃┃┃┗┫┏━┓┣┛┏┓┗┫┏━┓┃┗━┛┃
┗┛╋┗┻━━━┻┛┗━┻┛╋┗┻━┛┗━┻┛╋┗┻━━━┛
")
    End Sub



    '==================================================================================================
    '==================================================================================================






End Class
