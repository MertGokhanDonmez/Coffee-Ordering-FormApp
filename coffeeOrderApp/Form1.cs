using System.Data;
using System.Data.SqlClient;

namespace coffeeOrderApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }


        
        
        private void btn_reset_Click(object sender, EventArgs e)
        {
            price = 0;
            dgw_orders.Rows.Clear();
            label2.Text = price.ToString();
        }

        SqlConnection con;
        DataSet ds;
        SqlDataAdapter da;
        int price = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

            con = new SqlConnection(
                "server=LAPTOP-Q640SRQG;" +
                "Initial Catalog=coffee;" +
                "Integrated Security=True"
                );
            string query = "Select * From coffees";
            da = new SqlDataAdapter(query, con);
            ds = new DataSet();

            con.Open();

            da.Fill(ds, "coffee");
            dgw.DataSource = ds.Tables["coffee"];
            dgw.Columns.Remove("Id");

            DataGridViewButtonColumn dgvButton = new DataGridViewButtonColumn();
            dgvButton.Name = "Add";
            dgvButton.HeaderText = "Ekle";

            dgw.Columns.Add(dgvButton);
            dgw.Columns["Add"].DisplayIndex = 0;
            dgw.Columns[0].HeaderText = "Kahve";
            dgw.Columns[1].HeaderText = "Fiyat";
            con.Close();

            
            

        }
        
        

        private void btn_rmv_order_Click(object sender, EventArgs e)
        {
            dgw_orders.Rows.Clear();
        }


        
        private void dgw_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (DataGridViewRow row in dgw.SelectedRows)
            {
                // fiyati topluyor
                price += Int32.Parse(row.Cells["c_price"].Value.ToString());

                //veri cekme ve ekleme
                
                string c_price = row.Cells["c_price"].Value.ToString();
                string c_name = row.Cells["c_name"].Value.ToString();
                //orders.Items.Add(c_name).SubItems.Add(c_price);
                
                
                dgw_orders.Rows.Add("", c_name, c_price);
                // toplam tutar
                label2.Text = price.ToString();

            }
            
            
        }

        private void dgw_orders_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (DataGridViewRow row in dgw_orders.SelectedRows)
            {
                // fiyati azaltiyor
                price -= Int32.Parse(row.Cells["c_price"].Value.ToString());
                dgw_orders.Rows.Remove(row);
                // toplam tutar
                label2.Text = price.ToString();
            }
        }

        private void btn_fnsh_order_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparisiniz Alinmistir, Afiyet Olsun!");
            dgw_orders.Rows.Clear();
            label2.Text = "0";
            price = 0;
        }
    }
}