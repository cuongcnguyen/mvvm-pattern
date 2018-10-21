using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TheDebtBook.Models;
using TheDebtBook.Views;

namespace TheDebtBook.ViewModels
{

    public class ChildViewModel : Screen
    {
        public string Name { get; set; }
        public int Amount { get; set; }

        public bool CanClose { get; set; }

        public void CloseAddDebtorWindow(ChildView2 childView2)
        {
            childView2?.Close();
        }


    }
}
