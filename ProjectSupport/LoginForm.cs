using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSupport
{

   

    public partial class LoginForm : Form
    {
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
    }
}
