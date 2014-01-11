using System;
using System.IO;
using System.Data;

namespace Framework
{
    /// <summary>
    /// Contiene los métodos necesarios para conversiones entre tipos de datos.
    /// </summary>
    public class Utils
    {
        /// <summary>
        /// Crea una nueva instancia de ValueHelper.
        /// </summary>
        public Utils()
        {
        }

        /// <summary>
        /// Convierte en entero el valor pasado como argumento, en caso de que el cast no sea posible, devuelve el valor 
        /// marcado como default.
        /// </summary>
        /// <param name="test">Objeto que se va a convertir a entero.</param>
        /// <param name="defaultValue">Valor por default en caso de que la conversión no pueda ser realizada.</param>
        /// <returns>Entero obtenido por la operación.</returns>
        public static int IsNull(object test, int defaultValue)
        {
            if (test != null && test != System.DBNull.Value)
            {
                try
                {
                    return int.Parse(test.ToString());
                }
                catch
                {
                    return defaultValue;
                }
            }
            else
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// Convierte en cadena de caracteres el objeto especificado.
        /// </summary>
        /// <param name="test">Objeto que se va a convertir a string.</param>
        /// <param name="defaultValue">Valor por default en caso de que la conversión no sea válida.</param>
        /// <returns>String con el resultado de la conversión.</returns>
        public static string IsNull(object test, string defaultValue)
        {
            if (test != null && test != System.DBNull.Value)
            {
                return test.ToString().Trim();
            }
            else
            {
                return defaultValue;
            }
        }

        public static DateTime IsNull(object test, DateTime defaultValue)
        {
            if (test != null && test != System.DBNull.Value)
            {
                try
                {
                    return DateTime.Parse(test.ToString());
                }
                catch
                {
                    return defaultValue;
                }
            }
            else
            {
                return defaultValue;
            }
        }

        public static double IsNull(object test, double defaultValue)
        {
            if (test != null && test != System.DBNull.Value)
            {
                try
                {
                    return double.Parse(test.ToString());
                }
                catch
                {
                    return defaultValue;
                }
            }
            else
            {
                return defaultValue;
            }
        }

        public static float IsNull(object test, float defaultValue)
        {
            if (test != null && test != System.DBNull.Value)
            {
                try
                {
                    return float.Parse(test.ToString());
                }
                catch
                {
                    return defaultValue;
                }
            }
            else
            {
                return defaultValue;
            }
        }

        public static decimal IsNull(object test, decimal defaultValue)
        {
            if (test != null && test != System.DBNull.Value)
            {
                try
                {
                    return decimal.Parse(test.ToString());
                }
                catch
                {
                    return defaultValue;
                }
            }
            else
            {
                return defaultValue;
            }
        }

        public static bool IsNull(object test, bool defaultValue)
        {
            if (test != null && test != System.DBNull.Value)
            {
                try
                {
                    return bool.Parse(test.ToString());
                }
                catch
                {
                    return defaultValue;
                }
            }
            else
            {
                return defaultValue;
            }
        }

        /*
        public static string GetExecutionPath()
        {
            string path = "";
            if (System.Web.HttpContext.Current != null)
            {
                //path = System.Web.HttpContext.Current.Server.MapPath("");
                path = System.Web.HttpContext.Current.Request.PhysicalApplicationPath;
            }
            else
            {
                path = Environment.CurrentDirectory;
            }

            path = path.ToLower().Replace("\\debug", "");
            path = path.ToLower().Replace("\\bin", "");

            if (!path.EndsWith("\\"))
            {
                path += "\\";
            }
            return path;
        }

        public static byte[] ConvertFileToByteArray(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            BinaryReader bin = new BinaryReader(fs);
            byte[] b = bin.ReadBytes((int)fs.Length);
            bin.Close();
            fs.Close();
            return b;
        }

        public static bool Uninstall(string[] args)
        {
            bool exit = false;
            if (args != null)
            {
                foreach (string s in args)
                {
                    string []key = s.Split('=');
                    if (key.Length == 2)
                    {
                        if (key[0].ToLower() == "/u")
                        {
                            exit = true;
                            string guid = key[1];
                            string path = Environment.GetFolderPath(Environment.SpecialFolder.System);
                            System.Diagnostics.ProcessStartInfo si = new System.Diagnostics.ProcessStartInfo(string.Format("{0}\\msiexec.exe", path),
                                string.Format("/x {0}", guid));
                            System.Diagnostics.Process.Start(si);
                        }
                    }
                }
            }
            return exit;
        }
        */
        public static int GetDataRowValue(DataRow dr, string columnName, int defaultValue)
        {
            if (dr != null)
            {
                if (dr.Table.Columns.Contains(columnName))
                {
                    return Utils.IsNull(dr[columnName], defaultValue);
                }
            }
            return defaultValue;
        }

        public static bool GetDataRowValue(DataRow dr, string columnName, bool defaultValue)
        {
            if (dr != null)
            {
                if (dr.Table.Columns.Contains(columnName))
                {
                    return Utils.IsNull(dr[columnName], defaultValue);
                }
            }
            return defaultValue;
        }

        public static string GetDataRowValue(DataRow dr, string columnName, string defaultValue)
        {
            if (dr != null)
            {
                if (dr.Table.Columns.Contains(columnName))
                {
                    return Utils.IsNull(dr[columnName], defaultValue);
                }
            }
            return defaultValue;
        }

        public static float GetDataRowValue(DataRow dr, string columnName, float defaultValue)
        {
            if (dr != null)
            {
                if (dr.Table.Columns.Contains(columnName))
                {
                    return Utils.IsNull(dr[columnName], defaultValue);
                }
            }
            return defaultValue;
        }

        public static DateTime GetDataRowValue(DataRow dr, string columnName, DateTime defaultValue)
        {
            if (dr != null)
            {
                if (dr.Table.Columns.Contains(columnName))
                {
                    return Utils.IsNull(dr[columnName], defaultValue);
                }
            }
            return defaultValue;
        }

        public static double GetDataRowValue(DataRow dr, string columnName, double defaultValue)
        {
            if (dr != null)
            {
                if (dr.Table.Columns.Contains(columnName))
                {
                    return Utils.IsNull(dr[columnName], defaultValue);
                }
            }
            return defaultValue;
        }

        public static decimal GetDataRowValue(DataRow dr, string columnName, decimal defaultValue)
        {
            if (dr != null)
            {
                if (dr.Table.Columns.Contains(columnName))
                {
                    return Utils.IsNull(dr[columnName], defaultValue);
                }
            }
            return defaultValue;
        }

        public static Guid GetDataRowValue(DataRow dr, string columnName, Guid defaultValue)
        {
            if (dr != null)
            {
                if (dr.Table.Columns.Contains(columnName))
                {
                    if (dr[columnName] != null && dr[columnName] != DBNull.Value)
                    {
                        return (Guid)dr[columnName];
                    }
                }
            }
            return defaultValue;
        }

        public static Guid IsNull(object test, Guid defaultValue)
        {
            if (test != null && test != System.DBNull.Value)
            {
                try
                {
                    return (Guid)test;
                }
                catch
                {
                    return defaultValue;
                }
            }
            else
            {
                return defaultValue;
            }
        }
    }
}
