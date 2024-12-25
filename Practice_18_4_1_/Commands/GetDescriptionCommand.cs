using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice_18_4_1_.Interfaces;

namespace Practice_18_4_1_.Commands
{
    internal class GetDescriptionCommand : Icommand
    {
        Ireceiver getDescription;
        public GetDescriptionCommand(Ireceiver getDescription)
        {
            this.getDescription = getDescription;
        }

        public async void Run()
        {
            await getDescription.Operation();
        }
    }
}
