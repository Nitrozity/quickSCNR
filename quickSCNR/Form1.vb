Imports System.IO
Imports Newtonsoft.Json

Public Class Form1
    Private mapOffsets As New Dictionary(Of String, Dictionary(Of String, OffsetEntry))
    Private selectedMapFilePath As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadConfig()

        Catch ex As Exception
            LogMessage("Error loading config: " & ex.Message)
        End Try
    End Sub

    Private detectMap As New Dictionary(Of String, String) From {
        {"levels\solo\005_intro\005_intro", "arrival"},
        {"levels\solo\010_jungle\010_jungle", "sierra_117"},
        {"levels\solo\020_base\020_base", "crows_nest"},
        {"levels\solo\030_outskirts\030_outskirts", "tsavo_highway"},
        {"levels\solo\040_voi\040_voi", "the_storm"},
        {"levels\solo\050_floodvoi\050_floodvoi", "floodgate"},
        {"levels\solo\070_waste\070_waste", "the_ark"},
        {"levels\solo\100_citadel\100_citadel", "the_covenant"},
        {"levels\solo\110_hc\110_hc", "cortana"},
        {"levels\solo\120_halo\120_halo", "halo"},
        {"levels\solo\130_epilogue\130_epilogue", "epilogue"},
        {"levels\multi\chill\chill", "narrows"},
        {"levels\multi\construct\construct", "construct"},
        {"levels\multi\cyberdyne\cyberdyne", "the_pit"},
        {"levels\multi\deadlock\deadlock", "high_ground"},
        {"levels\multi\guardian\guardian", "guardian"},
        {"levels\multi\isolation\isolation", "isolation"},
        {"levels\multi\riverworld\riverworld", "valhalla"},
        {"levels\multi\salvation\salvation", "epitaph"},
        {"levels\multi\shrine\shrine", "sandtrap"},
        {"levels\multi\snowbound\snowbound", "snowbound"},
        {"levels\multi\zanzibar\zanzibar", "last_resort"},
        {"levels\dlc\armory\armory", "rats_nest"},
        {"levels\dlc\bunkerworld\bunkerworld", "standoff"},
        {"levels\dlc\chillout\chillout", "cold_storage"},
        {"levels\dlc\descent\descent", "assembly"},
        {"levels\dlc\docks\docks", "longshore"},
        {"levels\dlc\fortress\fortress", "citadel"},
        {"levels\dlc\ghosttown\ghosttown", "ghost_town"},
        {"levels\dlc\lockout\lockout", "blackout"},
        {"levels\dlc\midship\midship", "heretic"},
        {"levels\dlc\sandbox\sandbox", "sandbox"},
        {"levels\dlc\sidewinder\sidewinder", "avalanche"},
        {"levels\dlc\spacecamp\spacecamp", "orbital"},
        {"levels\dlc\warehouse\warehouse", "foundry"}
    }

    Private Sub LoadConfig()
        Dim configText As String = File.ReadAllText("config.json")
        mapOffsets = JsonConvert.DeserializeObject(Of Dictionary(Of String, Dictionary(Of String, OffsetEntry)))(configText)
    End Sub

    Private Sub LogMessage(msg As String)
        If DebugTxt IsNot Nothing Then
            DebugTxt.Text = msg
        End If
    End Sub

    Private Sub btnLoadMap_Click(sender As Object, e As EventArgs) Handles btnLoadMap.Click
        Using mapOpen As New OpenFileDialog()
            mapOpen.Title = "Select a .map file"
            mapOpen.Filter = "Halo 3 Map Files (*.map)|*.map"
            mapOpen.InitialDirectory = ""

            If mapOpen.ShowDialog() = DialogResult.OK Then
                selectedMapFilePath = mapOpen.FileName

                Dim fileNameWithoutExt As String = Path.GetFileNameWithoutExtension(selectedMapFilePath).ToLowerInvariant()
                Dim friendlyName As String = "Unknown"

                For Each kvp In detectMap
                    If kvp.Key.EndsWith(fileNameWithoutExt, StringComparison.OrdinalIgnoreCase) Then
                        friendlyName = kvp.Value
                        Exit For
                    End If
                Next

                friendlyName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(friendlyName.Replace("_", " "))
                LogMessage($"Loaded: {Path.GetFileName(selectedMapFilePath)} ({friendlyName})")
            End If
        End Using
    End Sub

    Private Function ResolveMapName(filePath As String) As String
        Dim fileNameWithoutExt As String = Path.GetFileNameWithoutExtension(filePath).ToLowerInvariant()

        For Each kvp In detectMap
            If kvp.Key.EndsWith(fileNameWithoutExt, StringComparison.OrdinalIgnoreCase) Then
                Return kvp.Value
            End If
        Next

        Return fileNameWithoutExt
    End Function

    Private Sub btnRemoveSelected_Click(sender As Object, e As EventArgs) Handles btnRemoveSelected.Click
        If String.IsNullOrEmpty(selectedMapFilePath) OrElse Not File.Exists(selectedMapFilePath) Then
            LogMessage("Please load a valid map file first using the Load Map button.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show(
        "Do you want to create a backup of this map file before modifying it?",
        "Create Backup?",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If result = DialogResult.Yes Then
            Try
                Dim backupPath As String = selectedMapFilePath & ".bak"
                File.Copy(selectedMapFilePath, backupPath, True)
                LogMessage($"Backup created: {backupPath}")
            Catch ex As Exception
                LogMessage("Error creating backup: " & ex.Message)
            End Try
        End If

        Dim mapFilePath As String = selectedMapFilePath
        Dim mapName As String = ResolveMapName(mapFilePath)

        If Not mapOffsets.ContainsKey(mapName) Then
            LogMessage($"Warning: Map '{mapName}' not found in config. Removal may not work correctly.")
            Return
        End If

        Dim mapConfig = mapOffsets(mapName)
        Dim checkboxMap As New Dictionary(Of CheckBox, String) From {
        {chkKillTriggers, "KillTriggers"},
        {chkSoftCeilings, "SoftCeilings"},
        {chkSafeZones, "SafeZones"},
        {chkCrates, "Crates"},
        {chkWeapons, "Weapons"},
        {chkWeaponPalette, "WeaponPalette"},
        {chkEquipment, "Equipment"},
        {chkEquipmentPalette, "EquipmentPalette"},
        {chkVehicles, "Vehicles"},
        {chkVehiclePalette, "VehiclePalette"},
        {chkSoundScenery, "SoundScenery"},
        {chkSoundSceneryPalette, "SoundSceneryPalette"},
        {chkDecals, "Decals"},
        {chkDecalPalette, "DecalPalette"},
        {chkEffectScenery, "EffectScenery"},
        {chkEffectSceneryPalette, "EffectSceneryPalette"},
        {chkMapVariantSceneryPalette, "MapVariantSceneryPalette"},
        {chkMapVariantTeleporterPalette, "MapVariantTeleporterPalette"},
        {chkMapVariantGoalPalette, "MapVariantGoalPalette"},
        {chkMapVariantSpawnerPalette, "MapVariantSpawnerPalette"},
        {chkDeadTeammateInfluence, "DeadTeammateInfluence"},
        {chkAIUserHintData, "AIUserHintData"},
        {chkScripts, "Scripts"},
        {chkGlobals, "Globals"},
        {chkScriptReferences, "ScriptReferences"},
        {chkScriptingData, "ScriptingData"},
        {chkCutsceneFlags, "CutsceneFlags"},
        {chkScenarioClusterData, "ScenarioClusterData"},
        {chkSpawnData, "SpawnData"},
        {chkObjectNames, "ObjectNames"},
        {chkScenery, "Scenery"},
        {chkSceneryPalette, "SceneryPalette"},
        {chkAtmosphere, "Atmosphere"},
        {chkCameraFXPalette, "CameraFXPalette"},
        {chkCharacterPalette, "CharacterPalette"},
        {chkControls, "Controls"},
        {chkControlPalette, "ControlPalette"},
        {chkUnitSeatsMapping, "UnitSeatsMapping"},
        {chkLightingZoneSets, "LightingZoneSets"}
    }

        Try
            Using fs As New FileStream(mapFilePath, FileMode.Open, FileAccess.Write, FileShare.None)
                For Each kvp In checkboxMap
                    If kvp.Key.Checked AndAlso mapConfig.ContainsKey(kvp.Value) Then
                        NullSection(fs, mapConfig(kvp.Value))
                    End If
                Next
            End Using

            LogMessage("Selected elements removed successfully!")
        Catch ex As Exception
            LogMessage("Error: " & ex.Message)
        End Try
    End Sub



    Private Sub NullSection(fs As FileStream, entry As OffsetEntry)
        fs.Seek(entry.OffsetLong, SeekOrigin.Begin)
        Dim zeroBytes(entry.Size - 1) As Byte
        fs.Write(zeroBytes, 0, zeroBytes.Length)
    End Sub

    Private Sub ToggleCheckboxesInPanel(panel As FlowLayoutPanel, checkState As Boolean)
        For Each ctrl As Control In panel.Controls
            If TypeOf ctrl Is CheckBox AndAlso ctrl.Name <> "chkAll" Then
                DirectCast(ctrl, CheckBox).Checked = checkState
            End If
        Next
    End Sub

    Private Sub chkAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkAll.CheckedChanged
        ToggleCheckboxesInPanel(FlowLayoutPanel1, chkAll.Checked)
        ToggleCheckboxesInPanel(FlowLayoutPanel2, chkAll.Checked)
        ToggleCheckboxesInPanel(FlowLayoutPanel3, chkAll.Checked)
    End Sub
End Class

Public Class OffsetEntry
    Public Property Offset As String
    Public Property Size As Integer

    Public ReadOnly Property OffsetLong As Long
        Get
            Return Convert.ToInt64(Offset.Replace("&H", ""), 16)
        End Get
    End Property
End Class
