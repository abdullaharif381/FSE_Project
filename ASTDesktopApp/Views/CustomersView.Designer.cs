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
			CustomerDataGridView = new DataGridView();
			SrNo = new DataGridViewTextBoxColumn();
			dgvID = new DataGridViewTextBoxColumn();
			dgvName = new DataGridViewTextBoxColumn();
			dgvAddress = new DataGridViewTextBoxColumn();
			dgvPhone = new DataGridViewTextBoxColumn();
			dgvEdit = new DataGridViewImageColumn();
			dgvDel = new DataGridViewImageColumn();
			TopViewPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)CustomerDataGridView).BeginInit();
			SuspendLayout();
			// 
			// CustomerDataGridView
			// 
			CustomerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			CustomerDataGridView.BackgroundColor = SystemColors.InactiveBorder;
			CustomerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			CustomerDataGridView.Columns.AddRange(new DataGridViewColumn[] { SrNo, dgvID, dgvName, dgvAddress, dgvPhone, dgvEdit, dgvDel });
			CustomerDataGridView.Dock = DockStyle.Fill;
			CustomerDataGridView.Location = new Point(3, 169);
			CustomerDataGridView.Name = "CustomerDataGridView";
			CustomerDataGridView.RowHeadersWidth = 51;
			CustomerDataGridView.Size = new Size(794, 278);
			CustomerDataGridView.TabIndex = 4;
			CustomerDataGridView.CellContentClick += CustomerDataGridView_CellContentClick_3;
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
		private DataGridViewImageColumn dgvEdit;
		private DataGridViewImageColumn dgvDel;
	
	}
}