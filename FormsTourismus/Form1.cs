using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibo_Tourismus;

namespace Forms_Tourismus
{
    public partial class Form1 : Form
    {
        public static string pfad = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\DB.mdf;Integrated Security=True;Connect Timeout=10";
        IController controller = new ControllDB(pfad);
        public Form1()
        {        
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sight[] alle = controller.AllSight();
            listSight.DataSource = alle;

        } 

        private void TxtSuche_KeyUp(object sender, KeyEventArgs e)
        {
            listSight.DataSource = controller.AllSight(txtSuche.Text);
        }

        private void ListSight_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sight sig = listSight.SelectedItem as Sight;
            txt_sight_besch.Visible = true;
            txt_sight_besch.Text = sig.Sbeschreibung;
            img_sight.Image = Image.FromFile(Application.StartupPath + "/img/" + sig.Sbild);
           
        }

        private void Img_sight_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime datum = dateTimePicker1.Value;

            MessageBox.Show(datum.ToString("yyyy.MM.dd"));
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;

        }

        private void Tab_Suche_Click(object sender, EventArgs e)
        {

        }
    }
}
