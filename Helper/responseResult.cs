using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class responseResult
    {
        public bool response { get; set; }
        public string message { get; set; }
        public string href { get; set; }
        public string ErrorMessage { get; set; }

        public responseResult()
        {
            this.response = false;
            this.message = "Ocurrio un error inesperado";
        }

        public void SetResponse(bool r, string m = "")
        {
            this.response = r;
            this.message = m;
            if (!r && m == "") this.message = "Ocurrio un error inesperado";


        }
    }
}
