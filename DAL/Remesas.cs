using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Remesas : IRemesas
    {
        public void AgregarRemesas(tbl_remesasDTO remesasDTO)
        {
            int response = 0;
            try{

                var param1 = new SqlParameter
                {
                    ParameterName = "@result",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output

                };

                var procResult = new SqlParameter
                {
                    ParameterName = "@procResult",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };

                using (var ctx = new dbContext())
                {
                    response = ctx.Database.ExecuteSqlCommand("exec @procResult =  uspe_reme_add @codSol, @respWF OUTPUT, @respTopaz OUTPUT");

                }






            }
            catch(Exception e)
            {
                throw;
            }

            
        }
    }
}
