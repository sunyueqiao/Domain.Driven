using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Driven.Domain.User
{
    public class UserContact : Entity
    {
        public UserContact(string mobile, string realName, string address)
        {
            this.Mobile = mobile;
            this.RealName = RealName;
            this.Address = address;
        }

        public string Mobile { get; private set; }

        public string RealName { get; private set; }

        public string Address { get; private set; }
    }
}
