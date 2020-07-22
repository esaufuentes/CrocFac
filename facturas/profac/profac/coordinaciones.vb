Public Class coordinaciones
    Private Sub CoordinacionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CoordinacionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CoordinacionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FacturascDataSet)

    End Sub

    Private Sub coordinaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FacturascDataSet.coordinacion' Puede moverla o quitarla según sea necesario.
        Me.CoordinacionTableAdapter.Fill(Me.FacturascDataSet.coordinacion)

    End Sub
End Class