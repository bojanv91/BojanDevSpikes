using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDS.LiteCQRS.Impl
{
    public class CreateAccountHandler : IBaseHandler<CreateAccountCommand, int>
    {
        public int Handle(CreateAccountCommand message)
        {
            return 5;
        }
    }
}
