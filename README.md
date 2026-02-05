# Financas

Funcionalidades
👤 Cadastro de Pessoas

Permite o gerenciamento completo de pessoas cadastradas no sistema.

Funcionalidades disponíveis:

Criar pessoa

Editar pessoa

Excluir pessoa

Listar pessoas

Regras e atributos:

O identificador é gerado automaticamente

Nome com tamanho máximo de 200 caracteres

Idade obrigatória

Ao excluir uma pessoa, todas as transações associadas são removidas automaticamente (exclusão em cascata)

🏷️ Cadastro de Categorias

Permite o gerenciamento básico de categorias utilizadas nas transações financeiras.

Funcionalidades disponíveis:

Criar categoria

Listar categorias

Atributos:

Identificador gerado automaticamente

Descrição com tamanho máximo de 400 caracteres

Finalidade da categoria:

Despesa

Receita

Ambas

💰 Cadastro de Transações

Responsável pelo registro das movimentações financeiras das pessoas cadastradas.

Funcionalidades disponíveis:

Criar transação

Listar transações

Atributos:

Identificador gerado automaticamente

Descrição com tamanho máximo de 400 caracteres

Valor numérico positivo

Tipo da transação:

Despesa

Receita

Categoria vinculada

Pessoa vinculada

Regras de negócio:

Pessoas menores de 18 anos podem registrar apenas despesas

A categoria utilizada deve ser compatível com o tipo da transação:

Transações do tipo Despesa não podem utilizar categorias com finalidade Receita

Transações do tipo Receita não podem utilizar categorias com finalidade Despesa

Categorias com finalidade Ambas são aceitas para qualquer tipo

📊 Consultas e Relatórios
📈 Totais por Pessoa

Exibe um resumo financeiro de todas as pessoas cadastradas.

Para cada pessoa são apresentados:

Total de receitas

Total de despesas

Saldo (receitas − despesas)

Ao final da listagem, é exibido:

Total geral de receitas

Total geral de despesas

Saldo líquido consolidado

📊 Totais por Categoria (Opcional)

Exibe um resumo financeiro agrupado por categoria.

Para cada categoria são apresentados:

Total de receitas

Total de despesas

Saldo (receitas − despesas)

Ao final da listagem, é exibido:

Total geral de receitas

Total geral de despesas

Saldo líquido consolidado
