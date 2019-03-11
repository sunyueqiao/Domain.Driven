using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Driven.Domain.User
{
    public class UserInfo : AggregateRoot
    {
        public IList<UserContact> UserContacts { get; private set; }

        public UserInfo AttachUserContacts(IEnumerable<UserContact> userContacts)
        {
            List<UserContact> list = new List<UserContact>();
            list.AddRange(userContacts);
            this.UserContacts = list;
            return this;
        }
    }
}
