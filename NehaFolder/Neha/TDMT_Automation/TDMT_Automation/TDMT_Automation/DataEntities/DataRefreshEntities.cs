using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDMT_Automation
{
    public class DataRefreshEntities
    {
        public static string application;
        public static string region;
        public static string src_env;
        public static string dest_env;
        public static string item;
        public static string ccn;
        public DataRefreshEntities(DataRow dr)
        {
            if (dr == null)
                return;

            if (dr["application"] != null && !string.IsNullOrEmpty(dr["application"].ToString()))
                application = dr["application"].ToString().Trim(' ');

            if (dr["region"] != null && !string.IsNullOrEmpty(dr["region"].ToString()))
               region = dr["region"].ToString().Trim(' ');

            if (dr["src_env"] != null && !string.IsNullOrEmpty(dr["src_env"].ToString()))
                src_env = dr["src_env"].ToString().Trim(' ');

            if (dr["dest_env"] != null && !string.IsNullOrEmpty(dr["dest_env"].ToString()))
                dest_env = dr["dest_env"].ToString().Trim(' ');

            if (dr["item"] != null && !string.IsNullOrEmpty(dr["item"].ToString()))
                item = dr["item"].ToString().Trim(' ');

            if (dr["ccn"] != null && !string.IsNullOrEmpty(dr["ccn"].ToString()))
                ccn = dr["ccn"].ToString().Trim(' ');
        }
    }
}
