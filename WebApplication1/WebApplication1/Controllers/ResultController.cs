using SterilityRestful.CommonLibrary;
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
    public class ResultController : ApiController
    {
        static readonly IResultRepository repository = new ResultRepository();
        DataConnection pclsCache = new DataConnection();

        /// <summary>
        /// 检测结果录入
        /// </summary>
        /// <param name="testResult"></param>
        /// <returns></returns>
        [Route("Api/v1/Result/ResTestResultSetData")]
        public HttpResponseMessage ResTestResultSetData(TestResultInfo testResultInfo)
        {
            int ret = repository.ResTestResultSetData(pclsCache, testResultInfo.TestId, testResultInfo.ObjectNo, testResultInfo.ObjCompany, testResultInfo.ObjIncuSeq, testResultInfo.TestType, testResultInfo.TestStand, testResultInfo.TestEquip, testResultInfo.Description, testResultInfo.CollectStart, testResultInfo.CollectEnd, testResultInfo.TestTime, testResultInfo.TestResult, testResultInfo.TestPeople, testResultInfo.ReStatus, testResultInfo.RePeople, testResultInfo.ReTime, testResultInfo.TerminalIP, new ExceptionHandler().getTerminalName(), testResultInfo.revUserId);
            return new ExceptionHandler().SetData(Request, ret);
        }

        /// <summary>
        /// 样品培养记录
        /// </summary>
        /// <param name="resIncubator"></param>
        /// <returns></returns>
        [Route("Api/v1/Result/ResIncubatorSetData")]
        public HttpResponseMessage ResIncubatorSetData(ResIncubator resIncubator)
        {
            int ret = repository.ResIncubatorSetData(pclsCache, resIncubator.TestId, resIncubator.TubeNo, resIncubator.CultureId, resIncubator.BacterId, resIncubator.OtherRea, resIncubator.IncubatorId, resIncubator.StartTime, resIncubator.EndTime, resIncubator.AnalResult);
            return new ExceptionHandler().SetData(Request, ret);
        }
    }
}