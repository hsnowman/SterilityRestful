using System;
using System.Web;

namespace WebApplication1.DataModels
{
    public class UserInfo
    {
    }

    public class Register
    {
        public string UserId { get; set; }
        public string Identify { get; set; }
        public long PhoneNo { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public string TerminalIP { get; set; }
        public string revUserId { get; set; }
    }

    public class Login
    {
        public string UserId { get; set; }
        public string InPassword { get; set; }
        public string TerminalIP { get; set; }
        public string revUserId { get; set; }
    }

    public class ChangePassword
    {
        public string UserId { get; set; }
        public int IfPhone { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string TerminalIP { get; set; }
        public string revUserId { get; set; }
    }

    public class UpdateUserInfo
    {
        public string UserId { get; set; }
        public string Identify { get; set; }
        public long PhoneNo { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public string TerminalIP { get; set; }
        public string revUserId { get; set; }
    }
}
