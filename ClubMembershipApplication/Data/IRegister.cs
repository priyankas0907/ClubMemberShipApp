using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembershipApplication.Data
{
    public interface IRegister
    {
        bool EmailExists(string emailAddress);
        bool Register(string[] fields);

    }
}
