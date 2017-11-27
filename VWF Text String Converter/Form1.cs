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
        public Dictionary<string,int> fontMap = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FName = "melissa 8x8.png";
            FontImage = new Bitmap(FName);
            imgFontMap.Image = FontImage;
            fontMap.Add("a",8);
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            
        }



        /*private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FName = "/melissa 8x8.png";
            FontImage = new Bitmap(FName);
            imgFontMap.Image = FontImage;
        }*/


    }
}
