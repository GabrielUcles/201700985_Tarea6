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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbA = New System.Windows.Forms.Label()
        Me.btnAmenos = New System.Windows.Forms.Button()
        Me.btnAmas = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBmenos = New System.Windows.Forms.Button()
        Me.lbB = New System.Windows.Forms.Label()
        Me.btnBmas = New System.Windows.Forms.Button()
        Me.Sumar = New System.Windows.Forms.Button()
        Me.Restar = New System.Windows.Forms.Button()
        Me.Multiplicar = New System.Windows.Forms.Button()
        Me.Dividir = New System.Windows.Forms.Button()
        Me.lbResultado = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(124, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A"
        '
        'lbA
        '
        Me.lbA.AutoSize = True
        Me.lbA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbA.Location = New System.Drawing.Point(350, 136)
        Me.lbA.Name = "lbA"
        Me.lbA.Size = New System.Drawing.Size(19, 20)
        Me.lbA.TabIndex = 1
        Me.lbA.Text = "0"
        '
        'btnAmenos
        '
        Me.btnAmenos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAmenos.Location = New System.Drawing.Point(216, 133)
        Me.btnAmenos.Name = "btnAmenos"
        Me.btnAmenos.Size = New System.Drawing.Size(75, 29)
        Me.btnAmenos.TabIndex = 2
        Me.btnAmenos.Text = "-"
        Me.btnAmenos.UseVisualStyleBackColor = True
        '
        'btnAmas
        '
        Me.btnAmas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAmas.Location = New System.Drawing.Point(424, 132)
        Me.btnAmas.Name = "btnAmas"
        Me.btnAmas.Size = New System.Drawing.Size(75, 29)
        Me.btnAmas.TabIndex = 3
        Me.btnAmas.Text = "+"
        Me.btnAmas.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(124, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "B"
        '
        'btnBmenos
        '
        Me.btnBmenos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBmenos.Location = New System.Drawing.Point(216, 179)
        Me.btnBmenos.Name = "btnBmenos"
        Me.btnBmenos.Size = New System.Drawing.Size(75, 29)
        Me.btnBmenos.TabIndex = 5
        Me.btnBmenos.Text = "-"
        Me.btnBmenos.UseVisualStyleBackColor = True
        '
        'lbB
        '
        Me.lbB.AutoSize = True
        Me.lbB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbB.Location = New System.Drawing.Point(350, 182)
        Me.lbB.Name = "lbB"
        Me.lbB.Size = New System.Drawing.Size(19, 20)
        Me.lbB.TabIndex = 6
        Me.lbB.Text = "0"
        '
        'btnBmas
        '
        Me.btnBmas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBmas.Location = New System.Drawing.Point(424, 179)
        Me.btnBmas.Name = "btnBmas"
        Me.btnBmas.Size = New System.Drawing.Size(75, 29)
        Me.btnBmas.TabIndex = 7
        Me.btnBmas.Text = "+"
        Me.btnBmas.UseVisualStyleBackColor = True
        '
        'Sumar
        '
        Me.Sumar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Sumar.Location = New System.Drawing.Point(561, 93)
        Me.Sumar.Name = "Sumar"
        Me.Sumar.Size = New System.Drawing.Size(90, 29)
        Me.Sumar.TabIndex = 8
        Me.Sumar.Text = "Sumar"
        Me.Sumar.UseVisualStyleBackColor = True
        '
        'Restar
        '
        Me.Restar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Restar.Location = New System.Drawing.Point(561, 133)
        Me.Restar.Name = "Restar"
        Me.Restar.Size = New System.Drawing.Size(90, 29)
        Me.Restar.TabIndex = 9
        Me.Restar.Text = "Restar"
        Me.Restar.UseVisualStyleBackColor = True
        '
        'Multiplicar
        '
        Me.Multiplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Multiplicar.Location = New System.Drawing.Point(561, 173)
        Me.Multiplicar.Name = "Multiplicar"
        Me.Multiplicar.Size = New System.Drawing.Size(90, 29)
        Me.Multiplicar.TabIndex = 10
        Me.Multiplicar.Text = "Multiplicar"
        Me.Multiplicar.UseVisualStyleBackColor = True
        '
        'Dividir
        '
        Me.Dividir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Dividir.Location = New System.Drawing.Point(561, 213)
        Me.Dividir.Name = "Dividir"
        Me.Dividir.Size = New System.Drawing.Size(90, 29)
        Me.Dividir.TabIndex = 11
        Me.Dividir.Text = "Dividir"
        Me.Dividir.UseVisualStyleBackColor = True
        '
        'lbResultado
        '
        Me.lbResultado.AutoSize = True
        Me.lbResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbResultado.Location = New System.Drawing.Point(315, 290)
        Me.lbResultado.Name = "lbResultado"
        Me.lbResultado.Size = New System.Drawing.Size(161, 25)
        Me.lbResultado.TabIndex = 13
        Me.lbResultado.Text = "El resultado es:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(268, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(269, 37)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "CALCULADORA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(22, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "201700985"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbResultado)
        Me.Controls.Add(Me.Dividir)
        Me.Controls.Add(Me.Multiplicar)
        Me.Controls.Add(Me.Restar)
        Me.Controls.Add(Me.Sumar)
        Me.Controls.Add(Me.btnBmas)
        Me.Controls.Add(Me.lbB)
        Me.Controls.Add(Me.btnBmenos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAmas)
        Me.Controls.Add(Me.btnAmenos)
        Me.Controls.Add(Me.lbA)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbA As Label
    Friend WithEvents btnAmenos As Button
    Friend WithEvents btnAmas As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBmenos As Button
    Friend WithEvents lbB As Label
    Friend WithEvents btnBmas As Button
    Friend WithEvents Sumar As Button
    Friend WithEvents Restar As Button
    Friend WithEvents Multiplicar As Button
    Friend WithEvents Dividir As Button
    Friend WithEvents lbResultado As Label
    Friend WithEvents Label6 As Label
    Private Sub btnAmenos_Click(sender As Object, e As EventArgs) Handles btnAmenos.Click
        Dim numeroentrante As String = lbA.Text
        lbA.Text = Resta(numeroentrante)
    End Sub

    Private Sub btnBmenos_Click(sender As Object, e As EventArgs) Handles btnBmenos.Click
        Dim numeroentrante As String = lbB.Text
        lbB.Text = Resta(numeroentrante)
    End Sub

    Function Resta(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevotexto As String
        numero = numero - 1
        nuevotexto = numero.ToString()
        Return numero
    End Function
    Private Sub btnAmas_Click(sender As Object, e As EventArgs) Handles btnAmas.Click
        Dim numeroentrante As String = lbA.Text
        lbA.Text = Aumentar(numeroentrante)
    End Sub

    Private Sub btnBmas_Click(sender As Object, e As EventArgs) Handles btnBmas.Click
        Dim numeroentrante As String = lbB.Text
        lbB.Text = Aumentar(numeroentrante)
    End Sub

    Function Aumentar(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevotexto As String
        numero = numero + 1
        nuevotexto = numero.ToString()
        Return numero
    End Function

    Private Sub Suma_Click(sender As Object, e As EventArgs) Handles Sumar.Click
        Dim txtA = lbA.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = lbB.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadoSuma = Suma(numA, numB)
        lbResultado.Text = "El resultado de A + B es: " + resultadoSuma.ToString()
    End Sub
    Function Suma(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA + numB
        Return resultado
    End Function

    Private Sub Restar_Click(sender As Object, e As EventArgs) Handles Restar.Click
        Dim txtA = lbA.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = lbB.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadoResta = Resta(numA, numB)
        lbResultado.Text = "El resultado de A - B es: " + resultadoResta.ToString()
    End Sub
    Function Resta(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA - numB
        Return resultado
    End Function
    Private Sub Multiplicar_Click(sender As Object, e As EventArgs) Handles Multiplicar.Click
        Dim txtA = lbA.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = lbB.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadoMultiplicación = Multiplicación(numA, numB)
        lbResultado.Text = "El resultado de A * B es: " + resultadoMultiplicación.ToString()
    End Sub
    Function Multiplicación(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA * numB
        Return resultado
    End Function
    Private Sub Dividir_Click(sender As Object, e As EventArgs) Handles Dividir.Click
        Dim txtA = lbA.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = lbB.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadoDivisión = División(numA, numB)
        lbResultado.Text = "El resultado de A / B es: " + resultadoDivisión.ToString()
    End Sub
    Function División(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA / numB
        Return resultado
    End Function

    Friend WithEvents Label2 As Label
End Class
