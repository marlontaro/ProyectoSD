using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Entidades
{
    [DataContract]
    public class Tarjeta
    {
        private String idcard = string.Empty;
        private String namecard = string.Empty;
        private String expirationdate = string.Empty;
        private String cvvcode = string.Empty;

        [DataMember]
        public String IdCard
        {
            get { return idcard; }
            set { idcard = value; }
        }

        [DataMember]
        public String NameCard
        {
            get { return namecard; }
            set { namecard = value; }
        }

        [DataMember]
        public String ExpirationDate
        {
            get { return expirationdate; }
            set { expirationdate = value; }
        }

        [DataMember]
        public String CVVCode
        {
            get { return cvvcode; }
            set { cvvcode = value; }
        }

    }
}
