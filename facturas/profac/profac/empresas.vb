Public Class empresas
    Private Sub EmpresaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpresaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpresaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FacturascDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FacturascDataSet.empresa' Puede moverla o quitarla según sea necesario.
        Me.EmpresaTableAdapter.Fill(Me.FacturascDataSet.empresa)

    End Sub
End Class