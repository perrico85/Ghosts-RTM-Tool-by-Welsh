using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS3Lib;

namespace WindowsFormsApplication1
{
    class Addresses
    {
        public static uint AntibanOffset1 = 0x700ADC;
        public static uint AntibanOffset2 = 0x6FF4D8;
        public static uint AntibanOffset3 = 0x6FF164;
        public static uint AntibanOffset4 = 0x700AD4;
        public static uint AntibanOffset5 = 0x700AD8;
        public static uint AntibanOffset6 = 0x6F41E8;
        //lobby settings
        public static uint Knockback = 0x01CA2858;
        public static uint Timescale = 0x01CB5578;
        public static uint FlyMode = 0x5D5DE8;
        public static uint MaxFallDamage = 0xDE394;
        public static uint LobbyPlayerSpeed = 0x22E01E;
        public static uint JumpHeight = 0xEC708;
        public static uint Gravity = 0x22FE72;
        public static uint Invisible = 0x0177EA25;
        public static uint MinFallDamage = 0xF905C;
        public static uint GodModeAll = 0x23D1E0;
        public static uint FullAuto = 0x10EA9C;
        public static uint WallBreach = 0x22DFCE;
        //non host
        public static uint AdvancedUAV = 0x140A3A;
        public static uint NoRecoil = 0x6C65C0;
        public static uint Laser = 0x52DDE7;
        public static uint ChromePlayer = 0x478D5B;
        public static uint PlayerColour = 0x01CBEDB8;
        public static uint SteadyAim = 0x1215CC;
        public static uint SkyColour = 0x01CBF0B8;
        public static uint WallhackGlow = 0x16AB63;
        public static uint RedBoxes = 0x149134;
        public static uint GlowPlayers = 0x16AB63;
        public static uint SuperTargetfinder = 0x01CC4B78;
        public static uint cg_fov = 0x008A4B46;
        public static uint UAV = 0x0082F7F0;
        public static uint Wallhack = 0x0086C664;
        //MP stats   
        public static uint UnlockAll = 0x17A20B0;// (bytes in C# http =//pastebin.com/AjexHw99 )
        public static uint PreferredWeapon = 0x179DE3D;// (Prefered Weapon List http =//pastebin.com/8Cfx83Kh  )
        public static uint Prestige = 0x17A2D1C;
        public static uint XPSoldier = 0x179EDDA;
        public static uint Kills = 0x179DE79;
        public static uint Deaths = 0x179DE51;
        public static uint Score = 0x179DEA2;
        public static uint Wins = 0x179DECA;
        public static uint Losses = 0x179DE81;
        public static uint SquadPoints = 0x17A2A24;
        public static uint Killstreak = 0x179DE7D;
        public static uint Currentstreak = 0x179E74D;
        public static uint Winstreak = 0x179DE4D;
        public static uint Misses = 0x179DE86;
        public static uint Hits = 0x179DE71;
        public static uint GamesPlayed = 0x179DE69;
        public static uint TimePlayed = 0x179DEBE;  
        public static uint Name  = 0x177A238;
        public static uint ClanTag = 0xCBFF6A;
        /*GC_ (G_Client Address) = 0xF44980,
            public static UInt32 G_Client(UInt32 Index, UInt32 Client)
            {
                UInt32 GC_ = GC_;
                return GC_ + Index + (Client * 0x3700);
            }
Do G_Client Address + (The Hex) = The Address you looking for
Exmple:
G_Client + 0x1C = Teleport Offset*/

//Status:
       public static uint readScore = 0x3150;
       public static uint readRank = 0x30BF;
       public static uint readPrestige = 0x30C3;
       public static uint readKills = 0x3152;
       public static uint readDeaths = 0x3154;
       public static uint readAssists = 0x3156;
       public static uint godmode = 0xE04B2A;
       public static uint Gmode1 = 0x303C;// (On - 0x0F,0xFF,0xFF,0xFF , Off - 0x00,0x00,0x00,0x64) - G_ClientIndex
       public static uint Gmode2 = 0x1D0;// (On - 0x0F,0xFF,0xFF,0xFF , Off - 0x00,0x00,0x00,0x64) - G_ClientIndex
       public static uint Gmode3 = 0x1AA;// (On - 0xFF,0xFF , Off - 0x00,0x64) - G_EntityIndex
       public static uint Spining_Mode = G_client + 0x6C;//(0x80,0x00 = Off) (Float*)
       public static uint Teleport = G_client + 0x1C;// (Origin + 0x0 = X ,Origin + 0x4 = Y ,Origin + 0x8 = Z)
       public static uint NameInGame = G_client + 0x309C;
       public static uint ResetName = G_client + 0x301C;
       public static uint HostClanTag = G_client + 0x310C;
       public static uint KillClient = G_client + 0x24;//(0x00 - Kill (Not effective against god mode))
       public static uint ActiveUser = G_client + 0x314C;// (0x03, 0xFF - not in game, Other - In Game)
       public static uint Jetpack = G_client + 0x30;// (*Float)
       public static uint Jammer = G_client + 0x125;// (Laser - 0x01, Jammer - 0x40, Disable Weapons - 0x30, Jammer&Laser - 0x41) 
       public static uint KillAndScare = G_client + 0x24;// (0xFF,0xFF - On) (Die to turn off)
       public static uint OrangeBoxes = G_client + 0x13;// (Orange Boxes - 0x50 , Third Person - 0x07 , Both - 0x57)
       public static uint PlayerSpeed = G_client + 0x3050;// (On - 0x40 , Off - 0x3F) (*Float)
       public static uint AkimboPrimary = G_client + 0x341;// (On - 0x01 , Off - 0x00)
       public static uint AkimboSecondary = G_client + 0x351;// (On - 0x01 , Off - 0x00)
       public static uint SpectatorGodMod = G_client + 0x12;// (On - 0xFF , Off - 0x40)
       public static uint HostUAV = G_client + 0x3165;// (On - 0x01 , Off - 0x00)
       public static uint Lag = G_client + 0x2F9F;// (On - 0x00 , Off - 0x02)
       public static uint mFlag = G_client + 0x331F;// (0x00 - Off , 0x01 - NoClip ,0x02 - UFO MOD ,0x04 - Freeze)
       public static uint SkateMode = G_client + 0xE;// (On - 0x01 , Off - 0x00)
       public static uint Team = G_client + 0x3063;//  (Free For All - 0x08 ,Spectator Team - 0x03 ,Federation Team - 0x01 ,Ghosts Team - 0x02)
       public static uint ImpactBullets = G_client + 0x30D3;//(0xFF - On , 0x60 - Off)
       public static uint AllPerks = G_client + 0xA2A;//(On - 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF)
        //(Off - 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02, 0x00, 0xC0, 0x80, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00)
       public static uint Alive = 0x2F83;// (0x03 - Connecting, 0x02 - Spectator, 0x01 - Dead,0x00 - Alive)
//Ammo: [0x0F,0xFF,0xFF,0xFF = Inffintie Ammo | 0x00,0x00,0x00,0x1E - 31 Bullets]
       public static uint Client_Team = G_client + 0x3063;
       public static uint PrimaryBullets = G_client + 0x558;
       public static uint PrimaryClip = PrimaryBullets - 0xF0;
       public static uint SecondaryBullets = PrimaryBullets + 0x10;
       public static uint SecondaryClip = PrimaryBullets - 0xE0;
       public static uint Lethal = PrimaryBullets - 0x20;
       public static uint Tactical = PrimaryBullets - 0x10;
        // Soldier EXP
        public static uint soldier1 = 0x179eddc;
        public static uint soldier2 = 0x179f430;
        public static uint soldier3 = 0x179f8a5;
        public static uint soldier4 = 0x179fe08;
        public static uint soldier5 = 0x17a036d;
        public static uint soldier6 = 0x17a08d1;
        public static uint soldier7 = 0x17a0e35;
        public static uint soldier8 = 0x17a1398;
        public static uint soldier9 = 0x17a18fc;
        public static uint soldier10 = 0x17a1e61;
        //Extinction Stats
        public static uint ExtictionPrestige = 0x17A550C;
        public static uint Level  = 0x17A5513;
        public static uint Teeth  = 0x17A60E6;
        public static uint Revive  = 0x17A550A;
        public static uint MissionCompleted  = 0x17A5532;
        public static uint MaxRelics  = 0x17A5522;
        public static uint AliensKilled = 0x17A552A;
        public static uint ExtictionRevives = 0x17A5470;
        public static uint ExtictionScore = 0x17A5574;
        public static uint ExtictionKills = 0x17A558C;
        public static uint Downs = 0x17A54C8;
        public static uint CashFlow = 0x17A54FC;
        public static uint HivesDestroyed = 0x17A54CC;
        public static uint CompletedChallenges = 0x17A54F1;
        public static uint AttemteptedChallenges = 0x17A54F5;
        //RPC
        public static uint Function_Address = 0x4851456;
        public static uint PlayerCmd_ClonePlayer = 0x2F19CC;
        public static uint G_Spawn = 0x290E58;
        public static uint G_SetModel = 0x28FA4C;
        public static uint G_TempEntity = 0x2916AC;
        public static uint G_EffectIndex = 0x2E8AE8;
        public static uint G_SpawnTurret = 0x2A2A40;
        public static uint G_Entity = 0xE04980;
        public static uint G_client = 0xF44980;
        public static uint Cbuf_AddText = 0x2B1C14;
        public static uint SV_GameSendServerCommand = 0x672444;
        public static uint G_GivePlayerWeapon = 0x2947FC;
        public static uint Add_Ammo = 0x24879C;
        public static uint SetClientViewAngles = 0x231450;
        public static uint SV_LinkEntity = 0x32C420;
        public static uint SV_UnlinkEntity = 0x32C3A0;
        public static uint SV_SetBrushModel = 0x5ECF94;
        public static uint SP_Script_Model = 0x286710;
        //public static uint G_GivePlayerWeapon = 0x2A8364;
        public static uint G_InitializeAmmo = 0x1E6838;
        public static uint Key_IsDown = 0x018EEB8;
        public static uint Dvar_GetBool = 0x04CE50C;
        public static uint Get_ServerDetails = 0x1072868;
        public static uint Disabled_CharCheck = 0x378620;
        public static uint ClientInterval = 0x3700;

        //////
        public static int ClientIndex = 0;
        public static int MaxClients = 12;
        public static int MaxClientsExt = 4;
        
    }
}

