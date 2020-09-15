<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VetsRForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.PetOwnerInfo = New System.Windows.Forms.Label()
        Me.PetInfo = New System.Windows.Forms.Label()
        Me.firstName = New System.Windows.Forms.Label()
        Me.middleName = New System.Windows.Forms.Label()
        Me.lastName = New System.Windows.Forms.Label()
        Me.petName = New System.Windows.Forms.Label()
        Me.petSpecies = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.operation = New System.Windows.Forms.Label()
        Me.ckOfficeVisit = New System.Windows.Forms.CheckBox()
        Me.ckXray = New System.Windows.Forms.CheckBox()
        Me.ckSpecimenExam = New System.Windows.Forms.CheckBox()
        Me.vaccines = New System.Windows.Forms.Label()
        Me.ckRabies = New System.Windows.Forms.CheckBox()
        Me.ckKennelCough = New System.Windows.Forms.CheckBox()
        Me.ckAntibaV = New System.Windows.Forms.CheckBox()
        Me.petSize = New System.Windows.Forms.Label()
        Me.phone = New System.Windows.Forms.Label()
        Me.dTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ckMultiPet = New System.Windows.Forms.CheckBox()
        Me.ckLowIncome = New System.Windows.Forms.CheckBox()
        Me.discount = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.btnReceipt = New System.Windows.Forms.Button()
        Me.dReceipt = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.btnFinalTotal = New System.Windows.Forms.Button()
        Me.dFinalTotal = New System.Windows.Forms.TextBox()
        Me.cmbPetSize = New System.Windows.Forms.ComboBox()
        Me.weight = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.lblantibanotice = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.MaskedTextBox()
        Me.txtLastName = New System.Windows.Forms.MaskedTextBox()
        Me.txtPetName = New System.Windows.Forms.MaskedTextBox()
        Me.txtSpeciesName = New System.Windows.Forms.MaskedTextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTotal
        '
        Me.btnTotal.BackColor = System.Drawing.Color.LightBlue
        Me.btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTotal.Location = New System.Drawing.Point(426, 40)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(160, 41)
        Me.btnTotal.TabIndex = 14
        Me.btnTotal.Text = "Get Total"
        Me.btnTotal.UseVisualStyleBackColor = False
        '
        'PetOwnerInfo
        '
        Me.PetOwnerInfo.AutoSize = True
        Me.PetOwnerInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PetOwnerInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PetOwnerInfo.Location = New System.Drawing.Point(20, 21)
        Me.PetOwnerInfo.Name = "PetOwnerInfo"
        Me.PetOwnerInfo.Size = New System.Drawing.Size(155, 25)
        Me.PetOwnerInfo.TabIndex = 21
        Me.PetOwnerInfo.Text = "Pet Owner Info"
        '
        'PetInfo
        '
        Me.PetInfo.AutoSize = True
        Me.PetInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PetInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PetInfo.Location = New System.Drawing.Point(22, 179)
        Me.PetInfo.Name = "PetInfo"
        Me.PetInfo.Size = New System.Drawing.Size(86, 25)
        Me.PetInfo.TabIndex = 24
        Me.PetInfo.Text = "Pet Info"
        '
        'firstName
        '
        Me.firstName.AutoSize = True
        Me.firstName.Location = New System.Drawing.Point(24, 62)
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(76, 17)
        Me.firstName.TabIndex = 22
        Me.firstName.Text = "First Name"
        '
        'middleName
        '
        Me.middleName.AutoSize = True
        Me.middleName.Location = New System.Drawing.Point(22, 93)
        Me.middleName.Name = "middleName"
        Me.middleName.Size = New System.Drawing.Size(90, 17)
        Me.middleName.TabIndex = 21
        Me.middleName.Text = "Middle Name"
        '
        'lastName
        '
        Me.lastName.AutoSize = True
        Me.lastName.Location = New System.Drawing.Point(22, 122)
        Me.lastName.Name = "lastName"
        Me.lastName.Size = New System.Drawing.Size(76, 17)
        Me.lastName.TabIndex = 22
        Me.lastName.Text = "Last Name"
        '
        'petName
        '
        Me.petName.AutoSize = True
        Me.petName.Location = New System.Drawing.Point(24, 216)
        Me.petName.Name = "petName"
        Me.petName.Size = New System.Drawing.Size(70, 17)
        Me.petName.TabIndex = 25
        Me.petName.Text = "Pet Name"
        '
        'petSpecies
        '
        Me.petSpecies.AutoSize = True
        Me.petSpecies.Location = New System.Drawing.Point(24, 243)
        Me.petSpecies.Name = "petSpecies"
        Me.petSpecies.Size = New System.Drawing.Size(83, 17)
        Me.petSpecies.TabIndex = 26
        Me.petSpecies.Text = "Pet Species"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(137, 90)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(139, 22)
        Me.txtMiddleName.TabIndex = 1
        '
        'operation
        '
        Me.operation.AutoSize = True
        Me.operation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.operation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.operation.Location = New System.Drawing.Point(19, 276)
        Me.operation.Name = "operation"
        Me.operation.Size = New System.Drawing.Size(118, 25)
        Me.operation.TabIndex = 27
        Me.operation.Text = "Operations"
        '
        'ckOfficeVisit
        '
        Me.ckOfficeVisit.AutoSize = True
        Me.ckOfficeVisit.Location = New System.Drawing.Point(24, 315)
        Me.ckOfficeVisit.Name = "ckOfficeVisit"
        Me.ckOfficeVisit.Size = New System.Drawing.Size(145, 21)
        Me.ckOfficeVisit.TabIndex = 6
        Me.ckOfficeVisit.Text = "Office Visit $25.00"
        Me.ckOfficeVisit.UseVisualStyleBackColor = True
        '
        'ckXray
        '
        Me.ckXray.AutoSize = True
        Me.ckXray.Location = New System.Drawing.Point(24, 342)
        Me.ckXray.Name = "ckXray"
        Me.ckXray.Size = New System.Drawing.Size(117, 21)
        Me.ckXray.TabIndex = 7
        Me.ckXray.Text = "X-Ray $15.00"
        Me.ckXray.UseVisualStyleBackColor = True
        '
        'ckSpecimenExam
        '
        Me.ckSpecimenExam.AutoSize = True
        Me.ckSpecimenExam.Location = New System.Drawing.Point(24, 369)
        Me.ckSpecimenExam.Name = "ckSpecimenExam"
        Me.ckSpecimenExam.Size = New System.Drawing.Size(220, 21)
        Me.ckSpecimenExam.TabIndex = 8
        Me.ckSpecimenExam.Text = "Specimen Examination $12.50"
        Me.ckSpecimenExam.UseVisualStyleBackColor = True
        '
        'vaccines
        '
        Me.vaccines.AutoSize = True
        Me.vaccines.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vaccines.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.vaccines.Location = New System.Drawing.Point(22, 403)
        Me.vaccines.Name = "vaccines"
        Me.vaccines.Size = New System.Drawing.Size(101, 25)
        Me.vaccines.TabIndex = 28
        Me.vaccines.Text = "Vaccines"
        '
        'ckRabies
        '
        Me.ckRabies.AutoSize = True
        Me.ckRabies.Location = New System.Drawing.Point(24, 431)
        Me.ckRabies.Name = "ckRabies"
        Me.ckRabies.Size = New System.Drawing.Size(114, 21)
        Me.ckRabies.TabIndex = 9
        Me.ckRabies.Text = "Rabies $8.00"
        Me.ckRabies.UseVisualStyleBackColor = True
        '
        'ckKennelCough
        '
        Me.ckKennelCough.AutoSize = True
        Me.ckKennelCough.Location = New System.Drawing.Point(24, 458)
        Me.ckKennelCough.Name = "ckKennelCough"
        Me.ckKennelCough.Size = New System.Drawing.Size(159, 21)
        Me.ckKennelCough.TabIndex = 10
        Me.ckKennelCough.Text = "Kennel Cough $6.00"
        Me.ckKennelCough.UseVisualStyleBackColor = True
        '
        'ckAntibaV
        '
        Me.ckAntibaV.AutoSize = True
        Me.ckAntibaV.Location = New System.Drawing.Point(24, 485)
        Me.ckAntibaV.Name = "ckAntibaV"
        Me.ckAntibaV.Size = New System.Drawing.Size(283, 21)
        Me.ckAntibaV.TabIndex = 11
        Me.ckAntibaV.Text = "Antiba-V (Antibadisesius Vaccine) $5.00"
        Me.ckAntibaV.UseVisualStyleBackColor = True
        '
        'petSize
        '
        Me.petSize.AutoSize = True
        Me.petSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.petSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.petSize.Location = New System.Drawing.Point(22, 626)
        Me.petSize.Name = "petSize"
        Me.petSize.Size = New System.Drawing.Size(93, 25)
        Me.petSize.TabIndex = 31
        Me.petSize.Text = "Pet Size"
        '
        'phone
        '
        Me.phone.AutoSize = True
        Me.phone.Location = New System.Drawing.Point(22, 152)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(103, 17)
        Me.phone.TabIndex = 23
        Me.phone.Text = "Phone Number"
        '
        'dTotal
        '
        Me.dTotal.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.dTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dTotal.Location = New System.Drawing.Point(619, 39)
        Me.dTotal.Multiline = True
        Me.dTotal.Name = "dTotal"
        Me.dTotal.ReadOnly = True
        Me.dTotal.Size = New System.Drawing.Size(264, 42)
        Me.dTotal.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(421, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Check All That Applies"
        '
        'ckMultiPet
        '
        Me.ckMultiPet.AutoSize = True
        Me.ckMultiPet.Location = New System.Drawing.Point(426, 122)
        Me.ckMultiPet.Name = "ckMultiPet"
        Me.ckMultiPet.Size = New System.Drawing.Size(110, 21)
        Me.ckMultiPet.TabIndex = 15
        Me.ckMultiPet.Text = "Multiple Pets"
        Me.ckMultiPet.UseVisualStyleBackColor = True
        '
        'ckLowIncome
        '
        Me.ckLowIncome.AutoSize = True
        Me.ckLowIncome.Location = New System.Drawing.Point(619, 122)
        Me.ckLowIncome.Name = "ckLowIncome"
        Me.ckLowIncome.Size = New System.Drawing.Size(104, 21)
        Me.ckLowIncome.TabIndex = 16
        Me.ckLowIncome.Text = "Low Income"
        Me.ckLowIncome.UseVisualStyleBackColor = True
        '
        'discount
        '
        Me.discount.AutoSize = True
        Me.discount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.discount.Location = New System.Drawing.Point(421, 149)
        Me.discount.Name = "discount"
        Me.discount.Size = New System.Drawing.Size(96, 25)
        Me.discount.TabIndex = 28
        Me.discount.Text = "Discount"
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(619, 153)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(264, 22)
        Me.txtDiscount.TabIndex = 17
        '
        'btnReceipt
        '
        Me.btnReceipt.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceipt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReceipt.Location = New System.Drawing.Point(426, 260)
        Me.btnReceipt.Name = "btnReceipt"
        Me.btnReceipt.Size = New System.Drawing.Size(228, 41)
        Me.btnReceipt.TabIndex = 19
        Me.btnReceipt.Text = "Show Receipt"
        Me.btnReceipt.UseVisualStyleBackColor = False
        '
        'dReceipt
        '
        Me.dReceipt.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.dReceipt.Location = New System.Drawing.Point(426, 315)
        Me.dReceipt.Multiline = True
        Me.dReceipt.Name = "dReceipt"
        Me.dReceipt.ReadOnly = True
        Me.dReceipt.Size = New System.Drawing.Size(457, 369)
        Me.dReceipt.TabIndex = 31
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(137, 149)
        Me.txtPhoneNumber.Mask = "(999) 000-0000"
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(139, 22)
        Me.txtPhoneNumber.TabIndex = 3
        '
        'btnFinalTotal
        '
        Me.btnFinalTotal.BackColor = System.Drawing.Color.LightBlue
        Me.btnFinalTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFinalTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFinalTotal.Location = New System.Drawing.Point(426, 201)
        Me.btnFinalTotal.Name = "btnFinalTotal"
        Me.btnFinalTotal.Size = New System.Drawing.Size(160, 41)
        Me.btnFinalTotal.TabIndex = 18
        Me.btnFinalTotal.Text = "Final Total "
        Me.btnFinalTotal.UseVisualStyleBackColor = False
        Me.btnFinalTotal.UseWaitCursor = True
        '
        'dFinalTotal
        '
        Me.dFinalTotal.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.dFinalTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dFinalTotal.Location = New System.Drawing.Point(619, 200)
        Me.dFinalTotal.Multiline = True
        Me.dFinalTotal.Name = "dFinalTotal"
        Me.dFinalTotal.ReadOnly = True
        Me.dFinalTotal.Size = New System.Drawing.Size(264, 42)
        Me.dFinalTotal.TabIndex = 33
        '
        'cmbPetSize
        '
        Me.cmbPetSize.FormattingEnabled = True
        Me.cmbPetSize.Items.AddRange(New Object() {"small (animal factor 10)", "medium (animal factor 50)", "large (animal factor 100)"})
        Me.cmbPetSize.Location = New System.Drawing.Point(27, 654)
        Me.cmbPetSize.Name = "cmbPetSize"
        Me.cmbPetSize.Size = New System.Drawing.Size(228, 24)
        Me.cmbPetSize.TabIndex = 13
        Me.cmbPetSize.Text = "(--please select--)"
        '
        'weight
        '
        Me.weight.AutoSize = True
        Me.weight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.weight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.weight.Location = New System.Drawing.Point(23, 573)
        Me.weight.Name = "weight"
        Me.weight.Size = New System.Drawing.Size(118, 25)
        Me.weight.TabIndex = 30
        Me.weight.Text = "Pet Weight"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(25, 601)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(230, 22)
        Me.txtWeight.TabIndex = 12
        '
        'lblantibanotice
        '
        Me.lblantibanotice.AutoSize = True
        Me.lblantibanotice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblantibanotice.ForeColor = System.Drawing.Color.Red
        Me.lblantibanotice.Location = New System.Drawing.Point(21, 523)
        Me.lblantibanotice.Name = "lblantibanotice"
        Me.lblantibanotice.Size = New System.Drawing.Size(302, 36)
        Me.lblantibanotice.TabIndex = 29
        Me.lblantibanotice.Text = "***Please Specify Pet Weight and Size " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     if you use Antiba-V Vaccine***"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(137, 59)
        Me.txtFirstName.Mask = "????????????"
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(139, 22)
        Me.txtFirstName.TabIndex = 0
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(137, 119)
        Me.txtLastName.Mask = "????????????"
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(139, 22)
        Me.txtLastName.TabIndex = 2
        '
        'txtPetName
        '
        Me.txtPetName.Location = New System.Drawing.Point(139, 213)
        Me.txtPetName.Mask = "????????????"
        Me.txtPetName.Name = "txtPetName"
        Me.txtPetName.Size = New System.Drawing.Size(139, 22)
        Me.txtPetName.TabIndex = 4
        '
        'txtSpeciesName
        '
        Me.txtSpeciesName.Location = New System.Drawing.Point(137, 240)
        Me.txtSpeciesName.Mask = "????????????"
        Me.txtSpeciesName.Name = "txtSpeciesName"
        Me.txtSpeciesName.Size = New System.Drawing.Size(141, 22)
        Me.txtSpeciesName.TabIndex = 5
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSalmon
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(660, 260)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(223, 41)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clear All"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'VetsRForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(909, 699)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtSpeciesName)
        Me.Controls.Add(Me.txtPetName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblantibanotice)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.weight)
        Me.Controls.Add(Me.cmbPetSize)
        Me.Controls.Add(Me.dFinalTotal)
        Me.Controls.Add(Me.btnFinalTotal)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.dReceipt)
        Me.Controls.Add(Me.btnReceipt)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.discount)
        Me.Controls.Add(Me.ckLowIncome)
        Me.Controls.Add(Me.ckMultiPet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dTotal)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.petSize)
        Me.Controls.Add(Me.ckAntibaV)
        Me.Controls.Add(Me.ckKennelCough)
        Me.Controls.Add(Me.ckRabies)
        Me.Controls.Add(Me.vaccines)
        Me.Controls.Add(Me.ckSpecimenExam)
        Me.Controls.Add(Me.ckXray)
        Me.Controls.Add(Me.ckOfficeVisit)
        Me.Controls.Add(Me.operation)
        Me.Controls.Add(Me.txtMiddleName)
        Me.Controls.Add(Me.petSpecies)
        Me.Controls.Add(Me.petName)
        Me.Controls.Add(Me.lastName)
        Me.Controls.Add(Me.middleName)
        Me.Controls.Add(Me.firstName)
        Me.Controls.Add(Me.PetInfo)
        Me.Controls.Add(Me.PetOwnerInfo)
        Me.Controls.Add(Me.btnTotal)
        Me.Name = "VetsRForm"
        Me.Text = "11155"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTotal As Button
    Friend WithEvents PetOwnerInfo As Label
    Friend WithEvents PetInfo As Label
    Friend WithEvents firstName As Label
    Friend WithEvents middleName As Label
    Friend WithEvents lastName As Label
    Friend WithEvents petName As Label
    Friend WithEvents petSpecies As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents operation As Label
    Friend WithEvents ckOfficeVisit As CheckBox
    Friend WithEvents ckXray As CheckBox
    Friend WithEvents ckSpecimenExam As CheckBox
    Friend WithEvents vaccines As Label
    Friend WithEvents ckRabies As CheckBox
    Friend WithEvents ckKennelCough As CheckBox
    Friend WithEvents ckAntibaV As CheckBox
    Friend WithEvents petSize As Label
    Friend WithEvents phone As Label
    Friend WithEvents dTotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ckMultiPet As CheckBox
    Friend WithEvents ckLowIncome As CheckBox
    Friend WithEvents discount As Label
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents btnReceipt As Button
    Friend WithEvents dReceipt As TextBox
    Friend WithEvents txtPhoneNumber As MaskedTextBox
    Friend WithEvents btnFinalTotal As Button
    Friend WithEvents dFinalTotal As TextBox
    Friend WithEvents cmbPetSize As ComboBox
    Friend WithEvents weight As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents lblantibanotice As Label
    Friend WithEvents txtFirstName As MaskedTextBox
    Friend WithEvents txtLastName As MaskedTextBox
    Friend WithEvents txtPetName As MaskedTextBox
    Friend WithEvents txtSpeciesName As MaskedTextBox
    Friend WithEvents btnClear As Button
End Class
