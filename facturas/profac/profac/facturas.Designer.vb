<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class facturas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcempresa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtempresa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtrazon = New System.Windows.Forms.TextBox()
        Me.txtestado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtconceptos = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtdescrip = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtidcoor = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtnombrecor = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.FacturascDataSet = New profac.facturascDataSet()
        Me.EstatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstatusTableAdapter = New profac.facturascDataSetTableAdapters.estatusTableAdapter()
        Me.TableAdapterManager = New profac.facturascDataSetTableAdapters.TableAdapterManager()
        Me.IdestatusComboBox = New System.Windows.Forms.ComboBox()
        Me.EstatusBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtfexha = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturascDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstatusBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 246)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(844, 163)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "NOMBRE DE LA EMPRESA"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "RAZON SOCIAL"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "ESTADO"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "CONSEPTO"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "DESCRIPCION"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "PRECIO"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "CANTIDAD"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "NOMBRE"
        Me.Column8.Name = "Column8"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(638, 415)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(561, 418)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TOTAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(525, 480)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SERIE LETRA"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(637, 477)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(168, 12)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(82, 20)
        Me.TextBox3.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(105, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "FACTURA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(275, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ID DE EMPRESA"
        '
        'txtcempresa
        '
        Me.txtcempresa.BackColor = System.Drawing.Color.DarkOrange
        Me.txtcempresa.Location = New System.Drawing.Point(372, 95)
        Me.txtcempresa.Name = "txtcempresa"
        Me.txtcempresa.Size = New System.Drawing.Size(100, 20)
        Me.txtcempresa.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(223, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "NOMBRE DE LA EMPRESA"
        '
        'txtempresa
        '
        Me.txtempresa.BackColor = System.Drawing.SystemColors.Window
        Me.txtempresa.Location = New System.Drawing.Point(372, 124)
        Me.txtempresa.Name = "txtempresa"
        Me.txtempresa.Size = New System.Drawing.Size(242, 20)
        Me.txtempresa.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(275, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "RAZON SOCIAL"
        '
        'txtrazon
        '
        Me.txtrazon.Location = New System.Drawing.Point(372, 158)
        Me.txtrazon.Name = "txtrazon"
        Me.txtrazon.Size = New System.Drawing.Size(242, 20)
        Me.txtrazon.TabIndex = 12
        '
        'txtestado
        '
        Me.txtestado.Location = New System.Drawing.Point(372, 194)
        Me.txtestado.Name = "txtestado"
        Me.txtestado.Size = New System.Drawing.Size(151, 20)
        Me.txtestado.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(300, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "ESTADO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(650, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "ID CONSEPTO"
        '
        'txtconceptos
        '
        Me.txtconceptos.BackColor = System.Drawing.Color.DarkOrange
        Me.txtconceptos.Location = New System.Drawing.Point(736, 66)
        Me.txtconceptos.Name = "txtconceptos"
        Me.txtconceptos.Size = New System.Drawing.Size(72, 20)
        Me.txtconceptos.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(650, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "DESCRIPCION"
        '
        'txtdescrip
        '
        Me.txtdescrip.Location = New System.Drawing.Point(736, 100)
        Me.txtdescrip.Name = "txtdescrip"
        Me.txtdescrip.Size = New System.Drawing.Size(151, 20)
        Me.txtdescrip.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(679, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "PRECIO"
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(736, 134)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(72, 20)
        Me.txtprecio.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(478, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(828, 66)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(650, 177)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "DELEGACION"
        '
        'txtidcoor
        '
        Me.txtidcoor.BackColor = System.Drawing.Color.DarkOrange
        Me.txtidcoor.Location = New System.Drawing.Point(736, 171)
        Me.txtidcoor.Name = "txtidcoor"
        Me.txtidcoor.Size = New System.Drawing.Size(76, 20)
        Me.txtidcoor.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(651, 211)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "NOMBRE"
        '
        'txtnombrecor
        '
        Me.txtnombrecor.Location = New System.Drawing.Point(736, 207)
        Me.txtnombrecor.Name = "txtnombrecor"
        Me.txtnombrecor.Size = New System.Drawing.Size(151, 20)
        Me.txtnombrecor.TabIndex = 26
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(818, 168)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Buscar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(128, 428)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 29
        Me.Button4.Text = "AGREGAR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(209, 428)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 30
        Me.Button5.Text = "GUARDAR"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(561, 447)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "ESTATUS"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(299, 428)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 33
        Me.Button6.Text = "FACTURAR"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(380, 428)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(124, 23)
        Me.Button7.TabIndex = 34
        Me.Button7.Text = "NUEVA FACTURA"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = Global.profac.My.Resources.Resources.antorcha
        Me.PictureBox13.Location = New System.Drawing.Point(12, 48)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(208, 123)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 35
        Me.PictureBox13.TabStop = False
        '
        'FacturascDataSet
        '
        Me.FacturascDataSet.DataSetName = "facturascDataSet"
        Me.FacturascDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstatusBindingSource
        '
        Me.EstatusBindingSource.DataMember = "estatus"
        Me.EstatusBindingSource.DataSource = Me.FacturascDataSet
        '
        'EstatusTableAdapter
        '
        Me.EstatusTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.conseptosTableAdapter = Nothing
        Me.TableAdapterManager.coordinacionTableAdapter = Nothing
        Me.TableAdapterManager.empresaTableAdapter = Nothing
        Me.TableAdapterManager.estatusTableAdapter = Me.EstatusTableAdapter
        Me.TableAdapterManager.facturasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = profac.facturascDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdestatusComboBox
        '
        Me.IdestatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstatusBindingSource, "idestatus", True))
        Me.IdestatusComboBox.DataSource = Me.EstatusBindingSource1
        Me.IdestatusComboBox.DisplayMember = "nombre"
        Me.IdestatusComboBox.FormattingEnabled = True
        Me.IdestatusComboBox.Location = New System.Drawing.Point(638, 447)
        Me.IdestatusComboBox.Name = "IdestatusComboBox"
        Me.IdestatusComboBox.Size = New System.Drawing.Size(119, 21)
        Me.IdestatusComboBox.TabIndex = 37
        '
        'EstatusBindingSource1
        '
        Me.EstatusBindingSource1.DataMember = "estatus"
        Me.EstatusBindingSource1.DataSource = Me.FacturascDataSet
        '
        'txtfexha
        '
        Me.txtfexha.Location = New System.Drawing.Point(803, 8)
        Me.txtfexha.Name = "txtfexha"
        Me.txtfexha.Size = New System.Drawing.Size(100, 20)
        Me.txtfexha.TabIndex = 38
        Me.txtfexha.Visible = False
        '
        'Timer1
        '
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(584, 9)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 39
        '
        'facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(923, 521)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtfexha)
        Me.Controls.Add(Me.IdestatusComboBox)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtnombrecor)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtidcoor)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtdescrip)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtconceptos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtestado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtrazon)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtempresa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcempresa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "facturas"
        Me.Text = "FACTURA"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturascDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstatusBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcempresa As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtempresa As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtrazon As TextBox
    Friend WithEvents txtestado As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtconceptos As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtdescrip As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents txtidcoor As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtnombrecor As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents FacturascDataSet As facturascDataSet
    Friend WithEvents EstatusBindingSource As BindingSource
    Friend WithEvents EstatusTableAdapter As facturascDataSetTableAdapters.estatusTableAdapter
    Friend WithEvents TableAdapterManager As facturascDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdestatusComboBox As ComboBox
    Friend WithEvents EstatusBindingSource1 As BindingSource
    Friend WithEvents txtfexha As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
