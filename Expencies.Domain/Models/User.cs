using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expencies.Domain.Models
{
    public enum SocialStatus
    {
        Unknown = 0,
        Worker = 1,
        Student = 2,
        Pensioner = 3,
        Child = 4
    }

    public class User
    {
        public Guid UserId;
        public String UserName;
        public SocialStatus Status;

    }
}
