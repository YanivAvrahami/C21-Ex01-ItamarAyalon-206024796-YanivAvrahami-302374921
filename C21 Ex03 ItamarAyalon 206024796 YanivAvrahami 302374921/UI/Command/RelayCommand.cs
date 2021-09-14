using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal class RelayCommand : ICommand
    {
        private Action m_Action;

        public RelayCommand(Action i_Action)
        {
            m_Action = i_Action;
        }

        public void Execute()
        {
            m_Action.Invoke();
        }
    }
}
