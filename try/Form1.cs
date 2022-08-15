using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using customDataGrid;
namespace @try
{
    public partial class Form1 : Form
    {
        List<Muser> userList = new List<Muser>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0;i<10;i++)
            {
                userList.Add(new Muser(i.ToString(), i.ToString(), i.ToString(), i.ToString()));   
            }
            userControl11.SetDataList(userList);
        }
    }
}
