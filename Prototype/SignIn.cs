using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;// need to call RC2 CryptoServiceProvider

namespace Prototype
{
    public partial class SignIn : Form
    {
        public static string filename = @"\\ATS-V-FS12\StudentHome$\year2012\FAdam95274\Visual Studio 2013\Projects\Lawfirm\Prototype\Users.txt";

        public SignIn()
        {
            InitializeComponent();
            //this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignIn_FormClosed);

        }

        //private void SignIn_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    (new Login()).Show();
        //}

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            if (User_txt.TextLength >= 4 && User_txt.TextLength <= 15 && Pass_txt.TextLength >= 6 && Pass_txt.TextLength <= 20 && Pass_txt.Text == ReEnter_txt.Text)
            {
                var username = User_txt.Text;
                var password = Pass_txt.Text;
                //FileStream filestream = new FileStream();
                //StreamReader UserCheck = new StreamReader(filename);
                //var Txt = UserCheck.();
                foreach (string line in File.ReadLines(filename))
                {
                    if (line.Contains(username))
                    {
                        MessageBox.Show("Another User already has this username");
                        return;
                    }
                }
                StreamWriter Usersave = new StreamWriter(filename, append: true);
                RC2CryptoServiceProvider rc2CSP = new RC2CryptoServiceProvider();//creates a new encryptor
                Byte[] Byte_IV = rc2CSP.IV;//sets a IV
                String IV = Convert.ToBase64String(Byte_IV);//iv must be unique but doesnt need to be secret
                var input = password;
                var output = Encode.EncryptText(input, IV);
                Usersave.WriteLine(username);
                Usersave.WriteLine(output);
                Usersave.WriteLine(IV);
                Usersave.Close();
                this.Hide();
                var LForm = new Login();
                LForm.Closed += (s, args) => this.Close();
                LForm.Show();
            }
            else
            {
                MessageBox.Show("make sure that the usernames and passwords are valid");
            }
        }

        private void ReEnter_txt_TextChanged(object sender, EventArgs e)
        {
            if (ReEnter_txt.Text == Pass_txt.Text)
            {
                ReEnter_lbl.Text = "Passwords are the same";
            }
            else
            {
                ReEnter_lbl.Text = "Passwords need to be the same";
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var LForm = new Login();
            LForm.Closed += (s, args) => this.Close();
            LForm.Show();
        }
    }
}
