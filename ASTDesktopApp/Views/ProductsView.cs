using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASTDesktopApp.Models;
using MaterialSkin.Controls;
using MaterialSkin.Properties;

namespace ASTDesktopApp.Views
{
	public partial class ProductsView : SampleViews
	{
		public ProductsView()
		{
			InitializeComponent();
		}

		private void ProductsView_Load(object sender, EventArgs e)
		{
			// Load the data from the database
			LoadData();
		}

		public void LoadData()
		{
			// Clear the existing data
			ListBox lb = new ListBox();
			lb.Items.Add(dgvID);
			lb.Items.Add(dgvItem);
			lb.Items.Add(dgvCategoryID);
			lb.Items.Add(dgvCategoryName);
			lb.Items.Add(dgvDescription);
			lb.Items.Add(dgvCost);
			lb.Items.Add(dgvPrice);

			string query = @"SELECT p.ProductID, p.Name, p.CategoryID, c.Name, p.Description, p.Cost, p.Price FROM Products as p JOIN Categories as c ON p.CategoryID = c.CategoryID
							WHERE c.Name like '%" + SearchTextBox.Text + "%' OR p.Name like '%" + SearchTextBox.Text + "%' ORDER BY ProductID";
			MainClass.LoadData(query, ProductDataGridView, lb);


		}

		private void ProductDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (ProductDataGridView.CurrentCell.OwningColumn.Name == "dgvEdit")
			{
				AddProducts addProduct = new AddProducts();
				addProduct.setID((ProductDataGridView.CurrentRow.Cells["dgvID"].Value.ToString()));
				addProduct.setName(ProductDataGridView.CurrentRow.Cells["dgvItem"].Value.ToString());
				addProduct.setCategory(ProductDataGridView.CurrentRow.Cells["dgvCategoryID"].Value.ToString());
				addProduct.setDetail(ProductDataGridView.CurrentRow.Cells["dgvDescription"].Value.ToString());
				addProduct.setCost(ProductDataGridView.CurrentRow.Cells["dgvCost"].Value.ToString());
				addProduct.setPrice(ProductDataGridView.CurrentRow.Cells["dgvPrice"].Value.ToString());



				MainClass.BlurBackground(addProduct);
				LoadData();


			}
			if (ProductDataGridView.CurrentCell.OwningColumn.Name == "dgvDel")

			{
				DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					int ProductID = Convert.ToInt32(ProductDataGridView.CurrentRow.Cells["dgvID"].Value);
					string query = "DELETE FROM Products WHERE ProductID = '" + ProductID + "'";
					Hashtable ht = new Hashtable();
					if (MainClass.SQL(query, ht) > 0)
					{
						// If the deletion is successful, reload the data
						LoadData();
						MessageBox.Show("Product deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						// If there's an error, show the error message
						MessageBox.Show("An error occurred while deleting the Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}



		}
		public override void AddNewButton_Click(object sender, EventArgs e)
		{
			//open the AddProducts.cs form when this button is clicked:
			MainClass.BlurBackground(new AddProducts());
			AddProducts add = new AddProducts();
			add.Show();
			LoadData();



		}

		public override void SearchTextBox_TextChanged(object sender, EventArgs e)
		{
			LoadData();
		}

		private void SearchTextBox_Click_1(object sender, EventArgs e)
		{

		}
		private void CategoryDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			// Suppress the error dialog
			e.ThrowException = false;
		}

		private void ProductDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			if (ProductDataGridView.CurrentCell.OwningColumn.Name == "dgvEdit")
			{
				AddProducts addProduct = new AddProducts();
				addProduct.setID((ProductDataGridView.CurrentRow.Cells["dgvID"].Value.ToString()));
				addProduct.setName(ProductDataGridView.CurrentRow.Cells["dgvItem"].Value.ToString());
				addProduct.setCategory(ProductDataGridView.CurrentRow.Cells["dgvCategoryID"].Value.ToString());
				addProduct.setDetail(ProductDataGridView.CurrentRow.Cells["dgvDescription"].Value.ToString());
				addProduct.setCost(ProductDataGridView.CurrentRow.Cells["dgvCost"].Value.ToString());
				addProduct.setPrice(ProductDataGridView.CurrentRow.Cells["dgvPrice"].Value.ToString());



				MainClass.BlurBackground(addProduct);
				LoadData();


			}
			if (ProductDataGridView.CurrentCell.OwningColumn.Name == "dgvDel")

			{
				DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					int ProductID = Convert.ToInt32(ProductDataGridView.CurrentRow.Cells["dgvID"].Value);
					string query = "DELETE FROM Products WHERE ProductID = '" + ProductID + "'";
					Hashtable ht = new Hashtable();
					if (MainClass.SQL(query, ht) > 0)
					{
						// If the deletion is successful, reload the data
						LoadData();
						MessageBox.Show("Product deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						// If there's an error, show the error message
						MessageBox.Show("An error occurred while deleting the Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}

		}
	}
}
