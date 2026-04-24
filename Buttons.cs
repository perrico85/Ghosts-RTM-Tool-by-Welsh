using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS3Lib;

namespace WindowsFormsApplication1
{
    public class Buttons
    {
        public static UInt32
        //X = 262144,
        X = 4,
        Square = 805306368,
        L1 = 526336,
        L2 = 8388608,
        L3 = 35651584,
        R1 = 16777216,
        R2 = 4194304,
        R3 = 67108868,
        Crouch = 131072,
        Prone = 65536,
        StartButton = 32768;

        public static bool ButtonPressed(UInt32 clientIndex, UInt32 Button)
        {
            if (RPC.PS3.Extension.ReadUInt32(Addresses.G_client + 0x3330 + (Addresses.ClientInterval * (uint)Addresses.ClientIndex)) == Button)
                return true;
            else return false;
        }
    }
}
        
