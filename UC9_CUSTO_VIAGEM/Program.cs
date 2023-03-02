// Criando Variavel
Double valorabastecido, kmrodado, valorlitro, consumo;

// Inicialiando as varivaveis
valorabastecido = 0;
kmrodado = 0;
valorlitro = 0;
consumo = 0;

Console.WriteLine("Qual o valor pago pelo abastecimento?");
valorabastecido = double.Parse(Console.ReadLine());

Console.WriteLine("Quantos Kms você percorreu com este abastecimento?");
kmrodado = double.Parse(Console.ReadLine());

Console.WriteLine("Qual o valor do litro?");
valorlitro = double.Parse(Console.ReadLine());

consumo = kmrodado / (valorabastecido / valorlitro);

Console.WriteLine("O consumo do seu veiculo é (KM / l): " + consumo);