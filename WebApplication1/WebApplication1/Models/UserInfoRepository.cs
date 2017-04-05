using SterilityRestful.CommonLibrary;
using SterilityRestful.DataMethod;
using System;
using System.Web;

namespace SterilityRestful.Models
{
    public class UserInfoRepository : IUserInfoRepository
    {
        UserInfoMethod UserInfoMethod = new UserInfoMethod();
        public int MstUserRegister(DataConnection pclsCache, string UserId, string Identify, long PhoneNo, string UserName, string Role, string Password, string TerminalIP, string TerminalName, string revUserId)
        {
            return UserInfoMethod.MstUserRegister(pclsCache, UserId, Identify, PhoneNo, UserName, Role, Password, TerminalIP, TerminalName, revUserId);
        }

        public int MstUserLogin(DataConnection pclsCache, string UserId, string InPassword, string TerminalIP, string TerminalName, string revUserId)
        {
            return UserInfoMethod.MstUserLogin(pclsCache, UserId, InPassword, TerminalIP, TerminalName, revUserId);
        }

        public int MstUserChangePassword(DataConnection pclsCache, string UserId, int IfPhone, string OldPassword, string NewPassword, string TerminalIP, string TerminalName, string revUserId)
        {
            return UserInfoMethod.MstUserChangePassword(pclsCache, UserId, IfPhone, OldPassword, NewPassword, TerminalIP, TerminalName, revUserId);
        }

        public int MstUserUpdateUserInfo(DataConnection pclsCache, string UserId, string Identify, long PhoneNo, string UserName, string Role, string TerminalIP, string TerminalName, string revUserId)
        {
            return UserInfoMethod.MstUserUpdateUserInfo(pclsCache, UserId, Identify, PhoneNo, UserName, Role, TerminalIP, TerminalName, revUserId);
        }

        public string MstUserGetUserInfo(DataConnection pclsCache, string UserId, int Identify, int PhoneNo, int UserName, int Role, int Password, int LastLoginTime, int RevisionInfo)
        {
            return UserInfoMethod.MstUserGetUserInfo(pclsCache, UserId, Identify, PhoneNo, UserName, Role, Password, LastLoginTime, RevisionInfo);
        }

        public string MstUserGetUserByPhoneNo(DataConnection pclsCache, long PhoneNo)
        {
            return UserInfoMethod.MstUserGetUserByPhoneNo(pclsCache, PhoneNo);
        }

        public string MstUserCreateNewUserId(DataConnection pclsCache, long PhoneNo)
        {
            return UserInfoMethod.MstUserCreateNewUserId(pclsCache, PhoneNo);
        }
    }
}
