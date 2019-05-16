'Author:        Michael J Pearson
'Date:          March 16, 2006
'Purpose:       The Jackpot program is disigned to randomly generate six 
'               numbers  for Jacques Cousard to use in his attempts to 
'               win the lottery.
Option Explicit On 
Option Strict On

Public Class LotteryForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents uiLotteryNumbersLabel As System.Windows.Forms.Label
    Friend WithEvents uiRandomNumLabel1 As System.Windows.Forms.Label
    Friend WithEvents uiRandomNumLabel2 As System.Windows.Forms.Label
    Friend WithEvents uiRandomNumLabel3 As System.Windows.Forms.Label
    Friend WithEvents uiRandomNumLabel4 As System.Windows.Forms.Label
    Friend WithEvents uiRandomNumLabel5 As System.Windows.Forms.Label
    Friend WithEvents uiRandomNumLabel6 As System.Windows.Forms.Label
    Friend WithEvents uiGenerateButton As System.Windows.Forms.Button
    Friend WithEvents uiClearButton As System.Windows.Forms.Button
    Friend WithEvents uiExitButton As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.uiLotteryNumbersLabel = New System.Windows.Forms.Label()
        Me.uiRandomNumLabel1 = New System.Windows.Forms.Label()
        Me.uiRandomNumLabel2 = New System.Windows.Forms.Label()
        Me.uiRandomNumLabel3 = New System.Windows.Forms.Label()
        Me.uiRandomNumLabel4 = New System.Windows.Forms.Label()
        Me.uiRandomNumLabel5 = New System.Windows.Forms.Label()
        Me.uiRandomNumLabel6 = New System.Windows.Forms.Label()
        Me.uiGenerateButton = New System.Windows.Forms.Button()
        Me.uiClearButton = New System.Windows.Forms.Button()
        Me.uiExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'uiLotteryNumbersLabel
        '
        Me.uiLotteryNumbersLabel.AutoSize = True
        Me.uiLotteryNumbersLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uiLotteryNumbersLabel.Location = New System.Drawing.Point(128, 8)
        Me.uiLotteryNumbersLabel.Name = "uiLotteryNumbersLabel"
        Me.uiLotteryNumbersLabel.Size = New System.Drawing.Size(269, 37)
        Me.uiLotteryNumbersLabel.TabIndex = 0
        Me.uiLotteryNumbersLabel.Text = "Lottery Numbers"
        '
        'uiRandomNumLabel1
        '
        Me.uiRandomNumLabel1.BackColor = System.Drawing.SystemColors.Menu
        Me.uiRandomNumLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.uiRandomNumLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uiRandomNumLabel1.Location = New System.Drawing.Point(16, 56)
        Me.uiRandomNumLabel1.Name = "uiRandomNumLabel1"
        Me.uiRandomNumLabel1.Size = New System.Drawing.Size(72, 104)
        Me.uiRandomNumLabel1.TabIndex = 1
        Me.uiRandomNumLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'uiRandomNumLabel2
        '
        Me.uiRandomNumLabel2.BackColor = System.Drawing.SystemColors.Menu
        Me.uiRandomNumLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.uiRandomNumLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uiRandomNumLabel2.Location = New System.Drawing.Point(96, 56)
        Me.uiRandomNumLabel2.Name = "uiRandomNumLabel2"
        Me.uiRandomNumLabel2.Size = New System.Drawing.Size(72, 104)
        Me.uiRandomNumLabel2.TabIndex = 2
        Me.uiRandomNumLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'uiRandomNumLabel3
        '
        Me.uiRandomNumLabel3.BackColor = System.Drawing.SystemColors.Menu
        Me.uiRandomNumLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.uiRandomNumLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uiRandomNumLabel3.Location = New System.Drawing.Point(176, 56)
        Me.uiRandomNumLabel3.Name = "uiRandomNumLabel3"
        Me.uiRandomNumLabel3.Size = New System.Drawing.Size(72, 104)
        Me.uiRandomNumLabel3.TabIndex = 3
        Me.uiRandomNumLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'uiRandomNumLabel4
        '
        Me.uiRandomNumLabel4.BackColor = System.Drawing.SystemColors.Menu
        Me.uiRandomNumLabel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.uiRandomNumLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uiRandomNumLabel4.Location = New System.Drawing.Point(256, 56)
        Me.uiRandomNumLabel4.Name = "uiRandomNumLabel4"
        Me.uiRandomNumLabel4.Size = New System.Drawing.Size(72, 104)
        Me.uiRandomNumLabel4.TabIndex = 4
        Me.uiRandomNumLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'uiRandomNumLabel5
        '
        Me.uiRandomNumLabel5.BackColor = System.Drawing.SystemColors.Menu
        Me.uiRandomNumLabel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.uiRandomNumLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uiRandomNumLabel5.Location = New System.Drawing.Point(336, 56)
        Me.uiRandomNumLabel5.Name = "uiRandomNumLabel5"
        Me.uiRandomNumLabel5.Size = New System.Drawing.Size(72, 104)
        Me.uiRandomNumLabel5.TabIndex = 5
        Me.uiRandomNumLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'uiRandomNumLabel6
        '
        Me.uiRandomNumLabel6.BackColor = System.Drawing.SystemColors.Menu
        Me.uiRandomNumLabel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.uiRandomNumLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uiRandomNumLabel6.Location = New System.Drawing.Point(416, 56)
        Me.uiRandomNumLabel6.Name = "uiRandomNumLabel6"
        Me.uiRandomNumLabel6.Size = New System.Drawing.Size(72, 104)
        Me.uiRandomNumLabel6.TabIndex = 6
        Me.uiRandomNumLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'uiGenerateButton
        '
        Me.uiGenerateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uiGenerateButton.Location = New System.Drawing.Point(56, 200)
        Me.uiGenerateButton.Name = "uiGenerateButton"
        Me.uiGenerateButton.Size = New System.Drawing.Size(120, 40)
        Me.uiGenerateButton.TabIndex = 7
        Me.uiGenerateButton.Text = "&Generate"
        '
        'uiClearButton
        '
        Me.uiClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uiClearButton.Location = New System.Drawing.Point(192, 200)
        Me.uiClearButton.Name = "uiClearButton"
        Me.uiClearButton.Size = New System.Drawing.Size(120, 40)
        Me.uiClearButton.TabIndex = 8
        Me.uiClearButton.Text = "&Clear"
        '
        'uiExitButton
        '
        Me.uiExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uiExitButton.Location = New System.Drawing.Point(328, 200)
        Me.uiExitButton.Name = "uiExitButton"
        Me.uiExitButton.Size = New System.Drawing.Size(120, 40)
        Me.uiExitButton.TabIndex = 9
        Me.uiExitButton.Text = "&Exit"
        '
        'LotteryForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(520, 266)
        Me.Controls.Add(Me.uiExitButton)
        Me.Controls.Add(Me.uiClearButton)
        Me.Controls.Add(Me.uiGenerateButton)
        Me.Controls.Add(Me.uiRandomNumLabel6)
        Me.Controls.Add(Me.uiRandomNumLabel5)
        Me.Controls.Add(Me.uiRandomNumLabel4)
        Me.Controls.Add(Me.uiRandomNumLabel3)
        Me.Controls.Add(Me.uiRandomNumLabel2)
        Me.Controls.Add(Me.uiRandomNumLabel1)
        Me.Controls.Add(Me.uiLotteryNumbersLabel)
        Me.Name = "LotteryForm"
        Me.Text = "Jackpot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub uiGenerateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uiGenerateButton.Click
        'Generates and displays six randomly selected lottery numbers

        Dim randomNum1, randomNum2, randomNum3, randomNum4, randomNum5, randomNum6 As Integer
        Dim randomGenerator As New Random

        'generate random numbers
        randomNum1 = randomGenerator.Next(1, 54)
        randomNum2 = randomGenerator.Next(1, 54)
        randomNum3 = randomGenerator.Next(1, 54)
        randomNum4 = randomGenerator.Next(1, 54)
        randomNum5 = randomGenerator.Next(1, 54)
        randomNum6 = randomGenerator.Next(1, 54)

        'Display the random numbers for the user to see.
        uiRandomNumLabel1.Text = Convert.ToString(randomNum1)
        uiRandomNumLabel2.Text = Convert.ToString(randomNum2)
        uiRandomNumLabel3.Text = Convert.ToString(randomNum3)
        uiRandomNumLabel4.Text = Convert.ToString(randomNum4)
        uiRandomNumLabel5.Text = Convert.ToString(randomNum5)
        uiRandomNumLabel6.Text = Convert.ToString(randomNum6)
    End Sub

    Private Sub uiClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uiClearButton.Click
        uiRandomNumLabel1.Text = ""
        uiRandomNumLabel2.Text = ""
        uiRandomNumLabel3.Text = ""
        uiRandomNumLabel4.Text = ""
        uiRandomNumLabel5.Text = ""
        uiRandomNumLabel6.Text = ""
    End Sub

    Private Sub uiExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uiExitButton.Click
        Me.Close()
    End Sub
End Class
