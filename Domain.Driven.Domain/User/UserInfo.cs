using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Driven.Domain.User
{
    public class UserInfo : AggregateRoot
    {
        public List<UserContact> UserContacts { get; set; }
    }
}
