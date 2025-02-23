using System;
namespace OECasualCSharp
{
    public class Util
    {
        public static int ConvertKey(int key)
        {
            switch (key)
            {
                case 32:
                    return key;
                case 33:
                case 34:
                case 35:
                case 36:
                    break;
                case 37:
                    return 256;
                case 38:
                    return 259;
                case 39:
                    return 258;
                case 40:
                    return 257;
                default:
                    if (key == 192)
                    {
                        return 64;
                    }
                    break;
            }
            return 32 + key;
        }
        public static bool IsSpecialKey(int key)
        {
            return key == 18;
        }
    }
}
