using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProjectSupport
{
   


    public partial class LoginForm : Form
    {
        public static List<Color> appearanceColor = new List<Color>()
            {
                Color.FromArgb(24, 49, 83), // green
                Color.FromArgb(99, 230, 190),//darkblue
                Color.FromArgb(36, 35, 80)//darkviolet


            };

        bool mouseDown;
        Point mousePos;
        

        private static LoginForm _instance;
        public static LoginForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LoginForm();
                return _instance;
            }


            
        }


        public LoginForm()
        {
            InitializeComponent();

            loginAppearance();
        }

        

        



        private void LoginForm_Load(object sender, EventArgs e)
        {
            _instance = this;
        }

        

        public Users UserInfo { get; set; }

        private void loginBt_Click(object sender, EventArgs e)
        {
            using (ProjectDB db = new ProjectDB())
            {
                var loginQuery = (from user in db.Users
                                  where user.UserName == loginTB.Text && user.UserPassword == passwdTB.Text 
                                  select user).SingleOrDefault();
                if(loginQuery != null)
                {
                    UserInfo = loginQuery;
                    if (loginQuery.Roles.RoleId == 1)
                    {

                        this.Hide();
                        using (AdminForm adminForm = new AdminForm())
                        {
                            adminForm.UserID = loginQuery.UserId;
                            adminForm.ShowDialog();
                        }
                    }
                    else if (loginQuery.Roles.RoleId == 2)
                    {
                        this.Hide();
                        using(UserForm userForm = new UserForm())
                        { 
                            userForm.UserID = loginQuery.UserId;
                            userForm.ShowDialog();}

                    }
                }
                

                
                else
                {
                    MessageBox.Show("wrong login or password","Wrong" ,MessageBoxButtons.OK);
                }

            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            mousePos.X = e.X;
            mousePos.Y = e.Y;
            mouseDown = true;
        }

        

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
                mouseDown = false;
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {

                Point currentPos = PointToScreen(e.Location);
                Location = new Point(currentPos.X - mousePos.X, currentPos.Y - mousePos.Y);
            }
        }
    
    
     void loginAppearance()
        {
            
            


            this.BackColor = appearanceColor[0];
            this.panel1.BackColor = appearanceColor[1];
            this.passwdTB.BackColor = appearanceColor[2];
            this.loginTB.BackColor = appearanceColor[2];
            this.loginBt.BackColor = appearanceColor[2];
            this.loginBt.FlatAppearance.BorderColor = appearanceColor[1];
            this.Font = new Font(this.Font, FontStyle.Bold);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
    






}
