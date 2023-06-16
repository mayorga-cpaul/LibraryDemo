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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnDelete = new ReaLTaiizor.Controls.Button();
            lbBirth = new ReaLTaiizor.Controls.DungeonLabel();
            lbNationality = new ReaLTaiizor.Controls.DungeonLabel();
            lblName = new ReaLTaiizor.Controls.DungeonLabel();
            btnCreate = new ReaLTaiizor.Controls.Button();
            dtBirth = new ReaLTaiizor.Controls.PoisonDateTime();
            txtnationality = new ReaLTaiizor.Controls.BigTextBox();
            txtAuthorName = new ReaLTaiizor.Controls.BigTextBox();
            btnUpdate = new ReaLTaiizor.Controls.Button();
            dtgData = new ReaLTaiizor.Controls.PoisonDataGridView();
            tgUpdate = new ReaLTaiizor.Controls.ToggleButton();
            lblUpdate = new ReaLTaiizor.Controls.DungeonLabel();
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
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(76, 76, 77);
            lblName.Location = new Point(609, 47);
            lblName.Name = "lblName";
            lblName.Size = new Size(66, 25);
            lblName.TabIndex = 36;
            lblName.Text = "Name:";
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
            // txtnationality
            // 
            txtnationality.Anchor = AnchorStyles.Right;
            txtnationality.BackColor = Color.Transparent;
            txtnationality.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtnationality.ForeColor = Color.DimGray;
            txtnationality.Image = null;
            txtnationality.Location = new Point(605, 169);
            txtnationality.MaxLength = 32767;
            txtnationality.Multiline = false;
            txtnationality.Name = "txtnationality";
            txtnationality.ReadOnly = false;
            txtnationality.Size = new Size(235, 46);
            txtnationality.TabIndex = 33;
            txtnationality.TextAlignment = HorizontalAlignment.Left;
            txtnationality.UseSystemPasswordChar = false;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Anchor = AnchorStyles.Right;
            txtAuthorName.BackColor = Color.Transparent;
            txtAuthorName.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAuthorName.ForeColor = Color.DimGray;
            txtAuthorName.Image = null;
            txtAuthorName.Location = new Point(605, 75);
            txtAuthorName.MaximumSize = new Size(235, 46);
            txtAuthorName.MaxLength = 32767;
            txtAuthorName.MinimumSize = new Size(235, 46);
            txtAuthorName.Multiline = false;
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.ReadOnly = false;
            txtAuthorName.Size = new Size(235, 46);
            txtAuthorName.TabIndex = 32;
            txtAuthorName.TextAlignment = HorizontalAlignment.Left;
            txtAuthorName.UseSystemPasswordChar = false;
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
            btnUpdate.Location = new Point(214, 408);
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(243, 243, 243);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(243, 243, 243);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgData.ColumnHeadersHeight = 30;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dtgData.DefaultCellStyle = dataGridViewCellStyle5;
            dtgData.EnableHeadersVisualStyles = false;
            dtgData.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtgData.GridColor = Color.FromArgb(255, 255, 255);
            dtgData.Location = new Point(35, 47);
            dtgData.MultiSelect = false;
            dtgData.Name = "dtgData";
            dtgData.ReadOnly = true;
            dtgData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(243, 243, 243);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(243, 243, 243);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dtgData.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dtgData.RowHeadersWidth = 51;
            dtgData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgData.RowTemplate.Height = 29;
            dtgData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgData.Size = new Size(537, 343);
            dtgData.TabIndex = 30;
            dtgData.CellClick += dtgData_CellClick;
            // 
            // tgUpdate
            // 
            tgUpdate.Location = new Point(351, 407);
            tgUpdate.Name = "tgUpdate";
            tgUpdate.Size = new Size(76, 33);
            tgUpdate.TabIndex = 40;
            tgUpdate.Text = "toggleButton1";
            tgUpdate.Toggled = false;
            tgUpdate.Type = ReaLTaiizor.Controls.ToggleButton._Type.CheckMark;
            tgUpdate.ToggledChanged += tgUpdate_ToggledChanged;
            // 
            // lblUpdate
            // 
            lblUpdate.Anchor = AnchorStyles.Right;
            lblUpdate.AutoSize = true;
            lblUpdate.BackColor = Color.Transparent;
            lblUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblUpdate.ForeColor = Color.FromArgb(76, 76, 77);
            lblUpdate.Location = new Point(688, 374);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(73, 25);
            lblUpdate.TabIndex = 41;
            lblUpdate.Text = "Update";
            // 
            // AuthorView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(852, 490);
            Controls.Add(lblUpdate);
            Controls.Add(tgUpdate);
            Controls.Add(btnDelete);
            Controls.Add(lbBirth);
            Controls.Add(lbNationality);
            Controls.Add(lblName);
            Controls.Add(btnCreate);
            Controls.Add(dtBirth);
            Controls.Add(txtnationality);
            Controls.Add(txtAuthorName);
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
        private ReaLTaiizor.Controls.DungeonLabel lblName;
        private ReaLTaiizor.Controls.Button btnCreate;
        private ReaLTaiizor.Controls.PoisonDateTime dtBirth;
        private ReaLTaiizor.Controls.BigTextBox txtnationality;
        private ReaLTaiizor.Controls.BigTextBox txtAuthorName;
        private ReaLTaiizor.Controls.Button btnUpdate;
        private ReaLTaiizor.Controls.PoisonDataGridView dtgData;
        private ReaLTaiizor.Controls.ToggleButton tgUpdate;
        private ReaLTaiizor.Controls.DungeonLabel lblUpdate;
    }
}