using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TheDebtBook.Models;

namespace TheDebtBook.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        

        private BindableCollection<DebtorModels> _debtors = new BindableCollection<DebtorModels>();

        public ShellViewModel()
        {          

            Debtors.Add(new DebtorModels { Name = "Mickey Mouse", Amount = -100 });
            Debtors.Add(new DebtorModels { Name = "Donald Duck", Amount = 1321 });
            Debtors.Add(new DebtorModels { Name = "Tom Cruise", Amount = 300 });           
        }
       
        public BindableCollection<DebtorModels> Debtors
        {
            get { return _debtors; }
            set { _debtors = value; }
        }

       public void OpenChildPage()
        {
            ActivateItem(new ChildViewModel());
        }

    }
}
