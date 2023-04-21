using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DrLicence
    {
       public int UsersID { get; set; }
        public OrderStatus LicenceStatus { get; set; }
        public DateTime DateofSubmition { get; set; }
        public TypeofOrder Type { get; set; }
        public List<Documents> Documents { get; set; }

        private DrLicence()
        {
            Documents = new List<Documents>();
        }

        public DrLicence(OrderStatus licenceStatus, DateTime dateofSubmition, TypeofOrder type)
        {
            LicenceStatus = licenceStatus;
            DateofSubmition = dateofSubmition;
            Type = type;
        }
    }
}
