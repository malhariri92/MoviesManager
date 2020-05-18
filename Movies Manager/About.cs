using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies_Manager
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            string str = "Movies Manager Application";
            int index = richTBX.Text.IndexOf(str);
            int length = str.Length;
            richTBX.Select(index, length);
            richTBX.SelectionColor = Color.Red;
            richTBX.SelectionFont = new Font("Segio UI", 12, FontStyle.Bold);
            richTBX.DeselectAll();

            str = "Mutasem Alhariri";
            index = richTBX.Text.IndexOf(str);
            length = str.Length;
            richTBX.Select(index, length);            
            richTBX.SelectionFont = new Font("Segio UI", 10, FontStyle.Bold);
            richTBX.DeselectAll();

            str = "05/01/2020";
            index = richTBX.Text.IndexOf(str);
            length = str.Length;
            richTBX.Select(index, length);
            richTBX.SelectionFont = new Font("Segio UI", 10, FontStyle.Bold);
            richTBX.DeselectAll();

            str = "1.3";
            index = richTBX.Text.IndexOf(str);
            length = str.Length;
            richTBX.Select(index, length);
            richTBX.SelectionFont = new Font("Segio UI", 10, FontStyle.Italic);
            richTBX.DeselectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
