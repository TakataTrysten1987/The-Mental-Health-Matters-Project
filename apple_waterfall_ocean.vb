Public Class MentalHealthMatters
    ' Declare global variables
    Dim userPrompt As String
    Dim userAnswer As String
    Dim userName As String
    Dim userAge As Integer
    Dim userGender As String
    Dim userMentalHealthHistory As String
    Dim userMentalHealthSupport As String
    
    'Create method to gather user information
    Public Sub GatherUserInfo()
        userPrompt = "Please enter your name:"
        userName = InputBox(userPrompt, "Mental Health Matter Project Survey")
        userPrompt = "Please enter your age:"
        userAge = InputBox(userPrompt, "Mental Health Matter Project Survey")
        userPrompt = "Please enter your gender:"
        userGender = InputBox(userPrompt, "Mental Health Matter Project Survey")
    End Sub
    
    'Create method to query user about mental health history
    Public Sub QueryMentalHealthHistory()
        userPrompt = "Do you have any mental health history? Please enter yes or no:"
        userAnswer = InputBox(userPrompt, "Mental Health Matter Project Survey")
        If userAnswer = "yes" Then
            userPrompt = "Please enter a brief description of your mental health history:"
            userMentalHealthHistory = InputBox(userPrompt, "Mental Health Matter Project Survey")
        End If
    End Sub
    
    'Create method to query user about mental health support
    Public Sub QueryMentalHealthSupport()
        userPrompt = "Do you have access to mental health care? Please enter yes or no:"
        userAnswer = InputBox(userPrompt, "Mental Health Matter Project Survey")
        If userAnswer = "yes" Then
            userPrompt = "Please enter a brief description of the mental health care you have access to:"
            userMentalHealthSupport = InputBox(userPrompt, "Mental Health Matter Project Survey")
        End If
    End Sub
    
    'Create method to display user information
    Public Sub DisplayUserInfo()
        MsgBox("Name: " & userName & vbCrLf & "Age: " & userAge & vbCrLf & "Gender: " & userGender & vbCrLf & "Mental Health History: " & userMentalHealthHistory & vbCrLf & "Mental Health Support: " & userMentalHealthSupport)
    End Sub
    
    'Create Main function
    Public Sub Main()
        GatherUserInfo()
        QueryMentalHealthHistory()
        QueryMentalHealthSupport()
        DisplayUserInfo()
    End Sub
End Class