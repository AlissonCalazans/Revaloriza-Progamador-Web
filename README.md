<h1>Revaloriza-Progamador-Web</h1>

<h4> Projeto desenvolvido com APS.NET Core. - Tela de cadastro de Clientes com com funções inclusão, alteração, exclusão e um campo de Pesquisa.</h4>:-----------------------------------------------------------------------------------------------------------------------------------:
<h3>- Estrutura do Projeto</h3>
:shipit: ./Controllers/ClienteController.cs : É Utilizado para incluir a lista, além de gerar as acões do botoes dos registros dos clientes.

:shipit: ./ Controllers/homeControllers.cs:
1. Index: Essa ação retorna uma visualização (view) para a página inicial da aplicação. A página inicial é aquela que normalmente é carregada quando alguém visita o site.

2. Privacy: Essa ação retorna uma visualização para a página de privacidade da aplicação. É comum que os sites tenham uma página de privacidade para explicar suas políticas de privacidade aos usuários.

3. Error: Essa ação é acionada quando ocorre um erro na aplicação. Ela retorna uma visualização com informações sobre o erro, como o ID da solicitação e outras informações de rastreamento.

:shipit:./models/ClienteModel.cs: A classe utiliza atributos de anotação (Annotations) para configurar metadados que descrevem como as propriedades do modelo devem ser tratadas, como por exemplo, a nomenclatura das colunas no banco de dados e a exibição de nomes nas visualizações.

:shipit:./Viwes/ É toda a parte de estilização do site, isso inclui as rotas dos links e botões.




<h4>-Frameworks </h4>

- Microsoft.EntityFrameworkCore (Versão 7.0.10)

- Microsoft.EntityFrameworkCore.Design (Versão 7.0.10)

- Microsoft.EntityFrameworkCore.SqlServer (Versão 7.0.10)

- Microsoft.EntityFrameworkCore.Tools (Versão 7.0.10)
