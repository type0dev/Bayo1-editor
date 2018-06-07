<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XC2MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XC2MainForm))
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.SaveAsFileBtn = New System.Windows.Forms.Button()
        Me.OpenFileBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PlayerInfoEditor = New Bayo1Editor.XC2FieldTypeEditor()
        Me.SuspendLayout()
        '
        'SaveBtn
        '
        Me.SaveBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Location = New System.Drawing.Point(95, 131)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(76, 30)
        Me.SaveBtn.TabIndex = 15
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'SaveAsFileBtn
        '
        Me.SaveAsFileBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveAsFileBtn.Location = New System.Drawing.Point(177, 131)
        Me.SaveAsFileBtn.Name = "SaveAsFileBtn"
        Me.SaveAsFileBtn.Size = New System.Drawing.Size(76, 30)
        Me.SaveAsFileBtn.TabIndex = 14
        Me.SaveAsFileBtn.Text = "Save As..."
        Me.SaveAsFileBtn.UseVisualStyleBackColor = True
        '
        'OpenFileBtn
        '
        Me.OpenFileBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenFileBtn.Location = New System.Drawing.Point(12, 131)
        Me.OpenFileBtn.Name = "OpenFileBtn"
        Me.OpenFileBtn.Size = New System.Drawing.Size(77, 30)
        Me.OpenFileBtn.TabIndex = 13
        Me.OpenFileBtn.Text = "Open"
        Me.OpenFileBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(326, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 30)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Credits"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PlayerInfoEditor
        '
        Me.PlayerInfoEditor.CanEdit = False
        Me.PlayerInfoEditor.CurrentValue = Nothing
        Me.PlayerInfoEditor.DataSource = Nothing
        Me.PlayerInfoEditor.FieldTypeLabel = Nothing
        Me.PlayerInfoEditor.FieldValueLabel = "Value"
        Me.PlayerInfoEditor.Location = New System.Drawing.Point(12, 12)
        Me.PlayerInfoEditor.Name = "PlayerInfoEditor"
        Me.PlayerInfoEditor.Size = New System.Drawing.Size(402, 93)
        Me.PlayerInfoEditor.TabIndex = 16
        '
        'XC2MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 173)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PlayerInfoEditor)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.SaveAsFileBtn)
        Me.Controls.Add(Me.OpenFileBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "XC2MainForm"
        Me.Text = "Bayonetta Save Editor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PlayerInfoEditor As XC2FieldTypeEditor
    Friend WithEvents SaveBtn As Button
    Friend WithEvents SaveAsFileBtn As Button
    Friend WithEvents OpenFileBtn As Button
    Friend WithEvents Button1 As Button
End Class
