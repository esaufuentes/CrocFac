Imports System.Data.SqlClient

Public Class facturas
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub EstatusBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EstatusBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FacturascDataSet)

    End Sub

    Private Sub facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtfexha_TextChanged(sender As Object, e As EventArgs) Handles txtfexha.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim fecha As Date
        fecha = Format(DateTimePicker1.Value, "Short Date")
        txtfexha.Text = fecha
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As String
        conexion = "Data Source=ESAU-PC\MSQLSERVER;Initial Catalog=facturasc;User ID=sa;Password=E.sau1234"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlDataAdapter("select * from empresa where idempresa =" & txtcempresa.Text & "", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")

        If ds.Tables("datos").Rows.Count > 0 Then
            txtempresa.Text = ds.Tables("datos").Rows(0).Item(1).ToString
            txtrazon.Text = ds.Tables("datos").Rows(0).Item(2).ToString
            txtestado.Text = ds.Tables("datos").Rows(0).Item(3).ToString


        Else
            MsgBox("EL ID DE LA EMPRESA O LA EMPRESA NO EXISTEN")



        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim conexion As String
        conexion = "Data Source=ESAU-PC\MSQLSERVER;Initial Catalog=facturasc;User ID=sa;Password=E.sau1234"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlDataAdapter("select * from conseptos where idconseptos =" & txtconceptos.Text & "", cn)
        Dim dsc As New DataSet
        adaptador.Fill(dsc, "datosc")

        If dsc.Tables("datosc").Rows.Count > 0 Then


            txtdescrip.Text = dsc.Tables("datosc").Rows(0).Item(1).ToString
            txtprecio.Text = dsc.Tables("datosc").Rows(0).Item(2).ToString



        Else
            MsgBox("EL SERVICIO NO EXISTE FAVOR DE DARLO DE ALTA EN LA SECCIÓN DE CONSEPTOS")
        End If
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles txtidcoor.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim conexion As String
        conexion = "Data Source=ESAU-PC\MSQLSERVER;Initial Catalog=facturasc;User ID=sa;Password=E.sau1234"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlDataAdapter("select * from coordinacion where idcoordinacion =" & txtidcoor.Text & "", cn)
        Dim dscor As New DataSet
        adaptador.Fill(dscor, "datosco")

        If dscor.Tables("datosco").Rows.Count > 0 Then


            txtnombrecor.Text = dscor.Tables("datosco").Rows(0).Item(1).ToString




        Else
            MsgBox("EL Coordinador no Esta Dado de Alta")
        End If
    End Sub
End Class