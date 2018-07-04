' Author:       Michael Jennings
' Professor:    Steve Carver
' Assignment:   Ex 3.16: Body Mass Index Calculator 
' Description:  This assignment is suppose to help
'               use get comfortable with tools, buttons.
' Date created: 8/25/10
Public Class frmMassCalc

    Private Sub frmMassCalc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtHealthScale.Text = "BMI VALUES" & vbCrLf & "Underweight: less than 18.5" & vbCrLf & "Normal:      between(18.5 and 24.9)" & vbCrLf & "OverWeight:  between(25 And 29.9)" & vbCrLf & "Obese:       30 or greater"
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        TxtMassIndex.Text = Val(txtWeighNPounds.Text) * "703" / (Val(txtHeightNInches.Text) * Val(txtHeightNInches.Text))
    End Sub
End Class
