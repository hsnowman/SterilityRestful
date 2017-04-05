using SterilityRestful.CommonLibrary;
using System;
using System.Web;

namespace SterilityRestful.Models
{
    public interface IUserInfoRepository
    {
        int MstUserRegister(DataConnection pclsCache, string UserId, string Identify, long PhoneNo, string UserName, string Role, string Password, string TerminalIP, string TerminalName, string revUserId);

        int MstUserLogin(DataConnection pclsCache, string UserId, string InPassword, string TerminalIP, string TerminalName, string revUserId);

        int MstUserChangePassword(DataConnection pclsCache, string UserId, int IfPhone, string OldPassword, string NewPassword, string TerminalIP, string TerminalName, string revUserId);

        int MstUserUpdateUserInfo(DataConnection pclsCache, string UserId, string Identify, long PhoneNo, string UserName, string Role, string TerminalIP, string TerminalName, string revUserId);

        string MstUserGetUserInfo(DataConnection pclsCache, string UserId, int Identify, int PhoneNo, int UserName, int Role, int Password, int LastLoginTime, int RevisionInfo);

        string MstUserGetUserByPhoneNo(DataConnection pclsCache, long PhoneNo);

        string MstUserCreateNewUserId(DataConnection pclsCache, long PhoneNo);
    }
}
