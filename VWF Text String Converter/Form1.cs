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
        public string fName;
        public Bitmap fontImage;
        public Bitmap textString;
        public Bitmap srcLetter;
        public Bitmap destLetter;
        public string textInput;
        public char[] textArray;
        public int textLetter;
        public int tileNum;
        public int tileWidth;
        public int tileHeight;
        public int sourceX;
        public int sourceY;
        //public Rectangle rectSrc = new Rectangle();
        //public Rectangle rectDest = new Rectangle();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fName = "melissa 8x8 mod.bmp";
            fontImage = new Bitmap(fName);
            imgFontMap.Image = fontImage;
            
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
                    sourceX = (textLetter % 16) * tileWidth;
                    sourceY = (textLetter / 16) * tileHeight;
                    DrawLetter(sourceX, sourceY);
                    

                }

            }
        }

        public void DrawLetter(int srcX, int srcY)
        {
            Image newImage = Image.FromFile(fName);
            Rectangle srcRect = new Rectangle(sourceX,sourceY,tileWidth,tileHeight);
            GraphicsUnit units = GraphicsUnit.Pixel;
            Graphics.DrawImage(newImage, srcX, srcY, srcRect, units);
        }
    }
}
