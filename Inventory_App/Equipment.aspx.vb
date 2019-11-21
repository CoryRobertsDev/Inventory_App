Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class Equipment
    Inherits System.Web.UI.Page
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("ConString").ConnectionString
    Private strConn As String = connectionString
    Private sqlCon As SqlConnection
    Public errorString As String
    Public dynamicString As String

    Sub Main()
    End Sub


    Private Sub InsertNewRecord()
        sqlCon = New SqlConnection(strConn)

        Using (sqlCon)

            Dim sqlComm As New SqlCommand()

            sqlComm.Connection = sqlCon

            sqlComm.CommandText = "SYS_INSERT_EQUIPMENT"
            sqlComm.CommandType = CommandType.StoredProcedure

            sqlComm.Parameters.AddWithValue("@EQUIP_TYPE", txtEQUIP_TYPE.Text)
            sqlComm.Parameters.AddWithValue("@VENDOR", txtVENDOR.Text)
            sqlComm.Parameters.AddWithValue("@MANUFACTURER", txtMANUFACTURER.Text)
            sqlComm.Parameters.AddWithValue("@MODEL", txtMODEL.Text)
            sqlComm.Parameters.AddWithValue("@SUB_MODEL", txtSUB_MODEL.Text)
            sqlComm.Parameters.AddWithValue("@SERIAL_NUM", txtSERIAL_NUM.Text)
            sqlComm.Parameters.AddWithValue("@UC_SERIAL_NUM", txtUC_SERIAL_NUM.Text)
            sqlComm.Parameters.AddWithValue("@INVOICE_NUM", txtUC_SERIAL_NUM.Text)
            sqlComm.Parameters.AddWithValue("@DATE_RECEIVED", DateTime.Parse(txtDATE_RECEIVED.Text))
            sqlComm.Parameters.AddWithValue("@REQUESTING_DEPT", txtREQUESTING_DEP.Text)
            sqlComm.Parameters.AddWithValue("@REQUESTED_BY", txtREQUESTED_BY.Text)
            sqlComm.Parameters.AddWithValue("@WARRANTY", txtWARRANTY.Text)


            sqlCon.Open()

            sqlComm.ExecuteNonQuery()



        End Using

    End Sub

    Private Sub UpdateRecord()
        sqlCon = New SqlConnection(strConn)

        Using (sqlCon)

            Dim sqlComm As New SqlCommand With {
                .Connection = sqlCon,
                .CommandText = "SYS_UPDATE_EQUIPMENT",
                .CommandType = CommandType.StoredProcedure
            }


            sqlComm.Parameters.AddWithValue("@EQUIP_TYPE", txtEQUIP_TYPE.Text)
            sqlComm.Parameters.AddWithValue("@VENDOR", txtVENDOR.Text)
            sqlComm.Parameters.AddWithValue("@MANUFACTURER", txtMANUFACTURER.Text)
            sqlComm.Parameters.AddWithValue("@MODEL", txtMODEL.Text)
            sqlComm.Parameters.AddWithValue("@SUB_MODEL", txtSUB_MODEL.Text)
            sqlComm.Parameters.AddWithValue("@SERIAL_NUM", txtSERIAL_NUM.Text)
            sqlComm.Parameters.AddWithValue("@UC_SERIAL_NUM", txtUC_SERIAL_NUM.Text)
            sqlComm.Parameters.AddWithValue("@INVOICE_NUM", txtUC_SERIAL_NUM.Text)
            sqlComm.Parameters.AddWithValue("@DATE_RECEIVED", DateTime.Parse(txtDATE_RECEIVED.Text))
            sqlComm.Parameters.AddWithValue("@REQUESTING_DEPT", txtREQUESTING_DEP.Text)
            sqlComm.Parameters.AddWithValue("@REQUESTED_BY", txtREQUESTED_BY.Text)
            sqlComm.Parameters.AddWithValue("@DECOMISSION_STATUS", txtWARRANTY.Text)
            sqlComm.Parameters.AddWithValue("@DECOMISSION_DATE", txtWARRANTY.Text)
            sqlComm.Parameters.AddWithValue("@DESTROY_STATUS", txtWARRANTY.Text)
            sqlComm.Parameters.AddWithValue("@DESTROY_DATE", txtWARRANTY.Text)

            sqlCon.Open()

            sqlComm.ExecuteNonQuery()

        End Using

    End Sub

    Protected Sub Submit_Click(ByVal sender As Object, ByVal e As EventArgs)
        'EXECUTES INSERT STORED PROCEDURE ON CLICK
        InsertNewRecord()
    End Sub

    Protected Sub BtnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs)
        'EXECUTES UPDATE STORED PROCEDURE ON CLICK
        UpdateRecord()
    End Sub

    'Protected Sub BtnSearch_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    'EXECUTES SEARCH ON CLICK
    '    sqlCon = New SqlConnection(strConn)


    '    Using (sqlCon)

    '        Dim sqlComm As New SqlCommand With {
    '            .Connection = sqlCon,
    '            .CommandText = "dbo.PAGE_EQUIPMENT",
    '            .CommandType = CommandType.StoredProcedure
    '        }

    '        sqlCon.Open()

    '        sqlComm.ExecuteNonQuery()

    '    End Using

    'End Sub



    'Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load



    '    Dim con As New SqlConnection(connectionString)

    '    Dim slct_ds As String = "Select * from Equipment_Information"

    '    Dim ds As New DataSet


    '    Try
    '        Dim myDataAdapter As New SqlDataAdapter(slct_ds, connectionString)
    '        myDataAdapter.Fill(ds)

    '        If ds.Tables.Count > 0 Then
    '            If ds.Tables(0).Rows.Count > 0 Then
    '                If Not IsDBNull(ds.Tables(0).Rows(0).Item(0)) Then
    '                    For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
    '                        dynamicString = dynamicString & "<article class=""card"">"
    '                        dynamicString = dynamicString & "<div class=""card-content"" >"
    '                        dynamicString = dynamicString & "<li class=""list-group-item"">"
    '                        dynamicString = dynamicString & "<B>EQUIPMENT ID: </B>"
    '                        dynamicString = dynamicString & ds.Tables(0).Rows(i).Item(0)
    '                        dynamicString = dynamicString & "</a>"
    '                        dynamicString = dynamicString & "</li>"
    '                        dynamicString = dynamicString & "<li class=""list-group-item"">"
    '                        dynamicString = dynamicString & "<B>TYPE: </B>"
    '                        dynamicString = dynamicString & ds.Tables(0).Rows(i).Item(1)
    '                        dynamicString = dynamicString & "</a>"
    '                        dynamicString = dynamicString & "</li>"
    '                        dynamicString = dynamicString & "<li class=""list-group-item"">"
    '                        dynamicString = dynamicString & "<B>VENDOR: </B>"
    '                        dynamicString = dynamicString & ds.Tables(0).Rows(i).Item(2)
    '                        dynamicString = dynamicString & "</a>"
    '                        dynamicString = dynamicString & "</li>"
    '                        dynamicString = dynamicString & "<li class=""list-group-item"">"
    '                        dynamicString = dynamicString & "<B>MANUFACTURER: </B>"
    '                        dynamicString = dynamicString & ds.Tables(0).Rows(i).Item(3)
    '                        dynamicString = dynamicString & "</a>"
    '                        dynamicString = dynamicString & "</li>"
    '                        dynamicString = dynamicString & "<li class=""list-group-item"">"
    '                        dynamicString = dynamicString & "<B>MODEL: </B>"
    '                        dynamicString = dynamicString & ds.Tables(0).Rows(i).Item(4)
    '                        dynamicString = dynamicString & "</li>"
    '                        dynamicString = dynamicString & "<li class=""list-group-item"">"
    '                        dynamicString = dynamicString & "<B>SUB-MODEL: </B>"
    '                        dynamicString = dynamicString & ds.Tables(0).Rows(i).Item(5)
    '                        dynamicString = dynamicString & "</a>"
    '                        dynamicString = dynamicString & "</li>"
    '                        dynamicString = dynamicString & "<li class=""list-group-item"">"
    '                        dynamicString = dynamicString & "<B>SERIAL #: </B>"
    '                        dynamicString = dynamicString & ds.Tables(0).Rows(i).Item(6)
    '                        dynamicString = dynamicString & "</a>"
    '                        dynamicString = dynamicString & "</li>"
    '                        dynamicString = dynamicString & "<li class=""list-group-item"">"
    '                        dynamicString = dynamicString & "<B>UC SERIAL #: </B>"
    '                        dynamicString = dynamicString & ds.Tables(0).Rows(i).Item(7)
    '                        dynamicString = dynamicString & "</a>"
    '                        dynamicString = dynamicString & "</li>"
    '                        dynamicString = dynamicString & "<li class=""list-group-item"">"
    '                        dynamicString = dynamicString & "<B>INVOICE #: </B>"
    '                        dynamicString = dynamicString & ds.Tables(0).Rows(i).Item(8)
    '                        dynamicString = dynamicString & "</a>"
    '                        dynamicString = dynamicString & "</li>"
    '                        dynamicString = dynamicString & "<li class=""list-group-item"">"
    '                        dynamicString = dynamicString & "<B>DATE: </B>"
    '                        dynamicString = dynamicString & ds.Tables(0).Rows(i).Item(9)
    '                        dynamicString = dynamicString & "</a>"
    '                        dynamicString = dynamicString & "</li>"
    '                        dynamicString = dynamicString & "<li class=""list-group-item"">"
    '                        dynamicString = dynamicString & "<B>REQUESTING DEPT: </B>"
    '                        dynamicString = dynamicString & ds.Tables(0).Rows(i).Item(10)
    '                        dynamicString = dynamicString & "</a>"
    '                        dynamicString = dynamicString & "</li>"
    '                        dynamicString = dynamicString & "<li class=""list-group-item"">"
    '                        dynamicString = dynamicString & "<B>REQUESTED BY: </B>"
    '                        dynamicString = dynamicString & ds.Tables(0).Rows(i).Item(11)
    '                        dynamicString = dynamicString & "</a>"
    '                        dynamicString = dynamicString & "</li>"
    '                        dynamicString = dynamicString & "<li class=""list-group-item"">"
    '                        dynamicString = dynamicString & "<B>WARRANTY: </B>"
    '                        dynamicString = dynamicString & ds.Tables(0).Rows(i).Item(12)
    '                        dynamicString = dynamicString & "</a>"
    '                        dynamicString = dynamicString & "</li>"
    '                        dynamicString = dynamicString & "<li class=""list-group-item"">"
    '                        dynamicString = dynamicString & "<B>DECOMISSION DATE: </B>"
    '                        dynamicString = dynamicString & ds.Tables(0).Rows(i).Item(13)
    '                        dynamicString = dynamicString & "</a>"
    '                        dynamicString = dynamicString & "</li>"
    '                        dynamicString = dynamicString & "<li class=""list-group-item"">"
    '                        dynamicString = dynamicString & "<B>DECOMISSION DATE: </B>"
    '                        dynamicString = dynamicString & ds.Tables(0).Rows(i).Item(14)
    '                        dynamicString = dynamicString & "</a>"
    '                        dynamicString = dynamicString & "</li>"
    '                        dynamicString = dynamicString & "<li class=""list-group-item"">"
    '                        dynamicString = dynamicString & "<B>DESTROY STATUS: </B>"
    '                        dynamicString = dynamicString & ds.Tables(0).Rows(i).Item(15)
    '                        dynamicString = dynamicString & "</a>"
    '                        dynamicString = dynamicString & "</li>"
    '                        dynamicString = dynamicString & "<li class=""list-group-item"">"
    '                        dynamicString = dynamicString & "<B>DESTROY DATE: </B>"
    '                        dynamicString = dynamicString & ds.Tables(0).Rows(i).Item(16)
    '                        dynamicString = dynamicString & "</a> </li> </ul> </p> "
    '                        dynamicString = dynamicString & "</div><!-- .card-content -->"
    '                        dynamicString = dynamicString & "</a>"
    '                        dynamicString = dynamicString & "</article>"
    '                        dynamicString = dynamicString & "<!-- .card -->"
    '                    Next
    '                Else errorString = errorString & "The table returned a null item.."
    '                End If
    '            Else errorString = errorString & "The table returned a null row.."
    '            End If
    '        Else errorString = errorString & "The table failed to load."
    '        End If

    '    Catch ex As Exception
    '        errorString = errorString & "The server failed to respond!"
    '    End Try
    'End Sub

End Class
