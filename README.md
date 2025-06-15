
🚀 PROJETO DE ESTACIONAMENTO INTELIGENTE EM C#
🎯 DOMINE O .NET: SEU PRIMEIRO GRANDE PROJETO!






Bem-vindo ao Estacionamento Inteligente, um sistema revolucionário que vai transformar a gestão de veículos! Desenvolvido com C# e o poder do .NET 9.0, este projeto é o ápice do que você aprendeu na trilha de fundamentos da DIO. Prepare-se para ver a teoria virar realidade!

💡 O DESAFIO: UM CENÁRIO REAL
Imagine-se como um desenvolvedor contratado para modernizar um estacionamento! Sua missão crítica é construir um sistema que não apenas gerencie a entrada e saída de veículos, mas também calcule o valor exato a ser cobrado e mantenha um controle impecável das vagas. Este é o seu laboratório para aplicar conceitos de programação orientada a objetos de forma prática e eficaz!

✨ FUNCIONALIDADES ROBUSTAS
Nosso sistema é construído em torno da poderosa classe Estacionamento, que orquestra todas as operações essenciais:

ESTRUTURA DA CLASSE Estacionamento
Propriedade	Tipo	Descrição Detalhada
precoInicial	decimal	O valor fixo cobrado no momento da entrada do veículo, independente do tempo de permanência.
precoPorHora	decimal	O custo adicional por cada hora (ou fração de hora) que o veículo permanece estacionado.
veiculos	List<string>	Uma lista dinâmica que armazena as placas dos veículos que estão atualmente ocupando as vagas do estacionamento.

Exportar para as Planilhas
MÉTODOS ESSENCIAIS:
AdicionarVeiculo():
Simples e eficiente! Solicita a placa do veículo ao usuário e a registra imediatamente em nossa lista de estacionados.
RemoverVeiculo():
Inteligência em ação! Pede a placa do veículo a ser removido.
Verifica instantaneamente se o veículo está de fato estacionado.
Se encontrado, solicita a quantidade de horas de permanência.
Calcula o valor total a ser pago, utilizando a fórmula: precoInicial + (precoPorHora * horas).
Exibe o valor cobrado ao usuário e remove o veículo da lista.
Caso a placa não seja encontrada, uma mensagem informativa é exibida.
ListarVeiculos():
Visão geral rápida! Exibe todas as placas dos veículos atualmente presentes no estacionamento.
Se o estacionamento estiver vazio, uma mensagem amigável informa a ausência de veículos.
DIAGRAMA DE CLASSES (Estacionamento)
Compreenda a arquitetura limpa e funcional do nosso sistema de forma visual e clara:

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
Quer colocar as mãos na massa e ver o Estacionamento Inteligente em ação? Siga estes passos simples:

CLONE O REPOSITÓRIO para sua máquina local:
Bash

git clone git@github.com:PauloBarros3335/trilha-net-fundamentos-desafio.git
NAVEGUE ATÉ O DIRETÓRIO DO PROJETO no seu terminal (Git Bash ou PowerShell):
Bash

cd trilha-net-fundamentos-desafio/DesafioFundamentos
RESTAURE AS DEPENDÊNCIAS (garanta que tudo esteja pronto para rodar):
Bash

dotnet restore
EXECUTE A APLICAÇÃO e veja a mágica acontecer:
Bash

dotnet run
MENU DE INTERAÇÃO:
Ao iniciar, você será saudado por um menu intuitivo:

Digite a sua opção:
1 - Cadastrar veículo
2 - Remover veículo
3 - Listar veículos
4 - Encerrar
Experimente todas as opções para simular o dia a dia de um estacionamento de forma realista e interativa!

🛠️ TECNOLOGIAS DE PONTA
Este projeto foi construído utilizando as seguintes ferramentas e tecnologias modernas:

C#: A linguagem poderosa por trás de toda a lógica.
.NET 9.0: O framework mais recente e robusto da Microsoft, garantindo performance e escalabilidade.
Git: Para controle de versão impecável e organização do código.
GitHub: A plataforma líder para hospedagem e colaboração em projetos de código aberto.
🤝 PARTICIPE: SUA CONTRIBUIÇÃO IMPORTA!
Este é um projeto em constante evolução! Sinta-se à vontade para:

Explorar o código a fundo.
Sugerir novas funcionalidades que levem o estacionamento ao próximo nível.
Reportar bugs para mantermos a qualidade.
Sua colaboração é fundamental para tornar este Estacionamento Inteligente ainda mais completo e eficiente!

🧑‍💻 SOBRE O AUTOR
Desenvolvido com paixão e expertise por:

Paulo Barros - GitHub @PauloBarros3335
