using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Base_de_datos
{
    public class Datos
    {
        public SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3M8RSE2\TEW_SQLEXPRESS;Initial Catalog = TP_BaseDatos;Integrated Security = True");
        public DataTable consulta(string sql)
        {
            DataTable consulta = new DataTable();
            SqlDataAdapter consultaAdapter = new SqlDataAdapter(sql,con);
            consultaAdapter.Fill(consulta);
            return consulta;
        }
    }
}
