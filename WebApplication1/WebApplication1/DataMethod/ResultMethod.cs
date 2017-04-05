using SterilityRestful.CommonLibrary;
using System;
using System.Web;

namespace SterilityRestful.DataMethod
{
    public class ResultMethod
    {
        /// <summary>
        /// 检测结果录入
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="TestId"></param>
        /// <param name="ObjectNo"></param>
        /// <param name="ObjCompany"></param>
        /// <param name="ObjIncuSeq"></param>
        /// <param name="TestType"></param>
        /// <param name="TestStand"></param>
        /// <param name="TestEquip"></param>
        /// <param name="Description"></param>
        /// <param name="CollectStart"></param>
        /// <param name="CollectEnd"></param>
        /// <param name="TestTime"></param>
        /// <param name="TestResult"></param>
        /// <param name="TestPeople"></param>
        /// <param name="ReStatus"></param>
        /// <param name="RePeople"></param>
        /// <param name="ReTime"></param>
        /// <param name="TerminalIP"></param>
        /// <param name="TerminalName"></param>
        /// <param name="revUserId"></param>
        /// <returns></returns>
        public int ResTestResultSetData(DataConnection pclsCache, string TestId, string ObjectNo, string ObjCompany, string ObjIncuSeq, string TestType, string TestStand, string TestEquip, string Description, DateTime CollectStart, DateTime CollectEnd, DateTime TestTime, string TestResult, string TestPeople, int ReStatus, string RePeople, string ReTime, string TerminalIP, string TerminalName, string revUserId)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(Rs.ResTestResult.SetData(pclsCache.CacheConnectionObject, TestId, ObjectNo, ObjCompany, ObjIncuSeq, TestType, TestStand, TestEquip, Description, CollectStart, CollectEnd, TestTime, TestResult, TestPeople, ReStatus, RePeople, ReTime, TerminalIP, TerminalName, revUserId));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ResultMethod.ResTestResultSetData", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }

        /// <summary>
        /// 样品培养记录
        /// </summary>
        /// <param name="pclsCache"></param>
        /// <param name="TestId"></param>
        /// <param name="TubeNo"></param>
        /// <param name="CultureId"></param>
        /// <param name="BacterId"></param>
        /// <param name="OtherRea"></param>
        /// <param name="IncubatorId"></param>
        /// <param name="StartTime"></param>
        /// <param name="EndTime"></param>
        /// <param name="AnalResult"></param>
        /// <returns></returns>
        public int ResIncubatorSetData(DataConnection pclsCache, string TestId, string TubeNo, string CultureId, string BacterId, string OtherRea, string IncubatorId, string StartTime, string EndTime, string AnalResult)
        {
            int Result = -2;
            try
            {
                if (!pclsCache.Connect())
                {
                    return Result;
                }
                Result = Convert.ToInt32(Rs.ResIncubator.SetData(pclsCache.CacheConnectionObject, TestId, TubeNo, CultureId, BacterId, OtherRea, IncubatorId, StartTime, EndTime, AnalResult));
                return Result;
            }
            catch (Exception ex)
            {
                HygeiaComUtility.WriteClientLog(HygeiaEnum.LogType.ErrorLog, "ResultMethod.ResIncubatorSetData", "数据库操作异常！ error information : " + ex.Message + Environment.NewLine + ex.StackTrace);
                return Result;
            }
            finally
            {
                pclsCache.DisConnect();
            }
        }
    }
}
