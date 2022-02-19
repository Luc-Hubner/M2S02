using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace ex8
{
    class ex8
    {
        static void Main(string[] args)
        {
            string path = @"F:\Arquivos Lucs\Code\Curso DEVinHouse\Modulo 2\M2S02\ex8\notas.json";
            string jsonText = File.ReadAllText(path);
            dynamic json = JsonConvert.DeserializeObject(jsonText);

            List<estudante> listaEstudante = JsonConvert.DeserializeObject<List<estudante>>(json.Estudantes.ToString());

            var listaEstudanteMenos5 = listaEstudante.Where(e => e.Nota < 5);

            foreach (var item in listaEstudanteMenos5)
            {
                Console.WriteLine(item.Nome);
            }

            /*
            for (int i = 0; i < json.Estudantes.Count; i++)
            {
                var nota = json.Estudantes[i].Nota;
                if(nota < 5)
                {
                    Console.WriteLine(json.Estudantes[i].Nome);
                }
            }*/
            
        }
    }
}
