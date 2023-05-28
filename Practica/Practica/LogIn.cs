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
using static System.Net.Mime.MediaTypeNames;

namespace Practica
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=L36_PC10\SQLEXPRESS;Initial Catalog=LogIn_Admin;Integrated Security=True");
        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btn_closeL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void artanButton1_Click(object sender, EventArgs e)
        {
            String username, user_password;

            username = tb_username.Text;
            user_password = tb_password.Text;

            try
            {
                String querry = "SELECT *  FROM  Login_new WHERE username = '"+tb_username.Text+"' AND password = '"+tb_password.Text+"' ";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable  dTable = new DataTable();
                sda.Fill(dTable);

                if(dTable.Rows.Count > 0 ) 
                { 
                    username = tb_username.Text;
                    user_password = tb_password.Text;

                    //pagina ce trebuie pe care ne comutam
                    Form1 form2 = new Form1();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_username.Clear();
                    tb_password.Clear();

                    //to focus username
                    tb_username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void pic_clear_Click(object sender, EventArgs e)
        {
            tb_username.Clear();
            tb_username.Clear();

            tb_username.Focus();
        }

        private void meme_Click(object sender, EventArgs e)
        {
            pic_mem.Visible = true;
            label_mem.Visible=true;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }
    }
}
