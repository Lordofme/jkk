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

namespace GestionDeStock.PL
{
   
    public partial class FRM_MUN : Form
    {
        //Private Constructor.  

        private static FRM_MUN instance = null;
        public static FRM_MUN Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FRM_MUN();
                }
                return instance;
            }
            

        }
       

        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Heisenberg\Desktop\ISTA\GestionDeStock\GestionDeStock\COPAQ.mdf;Integrated Security=True");
        private FRM_MUN()
        {
            InitializeComponent();
            panel1.Size =   panel1.MaximumSize;
            panel_client.Visible = false;
            dataGridView1.Visible = true;
            pnlred.Visible = false;
            dataGridView1.Visible = false;
            panel_produit.Visible = false;
            panel_contact.Visible = false;
            panel_User.Visible = false;
            panel_deconnexion.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (panel1.Size == panel1.MaximumSize)
            {
                panel1.Size = panel1.MinimumSize;
            }
            else
            {
                panel1.Size =panel1.MaximumSize;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlred.Visible = true;
            pnlred.Top =button_produit.Top;
            panel_accueil.Visible = false;
            panel_contact.Visible = false;
            panel_client.Visible = false;
            panel_produit.Visible = true;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlred.Visible = true;
            pnlred.Top = button_client.Top;
            panel_accueil.Visible = false;
            panel_contact.Visible = false;
            panel_client.Visible = true;
            panel_produit.Visible = false;
            panel_User.Visible = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            pnlred.Visible = true;
            pnlred.Top = button_categorie.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnlred.Visible = true;
            pnlred.Top = button_commande.Top;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pnlred.Visible = true;
            pnlred.Top = button_contact.Top;
            panel_accueil.Visible = false;
            panel_client.Visible = false;
            panel_produit.Visible = false;
            panel_contact.Visible = true;
            panel_User.Visible = false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void pnlred_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            FRM_LOGIN Flog = new FRM_LOGIN();
            this.Hide();
            Flog.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public void FRM_MUN_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'cOPAQDataSet3.Utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.utilisateurTableAdapter.Fill(this.cOPAQDataSet3.Utilisateur);
            // TODO: cette ligne de code charge les données dans la table 'cOPAQDataSet2.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter2.Fill(this.cOPAQDataSet2.Client);
            // TODO: cette ligne de code charge les données dans la table 'cOPAQDataSet1.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter1.Fill(this.cOPAQDataSet1.Client);
            // TODO: cette ligne de code charge les données dans la table 'cOPAQDataSet.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.cOPAQDataSet.Client);
            FRM_LOGIN Flog = new FRM_LOGIN();
      
            }

      

        private void button_ajouteclient_Click(object sender, EventArgs e)
        {

        }

        private void button_modclient_Click(object sender, EventArgs e)
        {

        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_suppclient_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        private int ImageNumber = 1;
        private void LoadNextImage()
        {
            if(ImageNumber == 6)
            {
                ImageNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"Images\{0}.jpg", ImageNumber);
            ImageNumber++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            panel_client.Visible = false;
            panel_accueil.Visible = true;
            panel_produit.Visible = false;
            panel_contact.Visible = false;
            panel_User.Visible = false;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void button3_Click_1(object sender, EventArgs e)
        {
            Form_Add_edit FrmAjout = new Form_Add_edit();
            FrmAjout.Show();
            FrmAjout.button_edit.Visible = false;
        }

        public void remplirdatagidview()
        {
            DataTable dt = new DataTable();
            if(dt.Rows!= null)
            {
                dt.Rows.Clear();
            }
            sqlcon.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Client", sqlcon);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlcon.Close();
            dataGridView1.Visible = true;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            remplirdatagidview();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button_edit_menu_Click(object sender, EventArgs e)
        {
            Form_Add_edit Frmedit = new Form_Add_edit();
            Frmedit.label1.Text = "Modifier un client";
            Frmedit.button_Save.Visible = false;
            if (dataGridView1.CurrentRow != null)
            {
                Frmedit.textBox_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Frmedit.textBox_ajout_nom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Frmedit.textBox_ajout_prenom.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Frmedit.textBox_ajoute_adress.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Frmedit.textBox_ajoute_tele.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Frmedit.textBox_ajoute_ville.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                Frmedit.textBox_ajoute_pays.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                Frmedit.Show();
            }
            else MessageBox.Show("Choisir un Client d'abord", "Editer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            
            

        }
        

        private void panel_client_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form_Add_edit FrmAddEdit = new Form_Add_edit();
            
            if (dataGridView1.CurrentRow != null && MessageBox.Show("Confirmer la suppresion ?", "Supprimer", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                sqlcon.Open();
                string requet = "delete from Client where ID_Client='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                SqlCommand comma = new SqlCommand(requet, sqlcon);
                comma.ExecuteNonQuery();
                sqlcon.Close();
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                MessageBox.Show("Client a éte Supprimer");
                sqlcon.Close();
            }
            else
             if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Choisir un client d'abord !", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_user_Click(object sender, EventArgs e)
        {
            pnlred.Visible = true;
            pnlred.Top = button_user.Top;
            panel_client.Visible = false;
            panel_accueil.Visible = false;
            panel_produit.Visible = false;
            panel_contact.Visible = false;
            panel_User.Visible = true;
        }

        private void button_fb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/JaoudaMarocOfficiel/");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/company/copag");
        }

        private void button10_Click_2(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCuqURF6a2GLa6XjhrilFShQ/featured");
        }

        private void button14_Click(object sender, EventArgs e)
        {
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Jus_Fruit jf = new Jus_Fruit();
            jf.Show();
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Frm_Prd_Laitiers prd_Laitiers = new Frm_Prd_Laitiers();
            prd_Laitiers.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
           
        }

        private void button19_Click(object sender, EventArgs e)
        {
           
        }

        private void panel_accueil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            panel_deconnexion.Visible = !panel_deconnexion.Visible; 
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            PL.FRM_MUN.instance.Close();
            FRM_LOGIN LGN = new FRM_LOGIN();
            LGN.Show();
        }
    }
}
