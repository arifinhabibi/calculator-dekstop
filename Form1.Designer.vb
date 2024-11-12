<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        grpInput = New GroupBox()
        txtHasil = New TextBox()
        lblHasil = New Label()
        txtInput2 = New TextBox()
        lblInput2 = New Label()
        lblInput1 = New Label()
        txtInput1 = New TextBox()
        grpOperations = New GroupBox()
        btnLessThan = New Button()
        btnBagi = New Button()
        btnMoreThan = New Button()
        btnKali = New Button()
        btnTambah = New Button()
        btnKurang = New Button()
        btnReset = New Button()
        grpInput.SuspendLayout()
        grpOperations.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpInput
        ' 
        grpInput.Controls.Add(txtHasil)
        grpInput.Controls.Add(lblHasil)
        grpInput.Controls.Add(txtInput2)
        grpInput.Controls.Add(lblInput2)
        grpInput.Controls.Add(lblInput1)
        grpInput.Controls.Add(txtInput1)
        grpInput.Location = New Point(20, 20)
        grpInput.Name = "grpInput"
        grpInput.Size = New Size(440, 150)
        grpInput.TabIndex = 0
        grpInput.TabStop = False
        grpInput.Text = "Input Numbers"
        ' 
        ' txtHasil
        ' 
        txtHasil.BackColor = Color.LightGray
        txtHasil.BorderStyle = BorderStyle.FixedSingle
        txtHasil.Location = New Point(110, 110)
        txtHasil.Name = "txtHasil"
        txtHasil.ReadOnly = True
        txtHasil.Size = New Size(300, 25)
        txtHasil.TabIndex = 5
        ' 
        ' lblHasil
        ' 
        lblHasil.AutoSize = True
        lblHasil.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHasil.Location = New Point(20, 110)
        lblHasil.Name = "lblHasil"
        lblHasil.Size = New Size(50, 17)
        lblHasil.TabIndex = 4
        lblHasil.Text = "Result:"
        ' 
        ' txtInput2
        ' 
        txtInput2.BackColor = Color.LightYellow
        txtInput2.BorderStyle = BorderStyle.FixedSingle
        txtInput2.Location = New Point(110, 70)
        txtInput2.Name = "txtInput2"
        txtInput2.Size = New Size(300, 25)
        txtInput2.TabIndex = 3
        ' 
        ' lblInput2
        ' 
        lblInput2.AutoSize = True
        lblInput2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInput2.Location = New Point(20, 70)
        lblInput2.Name = "lblInput2"
        lblInput2.Size = New Size(56, 17)
        lblInput2.TabIndex = 2
        lblInput2.Text = "Input 2:"
        ' 
        ' lblInput1
        ' 
        lblInput1.AutoSize = True
        lblInput1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInput1.Location = New Point(20, 30)
        lblInput1.Name = "lblInput1"
        lblInput1.Size = New Size(56, 17)
        lblInput1.TabIndex = 1
        lblInput1.Text = "Input 1:"
        ' 
        ' txtInput1
        ' 
        txtInput1.BackColor = Color.LightYellow
        txtInput1.BorderStyle = BorderStyle.FixedSingle
        txtInput1.Location = New Point(110, 30)
        txtInput1.Name = "txtInput1"
        txtInput1.Size = New Size(300, 25)
        txtInput1.TabIndex = 0
        ' 
        ' grpOperations
        ' 
        grpOperations.Controls.Add(btnLessThan)
        grpOperations.Controls.Add(btnBagi)
        grpOperations.Controls.Add(btnMoreThan)
        grpOperations.Controls.Add(btnKali)
        grpOperations.Controls.Add(btnTambah)
        grpOperations.Controls.Add(btnKurang)
        grpOperations.Location = New Point(20, 180)
        grpOperations.Name = "grpOperations"
        grpOperations.Size = New Size(440, 125)
        grpOperations.TabIndex = 1
        grpOperations.TabStop = False
        grpOperations.Text = "Basic Operations"
        ' 
        ' btnLessThan
        ' 
        btnLessThan.BackColor = Color.FromArgb(CByte(33), CByte(150), CByte(243))
        btnLessThan.FlatStyle = FlatStyle.Flat
        btnLessThan.ForeColor = Color.White
        btnLessThan.Location = New Point(230, 71)
        btnLessThan.Name = "btnLessThan"
        btnLessThan.Size = New Size(200, 35)
        btnLessThan.TabIndex = 1
        btnLessThan.Text = "Less Than (<)"
        btnLessThan.UseVisualStyleBackColor = False
        ' 
        ' btnBagi
        ' 
        btnBagi.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnBagi.FlatStyle = FlatStyle.Flat
        btnBagi.ForeColor = Color.White
        btnBagi.Location = New Point(335, 30)
        btnBagi.Name = "btnBagi"
        btnBagi.Size = New Size(95, 35)
        btnBagi.TabIndex = 3
        btnBagi.Text = "Div (÷)"
        btnBagi.UseVisualStyleBackColor = False
        ' 
        ' btnMoreThan
        ' 
        btnMoreThan.BackColor = Color.FromArgb(CByte(33), CByte(150), CByte(243))
        btnMoreThan.FlatStyle = FlatStyle.Flat
        btnMoreThan.ForeColor = Color.White
        btnMoreThan.Location = New Point(20, 71)
        btnMoreThan.Name = "btnMoreThan"
        btnMoreThan.Size = New Size(200, 35)
        btnMoreThan.TabIndex = 0
        btnMoreThan.Text = "More Than (>)"
        btnMoreThan.UseVisualStyleBackColor = False
        ' 
        ' btnKali
        ' 
        btnKali.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnKali.FlatStyle = FlatStyle.Flat
        btnKali.ForeColor = Color.White
        btnKali.Location = New Point(230, 30)
        btnKali.Name = "btnKali"
        btnKali.Size = New Size(95, 35)
        btnKali.TabIndex = 2
        btnKali.Text = "Mul (×)"
        btnKali.UseVisualStyleBackColor = False
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.ForeColor = Color.White
        btnTambah.Location = New Point(20, 30)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(95, 35)
        btnTambah.TabIndex = 1
        btnTambah.Text = "Add (+)"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnKurang
        ' 
        btnKurang.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnKurang.FlatStyle = FlatStyle.Flat
        btnKurang.ForeColor = Color.White
        btnKurang.Location = New Point(125, 30)
        btnKurang.Name = "btnKurang"
        btnKurang.Size = New Size(95, 35)
        btnKurang.TabIndex = 0
        btnKurang.Text = "Sub (-)"
        btnKurang.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReset.Location = New Point(40, 330)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(410, 35)
        btnReset.TabIndex = 3
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(484, 421)
        Controls.Add(btnReset)
        Controls.Add(grpOperations)
        Controls.Add(grpInput)
        Font = New Font("Segoe UI", 10F)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Modern Calculator"
        grpInput.ResumeLayout(False)
        grpInput.PerformLayout()
        grpOperations.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents grpInput As GroupBox
    Friend WithEvents grpOperations As GroupBox
    Friend WithEvents txtInput1 As TextBox
    Friend WithEvents lblInput1 As Label
    Friend WithEvents lblInput2 As Label
    Friend WithEvents txtInput2 As TextBox
    Friend WithEvents lblHasil As Label
    Friend WithEvents txtHasil As TextBox
    Friend WithEvents btnKurang As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnKali As Button
    Friend WithEvents btnBagi As Button
    Friend WithEvents btnMoreThan As Button
    Friend WithEvents btnLessThan As Button
    Friend WithEvents btnReset As Button
End Class
