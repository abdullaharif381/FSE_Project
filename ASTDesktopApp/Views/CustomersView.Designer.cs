namespace ASTDesktopApp.Views
{
    partial class CustomersView
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
			CustomerDataGridView = new DataGridView();
			SrNo = new DataGridViewTextBoxColumn();
			dgvID = new DataGridViewTextBoxColumn();
			dgvName = new DataGridViewTextBoxColumn();
			dgvAddress = new DataGridViewTextBoxColumn();
			dgvPhone = new DataGridViewTextBoxColumn();
			Column1 = new DataGridViewTextBoxColumn();
			dgvEdit = new DataGridViewImageColumn();
			dgvDel = new DataGridViewImageColumn();
			TopViewPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)CustomerDataGridView).BeginInit();
			SuspendLayout();
			// 
			// CustomerDataGridView
			// 
			CustomerDataGridView.AllowUserToAddRows = false;
			CustomerDataGridView.AllowUserToDeleteRows = false;
			CustomerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			CustomerDataGridView.BackgroundColor = SystemColors.InactiveBorder;
			CustomerDataGridView.BorderStyle = BorderStyle.Fixed3D;
			CustomerDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
			CustomerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			CustomerDataGridView.Columns.AddRange(new DataGridViewColumn[] { SrNo, dgvID, dgvName, dgvAddress, dgvPhone, Column1, dgvEdit, dgvDel });
			CustomerDataGridView.Dock = DockStyle.Fill;
			CustomerDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
			CustomerDataGridView.Location = new Point(3, 169);
			CustomerDataGridView.Name = "CustomerDataGridView";
			CustomerDataGridView.RowHeadersWidth = 51;
			dataGridViewCellStyle1.BackColor = Color.AliceBlue;
			dataGridViewCellStyle1.Padding = new Padding(10, 0, 10, 2);
			CustomerDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
			CustomerDataGridView.ScrollBars = ScrollBars.Horizontal;
			CustomerDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
			CustomerDataGridView.Size = new Size(794, 278);
			CustomerDataGridView.TabIndex = 7;
			// 
			// SrNo
			// 
			SrNo.HeaderText = "SrNo";
			SrNo.MinimumWidth = 6;
			SrNo.Name = "SrNo";
			// 
			// dgvID
			// 
			dgvID.HeaderText = "ID";
			dgvID.MinimumWidth = 6;
			dgvID.Name = "dgvID";
			// 
			// dgvName
			// 
			dgvName.HeaderText = "Name";
			dgvName.MinimumWidth = 6;
			dgvName.Name = "dgvName";
			// 
			// dgvAddress
			// 
			dgvAddress.HeaderText = "Address";
			dgvAddress.MinimumWidth = 6;
			dgvAddress.Name = "dgvAddress";
			// 
			// dgvPhone
			// 
			dgvPhone.HeaderText = "Phone";
			dgvPhone.MinimumWidth = 6;
			dgvPhone.Name = "dgvPhone";
			// 
			// Column1
			// 
			Column1.HeaderText = "Column1";
			Column1.MinimumWidth = 6;
			Column1.Name = "Column1";
			Column1.Visible = false;
			// 
			// dgvEdit
			// 
			dgvEdit.HeaderText = "";
			dgvEdit.Image = Properties.Resources.pen;
			dgvEdit.MinimumWidth = 6;
			dgvEdit.Name = "dgvEdit";
			// 
			// dgvDel
			// 
			dgvDel.HeaderText = "";
			dgvDel.Image = Properties.Resources.trash;
			dgvDel.MinimumWidth = 6;
			dgvDel.Name = "dgvDel";
			// 
			// CustomersView
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(CustomerDataGridView);
			Location = new Point(0, 0);
			Name = "CustomersView";
			Text = "Customers";
			Load += CustomersView_Load;
			Controls.SetChildIndex(TopViewPanel, 0);
			Controls.SetChildIndex(CustomerDataGridView, 0);
			TopViewPanel.ResumeLayout(false);
			TopViewPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)CustomerDataGridView).EndInit();
			ResumeLayout(false);
		}

		#endregion
		
        private DataGridView CustomerDataGridView;
        private DataGridViewTextBoxColumn SrNo;
        private DataGridViewTextBoxColumn dgvID;
        private DataGridViewTextBoxColumn dgvName;
        private DataGridViewTextBoxColumn dgvAddress;
        private DataGridViewTextBoxColumn dgvPhone;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewImageColumn dgvEdit;
        private DataGridViewImageColumn dgvDel;
    }
}