<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empresas
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
        Me.components = New System.ComponentModel.Container()
        Dim IdempresaLabel As System.Windows.Forms.Label
        Dim NombreemLabel As System.Windows.Forms.Label
        Dim RazonsemLabel As System.Windows.Forms.Label
        Dim EstadoemLabel As System.Windows.Forms.Label
        Dim DireccionemLabel As System.Windows.Forms.Label
        Dim TelefonoemLabel As System.Windows.Forms.Label
        Dim CorreoeleemLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(empresas))
        Me.FacturascDataSet = New profac.facturascDataSet()
        Me.EmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresaTableAdapter = New profac.facturascDataSetTableAdapters.empresaTableAdapter()
        Me.TableAdapterManager = New profac.facturascDataSetTableAdapters.TableAdapterManager()
        Me.EmpresaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EmpresaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdempresaTextBox = New System.Windows.Forms.TextBox()
        Me.NombreemTextBox = New System.Windows.Forms.TextBox()
        Me.RazonsemTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoemTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionemTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoemTextBox = New System.Windows.Forms.TextBox()
        Me.CorreoeleemTextBox = New System.Windows.Forms.TextBox()
        Me.EmpresaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        IdempresaLabel = New System.Windows.Forms.Label()
        NombreemLabel = New System.Windows.Forms.Label()
        RazonsemLabel = New System.Windows.Forms.Label()
        EstadoemLabel = New System.Windows.Forms.Label()
        DireccionemLabel = New System.Windows.Forms.Label()
        TelefonoemLabel = New System.Windows.Forms.Label()
        CorreoeleemLabel = New System.Windows.Forms.Label()
        CType(Me.FacturascDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpresaBindingNavigator.SuspendLayout()
        CType(Me.EmpresaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdempresaLabel
        '
        IdempresaLabel.AutoSize = True
        IdempresaLabel.Location = New System.Drawing.Point(273, 35)
        IdempresaLabel.Name = "IdempresaLabel"
        IdempresaLabel.Size = New System.Drawing.Size(73, 13)
        IdempresaLabel.TabIndex = 1
        IdempresaLabel.Text = "ID EMPRESA"
        '
        'NombreemLabel
        '
        NombreemLabel.AutoSize = True
        NombreemLabel.Location = New System.Drawing.Point(273, 61)
        NombreemLabel.Name = "NombreemLabel"
        NombreemLabel.Size = New System.Drawing.Size(109, 13)
        NombreemLabel.TabIndex = 3
        NombreemLabel.Text = "NOMBRE EMPRESA"
        '
        'RazonsemLabel
        '
        RazonsemLabel.AutoSize = True
        RazonsemLabel.Location = New System.Drawing.Point(273, 90)
        RazonsemLabel.Name = "RazonsemLabel"
        RazonsemLabel.Size = New System.Drawing.Size(86, 13)
        RazonsemLabel.TabIndex = 5
        RazonsemLabel.Text = "RAZON SOCIAL"
        '
        'EstadoemLabel
        '
        EstadoemLabel.AutoSize = True
        EstadoemLabel.Location = New System.Drawing.Point(273, 119)
        EstadoemLabel.Name = "EstadoemLabel"
        EstadoemLabel.Size = New System.Drawing.Size(51, 13)
        EstadoemLabel.TabIndex = 7
        EstadoemLabel.Text = "ESTADO"
        '
        'DireccionemLabel
        '
        DireccionemLabel.AutoSize = True
        DireccionemLabel.Location = New System.Drawing.Point(273, 149)
        DireccionemLabel.Name = "DireccionemLabel"
        DireccionemLabel.Size = New System.Drawing.Size(66, 13)
        DireccionemLabel.TabIndex = 9
        DireccionemLabel.Text = "DIRECCIÓN"
        '
        'TelefonoemLabel
        '
        TelefonoemLabel.AutoSize = True
        TelefonoemLabel.Location = New System.Drawing.Point(273, 186)
        TelefonoemLabel.Name = "TelefonoemLabel"
        TelefonoemLabel.Size = New System.Drawing.Size(64, 13)
        TelefonoemLabel.TabIndex = 11
        TelefonoemLabel.Text = "TELEFONO"
        '
        'CorreoeleemLabel
        '
        CorreoeleemLabel.AutoSize = True
        CorreoeleemLabel.Location = New System.Drawing.Point(250, 215)
        CorreoeleemLabel.Name = "CorreoeleemLabel"
        CorreoeleemLabel.Size = New System.Drawing.Size(132, 13)
        CorreoeleemLabel.TabIndex = 13
        CorreoeleemLabel.Text = "CORREO ELECTRONICO"
        '
        'FacturascDataSet
        '
        Me.FacturascDataSet.DataSetName = "facturascDataSet"
        Me.FacturascDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpresaBindingSource
        '
        Me.EmpresaBindingSource.DataMember = "empresa"
        Me.EmpresaBindingSource.DataSource = Me.FacturascDataSet
        '
        'EmpresaTableAdapter
        '
        Me.EmpresaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.conseptosTableAdapter = Nothing
        Me.TableAdapterManager.coordinacionTableAdapter = Nothing
        Me.TableAdapterManager.empresaTableAdapter = Me.EmpresaTableAdapter
        Me.TableAdapterManager.estatusTableAdapter = Nothing
        Me.TableAdapterManager.facturasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = profac.facturascDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmpresaBindingNavigator
        '
        Me.EmpresaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpresaBindingNavigator.BindingSource = Me.EmpresaBindingSource
        Me.EmpresaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpresaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpresaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpresaBindingNavigatorSaveItem})
        Me.EmpresaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpresaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpresaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpresaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpresaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpresaBindingNavigator.Name = "EmpresaBindingNavigator"
        Me.EmpresaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpresaBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.EmpresaBindingNavigator.TabIndex = 0
        Me.EmpresaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'EmpresaBindingNavigatorSaveItem
        '
        Me.EmpresaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpresaBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpresaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmpresaBindingNavigatorSaveItem.Name = "EmpresaBindingNavigatorSaveItem"
        Me.EmpresaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EmpresaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdempresaTextBox
        '
        Me.IdempresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "idempresa", True))
        Me.IdempresaTextBox.Location = New System.Drawing.Point(403, 28)
        Me.IdempresaTextBox.Name = "IdempresaTextBox"
        Me.IdempresaTextBox.Size = New System.Drawing.Size(57, 20)
        Me.IdempresaTextBox.TabIndex = 2
        '
        'NombreemTextBox
        '
        Me.NombreemTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "nombreem", True))
        Me.NombreemTextBox.Location = New System.Drawing.Point(403, 61)
        Me.NombreemTextBox.Name = "NombreemTextBox"
        Me.NombreemTextBox.Size = New System.Drawing.Size(255, 20)
        Me.NombreemTextBox.TabIndex = 4
        '
        'RazonsemTextBox
        '
        Me.RazonsemTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "razonsem", True))
        Me.RazonsemTextBox.Location = New System.Drawing.Point(403, 87)
        Me.RazonsemTextBox.Name = "RazonsemTextBox"
        Me.RazonsemTextBox.Size = New System.Drawing.Size(255, 20)
        Me.RazonsemTextBox.TabIndex = 6
        '
        'EstadoemTextBox
        '
        Me.EstadoemTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "estadoem", True))
        Me.EstadoemTextBox.Location = New System.Drawing.Point(403, 116)
        Me.EstadoemTextBox.Name = "EstadoemTextBox"
        Me.EstadoemTextBox.Size = New System.Drawing.Size(108, 20)
        Me.EstadoemTextBox.TabIndex = 8
        '
        'DireccionemTextBox
        '
        Me.DireccionemTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "direccionem", True))
        Me.DireccionemTextBox.Location = New System.Drawing.Point(403, 146)
        Me.DireccionemTextBox.Name = "DireccionemTextBox"
        Me.DireccionemTextBox.Size = New System.Drawing.Size(187, 20)
        Me.DireccionemTextBox.TabIndex = 10
        '
        'TelefonoemTextBox
        '
        Me.TelefonoemTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "telefonoem", True))
        Me.TelefonoemTextBox.Location = New System.Drawing.Point(403, 179)
        Me.TelefonoemTextBox.Name = "TelefonoemTextBox"
        Me.TelefonoemTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoemTextBox.TabIndex = 12
        '
        'CorreoeleemTextBox
        '
        Me.CorreoeleemTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "correoeleem", True))
        Me.CorreoeleemTextBox.Location = New System.Drawing.Point(403, 212)
        Me.CorreoeleemTextBox.Name = "CorreoeleemTextBox"
        Me.CorreoeleemTextBox.Size = New System.Drawing.Size(187, 20)
        Me.CorreoeleemTextBox.TabIndex = 14
        '
        'EmpresaDataGridView
        '
        Me.EmpresaDataGridView.AutoGenerateColumns = False
        Me.EmpresaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpresaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.EmpresaDataGridView.DataSource = Me.EmpresaBindingSource
        Me.EmpresaDataGridView.Location = New System.Drawing.Point(24, 245)
        Me.EmpresaDataGridView.Name = "EmpresaDataGridView"
        Me.EmpresaDataGridView.Size = New System.Drawing.Size(746, 220)
        Me.EmpresaDataGridView.TabIndex = 15
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idempresa"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idempresa"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombreem"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombreem"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "razonsem"
        Me.DataGridViewTextBoxColumn3.HeaderText = "razonsem"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "estadoem"
        Me.DataGridViewTextBoxColumn4.HeaderText = "estadoem"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "direccionem"
        Me.DataGridViewTextBoxColumn5.HeaderText = "direccionem"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "telefonoem"
        Me.DataGridViewTextBoxColumn6.HeaderText = "telefonoem"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "correoeleem"
        Me.DataGridViewTextBoxColumn7.HeaderText = "correoeleem"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = Global.profac.My.Resources.Resources.antorcha
        Me.PictureBox13.Location = New System.Drawing.Point(24, 39)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(208, 123)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 16
        Me.PictureBox13.TabStop = False
        '
        'empresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(800, 545)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.EmpresaDataGridView)
        Me.Controls.Add(IdempresaLabel)
        Me.Controls.Add(Me.IdempresaTextBox)
        Me.Controls.Add(NombreemLabel)
        Me.Controls.Add(Me.NombreemTextBox)
        Me.Controls.Add(RazonsemLabel)
        Me.Controls.Add(Me.RazonsemTextBox)
        Me.Controls.Add(EstadoemLabel)
        Me.Controls.Add(Me.EstadoemTextBox)
        Me.Controls.Add(DireccionemLabel)
        Me.Controls.Add(Me.DireccionemTextBox)
        Me.Controls.Add(TelefonoemLabel)
        Me.Controls.Add(Me.TelefonoemTextBox)
        Me.Controls.Add(CorreoeleemLabel)
        Me.Controls.Add(Me.CorreoeleemTextBox)
        Me.Controls.Add(Me.EmpresaBindingNavigator)
        Me.Name = "empresas"
        Me.Text = "EMPRESAS"
        CType(Me.FacturascDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpresaBindingNavigator.ResumeLayout(False)
        Me.EmpresaBindingNavigator.PerformLayout()
        CType(Me.EmpresaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FacturascDataSet As facturascDataSet
    Friend WithEvents EmpresaBindingSource As BindingSource
    Friend WithEvents EmpresaTableAdapter As facturascDataSetTableAdapters.empresaTableAdapter
    Friend WithEvents TableAdapterManager As facturascDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpresaBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents EmpresaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdempresaTextBox As TextBox
    Friend WithEvents NombreemTextBox As TextBox
    Friend WithEvents RazonsemTextBox As TextBox
    Friend WithEvents EstadoemTextBox As TextBox
    Friend WithEvents DireccionemTextBox As TextBox
    Friend WithEvents TelefonoemTextBox As TextBox
    Friend WithEvents CorreoeleemTextBox As TextBox
    Friend WithEvents EmpresaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox13 As PictureBox
End Class
