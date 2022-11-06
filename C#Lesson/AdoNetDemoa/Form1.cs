using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();

        }

        private void LoadProducts()
        {
            dgwProduts.DataSource = _productDal.GetAll();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });
            LoadProducts();
            MessageBox.Show("Product added!");

        }

        private void dgwProduts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProduts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProduts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProduts.CurrentRow.Cells[3].Value.ToString();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = Convert.ToInt32(dgwProduts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)
            };
            _productDal.Update(product);
            LoadProducts();
            MessageBox.Show("Updated");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProduts.CurrentRow.Cells[0].Value);
            _productDal.Delete(id);
            LoadProducts();
            MessageBox.Show("Deleted");
        }

        private void dgwProduts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    
