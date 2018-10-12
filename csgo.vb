' 2018-10-12 18:51:08.287016 UTC

Namespace hazedumper
    Public Const timestamp as Integer = &H5BC0ED1C
    Public Shared Class netvars
        Public Const m_ArmorValue as Integer = &HB25C
        Public Const m_Collision as Integer = &H318
        Public Const m_CollisionGroup as Integer = &H470
        Public Const m_Local as Integer = &H2FAC
        Public Const m_MoveType as Integer = &H258
        Public Const m_OriginalOwnerXuidHigh as Integer = &H31A4
        Public Const m_OriginalOwnerXuidLow as Integer = &H31A0
        Public Const m_aimPunchAngle as Integer = &H301C
        Public Const m_aimPunchAngleVel as Integer = &H3028
        Public Const m_bGunGameImmunity as Integer = &H38B4
        Public Const m_bHasDefuser as Integer = &HB26C
        Public Const m_bHasHelmet as Integer = &HB250
        Public Const m_bInReload as Integer = &H3275
        Public Const m_bIsDefusing as Integer = &H38A8
        Public Const m_bIsScoped as Integer = &H389E
        Public Const m_bSpotted as Integer = &H939
        Public Const m_bSpottedByMask as Integer = &H97C
        Public Const m_clrRender as Integer = &H70
        Public Const m_dwBoneMatrix as Integer = &H2698
        Public Const m_fAccuracyPenalty as Integer = &H32E0
        Public Const m_fFlags as Integer = &H100
        Public Const m_flC4Blow as Integer = &H2980
        Public Const m_flDefuseCountDown as Integer = &H2998
        Public Const m_flDefuseLength as Integer = &H2994
        Public Const m_flFallbackWear as Integer = &H31B0
        Public Const m_flFlashDuration as Integer = &HA318
        Public Const m_flFlashMaxAlpha as Integer = &HA314
        Public Const m_flNextPrimaryAttack as Integer = &H3208
        Public Const m_flTimerLength as Integer = &H2984
        Public Const m_hActiveWeapon as Integer = &H2EE8
        Public Const m_hMyWeapons as Integer = &H2DE8
        Public Const m_hObserverTarget as Integer = &H3360
        Public Const m_hOwner as Integer = &H29BC
        Public Const m_hOwnerEntity as Integer = &H148
        Public Const m_iAccountID as Integer = &H2FB8
        Public Const m_iClip1 as Integer = &H3234
        Public Const m_iCompetitiveRanking as Integer = &H1A84
        Public Const m_iCompetitiveWins as Integer = &H1B88
        Public Const m_iCrosshairId as Integer = &HB2C8
        Public Const m_iEntityQuality as Integer = &H2F9C
        Public Const m_iFOVStart as Integer = &H31D8
        Public Const m_iGlowIndex as Integer = &HA330
        Public Const m_iHealth as Integer = &HFC
        Public Const m_iItemDefinitionIndex as Integer = &H2F9A
        Public Const m_iItemIDHigh as Integer = &H2FB0
        Public Const m_iObserverMode as Integer = &H334C
        Public Const m_iShotsFired as Integer = &HA2D0
        Public Const m_iState as Integer = &H3228
        Public Const m_iTeamNum as Integer = &HF0
        Public Const m_lifeState as Integer = &H25B
        Public Const m_nFallbackPaintKit as Integer = &H31A8
        Public Const m_nFallbackSeed as Integer = &H31AC
        Public Const m_nFallbackStatTrak as Integer = &H31B4
        Public Const m_nForceBone as Integer = &H267C
        Public Const m_nTickBase as Integer = &H3404
        Public Const m_rgflCoordinateFrame as Integer = &H440
        Public Const m_szCustomName as Integer = &H302C
        Public Const m_szLastPlaceName as Integer = &H3588
        Public Const m_thirdPersonViewAngles as Integer = &H31C8
        Public Const m_vecOrigin as Integer = &H134
        Public Const m_vecVelocity as Integer = &H110
        Public Const m_vecViewOffset as Integer = &H104
        Public Const m_viewPunchAngle as Integer = &H3010
    End Class
    Public Shared Class signatures
        Public Const convar_name_hash_table as Integer = &H2F0F8
        Public Const dwClientState as Integer = &H589B34
        Public Const dwClientState_GetLocalPlayer as Integer = &H180
        Public Const dwClientState_IsHLTV as Integer = &H4CC8
        Public Const dwClientState_Map as Integer = &H28C
        Public Const dwClientState_MapDirectory as Integer = &H188
        Public Const dwClientState_MaxPlayer as Integer = &H310
        Public Const dwClientState_PlayerInfo as Integer = &H5240
        Public Const dwClientState_State as Integer = &H108
        Public Const dwClientState_ViewAngles as Integer = &H4D10
        Public Const dwEntityList as Integer = &H4C3C4F4
        Public Const dwForceAttack as Integer = &H307DBB8
        Public Const dwForceAttack2 as Integer = &H307DBC4
        Public Const dwForceBackward as Integer = &H307DBF4
        Public Const dwForceForward as Integer = &H307DBD0
        Public Const dwForceJump as Integer = &H50DF1B8
        Public Const dwForceLeft as Integer = &H307DBE8
        Public Const dwForceRight as Integer = &H307DC0C
        Public Const dwGameDir as Integer = &H627DF0
        Public Const dwGameRulesProxy as Integer = &H51514D4
        Public Const dwGetAllClasses as Integer = &HC81474
        Public Const dwGlobalVars as Integer = &H589838
        Public Const dwGlowObjectManager as Integer = &H517B700
        Public Const dwInput as Integer = &H5087170
        Public Const dwInterfaceLinkList as Integer = &H858D24
        Public Const dwLocalPlayer as Integer = &HC5F89C
        Public Const dwMouseEnable as Integer = &HC65268
        Public Const dwMouseEnablePtr as Integer = &HC65238
        Public Const dwPlayerResource as Integer = &H307BF6C
        Public Const dwRadarBase as Integer = &H50711DC
        Public Const dwSensitivity as Integer = &HC65104
        Public Const dwSensitivityPtr as Integer = &HC650D8
        Public Const dwSetClanTag as Integer = &H88B90
        Public Const dwViewMatrix as Integer = &H4C2DF24
        Public Const dwWeaponTable as Integer = &H5087C10
        Public Const dwWeaponTableIndex as Integer = &H322C
        Public Const dwYawPtr as Integer = &HC64EC8
        Public Const dwZoomSensitivityRatioPtr as Integer = &HC69F88
        Public Const dwbSendPackets as Integer = &HD105A
        Public Const dwppDirect3DDevice9 as Integer = &HA2F20
        Public Const interface_engine_cvar as Integer = &H3E9EC
        Public Const m_nDeltaTicks as Integer = &H174
        Public Const m_pStudioHdr as Integer = &H293C
        Public Const m_pitchClassPtr as Integer = &H5071488
        Public Const m_yawClassPtr as Integer = &HC64EC8
    End Class
End Namespace
