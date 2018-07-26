using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Services.Interface
{
    public interface ICheckLengthPasswordService
    {
        MessageModel CheckLengthPassword(string password);
        string GetMessage(int lengthPassword);
    }
}
