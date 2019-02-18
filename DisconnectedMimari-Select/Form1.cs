using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace DisconnectedMimari_Select
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Server=Serverİsmi; Initial Catalog=VeritabanıAdı; Integrated Security=true;");
            SqlDataAdapter da = new SqlDataAdapter("Select * From TabloAdı",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            //Serverİsmi: VeriTabanımıza bağlandığımız ServerName kısmı yazılacak.
            //Database:Veritabanı İsmi(Hangi veritabanı ile çalışacaksak o veritabanı yazılacak.)
            //Integrated Security=SQL'e WindowsAuthentication ile bağlandıysak bağlantı güvenilir diye belirtmek için yazılacak.
            //SQlDataAdapter:Disconnected Mimari'de kullanıyoruz.İçerisine commandtext ve connection istiyor. Bizde sırası parametreleri veriyoruz.
            //Tabloİsmi: Veritabanında hangi tablo ile işlem yapmak istiyorsak o tabloyu Tabloİsmi diye belirttiğim yere yazılacak.
            //DatagridView'e DataTable tipindeki içerisini doldurduğumuz dt nesnesini veriyoruz.
        }
    }
}
