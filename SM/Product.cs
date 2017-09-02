using System;
using System.Windows.Forms;
using SM.BL;


namespace SM
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            cbox_Status.SelectedIndex = 0;
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            int newProductCode;
            int.TryParse(txb_ProductCode.Text, out newProductCode);
            string newProductName = txb_ProdName.Text;
            string message = string.Empty;

            ProductPart addProduct = new ProductPart();
            bool result = addProduct.AddProduct(newProductCode, newProductName, ref message);

            if (result == false)
            {
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
