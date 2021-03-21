namespace UserProject.Views
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.addToolStrip = new System.Windows.Forms.ToolStrip();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.changeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserIdColmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleIdColimn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addToolStrip
            // 
            this.addToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.addToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripButton,
            this.changeToolStripButton});
            this.addToolStrip.Location = new System.Drawing.Point(0, 0);
            this.addToolStrip.Name = "addToolStrip";
            this.addToolStrip.Size = new System.Drawing.Size(800, 31);
            this.addToolStrip.TabIndex = 0;
            this.addToolStrip.Text = "toolStrip1";
            // 
            // addToolStripButton
            // 
            this.addToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripButton.Image")));
            this.addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolStripButton.Name = "addToolStripButton";
            this.addToolStripButton.Size = new System.Drawing.Size(80, 28);
            this.addToolStripButton.Text = "Добавить";
            // 
            // changeToolStripButton
            // 
            this.changeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.changeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("changeToolStripButton.Image")));
            this.changeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.changeToolStripButton.Name = "changeToolStripButton";
            this.changeToolStripButton.Size = new System.Drawing.Size(82, 28);
            this.changeToolStripButton.Text = "Изменить";
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToAddRows = false;
            this.usersDataGridView.AllowUserToDeleteRows = false;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.PhoneNumberColumn,
            this.RoleColumn,
            this.UserIdColmn,
            this.RoleIdColimn});
            this.usersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersDataGridView.Location = new System.Drawing.Point(0, 31);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            this.usersDataGridView.RowHeadersWidth = 51;
            this.usersDataGridView.RowTemplate.Height = 24;
            this.usersDataGridView.Size = new System.Drawing.Size(800, 419);
            this.usersDataGridView.TabIndex = 1;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Имя пользователя";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 125;
            // 
            // PhoneNumberColumn
            // 
            this.PhoneNumberColumn.HeaderText = "Номер телефона";
            this.PhoneNumberColumn.MinimumWidth = 6;
            this.PhoneNumberColumn.Name = "PhoneNumberColumn";
            this.PhoneNumberColumn.ReadOnly = true;
            this.PhoneNumberColumn.Width = 125;
            // 
            // RoleColumn
            // 
            this.RoleColumn.HeaderText = "Роль ";
            this.RoleColumn.MinimumWidth = 6;
            this.RoleColumn.Name = "RoleColumn";
            this.RoleColumn.ReadOnly = true;
            this.RoleColumn.Width = 125;
            // 
            // UserIdColmn
            // 
            this.UserIdColmn.HeaderText = "id";
            this.UserIdColmn.MinimumWidth = 6;
            this.UserIdColmn.Name = "UserIdColmn";
            this.UserIdColmn.ReadOnly = true;
            this.UserIdColmn.Visible = false;
            this.UserIdColmn.Width = 125;
            // 
            // RoleIdColimn
            // 
            this.RoleIdColimn.HeaderText = "рольайди";
            this.RoleIdColimn.MinimumWidth = 6;
            this.RoleIdColimn.Name = "RoleIdColimn";
            this.RoleIdColimn.ReadOnly = true;
            this.RoleIdColimn.Visible = false;
            this.RoleIdColimn.Width = 125;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usersDataGridView);
            this.Controls.Add(this.addToolStrip);
            this.Name = "MainView";
            this.Text = "Список пользователей";
            this.addToolStrip.ResumeLayout(false);
            this.addToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip addToolStrip;
        private System.Windows.Forms.ToolStripButton addToolStripButton;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.ToolStripButton changeToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIdColmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleIdColimn;
    }
}