using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionMachine
{
    interface EncryptionDecryptionInterface
    {
        String Encrypt(String input);
        String Decrypt(String input);
    }
}
