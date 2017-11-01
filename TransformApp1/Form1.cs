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
using TransformationLib;

namespace TransformApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            var amountContent = File.ReadAllText(openFileDialog1.FileName);
            var quantityContent = File.ReadAllText(openFileDialog2.FileName);
            var result = Transformation.Transform(amountContent, quantityContent);
            File.WriteAllText(saveFileDialog1.FileName, result);
        }
    }
}
