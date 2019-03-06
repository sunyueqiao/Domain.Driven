using Domain.Driven.Domain.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Driven.Application.User
{
    public interface IUserAppService : IApplicationService
    {
        UserInfo GetUserById(long userId);
    }
}
