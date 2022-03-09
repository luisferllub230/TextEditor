using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextEditor.Controller;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        form1Controller c1 = new form1Controller();
       

        public Form1()
        {
            InitializeComponent();
        }

        //abrir un archivo ya existente
        private void Abrir_Click(object sender, EventArgs e)
        {
            string arch = c1.abrir();
            if (arch!=null) 
            {
                using (StreamReader sr = new StreamReader(arch))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                }
            }
        }

        //
    }
}
