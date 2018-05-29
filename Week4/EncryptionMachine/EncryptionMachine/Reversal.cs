using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionMachine
{
    class Reversal : EncryptionDecryptionInterface
    {
        public String Decrypt(String input)
        {
            String output = "";
            for(int i = input.Length -1; i >= 0; i--)
            {
                output += input[i];
            }
            return output;
        }

        public String Encrypt(String input)
        {
            String output = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }
            return output;
        }
    }
}
