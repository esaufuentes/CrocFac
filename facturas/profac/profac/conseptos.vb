Public Class conseptos
    Private Sub ConseptosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ConseptosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ConseptosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FacturascDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FacturascDataSet.conseptos' Puede moverla o quitarla según sea necesario.
        Me.ConseptosTableAdapter.Fill(Me.FacturascDataSet.conseptos)

    End Sub
End Class