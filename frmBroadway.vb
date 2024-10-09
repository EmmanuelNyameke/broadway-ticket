' Program Name: Broadway Tickets
' Date: October 5, 2024
' Author: K Bola
' Purpose: This application helps users to determine the total cost of broadway ticket group discount after entering the group size 
Public Class frmBroadway
    Private Sub btnCalcCost_Click(sender As Object, e As EventArgs) Handles btnCalcCost.Click
        Const _cdecPricePerGroup1 As Decimal = 249
        Const _cdecPricePerGroup9 As Decimal = 219
        Const _cdecPricePerGroup13 As Decimal = 199
        Const _cdecPricePerGroup25 As Decimal = 169
        Dim intGroupSize As Integer
        Dim decTotalCost As Decimal
        If (IsNumeric(txtGroupSize.Text)) Then
            intGroupSize = Convert.ToInt32(txtGroupSize.Text)
            Select Case intGroupSize
                Case 1 To 8 And radGroup1.Checked
                    decTotalCost = intGroupSize * _cdecPricePerGroup1
                    lblCost.Text = decTotalCost.ToString("C")
                    MsgBox("NB: Cost Per Person is " & _cdecPricePerGroup1.ToString("C"), MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Note")
                Case 9 To 12 And radGroup9.Checked
                    decTotalCost = intGroupSize * _cdecPricePerGroup9
                    lblCost.Text = decTotalCost.ToString("C")
                    MsgBox("NB: Cost Per Person is " & _cdecPricePerGroup9.ToString("C"), MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Note")
                Case 13 To 24 And radGroup13.Checked
                    decTotalCost = intGroupSize * _cdecPricePerGroup13
                    lblCost.Text = decTotalCost.ToString("C")
                    MsgBox("NB: Cost Per Person is " & _cdecPricePerGroup13.ToString("C"), MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Note")
                Case 25 To 99 And radGroup25.Checked
                    decTotalCost = intGroupSize * _cdecPricePerGroup25
                    lblCost.Text = decTotalCost.ToString("C")
                    MsgBox("NB: Cost Per Person is " & _cdecPricePerGroup25.ToString("C"), MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Note")
                Case Else
                    MsgBox("Enter number according to the group size above" & vbCrLf & "and make sure to check the radio button that" & vbCrLf & "contains the range of your number.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Invalid Entry")
                    txtGroupSize.Clear()
                    txtGroupSize.Focus()
            End Select
        Else
            MsgBox("Enter a number", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Invalid Entry")
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGroupSize.Clear()
        txtGroupSize.Focus()
        lblCost.Text = ""
        radGroup1.Checked = False
        radGroup9.Checked = False
        radGroup13.Checked = False
        radGroup25.Checked = False
    End Sub
    Private Sub frmBroadway_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCost.Text = ""
    End Sub
End Class
