// See https://aka.ms/new-console-template for more information
using ConsoleApp_manha;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

Produto p1 = new Produto(1, "mouse sem fio", 59.90M);
Console.WriteLine( p1.getDescricao() + " " + p1.getValor);
