using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor.Controller
{
    internal class form1Controller
    {
        private String _ArchivoNombre;


        public String abrir() 
        {
            OpenFileDialog OpenFile = new OpenFileDialog();

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                this._ArchivoNombre = OpenFile.FileName;
            }
            return this._ArchivoNombre;
        }
    }
}
