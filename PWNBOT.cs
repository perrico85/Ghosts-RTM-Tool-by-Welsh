using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS3Lib;

namespace WindowsFormsApplication1
{
    #region Aimbot
    public static class PWNBOT    
    {
        public static PS3API PS3 = new PS3API(SelectAPI.ControlConsole);
        public class Offsets
        {
            public static uint g_client = 0xF44980;
            public static uint clientSize = 0x3700;
            public static uint g_entity = 0xE04980;
            public static uint entitySize = 0x280;
            public static uint setClientViewAngles = 0x231450;
        }
        public static float[] ReadSingle(uint address, int length)
        {
            byte[] memory = RPC.PS3.Extension.ReadBytes(address, length * 4);
            ReverseBytes(memory);
            float[] numArray = new float[length];
            for (int index = 0; index < length; ++index)
                numArray[index] = BitConverter.ToSingle(memory, (length - 1 - index) * 4);
            return numArray;
        }
        public static void WriteSingle(UInt32 address, float[] input)
        {
            Int32 length = input.Length;
            Byte[] array = new Byte[length * 4];
            for (Int32 i = 0; i < length; i++)
            {
                ReverseBytes(BitConverter.GetBytes(input[i])).CopyTo(array, (Int32)(i * 4));
            }
            RPC.PS3.SetMemory(address, array);
        }

        public static byte[] ReverseBytes(Byte[] toReverse)
        {
            Array.Reverse(toReverse);
            return toReverse;
        }
        public static uint G_Client(int client)
        {
            return Offsets.g_client + (Offsets.clientSize * (uint)client);
        }
        public static uint G_Entity(int client)
        {
            return Offsets.g_entity + (Offsets.entitySize * (uint)client);
        }
        public static float[] getOrigin(int client)
        {
            return ReadSingle(G_Client(client) + 0x1C, 3);
        }
        public static float[] vectoangles(float[] Angles)
        {
            float num2;
            float num3;
            float[] numArray = new float[3];
            if ((Angles[1] == 0f) && (Angles[0] == 0f))
            {
                num2 = 0f;
                if (Angles[2] > 0f)
                {
                    num3 = 90f;
                }
                else
                {
                    num3 = 270f;
                }
            }
            else
            {
                if (Angles[0] != -1f)
                {
                    num2 = (float)((Math.Atan2((double)Angles[1], (double)Angles[0]) * 180.0) / 3.1415926535897931);
                }
                else if (Angles[1] > 0f)
                {
                    num2 = 90f;
                }
                else
                {
                    num2 = 270f;
                }
                if (num2 < 0f)
                {
                    num2 += 360f;
                }
                float num = (float)Math.Sqrt((double)((Angles[0] * Angles[0]) + (Angles[1] * Angles[1])));
                num3 = (float)((Math.Atan2((double)Angles[2], (double)num) * 180.0) / 3.1415926535897931);
                if (num3 < 0f)
                {
                    num3 += 360f;
                }
            }
            numArray[0] = -num3;
            numArray[1] = num2;
            return numArray;
        }
        public static float[] getVector(int shooter, int victim)
        {
            float[] numArray = getOrigin(shooter);
            float[] numArray2 = getOrigin(victim);
            return new float[] { (numArray2[0] - numArray[0]), (numArray2[1] - numArray[1]), (numArray2[2] - numArray[2]) };
        }
        public static int nearestPlayer(int shooter)
        {
            int victim = -1;
            float closest = float.MaxValue;
            for (int i = 0; i < 12; i++)
            {
                float XYZ = getOrigin(shooter)[0] - getOrigin(i)[0];
                float distance = (float)Math.Sqrt(XYZ * XYZ);
                if ((i != shooter))
                {
                    if (distance < closest)
                    {
                        victim = i;
                        closest = distance;
                    }
                }
            }
            return victim;
        }
        public static void setClientViewAngles(int client)
        {
            int victim = nearestPlayer(client);
            float[] angles = vectoangles(getVector(client, victim));
            WriteSingle(0x10004000, angles);
            RPC.Call(Offsets.setClientViewAngles, new object[] { G_Entity(client), 0x10004000, angles });
        }
    }
}
    #endregion