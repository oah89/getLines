Imports System.Configuration
Imports System.Data
Imports System.Data.SQLite
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Public Class SqliteDataAcces
    Public Sub addGroupe(num As String, name As String)

        OpenSqliteConnexion()
        Try
            Const insertSql As String = "INSERT INTO groupes (numGroup,groupName)  VALUES (@num, @name);"
            Dim addCmd = New SQLiteCommand(insertSql, mySqliteConnexion)
            addCmd.Parameters.AddWithValue("@num", num)
            addCmd.Parameters.AddWithValue("@name", name.Replace("'", "@_@"))


            addCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("addGroupe" & vbNewLine & ex.Message)
        End Try

        CloseSqliteConnexion()
    End Sub

    Friend Sub updateGroupe(num As String, name As String, id As Object)

        OpenSqliteConnexion()
        Try
            Const insertSql As String = "UPDATE groupes SET numGroup=@num ,groupName=@name  where idGroup=@id;"
            Dim addCmd = New SQLiteCommand(insertSql, mySqliteConnexion)
            addCmd.Parameters.AddWithValue("@num", num)
            addCmd.Parameters.AddWithValue("@name", name.Replace("'", "@_@"))
            addCmd.Parameters.AddWithValue("@id", id)


            addCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("addGroupe" & vbNewLine & ex.Message)
        End Try

        CloseSqliteConnexion()
    End Sub

    Friend Sub updateLogin(oldUser As user, newUser As user)
        OpenSqliteConnexion()
        Try
            Const insertSql As String = "UPDATE  logins set login=@newLogin,password= @newPassword where login=@oldLogin and password= @oldPassword;"
            Dim addCmd = New SQLiteCommand(insertSql, mySqliteConnexion)
            addCmd.Parameters.AddWithValue("@newLogin", newUser.login.Replace("'", "@_@"))
            addCmd.Parameters.AddWithValue("@newPassword", newUser.password.Replace("'", "@_@"))
            addCmd.Parameters.AddWithValue("@oldLogin", oldUser.login)
            addCmd.Parameters.AddWithValue("@oldPassword", oldUser.password)


            addCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("addPerson" & vbNewLine & ex.Message)
        End Try

        CloseSqliteConnexion()
    End Sub

    Public Sub addPerson(person As Person)

        OpenSqliteConnexion()
        Try
            Const insertSql As String = "INSERT INTO persons (cin,nameFirst,nameFamily,adresse)  VALUES (@cin, @nameFirst, @nameFamily,@adresse);"
            Dim addCmd = New SQLiteCommand(insertSql, mySqliteConnexion)
            addCmd.Parameters.AddWithValue("@cin", person.cin.Replace(" ", ""))
            addCmd.Parameters.AddWithValue("@nameFirst", person.nameFirst)
            addCmd.Parameters.AddWithValue("@nameFamily", person.nameFamily)
            addCmd.Parameters.AddWithValue("@adresse", person.adresse)

            addCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("addPerson" & vbNewLine & ex.Message)
        End Try

        CloseSqliteConnexion()
    End Sub
    Public Sub updatePerson(person As Person)
        OpenSqliteConnexion()
        Try
            Const insertSql As String = "UPDATE  persons set cin=@cin,nameFirst= @nameFirst,nameFamily=@nameFamily,adresse=@adresse where idPerson =@id;"
            Dim addCmd = New SQLiteCommand(insertSql, mySqliteConnexion)
            addCmd.Parameters.AddWithValue("@cin", person.cin.Replace(" ", ""))
            addCmd.Parameters.AddWithValue("@nameFirst", person.nameFirst)
            addCmd.Parameters.AddWithValue("@nameFamily", person.nameFamily)
            addCmd.Parameters.AddWithValue("@adresse", person.adresse)
            addCmd.Parameters.AddWithValue("@id", person.idPerson)

            addCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("addPerson" & vbNewLine & ex.Message)
        End Try

        CloseSqliteConnexion()
    End Sub

    Public Sub deletePerson(id As Integer)

        OpenSqliteConnexion()
        Try
            Dim insertSql As String = "delete from persons where   idPerson =" & id & ";"
            Dim addCmd = New SQLiteCommand(insertSql, mySqliteConnexion)
            MsgBox(insertSql)
            '  addCmd.Parameters.AddWithValue("@cin", )
            'addCmd.Parameters.AddWithValue("@id", id)
            'MsgBox(addCmd.)
            addCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("deletePerson" & vbNewLine & ex.Message)
        End Try

        CloseSqliteConnexion()
    End Sub
    Public Sub retirerPerson(idPerson As Integer, idGroup As Integer, statut As String, dateRetirer As String)
        '
        OpenSqliteConnexion()
        Try
            Dim insertSql As String = "DELETE FROM workers WHERE idPerson=@idPerson and idGroup=@idGroup and statut=@statut; INSERT INTO retraites (idPerson,idGroup,statut,dateRetraite) values (@idPerson,@idGroup,@statut,@dateRetraite);"
            Dim addCmd = New SQLiteCommand(insertSql, mySqliteConnexion)
            addCmd.Parameters.AddWithValue("@idPerson", idPerson)
            addCmd.Parameters.AddWithValue("@idGroup", idGroup)
            addCmd.Parameters.AddWithValue("@statut", statut)
            addCmd.Parameters.AddWithValue("@dateRetraite", dateRetirer)
            addCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("deletePerson" & vbNewLine & ex.Message)
        End Try

        CloseSqliteConnexion()
    End Sub


    Public Function getLogin(login As String, password As String) As user
        Dim result As user = Nothing
        Dim sqlite_cmd As SQLiteCommand
        Dim sqlite_datareader As SQLiteDataReader
        OpenSqliteConnexion()
        sqlite_cmd = mySqliteConnexion.CreateCommand()
        sqlite_cmd.CommandText = "select login,password from logins where login='" & login.Replace("'", "@_@") & "' and password='" & password.Replace("'", "@_@") & "'"
        sqlite_datareader = sqlite_cmd.ExecuteReader()
        While (sqlite_datareader.Read())
            result = New user(sqlite_datareader.GetString(0).ToString, sqlite_datareader.GetString(1))
        End While
        CloseSqliteConnexion()
        Return result
    End Function

    Public Function checkPersonExist(cin As String) As Person
        Dim result As Person = Nothing
        Dim sqlite_cmd As SQLiteCommand
        Dim sqlite_datareader As SQLiteDataReader
        OpenSqliteConnexion()
        sqlite_cmd = mySqliteConnexion.CreateCommand()
        sqlite_cmd.CommandText = "select idPerson,cin,nameFirst,nameFamily,adresse,isChef from persons where LOWER(cin)='" & cin.Replace(" ", "").Replace("'", "@_@") & "'"
        sqlite_datareader = sqlite_cmd.ExecuteReader()
        While (sqlite_datareader.Read())
            result = New Person(sqlite_datareader.GetInt16(0), sqlite_datareader.GetString(1).ToString, sqlite_datareader.GetString(2), sqlite_datareader.GetString(3), sqlite_datareader.GetString(4), sqlite_datareader.GetBoolean(5))
        End While
        CloseSqliteConnexion()
        Return result
    End Function


    Public Function getListPerson(Optional condition As String = "") As List(Of Person)
        Dim lst As New List(Of Person)
        Dim sqlite_cmd As SQLiteCommand
        Dim sqlite_datareader As SQLiteDataReader
        OpenSqliteConnexion()
        Try
            sqlite_cmd = mySqliteConnexion.CreateCommand()
            sqlite_cmd.CommandText = "SELECT idPerson,cin,nameFirst,nameFamily,adresse FROM persons " & condition
            ' MsgBox(sqlite_cmd.CommandText)
            sqlite_datareader = sqlite_cmd.ExecuteReader()
            While (sqlite_datareader.Read())
                lst.Add(New Person(sqlite_datareader.GetInt16(0), sqlite_datareader.GetString(1).ToString, sqlite_datareader.GetString(2), sqlite_datareader.GetString(3), sqlite_datareader.GetString(4)))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CloseSqliteConnexion()
        Return lst
    End Function

    Public Function getListPersonNotInWork(condition As String) As List(Of Person)
        Dim lst As New List(Of Person)
        Dim sqlite_cmd As SQLiteCommand
        Dim sqlite_datareader As SQLiteDataReader
        OpenSqliteConnexion()
        Try
            sqlite_cmd = mySqliteConnexion.CreateCommand()
            sqlite_cmd.CommandText = "select p.idPerson,p.cin,p.nameFirst,p.nameFamily FROM persons p WHERE  p.idPerson not in( select idPerson from workers)" & condition
            ' MsgBox(sqlite_cmd.CommandText)
            sqlite_datareader = sqlite_cmd.ExecuteReader()
            While (sqlite_datareader.Read())
                Dim p = New Person()
                p.idPerson = sqlite_datareader.GetInt16(0)
                p.cin = sqlite_datareader.GetString(1).ToString
                p.nameFamily = sqlite_datareader.GetString(3).ToString
                p.nameFirst = sqlite_datareader.GetString(2).ToString
                lst.Add(p)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CloseSqliteConnexion()
        Return lst
    End Function



    Public Function getListGroupe() As List(Of Groupe)
        Dim lst As New List(Of Groupe)
        Dim sqlite_cmd As SQLiteCommand
        Dim sqlite_datareader As SQLiteDataReader
        OpenSqliteConnexion()
        Try

            sqlite_cmd = mySqliteConnexion.CreateCommand()
            sqlite_cmd.CommandText = "SELECT idGroup,numGroup,groupName FROM groupes "
            ' MsgBox(sqlite_cmd.CommandText)
            sqlite_datareader = sqlite_cmd.ExecuteReader()
            While (sqlite_datareader.Read())
                lst.Add(New Groupe(sqlite_datareader.GetInt16(0), sqlite_datareader.GetString(1), sqlite_datareader.GetString(2).Replace("@_@", "'")))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CloseSqliteConnexion()
        Return lst
    End Function


    Public Function getWorkersByGroup(idGroup As Integer, statut As String) As List(Of Person)
        Dim lstWorker As New List(Of Person)
        Dim sqlite_cmd As SQLiteCommand
        Dim sqlite_datareader As SQLiteDataReader
        OpenSqliteConnexion()
        ' Try

        sqlite_cmd = mySqliteConnexion.CreateCommand()
        sqlite_cmd.CommandText = "select p.idPerson,p.cin,p.nameFirst,p.nameFamily,w.idGroup,w.numBureau FROM workers w,persons p WHERE idGroup=" & idGroup & " and w.idPerson=p.idPerson and w.statut='" & statut & "'"
        sqlite_datareader = sqlite_cmd.ExecuteReader()
            While (sqlite_datareader.Read())
                lstWorker.Add(New Person(sqlite_datareader.GetInt16(0), sqlite_datareader.GetString(1), sqlite_datareader.GetString(2), sqlite_datareader.GetString(3), sqlite_datareader.GetInt16(4), sqlite_datareader.GetInt16(5)))
            End While
            'Catch ex As Exception
            '    MsgBox("getWorkersByGroup" & vbNewLine & ex.Message)
            'End Try
            CloseSqliteConnexion()
        Return lstWorker
    End Function
    'Public Function getChefOfGroup(idGroup As Integer) As Person

    '    Dim chef As Person = Nothing
    '    Dim sqlite_cmd As SQLiteCommand
    '    Dim sqlite_datareader As SQLiteDataReader
    '    OpenSqliteConnexion()
    '    Try
    '        sqlite_cmd = mySqliteConnexion.CreateCommand()
    '        sqlite_cmd.CommandText = "select p.idPerson,p.cin,p.nameFirst,p.nameFamily,w.statut FROM workers w,persons p WHERE idGroup=" & idGroup & " and w.idPerson=p.idPerson and w.statut='Chef'"
    '        sqlite_datareader = sqlite_cmd.ExecuteReader()
    '        While (sqlite_datareader.Read())
    '            chef = New Person(sqlite_datareader.GetInt16(0), sqlite_datareader.GetString(1), sqlite_datareader.GetString(2), sqlite_datareader.GetString(3))
    '        End While
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    CloseSqliteConnexion()
    '    Return chef
    'End Function



    Public Function checkGroupExist(num As String) As Groupe
        Dim result As Groupe = Nothing
        Dim sqlite_cmd As SQLiteCommand
        Dim sqlite_datareader As SQLiteDataReader
        OpenSqliteConnexion()
        sqlite_cmd = mySqliteConnexion.CreateCommand()
        sqlite_cmd.CommandText = "SELECT idGroup,numGroup,groupName FROM groupes  where LOWER(numGroup)='" & num.Replace("'", "@_@") & "'"
        sqlite_datareader = sqlite_cmd.ExecuteReader()
        While (sqlite_datareader.Read())
            result = New Groupe(sqlite_datareader.GetInt16(0), sqlite_datareader.GetString(1), sqlite_datareader.GetString(2).Replace("@_@", "'"))
        End While
        CloseSqliteConnexion()
        Return result
    End Function

    Public Sub addPersonToGroup(idGroup As Integer, idPerson As Integer, statut As String, numBureau As Integer)
        OpenSqliteConnexion()
        Try
            Const insertSql As String = "INSERT INTO workers (idGroup,idPerson,statut,numBureau)  VALUES (@idGroup, @idPerson, @statut, @numBureau);"

            Dim addCmd = New SQLiteCommand(insertSql, mySqliteConnexion)
            addCmd.Parameters.AddWithValue("@idGroup", idGroup)
            addCmd.Parameters.AddWithValue("@idPerson", idPerson)
            addCmd.Parameters.AddWithValue("@statut", statut)
            addCmd.Parameters.AddWithValue("@numBureau", numBureau)
            '  MsgBox(dateAfecte)
            addCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("addPerson" & vbNewLine & ex.Message)
        End Try

        CloseSqliteConnexion()
    End Sub

    Friend Function getListChef() As List(Of Person)
        Dim lstWorker As New List(Of Person)
        Dim sqlite_cmd As SQLiteCommand
        Dim sqlite_datareader As SQLiteDataReader
        OpenSqliteConnexion()
        Try
            sqlite_cmd = mySqliteConnexion.CreateCommand()
            ' idPerson , cin , nameFirst , nameFamily , statut , numBureau 
            sqlite_cmd.CommandText = "select p.idPerson,p.cin,p.nameFirst,p.nameFamily,w.idGroup,w.numBureau FROM workers w,persons p WHERE  w.idPerson=p.idPerson and w.statut='Chef'"
            sqlite_datareader = sqlite_cmd.ExecuteReader()
            While (sqlite_datareader.Read())
                'New(idPerson , cin , nameFirst, nameFamily , idGroup)
                lstWorker.Add(New Person(sqlite_datareader.GetInt16(0), sqlite_datareader.GetString(1), sqlite_datareader.GetString(2), sqlite_datareader.GetString(3), sqlite_datareader.GetInt16(4), sqlite_datareader.GetInt16(5)))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CloseSqliteConnexion()
        Return lstWorker
    End Function

    Public Function getGroupById(idGroup As String) As Groupe
        Dim result As Groupe = New Groupe
        Dim sqlite_cmd As SQLiteCommand
        Dim sqlite_datareader As SQLiteDataReader
        OpenSqliteConnexion()
        sqlite_cmd = mySqliteConnexion.CreateCommand()
        sqlite_cmd.CommandText = "SELECT numGroup,groupName FROM groupes  wher where idGroup=" & idGroup
        sqlite_datareader = sqlite_cmd.ExecuteReader()
        While (sqlite_datareader.Read())
            result.idGroup = idGroup
            result.numGroup = sqlite_datareader.GetString(0)
            result.groupName = sqlite_datareader.GetString(1)
        End While
        CloseSqliteConnexion()
        Return result
    End Function




    'Private Function LoadConnectionString(Optional id As String = "Default") As String

    '    Return ConfigurationManager.ConnectionStrings(id).ConnectionString
    'End Function

End Class
