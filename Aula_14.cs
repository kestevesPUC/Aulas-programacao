
using System.Transactions;

using System;
using System.Runtime.InteropServices;

class Aula_14
{

    static void Main(string[] args)
    { 

        /**
            Regras:
                1- Porta false, iniciar = false
                2- Porta true, comidaInserida = false
                3- Porta true
                4- Iniciar false, porta false, comidaInserida true
                5- Iniciar true
        */

        bool portaAberta    = false;
        bool comidaInserida = false;
        bool iniciado       = false;
        bool controle       = true;

        while (controle)
        {
            Console.WriteLine("1- Abrir porta");
            Console.WriteLine("2- Colocar comida");
            Console.WriteLine("3- Fechar porta");
            Console.WriteLine("4- Iniciar");
            Console.WriteLine("5- Pausar");
            Console.WriteLine("6- Sair");
            
            int opicao = int.Parse(Console.ReadLine());
            
            switch (opicao)
            {
                case 1:
                    if (portaAberta == false && iniciado == false)
                    {
                        System.Console.WriteLine("A porta foi aberta.");
                        portaAberta = true;
                        
                    } else
                    {
                        if(portaAberta == false)
                        {
                            System.Console.WriteLine("Pause o microondas para prosseguir.");
                        } else
                        {
                            System.Console.WriteLine("Feche a porta para prosseguir.");
                        }
                    }
                break;
                case 2:
                    if(portaAberta == true && comidaInserida == false)
                    {
                        System.Console.WriteLine("Comida inserida no microondas.");
                        comidaInserida = true;
                    } else
                    {
                        if(portaAberta == false)
                        {
                            System.Console.WriteLine("Favor abrir a porta do microondas.");
                        } else
                        {
                            System.Console.WriteLine("A comida já estava inserida no microondas.");
                        }
                    }
                break;
                case 3:
                    if (portaAberta == true)
                    {
                        System.Console.WriteLine("A porta foi fechada");
                        portaAberta = false;
                    } else
                    {
                        System.Console.WriteLine("A porta já estava aberta");
                    }
                break;
                case 4:
                    if (portaAberta == false && comidaInserida == true && iniciado == false)
                    {
                        System.Console.WriteLine("Microondas iniciado.");
                        iniciado = true;
                    } else
                    {
                        if (portaAberta == true)
                        {
                            System.Console.WriteLine("Não foi possível iniciar porque a porta está aberta.");
                        } else if (comidaInserida == false)
                        {
                            System.Console.WriteLine("Você não inseriu a comida.");
                        } else
                        {
                            System.Console.WriteLine("O microondas já estava iniciado.");
                        }
                    }
                break;
                case 5:
                    if (iniciado == true)
                    {
                        System.Console.WriteLine("Microondas pausado");
                        iniciado = false;
                    } else
                    {
                        System.Console.WriteLine("O microondas não foi pausado porque não foi iniciado.");
                    }
                break;

                default:
                    System.Console.WriteLine("Microondas desconectado.");
                    controle = false;
                    break;
            }


            
        }

        
        
        
        
        
        System.Console.WriteLine();
        System.Console.WriteLine();
        System.Console.WriteLine();
        System.Console.WriteLine("Até logo");
        
        
        
        


        


    }
}
