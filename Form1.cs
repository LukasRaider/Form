using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Lukas_Huvar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StatBar.Text = DateTime.Now.ToString("hh:mm:ss");
            timer1.Start();
            timer2.Start();
        }

        private void BtSoucet_Click(object sender, EventArgs e)
        {

            String A, B;
            int Soucet = 0;

            A = TBA.Text;
            B = TBB.Text;

            int Ai = int.Parse(A);
            int Bi = int.Parse(B);

            Soucet = Ai + Bi;

            LabVys.Text = Soucet.ToString();

            
        }

        private void TRBarstat_Scroll(object sender, EventArgs e)
        {
            LabDisk.Text = TRBarstat.Value.ToString();
            
        }

        private void Napoveda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Napoveda");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tlacitko 1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tlacitko 2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tlacitko 3");
        }

        private void CbDruh_KeyPress(object sender, KeyPressEventArgs e)
        {
            // zapis do combo boxu pomoci enteru
            if (e.KeyChar == 13)
            {
                CbDruh.Items.Add(CbDruh.Text);
            }
        }

        private void otevritToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            DialogResult DR = openFileDialog1.ShowDialog();
            if (DR == DialogResult.OK)
            {
                //nacitani souboru

                string cestaSoubor = openFileDialog1.FileName;

                String obsahSouboru = System.IO.File.ReadAllText(cestaSoubor);
                TextRead.Text = obsahSouboru;

            }
            else
            {
                MessageBox.Show("Soubor nelze otevřít.");
            }



        }

        private void TipIko_Popup(object sender, PopupEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //nastaveni timera
            this.PrBCas.Increment(10);
            this.LabTime.Text = "Instalace probiha, cekejte ..." + (10 - this.PrBCas.Value / 10).ToString() + " s";
            if (this.PrBCas.Value == this.PrBCas.Maximum) timer1.Stop();
            
        }

        private void StatBar_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void RBVal_CheckedChanged(object sender, EventArgs e)
        {
            LabTyp.Text = "Vanilkova";
        }

        private void RBCok_CheckedChanged(object sender, EventArgs e)
        {
            LabTyp.Text = "Cokoladova";
        }

        private void RBMich_CheckedChanged(object sender, EventArgs e)
        {
            LabTyp.Text = "Michana";
        }

        private void CheckPos_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPos.Checked)
            {
                LabOrechy.Text = "s orisky";
            }
            else
            {
                LabOrechy.Text = "bez orisku";
            }
        }

        private void PocetKop_ValueChanged(object sender, EventArgs e)
        {
            LabPoKop.Text = PocetKop.Value.ToString();
        }

        private void CbDruh_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabDruhk.Text = CbDruh.SelectedItem.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            this.StatBar.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void ulozToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string fileToSave = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(fileToSave, TextRead.Text);
                
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void ButPic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }

}
