using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reinforce_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_level.Text = "0";
            txt_rate.Text = Convert.ToString(Convert.ToDouble(10000) / 100);

        }
        public int reinforce(int level)
        {
            Random random = new Random();
            double rate = cal_rate(level);
            int result = random.Next(0, 10001);

            if(result <= rate)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
        }
        public int cal_rate(int level)
        {
            int rate = Convert.ToInt32(100*100 * Math.Exp(-1 * Convert.ToDouble(level) / 10));
            return rate;
        }

        public void set_rate(int level)
        {
            txt_rate.Text =Convert.ToString(Convert.ToDouble(cal_rate(level)) / 100);
        }
        private void btn_reinforce_Click(object sender, EventArgs e)
        {
            int level = Convert.ToInt32(txt_level.Text);
            int result = reinforce(level);

            if(result == 1)
            {
                level += 1;
                txt_level.Text = level.ToString();
                set_rate(level);
                MessageBox.Show("성공했습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                level = 0;
                txt_level.Text = level.ToString();
                set_rate(level);
                txt_money.Text = (Convert.ToInt32(txt_money.Text) - 100).ToString();
                MessageBox.Show("실패했습니다.", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            txt_money.Text = (Convert.ToInt32(txt_money.Text) + (Convert.ToInt32(txt_level.Text) * 100)).ToString();
            txt_level.Text = "0";
            set_rate(0);
            MessageBox.Show("판매하였습니다.", "판매", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_keep_Click(object sender, EventArgs e)
        {
            if(txt_level.Text != "0")
            {
                inventory.Items.Add(txt_level.Text);
                txt_level.Text = "0";
                set_rate(0);
                txt_money.Text = (Convert.ToInt32(txt_money.Text) - 100).ToString();
            }
            
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            if (txt_level.Text == "0")
            {
                txt_level.Text = inventory.SelectedItems[0].Text;
                inventory.SelectedItems[0].Remove();
                set_rate(Convert.ToInt32(txt_level.Text));
            }
            else if(txt_level.Text != "0")
            {
                inventory.Items.Add(txt_level.Text);
                txt_level.Text = inventory.SelectedItems[0].Text;
                inventory.SelectedItems[0].Remove();
                set_rate(Convert.ToInt32(txt_level.Text));
            }
        }
    }
}
