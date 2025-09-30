using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaProtoGuiA
{
    public partial class Janela2 : Form
    {
        public Janela2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 Idade = (Int32)numIdade.Value;

            MessageBox.Show("Idade = " + Idade);
        }
    }
}
