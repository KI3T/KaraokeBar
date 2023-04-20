using KaraokeBar.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeBar.SecondView
{
    public partial class formAccountManage : Form
    {
        public formAccountManage()
        {
            InitializeComponent();

            LoadAccountList();
        }

        void LoadAccountList()
        {
            string query = "SELECT * FROM dbo.Account";

            gridControlAccount.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
