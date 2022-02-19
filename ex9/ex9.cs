using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace ex9
{
    class ex9
    {
        static void Main(string[] args)
        {
            string path = @"F:\Arquivos Lucs\Code\Curso DEVinHouse\Modulo 2\M2S02\ex9\notas.json";
            string jsonText = File.ReadAllText(path);
            dynamic json = JsonConvert.DeserializeObject(jsonText);

            var reprovados = new List<string>();

            for (int i = 0; i < json.Estudantes.Count; i++)
            {
                if (json.Estudantes[i].Nota < 5)
                {
                    reprovados.Add(json.Estudantes[i].Nome.ToString());
                }
            }

            string jsonNew = JsonConvert.SerializeObject(reprovados);

            string pathNewFile = @"F:\Arquivos Lucs\Code\Curso DEVinHouse\Modulo 2\M2S02\ex9\reprovados.json";
            if (!File.Exists(pathNewFile))
            {
                using (StreamWriter sw = File.CreateText(pathNewFile))
                {
                    sw.WriteLine(jsonNew);
                }
            }
        }
    }
}
