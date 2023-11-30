﻿using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
{
    List<Advogado> advogados = new List<Advogado>();
    List<Cliente> clientes = new List<Cliente>();

        advogados.Add(new Advogado("Ricardo Teixeira", new DateTime (1990, 5, 15), "12345678901", "CNA123"));
        advogados.Add(new Advogado("Dan Sampaio", new DateTime (1985, 8, 20), "98765432101", "CNA456"));

        clientes.Add(new Cliente("Rita Santos", new DataTime(1988, 4, 21), "02538968518", "solteria", "professora"));
        clientes.Add(new Cliente("Isabela Chaves", new DataTime(1986, 2 ,4), "0151871507", "casada" , "medica" ));

    
        Console.WriteLine("Advogados com idade entre 30 e 40 anos:");
        List<Advogado> advogadosRelatorio1 = AdvogadosEntreIdades(advogados, 30, 40);
        ImprimirAdvogados(advogadosRelatorio1);
    
        Console.WriteLine("\nClientes com idade entre 25 e 35 anos:");
        List<Cliente> clientesRelatorio2 = ClientesEntreIdades(clientes, 25, 35);
        ImprimirClientes(clientesRelatorio2);

        Console.WriteLine("\nClientes solteiros:");
        List<Cliente> clientesRelatorio3 = ClientesPorEstadoCivil(clientes, "Solteiro");
        ImprimirClientes(clientesRelatorio3);

}