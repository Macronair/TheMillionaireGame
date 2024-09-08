<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HostScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HostScreen))
        Me.pnlCorrect = New System.Windows.Forms.Panel()
        Me.picCorrect = New System.Windows.Forms.PictureBox()
        Me.lblCorrect = New System.Windows.Forms.Label()
        Me.pnlWrong = New System.Windows.Forms.Panel()
        Me.picWrong = New System.Windows.Forms.PictureBox()
        Me.lblWrong = New System.Windows.Forms.Label()
        Me.pnlCurrent = New System.Windows.Forms.Panel()
        Me.picCurrent = New System.Windows.Forms.PictureBox()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.pnlDrop = New System.Windows.Forms.Panel()
        Me.lblDrop = New System.Windows.Forms.Label()
        Me.pnlQLeft = New System.Windows.Forms.Panel()
        Me.picQLeft = New System.Windows.Forms.PictureBox()
        Me.lblQLeft = New System.Windows.Forms.Label()
        Me.pnlAnswer = New System.Windows.Forms.Panel()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblExplainRules = New System.Windows.Forms.Label()
        Me.lblWalkedAway = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtATAd = New System.Windows.Forms.TextBox()
        Me.txtATAc = New System.Windows.Forms.TextBox()
        Me.txtATAb = New System.Windows.Forms.TextBox()
        Me.txtATAa = New System.Windows.Forms.TextBox()
        Me.txtExplain = New System.Windows.Forms.Label()
        Me.txtWinnings = New System.Windows.Forms.Label()
        Me.lblHostMsg = New System.Windows.Forms.TextBox()
        Me.pnlD = New System.Windows.Forms.Panel()
        Me.txtD = New System.Windows.Forms.Label()
        Me.pnlB = New System.Windows.Forms.Panel()
        Me.txtB = New System.Windows.Forms.Label()
        Me.pnlC = New System.Windows.Forms.Panel()
        Me.txtC = New System.Windows.Forms.Label()
        Me.pnlA = New System.Windows.Forms.Panel()
        Me.txtA = New System.Windows.Forms.Label()
        Me.picQuestion = New System.Windows.Forms.Panel()
        Me.txtQuestion = New System.Windows.Forms.Label()
        Me.picTree = New System.Windows.Forms.PictureBox()
        Me.pnlStrap = New System.Windows.Forms.Panel()
        Me.txtWinningStrap = New System.Windows.Forms.Label()
        Me.picLifeline1 = New System.Windows.Forms.PictureBox()
        Me.picLifeline2 = New System.Windows.Forms.PictureBox()
        Me.picLifeline3 = New System.Windows.Forms.PictureBox()
        Me.picLifeline4 = New System.Windows.Forms.PictureBox()
        Me.pnlCorrect.SuspendLayout()
        CType(Me.picCorrect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlWrong.SuspendLayout()
        CType(Me.picWrong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCurrent.SuspendLayout()
        CType(Me.picCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDrop.SuspendLayout()
        Me.pnlQLeft.SuspendLayout()
        CType(Me.picQLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAnswer.SuspendLayout()
        Me.pnlD.SuspendLayout()
        Me.pnlB.SuspendLayout()
        Me.pnlC.SuspendLayout()
        Me.pnlA.SuspendLayout()
        Me.picQuestion.SuspendLayout()
        CType(Me.picTree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStrap.SuspendLayout()
        CType(Me.picLifeline1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLifeline2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLifeline3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLifeline4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCorrect
        '
        Me.pnlCorrect.BackColor = System.Drawing.Color.Lime
        Me.pnlCorrect.Controls.Add(Me.picCorrect)
        Me.pnlCorrect.Controls.Add(Me.lblCorrect)
        Me.pnlCorrect.Location = New System.Drawing.Point(9, 4)
        Me.pnlCorrect.Name = "pnlCorrect"
        Me.pnlCorrect.Size = New System.Drawing.Size(191, 49)
        Me.pnlCorrect.TabIndex = 8
        '
        'picCorrect
        '
        Me.picCorrect.Image = CType(resources.GetObject("picCorrect.Image"), System.Drawing.Image)
        Me.picCorrect.Location = New System.Drawing.Point(153, 9)
        Me.picCorrect.Name = "picCorrect"
        Me.picCorrect.Size = New System.Drawing.Size(31, 31)
        Me.picCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCorrect.TabIndex = 17
        Me.picCorrect.TabStop = False
        '
        'lblCorrect
        '
        Me.lblCorrect.AutoSize = True
        Me.lblCorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrect.ForeColor = System.Drawing.Color.Black
        Me.lblCorrect.Location = New System.Drawing.Point(9, 12)
        Me.lblCorrect.Name = "lblCorrect"
        Me.lblCorrect.Size = New System.Drawing.Size(25, 25)
        Me.lblCorrect.TabIndex = 16
        Me.lblCorrect.Text = "0"
        '
        'pnlWrong
        '
        Me.pnlWrong.BackColor = System.Drawing.Color.Red
        Me.pnlWrong.Controls.Add(Me.picWrong)
        Me.pnlWrong.Controls.Add(Me.lblWrong)
        Me.pnlWrong.Location = New System.Drawing.Point(9, 59)
        Me.pnlWrong.Name = "pnlWrong"
        Me.pnlWrong.Size = New System.Drawing.Size(191, 49)
        Me.pnlWrong.TabIndex = 9
        '
        'picWrong
        '
        Me.picWrong.Image = CType(resources.GetObject("picWrong.Image"), System.Drawing.Image)
        Me.picWrong.Location = New System.Drawing.Point(153, 9)
        Me.picWrong.Name = "picWrong"
        Me.picWrong.Size = New System.Drawing.Size(31, 31)
        Me.picWrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWrong.TabIndex = 19
        Me.picWrong.TabStop = False
        '
        'lblWrong
        '
        Me.lblWrong.AutoSize = True
        Me.lblWrong.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWrong.ForeColor = System.Drawing.Color.White
        Me.lblWrong.Location = New System.Drawing.Point(9, 12)
        Me.lblWrong.Name = "lblWrong"
        Me.lblWrong.Size = New System.Drawing.Size(25, 25)
        Me.lblWrong.TabIndex = 16
        Me.lblWrong.Text = "0"
        '
        'pnlCurrent
        '
        Me.pnlCurrent.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlCurrent.Controls.Add(Me.picCurrent)
        Me.pnlCurrent.Controls.Add(Me.lblCurrent)
        Me.pnlCurrent.Location = New System.Drawing.Point(206, 4)
        Me.pnlCurrent.Name = "pnlCurrent"
        Me.pnlCurrent.Size = New System.Drawing.Size(191, 49)
        Me.pnlCurrent.TabIndex = 10
        '
        'picCurrent
        '
        Me.picCurrent.Image = CType(resources.GetObject("picCurrent.Image"), System.Drawing.Image)
        Me.picCurrent.Location = New System.Drawing.Point(153, 9)
        Me.picCurrent.Name = "picCurrent"
        Me.picCurrent.Size = New System.Drawing.Size(31, 31)
        Me.picCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCurrent.TabIndex = 18
        Me.picCurrent.TabStop = False
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrent.ForeColor = System.Drawing.Color.Black
        Me.lblCurrent.Location = New System.Drawing.Point(9, 12)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(25, 25)
        Me.lblCurrent.TabIndex = 0
        Me.lblCurrent.Text = "0"
        '
        'pnlDrop
        '
        Me.pnlDrop.BackColor = System.Drawing.Color.Cyan
        Me.pnlDrop.Controls.Add(Me.lblDrop)
        Me.pnlDrop.Location = New System.Drawing.Point(9, 114)
        Me.pnlDrop.Name = "pnlDrop"
        Me.pnlDrop.Size = New System.Drawing.Size(191, 49)
        Me.pnlDrop.TabIndex = 9
        '
        'lblDrop
        '
        Me.lblDrop.AutoSize = True
        Me.lblDrop.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrop.ForeColor = System.Drawing.Color.Black
        Me.lblDrop.Location = New System.Drawing.Point(9, 12)
        Me.lblDrop.Name = "lblDrop"
        Me.lblDrop.Size = New System.Drawing.Size(25, 25)
        Me.lblDrop.TabIndex = 16
        Me.lblDrop.Text = "0"
        '
        'pnlQLeft
        '
        Me.pnlQLeft.BackColor = System.Drawing.Color.Blue
        Me.pnlQLeft.Controls.Add(Me.picQLeft)
        Me.pnlQLeft.Controls.Add(Me.lblQLeft)
        Me.pnlQLeft.Location = New System.Drawing.Point(206, 59)
        Me.pnlQLeft.Name = "pnlQLeft"
        Me.pnlQLeft.Size = New System.Drawing.Size(191, 49)
        Me.pnlQLeft.TabIndex = 11
        '
        'picQLeft
        '
        Me.picQLeft.Image = CType(resources.GetObject("picQLeft.Image"), System.Drawing.Image)
        Me.picQLeft.Location = New System.Drawing.Point(153, 9)
        Me.picQLeft.Name = "picQLeft"
        Me.picQLeft.Size = New System.Drawing.Size(31, 31)
        Me.picQLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQLeft.TabIndex = 18
        Me.picQLeft.TabStop = False
        '
        'lblQLeft
        '
        Me.lblQLeft.AutoSize = True
        Me.lblQLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQLeft.ForeColor = System.Drawing.Color.White
        Me.lblQLeft.Location = New System.Drawing.Point(9, 12)
        Me.lblQLeft.Name = "lblQLeft"
        Me.lblQLeft.Size = New System.Drawing.Size(25, 25)
        Me.lblQLeft.TabIndex = 16
        Me.lblQLeft.Text = "0"
        '
        'pnlAnswer
        '
        Me.pnlAnswer.BackColor = System.Drawing.Color.Black
        Me.pnlAnswer.Controls.Add(Me.lblAnswer)
        Me.pnlAnswer.Location = New System.Drawing.Point(880, 440)
        Me.pnlAnswer.Name = "pnlAnswer"
        Me.pnlAnswer.Size = New System.Drawing.Size(47, 46)
        Me.pnlAnswer.TabIndex = 17
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.ForeColor = System.Drawing.Color.Black
        Me.lblAnswer.Location = New System.Drawing.Point(12, 11)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(25, 25)
        Me.lblAnswer.TabIndex = 0
        Me.lblAnswer.Text = "1"
        '
        'lblExplainRules
        '
        Me.lblExplainRules.AutoSize = True
        Me.lblExplainRules.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExplainRules.ForeColor = System.Drawing.Color.Black
        Me.lblExplainRules.Location = New System.Drawing.Point(400, 17)
        Me.lblExplainRules.Name = "lblExplainRules"
        Me.lblExplainRules.Size = New System.Drawing.Size(152, 18)
        Me.lblExplainRules.TabIndex = 23
        Me.lblExplainRules.Text = "EXPLAIN RULES"
        '
        'lblWalkedAway
        '
        Me.lblWalkedAway.AutoSize = True
        Me.lblWalkedAway.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWalkedAway.ForeColor = System.Drawing.Color.Black
        Me.lblWalkedAway.Location = New System.Drawing.Point(400, 35)
        Me.lblWalkedAway.Name = "lblWalkedAway"
        Me.lblWalkedAway.Size = New System.Drawing.Size(147, 18)
        Me.lblWalkedAway.TabIndex = 26
        Me.lblWalkedAway.Text = "WALKED AWAY"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Copperplate Gothic Bold", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(750, 320)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(181, 107)
        Me.lblTime.TabIndex = 27
        Me.lblTime.Text = "30"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTime.Visible = False
        '
        'txtATAd
        '
        Me.txtATAd.BackColor = System.Drawing.Color.Black
        Me.txtATAd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtATAd.Font = New System.Drawing.Font("Copperplate Gothic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtATAd.ForeColor = System.Drawing.Color.White
        Me.txtATAd.Location = New System.Drawing.Point(760, 206)
        Me.txtATAd.Name = "txtATAd"
        Me.txtATAd.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtATAd.Size = New System.Drawing.Size(170, 36)
        Me.txtATAd.TabIndex = 43
        Me.txtATAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtATAc
        '
        Me.txtATAc.BackColor = System.Drawing.Color.Black
        Me.txtATAc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtATAc.Font = New System.Drawing.Font("Copperplate Gothic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtATAc.ForeColor = System.Drawing.Color.White
        Me.txtATAc.Location = New System.Drawing.Point(760, 164)
        Me.txtATAc.Name = "txtATAc"
        Me.txtATAc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtATAc.Size = New System.Drawing.Size(170, 36)
        Me.txtATAc.TabIndex = 42
        Me.txtATAc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtATAb
        '
        Me.txtATAb.BackColor = System.Drawing.Color.Black
        Me.txtATAb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtATAb.Font = New System.Drawing.Font("Copperplate Gothic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtATAb.ForeColor = System.Drawing.Color.White
        Me.txtATAb.Location = New System.Drawing.Point(760, 122)
        Me.txtATAb.Name = "txtATAb"
        Me.txtATAb.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtATAb.Size = New System.Drawing.Size(170, 36)
        Me.txtATAb.TabIndex = 41
        Me.txtATAb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtATAa
        '
        Me.txtATAa.BackColor = System.Drawing.Color.Black
        Me.txtATAa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtATAa.Font = New System.Drawing.Font("Copperplate Gothic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtATAa.ForeColor = System.Drawing.Color.White
        Me.txtATAa.Location = New System.Drawing.Point(760, 80)
        Me.txtATAa.Name = "txtATAa"
        Me.txtATAa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtATAa.Size = New System.Drawing.Size(170, 36)
        Me.txtATAa.TabIndex = 40
        Me.txtATAa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtExplain
        '
        Me.txtExplain.BackColor = System.Drawing.Color.Black
        Me.txtExplain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtExplain.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExplain.ForeColor = System.Drawing.Color.White
        Me.txtExplain.Location = New System.Drawing.Point(12, 333)
        Me.txtExplain.Name = "txtExplain"
        Me.txtExplain.Size = New System.Drawing.Size(746, 155)
        Me.txtExplain.TabIndex = 61
        '
        'txtWinnings
        '
        Me.txtWinnings.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWinnings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtWinnings.Location = New System.Drawing.Point(206, 115)
        Me.txtWinnings.Name = "txtWinnings"
        Me.txtWinnings.Size = New System.Drawing.Size(288, 46)
        Me.txtWinnings.TabIndex = 67
        Me.txtWinnings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHostMsg
        '
        Me.lblHostMsg.BackColor = System.Drawing.Color.Black
        Me.lblHostMsg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblHostMsg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lblHostMsg.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblHostMsg.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHostMsg.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblHostMsg.Location = New System.Drawing.Point(12, 169)
        Me.lblHostMsg.Multiline = True
        Me.lblHostMsg.Name = "lblHostMsg"
        Me.lblHostMsg.Size = New System.Drawing.Size(746, 161)
        Me.lblHostMsg.TabIndex = 70
        '
        'pnlD
        '
        Me.pnlD.BackgroundImage = Global.MillionaireGame.My.Resources.Resources._01_Answer_R_Normal
        Me.pnlD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlD.Controls.Add(Me.txtD)
        Me.pnlD.Location = New System.Drawing.Point(640, 651)
        Me.pnlD.Name = "pnlD"
        Me.pnlD.Size = New System.Drawing.Size(641, 57)
        Me.pnlD.TabIndex = 65
        '
        'txtD
        '
        Me.txtD.BackColor = System.Drawing.Color.Transparent
        Me.txtD.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtD.ForeColor = System.Drawing.Color.White
        Me.txtD.Location = New System.Drawing.Point(41, 5)
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(476, 46)
        Me.txtD.TabIndex = 19
        Me.txtD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlB
        '
        Me.pnlB.BackgroundImage = Global.MillionaireGame.My.Resources.Resources._01_Answer_R_Normal
        Me.pnlB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlB.Controls.Add(Me.txtB)
        Me.pnlB.Location = New System.Drawing.Point(640, 592)
        Me.pnlB.Name = "pnlB"
        Me.pnlB.Size = New System.Drawing.Size(641, 57)
        Me.pnlB.TabIndex = 64
        '
        'txtB
        '
        Me.txtB.BackColor = System.Drawing.Color.Transparent
        Me.txtB.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB.ForeColor = System.Drawing.Color.White
        Me.txtB.Location = New System.Drawing.Point(41, 5)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(476, 46)
        Me.txtB.TabIndex = 19
        Me.txtB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlC
        '
        Me.pnlC.BackgroundImage = Global.MillionaireGame.My.Resources.Resources._01_Answer_L_Normal
        Me.pnlC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlC.Controls.Add(Me.txtC)
        Me.pnlC.Location = New System.Drawing.Point(0, 651)
        Me.pnlC.Name = "pnlC"
        Me.pnlC.Size = New System.Drawing.Size(641, 57)
        Me.pnlC.TabIndex = 63
        '
        'txtC
        '
        Me.txtC.BackColor = System.Drawing.Color.Transparent
        Me.txtC.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC.ForeColor = System.Drawing.Color.White
        Me.txtC.Location = New System.Drawing.Point(122, 5)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(476, 46)
        Me.txtC.TabIndex = 18
        Me.txtC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlA
        '
        Me.pnlA.BackgroundImage = Global.MillionaireGame.My.Resources.Resources._01_Answer_L_Normal
        Me.pnlA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlA.Controls.Add(Me.txtA)
        Me.pnlA.Location = New System.Drawing.Point(0, 592)
        Me.pnlA.Name = "pnlA"
        Me.pnlA.Size = New System.Drawing.Size(641, 57)
        Me.pnlA.TabIndex = 62
        '
        'txtA
        '
        Me.txtA.BackColor = System.Drawing.Color.Transparent
        Me.txtA.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.ForeColor = System.Drawing.Color.White
        Me.txtA.Location = New System.Drawing.Point(122, 5)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(476, 46)
        Me.txtA.TabIndex = 17
        Me.txtA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picQuestion
        '
        Me.picQuestion.BackgroundImage = Global.MillionaireGame.My.Resources.Resources._01_Question_Strap
        Me.picQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picQuestion.Controls.Add(Me.txtQuestion)
        Me.picQuestion.Location = New System.Drawing.Point(0, 492)
        Me.picQuestion.Name = "picQuestion"
        Me.picQuestion.Size = New System.Drawing.Size(1280, 93)
        Me.picQuestion.TabIndex = 66
        '
        'txtQuestion
        '
        Me.txtQuestion.BackColor = System.Drawing.Color.Transparent
        Me.txtQuestion.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestion.ForeColor = System.Drawing.Color.White
        Me.txtQuestion.Location = New System.Drawing.Point(132, 11)
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(1016, 69)
        Me.txtQuestion.TabIndex = 13
        Me.txtQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picTree
        '
        Me.picTree.BackColor = System.Drawing.Color.Transparent
        Me.picTree.Image = Global.MillionaireGame.My.Resources.Resources._01_Tree
        Me.picTree.Location = New System.Drawing.Point(367, 0)
        Me.picTree.Name = "picTree"
        Me.picTree.Size = New System.Drawing.Size(920, 490)
        Me.picTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTree.TabIndex = 12
        Me.picTree.TabStop = False
        '
        'pnlStrap
        '
        Me.pnlStrap.BackgroundImage = Global.MillionaireGame.My.Resources.Resources.WinStrap_01
        Me.pnlStrap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlStrap.Controls.Add(Me.txtWinningStrap)
        Me.pnlStrap.Location = New System.Drawing.Point(-8, 492)
        Me.pnlStrap.Name = "pnlStrap"
        Me.pnlStrap.Size = New System.Drawing.Size(1296, 225)
        Me.pnlStrap.TabIndex = 68
        Me.pnlStrap.Visible = False
        '
        'txtWinningStrap
        '
        Me.txtWinningStrap.BackColor = System.Drawing.Color.Transparent
        Me.txtWinningStrap.Font = New System.Drawing.Font("Copperplate Gothic Bold", 38.0!)
        Me.txtWinningStrap.Location = New System.Drawing.Point(423, 84)
        Me.txtWinningStrap.Name = "txtWinningStrap"
        Me.txtWinningStrap.Size = New System.Drawing.Size(451, 55)
        Me.txtWinningStrap.TabIndex = 0
        Me.txtWinningStrap.Text = "1.000.000"
        Me.txtWinningStrap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picLifeline1
        '
        Me.picLifeline1.BackColor = System.Drawing.Color.Transparent
        Me.picLifeline1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLifeline1.Location = New System.Drawing.Point(566, 12)
        Me.picLifeline1.Name = "picLifeline1"
        Me.picLifeline1.Size = New System.Drawing.Size(86, 52)
        Me.picLifeline1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLifeline1.TabIndex = 71
        Me.picLifeline1.TabStop = False
        '
        'picLifeline2
        '
        Me.picLifeline2.BackColor = System.Drawing.Color.Transparent
        Me.picLifeline2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLifeline2.Location = New System.Drawing.Point(658, 12)
        Me.picLifeline2.Name = "picLifeline2"
        Me.picLifeline2.Size = New System.Drawing.Size(86, 52)
        Me.picLifeline2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLifeline2.TabIndex = 72
        Me.picLifeline2.TabStop = False
        '
        'picLifeline3
        '
        Me.picLifeline3.BackColor = System.Drawing.Color.Transparent
        Me.picLifeline3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLifeline3.Location = New System.Drawing.Point(750, 12)
        Me.picLifeline3.Name = "picLifeline3"
        Me.picLifeline3.Size = New System.Drawing.Size(86, 52)
        Me.picLifeline3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLifeline3.TabIndex = 73
        Me.picLifeline3.TabStop = False
        '
        'picLifeline4
        '
        Me.picLifeline4.BackColor = System.Drawing.Color.Transparent
        Me.picLifeline4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLifeline4.Location = New System.Drawing.Point(841, 12)
        Me.picLifeline4.Name = "picLifeline4"
        Me.picLifeline4.Size = New System.Drawing.Size(86, 52)
        Me.picLifeline4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLifeline4.TabIndex = 74
        Me.picLifeline4.TabStop = False
        '
        'HostScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.picLifeline4)
        Me.Controls.Add(Me.picLifeline3)
        Me.Controls.Add(Me.picLifeline2)
        Me.Controls.Add(Me.picLifeline1)
        Me.Controls.Add(Me.picQuestion)
        Me.Controls.Add(Me.txtATAd)
        Me.Controls.Add(Me.txtATAc)
        Me.Controls.Add(Me.txtATAb)
        Me.Controls.Add(Me.txtATAa)
        Me.Controls.Add(Me.lblHostMsg)
        Me.Controls.Add(Me.txtWinnings)
        Me.Controls.Add(Me.pnlD)
        Me.Controls.Add(Me.pnlB)
        Me.Controls.Add(Me.pnlC)
        Me.Controls.Add(Me.pnlA)
        Me.Controls.Add(Me.txtExplain)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblWalkedAway)
        Me.Controls.Add(Me.lblExplainRules)
        Me.Controls.Add(Me.pnlAnswer)
        Me.Controls.Add(Me.pnlQLeft)
        Me.Controls.Add(Me.pnlDrop)
        Me.Controls.Add(Me.pnlCurrent)
        Me.Controls.Add(Me.pnlWrong)
        Me.Controls.Add(Me.pnlCorrect)
        Me.Controls.Add(Me.picTree)
        Me.Controls.Add(Me.pnlStrap)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HostScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Host Screen"
        Me.pnlCorrect.ResumeLayout(False)
        Me.pnlCorrect.PerformLayout()
        CType(Me.picCorrect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlWrong.ResumeLayout(False)
        Me.pnlWrong.PerformLayout()
        CType(Me.picWrong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCurrent.ResumeLayout(False)
        Me.pnlCurrent.PerformLayout()
        CType(Me.picCurrent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDrop.ResumeLayout(False)
        Me.pnlDrop.PerformLayout()
        Me.pnlQLeft.ResumeLayout(False)
        Me.pnlQLeft.PerformLayout()
        CType(Me.picQLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAnswer.ResumeLayout(False)
        Me.pnlAnswer.PerformLayout()
        Me.pnlD.ResumeLayout(False)
        Me.pnlB.ResumeLayout(False)
        Me.pnlC.ResumeLayout(False)
        Me.pnlA.ResumeLayout(False)
        Me.picQuestion.ResumeLayout(False)
        CType(Me.picTree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStrap.ResumeLayout(False)
        CType(Me.picLifeline1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLifeline2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLifeline3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLifeline4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlCorrect As Panel
    Friend WithEvents pnlWrong As Panel
    Friend WithEvents pnlCurrent As Panel
    Friend WithEvents pnlDrop As Panel
    Friend WithEvents pnlQLeft As Panel
    Friend WithEvents picTree As PictureBox
    Friend WithEvents lblCorrect As Label
    Friend WithEvents lblWrong As Label
    Friend WithEvents lblCurrent As Label
    Friend WithEvents lblDrop As Label
    Friend WithEvents lblQLeft As Label
    Friend WithEvents pnlAnswer As Panel
    Friend WithEvents lblAnswer As Label
    Friend WithEvents lblExplainRules As Label
    Friend WithEvents lblWalkedAway As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents txtATAd As TextBox
    Friend WithEvents txtATAc As TextBox
    Friend WithEvents txtATAb As TextBox
    Friend WithEvents txtATAa As TextBox
    Friend WithEvents picCorrect As PictureBox
    Friend WithEvents picWrong As PictureBox
    Friend WithEvents picCurrent As PictureBox
    Friend WithEvents picQLeft As PictureBox
    Friend WithEvents txtExplain As Label
    Friend WithEvents pnlD As Panel
    Friend WithEvents txtD As Label
    Friend WithEvents pnlB As Panel
    Friend WithEvents txtB As Label
    Friend WithEvents pnlC As Panel
    Friend WithEvents txtC As Label
    Friend WithEvents pnlA As Panel
    Friend WithEvents txtA As Label
    Friend WithEvents picQuestion As Panel
    Friend WithEvents txtQuestion As Label
    Friend WithEvents txtWinnings As Label
    Friend WithEvents pnlStrap As Panel
    Friend WithEvents txtWinningStrap As Label
    Friend WithEvents lblHostMsg As TextBox
    Friend WithEvents picLifeline1 As PictureBox
    Friend WithEvents picLifeline2 As PictureBox
    Friend WithEvents picLifeline3 As PictureBox
    Friend WithEvents picLifeline4 As PictureBox
End Class
