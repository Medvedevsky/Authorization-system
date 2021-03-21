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
    public class EditUserController
    {
        private ComboBox _role;
        private TextBox _nameTextbox;
        private MaskedTextBox _phone;

        private RolesServices _services;

        private List<Roles> roles;

        private Users _data;

        public EditUserController(Users data,ComboBox role, TextBox nameTextbox, MaskedTextBox phone)
        {
            _role = role;
            _nameTextbox = nameTextbox;
            _phone = phone;
            _data = data;

            _services = new RolesServices(SqlConnectionToDataBase.ConnectionString());

        }

       
        public void EditUsersView_Load(object sender, EventArgs e)
        {
            if (_data == null)
                _data = new Users { Roles = new Roles() };

            roles = _services.GetAll();

            _role.DataSource = roles;
            _nameTextbox.Text = _data.Name;
            _phone.Text = _data.PhoneNumber;
        }

        public void applyButton_Click(object sender, EventArgs e)
        {
            
            if (_data == null)
                _data = new Users { Roles = new Roles() };

            _data.Roles = _role.SelectedItem as Roles;
            _data.RoleId = _data.Roles.Id;
            _data.Name = _nameTextbox.Text;
            _data.PhoneNumber = _phone.Text;
        }

        public void cancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
