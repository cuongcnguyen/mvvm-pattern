using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDebtBook.Models
{
    public class Debtor 
    {
        public string Name { get; set; }
        private List<DebtEntryModel> debtCollection = new List<DebtEntryModel>();                
        public int Amount { get; set; }        
    }
}
