using Northwind.Business.Abstract;
using Northwind.Business.Concreate;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concreate.EntityFramework;
using Northwind.Entities.Concreate;
using NorthWind.DataAccess.Abstract.EntityFramework;
using NorthWind.DataAccess.Abstract.NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }
        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProduct();
            LoadCategories();
            LoadCategories2();
            LoadCategories3();

        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";



        }
        private void LoadCategories2()
        {

            cbxCategoryId.DataSource = _categoryService.GetAll();
            cbxCategoryId.DisplayMember = "CategoryName";
            cbxCategoryId.ValueMember = "CategoryId";
        }
        private void LoadCategories3()
        {

            cbxCategoryIdUpdate.DataSource = _categoryService.GetAll();
            cbxCategoryIdUpdate.DisplayMember = "CategoryName";
            cbxCategoryIdUpdate.ValueMember = "CategoryId";
        }
        private void LoadProduct()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch (Exception)
            {


            }

        }
        private void tbxProduct_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProduct.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProduct.Text);
            }
            else
            {
                LoadProduct();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    ProductName = tbxProductName.Text,
                    CategoryId = Convert.ToInt32(cbxCategoryId.SelectedValue),
                    QuantityPerUnit = tbxQuantityPerUnit.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxStockAmount.Text)

                });
                MessageBox.Show("Ürün eklendi");
                LoadProduct();
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    CategoryId = Convert.ToInt32(cbxCategoryIdUpdate.SelectedValue),
                    ProductName = tbxProductNameUpdate.Text,
                    UnitsInStock = Convert.ToInt16(tbxstockAmountUpdate.Text),
                    QuantityPerUnit = tbxOunatityPerUnitUpdate.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text)

                });
                MessageBox.Show("Ürün Güncellendi");
                LoadProduct();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
         

        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            cbxCategoryIdUpdate.SelectedValue = row.Cells[1].Value;
            tbxProductNameUpdate.Text = row.Cells[2].Value.ToString();
            tbxUnitPriceUpdate.Text = row.Cells[3].Value.ToString();
            tbxstockAmountUpdate.Text = row.Cells[4].Value.ToString();
            tbxOunatityPerUnitUpdate.Text = row.Cells[5].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                });
                MessageBox.Show("Ürün Silindi");
                LoadProduct();
            }
                catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }


        }
    }
}

