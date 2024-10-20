using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Millionaire
{
    public class SQLInfo
    {
        public bool UseRemoteServer { get; set; }
        public string rSQL_Server { get; set; }
        public int rSQL_Port { get; set; }
        public string rSQL_Database { get; set; }
        public string rSQL_Login { get; set; }
        public string rSQL_Password { get; set; }
        public bool HideAtStart { get; set; }
    }

    public class SQLSettings
    {
        private string filePath = "sql.xml";
        public static SQLInfo SQLInfo = new SQLInfo();

        public void LoadSettings()
        {
            if (!File.Exists(filePath))
            {
                System.Threading.Thread.Sleep(100);
                SaveDefaultSettings();
            }

            SQLInfo loadedvalues = DeserializeFromXml(filePath);

            if (loadedvalues != null)
            {
                SQLInfo.UseRemoteServer = loadedvalues.UseRemoteServer;
                SQLInfo.rSQL_Server = loadedvalues.rSQL_Server;
                SQLInfo.rSQL_Port = loadedvalues.rSQL_Port;
                SQLInfo.rSQL_Database = loadedvalues.rSQL_Database;
                SQLInfo.rSQL_Login = loadedvalues.rSQL_Login;
                SQLInfo.rSQL_Password = loadedvalues.rSQL_Password;
                SQLInfo.HideAtStart = loadedvalues.HideAtStart;
            }
        }

        //public void SaveSettings()
        //{
        //    if (SQLLogin.radSQLLocal.Checked)
        //    {
        //        SQLInfo.UseRemoteServer = false;
        //    }
        //    else if (SQLLogin.radSQLRemote.Checked)
        //    {
        //        SQLInfo.UseRemoteServer = true;
        //    }

        //    SQLInfo.rSQL_Server = SQLLogin.txtSQLR_ServerInstance.Text;
        //    SQLInfo.rSQL_Port = (int)SQLLogin.txtSQLR_Port.Value;
        //    SQLInfo.rSQL_Database = SQLLogin.txtSQLR_Database.Text;
        //    SQLInfo.rSQL_Login = SQLLogin.txtSQLR_Username.Text;
        //    SQLInfo.rSQL_Password = SQLLogin.txtSQLR_Password.Text;
        //    SQLInfo.HideAtStart = SQLLogin.chkHideAtStart.Checked;

        //    SerializeToXml(SQLInfo, filePath);
        //}

        private void SaveDefaultSettings()
        {
            SQLInfo.UseRemoteServer = false;
            SQLInfo.rSQL_Server = "";
            SQLInfo.rSQL_Port = 1433;
            SQLInfo.rSQL_Database = "";
            SQLInfo.rSQL_Login = "";
            SQLInfo.rSQL_Password = "";
            SQLInfo.HideAtStart = false;

            SerializeToXml(SQLInfo, filePath);
        }

        private void SerializeToXml(SQLInfo settings, string filePath)
        {
            using (XmlTextWriter writer = new XmlTextWriter(filePath, null))
            {
                writer.Formatting = Formatting.Indented;
                XmlSerializer serializer = new XmlSerializer(typeof(SQLInfo));
                serializer.Serialize(writer, settings);
            }
        }

        private SQLInfo DeserializeFromXml(string filePath)
        {
            try
            {
                using (XmlTextReader reader = new XmlTextReader(filePath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(SQLInfo));
                    SQLInfo settings = (SQLInfo)serializer.Deserialize(reader);
                    return settings;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}