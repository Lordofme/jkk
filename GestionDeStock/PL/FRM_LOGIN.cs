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
    public partial class FRM_LOGIN : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Heisenberg\Desktop\ISTA\GestionDeStock\GestionDeStock\COPAQ.mdf;Integrated Security=True");
        public FRM_LOGIN()
        {
            InitializeComponent();
            label2.Visible = false;
            label3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            panel1.BackColor = Color.Green;
            label2.Text = "";
        }

        private void textBox_user_Enter(object sender, EventArgs e)
        {
            if (textBox_user.Text == "Nom d'utilisateur")
            {
                textBox_user.Text = "";
            }
           
        }

        private void textBox_pass_Enter(object sender, EventArgs e)
        {
            if (textBox_pass.Text == "Mot de passe")
            {
                textBox_pass.Text = "";
                
            }

           
        }

        private void textBox_user_Leave(object sender, EventArgs e)
        {
            if (textBox_user.Text == "")
            {
                textBox_user.Text = "Nom d'utilisateur";
                panel1.BackColor = Color.Red;
            }
        }

        private void textBox_pass_Leave(object sender, EventArgs e)
        {
            if (textBox_pass.Text == "")
            {
                textBox_pass.Text = "Mot de passe";  
            }
            
        }

        public void button5_Click(object sender, EventArgs e)
        {



            if (textBox_user.Text==""||textBox_user.Text== "Nom d'utilisateur")
            {
                label2.Visible = true;
                panel2.BackColor = Color.Red;
            }
            else
            {

                label2.Visible = false;
                panel1.BackColor = Color.Green;
            }
            if (textBox_pass.Text == "" || textBox_pass.Text == "Mot de passe")
            {
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
                
            }
            if (textBox_user.Text !="" && textBox_pass.Text !="" && textBox_user.Text != "Nom d'utilisateur" && textBox_pass.Text != "Mot de passe") 
          { 
            sqlcon.Open();
            SqlDataAdapter dtadapt = new SqlDataAdapter("select * from Utilisateur where Username='" + textBox_user.Text + "'and Passcode='" + textBox_pass.Text + "'", sqlcon);
            DataTable dt = new DataTable();
            dtadapt.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                PL.FRM_MUN.Instance.Show();
                
                    if (dt.Rows[0][0].ToString() == textBox_user.Text || dt.Rows[0][0].ToString() == textBox_user.Text)
                    {
                        PL.FRM_MUN.Instance.label_authentif.Text = dt.Rows[0][2].ToString() + " " + dt.Rows[0][3].ToString();
                        PL.FRM_MUN.Instance.pictureBox1.Image = Image.FromFile(@"Images\Authentification\" + dt.Rows[0][5].ToString()+".ico");
                       
                         
                        
                    }

                
            }
            
            else
            {
                MessageBox.Show("Nom d'utilisateur ou motpass est incorrect", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
                sqlcon.Close();
            }
        }

        private void textBox_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            panel2.BackColor = Color.Green;
            textBox_pass.PasswordChar = '*';
            label3.Text = "";
        }

        private void FRM_LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void textBox_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
