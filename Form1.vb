Imports System.Threading

Public Class Form1
    Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles btn1.Click
        ' 1. Get the selected program (ComboBox)
        Dim program As String = If(cb1.SelectedItem IsNot Nothing, cb1.SelectedItem.ToString(), "Not Selected")

        ' 2. Collect hobbies from CheckBoxes
        Dim hobbiesList As New List(Of String)
        If ck1.Checked Then hobbiesList.Add("Reading")
        If ck2.Checked Then hobbiesList.Add("Sports")
        If ck3.Checked Then hobbiesList.Add("Music")

        ' Combine all selected hobbies into one string
        Dim hobbies As String = If(hobbiesList.Count > 0, String.Join(", ", hobbiesList), "None")

        ' 3. Get the selected gender (RadioButtons inside GroupBox)
        Dim sex As String = "Not Selected"
        If rb1.Checked Then
            sex = "Male"
        ElseIf rb2.Checked Then
            sex = "Female"
        End If

        ' 4. Show results in Labels
        lb1.Text = "Course: " & program
        lb2.Text = "Hobbies: " & hobbies
        lb3.Text = "Gender: " & sex
    End Sub
End Class