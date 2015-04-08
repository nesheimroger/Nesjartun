using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap.Configuration.DSL;

namespace Nesjartun.Contact
{
    public class ContactRegistry : Registry
    {
        public ContactRegistry()
        {
            For<IContactService>().Use<ContactService>();
        }
    }
}
