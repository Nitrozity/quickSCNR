<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnLoadMap = New System.Windows.Forms.Button()
        Me.openMapDialog = New System.Windows.Forms.OpenFileDialog()
        Me.saveMapDialog = New System.Windows.Forms.SaveFileDialog()
        Me.btnRemoveSelected = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.chkVehicles = New System.Windows.Forms.CheckBox()
        Me.chkKillTriggers = New System.Windows.Forms.CheckBox()
        Me.chkSoftCeilings = New System.Windows.Forms.CheckBox()
        Me.chkSafeZones = New System.Windows.Forms.CheckBox()
        Me.chkCrates = New System.Windows.Forms.CheckBox()
        Me.chkDecals = New System.Windows.Forms.CheckBox()
        Me.chkDecalPalette = New System.Windows.Forms.CheckBox()
        Me.chkVehiclePalette = New System.Windows.Forms.CheckBox()
        Me.chkEquipment = New System.Windows.Forms.CheckBox()
        Me.chkEquipmentPalette = New System.Windows.Forms.CheckBox()
        Me.chkWeapons = New System.Windows.Forms.CheckBox()
        Me.chkWeaponPalette = New System.Windows.Forms.CheckBox()
        Me.chkSoundScenery = New System.Windows.Forms.CheckBox()
        Me.chkSoundSceneryPalette = New System.Windows.Forms.CheckBox()
        Me.chkEffectScenery = New System.Windows.Forms.CheckBox()
        Me.chkEffectSceneryPalette = New System.Windows.Forms.CheckBox()
        Me.chkAll = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.chkMapVariantSceneryPalette = New System.Windows.Forms.CheckBox()
        Me.chkMapVariantTeleporterPalette = New System.Windows.Forms.CheckBox()
        Me.chkMapVariantGoalPalette = New System.Windows.Forms.CheckBox()
        Me.chkMapVariantSpawnerPalette = New System.Windows.Forms.CheckBox()
        Me.chkDeadTeammateInfluence = New System.Windows.Forms.CheckBox()
        Me.chkAIUserHintData = New System.Windows.Forms.CheckBox()
        Me.chkScripts = New System.Windows.Forms.CheckBox()
        Me.chkGlobals = New System.Windows.Forms.CheckBox()
        Me.chkScriptReferences = New System.Windows.Forms.CheckBox()
        Me.chkScriptingData = New System.Windows.Forms.CheckBox()
        Me.chkCutsceneFlags = New System.Windows.Forms.CheckBox()
        Me.chkScenarioClusterData = New System.Windows.Forms.CheckBox()
        Me.chkSpawnData = New System.Windows.Forms.CheckBox()
        Me.chkObjectNames = New System.Windows.Forms.CheckBox()
        Me.chkScenery = New System.Windows.Forms.CheckBox()
        Me.chkSceneryPalette = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DebugTxt = New System.Windows.Forms.Label()
        Me.cmbMaps = New System.Windows.Forms.ComboBox()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.chkAtmosphere = New System.Windows.Forms.CheckBox()
        Me.chkCameraFXPalette = New System.Windows.Forms.CheckBox()
        Me.chkCharacterPalette = New System.Windows.Forms.CheckBox()
        Me.chkControls = New System.Windows.Forms.CheckBox()
        Me.chkControlPalette = New System.Windows.Forms.CheckBox()
        Me.chkUnitSeatsMapping = New System.Windows.Forms.CheckBox()
        Me.chkLightingZoneSets = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLoadMap
        '
        Me.btnLoadMap.Location = New System.Drawing.Point(15, 12)
        Me.btnLoadMap.Name = "btnLoadMap"
        Me.btnLoadMap.Size = New System.Drawing.Size(87, 23)
        Me.btnLoadMap.TabIndex = 0
        Me.btnLoadMap.Text = "Load Map"
        Me.btnLoadMap.UseVisualStyleBackColor = True
        '
        'openMapDialog
        '
        Me.openMapDialog.FileName = "OpenFileDialog1"
        '
        'btnRemoveSelected
        '
        Me.btnRemoveSelected.Location = New System.Drawing.Point(108, 12)
        Me.btnRemoveSelected.Name = "btnRemoveSelected"
        Me.btnRemoveSelected.Size = New System.Drawing.Size(117, 23)
        Me.btnRemoveSelected.TabIndex = 9
        Me.btnRemoveSelected.Text = "Apply Removals"
        Me.btnRemoveSelected.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.chkVehicles)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkKillTriggers)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkSoftCeilings)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkSafeZones)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkCrates)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkDecals)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkDecalPalette)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkVehiclePalette)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkEquipment)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkEquipmentPalette)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkWeapons)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkWeaponPalette)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkSoundScenery)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkSoundSceneryPalette)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkEffectScenery)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkEffectSceneryPalette)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(13, 72)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(136, 376)
        Me.FlowLayoutPanel1.TabIndex = 10
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'chkVehicles
        '
        Me.chkVehicles.AutoSize = True
        Me.chkVehicles.Location = New System.Drawing.Point(3, 3)
        Me.chkVehicles.Name = "chkVehicles"
        Me.chkVehicles.Size = New System.Drawing.Size(66, 17)
        Me.chkVehicles.TabIndex = 13
        Me.chkVehicles.Text = "Vehicles"
        Me.chkVehicles.UseVisualStyleBackColor = True
        '
        'chkKillTriggers
        '
        Me.chkKillTriggers.AutoSize = True
        Me.chkKillTriggers.Location = New System.Drawing.Point(3, 26)
        Me.chkKillTriggers.Name = "chkKillTriggers"
        Me.chkKillTriggers.Size = New System.Drawing.Size(80, 17)
        Me.chkKillTriggers.TabIndex = 0
        Me.chkKillTriggers.Text = "Kill Triggers"
        Me.chkKillTriggers.UseVisualStyleBackColor = True
        '
        'chkSoftCeilings
        '
        Me.chkSoftCeilings.AutoSize = True
        Me.chkSoftCeilings.Location = New System.Drawing.Point(3, 49)
        Me.chkSoftCeilings.Name = "chkSoftCeilings"
        Me.chkSoftCeilings.Size = New System.Drawing.Size(84, 17)
        Me.chkSoftCeilings.TabIndex = 1
        Me.chkSoftCeilings.Text = "Soft Ceilings"
        Me.chkSoftCeilings.UseVisualStyleBackColor = True
        '
        'chkSafeZones
        '
        Me.chkSafeZones.AutoSize = True
        Me.chkSafeZones.Location = New System.Drawing.Point(3, 72)
        Me.chkSafeZones.Name = "chkSafeZones"
        Me.chkSafeZones.Size = New System.Drawing.Size(81, 17)
        Me.chkSafeZones.TabIndex = 2
        Me.chkSafeZones.Text = "Safe Zones"
        Me.chkSafeZones.UseVisualStyleBackColor = True
        '
        'chkCrates
        '
        Me.chkCrates.AutoSize = True
        Me.chkCrates.Location = New System.Drawing.Point(3, 95)
        Me.chkCrates.Name = "chkCrates"
        Me.chkCrates.Size = New System.Drawing.Size(56, 17)
        Me.chkCrates.TabIndex = 3
        Me.chkCrates.Text = "Crates"
        Me.chkCrates.UseVisualStyleBackColor = True
        '
        'chkDecals
        '
        Me.chkDecals.AutoSize = True
        Me.chkDecals.Location = New System.Drawing.Point(3, 118)
        Me.chkDecals.Name = "chkDecals"
        Me.chkDecals.Size = New System.Drawing.Size(59, 17)
        Me.chkDecals.TabIndex = 4
        Me.chkDecals.Text = "Decals"
        Me.chkDecals.UseVisualStyleBackColor = True
        '
        'chkDecalPalette
        '
        Me.chkDecalPalette.AutoSize = True
        Me.chkDecalPalette.Location = New System.Drawing.Point(3, 141)
        Me.chkDecalPalette.Name = "chkDecalPalette"
        Me.chkDecalPalette.Size = New System.Drawing.Size(90, 17)
        Me.chkDecalPalette.TabIndex = 5
        Me.chkDecalPalette.Text = "Decal Palette"
        Me.chkDecalPalette.UseVisualStyleBackColor = True
        '
        'chkVehiclePalette
        '
        Me.chkVehiclePalette.AutoSize = True
        Me.chkVehiclePalette.Location = New System.Drawing.Point(3, 164)
        Me.chkVehiclePalette.Name = "chkVehiclePalette"
        Me.chkVehiclePalette.Size = New System.Drawing.Size(97, 17)
        Me.chkVehiclePalette.TabIndex = 6
        Me.chkVehiclePalette.Text = "Vehicle Palette"
        Me.chkVehiclePalette.UseVisualStyleBackColor = True
        '
        'chkEquipment
        '
        Me.chkEquipment.AutoSize = True
        Me.chkEquipment.Location = New System.Drawing.Point(3, 187)
        Me.chkEquipment.Name = "chkEquipment"
        Me.chkEquipment.Size = New System.Drawing.Size(76, 17)
        Me.chkEquipment.TabIndex = 7
        Me.chkEquipment.Text = "Equipment"
        Me.chkEquipment.UseVisualStyleBackColor = True
        '
        'chkEquipmentPalette
        '
        Me.chkEquipmentPalette.AutoSize = True
        Me.chkEquipmentPalette.Location = New System.Drawing.Point(3, 210)
        Me.chkEquipmentPalette.Name = "chkEquipmentPalette"
        Me.chkEquipmentPalette.Size = New System.Drawing.Size(112, 17)
        Me.chkEquipmentPalette.TabIndex = 8
        Me.chkEquipmentPalette.Text = "Equipment Palette"
        Me.chkEquipmentPalette.UseVisualStyleBackColor = True
        '
        'chkWeapons
        '
        Me.chkWeapons.AutoSize = True
        Me.chkWeapons.Location = New System.Drawing.Point(3, 233)
        Me.chkWeapons.Name = "chkWeapons"
        Me.chkWeapons.Size = New System.Drawing.Size(72, 17)
        Me.chkWeapons.TabIndex = 9
        Me.chkWeapons.Text = "Weapons"
        Me.chkWeapons.UseVisualStyleBackColor = True
        '
        'chkWeaponPalette
        '
        Me.chkWeaponPalette.AutoSize = True
        Me.chkWeaponPalette.Location = New System.Drawing.Point(3, 256)
        Me.chkWeaponPalette.Name = "chkWeaponPalette"
        Me.chkWeaponPalette.Size = New System.Drawing.Size(103, 17)
        Me.chkWeaponPalette.TabIndex = 10
        Me.chkWeaponPalette.Text = "Weapon Palette"
        Me.chkWeaponPalette.UseVisualStyleBackColor = True
        '
        'chkSoundScenery
        '
        Me.chkSoundScenery.AutoSize = True
        Me.chkSoundScenery.Location = New System.Drawing.Point(3, 279)
        Me.chkSoundScenery.Name = "chkSoundScenery"
        Me.chkSoundScenery.Size = New System.Drawing.Size(99, 17)
        Me.chkSoundScenery.TabIndex = 11
        Me.chkSoundScenery.Text = "Sound Scenery"
        Me.chkSoundScenery.UseVisualStyleBackColor = True
        '
        'chkSoundSceneryPalette
        '
        Me.chkSoundSceneryPalette.AutoSize = True
        Me.chkSoundSceneryPalette.Location = New System.Drawing.Point(3, 302)
        Me.chkSoundSceneryPalette.Name = "chkSoundSceneryPalette"
        Me.chkSoundSceneryPalette.Size = New System.Drawing.Size(135, 17)
        Me.chkSoundSceneryPalette.TabIndex = 12
        Me.chkSoundSceneryPalette.Text = "Sound Scenery Palette"
        Me.chkSoundSceneryPalette.UseVisualStyleBackColor = True
        '
        'chkEffectScenery
        '
        Me.chkEffectScenery.AutoSize = True
        Me.chkEffectScenery.Location = New System.Drawing.Point(3, 325)
        Me.chkEffectScenery.Name = "chkEffectScenery"
        Me.chkEffectScenery.Size = New System.Drawing.Size(96, 17)
        Me.chkEffectScenery.TabIndex = 14
        Me.chkEffectScenery.Text = "Effect Scenery"
        Me.chkEffectScenery.UseVisualStyleBackColor = True
        '
        'chkEffectSceneryPalette
        '
        Me.chkEffectSceneryPalette.AutoSize = True
        Me.chkEffectSceneryPalette.Location = New System.Drawing.Point(3, 348)
        Me.chkEffectSceneryPalette.Name = "chkEffectSceneryPalette"
        Me.chkEffectSceneryPalette.Size = New System.Drawing.Size(132, 17)
        Me.chkEffectSceneryPalette.TabIndex = 15
        Me.chkEffectSceneryPalette.Text = "Effect Scenery Palette"
        Me.chkEffectSceneryPalette.UseVisualStyleBackColor = True
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.Location = New System.Drawing.Point(17, 51)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(70, 17)
        Me.chkAll.TabIndex = 14
        Me.chkAll.Text = "Select All"
        Me.chkAll.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.chkMapVariantSceneryPalette)
        Me.FlowLayoutPanel2.Controls.Add(Me.chkMapVariantTeleporterPalette)
        Me.FlowLayoutPanel2.Controls.Add(Me.chkMapVariantGoalPalette)
        Me.FlowLayoutPanel2.Controls.Add(Me.chkMapVariantSpawnerPalette)
        Me.FlowLayoutPanel2.Controls.Add(Me.chkDeadTeammateInfluence)
        Me.FlowLayoutPanel2.Controls.Add(Me.chkAIUserHintData)
        Me.FlowLayoutPanel2.Controls.Add(Me.chkScripts)
        Me.FlowLayoutPanel2.Controls.Add(Me.chkGlobals)
        Me.FlowLayoutPanel2.Controls.Add(Me.chkScriptReferences)
        Me.FlowLayoutPanel2.Controls.Add(Me.chkScriptingData)
        Me.FlowLayoutPanel2.Controls.Add(Me.chkCutsceneFlags)
        Me.FlowLayoutPanel2.Controls.Add(Me.chkScenarioClusterData)
        Me.FlowLayoutPanel2.Controls.Add(Me.chkSpawnData)
        Me.FlowLayoutPanel2.Controls.Add(Me.chkObjectNames)
        Me.FlowLayoutPanel2.Controls.Add(Me.chkScenery)
        Me.FlowLayoutPanel2.Controls.Add(Me.chkSceneryPalette)
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(154, 72)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(174, 376)
        Me.FlowLayoutPanel2.TabIndex = 16
        Me.FlowLayoutPanel2.WrapContents = False
        '
        'chkMapVariantSceneryPalette
        '
        Me.chkMapVariantSceneryPalette.AutoSize = True
        Me.chkMapVariantSceneryPalette.Location = New System.Drawing.Point(3, 3)
        Me.chkMapVariantSceneryPalette.Name = "chkMapVariantSceneryPalette"
        Me.chkMapVariantSceneryPalette.Size = New System.Drawing.Size(161, 17)
        Me.chkMapVariantSceneryPalette.TabIndex = 13
        Me.chkMapVariantSceneryPalette.Text = "Map Variant Scenery Palette"
        Me.chkMapVariantSceneryPalette.UseVisualStyleBackColor = True
        '
        'chkMapVariantTeleporterPalette
        '
        Me.chkMapVariantTeleporterPalette.AutoSize = True
        Me.chkMapVariantTeleporterPalette.Location = New System.Drawing.Point(3, 26)
        Me.chkMapVariantTeleporterPalette.Name = "chkMapVariantTeleporterPalette"
        Me.chkMapVariantTeleporterPalette.Size = New System.Drawing.Size(170, 17)
        Me.chkMapVariantTeleporterPalette.TabIndex = 0
        Me.chkMapVariantTeleporterPalette.Text = "Map Variant Teleporter Palette"
        Me.chkMapVariantTeleporterPalette.UseVisualStyleBackColor = True
        '
        'chkMapVariantGoalPalette
        '
        Me.chkMapVariantGoalPalette.AutoSize = True
        Me.chkMapVariantGoalPalette.Location = New System.Drawing.Point(3, 49)
        Me.chkMapVariantGoalPalette.Name = "chkMapVariantGoalPalette"
        Me.chkMapVariantGoalPalette.Size = New System.Drawing.Size(144, 17)
        Me.chkMapVariantGoalPalette.TabIndex = 1
        Me.chkMapVariantGoalPalette.Text = "Map Variant Goal Palette"
        Me.chkMapVariantGoalPalette.UseVisualStyleBackColor = True
        '
        'chkMapVariantSpawnerPalette
        '
        Me.chkMapVariantSpawnerPalette.AutoSize = True
        Me.chkMapVariantSpawnerPalette.Location = New System.Drawing.Point(3, 72)
        Me.chkMapVariantSpawnerPalette.Name = "chkMapVariantSpawnerPalette"
        Me.chkMapVariantSpawnerPalette.Size = New System.Drawing.Size(164, 17)
        Me.chkMapVariantSpawnerPalette.TabIndex = 2
        Me.chkMapVariantSpawnerPalette.Text = "Map Variant Spawner Palette"
        Me.chkMapVariantSpawnerPalette.UseVisualStyleBackColor = True
        '
        'chkDeadTeammateInfluence
        '
        Me.chkDeadTeammateInfluence.AutoSize = True
        Me.chkDeadTeammateInfluence.Location = New System.Drawing.Point(3, 95)
        Me.chkDeadTeammateInfluence.Name = "chkDeadTeammateInfluence"
        Me.chkDeadTeammateInfluence.Size = New System.Drawing.Size(152, 17)
        Me.chkDeadTeammateInfluence.TabIndex = 3
        Me.chkDeadTeammateInfluence.Text = "Dead Teammate Influence"
        Me.chkDeadTeammateInfluence.UseVisualStyleBackColor = True
        '
        'chkAIUserHintData
        '
        Me.chkAIUserHintData.AutoSize = True
        Me.chkAIUserHintData.Location = New System.Drawing.Point(3, 118)
        Me.chkAIUserHintData.Name = "chkAIUserHintData"
        Me.chkAIUserHintData.Size = New System.Drawing.Size(109, 17)
        Me.chkAIUserHintData.TabIndex = 4
        Me.chkAIUserHintData.Text = "AI User Hint Data"
        Me.chkAIUserHintData.UseVisualStyleBackColor = True
        '
        'chkScripts
        '
        Me.chkScripts.AutoSize = True
        Me.chkScripts.Location = New System.Drawing.Point(3, 141)
        Me.chkScripts.Name = "chkScripts"
        Me.chkScripts.Size = New System.Drawing.Size(58, 17)
        Me.chkScripts.TabIndex = 5
        Me.chkScripts.Text = "Scripts"
        Me.chkScripts.UseVisualStyleBackColor = True
        '
        'chkGlobals
        '
        Me.chkGlobals.AutoSize = True
        Me.chkGlobals.Location = New System.Drawing.Point(3, 164)
        Me.chkGlobals.Name = "chkGlobals"
        Me.chkGlobals.Size = New System.Drawing.Size(61, 17)
        Me.chkGlobals.TabIndex = 6
        Me.chkGlobals.Text = "Globals"
        Me.chkGlobals.UseVisualStyleBackColor = True
        '
        'chkScriptReferences
        '
        Me.chkScriptReferences.AutoSize = True
        Me.chkScriptReferences.Location = New System.Drawing.Point(3, 187)
        Me.chkScriptReferences.Name = "chkScriptReferences"
        Me.chkScriptReferences.Size = New System.Drawing.Size(111, 17)
        Me.chkScriptReferences.TabIndex = 7
        Me.chkScriptReferences.Text = "Script References"
        Me.chkScriptReferences.UseVisualStyleBackColor = True
        '
        'chkScriptingData
        '
        Me.chkScriptingData.AutoSize = True
        Me.chkScriptingData.Location = New System.Drawing.Point(3, 210)
        Me.chkScriptingData.Name = "chkScriptingData"
        Me.chkScriptingData.Size = New System.Drawing.Size(93, 17)
        Me.chkScriptingData.TabIndex = 8
        Me.chkScriptingData.Text = "Scripting Data"
        Me.chkScriptingData.UseVisualStyleBackColor = True
        '
        'chkCutsceneFlags
        '
        Me.chkCutsceneFlags.AutoSize = True
        Me.chkCutsceneFlags.Location = New System.Drawing.Point(3, 233)
        Me.chkCutsceneFlags.Name = "chkCutsceneFlags"
        Me.chkCutsceneFlags.Size = New System.Drawing.Size(99, 17)
        Me.chkCutsceneFlags.TabIndex = 9
        Me.chkCutsceneFlags.Text = "Cutscene Flags"
        Me.chkCutsceneFlags.UseVisualStyleBackColor = True
        '
        'chkScenarioClusterData
        '
        Me.chkScenarioClusterData.AutoSize = True
        Me.chkScenarioClusterData.Location = New System.Drawing.Point(3, 256)
        Me.chkScenarioClusterData.Name = "chkScenarioClusterData"
        Me.chkScenarioClusterData.Size = New System.Drawing.Size(129, 17)
        Me.chkScenarioClusterData.TabIndex = 10
        Me.chkScenarioClusterData.Text = "Scenario Cluster Data"
        Me.chkScenarioClusterData.UseVisualStyleBackColor = True
        '
        'chkSpawnData
        '
        Me.chkSpawnData.AutoSize = True
        Me.chkSpawnData.Location = New System.Drawing.Point(3, 279)
        Me.chkSpawnData.Name = "chkSpawnData"
        Me.chkSpawnData.Size = New System.Drawing.Size(85, 17)
        Me.chkSpawnData.TabIndex = 11
        Me.chkSpawnData.Text = "Spawn Data"
        Me.chkSpawnData.UseVisualStyleBackColor = True
        '
        'chkObjectNames
        '
        Me.chkObjectNames.AutoSize = True
        Me.chkObjectNames.Location = New System.Drawing.Point(3, 302)
        Me.chkObjectNames.Name = "chkObjectNames"
        Me.chkObjectNames.Size = New System.Drawing.Size(93, 17)
        Me.chkObjectNames.TabIndex = 12
        Me.chkObjectNames.Text = "Object Names"
        Me.chkObjectNames.UseVisualStyleBackColor = True
        '
        'chkScenery
        '
        Me.chkScenery.AutoSize = True
        Me.chkScenery.Location = New System.Drawing.Point(3, 325)
        Me.chkScenery.Name = "chkScenery"
        Me.chkScenery.Size = New System.Drawing.Size(65, 17)
        Me.chkScenery.TabIndex = 14
        Me.chkScenery.Text = "Scenery"
        Me.chkScenery.UseVisualStyleBackColor = True
        '
        'chkSceneryPalette
        '
        Me.chkSceneryPalette.AutoSize = True
        Me.chkSceneryPalette.Location = New System.Drawing.Point(3, 348)
        Me.chkSceneryPalette.Name = "chkSceneryPalette"
        Me.chkSceneryPalette.Size = New System.Drawing.Size(101, 17)
        Me.chkSceneryPalette.TabIndex = 15
        Me.chkSceneryPalette.Text = "Scenery Palette"
        Me.chkSceneryPalette.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(13, 451)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(494, 1)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Label1"
        '
        'DebugTxt
        '
        Me.DebugTxt.Location = New System.Drawing.Point(14, 461)
        Me.DebugTxt.Name = "DebugTxt"
        Me.DebugTxt.Size = New System.Drawing.Size(493, 13)
        Me.DebugTxt.TabIndex = 19
        '
        'cmbMaps
        '
        Me.cmbMaps.FormattingEnabled = True
        Me.cmbMaps.Items.AddRange(New Object() {"Assembly", "Avalanche", "Blackout", "Cold Storage", "Construct", "Epitaph", "Foundry", "Ghost Town", "Guardian", "Heretic", "High Ground", "Isolation", "Last Resort", "Longshore", "Narrows", "Orbital", "Rat's Nest", "Sandbox", "Sandtrap", "Snowbound"})
        Me.cmbMaps.Location = New System.Drawing.Point(231, 13)
        Me.cmbMaps.Name = "cmbMaps"
        Me.cmbMaps.Size = New System.Drawing.Size(121, 21)
        Me.cmbMaps.TabIndex = 11
        Me.cmbMaps.Visible = False
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.chkAtmosphere)
        Me.FlowLayoutPanel3.Controls.Add(Me.chkCameraFXPalette)
        Me.FlowLayoutPanel3.Controls.Add(Me.chkCharacterPalette)
        Me.FlowLayoutPanel3.Controls.Add(Me.chkControls)
        Me.FlowLayoutPanel3.Controls.Add(Me.chkControlPalette)
        Me.FlowLayoutPanel3.Controls.Add(Me.chkUnitSeatsMapping)
        Me.FlowLayoutPanel3.Controls.Add(Me.chkLightingZoneSets)
        Me.FlowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(333, 72)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(174, 376)
        Me.FlowLayoutPanel3.TabIndex = 17
        Me.FlowLayoutPanel3.WrapContents = False
        '
        'chkAtmosphere
        '
        Me.chkAtmosphere.AutoSize = True
        Me.chkAtmosphere.Location = New System.Drawing.Point(3, 3)
        Me.chkAtmosphere.Name = "chkAtmosphere"
        Me.chkAtmosphere.Size = New System.Drawing.Size(82, 17)
        Me.chkAtmosphere.TabIndex = 13
        Me.chkAtmosphere.Text = "Atmosphere"
        Me.chkAtmosphere.UseVisualStyleBackColor = True
        '
        'chkCameraFXPalette
        '
        Me.chkCameraFXPalette.AutoSize = True
        Me.chkCameraFXPalette.Location = New System.Drawing.Point(3, 26)
        Me.chkCameraFXPalette.Name = "chkCameraFXPalette"
        Me.chkCameraFXPalette.Size = New System.Drawing.Size(114, 17)
        Me.chkCameraFXPalette.TabIndex = 0
        Me.chkCameraFXPalette.Text = "Camera FX Palette"
        Me.chkCameraFXPalette.UseVisualStyleBackColor = True
        '
        'chkCharacterPalette
        '
        Me.chkCharacterPalette.AutoSize = True
        Me.chkCharacterPalette.Location = New System.Drawing.Point(3, 49)
        Me.chkCharacterPalette.Name = "chkCharacterPalette"
        Me.chkCharacterPalette.Size = New System.Drawing.Size(108, 17)
        Me.chkCharacterPalette.TabIndex = 1
        Me.chkCharacterPalette.Text = "Character Palette"
        Me.chkCharacterPalette.UseVisualStyleBackColor = True
        '
        'chkControls
        '
        Me.chkControls.AutoSize = True
        Me.chkControls.Location = New System.Drawing.Point(3, 72)
        Me.chkControls.Name = "chkControls"
        Me.chkControls.Size = New System.Drawing.Size(64, 17)
        Me.chkControls.TabIndex = 14
        Me.chkControls.Text = "Controls"
        Me.chkControls.UseVisualStyleBackColor = True
        '
        'chkControlPalette
        '
        Me.chkControlPalette.AutoSize = True
        Me.chkControlPalette.Location = New System.Drawing.Point(3, 95)
        Me.chkControlPalette.Name = "chkControlPalette"
        Me.chkControlPalette.Size = New System.Drawing.Size(95, 17)
        Me.chkControlPalette.TabIndex = 15
        Me.chkControlPalette.Text = "Control Palette"
        Me.chkControlPalette.UseVisualStyleBackColor = True
        '
        'chkUnitSeatsMapping
        '
        Me.chkUnitSeatsMapping.AutoSize = True
        Me.chkUnitSeatsMapping.Location = New System.Drawing.Point(3, 118)
        Me.chkUnitSeatsMapping.Name = "chkUnitSeatsMapping"
        Me.chkUnitSeatsMapping.Size = New System.Drawing.Size(119, 17)
        Me.chkUnitSeatsMapping.TabIndex = 16
        Me.chkUnitSeatsMapping.Text = "Unit Seats Mapping"
        Me.chkUnitSeatsMapping.UseVisualStyleBackColor = True
        '
        'chkLightingZoneSets
        '
        Me.chkLightingZoneSets.AutoSize = True
        Me.chkLightingZoneSets.Location = New System.Drawing.Point(3, 141)
        Me.chkLightingZoneSets.Name = "chkLightingZoneSets"
        Me.chkLightingZoneSets.Size = New System.Drawing.Size(115, 17)
        Me.chkLightingZoneSets.TabIndex = 17
        Me.chkLightingZoneSets.Text = "Lighting Zone Sets"
        Me.chkLightingZoneSets.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 483)
        Me.Controls.Add(Me.DebugTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkAll)
        Me.Controls.Add(Me.cmbMaps)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.btnRemoveSelected)
        Me.Controls.Add(Me.btnLoadMap)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "quickSCNR"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLoadMap As Button
    Friend WithEvents openMapDialog As OpenFileDialog
    Friend WithEvents saveMapDialog As SaveFileDialog
    Friend WithEvents btnRemoveSelected As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents chkKillTriggers As CheckBox
    Friend WithEvents chkSoftCeilings As CheckBox
    Friend WithEvents chkSafeZones As CheckBox
    Friend WithEvents chkCrates As CheckBox
    Friend WithEvents chkDecals As CheckBox
    Friend WithEvents chkDecalPalette As CheckBox
    Friend WithEvents chkVehiclePalette As CheckBox
    Friend WithEvents chkEquipment As CheckBox
    Friend WithEvents chkEquipmentPalette As CheckBox
    Friend WithEvents chkWeapons As CheckBox
    Friend WithEvents chkWeaponPalette As CheckBox
    Friend WithEvents chkSoundScenery As CheckBox
    Friend WithEvents chkSoundSceneryPalette As CheckBox
    Friend WithEvents chkVehicles As CheckBox
    Friend WithEvents chkAll As CheckBox
    Friend WithEvents chkEffectScenery As CheckBox
    Friend WithEvents chkEffectSceneryPalette As CheckBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents chkMapVariantSceneryPalette As CheckBox
    Friend WithEvents chkMapVariantTeleporterPalette As CheckBox
    Friend WithEvents chkMapVariantGoalPalette As CheckBox
    Friend WithEvents chkMapVariantSpawnerPalette As CheckBox
    Friend WithEvents chkDeadTeammateInfluence As CheckBox
    Friend WithEvents chkAIUserHintData As CheckBox
    Friend WithEvents chkScripts As CheckBox
    Friend WithEvents chkGlobals As CheckBox
    Friend WithEvents chkScriptReferences As CheckBox
    Friend WithEvents chkScriptingData As CheckBox
    Friend WithEvents chkCutsceneFlags As CheckBox
    Friend WithEvents chkScenarioClusterData As CheckBox
    Friend WithEvents chkSpawnData As CheckBox
    Friend WithEvents chkObjectNames As CheckBox
    Friend WithEvents chkScenery As CheckBox
    Friend WithEvents chkSceneryPalette As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DebugTxt As Label
    Friend WithEvents cmbMaps As ComboBox
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents chkAtmosphere As CheckBox
    Friend WithEvents chkCameraFXPalette As CheckBox
    Friend WithEvents chkCharacterPalette As CheckBox
    Friend WithEvents chkControls As CheckBox
    Friend WithEvents chkControlPalette As CheckBox
    Friend WithEvents chkUnitSeatsMapping As CheckBox
    Friend WithEvents chkLightingZoneSets As CheckBox
End Class
