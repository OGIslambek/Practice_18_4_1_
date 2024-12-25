using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice_18_4_1_.Interfaces;

namespace Practice_18_4_1_
{
    internal class User
    {
        Icommand _command;

        public void SetCommand(Icommand command)
        {
            this._command = command;
        }

        public void RunCommand()
        {
            _command.Run();
        }

    }
}
