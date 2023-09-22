using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iText.Kernel.Crypto.Securityhandler;

namespace Domain.Entities
{
    public class Charge
    {
        public string Name {get;set;}
        
        public ICollection<Employee> Employees {get;set;}
    }
}