using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserProject.Controllers;
using UserProject.Models;

namespace UserProject.Views
{
    public partial class EditUsersView : Form
    {
        public EditUsersView(Users data)
        {
            InitializeComponent();
            EditUserController controller = new EditUserController(data, rolesComboBox, nameTextBox, phoneMaskedTextBox);

            Load += controller.EditUsersView_Load;
            applyButton.Click += controller.applyButton_Click;
            cancelButton.Click += controller.cancelButton_Click;

            applyButton.DialogResult = DialogResult.OK;
            cancelButton.DialogResult = DialogResult.Cancel;
        }

      
    }
}
