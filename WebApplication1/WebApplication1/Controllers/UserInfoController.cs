﻿using SterilityRestful.CommonLibrary;
using SterilityRestful.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApplication1.CommonLibrary;
using WebApplication1.DataModels;

namespace SterilityRestful.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserInfoController : ApiController
    {
        static readonly IUserInfoRepository repository = new UserInfoRepository();
        DataConnection pclsCache = new DataConnection();
        
        /// <summary>
        /// 注册 注册 -2：连接数据库失败 -1：同一用户名的同一角色已经存在 0：注册失败 1：注册成功
        /// </summary>
        /// <param name="register"></param>
        /// <returns></returns>
        [Route("Api/v1/UserInfo/MstUserRegister")]
        public HttpResponseMessage MstUserRegister(Register register)
        {
            int ret = repository.MstUserRegister(pclsCache, register.UserId, register.Identify, register.PhoneNo, register.UserName, register.Role, register.Password, register.TerminalIP, new ExceptionHandler().getTerminalName(), register.revUserId);
            return new ExceptionHandler().Register(Request, ret);
        }

        /// <summary>
        /// 登录 -2：连接数据库失败 -1：密码错误 0：用户不存在 1：登录成功
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        [Route("Api/v1/UserInfo/MstUserLogin")]
        public HttpResponseMessage MstUserLogin(Login login)
        {
            int ret = repository.MstUserLogin(pclsCache, login.UserId, login.InPassword, login.TerminalIP, new ExceptionHandler().getTerminalName(), login.revUserId);
            return new ExceptionHandler().Login(Request, ret);
        }

        /// <summary>
        /// 修改密码 -2：连接数据库失败 -1：旧密码错误 0：修改失败 1：修改成功
        /// </summary>
        /// <param name="changePassword"></param>
        /// <returns></returns>
        [Route("Api/v1/UserInfo/MstUserChangePassword")]
        public HttpResponseMessage MstUserChangePassword(ChangePassword changePassword)
        {
            int ret = repository.MstUserChangePassword(pclsCache, changePassword.UserId, changePassword.IfPhone, changePassword.OldPassword, changePassword.NewPassword, changePassword.TerminalIP, new ExceptionHandler().getTerminalName(), changePassword.revUserId);
            return new ExceptionHandler().ChangePassword(Request, ret);
        }

        /// <summary>
        /// 修改个人信息 -2：连接数据库失败 0：修改失败 1：修改成功
        /// </summary>
        /// <param name="updateUserInfo"></param>
        /// <returns></returns>
        [Route("Api/v1/UserInfo/MstUserUpdateUserInfo")]
        public HttpResponseMessage MstUserUpdateUserInfo(UpdateUserInfo updateUserInfo)
        {
            int ret = repository.MstUserUpdateUserInfo(pclsCache, updateUserInfo.UserId, updateUserInfo.Identify, updateUserInfo.PhoneNo, updateUserInfo.UserName, updateUserInfo.Role, updateUserInfo.TerminalIP, new ExceptionHandler().getTerminalName(), updateUserInfo.revUserId);
            return new ExceptionHandler().SetData(Request, ret);
        }
        
        /// <summary>
        /// 得到用户信息 格式为A|B|C，输入中1表示取，0表示不取
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="Identify"></param>
        /// <param name="PhoneNo"></param>
        /// <param name="UserName"></param>
        /// <param name="Role"></param>
        /// <param name="Password"></param>
        /// <param name="LastLoginTime"></param>
        /// <param name="RevisionInfo"></param>
        /// <returns></returns>
        [Route("Api/v1/UserInfo/MstUserGetUserInfo")]
        [HttpGet]
        public string MstUserGetUserInfo(string UserId, int Identify, int PhoneNo, int UserName, int Role, int Password, int LastLoginTime, int RevisionInfo )
        {
            return repository.MstUserGetUserInfo(pclsCache, UserId, Identify, PhoneNo, UserName, Role, Password, LastLoginTime, RevisionInfo);
        }

        /// <summary>
        /// 根据手机号获取用户唯一标识符
        /// </summary>
        /// <param name="PhoneNo"></param>
        /// <returns></returns>
        [Route("Api/v1/UserInfo/MstUserGetUserByPhoneNo")]
        [HttpGet]
        public string MstUserGetUserByPhoneNo(long PhoneNo)
        {
            return repository.MstUserGetUserByPhoneNo(pclsCache, PhoneNo);
        }

        /// <summary>
        /// 用手机号获取UserId
        /// </summary>
        /// <param name="PhoneNo"></param>
        /// <returns></returns>
        [Route("Api/v1/UserInfo/MstUserCreateNewUserId")]
        [HttpGet]
        public string MstUserCreateNewUserId(long PhoneNo)
        {
            return repository.MstUserCreateNewUserId(pclsCache, PhoneNo);
        }
    }
}