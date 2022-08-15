using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace customDataGrid
{
    public partial class UserControl1 : UserControl
    {
        List<Muser> userList = new List<Muser>();
        int x = 23;
        int y = 100;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        public void SetDataList(List<Muser> userList)
        {
            this.userList = userList;
            DisplayData();
        }
        public void DisplayData()
        {
            for (int i=0;i<userList.Count;i++)
            {

               TextBox text = new TextBox();
               this.Controls.Add(text);
               text.Location = new Point(x,y);
               text.Name = "TextName"+i;
                text.Text = userList[i].UserName;
                x = x + 100;

                TextBox textPassword = new TextBox();
                this.Controls.Add(textPassword);
                textPassword.Location = new Point(x, y);
                textPassword.Name = "TextPassword" + i;
                textPassword.Text = userList[i].UserPassword;
                x = x + 100;

                TextBox textRole = new TextBox();
                this.Controls.Add(textRole);
                textRole.Location = new Point(x, y);
                textRole.Name = "TextRole" + i;
                textRole.Text = userList[i].UserRole;
                x = x + 100;
                addButton();
                x = 23;
                y += 20;
            }

        }
        public void addButton()
        {
            Button btn=new Button();
            this.Controls.Add(btn);
            btn.Name = "Delete";
            btn.Text = "DELETE";
            btn.Location = new Point(x,y);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool found=false;
            foreach(var i in userList)
            {
                if(i.UserName==txtSearch.Text)
                {
                    MessageBox.Show(i.UserName+ "  is Found");
                    found = true;
                }
            }
            if(! found)
            {
                MessageBox.Show("Not found");
            }
        }
    } 
}