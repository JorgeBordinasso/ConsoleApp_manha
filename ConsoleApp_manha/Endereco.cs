using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_manha
{
    public class Endereco
    {
        public string Rua;
        public string Numero;
        public string CEP;
        public string Bairro;
        public string Cidade;
        public string Estado;

        public Endereco(string rua, string numero, string cep, string bairro, string cidade, string estado) {
            Rua = rua;
            Numero = numero;
            CEP = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

        public string EnderecoCompleto()
        {
            return Rua + " " + Numero + " " + Bairro + " " + Cidade + " " + Estado;
        }

        public string EnderecoCurto()
        {
            return Rua + " " + Numero;
        }



        public void setRua(string rua) 
        {  
            Rua = rua; 
        }
        public string getRua() 
        { 
            return Rua;
        }

        public void setNumero(string numero) 
        {
            Numero = numero;
        }

        public string getNumero()
        {
            return Numero;
        }
        
        public void setCep(string cep)
        {
            CEP = cep;
        }

        public string getCep()
        {
            return CEP;
        }

        public void setBairro(string bairro)
        {
            Bairro = bairro;
        }

        public string getBairro()
        {
            return Bairro;
        }

        public void setCidade(string cidade)
        {
            Cidade = cidade;
        }

        public string getCidade()
        {
            return Cidade;
        }
         
        public void setEstado(string estado)
        {
            Estado = estado;
        }

        public string getEstado()
        {
            return Estado;
        }
    }
}
