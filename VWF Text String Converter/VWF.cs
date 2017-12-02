using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Web;

namespace VWF_Text_String_Converter
{
    class VWF
    {
        public Bitmap fontImage;
        public string textCharData;
        public string textString;
        public void LoadBitmapFont(Bitmap fontMap, string charData)
        {
            fontImage = fontMap;
            textCharData = charData;
        }

        public void LoadString(string txtString)
        {
            textString = txtString;
        }

        public Bitmap TextStringBitmap(Bitmap fontMap, string txtString)
        {

        }
    }

    class CharacterInfo
    {

    }
}
