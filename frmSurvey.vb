
Option Strict On
'*********************************************
' Neina Cichon
' 2020-07-05
' IT 102-401  Programming 2
' Assignment 7 - Household Income Survey
'*********************************************


Public Class frmHouseholdIncome

    'Declare Class Variables
    Dim strOhio() As String = {"Hamilton", "Butler", "Clermont", "Warren"}
    Dim strKentucky() As String = {"Campbell", "Boone", "Kenton"}
    Dim intOhioCount(3) As Integer
    Dim intKentuckyCount(2) As Integer
    Dim dblIncomeOhio(3) As Double
    Dim dblIncomeKentucky(2) As Double
    Dim dblAveragesOH(3) As Double
    Dim dblAveragesKY(2) As Double


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the program
        Close()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        'Declare Variables
        Dim dblIncomeInput As Double

        'Set backcolors back to white in case of error
        cboCountyState.BackColor = Color.White
        txtYearlyIncome.BackColor = Color.White

        If ValidateInput(cboCountyState, dblIncomeInput) = True Then
            dblIncomeInput = CDbl(txtYearlyIncome.Text)
            GetCountSort(cboCountyState)
            GetIncomeSort(cboCountyState, dblIncomeInput)
            GetAverageSort()

            'Reset Form after Submit click
            cboCountyState.SelectedIndex = -1
            txtYearlyIncome.Clear()
        End If

    End Sub


    Function ValidateInput(ByRef County As ComboBox, ByRef Income As Double) As Boolean

        'Validate all input
        If ValidateCounty(County) = True Then
            If ValidateIncome(Income) = True Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If

    End Function

    Function ValidateCounty(ByRef County As ComboBox) As Boolean

        'Checking to make sure County has been selected
        If cboCountyState.SelectedIndex = -1 Then
            MessageBox.Show("Please select County.")
            cboCountyState.BackColor = Color.Yellow   'Set backcolor to yellow
            cboCountyState.Focus()  'set focus back to errored cell for user
            Return False
        Else
            Return True
        End If

    End Function

    'Create Function to Validate Income
    Function ValidateIncome(ByRef Income As Double) As Boolean

        'Check Income to make sure it is Numeric
        If IsNumeric(txtYearlyIncome.Text) Then
            Income = CDbl(txtYearlyIncome.Text)

            'Validate that Income is not negative
            If Income >= 0 Then
                Return True
            Else
                'Display error if negative
                MessageBox.Show("Income can not be negative.")
                txtYearlyIncome.BackColor = Color.Yellow     'Set color to yellow
                txtYearlyIncome.Focus()    'set focus back to errored cell for user
                Return False
            End If
        Else
            'Display Error if Not Numeric
            MessageBox.Show("Please enter Income")
            txtYearlyIncome.BackColor = Color.Yellow     'Set color to yellow
            txtYearlyIncome.Focus()    'set focus back to errored cell for user
            Return False
        End If

    End Function

    'Sub to Sort inputs by State and get count and put in array
    Private Sub GetCountSort(ByVal CountyState As ComboBox)

        'Declare Variables
        Dim i As Integer
        Dim County As String

        If cboCountyState.Text.EndsWith("OH") Then
            County = cboCountyState.Text.Replace(", OH", "")
            i = strOhio.ToList.IndexOf(County)
            intOhioCount(i) += 1

        ElseIf cboCountyState.Text.EndsWith("KY") Then
            County = cboCountyState.Text.Replace(", KY", "")
            i = strKentucky.ToList.IndexOf(County)
            intKentuckyCount(i) += 1
        End If

    End Sub

    'Get the averages by county and put in Array
    Private Sub GetAverageSort()

        'Declare Variables
        Dim i As Integer
        Dim ik As Integer

        'Get Ohio Averages
        Try
            For Each average As Double In dblAveragesOH
                If (intOhioCount(i) <= 0) Then 'Make sure not dividing by 0
                    dblAveragesOH(i) = 0
                Else
                    dblAveragesOH(i) = CDbl(dblIncomeOhio(i) / intOhioCount(i))

                End If
                i += 1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'Get Kentucky Averages
        Try
            For Each average As Double In dblAveragesKY
                If (intKentuckyCount(ik) <= 0) Then 'Make sure not dividing by 0
                    dblAveragesKY(ik) = 0
                Else
                    dblAveragesKY(ik) = CDbl(dblIncomeKentucky(ik) / intKentuckyCount(ik))

                End If
                ik += 1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    'Sort By state and put into array by county
    Private Sub GetIncomeSort(ByVal CountyState As ComboBox, ByVal Income As Double)

        'Declare Variables
        Dim intIndex As Integer

        If cboCountyState.Text.EndsWith("OH") Then
            intIndex = strOhio.ToList.IndexOf(cboCountyState.Text.Replace(", OH", ""))
            dblIncomeOhio(intIndex) += Income
        Else
            intIndex = strKentucky.ToList.IndexOf(cboCountyState.Text.Replace(", KY", ""))
            dblIncomeKentucky(intIndex) += Income
        End If

    End Sub

    Private Sub btnTotalSurveyed_Click(sender As Object, e As EventArgs) Handles btnTotalSurveyed.Click

        'Display Counts of surveyed households in MsgBox
        MessageBox.Show("Ohio: " & vbTab & vbTab & vbTab & intOhioCount.Sum & vbNewLine & vbTab &
             "Hamilton: " & vbTab & intOhioCount(0) & vbNewLine & vbTab &
            "Butler: " & vbTab & vbTab & intOhioCount(1) & vbNewLine & vbTab &
            "Clermont: " & vbTab & intOhioCount(2) & vbNewLine & vbTab &
            "Warren: " & vbTab & vbTab & intOhioCount(3) & vbNewLine &
            "Kentucky: " & vbTab & vbTab & intKentuckyCount.Sum & vbNewLine & vbTab &
            "Boone: " & vbTab & vbTab & intKentuckyCount(0) & vbNewLine & vbTab &
            "Campbell: " & vbTab & intKentuckyCount(1) & vbNewLine & vbTab &
            "Kenton: " & vbTab & vbTab & intKentuckyCount(2), "Number of Households Surveyed")

    End Sub

    Private Sub btnAverageIncome_Click(sender As Object, e As EventArgs) Handles btnAverageIncome.Click

        'Declare Variables
        Dim dblAverageOhio As Double
        Dim dblAverageKY As Double
        Dim incomeAllOhio = Aggregate income In dblIncomeOhio Into Sum()
        Dim countAllOhio = Aggregate count In intOhioCount Into Sum()

        'Get state averages
        If intOhioCount.Sum > 0 Then
            dblAverageOhio = CDbl(incomeAllOhio / countAllOhio)
        End If
        If intKentuckyCount.Sum > 0 Then
            dblAverageKY = CDbl(dblIncomeKentucky.Sum / intKentuckyCount.Sum)
        End If

        'Display messagebox with Totals
        MessageBox.Show("Ohio: " & vbTab & vbTab & vbTab & FormatCurrency(dblAverageOhio) & vbNewLine & vbTab &
         "Hamilton: " & vbTab & FormatCurrency(dblAveragesOH(0)) & vbNewLine & vbTab &
         "Butler: " & vbTab & vbTab & FormatCurrency(dblAveragesOH(1)) & vbNewLine & vbTab &
         "Clermont: " & vbTab & FormatCurrency(dblAveragesOH(2)) & vbNewLine & vbTab &
         "Warren: " & vbTab & vbTab & FormatCurrency(dblAveragesOH(3)) & vbNewLine &
         "Kentucky: " & vbTab & vbTab & FormatCurrency(dblAverageKY) & vbNewLine & vbTab &
         "Boone: " & vbTab & vbTab & FormatCurrency(dblAveragesKY(0)) & vbNewLine & vbTab &
         "Campbell: " & vbTab & FormatCurrency(dblAveragesKY(1)) & vbNewLine & vbTab &
         "Kenton: " & vbTab & vbTab & FormatCurrency(dblAveragesKY(2)), "Average Household Income")

    End Sub
End Class
