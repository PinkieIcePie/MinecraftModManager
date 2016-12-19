Imports System.IO
Imports System.Xml
Imports System.Web
Imports System.Net
Imports System.Environment
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class frm_init
    'init vars
    Dim userdir As String
    Dim minecraftdir As String
    Dim profilejson As String


    Private Sub frm_init_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userdir = Environment.GetEnvironmentVariable("userprofile")
        minecraftdir = "\AppData\Roaming\.minecraft"
        profilejson = userdir & minecraftdir & "\launcher_profiles.json"

        If File.Exists(userdir & minecraftdir & "\launcher_profiles.json") Then
            MsgBox("Discovered Minecraft installation at: /n" & userdir & minecraftdir)
            Dim json As String = File.ReadAllText(profilejson)
            Dim reader As JsonTextReader
            reader = New JsonTextReader(New StringReader(json))
            While (reader.Read())
                Console.WriteLine("Token: {0}, Value: {1}", reader.TokenType, reader.Value)
                If reader.TokenType = "PropertyName" & reader.Value = "profiles" Then
                    MsgBox("stuff")
                End If
            End While

        Else
            MsgBox("No Minecraft installation found, create folders?", MsgBoxStyle.YesNo)
                        If MsgBoxResult.Yes Then
                        'create .minecraft folder and set necessary vars
                    End If
                    If MsgBoxResult.No Then
                        'ask for location of mc installation
                    End If
        End If
    End Sub

    Private Sub btn_newprofile_Click(sender As Object, e As EventArgs) Handles btn_newprofile.Click
        'Create a new profile easily
    End Sub

    Private Sub btn_editprof_Click(sender As Object, e As EventArgs) Handles btn_editprof.Click
        'Open popup to modify parts of the profile
    End Sub

    Private Sub btn_down_Click(sender As Object, e As EventArgs) Handles btn_down.Click
        'Download mods from internal mods url list
    End Sub

    Private Sub btn_mods_Click(sender As Object, e As EventArgs) Handles btn_mods.Click
        'Enable and Disable mods for the current Profile
    End Sub
End Class
