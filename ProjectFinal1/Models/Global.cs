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
        static DbContext db = new DbContext("name=MEN_FASHIONSEntities");
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

        /// <summary>
        /// GetPRODUCT By LOAISP
        /// </summary>
        /// <param name="ID_L"></param>
        /// <returns></returns>
        public static List<PRODUCT> GetPRODUCTByLOAISP(int ID_L)
        {
            List<PRODUCT> pr = new List<PRODUCT>();
            DbContext db = new DbContext("name=MEN_FASHIONSEntities");
           
            // get data
            pr = db.Set<PRODUCT>().Where(x=>x.ID_L==ID_L).OrderByDescending(z=>z.DATE_SUB).ToList<PRODUCT>();
            return pr;
        }
        /// <summary>
        /// GetPRODUCT By BRANs
        /// </summary>
        /// <param name="ID_BR"></param>
        /// <returns></returns>
        public static List<PRODUCT> GetPRODUCTByBRANs( string ID_BR)
        {
            List<PRODUCT> pr = new List<PRODUCT>();
            DbContext db = new DbContext("name=MEN_FASHIONSEntities");

            // get data
            pr = db.Set<PRODUCT>().Where(x => x.ID_BR == ID_BR).OrderByDescending(z => z.DATE_SUB).ToList<PRODUCT>();
            return pr;
        }
        public static PRODUCT GetPRODUCTByID(string ID_PR)
        {
            return db.Set<PRODUCT>().Find(ID_PR);
        }

        /// <summary>
        /// get name product by id-pr
        /// </summary>
        /// <param name="ID_PR"></param>
        /// <returns></returns>
        public static String GetNameOfProductbyID(string ID_PR)
        {
            return db.Set<PRODUCT>().Find(ID_PR).NAME_PR;
        }

        /// <summary>
        /// get img by id_pr
        /// </summary>
        /// <param name="ID_PR"></param>
        /// <returns></returns>
        public static String GetImageOfProductbyID(string ID_PR)
        {
            return db.Set<PRODUCT>().Find(ID_PR).IMG;
        }
    }
}