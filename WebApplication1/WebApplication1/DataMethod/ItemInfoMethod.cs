using SterilityRestful.CommonLibrary;
using System;
using System.Web;

namespace SterilityRestful.DataMethod
{
    public class ItemInfoMethod
    {
        /// <summary>
        /// 无菌隔离器信息插入
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="IsolatorId"></param>
        /// <param name="ProductDay"></param>
        /// <param name="EquipPro"></param>
        /// <param name="InsDescription"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <returns></returns>
        public int ItemIsolatorSetData(DataConnection pclsCache, string IsolatorId, DateTime ProductDay, string EquipPro, string InsDescription, string TerminalIP, string TerminalName, string revUserId)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(It.ItemIsolator.SetData(pclsCache.CacheConnectionObject, IsolatorId, ProductDay, EquipPro, InsDescription, TerminalIP, TerminalName, revUserId));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ItemInfoMethod.ItemIsolatorSetData", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 培养箱信息插入
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="IncubatorId"></param>
        /// <param name="ProductDay"></param>
        /// <param name="EquipPro"></param>
        /// <param name="InsDescription"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <returns></returns>
        public int ItemIncubatorSetData(DataConnection pclsCache, string IncubatorId, DateTime ProductDay, string EquipPro, string InsDescription, string TerminalIP, string TerminalName, string revUserId)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(It.ItemIncubator.SetData(pclsCache.CacheConnectionObject, IncubatorId, ProductDay, EquipPro, InsDescription, TerminalIP, TerminalName, revUserId));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ItemInfoMethod.ItemIncubatorSetData", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 试剂信息插入
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="ReagentId"></param>
        /// <param name="ProductDay"></param>
        /// <param name="ReagentType"></param>
        /// <param name="ExpiryDay"></param>
        /// <param name="ReagentName"></param>
        /// <param name="ReagentTest"></param>
        /// <param name="SaveCondition"></param>
        /// <param name="Description"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <returns></returns>
        public int ItemReagentSetData(DataConnection pclsCache, string ReagentId, DateTime ProductDay, string ReagentType, DateTime ExpiryDay, string ReagentName, string ReagentTest, string SaveCondition, string Description, string TerminalIP, string TerminalName, string revUserId)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(It.ItemReagent.SetData(pclsCache.CacheConnectionObject, ReagentId, ProductDay, ReagentType, ExpiryDay, ReagentName, ReagentTest, SaveCondition, Description, TerminalIP, TerminalName, revUserId));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ItemInfoMethod.ItemReagentSetData", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 样品信息插入
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="ObjectNo"></param>
        /// <param name="ObjCompany"></param>
        /// <param name="ObjIncuSeq"></param>
        /// <param name="ObjectName"></param>
        /// <param name="ObjectType"></param>
        /// <param name="SamplingPeople"></param>
        /// <param name="SamplingTime"></param>
        /// <param name="SamplingWay"></param>
        /// <param name="SamplingTool"></param>
        /// <param name="SamAmount"></param>
        /// <param name="DevideWay"></param>
        /// <param name="SamContain"></param>
        /// <param name="Warning"></param>
        /// <param name="SamSave"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <returns></returns>
        public int ItemSampleSetData(DataConnection pclsCache, string ObjectNo, string ObjCompany, string ObjIncuSeq, string ObjectName, string ObjectType, string SamplingPeople, DateTime SamplingTime, string SamplingWay, string SamplingTool, string SamAmount, string DevideWay, string SamContain, string Warning, string SamSave, string TerminalIP, string TerminalName, string revUserId)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(It.ItemSample.SetData(pclsCache.CacheConnectionObject, ObjectNo, ObjCompany, ObjIncuSeq, ObjectName, ObjectType, SamplingPeople, SamplingTime, SamplingWay, SamplingTool, SamAmount, DevideWay, SamContain, Warning, SamSave, TerminalIP, TerminalName, revUserId));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ItemInfoMethod.ItemSampleSetData", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 培养箱环境录入
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="IncubatorId"></param>
        /// <param name="MeaTime"></param>
        /// <param name="Temperature"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <returns></returns>
        public int EnvIncubatorSetData(DataConnection pclsCache, string IncubatorId, DateTime MeaTime, int Temperature, string TerminalIP, string TerminalName, string revUserId)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(It.EnvIncubator.SetData(pclsCache.CacheConnectionObject, IncubatorId, MeaTime, Temperature, TerminalIP, TerminalName, revUserId));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ItemInfoMethod.EnvIncubatorSetData", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 无菌隔离器环境录入
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="IsolatorId"></param>
        /// <param name="CabinId"></param>
        /// <param name="MeaTime"></param>
        /// <param name="IsoCode"></param>
        /// <param name="IsoValue"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <returns></returns>
        public int EnvIsolatorSetData(DataConnection pclsCache, string IsolatorId, string CabinId, DateTime MeaTime, string IsoCode, string IsoValue, string TerminalIP, string TerminalName, string revUserId)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(It.EnvIsolator.SetData(pclsCache.CacheConnectionObject, IsolatorId, CabinId, MeaTime, IsoCode, IsoValue, TerminalIP, TerminalName, revUserId));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ItemInfoMethod.EnvIsolatorSetData", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }
    }
}
