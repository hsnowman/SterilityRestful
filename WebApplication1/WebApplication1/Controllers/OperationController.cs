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
    public class OperationController : ApiController
    {
        static readonly IOperationRepository repository = new OperationRepository();
        DataConnection pclsCache = new DataConnection();

        /// <summary>
        /// 无菌隔离器、培养箱操作记录
        /// </summary>
        /// <param name="operationInfo"></param>
        /// <returns></returns>
        [Route("Api/v1/Operation/OpEquipmentSetData")]
        public HttpResponseMessage OpEquipmentSetData(OperationInfo operationInfo)
        {
            int ret = repository.OpEquipmentSetData(pclsCache, operationInfo.EquipmentId, operationInfo.OperationNo, operationInfo.OperationTime, operationInfo.OperationCode, operationInfo.OperationValue, operationInfo.OperationResult, operationInfo.TerminalIP, new ExceptionHandler().getTerminalName(), operationInfo.revUserId);
            return new ExceptionHandler().SetData(Request, ret);
        }
    }
}