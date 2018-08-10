using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Procedure
{
   public  class USPE_WU_VOUCHER
    {
        public string AGENCIA { get; set; }
        public string TARJETA { get; set; }
        public string DESTINATARIO { get; set; }
        public string REMITENTE { get; set; }
        public string ID { get; set; }
        public string TEL { get; set; }
        public string DIRECCION { get; set; }
        public string FECHA_HORA { get; set; }
        public string OPERADOR { get; set; }
        public string TIPO_TRANSACCION { get; set; }
        public string DESTINO { get; set; }
        public string ORIGEN { get; set; }
        public decimal PAY_AMOUNT { get; set; }
        public decimal EXCHANGE_RATE { get; set; }
        public decimal SOURCE_AMOUNT { get; set; }
        public string MONEDA_ORINGEN { get; set; }
        public DateTime FECHA_ORIGEN { get; set; }
        public string MTCN { get; set; }


        public string CARGO_ENVIO { get; set; }
        public string CARGO_MENSAJE { get; set; }
        public string CARGO_ENTREGA { get; set; }
        public string IMPUESTO { get; set; }
        public decimal TOTAL { get; set; }
        public string FIRMA { get; set; }
      

    }
}
