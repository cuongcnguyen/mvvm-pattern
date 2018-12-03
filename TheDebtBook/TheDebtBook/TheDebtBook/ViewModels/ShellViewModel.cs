using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TheDebtBook.Models;
using TheDebtBook.Views;

namespace TheDebtBook.ViewModels
{
    public class ShellViewModel : Screen
    {
        private BindableCollection<Debtor> debtor = new BindableCollection<Debtor>();
        public ShellViewModel()
        {
            
            Debtors.Add(new Debtor { Name = "Mickey Mouse", Amount = -100 });
            Debtors.Add(new Debtor { Name = "Donald Duck", Amount = 1321 });
            Debtors.Add(new Debtor { Name = "Tom Cruise", Amount = 300 });
           
        }
       
        public BindableCollection<Debtor> Debtors
        {   get => debtor;
            set => debtor = value;
        }

        private Debtor selectedDebtor;

        public Debtor SelectedDebtor
        {
            get => selectedDebtor;
            set
            {
                selectedDebtor = value;
                NotifyOfPropertyChange(() => SelectedDebtor);
            }
        }        

        public void OpenAddDebtorPage()
        {
            var windowManager = new WindowManager();
            windowManager.ShowWindow(new AddDebtorViewModel(Debtors));
        }
    }
}
