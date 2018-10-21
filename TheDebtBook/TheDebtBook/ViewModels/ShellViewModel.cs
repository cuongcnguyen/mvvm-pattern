using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TheDebtBook.Models;
using TheDebtBook.Views;

namespace TheDebtBook.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        public ShellViewModel()
        {          

            Debtors.Add(new DebtorModels { Name = "Mickey Mouse", Amount = -100 });
            Debtors.Add(new DebtorModels { Name = "Donald Duck", Amount = 1321 });
            Debtors.Add(new DebtorModels { Name = "Tom Cruise", Amount = 300 });           
        }
       
        public BindableCollection<DebtorModels> Debtors { get; set; } = new BindableCollection<DebtorModels>();

        public void OpenChildPage()
        {
            ChildView2 addDebtorWindow = new ChildView2();
            addDebtorWindow.Show();
        }
    }
}
