Imports System.IO
Imports System.Text.RegularExpressions

Public Class VetsRForm

    Dim fmtStr As String = "{0, -30}{1, 31}{2,40}"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnReceipt_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click
        dReceipt.Clear()
        dReceipt.AppendText("Receipt" + vbNewLine)
        dReceipt.AppendText("============================================" + vbNewLine)

        Dim txtFirst, txtMiddle, txtLast, txtPhone, txtPet, txtSpecies As String
        Dim officeVisit, xRay, specimenExam, rabies, kennelCough, antibaV, weight, factor, tax, total, discount, totalWithDiscountTax, totalWithTax As Double
        total = 0
        tax = 0.06

        '1st name 
        txtFirst = txtFirstName.Text
        'If (Regex.IsMatch(txtFirst, "[A-Z][a-z]*") = False) Then
        'MessageBox.Show("Invalid First Name")
        'txtFirst = ""
        'Else
        dReceipt.AppendText(String.Format(fmtStr, "First Name", CStr(txtFirst), vbNewLine))
        'End If

        'middle name
        txtMiddle = txtMiddleName.Text
        If (Regex.IsMatch(txtMiddle, "[A-Za-z]*(\.)[A-Za-z]*") = False) Then
            MessageBox.Show("Invalid Middle Name")
            txtMiddle = ""
        Else
            dReceipt.AppendText(String.Format(fmtStr, "Middle Name", CStr(txtMiddle), vbNewLine))
        End If

        'last name
        txtLast = txtLastName.Text
        dReceipt.AppendText(String.Format(fmtStr, "Last Name", CStr(txtLast), vbNewLine))

        'phone auto validates on form 
        txtPhone = txtPhoneNumber.Text
        dReceipt.AppendText(String.Format(fmtStr, "Phone Number", txtPhone, vbNewLine))

        'pet name
        txtPet = txtPetName.Text
        dReceipt.AppendText(String.Format(fmtStr, "Pet Name", txtPet, vbNewLine))

        'species name
        txtSpecies = txtSpeciesName.Text
        dReceipt.AppendText(String.Format(fmtStr, "Pet Species", txtSpecies, vbNewLine))

        If ckOfficeVisit.Checked Then
            officeVisit = 25
            dReceipt.AppendText(String.Format(fmtStr, "Ofiice visit", "$25.00", vbNewLine))
            total = total + officeVisit
        End If
        If ckXray.Checked Then
            xRay = 15
            dReceipt.AppendText(String.Format(fmtStr, "X-Ray", "$15.00", vbNewLine))
            total = total + xRay
        End If
        If ckSpecimenExam.Checked Then
            specimenExam = 12.5
            dReceipt.AppendText(String.Format(fmtStr, "Specimen Examination", "$12.50", vbNewLine))
            total = total + specimenExam
        End If
        If ckRabies.Checked Then
            rabies = 8
            dReceipt.AppendText(String.Format(fmtStr, "Rabies", "$8.00", vbNewLine))
            total = total + rabies
        End If
        If ckKennelCough.Checked Then
            kennelCough = 6
            dReceipt.AppendText(String.Format(fmtStr, "Kennel Cough", "$6.00", vbNewLine))
            total = total + kennelCough
        End If

        If ckAntibaV.Checked Then
            weight = txtWeight.Text
            If cmbPetSize.SelectedIndex = 0 Then
                factor = 10.0
            ElseIf cmbPetSize.SelectedIndex = 1 Then
                factor = 50.0
            ElseIf cmbPetSize.SelectedIndex = 2 Then
                factor = 100.0
            End If
            antibaV = (5 * (weight / factor))
            dReceipt.AppendText(String.Format(fmtStr, "Antiba-V", "$", CStr(antibaV), vbNewLine))
            total = total + antibaV
        End If

        If (ckMultiPet.Checked Or ckLowIncome.Checked) Then
            discount = txtDiscount.Text
            If (discount >= 0 Or discount < total) Then
                totalWithTax = (total * tax) + total
                totalWithDiscountTax = totalWithTax - discount
                dReceipt.AppendText(String.Format(fmtStr, "tax Added", CStr(total * tax), vbNewLine))
                dReceipt.AppendText(String.Format(fmtStr, "discount applied", CStr(discount), vbNewLine))
                dReceipt.AppendText(String.Format(fmtStr, "total", CStr(total), vbNewLine))
                dReceipt.AppendText(String.Format(fmtStr, "total with tax & discount", CStr(totalWithDiscountTax), vbNewLine))
            Else
                MessageBox.Show("Please enter a valid discount")
            End If
        Else
            totalWithTax = (total * tax) + total
            dReceipt.AppendText(String.Format(fmtStr, "tax Added", CStr(total * tax), vbNewLine))
            dReceipt.AppendText(String.Format(fmtStr, "discount", "NA", vbNewLine))
            dReceipt.AppendText(String.Format(fmtStr, "total", CStr(total), vbNewLine))
            dReceipt.AppendText(String.Format(fmtStr, "total with tax", CStr(totalWithTax), vbNewLine))
        End If
        dReceipt.AppendText("============================================" + vbNewLine)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dReceipt.Clear()
        dTotal.Clear()
        dFinalTotal.Clear()
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        dTotal.Clear()
        Dim officeVisit, xRay, specimenExam, rabies, kennelCough, antibaV, weight, factor, tax, total, discount, totalWithDiscountTax, totalWithTax As Double
        total = 0
        tax = 0.06

        If ckOfficeVisit.Checked Then
            officeVisit = 25
            total = total + officeVisit
        End If
        If ckXray.Checked Then
            xRay = 15
            total = total + xRay
        End If
        If ckSpecimenExam.Checked Then
            specimenExam = 12.5
            total = total + specimenExam
        End If
        If ckRabies.Checked Then
            rabies = 8
            total = total + rabies
        End If
        If ckKennelCough.Checked Then
            kennelCough = 6
            total = total + kennelCough
        End If
        If ckAntibaV.Checked Then
            weight = txtWeight.Text
            If cmbPetSize.SelectedIndex = 0 Then
                factor = 10.0
            ElseIf cmbPetSize.SelectedIndex = 1 Then
                factor = 50.0
            ElseIf cmbPetSize.SelectedIndex = 2 Then
                factor = 100.0
            End If
            antibaV = (5 * (weight / factor))

            total = total + antibaV
        End If
        dTotal.AppendText(CStr(total))

    End Sub

    Private Sub btnFinalTotal_Click(sender As Object, e As EventArgs) Handles btnFinalTotal.Click
        dFinalTotal.Clear()
        Dim officeVisit, xRay, specimenExam, rabies, kennelCough, antibaV, weight, factor, tax, total, discount, totalWithDiscountTax, totalWithTax As Double
        total = 0
        tax = 0.06

        If ckOfficeVisit.Checked Then
            officeVisit = 25
            total = total + officeVisit
        End If
        If ckXray.Checked Then
            xRay = 15
            total = total + xRay
        End If
        If ckSpecimenExam.Checked Then
            specimenExam = 12.5
            total = total + specimenExam
        End If
        If ckRabies.Checked Then
            rabies = 8
            total = total + rabies
        End If
        If ckKennelCough.Checked Then
            kennelCough = 6
            total = total + kennelCough
        End If

        If ckAntibaV.Checked Then
            weight = txtWeight.Text
            If cmbPetSize.SelectedIndex = 0 Then
                factor = 10.0
            ElseIf cmbPetSize.SelectedIndex = 1 Then
                factor = 50.0
            ElseIf cmbPetSize.SelectedIndex = 2 Then
                factor = 100.0
            End If
            antibaV = (5 * (weight / factor))

            total = total + antibaV
        End If

        If (ckMultiPet.Checked Or ckLowIncome.Checked) Then
            discount = txtDiscount.Text
            If (discount >= 0 Or discount < total) Then
                totalWithTax = (total * tax) + total
                totalWithDiscountTax = totalWithTax - discount

                dFinalTotal.AppendText(CStr(totalWithDiscountTax))

            Else
                MessageBox.Show("Please enter a valid discount")
            End If
        Else
            totalWithTax = (total * tax) + total

            dFinalTotal.AppendText(CStr(totalWithTax))

        End If
    End Sub
End Class
