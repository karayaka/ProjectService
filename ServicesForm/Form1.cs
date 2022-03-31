using ServicesForm.Infrastructure;
using ServicesForm.Models;
using ServicesForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicesForm
{
    public partial class Form1 : Form
    {
        private readonly ICategoryRepository repo;
        private List<CategoryModel> categorys;
        private CategoryModel category;
        public Form1()
        {
            InitializeComponent();
            repo = new CategoryRepository();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            getForm();
        }

        public async Task getForm()
        {
            categorys = await repo.GetCategoryes();
            grdCategory.DataSource = categorys;
        }

     
        private void grdCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            category = categorys[index];
            var a = category;
            txtCategoriDesc.Text = category.description;
            txtCategoriName.Text = category.name;
        }

        private void btnFormReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (category != null)
            {

                Update();
            }
            else
            {
                Add();
                
            }
            ResetForm();
        }

        private async Task Add()
        {
            var ctgr = new CategoryModel()
            {
                description = txtCategoriDesc.Text,
                name = txtCategoriName.Text,
            };
            await repo.AddCategory(ctgr);
            getForm();
        }

        private async Task Update()
        {
            category.name = txtCategoriName.Text;
            category.description = txtCategoriDesc.Text;
            await repo.UpdateCategory(category);
            getForm();
            
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            if (category == null)
            {
                MessageBox.Show("Lütfen Satır Seçin");
                return;
            }
            DeleteAsync(category.ID);
        }

        private async Task DeleteAsync(int ID)
        {
            await repo.DeleteCategory(ID);
            getForm();
            ResetForm();
        }

        private void btnRefres_Click(object sender, EventArgs e)
        {
            getForm();
        }

        private void ResetForm()
        {
            category = null;
            txtCategoriDesc.Text = "";
            txtCategoriName.Text = "";
        }
    }
}
