using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace RETSYS
{

    public class Acesso_FB
    {
        public static int tentativaLogin { set; get; }
        public static string usuario_logado { set; get; }

        internal FbConnection getConexao()
        {
            string str_conn = $"Server=localhost;User=RETDBA;Password=masterkey;Database={System.AppDomain.CurrentDomain.BaseDirectory.ToString()}\\data\\RETSYS.FDB";
            FbConnection conn = new FbConnection(str_conn);
            return conn;
        }

        public DataTable fb_GetDados(string cmd_sql)
        {
            using (FbConnection conn = getConexao()) 
            {
                try
                {
                    conn.Open();
                    FbCommand fb_cmd = new FbCommand(cmd_sql, conn);
                    FbDataAdapter fb_dapt = new FbDataAdapter(fb_cmd);
                    DataTable dt = new DataTable();
                    fb_dapt.Fill(dt);
                    return dt;
                }
                catch(FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conn.Close();
                }

            } 
        }        

      public void exe_CRUD(string cmd_sql)
      {
            using (FbConnection conn = getConexao())
            {
                try
                {
                    conn.Open();
                    FbCommand fb_cmd = new FbCommand(cmd_sql, conn);
                    fb_cmd.ExecuteNonQuery();
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    conn.Close();
                }
            }

      }

        public string fb_Get_Info_Dtr(string cmd_sql, string column)
        {
            using (FbConnection conn = getConexao())
            {
                try
                {   
                    FbDataReader fdr = null;
                    FbCommand fb_cmd = new FbCommand(cmd_sql, conn);
                    conn.Open();
                    fdr = fb_cmd.ExecuteReader();
                    string info;
                    while (fdr.Read())
                    {
                        return info = fdr[$"{column}".ToUpper()].ToString();

                    }
                    return info = null;
                }
                catch (FbException fbex)
                {
                    throw fbex;

                }
                finally
                {
                    conn.Close();
                    
                }
            }
        }


    }
}          
        
         

     

