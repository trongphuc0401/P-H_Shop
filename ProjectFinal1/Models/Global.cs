using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ProjectFinal1.Models;
namespace ProjectFinal1.Models
{
    public class Global
    {
        /// <summary>
        /// function to get product 
        /// </summary>
        /// <returns></returns>
        public static List<PRODUCT> GetPRODUCTs()
        {
            List<PRODUCT> pr = new List<PRODUCT>();
            DbContext db = new DbContext("name=MEN_FASHIONSEntities");
            // get data
            pr = db.Set<PRODUCT>().ToList();
            return pr;
        }
        /// <summary>
        /// function to get product type
        /// </summary>
        /// <returns></returns>
        public static List<LOAISP> GetLOAISPs()
        {
            return new DbContext("name=MEN_FASHIONSEntities").Set<LOAISP>().ToList();
        }
        
        public static List<ARTICLE> GetARTICLEs() 
        {
            return new DbContext("name=MEN_FASHIONSEntities").Set<ARTICLE>().ToList();
        }
        public static List<BRAND> GetBRANDs()
        {
            return new DbContext("name=MEN_FASHIONSEntities").Set<BRAND>().ToList();
        }
        public static List<PRODUCT> GetPRODUCTByLOAISP(int ID_L)
        {
            List<PRODUCT> pr = new List<PRODUCT>();
            DbContext db = new DbContext("name=MEN_FASHIONSEntities");
            // get data
            pr = db.Set<PRODUCT>().Where(x=>x.ID_L==ID_L).ToList<PRODUCT>();
            return pr;
        }
    }
}