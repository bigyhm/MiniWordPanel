using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniWordPanel
{
    public partial class WordUniverse : Form
    {
        public WordUniverse()
        {
            InitializeComponent();
            this.OnSetWord += this.SetWordFun;
        }

        private void WordUniverse_Load(object sender, EventArgs e)
        {
        }

        public void ChangeWord(string val, string translate)
        {
            this.OnSetWord(val, translate);
        }

        public event Action<string, string> OnSetWord;

        private void SetWordFun(string val, string translate)
        {
            this.WordPhTextBox.Text = val;
            this.TranslateTextBox.Text = translate;
        }

        private void WordUniverse_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Parent.Visible = true;
        }
    }
}
