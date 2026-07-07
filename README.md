# Sistema de Cadastro de Visitas

Um sistema desktop feito em C# com Windows Forms para registrar e consultar visitas. Foi um projeto de exercício pra praticar formulários, estruturas de dados e navegação entre telas.

---

## O que faz

A ideia é simples: você preenche os dados de uma visita (nome, documento, tipo, data e hora) e salva no sistema. Depois dá pra consultar os registros numa segunda tela dedicada a isso.

Os campos do cadastro são:
- Nome do visitante
- Tipo e número do documento
- Tipo de visita
- Data e hora

---

## Tecnologias

- C# com Windows Forms (.NET Framework)
- `LinkedList` para armazenar os registros em memória
- `DataGridView` para exibir os dados nas telas

---

## Estrutura

```
├── Form1.cs              # tela principal de cadastro
├── Form2.cs              # tela de consulta dos registros
├── Form3.cs              # tela auxiliar
├── Form1.Designer.cs     # layout gerado pelo designer do Visual Studio
└── Program.cs            # ponto de entrada da aplicação
```

---

## Como rodar

Precisa ter o Visual Studio instalado com suporte a .NET Framework.

1. Clone o repositório
2. Abre o arquivo `.csproj` no Visual Studio
3. Roda com `F5`

---

Feito por [willvinic](https://github.com/willvinic)
