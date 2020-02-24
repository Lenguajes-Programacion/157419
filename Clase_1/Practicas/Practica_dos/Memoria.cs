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
            foreach((var key, var item) in dbObject)
            {
                Console.WriteLine("Dato en memoria:");
                MemoryData memoriaData = new MemoryData(DateTime.Now, item["operacion"].ToString(), (int) item["resultado"]);
                Console.WriteLine(key.ToString());
                Console.WriteLine(memoriaData.resultado.ToString());
            }
        }        
    }

    class MemoryData
    {
        DateTime fecha;
        string operacion;
        int resultado;

        public MemoryData(DateTime date, String operation, int result)
        {
            fecha = date;
            operacion = operacion;
            resultado = result;
        }

    }

}
