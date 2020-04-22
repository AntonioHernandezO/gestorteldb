Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Header

Public Class Form1

    Dim conexion As New SqlConnection
    Dim comando As New SqlCommand
    Public myReader As SqlDataReader
    Private results As String
    Dim sql As String



    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "Data Source=DESKTOP-84FHRG5\SQLEXPRESS01;Initial Catalog=Telmex;Integrated Security=True"
        conexion.Open()
        comando.Connection = conexion





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim snombre As String
        snombre = nombre.Text

        sql = "select Telefono,Paterno,Materno,Nombre,Domicilio,Colonia,Ciudad,Municipio,Entidad,Cp from Clientes where Telefono like '" + telefono.Text.ToString + "%' and Paterno like '" + telefono.Text.ToString + "%'and Materno like '" + materno.Text.ToString + "%' and Nombre like '" + nombre.Text.ToString + "%' and Domicilio like '%' and Colonia like '%' and Ciudad like '%' and Municipio like '%' and Entidad like '%' and Cp like '%'"
        comando = New SqlCommand(sql, conexion)


        'telefono.Clear()
        'paterno.Clear()
        'materno.Clear()
        'nombre.Clear()
        'domicilio.Clear()
        'colonia.Clear()
        'ciudad.Clear()
        'municipio.Clear()
        'entidad.Clear()
        'cp.Clear()


        'comando.ExecuteNonQuery()






        myReader = comando.ExecuteReader()
        While myReader.Read()


            Dim item As New ListViewItem(myReader(0).ToString)
            item.SubItems.Add(myReader(1).ToString)
            item.SubItems.Add(myReader(2).ToString)
            item.SubItems.Add(myReader(3).ToString)
            item.SubItems.Add(myReader(4).ToString)
            item.SubItems.Add(myReader(5).ToString)
            item.SubItems.Add(myReader(6).ToString)
            item.SubItems.Add(myReader(7).ToString)
            item.SubItems.Add(myReader(8).ToString)
            item.SubItems.Add(myReader(9).ToString)
            vista.Items.Add(item)


            'MsgBox(myReader(0).ToString + vbCrLf + myReader(1).ToString + vbCrLf + myReader(2).ToString + vbCrLf + myReader(3).ToString + vbCrLf + myReader(4).ToString + vbCrLf + myReader(5).ToString + vbCrLf + myReader(6).ToString + vbCrLf + myReader(7).ToString + vbCrLf + myReader(8).ToString + vbCrLf + myReader(9).ToString + vbCrLf)

        End While

        myReader.Close()



    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        conexion.Close()

    End Sub

    Private Sub paterno_TextChanged(sender As Object, e As EventArgs) Handles paterno.TextChanged

    End Sub

    Private Sub vista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles vista.SelectedIndexChanged







    End Sub
End Class
