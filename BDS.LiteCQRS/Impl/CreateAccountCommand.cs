using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace BDS.LiteCQRS.Impl
{
    public class CreateAccountCommand : IRequest<int>
    {
        public string FullName { get; set; }

        public string BusinessEmail { get; set; }

        public string Company { get; set; }

        public string PhoneNumber { get; set; }

        public string JobTitle { get; set; }
    }
}
