using System.Collections.Generic;
using System.Linq;
using AgGateway.ADAPT.ApplicationDataModel.Common;
using AgGateway.ADAPT.ISOv4Plugin.Models;
using NUnit.Framework;

namespace AcceptanceTests.Asserts.Import
{
    public class TimeScopeAssert
    {
        public static void AreEqual(List<TIM> tims, IEnumerable<TimeScope> timescopes)
        {
            var timescopeList = timescopes.ToList();

            for (int i = 0; i < tims.Count; i++)
            {
                Assert.AreEqual(tims[i].A, timescopeList[i].Stamp1.TimeStamp);
                Assert.AreEqual(DateContextEnum.ActualStart, timescopeList[i].Stamp1.DateContext);
                Assert.AreEqual(tims[i].B, timescopeList[i].Stamp2.TimeStamp);
                Assert.AreEqual(DateContextEnum.ActualEnd, timescopeList[i].Stamp2.DateContext);
            }
        }
    }
}