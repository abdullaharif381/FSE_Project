namespace ASTDesktopApp.Views
{
	partial class ProductsView
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
			PoductDataGridView = new DataGridView();
			dgvSr = new DataGridViewTextBoxColumn();
			dgvID = new DataGridViewTextBoxColumn();
			dgvItem = new DataGridViewTextBoxColumn();
			dgvCategoryID = new DataGridViewTextBoxColumn();
			dgvCategoryName = new DataGridViewTextBoxColumn();
			dgvDescription = new DataGridViewTextBoxColumn();
			dgvPrice = new DataGridViewTextBoxColumn();
			dgvCost = new DataGridViewTextBoxColumn();
			dgvEdit = new DataGridViewImageColumn();
			dgvDel = new DataGridViewImageColumn();
			TopViewPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)PoductDataGridView).BeginInit();
			SuspendLayout();
			// 
			// PoductDataGridView
			// 
			PoductDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			PoductDataGridView.BackgroundColor = SystemColors.InactiveBorder;
			PoductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			PoductDataGridView.Columns.AddRange(new DataGridViewColumn[] { dgvSr, dgvID, dgvItem, dgvCategoryID, dgvCategoryName, dgvDescription, dgvPrice, dgvCost, dgvEdit, dgvDel });
			PoductDataGridView.Dock = DockStyle.Fill;
			PoductDataGridView.Location = new Point(3, 169);
			PoductDataGridView.Name = "PoductDataGridView";
			PoductDataGridView.RowHeadersWidth = 51;
			PoductDataGridView.Size = new Size(794, 278);
			PoductDataGridView.TabIndex = 4;
			// 
			// dgvSr
			// 
			dgvSr.HeaderText = "SrNo";
			dgvSr.MinimumWidth = 6;
			dgvSr.Name = "dgvSr";
			// 
			// dgvID
			// 
			dgvID.HeaderText = "ID";
			dgvID.MinimumWidth = 6;
			dgvID.Name = "dgvID";
			// 
			// dgvItem
			// 
			dgvItem.HeaderText = "Item";
			dgvItem.MinimumWidth = 6;
			dgvItem.Name = "dgvItem";
			// 
			// dgvCategoryID
			// 
			dgvCategoryID.HeaderText = "CategoryID";
			dgvCategoryID.MinimumWidth = 6;
			dgvCategoryID.Name = "dgvCategoryID";
			dgvCategoryID.Visible = false;
			// 
			// dgvCategoryName
			// 
			dgvCategoryName.HeaderText = "Category";
			dgvCategoryName.MinimumWidth = 6;
			dgvCategoryName.Name = "dgvCategoryName";
			// 
			// dgvDescription
			// 
			dgvDescription.HeaderText = "Description";
			dgvDescription.MinimumWidth = 6;
			dgvDescription.Name = "dgvDescription";
			// 
			// dgvPrice
			// 
			dgvPrice.HeaderText = "Price";
			dgvPrice.MinimumWidth = 6;
			dgvPrice.Name = "dgvPrice";
			// 
			// dgvCost
			// 
			dgvCost.HeaderText = "Cost";
			dgvCost.MinimumWidth = 6;
			dgvCost.Name = "dgvCost";
			// 
			// dgvEdit
			// 
			dgvEdit.HeaderText = "";
			dgvEdit.Image = Properties.Resources.pen;
			dgvEdit.MinimumWidth = 6;
			dgvEdit.Name = "dgvEdit";
			dgvEdit.Resizable = DataGridViewTriState.True;
			dgvEdit.SortMode = DataGridViewColumnSortMode.Automatic;
			// 
			// dgvDel
			// 
			dgvDel.HeaderText = "";
			dgvDel.Image = Properties.Resources.trash;
			dgvDel.MinimumWidth = 6;
			dgvDel.Name = "dgvDel";
			dgvDel.Resizable = DataGridViewTriState.True;
			dgvDel.SortMode = DataGridViewColumnSortMode.Automatic;
			// 
			// ProductsView
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(PoductDataGridView);
			Location = new Point(0, 0);
			Name = "ProductsView";
			Text = "ProductsView";
			Load += ProductsView_Load;
			Controls.SetChildIndex(TopViewPanel, 0);
			Controls.SetChildIndex(PoductDataGridView, 0);
			TopViewPanel.ResumeLayout(false);
			TopViewPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)PoductDataGridView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView PoductDataGridView;
		private DataGridViewTextBoxColumn dgvSr;
		private DataGridViewTextBoxColumn dgvID;
		private DataGridViewTextBoxColumn dgvItem;
		private DataGridViewTextBoxColumn dgvCategoryID;
		private DataGridViewTextBoxColumn dgvCategoryName;
		private DataGridViewTextBoxColumn dgvDescription;
		private DataGridViewTextBoxColumn dgvPrice;
		private DataGridViewTextBoxColumn dgvCost;
		private DataGridViewImageColumn dgvEdit;
		private DataGridViewImageColumn dgvDel;
	}
}