namespace LIbraryDemo.Client
{
    partial class AuthorView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnDelete = new ReaLTaiizor.Controls.Button();
            lbBirth = new ReaLTaiizor.Controls.DungeonLabel();
            lbNationality = new ReaLTaiizor.Controls.DungeonLabel();
            txtName = new ReaLTaiizor.Controls.DungeonLabel();
            btnCreate = new ReaLTaiizor.Controls.Button();
            dtBirth = new ReaLTaiizor.Controls.PoisonDateTime();
            btnNationality = new ReaLTaiizor.Controls.BigTextBox();
            txtEmail = new ReaLTaiizor.Controls.BigTextBox();
            btnUpdate = new ReaLTaiizor.Controls.Button();
            dtgData = new ReaLTaiizor.Controls.PoisonDataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgData).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom;
            btnDelete.BackColor = Color.Transparent;
            btnDelete.EnteredColor = Color.FromArgb(32, 34, 37);
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Image = null;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.InactiveColor = Color.FromArgb(32, 34, 37);
            btnDelete.Location = new Point(67, 408);
            btnDelete.Name = "btnDelete";
            btnDelete.PressedColor = Color.FromArgb(165, 37, 37);
            btnDelete.Size = new Size(136, 39);
            btnDelete.TabIndex = 39;
            btnDelete.Text = "Delete";
            btnDelete.TextAlignment = StringAlignment.Center;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbBirth
            // 
            lbBirth.Anchor = AnchorStyles.Right;
            lbBirth.AutoSize = true;
            lbBirth.BackColor = Color.Transparent;
            lbBirth.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbBirth.ForeColor = Color.FromArgb(76, 76, 77);
            lbBirth.Location = new Point(609, 227);
            lbBirth.Name = "lbBirth";
            lbBirth.Size = new Size(111, 25);
            lbBirth.TabIndex = 38;
            lbBirth.Text = "Day of birth";
            // 
            // lbNationality
            // 
            lbNationality.Anchor = AnchorStyles.Right;
            lbNationality.AutoSize = true;
            lbNationality.BackColor = Color.Transparent;
            lbNationality.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbNationality.ForeColor = Color.FromArgb(76, 76, 77);
            lbNationality.Location = new Point(609, 141);
            lbNationality.Name = "lbNationality";
            lbNationality.Size = new Size(104, 25);
            lbNationality.TabIndex = 37;
            lbNationality.Text = "Nationality";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Right;
            txtName.AutoSize = true;
            txtName.BackColor = Color.Transparent;
            txtName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.FromArgb(76, 76, 77);
            txtName.Location = new Point(609, 47);
            txtName.Name = "txtName";
            txtName.Size = new Size(66, 25);
            txtName.TabIndex = 36;
            txtName.Text = "Name:";
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Bottom;
            btnCreate.BackColor = Color.Transparent;
            btnCreate.EnteredColor = Color.FromArgb(32, 34, 37);
            btnCreate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.Image = null;
            btnCreate.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreate.InactiveColor = Color.FromArgb(32, 34, 37);
            btnCreate.Location = new Point(605, 306);
            btnCreate.Name = "btnCreate";
            btnCreate.PressedColor = Color.FromArgb(165, 37, 37);
            btnCreate.Size = new Size(235, 32);
            btnCreate.TabIndex = 35;
            btnCreate.Text = "Create";
            btnCreate.TextAlignment = StringAlignment.Center;
            btnCreate.Click += btnCreate_Click;
            // 
            // dtBirth
            // 
            dtBirth.Anchor = AnchorStyles.Right;
            dtBirth.Location = new Point(605, 255);
            dtBirth.MinimumSize = new Size(0, 30);
            dtBirth.Name = "dtBirth";
            dtBirth.Size = new Size(235, 30);
            dtBirth.TabIndex = 34;
            // 
            // btnNationality
            // 
            btnNationality.Anchor = AnchorStyles.Right;
            btnNationality.BackColor = Color.Transparent;
            btnNationality.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnNationality.ForeColor = Color.DimGray;
            btnNationality.Image = null;
            btnNationality.Location = new Point(605, 169);
            btnNationality.MaxLength = 32767;
            btnNationality.Multiline = false;
            btnNationality.Name = "btnNationality";
            btnNationality.ReadOnly = false;
            btnNationality.Size = new Size(235, 46);
            btnNationality.TabIndex = 33;
            btnNationality.TextAlignment = HorizontalAlignment.Left;
            btnNationality.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Right;
            txtEmail.BackColor = Color.Transparent;
            txtEmail.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.DimGray;
            txtEmail.Image = null;
            txtEmail.Location = new Point(605, 75);
            txtEmail.MaximumSize = new Size(235, 46);
            txtEmail.MaxLength = 32767;
            txtEmail.MinimumSize = new Size(235, 46);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = false;
            txtEmail.Size = new Size(235, 46);
            txtEmail.TabIndex = 32;
            txtEmail.TextAlignment = HorizontalAlignment.Left;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom;
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.EnteredColor = Color.FromArgb(32, 34, 37);
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Image = null;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.InactiveColor = Color.FromArgb(32, 34, 37);
            btnUpdate.Location = new Point(222, 408);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.PressedColor = Color.FromArgb(165, 37, 37);
            btnUpdate.Size = new Size(131, 39);
            btnUpdate.TabIndex = 31;
            btnUpdate.Text = "Update";
            btnUpdate.TextAlignment = StringAlignment.Center;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dtgData
            // 
            dtgData.AllowUserToResizeRows = false;
            dtgData.BackgroundColor = Color.FromArgb(255, 255, 255);
            dtgData.BorderStyle = BorderStyle.None;
            dtgData.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtgData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 243, 243);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(243, 243, 243);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgData.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgData.DefaultCellStyle = dataGridViewCellStyle2;
            dtgData.EnableHeadersVisualStyles = false;
            dtgData.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtgData.GridColor = Color.FromArgb(255, 255, 255);
            dtgData.Location = new Point(35, 47);
            dtgData.MultiSelect = false;
            dtgData.Name = "dtgData";
            dtgData.ReadOnly = true;
            dtgData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(243, 243, 243);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(243, 243, 243);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgData.RowHeadersWidth = 51;
            dtgData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgData.RowTemplate.Height = 29;
            dtgData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgData.Size = new Size(537, 343);
            dtgData.TabIndex = 30;
            dtgData.CellClick += dtgData_CellClick;
            // 
            // AuthorView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(852, 490);
            Controls.Add(btnDelete);
            Controls.Add(lbBirth);
            Controls.Add(lbNationality);
            Controls.Add(txtName);
            Controls.Add(btnCreate);
            Controls.Add(dtBirth);
            Controls.Add(btnNationality);
            Controls.Add(txtEmail);
            Controls.Add(btnUpdate);
            Controls.Add(dtgData);
            MaximumSize = new Size(870, 537);
            MinimumSize = new Size(870, 537);
            Name = "AuthorView";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AuthorView_Load;
            ((System.ComponentModel.ISupportInitialize)dtgData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.Button btnDelete;
        private ReaLTaiizor.Controls.DungeonLabel lbBirth;
        private ReaLTaiizor.Controls.DungeonLabel lbNationality;
        private ReaLTaiizor.Controls.DungeonLabel txtName;
        private ReaLTaiizor.Controls.Button btnCreate;
        private ReaLTaiizor.Controls.PoisonDateTime dtBirth;
        private ReaLTaiizor.Controls.BigTextBox btnNationality;
        private ReaLTaiizor.Controls.BigTextBox txtEmail;
        private ReaLTaiizor.Controls.Button btnUpdate;
        private ReaLTaiizor.Controls.PoisonDataGridView dtgData;
    }
}