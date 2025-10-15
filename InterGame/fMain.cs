using DrawLib;
using GameLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterGame
{
    public partial class fMain : Form
    {
        private ClickerGame clickerGame = null;
        private WFADraw draw = null;

        private bool isPlaying = false;

        public fMain()
        {
            InitializeComponent();

            draw = new WFADraw(pGameArea);
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            timerFrameUpdate.Start();
        }

        private void Update(object sender, EventArgs e)
        {
            if (clickerGame != null && isPlaying)
            {
                clickerGame.Render();
                draw.Present();
            }
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            tbPlayerName.Visible = false;
            bStart.Visible = false;
            lPlayerText.Visible = false;

            clickerGame = new ClickerGame(draw, tbPlayerName.Text, pGameArea.Width, pGameArea.Height);

            tsScore.Text = $"Score: {clickerGame.GetScore()}";

            timerUpdate.Start();
            timerGameTime.Start();

            isPlaying = true;

            menuBar.Enabled = false;
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            if (clickerGame == null || !isPlaying)
                return;

            clickerGame.AddNewFigure();

            clickerGame.LifeCycle();

            tsScore.Text = $"Score: {clickerGame.GetScore()}";
        }

        private void pGameArea_MouseClick(object sender, MouseEventArgs e)
        {
            if (clickerGame == null)
                return;

            clickerGame.OnPlayerClick(e.X, e.Y);
            tsScore.Text = $"Score: {clickerGame.GetScore()}";
        }

        private void menuBarAboutTab_Click(object sender, EventArgs e)
        {
            fAbout fAbout = new fAbout();

            fAbout.ShowDialog();
        }

        private void timerGameTime_Tick(object sender, EventArgs e)
        {
            timerUpdate.Stop();
            timerGameTime.Stop();

            clickerGame.ClearAll();
            draw.Present();

            lPlayerText.Visible = true;
            tbPlayerName.Visible = true;
            bStart.Visible = true;

            menuBar.Enabled = true;

            int score = clickerGame.GetScore();

            clickerGame = null;

            if (score >= 200)
                MessageBox.Show($"Your score is {score}", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if(score > 0)
                MessageBox.Show($"Your score is {score}, try harder!", "Meh..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show($"You dont even trying!", "Its so weak", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
