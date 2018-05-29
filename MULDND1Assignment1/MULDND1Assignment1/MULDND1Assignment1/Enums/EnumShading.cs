using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum EShadingAlgorthims { GRAYSCALE, SHORT_RAINBOW, LONG_RAINBOW, YELLOW_TO_RED }

namespace MULDND1Assignment1
{
    public class EnumShading
    {
        public EShadingAlgorthims ShadingAlgorthim { get; set; }
    }
}
