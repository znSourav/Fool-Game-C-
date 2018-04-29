using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fool_Game
{
    public partial class FoolGame : Form
    {
        public FoolGame()
        {
            InitializeComponent();
        }

        private void ButtonEnter(object sender, EventArgs e)
        {
            Random r = new Random();

            int x = r.Next(this.Size.Width - this.NoButton.Size.Width-90);
            int y = r.Next(this.Size.Height - this.NoButton.Size.Height-38);
            this.NoButton.Location = new Point(x, y);
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            string buttonText = ((Button)sender).Text;
            if (buttonText == YesButton.Text)
            { 
                YesPanel.Visible = true;
                NoPanel.Visible = false;
            }
            else if(buttonText == NoButton.Text)
            {
                YesPanel.Visible = true;
                NoPanel.Visible = true;
            }
            else if(buttonText == TryButton.Text)
            {
                this.YesButton.Location = new Point(201, 223);
                this.NoButton.Location = new Point(414, 223);

                YesPanel.Visible = false;
                NoPanel.Visible = false;
            }
            else if(buttonText == FExitButton.Text)
            {
                Application.Exit();
            }
            else if(buttonText == ReplayButton.Text)
            {
                YesButton.Location = new Point(201, 223);
                NoButton.Location = new Point(414, 223);

                NoPanel.Visible = false;
                YesPanel.Visible = false;

            }
            else if(buttonText == NExitButton.Text)
            {
                Application.Exit();
            }
        }
    }
}
