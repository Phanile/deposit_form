using deposit_app.DataBase;
using deposit_app.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace deposit_app.Services
{
    internal class XmlService
    {
        private void AddClientFromXML_btn_Click(object sender, EventArgs e)
        {
            string? path;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK || !string.IsNullOrWhiteSpace(openFileDialog.FileName))
            {
                path = openFileDialog.FileName;

                List<Client> clients = DeserializeFromXml(path);
                if (clients.Count != 0)
                {
                    foreach (Client client in clients)
                    {
                        Db.AddClient(client);
                        //ValidationEventHandler eventHandler = new ValidationEventHandler(ValidationEventHandler);
                        //document.Validate(eventHandler);
                    }
                }
            }
        }

        private static List<Client> DeserializeFromXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Client>), new XmlRootAttribute("Clients"));
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                return (List<Client>)serializer.Deserialize(fileStream);
            }
        }

        public static void ValidationHandler(object sender, ValidationEventArgs args)
        {
            Console.WriteLine("***Validation error");
            Console.WriteLine("\tSeverity:{0}", args.Severity);
            Console.WriteLine("\tMessage  :{0}", args.Message);
        }
    }
}
