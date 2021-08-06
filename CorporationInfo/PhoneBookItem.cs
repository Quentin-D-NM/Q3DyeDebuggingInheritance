using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public abstract class PhoneBookItem
    {
        public abstract string GetContactSummary(); //this class/method should be abstract because getcontactsummary is defined within subclasses

    }
}
