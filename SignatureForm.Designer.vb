﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignatureForm
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
        Me.pBoxSignature = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.pBoxSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pBoxSignature
        '
        Me.pBoxSignature.BackColor = System.Drawing.Color.White
        Me.pBoxSignature.Location = New System.Drawing.Point(3, 2)
        Me.pBoxSignature.Name = "pBoxSignature"
        Me.pBoxSignature.Size = New System.Drawing.Size(500, 500)
        Me.pBoxSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxSignature.TabIndex = 0
        Me.pBoxSignature.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(179, 508)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(260, 508)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SignatureForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 534)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pBoxSignature)
        Me.Name = "SignatureForm"
        Me.Text = "SignatureForm"
        CType(Me.pBoxSignature, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pBoxSignature As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
