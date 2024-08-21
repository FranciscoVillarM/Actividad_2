<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        BOTON1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Suma", "Resta", "Multiplicación", "División"})
        ComboBox1.Location = New Point(411, 125)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(153, 23)
        ComboBox1.TabIndex = 0
        ComboBox1.Text = "Suma"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(94, 125)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(119, 23)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(94, 174)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(119, 23)
        TextBox2.TabIndex = 2
        ' 
        ' BOTON1
        ' 
        BOTON1.Location = New Point(411, 166)
        BOTON1.Name = "BOTON1"
        BOTON1.Size = New Size(153, 36)
        BOTON1.TabIndex = 3
        BOTON1.Text = "Calcular"
        BOTON1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(290, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 15)
        Label1.TabIndex = 4
        Label1.Text = "Calculadora"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(94, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 15)
        Label2.TabIndex = 5
        Label2.Text = "Ingrese los números :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(422, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(131, 15)
        Label3.TabIndex = 6
        Label3.Text = "Seleccione la operación"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 133)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 15)
        Label4.TabIndex = 7
        Label4.Text = "Num 1 :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(27, 182)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 15)
        Label5.TabIndex = 8
        Label5.Text = "Num 2 :"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BOTON1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox1)
        Name = "Form1"
        Text = "Actividad Calculadora - Francisco Villar"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BOTON1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
