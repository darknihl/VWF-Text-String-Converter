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
    public partial class Form1 : Form
    {
        public string FName;
        public Bitmap FontImage;
        public Bitmap textString;
        public Bitmap srcLetter;
        public Bitmap destLetter;
        public string textInput;
        public char[] textArray;
        public int textLetter;
        public int x = 0;
        public int y = 0;
        public int w = 8;
        public int h = 8;
        //public Rectangle rectSrc = new Rectangle();
        //public Rectangle rectDest = new Rectangle();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FName = "melissa 8x8 mod.bmp";
            FontImage = new Bitmap(FName);
            imgFontMap.Image = FontImage;
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textArray = txtInput.Text.ToCharArray();
                foreach (char c in textArray)
                {
                    int unicode = c;
                    textLetter = (unicode - 0x20);
                    
                    

                }

            }
        }

        public void CloneText(PaintEventArgs e)
        {
            srcLetter = FontImage.Clone(new Rectangle(x + textLetter * 8, y, 8, 8), FontImage.PixelFormat);
            destLetter = srcLetter;
            e.Graphics.DrawImageUnscaled(destLetter, 0, 0);
        }

        public static void CopyRegionIntoImage(Bitmap srcBitmap, Rectangle srcRegion, ref Bitmap destBitmap, Rectangle destRegion)
        {
            using (Graphics grD = Graphics.FromImage(destBitmap))
            {
                grD.DrawImage(srcBitmap, destRegion, srcRegion, GraphicsUnit.Pixel);
            }
        }

        //private void drawletter(painteventargs e)
        //{
        //    image newimage = image.fromfile(fname);
        //    int x = 0;
        //    int y = 0;

        //    rectangle srcrect = new rectangle(0, 0, 8, 8);
        //    graphicsunit units = graphicsunit.pixel;
        //    e.graphics.drawimage(newimage, x, y, srcrect, units);
        //}


    }
}
