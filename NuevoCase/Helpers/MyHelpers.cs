using System;

namespace NuevoCase.Helpers
{
    public class MyHelpers
    {
        public enum EnumType : byte
        {
            encode,
            decode
        }
        public static string Enigma(string value, EnumType process)
        {
            if (value == null)
                return "";
            string v = "";
            foreach (char s in value)
            {
                int charKod = (int)s;
                if (process == EnumType.encode)
                {
                    if (s == 'ü') v += '¼';
                    else if (s == 'Ü') v += '½';
                    else v += charKod % 2 == 0 ? Convert.ToChar(charKod + 1) : Convert.ToChar(charKod - 1);
                }
                else
                    if (s == '¼') v += 'ü';
                else if (s == '½') v += 'Ü';
                else v += charKod % 2 == 0 ? Convert.ToChar(charKod + 1) : Convert.ToChar(charKod - 1);
            }
            return v;
        }
    }
}
