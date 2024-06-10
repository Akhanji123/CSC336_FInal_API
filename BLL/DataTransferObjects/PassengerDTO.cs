using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DataTransferObjects
{
    public class PassengerDTO
    {
        public int PassengerId { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateOnly? DateOfBirth { get; set; }

        public string? PassportNumber { get; set; }

    }
}
