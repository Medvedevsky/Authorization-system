using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProject.Models;
using UserProject.Services;
using UserProject.Views;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace UserProject.Controllers
{
    public class MainViewController
    {
        private DataGridView _usersDataGridView;
        private UsersServices _services;
        public MainViewController(DataGridView usersDataGridView)
        {
            _usersDataGridView = usersDataGridView;
            _services = new UsersServices(SqlConnectionToDataBase.ConnectionString());
        }

        public void GetData(List<Users> data)
        {
            _usersDataGridView.Rows.Clear();
            data = _services.GetAll();
            int res = data.Count;

            foreach(var items in data)
            {
                _usersDataGridView.Rows.Add(items.Name, items.PhoneNumber, items.Roles.Role, items.Id, items.RoleId);

            }
        }

        public void MainView_Load(object sender, EventArgs e)
        {
            GetData(_services.GetAll());
        }

        public void addToolStripButton_Click(object sender, EventArgs e)
        {
            var newDataUsers = new Users
            { Roles = new Roles() };
            var newWindow = new EditUsersView(newDataUsers);

            var res  = newWindow.ShowDialog();

            if(res == DialogResult.OK)
            {
                _usersDataGridView.Rows.Add(newDataUsers.Name, newDataUsers.PhoneNumber, newDataUsers.Roles.Role);
                _services.Add(newDataUsers);
                GetData(_services.GetAll());
            }
        }

        public void changeToolStripButton_Click(object sender, EventArgs e)
        {
            var slectedItem = _usersDataGridView.SelectedRows[0];

            int id = int.Parse(slectedItem.Cells[3].Value.ToString());
            Roles roles = new Roles
            {
                Id = int.Parse(slectedItem.Cells[3].Value.ToString()),
                Role = slectedItem.Cells[2].Value.ToString()
            };

            var data = new Users
            {
                Id = int.Parse(slectedItem.Cells[3].Value.ToString()),
                RoleId = int.Parse(slectedItem.Cells[4].Value.ToString()),
                Name = slectedItem.Cells[0].Value.ToString(),
                PhoneNumber = slectedItem.Cells[1].Value.ToString(),
                Roles = roles
            };

            var openWindow = new EditUsersView(data);

            var res = openWindow.ShowDialog();

            if(res == DialogResult.OK)
            {
                _usersDataGridView.Rows.Add(data.Name, data.PhoneNumber, data.Roles);
                _services.ChangeData(id, data);

                GetData(_services.GetAll());
            }


        }


        public void EditUsersView_Load(object sender, EventArgs e)
        {

        }

        public void applyButton_Click(object sender, EventArgs e)
        {

        }

        public void cancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
