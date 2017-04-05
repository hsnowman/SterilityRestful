using SterilityRestful.CommonLibrary;
using System;
using System.Web;

namespace SterilityRestful.DataMethod
{
    public class UserInfoMethod
    {
        /// <summary>
        /// 注册 -2：连接数据库失败 -1：同一用户名的同一角色已经存在 0：注册失败 1：注册成功
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="UserId"></param>
        /// <param name="Identify"></param>
        /// <param name="PhoneNo"></param>
        /// <param name="UserName"></param>
        /// <param name="Role"></param>
        /// <param name="Password"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <returns></returns>
        public int MstUserRegister(DataConnection pclsCache, string UserId, string Identify, long PhoneNo, string UserName, string Role, string Password, string TerminalIP, string TerminalName, string revUserId)
        {
            int Result = -2;
            try 
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(Cm.MstUser.Register(pclsCache.CacheConnectionObject, UserId, Identify, PhoneNo, UserName, Role, Password, TerminalIP, TerminalName, revUserId));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "UserInfoMethod.MstUserRegister", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 登录 -2：连接数据库失败 -1：密码错误 0：用户不存在 1：登录成功
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="UserId"></param>
        /// <param name="InPassword"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <returns></returns>
        public int MstUserLogin(DataConnection pclsCache, string UserId, string InPassword, string TerminalIP, string TerminalName, string revUserId)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(Cm.MstUser.Login(pclsCache.CacheConnectionObject, UserId, InPassword, TerminalIP, TerminalName, revUserId));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "UserInfoMethod.MstUserLogin", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 修改密码 -2：连接数据库失败 -1：旧密码错误 0：修改失败 1：修改成功
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="UserId"></param>
        /// <param name="IfPhone"></param>
        /// <param name="OldPassword"></param>
        /// <param name="NewPassword"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <returns></returns>
        public int MstUserChangePassword(DataConnection pclsCache, string UserId, int IfPhone, string OldPassword, string NewPassword, string TerminalIP, string TerminalName, string revUserId)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(Cm.MstUser.ChangePassword(pclsCache.CacheConnectionObject, UserId, IfPhone, OldPassword, NewPassword, TerminalIP, TerminalName, revUserId));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "UserInfoMethod.MstUserChangePassword", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 修改个人信息 -2：连接数据库失败 0：修改失败 1：修改成功
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="UserId"></param>
        /// <param name="Identify"></param>
        /// <param name="PhoneNo"></param>
        /// <param name="UserName"></param>
        /// <param name="Role"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <returns></returns>
        public int MstUserUpdateUserInfo(DataConnection pclsCache, string UserId, string Identify, long PhoneNo, string UserName, string Role, string TerminalIP, string TerminalName, string revUserId)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(Cm.MstUser.UpdateUserInfo(pclsCache.CacheConnectionObject, UserId, Identify, PhoneNo, UserName, Role, TerminalIP, TerminalName, revUserId));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "UserInfoMethod.MstUserUpdateUserInfo", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 得到用户信息 格式为A|B|C，输入中1表示取，0表示不取
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="UserId"></param>
        /// <param name="Identify"></param>
        /// <param name="PhoneNo"></param>
        /// <param name="UserName"></param>
        /// <param name="Role"></param>
        /// <param name="Password"></param>
        /// <param name="LastLoginTime"></param>
        /// <param name="RevisionInfo"></param>
        /// <returns></returns>
        public string MstUserGetUserInfo(DataConnection pclsCache, string UserId, int Identify, int PhoneNo, int UserName, int Role, int Password, int LastLoginTime, int RevisionInfo)
        {
            string Result = "";
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Cm.MstUser.GetUserInfo(pclsCache.CacheConnectionObject, UserId, Identify, PhoneNo, UserName, Role, Password, LastLoginTime, RevisionInfo);
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "UserInfoMethod.MstUserGetUserInfo", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 根据手机号获取用户唯一标识符
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="PhoneNo"></param>
        /// <returns></returns>
        public string MstUserGetUserByPhoneNo(DataConnection pclsCache, long PhoneNo)
        {
            string Result = "";
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Cm.MstUser.GetUserByPhoneNo(pclsCache.CacheConnectionObject, PhoneNo);
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "UserInfoMethod.MstUserGetUserByPhoneNo", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 创建UserId
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="PhoneNo"></param>
        /// <returns></returns>
        public string MstUserCreateNewUserId(DataConnection pclsCache, long PhoneNo)
        {
            string Result = "";
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Cm.MstUser.CreateNewUserId(pclsCache.CacheConnectionObject, PhoneNo);
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "UserInfoMethod.MstUserCreateNewUserId", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }
    }
}
