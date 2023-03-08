using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_manha
{
    public class Produto
    {
        public int Id;
        public string Descricao;
        public decimal Valor;

        public Produto(int id, string descricao, decimal valor)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
            
        }
        
        public string getId()
        {
            return Descricao;
        }

        public decimal getValor()
        {
            return Valor;
        }
    }
}
