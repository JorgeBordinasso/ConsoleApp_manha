// See https://aka.ms/new-console-template for more information
using ConsoleApp_manha;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

Produto p1 = new Produto(1, "mouse sem fio", 59.90M);
Console.WriteLine( p1.getDescricao() + " " + p1.getValor());

p1.setValor(69.90M);
p1.setDescricao("mouser gamer Razor");
Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

Endereco e1 = new Endereco(
    "Franciso Alguelli",
    "218",
    "15904136",
    "Laranjeiras",
    "Taquaritinga",
    "SP");

Cliente c1 = new Cliente(1, "Jorge", "16997777947", e1);
Cliente c2 = new Cliente(2, "Pedro", "16997777948", e1);
Cliente c3 = new Cliente(3, "Otavio", "16997777949", e1);
Cliente c4 = new Cliente(4, "Olicio", "16997777950", e1 );

Console.WriteLine(c1.getEndereco().getRua());
c1.getEndereco().setRua("Prudente de Moraes");

Carros car = new Carros();
car.Marca = "VW";
car.numeroPortas = 4;
car.numeroRodas = 4;
car.cor = "Vermelho";

Aviao aviao = new Aviao();
aviao.portasInternas = 50;
aviao.numeroPortas = 1;
aviao.numeroRodas = 3;
aviao.cor = "Branco";
aviao.quantidadeAcento = 500;
aviao.PagaImposto = false;

Bike bicicleta = new Bike();
bicicleta.PagaImposto=false;

Console.WriteLine(c1.getEndereco().EnderecoCompleto());

Console.WriteLine(aviao.ExibirDados());
Console.WriteLine(car.ExibirDados());

List<Veiculos> listaVeiculos = new List<Veiculos>();
listaVeiculos.Add(aviao);
listaVeiculos.Add(car);
listaVeiculos.Add(bicicleta);

List<Cliente> listaCliente = new List<Cliente>();
listaCliente.Add(c1);
listaCliente.Add(c2);
listaCliente.Add(c3);
listaCliente.Add(c4);

foreach (var item in listaCliente)
{
    Console.WriteLine(item.getNome());
}