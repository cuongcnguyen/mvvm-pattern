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

    public abstract class ChildViewModel : ObservableObject
    {
        private ICommand _closeCommand;
        public ICommand CloseCommand
        {
            get
            {
                return _closeCommand ?? (_closeCommand = new RelayCommand(
                           param => Close(),
                           param => CanClose()
                       ));
            }
        }

        public event Action RequestClose;

        public virtual void Close()
        {
            RequestClose?.Invoke();
        }

        public virtual bool CanClose()
        {
            return true;
        }

        public string Name { get; set; }
        public int Amount { get; set; }

    }
}
