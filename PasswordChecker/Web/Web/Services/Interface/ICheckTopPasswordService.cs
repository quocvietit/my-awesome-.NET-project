using System;
using System.Collections.Generic;
using Web.Models;

namespace Web.Services.Interface
{
    public interface ICheckTopPasswordService
    {
        List<String> GetTopPasswords();
        MessageModel CheckTopPasswords(string password);
        bool Check(string password);
        int GetTopNumber(string password);
    }
}
