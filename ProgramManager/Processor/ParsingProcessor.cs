using ProgramManager.Etc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Processor
{
    class ParsingProcessor : Singleton<ParsingProcessor>
    {
        public void ParserToOBJ(object obj, DataSet ds)
        {
            FieldInfo[] infoArr = obj.GetType().GetFields();
            string colName = string.Empty;
            string value = string.Empty;

            bool goFirst = false;

            for (int i = 0; i < infoArr.Length; ++i)
            {
                goFirst = false;

                for (int t = 0; t < ds.Tables.Count; t++)
                {
                    for (int k = 0; k < ds.Tables[t].Rows.Count; k++)
                    {
                        colName = ds.Tables[t].Columns[k].ColumnName;

                        if (infoArr[i].Name == colName)
                        {
                            value = ds.Tables[t].Rows[k][colName].ToString();

                            FieldInfo info = infoArr[i];
                            info.SetValue(obj, value);

                            goFirst = true;
                            break;
                        }
                    }

                    if (goFirst == true)
                        break;
                }
            }
        }
    }
}
