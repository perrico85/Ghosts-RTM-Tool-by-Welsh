using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS3Lib;

namespace WindowsFormsApplication1
{
    class Functions
    {
        public static PS3API PS3 = new PS3API(SelectAPI.ControlConsole);

        public static void SetModel(int client, string model)
        {
            RPC.Call(Addresses.G_SetModel, Addresses.G_Entity + (client * 0x280), model);
            /*Exmple:
            SetModel(0,"mp_fullbody_juggernaut_heavy_black")
          Will give Juggernaut Model to client 0*/
        }
        public static void Cbuf_AddText(UInt32 Client, String Command)
        {
            UInt32 Cbuf_AddText_Offset = 0x2B061C;
            RPC.Call(Cbuf_AddText_Offset, Client, Command);
            //Exmple: Cbuf_AddText(0,cg_fov 90);
        }
        public static void SV_GameSendServerCommand(int client, string text, int type = 0)
        {

            RPC.Call(Addresses.SV_GameSendServerCommand, client, 0, (text));
        }
        public static void NoGun(int clientNumber, string input)
        {
            SV_GameSendServerCommand(clientNumber, "a \"" + input + "\"");
        }
        public static void iPrintln(int client, string input)
        {
            SV_GameSendServerCommand(client, "c \"" + input + "\"");
        }
        public static void iPrintlnBold(int clientNumber, string input)
        {
            SV_GameSendServerCommand(clientNumber, "e \"" + input + "\"");
        }
        public static void Vision(int client, String input)
        {
            SV_GameSendServerCommand((int)client, "J \"" + input + "\"");
        }
        public static void Blury(int client, String input)
        {
            SV_GameSendServerCommand((int)client, "i \"" + input + "\"");
        }
        public static void ICE(int client, String input)
        {
            SV_GameSendServerCommand((int)client, "q 132 \"" + input + "\"");
        }
        public static void PlaySound(int client, String input)
        {
            SV_GameSendServerCommand((int)client, "n \"" + input + "\"");
        }
        public static void KickWithError(int client, String input)
        {
            SV_GameSendServerCommand((int)client, "r \"" + input + "\"");
        }
        public static void Fov(int client, String input)
        {
            SV_GameSendServerCommand((int)client, "q \"13 \"" + input + "\"");
        }
        public static void CompassSize(int client, String input)
        {
            SV_GameSendServerCommand((int)client, "q \"23 \"" + input + "\"");
        }
        public static void SendClientDvar(int clientNumber, string input)
        {
            SV_GameSendServerCommand(clientNumber, "q " + input + "");
        }
        public static void GiveWeapon(int client, int weapon, int ammo, int akimbo)
        {
            RPC.Call(Addresses.G_GivePlayerWeapon, (uint)(Addresses.G_client + (client * 0x3700)), weapon, akimbo);
            RPC.Call(Addresses.Add_Ammo, (uint)(Addresses.G_client + (client * 0x3700)), weapon, 0, ammo, 1);
            RPC.Call(Addresses.SV_GameSendServerCommand, client, 0, "a \"" + weapon + "\"");
            /*Exmple:
             GiveWeapon(0, 37, 999, 0);
             Will give a walking I.M.S to client 0*/
        }
        public static string GetNames(int clientIndex)
        {
            if (PS3.Extension.ReadByte(Addresses.NameInGame + ((uint)clientIndex * Addresses.ClientInterval)) == 0x00)
            {
                return "Not Connected";
            }
            else
            {
                return PS3.Extension.ReadString(Addresses.NameInGame + ((uint)clientIndex * Addresses.ClientInterval));
            }
        }
        public static void SetXP(int value)
        {
            Cbuf_AddText(0, "set scr_war_score_kill " + value);
            Cbuf_AddText(0, "set scr_dm_score_kill " + value);
            Cbuf_AddText(0, "set scr_dom_score_kill " + value);
            Cbuf_AddText(0, "set scr_sd_score_kill " + value);
            Cbuf_AddText(0, "set scr_dem_score_kill " + value);
            Cbuf_AddText(0, "set scr_ctf_score_kill " + value);
            Cbuf_AddText(0, "set scr_hd_score_kill " + value);
            Cbuf_AddText(0, "set scr_kc_score_kill " + value);
            Cbuf_AddText(0, "set scr_sab_score_kill " + value);
            Cbuf_AddText(0, "set scr_hq_score_kill " + value);
            Cbuf_AddText(0, "set scr_tdef_score_kill " + value);
            Cbuf_AddText(0, "set scr_conf_score_kill " + value);
            Cbuf_AddText(0, "set scr_oic_score_kill " + value);
            Cbuf_AddText(0, "set scr_sas_score_kill " + value);
            Cbuf_AddText(0, "set scr_gun_score_kill " + value);
            Cbuf_AddText(0, "set scr_shrp_score_kill " + value);
        }

