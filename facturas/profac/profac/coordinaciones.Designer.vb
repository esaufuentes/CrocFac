<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class coordinaciones
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
        Dim IdcoordinacionLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(coordinaciones))
        Me.FacturascDataSet = New profac.facturascDataSet()
        Me.CoordinacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CoordinacionTableAdapter = New profac.facturascDataSetTableAdapters.coordinacionTableAdapter()
        Me.TableAdapterManager = New profac.facturascDataSetTableAdapters.TableAdapterManager()
        Me.CoordinacionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CoordinacionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdcoordinacionTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.CorreoTextBox = New System.Windows.Forms.TextBox()
        Me.CoordinacionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        IdcoordinacionLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        CType(Me.FacturascDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoordinacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoordinacionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CoordinacionBindingNavigator.SuspendLayout()
        CType(Me.CoordinacionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdcoordinacionLabel
        '
        IdcoordinacionLabel.AutoSize = True
        IdcoordinacionLabel.Location = New System.Drawing.Point(267, 83)
        IdcoordinacionLabel.Name = "IdcoordinacionLabel"
        IdcoordinacionLabel.Size = New System.Drawing.Size(90, 13)
        IdcoordinacionLabel.TabIndex = 1
        IdcoordinacionLabel.Text = "COORDINACION"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(303, 106)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(54, 13)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "NOMBRE"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(293, 132)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(64, 13)
        TelefonoLabel.TabIndex = 5
        TelefonoLabel.Text = "TELEFONO"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(291, 158)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(66, 13)
        DireccionLabel.TabIndex = 7
        DireccionLabel.Text = "DIRECCION"
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.Location = New System.Drawing.Point(303, 187)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(53, 13)
        CorreoLabel.TabIndex = 9
        CorreoLabel.Text = "CORREO"
        '
        'FacturascDataSet
        '
        Me.FacturascDataSet.DataSetName = "facturascDataSet"
        Me.FacturascDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CoordinacionBindingSource
        '
        Me.CoordinacionBindingSource.DataMember = "coordinacion"
        Me.CoordinacionBindingSource.DataSource = Me.FacturascDataSet
        '
        'CoordinacionTableAdapter
        '
        Me.CoordinacionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.conseptosTableAdapter = Nothing
        Me.TableAdapterManager.coordinacionTableAdapter = Me.CoordinacionTableAdapter
        Me.TableAdapterManager.empresaTableAdapter = Nothing
        Me.TableAdapterManager.estatusTableAdapter = Nothing
        Me.TableAdapterManager.facturasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = profac.facturascDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CoordinacionBindingNavigator
        '
        Me.CoordinacionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CoordinacionBindingNavigator.BindingSource = Me.CoordinacionBindingSource
        Me.CoordinacionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CoordinacionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CoordinacionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CoordinacionBindingNavigatorSaveItem})
        Me.CoordinacionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CoordinacionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CoordinacionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CoordinacionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CoordinacionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CoordinacionBindingNavigator.Name = "CoordinacionBindingNavigator"
        Me.CoordinacionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CoordinacionBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.CoordinacionBindingNavigator.TabIndex = 0
        Me.CoordinacionBindingNavigator.Text = "BindingNavigator1"
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
        'CoordinacionBindingNavigatorSaveItem
        '
        Me.CoordinacionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CoordinacionBindingNavigatorSaveItem.Image = CType(resources.GetObject("CoordinacionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CoordinacionBindingNavigatorSaveItem.Name = "CoordinacionBindingNavigatorSaveItem"
        Me.CoordinacionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CoordinacionBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdcoordinacionTextBox
        '
        Me.IdcoordinacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CoordinacionBindingSource, "idcoordinacion", True))
        Me.IdcoordinacionTextBox.Location = New System.Drawing.Point(374, 80)
        Me.IdcoordinacionTextBox.Name = "IdcoordinacionTextBox"
        Me.IdcoordinacionTextBox.Size = New System.Drawing.Size(70, 20)
        Me.IdcoordinacionTextBox.TabIndex = 2
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CoordinacionBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(374, 106)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(242, 20)
        Me.NombreTextBox.TabIndex = 4
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CoordinacionBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(374, 132)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 6
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CoordinacionBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(374, 158)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(242, 20)
        Me.DireccionTextBox.TabIndex = 8
        '
        'CorreoTextBox
        '
        Me.CorreoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CoordinacionBindingSource, "correo", True))
        Me.CorreoTextBox.Location = New System.Drawing.Point(374, 184)
        Me.CorreoTextBox.Name = "CorreoTextBox"
        Me.CorreoTextBox.Size = New System.Drawing.Size(242, 20)
        Me.CorreoTextBox.TabIndex = 10
        '
        'CoordinacionDataGridView
        '
        Me.CoordinacionDataGridView.AutoGenerateColumns = False
        Me.CoordinacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CoordinacionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.CoordinacionDataGridView.DataSource = Me.CoordinacionBindingSource
        Me.CoordinacionDataGridView.Location = New System.Drawing.Point(32, 257)
        Me.CoordinacionDataGridView.Name = "CoordinacionDataGridView"
        Me.CoordinacionDataGridView.Size = New System.Drawing.Size(688, 220)
        Me.CoordinacionDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idcoordinacion"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID COORDINACION"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 220
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 220
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn3.HeaderText = "TELEFONO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DIRECCION"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "correo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CORREO"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = Global.profac.My.Resources.Resources.antorcha
        Me.PictureBox13.Location = New System.Drawing.Point(32, 78)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(208, 123)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 12
        Me.PictureBox13.TabStop = False
        '
        'coordinaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(800, 579)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.CoordinacionDataGridView)
        Me.Controls.Add(IdcoordinacionLabel)
        Me.Controls.Add(Me.IdcoordinacionTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(CorreoLabel)
        Me.Controls.Add(Me.CorreoTextBox)
        Me.Controls.Add(Me.CoordinacionBindingNavigator)
        Me.Name = "coordinaciones"
        Me.Text = "COORDINACIONES"
        CType(Me.FacturascDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoordinacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoordinacionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CoordinacionBindingNavigator.ResumeLayout(False)
        Me.CoordinacionBindingNavigator.PerformLayout()
        CType(Me.CoordinacionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FacturascDataSet As facturascDataSet
    Friend WithEvents CoordinacionBindingSource As BindingSource
    Friend WithEvents CoordinacionTableAdapter As facturascDataSetTableAdapters.coordinacionTableAdapter
    Friend WithEvents TableAdapterManager As facturascDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CoordinacionBindingNavigator As BindingNavigator
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
    Friend WithEvents CoordinacionBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdcoordinacionTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents CorreoTextBox As TextBox
    Friend WithEvents CoordinacionDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox13 As PictureBox
End Class
