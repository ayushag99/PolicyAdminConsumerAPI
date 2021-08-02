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
    public class PropertyMasterDataGenerator
    {
        public PropertyMasterDataGenerator( ) { }
        public static void Initialize(ConsumerContext context)
        {
            List<PropertyMaster> propertyMaster = getPropertyMasterData();
            for (int i = 0; i < propertyMaster.Count; i++)
            {
                context.PropertiesMaster.Add(propertyMaster[i]);
            }
            context.SaveChanges();
                
            
        }
            private static List<PropertyMaster> getPropertyMasterData()
        {
            return new List<PropertyMaster>() {
                new PropertyMaster { 
                    Id=1, 
                    PropertyType=PropertyType.Building, 
                    MinimumCostOfAsset=10000000, 
                    MaximumCostOfAsset=999999999, 
                    MinimumArea=1000, 
                    MaximumArea=99999999, 
                    PropertyAgeMin=2, 
                    PropertyAgeMax=100, 
                    EstimatedLife =50},

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