<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class conseptos
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
        Dim IdconseptosLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim DetallesLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(conseptos))
        Me.FacturascDataSet = New profac.facturascDataSet()
        Me.ConseptosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConseptosTableAdapter = New profac.facturascDataSetTableAdapters.conseptosTableAdapter()
        Me.TableAdapterManager = New profac.facturascDataSetTableAdapters.TableAdapterManager()
        Me.ConseptosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ConseptosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdconseptosTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.DetallesTextBox = New System.Windows.Forms.TextBox()
        Me.ConseptosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        IdconseptosLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        DetallesLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        CType(Me.FacturascDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConseptosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConseptosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConseptosBindingNavigator.SuspendLayout()
        CType(Me.ConseptosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdconseptosLabel
        '
        IdconseptosLabel.AutoSize = True
        IdconseptosLabel.Location = New System.Drawing.Point(381, 89)
        IdconseptosLabel.Name = "IdconseptosLabel"
        IdconseptosLabel.Size = New System.Drawing.Size(78, 13)
        IdconseptosLabel.TabIndex = 1
        IdconseptosLabel.Text = "ID SERVICIOS"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(421, 168)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(47, 13)
        PrecioLabel.TabIndex = 5
        PrecioLabel.Text = "PRECIO"
        '
        'DetallesLabel
        '
        DetallesLabel.AutoSize = True
        DetallesLabel.Location = New System.Drawing.Point(320, 196)
        DetallesLabel.Name = "DetallesLabel"
        DetallesLabel.Size = New System.Drawing.Size(136, 13)
        DetallesLabel.TabIndex = 7
        DetallesLabel.Text = "DETALLES ADICIONALES"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(379, 111)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(80, 13)
        DescripcionLabel.TabIndex = 9
        DescripcionLabel.Text = "DESCRIPCION"
        '
        'FacturascDataSet
        '
        Me.FacturascDataSet.DataSetName = "facturascDataSet"
        Me.FacturascDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConseptosBindingSource
        '
        Me.ConseptosBindingSource.DataMember = "conseptos"
        Me.ConseptosBindingSource.DataSource = Me.FacturascDataSet
        '
        'ConseptosTableAdapter
        '
        Me.ConseptosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.conseptosTableAdapter = Me.ConseptosTableAdapter
        Me.TableAdapterManager.coordinacionTableAdapter = Nothing
        Me.TableAdapterManager.empresaTableAdapter = Nothing
        Me.TableAdapterManager.estatusTableAdapter = Nothing
        Me.TableAdapterManager.facturasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = profac.facturascDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ConseptosBindingNavigator
        '
        Me.ConseptosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ConseptosBindingNavigator.BindingSource = Me.ConseptosBindingSource
        Me.ConseptosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ConseptosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ConseptosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ConseptosBindingNavigatorSaveItem})
        Me.ConseptosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ConseptosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ConseptosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ConseptosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ConseptosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ConseptosBindingNavigator.Name = "ConseptosBindingNavigator"
        Me.ConseptosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ConseptosBindingNavigator.Size = New System.Drawing.Size(926, 25)
        Me.ConseptosBindingNavigator.TabIndex = 0
        Me.ConseptosBindingNavigator.Text = "BindingNavigator1"
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
        'ConseptosBindingNavigatorSaveItem
        '
        Me.ConseptosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ConseptosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ConseptosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ConseptosBindingNavigatorSaveItem.Name = "ConseptosBindingNavigatorSaveItem"
        Me.ConseptosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ConseptosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdconseptosTextBox
        '
        Me.IdconseptosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConseptosBindingSource, "idconseptos", True))
        Me.IdconseptosTextBox.Location = New System.Drawing.Point(465, 86)
        Me.IdconseptosTextBox.Name = "IdconseptosTextBox"
        Me.IdconseptosTextBox.Size = New System.Drawing.Size(86, 20)
        Me.IdconseptosTextBox.TabIndex = 2
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConseptosBindingSource, "precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(469, 165)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(82, 20)
        Me.PrecioTextBox.TabIndex = 6
        '
        'DetallesTextBox
        '
        Me.DetallesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConseptosBindingSource, "detalles", True))
        Me.DetallesTextBox.Location = New System.Drawing.Point(465, 193)
        Me.DetallesTextBox.Name = "DetallesTextBox"
        Me.DetallesTextBox.Size = New System.Drawing.Size(194, 20)
        Me.DetallesTextBox.TabIndex = 8
        '
        'ConseptosDataGridView
        '
        Me.ConseptosDataGridView.AutoGenerateColumns = False
        Me.ConseptosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConseptosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ConseptosDataGridView.DataSource = Me.ConseptosBindingSource
        Me.ConseptosDataGridView.Location = New System.Drawing.Point(12, 341)
        Me.ConseptosDataGridView.Name = "ConseptosDataGridView"
        Me.ConseptosDataGridView.Size = New System.Drawing.Size(901, 220)
        Me.ConseptosDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idconseptos"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID CONSEPTOS"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DESCRIPCION"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 450
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 450
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PRECIO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "detalles"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DETALLES"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 200
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConseptosBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(465, 112)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(322, 20)
        Me.DescripcionTextBox.TabIndex = 10
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = Global.profac.My.Resources.Resources.antorcha
        Me.PictureBox13.Location = New System.Drawing.Point(47, 85)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(208, 123)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 11
        Me.PictureBox13.TabStop = False
        '
        'conseptos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(926, 581)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.ConseptosDataGridView)
        Me.Controls.Add(IdconseptosLabel)
        Me.Controls.Add(Me.IdconseptosTextBox)
        Me.Controls.Add(PrecioLabel)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Controls.Add(DetallesLabel)
        Me.Controls.Add(Me.DetallesTextBox)
        Me.Controls.Add(Me.ConseptosBindingNavigator)
        Me.Name = "conseptos"
        Me.Text = "Form1"
        CType(Me.FacturascDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConseptosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConseptosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConseptosBindingNavigator.ResumeLayout(False)
        Me.ConseptosBindingNavigator.PerformLayout()
        CType(Me.ConseptosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FacturascDataSet As facturascDataSet
    Friend WithEvents ConseptosBindingSource As BindingSource
    Friend WithEvents ConseptosTableAdapter As facturascDataSetTableAdapters.conseptosTableAdapter
    Friend WithEvents TableAdapterManager As facturascDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ConseptosBindingNavigator As BindingNavigator
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
    Friend WithEvents ConseptosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdconseptosTextBox As TextBox
    Friend WithEvents PrecioTextBox As TextBox
    Friend WithEvents DetallesTextBox As TextBox
    Friend WithEvents ConseptosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents PictureBox13 As PictureBox
End Class
