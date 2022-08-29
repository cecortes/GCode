<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PnlCOM = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboBaud = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPtos = New System.Windows.Forms.ComboBox()
        Me.PnlCOM.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlCOM
        '
        Me.PnlCOM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlCOM.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PnlCOM.Controls.Add(Me.Label2)
        Me.PnlCOM.Controls.Add(Me.cboBaud)
        Me.PnlCOM.Controls.Add(Me.Label1)
        Me.PnlCOM.Controls.Add(Me.cboPtos)
        Me.PnlCOM.Font = New System.Drawing.Font("Noto Sans", 12.0!)
        Me.PnlCOM.Location = New System.Drawing.Point(12, 12)
        Me.PnlCOM.Name = "PnlCOM"
        Me.PnlCOM.Size = New System.Drawing.Size(982, 104)
        Me.PnlCOM.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(272, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Baud:"
        '
        'cboBaud
        '
        Me.cboBaud.FormattingEnabled = True
        Me.cboBaud.Items.AddRange(New Object() {"9600", "14400", "19200", "38400", "57600", "115200"})
        Me.cboBaud.Location = New System.Drawing.Point(352, 10)
        Me.cboBaud.Name = "cboBaud"
        Me.cboBaud.Size = New System.Drawing.Size(161, 35)
        Me.cboBaud.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "COM:"
        '
        'cboPtos
        '
        Me.cboPtos.FormattingEnabled = True
        Me.cboPtos.Location = New System.Drawing.Point(84, 10)
        Me.cboPtos.Name = "cboPtos"
        Me.cboPtos.Size = New System.Drawing.Size(161, 35)
        Me.cboPtos.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.PnlCOM)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GCode (C) César López 2022"
        Me.PnlCOM.ResumeLayout(False)
        Me.PnlCOM.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlCOM As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cboPtos As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboBaud As ComboBox
End Class
