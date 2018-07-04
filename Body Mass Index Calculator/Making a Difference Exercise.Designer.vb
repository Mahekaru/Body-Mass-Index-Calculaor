<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMassCalc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblWeightNPounds = New System.Windows.Forms.Label()
        Me.lblHeightNInches = New System.Windows.Forms.Label()
        Me.lblMassIndex = New System.Windows.Forms.Label()
        Me.txtWeighNPounds = New System.Windows.Forms.TextBox()
        Me.TxtMassIndex = New System.Windows.Forms.TextBox()
        Me.txtHeightNInches = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtHealthScale = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblWeightNPounds
        '
        Me.lblWeightNPounds.AutoSize = True
        Me.lblWeightNPounds.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeightNPounds.Location = New System.Drawing.Point(12, 37)
        Me.lblWeightNPounds.Name = "lblWeightNPounds"
        Me.lblWeightNPounds.Size = New System.Drawing.Size(166, 11)
        Me.lblWeightNPounds.TabIndex = 0
        Me.lblWeightNPounds.Text = "Enter weight in pounds:"
        '
        'lblHeightNInches
        '
        Me.lblHeightNInches.AutoSize = True
        Me.lblHeightNInches.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeightNInches.Location = New System.Drawing.Point(12, 67)
        Me.lblHeightNInches.Name = "lblHeightNInches"
        Me.lblHeightNInches.Size = New System.Drawing.Size(166, 11)
        Me.lblHeightNInches.TabIndex = 1
        Me.lblHeightNInches.Text = "Enter height in inches:"
        '
        'lblMassIndex
        '
        Me.lblMassIndex.AutoSize = True
        Me.lblMassIndex.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMassIndex.Location = New System.Drawing.Point(12, 104)
        Me.lblMassIndex.Name = "lblMassIndex"
        Me.lblMassIndex.Size = New System.Drawing.Size(117, 11)
        Me.lblMassIndex.TabIndex = 2
        Me.lblMassIndex.Text = "Body Mass Index:"
        '
        'txtWeighNPounds
        '
        Me.txtWeighNPounds.AcceptsTab = True
        Me.txtWeighNPounds.Location = New System.Drawing.Point(194, 32)
        Me.txtWeighNPounds.Name = "txtWeighNPounds"
        Me.txtWeighNPounds.Size = New System.Drawing.Size(117, 20)
        Me.txtWeighNPounds.TabIndex = 1
        '
        'TxtMassIndex
        '
        Me.TxtMassIndex.Location = New System.Drawing.Point(194, 99)
        Me.TxtMassIndex.Name = "TxtMassIndex"
        Me.TxtMassIndex.ReadOnly = True
        Me.TxtMassIndex.Size = New System.Drawing.Size(117, 20)
        Me.TxtMassIndex.TabIndex = 0
        Me.TxtMassIndex.TabStop = False
        '
        'txtHeightNInches
        '
        Me.txtHeightNInches.AcceptsTab = True
        Me.txtHeightNInches.Location = New System.Drawing.Point(194, 67)
        Me.txtHeightNInches.Name = "txtHeightNInches"
        Me.txtHeightNInches.Size = New System.Drawing.Size(117, 20)
        Me.txtHeightNInches.TabIndex = 2
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(325, 28)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(123, 27)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate BMI"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtHealthScale
        '
        Me.txtHealthScale.Enabled = False
        Me.txtHealthScale.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHealthScale.Location = New System.Drawing.Point(12, 125)
        Me.txtHealthScale.Multiline = True
        Me.txtHealthScale.Name = "txtHealthScale"
        Me.txtHealthScale.Size = New System.Drawing.Size(299, 71)
        Me.txtHealthScale.TabIndex = 8
        '
        'frmMassCalc
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 207)
        Me.Controls.Add(Me.txtHealthScale)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtHeightNInches)
        Me.Controls.Add(Me.TxtMassIndex)
        Me.Controls.Add(Me.txtWeighNPounds)
        Me.Controls.Add(Me.lblMassIndex)
        Me.Controls.Add(Me.lblHeightNInches)
        Me.Controls.Add(Me.lblWeightNPounds)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmMassCalc"
        Me.Text = "Body Mass Index Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWeightNPounds As System.Windows.Forms.Label
    Friend WithEvents lblHeightNInches As System.Windows.Forms.Label
    Friend WithEvents lblMassIndex As System.Windows.Forms.Label
    Friend WithEvents txtWeighNPounds As System.Windows.Forms.TextBox
    Friend WithEvents TxtMassIndex As System.Windows.Forms.TextBox
    Friend WithEvents txtHeightNInches As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtHealthScale As System.Windows.Forms.TextBox

End Class
