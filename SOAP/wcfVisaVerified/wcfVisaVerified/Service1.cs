using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;

namespace wcfVisaVerified
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        #region Miembros de IService1

        public int GetApproval(string IdCard, string NameCard, Decimal Price, String ExpirationDate, string CVVCode)
        {
            List<Tarjeta> Tarjetas = new List<Tarjeta>();

            Tarjeta Tarjeta1 = new Tarjeta();
            Tarjeta1.IdCard = "1234123412341234";
            Tarjeta1.NameCard = "Alfredo Contreras";
            Tarjeta1.ExpirationDate = "24/04/2015";
            Tarjeta1.CVVCode = "123";

            Tarjeta Tarjeta2 = new Tarjeta();
            Tarjeta2.IdCard = "2345234523452345";
            Tarjeta2.NameCard = "Juan Perez";
            Tarjeta2.ExpirationDate = "01/01/2020";
            Tarjeta2.CVVCode = "456";

            Tarjeta Tarjeta3 = new Tarjeta();
            Tarjeta3.IdCard = "3456345634563456";
            Tarjeta3.NameCard = "Yicela Vega";
            Tarjeta3.ExpirationDate = "01/12/2014";
            Tarjeta3.CVVCode = "789";

            Tarjetas.Add(Tarjeta1);
            Tarjetas.Add(Tarjeta2);
            Tarjetas.Add(Tarjeta3);

            var TarjetaEncontrada = (from t in Tarjetas
                                     where t.IdCard.Equals(IdCard) 
                                        && t.NameCard.Equals(NameCard)
                                        && t.ExpirationDate.Equals(ExpirationDate)
                                        && t.CVVCode.Equals(CVVCode)
                                    select t).Any();
            int retornar = 0;
            if (TarjetaEncontrada)
                retornar= 1;

            return retornar;
        }

        #endregion
    }
}
