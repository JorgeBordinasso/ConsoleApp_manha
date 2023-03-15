using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_manha
{
    public class Cliente
    {
        private int Id;
        private string Nome;
        private string Telefone;
        private Endereco Endereco;


        public Cliente(int id, string nome, string telefone, Endereco endereco)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
        }


        public void setEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }

        public Endereco getEndereco() 
        {  
            return Endereco; 
        }

        public int getId()
        {
            return Id;
        }
        public String getTelefone()
        {
            return Telefone;
        }
        public string getNome()
        {
            return Nome;
        }
        public void setId(int id)
        {
            Id = id;

        }
        public void setTelefone(String telefone)
        {
            Telefone = telefone;
        }
        public void setNome(String nome)
        {
            Nome = nome;
        }

    }
}
