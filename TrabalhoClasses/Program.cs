
using TrabalhoClasses.Models;

string repetir = "sim";
string aux;
int decisao, config, valor, dec;

while (repetir == "sim" || repetir == "s")
{
    while (true) {
        Console.Write("\nQual Dispositivo deseja inserir?\n1 - Televisão\n2 - Celular\n");
        try
        {
            aux = Console.ReadLine();
            decisao = int.Parse(aux);
            if(decisao == 1 || decisao == 2)
            {
                break;
            }
            else
            {
                throw new Exception("\nValor inválido! Digite 1 ou 2");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    switch (decisao)
    {
        // CADASTRO TELEVISÃO
        case 1:
            Televisao tv = new Televisao();
            tv.brilhoMaximo = 100;
            tv.Brilho = 0;
            tv.AlterarModo(0);

            Console.Write("\nVamos Cadastrar algumas informações de sua Televisão!\nDigite a Marca da TV: ");
            tv.Marca = Console.ReadLine()
                              .ToString();

            Console.Write("Digite agora o Modelo da TV: ");
            tv.Modelo = Console.ReadLine()
                              .ToString();


            Console.Write("Digite quantas polegadas a TV possui: ");
            tv.Polegadas = float.Parse(Console.ReadLine());

            Console.WriteLine($"\nA Televisão da {tv.Marca} é do modelo {tv.Modelo} e possui {tv.Polegadas} polegadas!\n");

            while (true)
            {
                Console.WriteLine("\nQual Configuração deseja alterar?\n1 - Brilho\n2 - Modo de Exibição\n0 - Sair");
                aux = Console.ReadLine();
                config = int.Parse(aux);
                
                switch(config)
                {
                    case 1:
                        Console.WriteLine($"\nO Brilho atual da Televisão é: {tv.Brilho}%\nO Brilho Máximo permitido é de {tv.brilhoMaximo}%\n" +
                            $"1 - Aumentar o Brilho\n2 - Diminuir o Brilho");
                        aux = Console.ReadLine();
                        dec = int.Parse(aux);

                        if(dec == 1)
                        {
                            Console.WriteLine("\nDigite quanto de brilho deseja aumentar: ");
                            aux = Console.ReadLine();
                            valor= int.Parse(aux);
                            tv.AumentarBrilho(valor);

                            Console.WriteLine($"\nO Brilho atual da Televisão é: {tv.Brilho}%");
                        } else if(dec == 2)
                        {
                            Console.WriteLine("\nDigite quanto de brilho deseja diminuir: ");
                            aux = Console.ReadLine();
                            valor = int.Parse(aux);
                            tv.DiminuirBrilho(valor);

                            Console.WriteLine($"\nO Brilho atual da Televisão é: {tv.Brilho}%");
                        } else
                        {
                            Console.WriteLine("Opção Inválida! Tente novamente");
                        }

                        break;
                   case 2:
                        Console.WriteLine($"\nO Modo atual da Televisão é {tv.Modo}, Escolha qual modo deseja:\n" +
                            $"0 - Padrão\n1 - Futebol\n2 - Cinema\n3 - Jogo");
                        aux = Console.ReadLine();
                        valor = int.Parse(aux);
                        tv.AlterarModo(valor);

                        Console.WriteLine($"\nO Modo Configurado foi {tv.Modo}");

                        break;
                }
                if (config == 0)
                {
                    break;
                }
            }
            break;

            // CADASTRO CELULAR
        case 2:
            Celular cel = new Celular();
            cel.brilhoMaximo = 50;
            cel.Brilho = 0;
            cel.Bateria = 100;

            Console.Write("\nVamos Cadastrar algumas informações de seu Celular!\nDigite a Marca do Celular: ");
            cel.Marca = Console.ReadLine()
                              .ToString();

            Console.Write("Digite agora o Modelo do Celular: ");
            cel.Modelo = Console.ReadLine()
                              .ToString();

            Console.Write("Digite quantas polegadas o Celular possui: ");
            cel.Polegadas = float.Parse(Console.ReadLine());

            Console.Write("Digite o Sistema Operacional do Celular: ");
            cel.SistemaOperacional = Console.ReadLine()
                                            .ToString();

            Console.WriteLine($"\nO Celular da {cel.Marca}, é do modelo {cel.Modelo}, possui {cel.Polegadas} polegadas " +
                $"e tem {cel.SistemaOperacional} como Sistema Operacional!\n");

            while (true)
            {
                Console.WriteLine("\nDeseja alterar o Brilho?\n1 - Brilho\n0 - Sair");
                aux = Console.ReadLine();
                config = int.Parse(aux);

                if (config == 1)
                {
                    Console.WriteLine($"\nO Brilho atual do Celular é: {cel.Brilho}%\nO Brilho Máximo permitido é de {cel.brilhoMaximo}%\n" +
                                    $"1 - Aumentar o Brilho\n2 - Diminuir o Brilho");
                    aux = Console.ReadLine();
                    dec = int.Parse(aux);
                    if (dec == 1)
                    {
                        Console.WriteLine("\nDigite quanto de brilho deseja aumentar: ");
                        aux = Console.ReadLine();
                        valor = int.Parse(aux);
                        cel.AumentarBrilho(valor);

                        Console.WriteLine($"\nO Brilho atual do celular é: {cel.Brilho}%");
                    }
                    else if (dec == 2)
                    {
                        Console.WriteLine("\nDigite quanto de brilho deseja diminuir: ");
                        aux = Console.ReadLine();
                        valor = int.Parse(aux);
                        cel.DiminuirBrilho(valor);

                        Console.WriteLine($"\nO Brilho atual do celular é: {cel.Brilho}%");
                    }
                    else
                    {
                        Console.WriteLine("Opção Inválida! Tente novamente");
                    }
                }
                else
                {
                    break;
                }
            }

                break;

    }

    Console.Write("\nDeseja executar novamente?\n");
    repetir = Console.ReadLine();
}
