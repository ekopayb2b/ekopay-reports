using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ekopay_Reports.Models.View
{
    public class CustomerFilter
    {
        public DateTime OnBoardingDate { get; set; }
        public string BranchCode { get; set; }
        public string CustomerType { get; set; }
        public string CIFSupplier { get; set; }
        public string NameOfSupplier { get; set; }
        public string CIFBuyer { get; set; }
        public string IDBuyer { get; set; }
        public string NameOfBuyer { get; set; }
        public string BusinessRegNo { get; set; }
        public string TaxCode { get; set; }
        public string Status { get; set; }
    }
}