
🚀 MEU PROJETO: ESTACIONAMENTO INTELIGENTE EM C#
🎯 DOMINE O .NET: SEU PRIMEIRO GRANDE PROJETO!
E aí, galera! Que bom ter vocês por aqui. Eu sou o Paulo Barros e tô super animado pra mostrar pra vocês o Estacionamento Inteligente, um sistema que eu desenvolvi pra mudar a forma como a gente gerencia veículos. Usei C# e o poder do .NET 9.0 pra criar isso, e tô orgulhoso de dizer que ele é o resultado de tudo que aprendi na trilha de fundamentos da DIO. Vocês vão ver como a teoria vira realidade na prática!

💡 O DESAFIO: UM CENÁRIO REAL
Imagina só: fui contratado como desenvolvedor pra modernizar um estacionamento. Minha missão era criar um sistema que não só gerenciasse a entrada e saída dos veículos, mas que também calculasse o valor certinho a ser cobrado e mantivesse um controle impecável das vagas. Pra mim, isso foi um laboratório perfeito pra aplicar os conceitos de programação orientada a objetos de um jeito prático e super eficaz!

✨ FUNCIONALIDADES ROBUSTAS
Meu sistema foi construído em torno da classe principal, a Estacionamento, que é quem orquestra todas as operações importantes:

ESTRUTURA DA CLASSE Estacionamento
Propriedade	Tipo	Descrição Detalhada
precoInicial	decimal	É o valor fixo que a gente cobra assim que o veículo entra, sem importar o tempo.
precoPorHora	decimal	O custo a mais por cada hora (ou fração) que o carro fica estacionado.
veiculos	List<string>	Uma lista dinâmica que guarda as placas dos carros que tão lá no estacionamento agora.

Exportar para as Planilhas
Ah, e também consigo exportar tudo pra planilhas!

MÉTODOS ESSENCIAIS:
AdicionarVeiculo():
Super simples e direto! Peço a placa do veículo pro usuário e já registro na nossa lista de carros estacionados.
RemoverVeiculo():
Aqui entra a inteligência! Primeiro, peço a placa do veículo pra remover.
Verifico na hora se o carro realmente tá estacionado.
Se encontro, pergunto quantas horas ele ficou.
Calculo o valor total a pagar usando a fórmula: precoInicial + (precoPorHora * horas).
Mostro o valor pro usuário e tiro o veículo da lista.
Se a placa não for encontrada, mostro uma mensagem avisando.
ListarVeiculos():
Uma visão geral rápida! Mostro todas as placas dos veículos que tão no estacionamento.
Se o estacionamento estiver vazio, aparece uma mensagem amigável informando que não tem nenhum carro.
DIAGRAMA DE CLASSES (Estacionamento)
Pra entender a arquitetura limpa e funcional do meu sistema de um jeito visual, olha só esse diagrama de classes:

Snippet de código

classDiagram
    class Estacionamento {
        -decimal precoInicial
        -decimal precoPorHora
        -List<string> veiculos
        +Estacionamento(precoInicial: decimal, precoPorHora: decimal)
        +void AdicionarVeiculo()
        +void RemoverVeiculo()
        +void ListarVeiculos()
    }
🚀 COMECE AGORA: PASSO A PASSO!
Quer colocar a mão na massa e ver o Estacionamento Inteligente funcionando? É só seguir esses passos bem simples:

CLONE O REPOSITÓRIO pra sua máquina:
Bash

git clone git@github.com:PauloBarros3335/trilha-net-fundamentos-desafio.git
NAVEGUE ATÉ O DIRETÓRIO DO PROJETO no seu terminal (Git Bash ou PowerShell, por exemplo):
Bash

cd trilha-net-fundamentos-desafio/DesafioFundamentos
RESTAURE AS DEPENDÊNCIAS (pra garantir que tudo esteja pronto pra rodar):
Bash

dotnet restore
EXECUTE A APLICAÇÃO e veja a mágica acontecer:
Bash

dotnet run
MENU DE INTERAÇÃO:
Quando você iniciar, vai ver um menu super fácil de usar:

Digite a sua opção:
1 - Cadastrar veículo
2 - Remover veículo
3 - Listar veículos
4 - Encerrar
Experimente todas as opções pra simular o dia a dia de um estacionamento de um jeito bem realista e interativo!

🛠️ TECNOLOGIAS DE PONTA
Construí esse projeto usando as seguintes ferramentas e tecnologias modernas:

C#: A linguagem poderosa por trás de toda a lógica.
.NET 9.0: O framework mais recente e robusto da Microsoft, que garante performance e escalabilidade.
Git: Pra ter um controle de versão impecável e organizar bem o código.
GitHub: A plataforma que usei pra hospedar e colaborar no projeto.
🤝 PARTICIPE: SUA CONTRIBUIÇÃO IMPORTA!
Esse é um projeto que tá sempre evoluindo! Fiquem à vontade pra:

Explorar o código a fundo.
Sugerir novas funcionalidades pra levar o estacionamento pro próximo nível.
Reportar bugs, pra gente manter a qualidade lá em cima.
A colaboração de vocês é fundamental pra deixar esse Estacionamento Inteligente ainda mais completo e eficiente!

🧑‍💻 SOBRE O AUTOR
Desenvolvido com muita paixão e expertise por:

Paulo Barros - GitHub @PauloBarros3335
