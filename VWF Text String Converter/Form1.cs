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
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Load font image";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.Multiselect = false;
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Could not open " + ofd.FileName);
                return;
            }
            FName = Path.GetFullPath(ofd.FileName);
            VWF_Font.OpenFont(ofd.FileName);
        }
    }
}
