using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_manha
{
    public class Pessoa
    {
        private int Id;
        private string Telefone;

        public Pessoa(int id, string telefone)
        {
            Id = id;
            Telefone = telefone;
        }

        public int getId()
        {
            return Id;
        }
        public String getTelefone()
        {
            return Telefone;
        }
        public void setId(int id)
        {
            Id = id;

        }
        public void setTelefone(String telefone)
        {
            Telefone = telefone;

        }

    }
}
