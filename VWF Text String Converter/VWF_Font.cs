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
    public class VWF_Font
    {
        Bitmap FontImage;

        public void OpenFont(string Name)
        {
            FontImage = new Bitmap(Name);
        }
    }
}
