using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace move_box
{
    public partial class Form1 : Form
    {
        Button btn = new Button();
        public Form1()
        {
            InitializeComponent();
            this.KeyUp += new KeyEventHandler(this.Keypress);
            btn.BackColor = Color.DodgerBlue;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Width = 40;
            btn.Height = 40;
            btn.Top = this.Height / 2 - (btn.Height / 2);
            btn.Left = this.Width / 2 - (btn.Width / 2);
            Controls.Add(btn);
        }
        private void Keypress(object obj, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up :
                    btn.Top -= 10;
                    break;
                case Keys.Down:
                    btn.Top += 10;
                    break;
                case Keys.Left:
                    btn.Left -= 10;
                    break;
                case Keys.Right:
                    btn.Left += 10;
                    break;
            }
        }
    }
}
