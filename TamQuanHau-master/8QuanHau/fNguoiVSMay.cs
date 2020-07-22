using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace _8QuanHau
{
    public partial class fNguoiVSMay : Form
    {
        QLBanCo BanCo;
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        public fNguoiVSMay()
        {
            player.URL = Application.StartupPath + "\\resources\\Kiss-the-rain.mp3";
            player.controls.play();
            InitializeComponent();
            BanCo = new QLBanCo(pnBanCo,1);
            BanCo.EndedGame += BanCo_EndedGame;
            BanCo.Playermarked += BanCo_Playermarked;

            
        }

        void EndGame()
        {
            pnBanCo.Enabled = false;

            if (BanCo.n < 8)
            {
                MessageBox.Show("Game over!\n Ban da thua.Hay thu lai van moi!");

            }
            else
            {
                MessageBox.Show("Game over!\n Ban da chien thang!");

            }
        }
        void NewGame()
        {
            
            BanCo.VeBanCo();
        }

        private void BanCo_Playermarked(object sender, EventArgs e)
        {
        }

        private void BanCo_EndedGame(object sender, EventArgs e)
        {
            EndGame();
        }


        private void newGameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NewGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fNguoiVSMay_FormClosing(object sender, FormClosingEventArgs e)
        {
            //tmCoolDown.Enabled = false;
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
              //  tmCoolDown.Enabled = true;
                e.Cancel = true;
            }
            else
            {
                //tmCoolDown.Stop();
                player.controls.stop();
            }
        }

        int dem = 0;
        private void btn_sound_Click(object sender, EventArgs e)
        {
            if (dem == 0)
            {
                dem = 1;
                player.controls.pause();
                btn_sound.BackgroundImage = Image.FromFile(Application.StartupPath + "\\resources\\no-sound.png");
            }
            else
            {
                dem = 0;
                player.controls.play();
                btn_sound.BackgroundImage = Image.FromFile(Application.StartupPath + "\\resources\\sound.png");
            }
        }
        

        private void fNguoiVSMay_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BanCo.GoiY();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BanCo.Checkkk();
        }
    }
}
