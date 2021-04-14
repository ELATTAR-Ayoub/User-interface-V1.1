using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Application_Enterface_V1._1
{
    public partial class Log_in_Register : Form
    {

        public static string Username = "";
        public static Boolean Islogin = false;
        public Log_in_Register()
        {
            InitializeComponent();

            
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=UserRegisterLogin_Data.mdb");
        OleDbCommand com = new OleDbCommand();
        OleDbDataAdapter ada = new OleDbDataAdapter();

        private void Registerbutt_Click(object sender, EventArgs e)
        {
            SidePanelRegister.Top = Registerbutt.Top;
            SidePanel_Login.Visible = false;
        }

        private void Loginbutt_Click(object sender, EventArgs e)
        {
            SidePanel_Login.Top = Loginbutt.Top;
            SidePanel_Login.Visible = true;
        }


        private void EnterUsernameBox(object sender, EventArgs e)
        {
            if (UsernameLogin.Text.Equals("Username"))
            {
                UsernameLogin.Text = "";
            }
            if (UsernameRegister.Text.Equals("Username"))
            {
                UsernameRegister.Text = "";
            }
        }

        private void LeaveUsernameBox(object sender, EventArgs e)
        {
            if (UsernameLogin.Text.Equals(""))
            {
                UsernameLogin.Text = "Username";
            }
            if (UsernameRegister.Text.Equals(""))
            {
                UsernameRegister.Text = "Username";
            }
        }

        private void EnterPasswordBox(object sender, EventArgs e)
        {
            if (passwordLogin.Text.Equals("Password"))
            {
                passwordLogin.Text = "";
                passwordLogin.isPassword = true;

            }
            if (PasswordRegister.Text.Equals("Password"))
            {
                PasswordRegister.Text = "";
                PasswordRegister.isPassword = true;
            }

            
        }

        private void LeavePasswordBox(object sender, EventArgs e)
        {
            if (passwordLogin.Text.Equals(""))
            {
                passwordLogin.Text = "Password";
                passwordLogin.isPassword = false;
            }
            if (PasswordRegister.Text.Equals(""))
            {
                PasswordRegister.Text = "Password";
                PasswordRegister.isPassword = false;
            }
            if (Password2Register.Text.Equals(""))
            {
                Password2Register.Text = "Confirme Password";
                Password2Register.isPassword = false;
            }
        }

        private void LoadingIntoSignup(object sender, EventArgs e)
        {
            UsernameLogin.Text = "Username";
            UsernameRegister.Text = "Username";
            PasswordRegister.isPassword = false;
            Password2Register.isPassword = false;
            passwordLogin.isPassword = false;
        }
        private void CloseLogin_Register(object sender, EventArgs e)
        {
            this.Close();
            Form1 F1 = new Form1();
            F1.Show();
        }

        private void EnterPassword2(object sender, EventArgs e)
        {
            if (Password2Register.Text.Equals("Confirme Password"))
            {
                Password2Register.Text = "";
                Password2Register.isPassword = true;
            }
        }

        private void RegisterNowbutt_Click(object sender, EventArgs e)
        {
            if (UsernameRegister.Text.Equals("Username") || UsernameRegister.Text.Equals(""))
            {
                MessageBox.Show(" Your Username is incorrect \n(Usernames must be no longer than 20 characters. Usernames must contain letters (a-z)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Turn the line under the Username text boxe to Red
                UsernameRegister.LineIdleColor = Color.Red;
                UsernameRegister.Focus();
                UsernameRegister.LineFocusedColor = Color.Red;

            }
            else if (Password2Register.Text != PasswordRegister.Text)
            {
                MessageBox.Show(" The first Password dosn't match the second one","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //Turn the line under the second password text boxe to Red and empty it
                Password2Register.Text = "";
                Password2Register.LineIdleColor = Color.Red;
                Password2Register.Focus();
                Password2Register.LineFocusedColor = Color.Red;

            }
            else if (PasswordRegister.Text.Equals("Password") || Password2Register.Text.Equals("Confirme Password"))
            {
                MessageBox.Show(" Your Password is incorrect \n (At least 8 characters—the more characters the better, A mixture of both uppercase and lowercase letters, A mixture of letters and numbers.)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Turn the line under the passwords text boxes to Red
                Password2Register.LineIdleColor = Color.Red;
                PasswordRegister.LineIdleColor = Color.Red;
                Password2Register.Focus();
                Password2Register.LineFocusedColor = Color.Red;

            }
            else
            {
                con.Open();
                string Register = "INSERT INTO ID_Users VALUES ('" + UsernameRegister.Text + "', '" + PasswordRegister.Text + "')";
                com = new OleDbCommand(Register, con);
                com.ExecuteNonQuery();
                con.Close();

                //Empty all the text boxes
                UsernameRegister.Text = "";
                PasswordRegister.Text = "";
                Password2Register.Text = "";

                //Turn the line down the text box to green if the register is succefuly
                UsernameRegister.LineIdleColor = Color.Green;
                Password2Register.LineIdleColor = Color.Green;
                PasswordRegister.LineIdleColor = Color.Green;
                MessageBox.Show(" Your account has been created Successfully, Try to Login ", "Welcome with us!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RemovePasswordTheme(object sender, EventArgs e)
        {
            if (PasswordRegisterSwitch.Value == true)
            {
                PasswordRegister.isPassword = false;
            }

            if (PasswordRegisterSwitch.Value == false)
            {
                PasswordRegister.isPassword = true;
            }

        }
        private void Password2RegisterSwitch_OnValueChange(object sender, EventArgs e)
        {
            if (Password2RegisterSwitch.Value == true)
            {
                Password2Register.isPassword = false;
            }
            if (Password2RegisterSwitch.Value == false)
            {
                Password2Register.isPassword = true;
            }
        }

        private void PasswordRegisterSwitch_OnValueChange(object sender, EventArgs e)
        {
            if (PasswordRegisterSwitch.Value == true)
            {
                PasswordRegister.isPassword = false;
            }
            if (PasswordRegisterSwitch.Value == false)
            {
                PasswordRegister.isPassword = true;
            }
        }

        private void PasswordLoginSwitch_OnValueChange(object sender, EventArgs e)
        {
            if (PasswordLoginSwitch.Value == true)
            {
                passwordLogin.isPassword = false;
            }
            if (PasswordLoginSwitch.Value == false)
            {
                passwordLogin.isPassword = true;
            }
        }

        private void LoginNowbutt_Click(object sender, EventArgs e)
        {
            con.Open();
            string Login = "SELECT * FROM ID_Users WHERE Username = '" + UsernameLogin.Text + "' and Password= '" + passwordLogin.Text + "'";
            com = new OleDbCommand(Login, con);
            OleDbDataReader dr = com.ExecuteReader();

            if (dr.Read() == true)
            {
                Username = UsernameLogin.Text;
                Islogin = true;
                MessageBox.Show(" Login Successfully, Enjoy!", "Welcome with us!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Form1().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" The Username or the Password is incorrect", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsernameLogin.LineIdleColor = Color.Red;
                passwordLogin.LineIdleColor = Color.Red;
                UsernameLogin.Text = "";
                passwordLogin.Text = "";
                UsernameLogin.Focus();
                UsernameLogin.LineFocusedColor = Color.Red;
            }
            con.Close();
        }

        private void UsernameLogin_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
