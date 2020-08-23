using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Git.Models
{
    public class Teste
    {
        public string[] Lista()
        {
            List<string> listagem = new List<string>();
            listagem.Add("João Carlos");
            listagem.Add("Marta Olmedo");
            listagem.Add("Lucas Olmedo");
            string[] s = new string[3];
            int i = 0;
            listagem.ForEach(p => {
                s[i] = p;
                i++;
            });
            return s;
        }
    }
}