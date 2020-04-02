<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomisation
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
        Me.cmbQuarter = New System.Windows.Forms.ComboBox()
        Me.lblQuarter = New System.Windows.Forms.Label()
        Me.lblVamp = New System.Windows.Forms.Label()
        Me.cmbVamp = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cmbQuarter
        '
        Me.cmbQuarter.FormattingEnabled = True
        Me.cmbQuarter.Items.AddRange(New Object() {"White ", "Red", "Blue", "Green", "Yellow", "Dark Grey", "Light Grey", "Black"})
        Me.cmbQuarter.Location = New System.Drawing.Point(178, 99)
        Me.cmbQuarter.Name = "cmbQuarter"
        Me.cmbQuarter.Size = New System.Drawing.Size(121, 21)
        Me.cmbQuarter.TabIndex = 0
        '
        'lblQuarter
        '
        Me.lblQuarter.AutoSize = True
        Me.lblQuarter.Location = New System.Drawing.Point(47, 106)
        Me.lblQuarter.Name = "lblQuarter"
        Me.lblQuarter.Size = New System.Drawing.Size(45, 13)
        Me.lblQuarter.TabIndex = 1
        Me.lblQuarter.Text = "Quarter:"
        '
        'lblVamp
        '
        Me.lblVamp.AutoSize = True
        Me.lblVamp.Location = New System.Drawing.Point(47, 530)
        Me.lblVamp.Name = "lblVamp"
        Me.lblVamp.Size = New System.Drawing.Size(37, 13)
        Me.lblVamp.TabIndex = 2
        Me.lblVamp.Text = "Vamp:"
        '
        'cmbVamp
        '
        Me.cmbVamp.FormattingEnabled = True
        Me.cmbVamp.Items.AddRange(New Object() {"White", "Red ", "Blue", "Green", "Yellow", "Dark Grey", "Light Grey", "Black"})
        Me.cmbVamp.Location = New System.Drawing.Point(178, 522)
        Me.cmbVamp.Name = "cmbVamp"
        Me.cmbVamp.Size = New System.Drawing.Size(121, 21)
        Me.cmbVamp.TabIndex = 3
        '
        'FrmCustomisation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1249, 809)
        Me.Controls.Add(Me.cmbVamp)
        Me.Controls.Add(Me.lblVamp)
        Me.Controls.Add(Me.lblQuarter)
        Me.Controls.Add(Me.cmbQuarter)
        Me.Name = "FrmCustomisation"
        Me.Text = "Customisation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbQuarter As ComboBox
    Friend WithEvents lblQuarter As Label
    Friend WithEvents lblVamp As Label
    Friend WithEvents cmbVamp As ComboBox
End Class
