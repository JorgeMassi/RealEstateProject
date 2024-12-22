using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Domain.Roles
{
    public class AdministrativeUser
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public List<Appointment> Calendar { get; private set; } = new List<Appointment>();
    }
