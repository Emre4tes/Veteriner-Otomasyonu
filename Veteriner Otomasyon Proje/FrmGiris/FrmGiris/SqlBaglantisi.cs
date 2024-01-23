using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FrmGiris
{
    class SqlBaglantisi
    {
        private static SqlConnection _baglan;

        public SqlConnection baglanti
        {
            get
            {
                if (_baglan == null)
                {
                    _baglan = YeniBaglantiOlustur();
                    _baglan.Open();
                }
                else if (_baglan.State == System.Data.ConnectionState.Closed)
                {
                    _baglan.Open();
                }

                return _baglan;
            }
        }

        private SqlConnection YeniBaglantiOlustur()
        {
            return new SqlConnection("Data Source=DESKTOP-SLHV6UB\\SQLEXPRESS;Initial Catalog=Veteriner Otoımasyoın Proje;Integrated Security=True;Connection Timeout=120");
        }
    }
}
