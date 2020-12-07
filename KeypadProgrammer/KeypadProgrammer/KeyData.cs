using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeypadProgrammer
{
    class KeyData
    {
        public byte  Key { get; set; }
        public byte Profile { get; set; }
        public byte Type { get; set; }
        public bool[] Modifiers { get; set; }
        public byte Looping { get; set; }
        public string Value { get; set; }

        public KeyData()
        {
            Modifiers = new bool[4];
            Looping = 0;
        }

        public byte[] getProgramerBytes()
        {
            byte[] data = new byte[100];
            int dataPos = 0;
            int stringPos = 0;

            byte inputType = 0x00;
            data[dataPos] = inputType;
            dataPos++;

            byte loopCommand = 0;
            if (Type == 1)
            {
                loopCommand += 1;
            }
            loopCommand += (byte)(2 * Looping);
            data[dataPos] = loopCommand;
            dataPos++;

            data[dataPos] = Profile;
            dataPos++;

            data[dataPos] = Key;
            dataPos++;

            byte inputMod = 0;
            for (int i = 0; i<4; i++)
            {
                if (Modifiers[i])
                {
                    inputMod += (byte) Math.Pow(2, i);
                }
            }
            data[dataPos] = inputMod;
            dataPos++;

            while (stringPos < Value.Length && dataPos < 99)
            {
                if (Value[stringPos] == '\\' && Value[stringPos + 1] == '$')
                {

                    data[dataPos] = Convert.ToByte(Value[stringPos + 1]);
                    dataPos++;
                    stringPos += 2;
                }
                else if (Value[stringPos] == '$')
                {
                    string hexVal = Value[stringPos + 1] + "" + Value[stringPos + 2];
                    int intVal;
                    if (Type == 1)
                    {
                        intVal = int.Parse(hexVal, System.Globalization.NumberStyles.HexNumber);
                    }
                    else
                    {
                        intVal = int.Parse(hexVal, System.Globalization.NumberStyles.HexNumber) + 136;
                    }
                    data[dataPos] = Convert.ToByte(intVal);
                    dataPos++;
                    stringPos += 3;
                }
                else
                {
                    data[dataPos] = Convert.ToByte(Value[stringPos]);
                    dataPos++;
                    stringPos++;
                }
            }

            data[dataPos] = 0xfe; //output end byte
            dataPos++;

            byte[] trimmedData = new byte[dataPos];

            Array.Copy(data, 0, trimmedData, 0, dataPos);

            return trimmedData;
        }
    }
    
}
