using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamiliBrowser_UI.MVVM.Models
{
    public class PageModel
    {
        public int CustomerCount { get; set; }
        public string Productstatus { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TransactionValue { get; set; }
        public DateTime DateTime { get; set; }
        public bool LocationStatus { get; set; }

    }
}
