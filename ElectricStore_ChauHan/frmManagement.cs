using ElectricStore_ChauHan_Repository.Models;
using ElectricStore_ChauHan_Repository.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ElectricStore_ChauHan
{
    public partial class frmManagement : Form
    {
        private IProductRepository _productRepository;
        public frmManagement()
        {
            _productRepository = new ProductRepository();
            InitializeComponent();
        }

        public void LoadData()
        {
            List<Product> list = _productRepository.GetAllProducts();
            dgv.Rows.Clear();
            foreach (Product item in list)
            {
                Category c = _productRepository.GetCategoryById(item.CategoryId);
                dgv.Rows.Add(item.Id, item.ProductName, item.ProductCode, item.Price, item.DateCreate.Value.ToString("dd-MM-yyyy"), c.CategoryName);
            }
        }

        public void LoadForm()
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtCode.Text = string.Empty;
            txtPrice.Text = string.Empty;
            dtpDate.Value = DateTime.Now;
        }

        private void frmManagement_Load(object sender, EventArgs e)
        {
            LoadData();
            List<Category> listc = _productRepository.GetAllCategories();
            cbCateName.DisplayMember = "CategoryName";
            cbCateName.ValueMember = "Id";
            cbCateName.DataSource = listc;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dgv.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                txtName.Text = dgv.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
                txtCode.Text = dgv.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
                txtPrice.Text = dgv.Rows[e.RowIndex].Cells["Column4"].Value.ToString();
                dtpDate.Value = DateTime.Parse(dgv.Rows[e.RowIndex].Cells["Column5"].Value.ToString());
                cbCateName.SelectedIndex = cbCateName.FindStringExact(dgv.Rows[e.RowIndex].Cells["Column6"].Value.ToString());
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            /*try
            {
                string searchValue = txtSearch.Text.Trim();
                List<Product> listp = _productRepository.GetAllProducts().Where(x => x.ProductCode == searchValue).ToList();
                dgv.Rows.Clear();
                foreach (Product product in listp)
                {
                    Category c = _productRepository.GetCategoryById(product.CategoryId);
                    dgv.Rows.Add(product.Id, product.ProductName, product.ProductCode, product.Price, product.DateCreate.Value.ToString("dd-MM-yyyy"), c.CategoryName);
                }
            }
            catch { }*/
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {  
                List<Product> listp1 = _productRepository.GetAllProducts().OrderBy(x => x.Id).ToList();

                int id = listp1.LastOrDefault().Id + 1;
                Product p1 = new Product();
                
                p1.ProductName = txtName.Text;
                p1.ProductCode = txtCode.Text;
                p1.Price = decimal.Parse(txtPrice.Text);
                p1.DateCreate = dtpDate.Value; //de ko cho doi thi ko de
                p1.CategoryId = int.Parse(cbCateName.SelectedValue.ToString());
                //Match m = Regex.Match(p.ProductCode, @"^[A-Z]{4}$");

                _productRepository.AddProduct(p1);
                MessageBox.Show("Added Successfully");
                LoadData();
                LoadForm();
            }
            catch { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                Product p1 = _productRepository.GetProductById(id);
                p1.ProductName = txtName.Text;
                p1.ProductCode = txtCode.Text;
                p1.Price = decimal.Parse(txtPrice.Text);
                p1.DateCreate = dtpDate.Value;
                p1.CategoryId = int.Parse(cbCateName.SelectedValue.ToString());

                _productRepository.UpdateProduct(p1);
                MessageBox.Show("Update Successfully");
                LoadData();
                LoadForm();
            }
            catch { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                DialogResult result = MessageBox
                    .Show("Are you sure you want to delete this product?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _productRepository.DeleteProduct(id);
                    MessageBox.Show("Delete Successfully");
                    LoadData();
                    LoadForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            return;
        }

     
    }
}
