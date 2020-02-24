using Newtonsoft.Json.Linq;
using System;
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
                MemoryData memoriaData = new MemoryData(DateTime.Now, item.Value["operacion"].ToString(), (int) item.Value["resultado"]);
                Console.WriteLine(item.Key.ToString());
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
