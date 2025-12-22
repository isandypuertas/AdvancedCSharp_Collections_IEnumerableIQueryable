# IEnumerable vs IQueryable na Prática

Projeto simples criado para demonstrar, **na prática**, a diferença entre `IEnumerable` e `IQueryable` no .NET, especialmente no contexto de consultas a banco de dados.

A ideia é mostrar como cada um se comporta em relação ao mesmo codigo, com log de consulta.

Resultado esperado:
<img width="1467" height="421" alt="image" src="https://github.com/user-attachments/assets/19e37890-19d1-4183-bb7c-cbac44a81986" />


---

## 🧠 Objetivo

Evidenciar:

- Diferença entre **execução em memória** (`IEnumerable`) - exemplificado com Take(2) - Performance pode ser pior, uma vez que traz todos os dados e nao o necessario
- Diferença entre **execução no banco de dados** (`IQueryable`) - também exemplificado com Take(2) - Performance pode ser melhor, menos memoria + menos dados trafegados => mais velocidade
- Quando usar cada abordagem (`IEnumerable`- dados ja em memoria, pouco volume de dados, dados de fontes distintas (bancos e arquivos diversos). `IQueryable` - grande volume de dados, paginacao, filtros complexos)

---

## 🛠️ Tecnologias Utilizadas

- .NET
- C#
- SQL Server
- LINQ

---

## 🗄️ Estrutura da Tabela (Banco de Dados)

Script simples para criação e carga da tabela `Employees` utilizada nos exemplos:

```sql
USE [LocalDatabase]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employees](
	[Id] [int] NOT NULL,
	 NULL,
	 NULL,
	 NULL
) ON [PRIMARY]
GO

INSERT INTO [dbo].[Employees]
           ([Id], [FirstName], [LastName], [Address])
VALUES
    (1, 'Isabelle', 'Maria', 'Adress 123'),
    (2, 'Maria', 'Isabelle', 'Adress 123'),
    (3, 'Joao', 'Gomes', 'Adress 123'),
    (4, 'Gomes', 'Joao', 'Adress 123'),
    (5, 'Beyonce', 'Knowless', 'Adress 123')
GO
