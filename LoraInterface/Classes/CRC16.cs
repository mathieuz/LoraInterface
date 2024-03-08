using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoraInterface.Classes
{
    public static class CRC16
    {
        internal static ushort Calc(byte[] buffer)
        {
            ushort crc = 0xFFFF;

            for (uint pos = 0; pos < buffer.Length; pos++)
            {
                crc ^= (ushort)buffer[pos];

                for (ushort i = 8; i != 0; i--)
                {
                    if ((crc & 0x0001) != 0)
                    {
                        crc >>= 1;
                        crc ^= 0xA001;

                    }
                    else
                    {
                        crc >>= 1;
                    }
                }
            }

            return crc;
        }

        internal static byte CalcAndGetHigh(byte[] buffer)
        {
            ushort crc = CRC16.Calc(buffer);
            return (byte)(crc >> 8);
        }

        internal static byte CalcAndGetLow(byte[] buffer)
        {
            ushort crc = CRC16.Calc(buffer);
            return (byte)(crc & 0x00FF);
        }
    }
}
