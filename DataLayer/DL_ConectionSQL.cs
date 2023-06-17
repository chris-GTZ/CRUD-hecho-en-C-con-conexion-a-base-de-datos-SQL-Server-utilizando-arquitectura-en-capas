using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataLayer {
  public class DL_ConectionSQL {
    private SqlConnection ConectionDB = new SqlConnection("Server=DESKTOP-ENDR46C;DataBase= SalesSystem;User ID=sax; Password=K25.zBxQ");

    public SqlConnection OpenConnection() {
      if (ConectionDB.State == ConnectionState.Closed)
        ConectionDB.Open();
      return ConectionDB;
    }

    public SqlConnection CloseConnection() {
      if (ConectionDB.State == ConnectionState.Open)
        ConectionDB.Close();
      return ConectionDB;
    }
  }
}
