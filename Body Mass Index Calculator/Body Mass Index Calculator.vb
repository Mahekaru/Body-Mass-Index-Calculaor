' Author:       Michael Jennings
' Professor:    Steve Carver
' Assignment:   Ex 3.16: Body Mass Index Calculator 
' Description:  This calculator takes your weight and height from user and calculates a number that represents 
'               your body mass, if your a normal weight for your height or not.
' Date created: 9/01/10
Public Class frmMassCalc
    Private Sub frmMassCalc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'This is the box at the very bottom left of the program, it literally types in the data shown "& vbCrLf &" this 
        'starts a new line in the textbox.
        txtHealthScale.Text = "BMI VALUES" & vbCrLf & "Underweight: less than 18.5" & vbCrLf & "Normal:      between(18.5 and 24.9)" & vbCrLf & "OverWeight:  between(25 And 29.9)" & vbCrLf & "Obese:       30 or greater"
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'these check if the textboxes are blank or if they contain A-Z charecters
        If txtHeightNInches.Text = "" Then
            MessageBox.Show("Height cannot be blank")
        ElseIf txtWeighNPounds.Text = "" Then
            MessageBox.Show("weight cannot be blank")
        ElseIf Not IsNumeric(txtHeightNInches.Text) Then
            MessageBox.Show("Height must be numeric. Example 80")
        ElseIf Not IsNumeric(txtWeighNPounds.Text) Then
            MessageBox.Show("Pounds must be numeric. Example 130")
        Else
            TxtMassIndex.Text = Val(txtWeighNPounds.Text) * "703" / (Val(txtHeightNInches.Text) * Val(txtHeightNInches.Text))
            End If
    End Sub
End Class
