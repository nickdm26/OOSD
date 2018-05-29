using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionMachine
{
    class ROT13 : EncryptionDecryptionInterface
    {
        public String Decrypt(String input)
        {
            return Encrypt(input);
        }

        public String Encrypt(String input)
        {
            String output = "";
            char[] charArry = input.ToCharArray();
            int ordChar;
            for(int i = 0; i < charArry.Length; i++)
            {
                ordChar = Convert.ToInt16(charArry[i]);

                if((ordChar >= 'a') && (ordChar <= 'z'))
                {
                    if (ordChar > 'm')
                    {
                        ordChar -= 13;
                    }
                    else
                    {
                        ordChar += 13;
                    }

                }else if((ordChar >= 'A') && (ordChar <= 'Z'))
                {
                    if (ordChar > 'M')
                    {
                        ordChar -= 13;
                    }
                    else
                    {
                        ordChar += 13;
                    }
                }
            
                charArry[i] = Convert.ToChar(ordChar);
                output += charArry[i].ToString();
            }
            return output;
        }
    }
}
