<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Dim Nombre_del_productoLabel As System.Windows.Forms.Label
        Dim Precio_Del_ProductoLabel As System.Windows.Forms.Label
        Dim Unidades_disponiblesLabel As System.Windows.Forms.Label
        Me.Database1DataSet = New App.Database1DataSet()
        Me.Tabla1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tabla1TableAdapter = New App.Database1DataSetTableAdapters.Tabla1TableAdapter()
        Me.TableAdapterManager = New App.Database1DataSetTableAdapters.TableAdapterManager()
        Me.Tabla1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Tabla1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tabla1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_del_productoTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_Del_ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.Unidades_disponiblesTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Nombre_del_productoLabel = New System.Windows.Forms.Label()
        Precio_Del_ProductoLabel = New System.Windows.Forms.Label()
        Unidades_disponiblesLabel = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabla1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabla1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabla1BindingNavigator.SuspendLayout()
        CType(Me.Tabla1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tabla1BindingSource
        '
        Me.Tabla1BindingSource.DataMember = "Tabla1"
        Me.Tabla1BindingSource.DataSource = Me.Database1DataSet
        '
        'Tabla1TableAdapter
        '
        Me.Tabla1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Tabla1TableAdapter = Me.Tabla1TableAdapter
        Me.TableAdapterManager.UpdateOrder = App.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tabla1BindingNavigator
        '
        Me.Tabla1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tabla1BindingNavigator.BindingSource = Me.Tabla1BindingSource
        Me.Tabla1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tabla1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tabla1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tabla1BindingNavigatorSaveItem})
        Me.Tabla1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tabla1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tabla1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tabla1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tabla1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tabla1BindingNavigator.Name = "Tabla1BindingNavigator"
        Me.Tabla1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tabla1BindingNavigator.Size = New System.Drawing.Size(582, 25)
        Me.Tabla1BindingNavigator.TabIndex = 0
        Me.Tabla1BindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'Tabla1BindingNavigatorSaveItem
        '
        Me.Tabla1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tabla1BindingNavigatorSaveItem.Image = CType(resources.GetObject("Tabla1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tabla1BindingNavigatorSaveItem.Name = "Tabla1BindingNavigatorSaveItem"
        Me.Tabla1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Tabla1BindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Tabla1DataGridView
        '
        Me.Tabla1DataGridView.AutoGenerateColumns = False
        Me.Tabla1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Tabla1DataGridView.DataSource = Me.Tabla1BindingSource
        Me.Tabla1DataGridView.Location = New System.Drawing.Point(79, 191)
        Me.Tabla1DataGridView.Name = "Tabla1DataGridView"
        Me.Tabla1DataGridView.Size = New System.Drawing.Size(397, 167)
        Me.Tabla1DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Nombre del producto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre del producto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Precio Del Producto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Precio Del Producto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "unidades disponibles"
        Me.DataGridViewTextBoxColumn3.HeaderText = "unidades disponibles"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Nombre_del_productoLabel
        '
        Nombre_del_productoLabel.AutoSize = True
        Nombre_del_productoLabel.Location = New System.Drawing.Point(76, 59)
        Nombre_del_productoLabel.Name = "Nombre_del_productoLabel"
        Nombre_del_productoLabel.Size = New System.Drawing.Size(109, 13)
        Nombre_del_productoLabel.TabIndex = 2
        Nombre_del_productoLabel.Text = "Nombre del producto:"
        '
        'Nombre_del_productoTextBox
        '
        Me.Nombre_del_productoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Nombre del producto", True))
        Me.Nombre_del_productoTextBox.Location = New System.Drawing.Point(197, 52)
        Me.Nombre_del_productoTextBox.Name = "Nombre_del_productoTextBox"
        Me.Nombre_del_productoTextBox.Size = New System.Drawing.Size(278, 20)
        Me.Nombre_del_productoTextBox.TabIndex = 3
        '
        'Precio_Del_ProductoLabel
        '
        Precio_Del_ProductoLabel.AutoSize = True
        Precio_Del_ProductoLabel.Location = New System.Drawing.Point(76, 106)
        Precio_Del_ProductoLabel.Name = "Precio_Del_ProductoLabel"
        Precio_Del_ProductoLabel.Size = New System.Drawing.Size(105, 13)
        Precio_Del_ProductoLabel.TabIndex = 4
        Precio_Del_ProductoLabel.Text = "Precio Del Producto:"
        '
        'Precio_Del_ProductoTextBox
        '
        Me.Precio_Del_ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "Precio Del Producto", True))
        Me.Precio_Del_ProductoTextBox.Location = New System.Drawing.Point(197, 99)
        Me.Precio_Del_ProductoTextBox.Name = "Precio_Del_ProductoTextBox"
        Me.Precio_Del_ProductoTextBox.Size = New System.Drawing.Size(278, 20)
        Me.Precio_Del_ProductoTextBox.TabIndex = 5
        '
        'Unidades_disponiblesLabel
        '
        Unidades_disponiblesLabel.AutoSize = True
        Unidades_disponiblesLabel.Location = New System.Drawing.Point(76, 157)
        Unidades_disponiblesLabel.Name = "Unidades_disponiblesLabel"
        Unidades_disponiblesLabel.Size = New System.Drawing.Size(108, 13)
        Unidades_disponiblesLabel.TabIndex = 6
        Unidades_disponiblesLabel.Text = "unidades disponibles:"
        '
        'Unidades_disponiblesTextBox
        '
        Me.Unidades_disponiblesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tabla1BindingSource, "unidades disponibles", True))
        Me.Unidades_disponiblesTextBox.Location = New System.Drawing.Point(197, 150)
        Me.Unidades_disponiblesTextBox.Name = "Unidades_disponiblesTextBox"
        Me.Unidades_disponiblesTextBox.Size = New System.Drawing.Size(278, 20)
        Me.Unidades_disponiblesTextBox.TabIndex = 7
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(400, 383)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 38)
        Me.Button3.TabIndex = 49
        Me.Button3.Text = "menú"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 449)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Unidades_disponiblesLabel)
        Me.Controls.Add(Me.Unidades_disponiblesTextBox)
        Me.Controls.Add(Precio_Del_ProductoLabel)
        Me.Controls.Add(Me.Precio_Del_ProductoTextBox)
        Me.Controls.Add(Nombre_del_productoLabel)
        Me.Controls.Add(Me.Nombre_del_productoTextBox)
        Me.Controls.Add(Me.Tabla1DataGridView)
        Me.Controls.Add(Me.Tabla1BindingNavigator)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabla1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabla1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabla1BindingNavigator.ResumeLayout(False)
        Me.Tabla1BindingNavigator.PerformLayout()
        CType(Me.Tabla1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents Tabla1BindingSource As BindingSource
    Friend WithEvents Tabla1TableAdapter As Database1DataSetTableAdapters.Tabla1TableAdapter
    Friend WithEvents TableAdapterManager As Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tabla1BindingNavigator As BindingNavigator
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
    Friend WithEvents Tabla1BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tabla1DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_del_productoTextBox As TextBox
    Friend WithEvents Precio_Del_ProductoTextBox As TextBox
    Friend WithEvents Unidades_disponiblesTextBox As TextBox
    Friend WithEvents Button3 As Button
End Class
