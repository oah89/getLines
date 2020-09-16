Imports System.Data.SQLite
Module PublicData
    Public mySqliteConnexion As SQLiteConnection
    Public datasource As SqliteDataAcces
    Public currentUser As user

    Sub OpenSqliteConnexion()
        Try
            If mySqliteConnexion.State = 0 Then
                mySqliteConnexion.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub CloseSqliteConnexion()
        Try
            If mySqliteConnexion.State = 1 Then
                mySqliteConnexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub SetDgColumnModeFill(ByVal dg As DataGridView)
        For conter = 0 To dg.ColumnCount - 1
            dg.Columns(conter).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dg.Columns(conter).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dg.RowHeadersDefaultCellStyle.BackColor = Color.MediumPurple
        Next
        SetDgColumnDgWidth(dg, 1, 20)
        SetDgColumnDgWidth(dg, 4, 50)
        SetDgColumnDgWidth(dg, 6, 60)
        SetDgColumnDgWidth(dg, 7, 60)
    End Sub
    Sub SetDgColumnDgWidth(ByVal dg As DataGridView, ByVal index As Integer, ByVal width As Integer)
        dg.Columns(index).Width = width
    End Sub



    Sub SetDgColumnModeFill2(ByVal dg As DataGridView, num As Integer)
        For conter = 0 To dg.ColumnCount - 1
            dg.Columns(conter).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dg.Columns(conter).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dg.RowHeadersDefaultCellStyle.BackColor = Color.MediumPurple
        Next
        SetDgColumnDgWidth(dg, num, 40)
        'SetDgColumnDgWidth(dg, 4, 50)
        'SetDgColumnDgWidth(dg, 6, 60)
        'SetDgColumnDgWidth(dg, 7, 60)
    End Sub

    Public Function dateToText(value As Date) As String
        Dim result As String = ""
        Try
            result = value.Day & "-" & value.Month & "-" & value.Year
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result
    End Function
End Module
