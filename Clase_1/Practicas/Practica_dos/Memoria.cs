using System;
using System Newtonsoft.Json.Ling;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace PracticaDos
{
    class memoria
    {

        public void GuardarMemoria()
        {

            string location = "../../../db.json";
            StreamReader reader = new StreamReader(location);
            var dbJSON = reader.ReadToEnd();
            var dbObject = JObject.Parse(dbJSON);
            //var result = dbObjetct.ToString();
            //var result= dbObject["arreglo"].ToString();
            //var result= dbObject["arreglo"][0].ToString();
            // Lectura de JsON iterable
            foreach(var item in dbObject)
            {
                Console.WriteLine("Dato en memoria:");
                Console.WriteLine(item.ToString());
            }
        }        
    }
}
