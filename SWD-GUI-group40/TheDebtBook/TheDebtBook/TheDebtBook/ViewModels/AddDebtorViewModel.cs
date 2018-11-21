using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TheDebtBook.Models;
using TheDebtBook.Views;
using Action = System.Action;

namespace TheDebtBook.ViewModels
{

    public class AddDebtorViewModel : Screen
    {
        private BindableCollection<Debtor> debtors;
        public AddDebtorViewModel(BindableCollection<Debtor> debtors)
        {
            this.debtors = debtors;
        }

        private string newName;

        public string NewName
        {
            get { return newName; }
            set
            {
                newName = value;
                NotifyOfPropertyChange(() => NewName);
            }
        }                

        private int debt;
        public int Debt
        {
            get { return debt; }
            set
            {
                debt = value;
                NotifyOfPropertyChange(() => Debt);
            }
        }

        public void AddDebtor()
        {            
            Debtor d = new Debtor { Name = NewName, Amount = Debt };            
            debtors.Add(d);
            TryClose();
        }

        public void Close()
        {
            TryClose();
        }

    }
}
