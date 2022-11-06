using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFarmeWorkDemo
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
            //using (ETradeContext context = new ETradeContext())
            //{
            //    dgwProduts.DataSource = context.Products.ToList();

            //}
            LoadProducts();

        }

        private void LoadProducts()
        {
            dgwProduts.DataSource = _productDal.GetAll();
        }
        private void SearchProducts(string key)
        {
            //var result = _productDal.GetAll().Where(p=>p.Name.ToLower().Contains(key.ToLower())).ToList();//bu koleksiyonda kullanılır.büyük küçük harf duyarlılıgı olur.
            var result = _productDal.GetByName(key);//linq
            dgwProduts.DataSource = result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name=tbxName.Text,
                UnitPrice=Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount=Convert.ToInt32(tbxStockAmount.Text)
            });
            LoadProducts();
            MessageBox.Show("Added");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProduts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)
            });
            LoadProducts();
            MessageBox.Show("UPDATED");
        }

        private void dgwProduts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProduts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProduts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProduts.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dgwProduts.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
            MessageBox.Show("Deleted");
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
        }

        private void tbxId_Click(object sender, EventArgs e)
        {
            _productDal.GetById(2);
        }
    }
}
//ETradeContext context=new ETradeContext(); bu bellekte çok yer kaplar. bu bağlamda DbContext IDisposable interfaceninde türetiliyor. ancak metod bittiği zaman .net memory yöneticisi işi biten nesneler varmı diye kontrol ediyor. bu bellekten atıyor buna çöp toplayıcıyla yapıyor.
//using kullanmamızın sebebi: blok bittiği anda çöp toplayıcı beklenmeden nesneyi zorla bellekten atıyor.
