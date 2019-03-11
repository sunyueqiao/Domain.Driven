using Domain.Driven.Domain;
using Domain.Driven.Domain.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Driven.Application.User
{
    public class UserAppService : IUserAppService
    {
        private readonly IRepository<long, UserInfo> _userRepository;
        private readonly IRepository<long, UserContact> _userContackRepository;

        public UserAppService(IRepository<long, UserInfo> userRepository, IRepository<long, UserContact> userContactRepository)
        {
            this._userRepository = userRepository;
            this._userContackRepository = userContactRepository;
        }

        public UserInfo GetUserById(long userId)
        {
            UserInfo userInfo = new UserInfo();
            return userInfo;
        }

        private List<UserContact> GetContacts(long userId)
        {
            return new List<UserContact>();
        }
    }
}
