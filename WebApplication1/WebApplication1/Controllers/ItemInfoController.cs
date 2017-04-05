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
    public class ItemInfoController : ApiController
    {
        static readonly IItemInfoRepository repository = new ItemInfoRepository();
        DataConnection pclsCache = new DataConnection();

        /// <summary>
        /// 无菌隔离器信息插入
        /// </summary>
        /// <param name="isolatorInfo"></param>
        /// <returns></returns>
        [Route("Api/v1/ItemInfo/ItemIsolatorSetData")]
        public HttpResponseMessage ItemIsolatorSetData(IsolatorInfo isolatorInfo)
        {
            int ret = repository.ItemIsolatorSetData(pclsCache, isolatorInfo.IsolatorId, isolatorInfo.ProductDay, isolatorInfo.EquipPro, isolatorInfo.InsDescription, isolatorInfo.TerminalIP, new ExceptionHandler().getTerminalName(), isolatorInfo.revUserId);
            return new ExceptionHandler().SetData(Request, ret);
        }

        /// <summary>
        /// 培养箱信息插入
        /// </summary>
        /// <param name="incubatorInfo"></param>
        /// <returns></returns>
        [Route("Api/v1/ItemInfo/ItemIncubatorSetData")]
        public HttpResponseMessage ItemIncubatorSetData(IncubatorInfo incubatorInfo)
        {
            int ret = repository.ItemIncubatorSetData(pclsCache, incubatorInfo.IncubatorId, incubatorInfo.ProductDay, incubatorInfo.EquipPro, incubatorInfo.InsDescription, incubatorInfo.TerminalIP, new ExceptionHandler().getTerminalName(), incubatorInfo.revUserId);
            return new ExceptionHandler().SetData(Request, ret);
        }

        /// <summary>
        /// 试剂信息插入
        /// </summary>
        /// <param name="reagentInfo"></param>
        /// <returns></returns>
        [Route("Api/v1/ItemInfo/ItemReagentSetData")]
        public HttpResponseMessage ItemReagentSetData(ReagentInfo reagentInfo)
        {
            int ret = repository.ItemReagentSetData(pclsCache, reagentInfo.ReagentId, reagentInfo.ProductDay, reagentInfo.ReagentType, reagentInfo.ExpiryDay, reagentInfo.ReagentName, reagentInfo.ReagentTest, reagentInfo.SaveCondition, reagentInfo.Description, reagentInfo.TerminalIP, new ExceptionHandler().getTerminalName(), reagentInfo.revUserId);
            return new ExceptionHandler().SetData(Request, ret);
        }

        /// <summary>
        /// 样品信息插入
        /// </summary>
        /// <param name="sampleInfo"></param>
        /// <returns></returns>
        [Route("Api/v1/ItemInfo/ItemSampleSetData")]
        public HttpResponseMessage ItemSampleSetData(SampleInfo sampleInfo)
        {
            int ret = repository.ItemSampleSetData(pclsCache, sampleInfo.ObjectNo, sampleInfo.ObjCompany, sampleInfo.ObjIncuSeq, sampleInfo.ObjectName, sampleInfo.ObjectType, sampleInfo.SamplingPeople, sampleInfo.SamplingTime, sampleInfo.SamplingWay, sampleInfo.SamplingTool, sampleInfo.SamAmount, sampleInfo.DevideWay, sampleInfo.SamContain, sampleInfo.Warning, sampleInfo.SamSave, sampleInfo.TerminalIP, new ExceptionHandler().getTerminalName(), sampleInfo.revUserId);
            return new ExceptionHandler().SetData(Request, ret);
        }

        /// <summary>
        /// 培养箱环境录入
        /// </summary>
        /// <param name="incubatorEnv"></param>
        /// <returns></returns>
        [Route("Api/v1/ItemInfo/EnvIncubatorSetData")]
        public HttpResponseMessage EnvIncubatorSetData(IncubatorEnv incubatorEnv)
        {
            int ret = repository.EnvIncubatorSetData(pclsCache, incubatorEnv.IncubatorId, incubatorEnv.MeaTime, incubatorEnv.Temperature, incubatorEnv.TerminalIP, new ExceptionHandler().getTerminalName(), incubatorEnv.revUserId);
            return new ExceptionHandler().SetData(Request, ret);
        }

        /// <summary>
        /// 无菌隔离器环境录入
        /// </summary>
        /// <param name="isolatorEnv"></param>
        /// <returns></returns>
        [Route("Api/v1/ItemInfo/EnvIsolatorSetData")]
        public HttpResponseMessage EnvIsolatorSetData(IsolatorEnv isolatorEnv)
        {
            int ret = repository.EnvIsolatorSetData(pclsCache, isolatorEnv.IsolatorId, isolatorEnv.CabinId, isolatorEnv.MeaTime, isolatorEnv.IsoCode, isolatorEnv.IsoValue, isolatorEnv.TerminalIP, new ExceptionHandler().getTerminalName(), isolatorEnv.revUserId);
            return new ExceptionHandler().SetData(Request, ret);
        }
    }
}