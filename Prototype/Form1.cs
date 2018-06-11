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

namespace Prototype
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)// starts the login process
        {
            using(TextReader reader = File.OpenText(SignIn.filename))//opens up the text file to be read
            {
                string line = null;//sets a new variable called line to null

                while (true)//loops infinitely until the code breaks out of the loop
                {
                    if (line == null)//checks if the line is null
                    {
                        line = reader.ReadLine();//reads next line
                        if (line == null)//if the next line is null too, it assumes it is the end of the text file and
                        {
                            MessageBox.Show("no such user and password combo");//displays a 'error msg'
                            break;// quits the loop
                        }
                    }
                    if (line.Contains(user_txt.Text))//checks if the line has the same text as the                  
                    {
                        string user = line;
                        string EncodedPass = reader.ReadLine();
                        string IV = reader.ReadLine();
                        string pass = Encode.DecryptText(EncodedPass, IV);
                        if (pass == pass_txt.Text)
                        {
                            this.Hide();
                            var MForm = new Main();
                            MForm.Closed += (s, args) => this.Close();
                            MForm.Show();
                            break;
                        }
                        else
                        {
                            line = reader.ReadLine();
                        }
                    }
                    else
                    {
                        line = null;
                    }
                }       
            }
        }

        private void NewUser_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var SForm = new SignIn();
            SForm.Closed += (s, args) => this.Close();
            SForm.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}
