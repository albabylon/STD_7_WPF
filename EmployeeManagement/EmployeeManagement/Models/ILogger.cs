using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public interface ILogger
    {
        public void WriteEvent(string eventMessage);
        public void WriteError(string errorMessage);
    }
}
