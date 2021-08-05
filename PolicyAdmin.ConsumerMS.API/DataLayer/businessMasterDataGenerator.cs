using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PolicyAdmin.ConsumerMS.API.Data;
using PolicyAdmin.ConsumerMS.API.Models;
using PolicyAdmin.ConsumerMS.API.Models.DAO;
using PolicyAdmin.ConsumerMS.API.Models.Enum;

namespace PolicyAdmin.ConsumerMS.API.DataLayer
{
    public class businessMasterDataGenerator
    {
        public businessMasterDataGenerator( ) { }
        public static void Initialize(ConsumerContext context)
        {
            List<BusinessMaster> businessMaster = getBusinessMasterData();
            for (int i = 0; i < businessMaster.Count; i++)
            {
                context.BusinessesMaster.Add(businessMaster[i]);
            }
            context.SaveChanges();
                
            
        }
            private static List<BusinessMaster> getBusinessMasterData()
        {
            return new List<BusinessMaster>() {
                new BusinessMaster { Id=1, BusinessType=BusinessType.SoleProprietorship, MinimumAnnualTurnOver=1200000, MinimumCapitalInvested=2000000, MinimumBusinessAgeInYears=2, MinimumTotalEmployees=10},
                new BusinessMaster { Id=2, BusinessType=BusinessType.Partnership, MinimumAnnualTurnOver=1200000, MinimumCapitalInvested=2000000, MinimumBusinessAgeInYears=2, MinimumTotalEmployees=10},
                new BusinessMaster { Id=3, BusinessType=BusinessType.LimitedPartnership, MinimumAnnualTurnOver=1200000, MinimumCapitalInvested=2000000, MinimumBusinessAgeInYears=2, MinimumTotalEmployees=10},
                new BusinessMaster { Id=4, BusinessType=BusinessType.LimitedLiabilityCompany, MinimumAnnualTurnOver=1200000, MinimumCapitalInvested=2000000, MinimumBusinessAgeInYears=2, MinimumTotalEmployees=10},
                new BusinessMaster { Id=5, BusinessType=BusinessType.Corporation,  MinimumAnnualTurnOver=1200000, MinimumCapitalInvested=2000000, MinimumBusinessAgeInYears=2, MinimumTotalEmployees=10},
                new BusinessMaster { Id=6, BusinessType=BusinessType.NonProfit, MinimumAnnualTurnOver=1200000, MinimumCapitalInvested=2000000, MinimumBusinessAgeInYears=2, MinimumTotalEmployees=10},
                new BusinessMaster { Id=7, BusinessType=BusinessType.Cooperative, MinimumAnnualTurnOver=1200000, MinimumCapitalInvested=2000000, MinimumBusinessAgeInYears=2, MinimumTotalEmployees=10},

            };
        }
    }

}



// Generate Random Values Python Script

//propertyType = {
//    0:"PropertyType.Building",
//    1:"PropertyType.Equipment",
//    2:"PropertyType.Singage",
//    3:"PropertyType.Inventory",
//    4:"PropertyType.Furniture"
//}
//a = []
//b = []
//for i in range(200):
//    pvrf = random.randint(0, 8)
//    pvrt = random.randint(pvrf, 8)
//    bvrf = random.randint(0, 8)
//    bvrt = random.randint(pvrf, 8)
//    pt = random.randint(0, 4)
//    quote = random.randint(100, 9999) * 100


//    a.append("new QuoteMaster {{ Id={0},PropertyValueRangeFrom={1}, PropertyValueRangeTo={2}, BusinesssValueRangeFrom={3}, BusinesssValueRangeTo={4}, PropertyType={5}, Quote={6} }}".format(i + 1, pvrf, pvrt, bvrf, bvrt, propertyType[pt], quote))
//    b.append("({},{},{},{},{},{})".format(pvrf, pvrt, bvrf, bvrt, pt, quote))

//print(*a, sep = ",\n")
//print(*b, sep = ",\n")