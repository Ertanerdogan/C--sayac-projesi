using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saatproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PCsaat()
        {
            string saat = DateTime.Now.Hour.ToString();
            string dakika = DateTime.Now.Minute.ToString();
            string saniye = DateTime.Now.Second.ToString();
            LblPC.Text = saat + ":" + dakika + ":" + saniye;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            PCsaat();
            progressBar1.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PCsaat();
            
        }
        int sayac;
        int dk;
        int sn;
        private void BtnBaslat_Click(object sender, EventArgs e)
        {
            BtnDevam.Enabled = false;
            BtnBaslat.Enabled = false;
            BtnDurdur.Enabled = true;
            int bilgi = int.Parse(TxtDk.Text);
            sayac = bilgi * 60;
            progressBar1.Maximum = sayac;
            if(sayac >= 60)
            {
                dk = sayac / 60;
                sn = sayac % 60;
           
            }
            if(sn >= 10)
            {
                LblSaat.Text = dk.ToString() + ":" + sn.ToString();
            }
            else
            {
                LblSaat.Text = dk.ToString() + ":" + "0" + sn.ToString();
            }
            timer2.Enabled = true;
        }
        int tik = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            tik++;
            LblSn.Text = tik.ToString();
            if(progressBar1.Value < sayac)
            {
                progressBar1.Value++;
            }
            
            if (sn != 0)
            {
                sn--;
            }
            if (sn == 0 && dk !=0)
            {
                sn = 59;
                dk--;
            }
            if (sn >= 10)
            {
                if(dk >=10)
                {
                    LblSaat.Text = dk.ToString() + ":" + sn.ToString();
                }
                else
                {
                    LblSaat.Text = "0" + dk.ToString() + ":" + sn.ToString();
                }
            }
            else
            {
                LblSaat.Text = dk.ToString() + ":" + "0" + sn.ToString();
            }
            
           
            if(dk == 0 && sn == 0)
            {
                timer2.Stop();
                timer2.Enabled = false;
                MessageBox.Show("Süre tamamlandı");
                BtnBaslat.Enabled = true;
            }
            
        }

        private void BtnDurdur_Click(object sender, EventArgs e)
        {
            BtnDevam.Enabled = true;
            BtnDurdur.Enabled = false;
            timer2.Stop();
        }

        private void BtnDevam_Click(object sender, EventArgs e)
        {
            timer2.Start();
            BtnDevam.Enabled = false;
            BtnDurdur.Enabled = true;
        }
    }
}
