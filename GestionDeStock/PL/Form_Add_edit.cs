using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionDeStock
{
    public partial class Form_Add_edit : Form
    {
        

        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Heisenberg\Desktop\ISTA\GestionDeStock\GestionDeStock\COPAQ.mdf;Integrated Security=True");
        public Form_Add_edit()
        {
            InitializeComponent();
            
        }

        private void Form_Add_edit_Load(object sender, EventArgs e)
        {

        }

        private void textBox_ajout_nom_Enter(object sender, EventArgs e)
        {
            if (textBox_ajout_nom.Text == "Nom de Client")
            {
                textBox_ajout_nom.Text = "";
            }
        }

        private void textBox_ajout_prenom_Enter(object sender, EventArgs e)
        {
            if (textBox_ajout_prenom.Text == "Prenom de Client")
            {
                textBox_ajout_prenom.Text = "";
            }
        }

        private void textBox_ajoute_adress_Enter(object sender, EventArgs e)
        {
            if (textBox_ajoute_adress.Text == "Adress de Client")
            {
                textBox_ajoute_adress.Text = "";
            }
        }

        private void textBox_ajoute_tele_Enter(object sender, EventArgs e)
        {
            if (textBox_ajoute_tele.Text == "Telephone de Client")
            {
                textBox_ajoute_tele.Text = "";
            }
        }

        private void textBox_ajoute_ville_Enter(object sender, EventArgs e)
        {
            if (textBox_ajoute_ville.Text == "Ville de Client")
            {
                textBox_ajoute_ville.Text = "";
            }
        }

        private void textBox_ajoute_pays_Enter(object sender, EventArgs e)
        {
            if (textBox_ajoute_pays.Text == "Pays de Client")
            {
                textBox_ajoute_pays.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string requet = "insert into Client Values('"+textBox_ID.Text+"','"+textBox_ajout_nom.Text+"','"+textBox_ajout_prenom.Text+"','"+
                textBox_ajoute_adress.Text+"','"+textBox_ajoute_tele.Text+"','"+textBox_ajoute_ville.Text+"','"+textBox_ajoute_pays.Text+"')";
            SqlCommand comma = new SqlCommand(requet, sqlcon);
            comma.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("Ajouter Avec Succes", "Ajoute", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox_ID.Text = "";
            textBox_ajout_nom.Text = "";
            textBox_ajout_prenom.Text = "";
            textBox_ajoute_adress.Text = "";
            textBox_ajoute_tele.Text = "";
            textBox_ajoute_ville.Text = "";
            textBox_ajoute_pays.Text = "";


            PL.FRM_MUN.Instance.remplirdatagidview();
            //FRMM.FRM_MUN_Load((object)sender, (EventArgs)e);


        }
        private void remplirdatagrid()
        {
            
        }

        private void textBox_ID_Enter(object sender, EventArgs e)
        {
            if (textBox_ID.Text == "ID de Client")
            {
                textBox_ID.Text = "";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            //PL.FRM_MUN FrmM = new PL.FRM_MUN();
            PL.FRM_MUN.Instance.dataGridView1.Refresh();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string requet = "update Client set Nom_Client='" + textBox_ajout_nom.Text + "',Prenom_Client='" +
                textBox_ajout_prenom.Text + "',Adresse_Client='" + textBox_ajoute_adress.Text + "',Telephone_Client='" + textBox_ajoute_tele.Text +
                "',Ville_Client='" + textBox_ajoute_ville.Text + "',Pays_Client='" + textBox_ajoute_pays.Text + "'where ID_Client='"+ textBox_ID.Text+"'";
            SqlCommand comma = new SqlCommand(requet, sqlcon);
            comma.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("Le Client  " + textBox_ajout_nom.Text + " " + textBox_ajout_prenom.Text + " a été modifier avec succes");
        }
    }
}
