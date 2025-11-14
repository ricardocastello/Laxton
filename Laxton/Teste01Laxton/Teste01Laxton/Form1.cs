using System;
using System.Windows.Forms;

namespace Teste01Laxton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string letra = "";

            switch (e.KeyCode)
            {
                case Keys.D1: letra = "a"; break;
                case Keys.D2: letra = "b"; break;
                case Keys.D3: letra = "c"; break;
                case Keys.D4: letra = "d"; break;
                case Keys.D5: letra = "e"; break;
                case Keys.D6: letra = "f"; break;
                case Keys.D7: letra = "g"; break;
                case Keys.D8: letra = "h"; break;
                case Keys.D9: letra = "i"; break;
                case Keys.C: letra = "o"; break;
            }

            if (!string.IsNullOrEmpty(letra))
            {
                lblStatus.Text = $"Letra exibida: {letra}";
            }
        }
    }
}