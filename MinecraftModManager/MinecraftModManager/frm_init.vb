Imports System.IO
Imports System.Xml
Imports System.Web
Imports System.Net
Imports System.Environment
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class frm_init
    'init vars
    Dim forge_mc_args As String = "--username ${auth_player_name} --version ${version_name} --gameDir ${game_directory} --assetsDir ${assets_root} --assetIndex ${assets_index_name} --uuid ${auth_uuid} --accessToken ${auth_access_token} --userType ${user_type} --tweakClass net.minecraftforge.fml.common.launcher.FMLTweaker --versionType Forge"
    Dim vanilla_mc_args As String = "--username ${auth_player_name} --version ${version_name} --gameDir ${game_directory} --assetsDir ${assets_root} --assetIndex ${assets_index_name} --uuid ${auth_uuid} --accessToken ${auth_access_token} --userType ${user_type} --versionType Vanilla"
    Dim mainclass As String = "net.minecraft.launchwrapper.Launch"
    Dim userdir As String
    Dim minecraftdir As String
    Dim profilejson As String
    Dim manageddir As String

    Dim folder1 As String = "\managedprofiles"


    Private Sub frm_init_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userdir = Environment.GetEnvironmentVariable("userprofile")
        minecraftdir = "\AppData\Roaming\.minecraft"
        manageddir = userdir & minecraftdir & folder1
        'generate managed profiles folder, ready for adding profiles
        If (Not Directory.Exists(manageddir)) Then
            Directory.CreateDirectory(manageddir)
            Console.WriteLine("Created Managed Profiles Folder - Copying LauncherProfiles")
            'TODO: Copy Launcher_Profiles.json to managedprofiles folder for customisation
        Else
            Console.WriteLine("Folder Already Exists, load the config now")
            'TODO: Add folder structure for existing profiles?
        End If

        'initialise launcher_profiles
        profilejson = userdir & minecraftdir & "\launcher_profiles.json"
        If File.Exists(userdir & minecraftdir & "\launcher_profiles.json") Then
            Console.WriteLine("Discovered Minecraft installation at:" & Environment.NewLine & userdir & minecraftdir)
            Dim json As String = File.ReadAllText(profilejson)
            Dim reader As JsonTextReader
            Dim convert As JsonSerializer
            Dim output As JObject
            Dim profstr As String
            convert = New JsonSerializer
            reader = New JsonTextReader(New StringReader(json))
            While (reader.Read())
                output = convert.Deserialize(reader)
                profstr = output.SelectToken("selectedProfile").ToString()
                lbl_profile.Text = profstr
                lbl_mcver.Text = output.SelectToken("profiles").SelectToken(profstr).SelectToken("lastVersionId").ToString()
                lbl_type.Text = output.SelectToken("profiles").SelectToken(profstr).SelectToken("type").ToString()

                Console.WriteLine(output.SelectToken("profiles").Count & " Profiles Loaded from Launcher")
                For Each profiles In output
                    cb_profilesel.Items.Add(output.SelectToken("profiles").ToString())
                Next

                'TODO: Strip down the output so that the initial form displays the content correctly
            End While
        Else
            MsgBox("No Minecraft installation found, check and then relaunch.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btn_newprofile_Click(sender As Object, e As EventArgs) Handles btn_newprofile.Click
        'Create a new profile easily
        'TODO: Add Functionality to write to a JSON file
        'TODO: Create ALL functionality for form, such as RAM slider.
    End Sub

    Private Sub btn_editprof_Click(sender As Object, e As EventArgs) Handles btn_editprof.Click
        'Open popup to modify parts of the profile
        MsgBox("Sorry, this feature is currently unavailable.")
    End Sub

    Private Sub btn_down_Click(sender As Object, e As EventArgs) Handles btn_down.Click
        'Download mods from internal mods url list
        'Using modurl.db file, or a self-generated XML file? create an easily viewable table with search funtions etc.
        MsgBox("Sorry, this feature is currently unavailable.")
    End Sub

    Private Sub btn_mods_Click(sender As Object, e As EventArgs) Handles btn_mods.Click
        'Enable and Disable mods for the current Profile
        MsgBox("Sorry, this feature is currently unavailable.")
        'TODO: Check available mods (in ./data/mods/%mcversion%/ ) and allow user to select which ones are loaded and which aren't.
    End Sub
End Class
