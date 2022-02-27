using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tomagochi
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new Settings();
            GameTimer.Interval = 1000 / Settings.speed;
            GameTimer.Start();
            init_game();
        }
        public void init_scale(Label lbl_cur, Label lbl_max, Scale scale)
        {
            lbl_cur.Text = scale.current_value.ToString();
            lbl_max.Text = scale.max_value.ToString();
        }

        private void init_game()
        {
            new Settings();
            init_scale(lbleatCur, lblEatMax, Settings.eat);
            init_scale(lblSleepCur, lblSleepMax, Settings.sleep);
            init_scale(lblHappyCur, lblHappyMax, Settings.happy);
            init_scale(lblClearCur, lblClearMax, Settings.clear);
            init_scale(lblXpCur, lblXpMax, Settings.hp);

            lblGameOver.Visible = false;
        }

        private  void set_scales()
        {
            lblClearCur.Text = Settings.clear.current_value.ToString();
            lblHappyCur.Text = Settings.happy.current_value.ToString();
            lblSleepCur.Text = Settings.sleep.current_value.ToString();
            lbleatCur.Text = Settings.eat.current_value.ToString();
            lblXpCur.Text = Settings.hp.current_value.ToString();
        }
        bool is_die()
        {
            int cur_life = (
                Settings.eat.current_value +
                Settings.clear.current_value +
                Settings.happy.current_value + 
                Settings.sleep.current_value
                )/ 4;
            Settings.hp.current_value = cur_life;
            if(
                Settings.eat.current_value == 0||
                Settings.clear.current_value == 0||
                Settings.happy.current_value == 0||
                Settings.sleep.current_value == 0
                )
            {
                Settings.hp.current_value = 0;
                return true;
            }
            return false;
        }
        private void game_over_actions()
        {
            pbImage.BackgroundImage = Properties.Resources.Lose;
            lblGameOver.Visible = true;
            btnEat.Enabled = false;
            btnClear.Enabled = false;
            btnHappy.Enabled = false;
            btnSleep.Enabled = false;
        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            Settings.sleep  = Settings.sleep.add_value(Settings.add);
            Settings.eat = Settings.eat.sub_value(Settings.sub);
            set_scales();
            Settings.is_gameover = is_die();
        }

        private void btnEat_Click(object sender, EventArgs e)
        {
            Settings.eat =  Settings.eat.add_value(Settings.add);
            Settings.clear = Settings.clear.sub_value(Settings.sub);
            set_scales();
            Settings.is_gameover = is_die();
        }

        private void pbImage_Click(object sender, EventArgs e)
        {

        }

        private void btnHappy_Click(object sender, EventArgs e)
        {
            Settings.happy  = Settings.happy.add_value(Settings.add);
            Settings.sleep  = Settings.sleep.sub_value(Settings.sub);
            set_scales();
            Settings.is_gameover = is_die();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Settings.clear  = Settings.clear.add_value(Settings.add);
            Settings.happy = Settings.happy.sub_value(Settings.sub);
            set_scales();
            Settings.is_gameover = is_die();
        }
        void generate_action(Random random)
        {
            List<Action> list = new List<Action>() { dec_eat, dec_clear, dec_happy, dec_sleep };
            int index = random.Next(list.Count);
            (list[index])();
        }
        public void dec_clear()
        {
            Settings.clear.sub_value(Settings.sub);
            set_scales();
            Settings.is_gameover = is_die();
        }
        public void dec_happy()
        {
            Settings.happy.sub_value(Settings.sub);
            set_scales();
            Settings.is_gameover = is_die();
        }
        public void dec_sleep()
        {
            Settings.sleep.sub_value(Settings.sub);
            set_scales();
            Settings.is_gameover = is_die();
        }
        public void dec_eat()
        {
            Settings.eat.sub_value(Settings.sub);
            set_scales();
            Settings.is_gameover = is_die();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if(Settings.is_gameover)
            {
                game_over_actions();
            }
            else
            {
                Random random = new Random();
                int is_action = random.Next(0, 51);
                if (is_action == 0)
                {
                    generate_action(random); 
                }

            }
        }
    }
}
