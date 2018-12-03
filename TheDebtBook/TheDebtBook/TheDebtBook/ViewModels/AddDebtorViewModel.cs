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
        private readonly BindableCollection<Debtor> _debtors;
        public AddDebtorViewModel(BindableCollection<Debtor> debtors)
        {
            this._debtors = debtors;
        }

        private string _newName;

        public string NewName
        {
            get => _newName;
            set
            {
                _newName = value;
                NotifyOfPropertyChange(() => NewName);
            }
        }                

        private int _debt;
        public int Debt
        {
            get => _debt;
            set
            {
                _debt = value;
                NotifyOfPropertyChange(() => Debt);
            }
        }

        public void AddDebtor()
        {            
            Debtor d = new Debtor { Name = NewName, Amount = Debt };            
            _debtors.Add(d);
            TryClose();
        }

        public void Close()
        {
            TryClose();
        }

    }
}
