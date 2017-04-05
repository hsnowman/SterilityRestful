using SterilityRestful.CommonLibrary;
using System;
using System.Web;

namespace SterilityRestful.DataMethod
{
    public class OperationMethod
    {
        /// <summary>
        /// 无菌隔离器、培养箱操作记录
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="EquipmentId"></param>
        /// <param name="OperationNo"></param>
        /// <param name="OperationTime"></param>
        /// <param name="OperationCode"></param>
        /// <param name="OperationValue"></param>
        /// <param name="OperationResult"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <returns></returns>
        public int OpEquipmentSetData(DataConnection pclsCache, string EquipmentId, string OperationNo, DateTime OperationTime, string OperationCode, string OperationValue, string OperationResult, string TerminalIP, string TerminalName, string revUserId)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(Op.OpEquipment.SetData(pclsCache.CacheConnectionObject, EquipmentId, OperationNo, OperationTime, OperationCode, OperationValue, OperationResult, TerminalIP, TerminalName, revUserId));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "OperationMethod.OpEquipmentSetData", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }
    }
}
