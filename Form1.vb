Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.IO
Imports Microsoft.VisualBasic.Logging
Imports System.Windows.Forms.DataVisualization.Charting


Public Class Form1
    'create student constructor
    'student has name, gpa, class rank, major, and graduation year
    Dim candidates As New List(Of Candidate)
    Public Class Candidate
        Public Property name As String
        Public Property gpa As Double
        Public Property rank As Integer
        Public Property year As Integer
        Public Property major As String
        Public Property phone As String

    End Class

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data from file when the form is loaded
    End Sub
    Private Sub FileLoad()
        Try
            'clearing the whole listbox for new dataset
            Dim openFileDialog As New OpenFileDialog()
            'Set properties for the OpenFileDialog
            openFileDialog.Title = "Select Data File"
            'Making sure txt file is selected
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            openFileDialog.FilterIndex = 1
            openFileDialog.RestoreDirectory = True
            ' Show the OpenFileDialog and check if the user selected a file
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                'Read the selected file path
                Dim filePath As String = openFileDialog.FileName
                If File.Exists(filePath) Then
                    ' Read all lines from the file
                    Dim lines() As String = File.ReadAllLines(filePath)

                    'Skip the header if exists and checks if the data has the expected length
                    If lines.Length > 0 Then
                        lines = lines.Skip(1).ToArray()
                    End If

                    For Each line As String In lines
                        Dim data() As String = line.Split("\"c)

                        'Create a new Candidate object and add it to the candidates list
                        If data.Length = 6 Then
                            Dim candidate As New Candidate() With {
                           .name = data(0),
                            .gpa = (data(1)),
                            .rank = (data(2)),
                            .year = (data(3)),
                            .major = data(4),
                            .phone = data(5)
                                    }
                            candidates.Add(candidate)
                        End If

                    Next



                    For Each candidate As Candidate In candidates
                        'Adds all of the candidate names into the listbox all, representing each every name in file
                        lstboxAll.Items.Add(candidate.name)
                    Next
                    UpdateChart()
                Else
                    'Display an error message if the file is not found
                    MsgBox("Cannot find specified file", vbCritical, "Error")
                End If
            End If
        Catch ex As Exception
            'Handle exceptions, display an Error message, Or log the error
            MsgBox("An error occurred while loading the file. Please check the file format and try again.", vbExclamation, "Error")
        End Try
    End Sub

    Private Sub btnFile_Click(sender As Object, e As EventArgs) Handles btnFile.Click
        'clearing previous data
        candidates.Clear()
        lstboxAll.Items.Clear()
        ' Reload data from file when the "File" button is clicked
        FileLoad()
        'clearing data from previous
        lstboxPotential.Items.Clear()
        'calling chart to make sure that new file is represented
        UpdateChart()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        ' Filter candidates based on user input and display potential candidates
        Try
            'Error handling to sort out where incorrect inputs by user
            Dim GPA As Double = txtGPA.Text
            If Double.TryParse(txtGPA.Text, GPA) = False Then
                MessageBox.Show("Invalid GPA. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
            Dim Rank As Integer = txtRank.Text
            If Integer.TryParse(txtRank.Text, Rank) = False Then
                MessageBox.Show("Invalid Rank. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
            Dim Grad As Integer = txtGrad.Text
            If Integer.TryParse(txtGrad.Text, Grad) = False Then
                MessageBox.Show("Invalid Graduation Year. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
            Dim Major As String = txtMajor.Text
            If String.IsNullOrEmpty(Major) Then
                MessageBox.Show("Major cannot be empty. Please enter a major.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
            Dim potentialcandidates As List(Of Candidate) = candidates.Where(Function(x) x.gpa >= GPA AndAlso x.rank <= Rank AndAlso x.year <= Grad AndAlso x.major = Major).ToList

            ' Clear and populate the potential candidates list box

            lstboxPotential.Items.Clear()
            'Checking for if any of the textboxes are empty
            If txtGPA.Text IsNot Nothing And txtRank.Text IsNot Nothing And txtGrad.Text IsNot Nothing And txtMajor.Text IsNot Nothing Then
                For Each candidate As Candidate In potentialcandidates.Take(50)
                    lstboxPotential.Items.Add(candidate.name)
                Next
                MsgBox("Potential Candidates added to List", vbOKOnly, "Confirmed")
            Else
                ' Input validation if user hasn't entered all information
                MsgBox("You have left one of the options blank, please try again", vbCritical, "error")

            End If
        Catch ex As Exception
            MsgBox("Invalid input, please try again", vbCritical, "Error")
        End Try
    End Sub

    Private Sub btnViewInfo_Click(sender As Object, e As EventArgs) Handles btnViewInfo.Click
        Try
            ' Display detailed information for the selected potential candidate
            Dim selectedcandidatename As String = lstboxPotential.SelectedItem
            Dim selectedcandidate As Candidate = candidates.FirstOrDefault(Function(x) x.name = selectedcandidatename)
            'Error handling if no candidate is chosen
            'Shows the user with a messagebox the candidate class association
            If selectedcandidatename IsNot Nothing Then
                Dim info As String = "Candidate: " & selectedcandidatename & vbCrLf & "GPA: " & selectedcandidate.gpa & vbCrLf &
                    "Class Rank: " & selectedcandidate.rank & vbCrLf & "Graduation Year : " & selectedcandidate.year & vbCrLf &
                    "Major: " & selectedcandidate.major & vbCrLf & "Phone Number: " & selectedcandidate.phone
                MessageBox.Show(info, "Candiate Info")
            Else
                MsgBox("Please select a candidates from the potential candidates list")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSendInterview_Click(sender As Object, e As EventArgs) Handles btnSendInterview.Click

        Try
            'Check if a candidate is selected in the potential candidates listbox
            Dim selectedCandidateName As String = lstboxPotential.SelectedItem
            Dim selectedcandidate As Candidate = candidates.FirstOrDefault(Function(x) x.name = selectedCandidateName)
            If selectedCandidateName IsNot Nothing Then
                'Check if candidate is already in the interviewee 
                If Not lstboxInterviewees.Items.Contains(selectedCandidateName & " " & selectedcandidate.phone) Then
                    'Ask user for confirmation
                    Dim confirmationResult As DialogResult = MessageBox.Show("Do you want to send this candidate to the Interviewees list?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    ' If the user confirms, add the candidate to the Interviewees listbox and their phone number is displayed
                    If confirmationResult = DialogResult.Yes Then
                        lstboxInterviewees.Items.Add(selectedCandidateName & " " & selectedcandidate.phone)
                        MsgBox("Candidate sent to Interviewees list", vbOKOnly, "Confirmed")
                    End If
                Else
                    'User was already in interviewee list box
                    MsgBox("This candidate is already in the Interviewees list", vbExclamation, "Error")
                End If
            Else
                'Inform the user to select a candidate first
                MsgBox("Please select a candidate from the potential candidates list", vbExclamation, "Error")
            End If

        Catch ex As Exception
            'Handle exceptions 
            MsgBox("An error occurred.", vbCritical, "Error")
        End Try
    End Sub

    Private Sub UpdateChart()
        'clearing existing data
        Chart1.Series.Clear()
        Chart1.ChartAreas.Clear()

        Dim chartArea As New ChartArea("MainChartArea")
        Chart1.ChartAreas.Add(chartArea)
        Dim seriesgpa As New Series("Average GPA")
        seriesgpa.ChartType = SeriesChartType.Column
        Dim avgGPAs = candidates.GroupBy(Function(candidate) candidate.major).Select(Function(x) New With {
            .Major = x.Key,
            .AvgGPA = x.Average(Function(candidate) candidate.gpa)
        })
        'adding data to chart
        For Each gpa In avgGPAs
            seriesgpa.Points.AddXY(gpa.Major, gpa.AvgGPA)
        Next
        Chart1.Series.Add(seriesgpa)
    End Sub


End Class