        public static void SetTimelimit(int value)
        {
            Cbuf_AddText(0, "set scr_war_timelimit " + value);
            Cbuf_AddText(0, "set scr_dm_timelimit  " + value);
            Cbuf_AddText(0, "set scr_dom_timelimit " + value);
            Cbuf_AddText(0, "set scr_sd_timelimit   " + value);
            Cbuf_AddText(0, "set scr_dem_timelimit  " + value);
            Cbuf_AddText(0, "set scr_ctf_timelimit  " + value);
            Cbuf_AddText(0, "set scr_hd_timelimit  " + value);
            Cbuf_AddText(0, "set scr_kc_timelimit  " + value);
            Cbuf_AddText(0, "set scr_sab_timelimit  " + value);
            Cbuf_AddText(0, "set scr_hq_timelimit " + value);
            Cbuf_AddText(0, "set scr_tdef_timelimit  " + value);
            Cbuf_AddText(0, "set scr_conf_timelimit " + value);
            Cbuf_AddText(0, "set scr_oic_timelimit  " + value);
            Cbuf_AddText(0, "set scr_sas_timelimit  " + value);
            Cbuf_AddText(0, "set scr_gun_timelimit  " + value);
            Cbuf_AddText(0, "set scr_shrp_timelimit  " + value);
        }

        public static void ForceHostON()
        {
            Cbuf_AddText(0, "ds_serverConnectTimeout 1000");
            Cbuf_AddText(0, "ds_serverConnectTimeout 1");
            Cbuf_AddText(0, "party_minplayers 1");
            Cbuf_AddText(0, "party_maxplayers 16");
        }
        public static Int32 G_Spawn()
        {
            return RPC.Call(Addresses.G_Spawn, new object[0]);//G_Spawn
        }
        public static void TeleportPlayerToPlayer(int Player1, int Player2)
        {
            PS3.Extension.WriteFloat(Addresses.Teleport + ((uint)Player1 * Addresses.ClientInterval), PS3.Extension.ReadFloat(Addresses.Teleport + ((uint)Player2 * Addresses.ClientInterval)));
            PS3.Extension.WriteFloat(Addresses.Teleport + ((uint)Player1 * Addresses.ClientInterval) + 0x04, PS3.Extension.ReadFloat(Addresses.Teleport + ((uint)Player2 * Addresses.ClientInterval) + 0x04));
            PS3.Extension.WriteFloat(Addresses.Teleport + ((uint)Player1 * Addresses.ClientInterval) + 0x08, PS3.Extension.ReadFloat(Addresses.Teleport + ((uint)Player2 * Addresses.ClientInterval) + 0x08));
        }

        public static void JetPack(int client)
        {
            float jH = PS3.Extension.ReadFloat(Addresses.Jetpack + ((uint)Addresses.ClientIndex * Addresses.ClientInterval));
            jH += 100;
            PS3.Extension.WriteFloat(Addresses.Jetpack + ((uint)Addresses.ClientIndex * Addresses.ClientInterval), jH);
        }
        //Must be used with timer/thread/backgroundworker
        //Can be used on single player aswell, with the single player Key_IsDown function.
    }
}

