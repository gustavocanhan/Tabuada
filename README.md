# 🧮 Projeto Tabuada (C# Console)

Este projeto foi desenvolvido em **C#** com o objetivo de praticar **entrada de dados, laços de repetição, validações e separação de responsabilidades entre classes**.

## 🎯 Objetivo
O programa exibe a **tabuada de multiplicação** de um número informado pelo usuário, repetindo o processo conforme a escolha do usuário.

---

## 🧠 Estrutura do Projeto

### 📁 Estrutura de Pastas
```
Tabuada/
│
├── Program.cs
├── Tela.cs
├── FuncaoMultiplicacao.cs
└── RepetirCodigo.cs
```

### 📂 Classes Principais

#### **Program**
- Contém o fluxo principal do sistema.
- Controla o loop que mantém o programa em execução.
- Interage com as classes `Tela`, `FuncaoMultiplicacao` e `RepetirCodigo`.

#### **Tela**
- Responsável por exibir todas as mensagens do programa.
- Centraliza a interface textual com o usuário.
- Exibe:
  - Menu principal
  - Mensagens de erro
  - Pergunta de repetição
  - Mensagem de saída

#### **FuncaoMultiplicacao**
- Responsável por **gerar e exibir a tabuada** do número digitado.
- Realiza um loop de 0 a 10 multiplicando o número informado.

#### **RepetirCodigo**
- Pergunta ao usuário se deseja repetir o processo.
- Faz validação de entrada (0 ou 1).
- Retorna `true` para repetir e `false` para encerrar.

---

## 🧩 Funcionamento

1. O programa solicita ao usuário um número inteiro.
2. Se o número for **positivo**, mostra a tabuada de 0 a 10.  
3. Se for **negativo**, exibe uma mensagem de erro.
4. Se for **0**, encerra o programa.
5. Após cada execução, pergunta se o usuário deseja repetir o processo.

---

## 💻 Exemplo de Execução

```
=== Tabuada de Multiplicação ===
Digite um valor inteiro ou (0 para sair): 5

5 x 0 = 0
5 x 1 = 5
5 x 2 = 10
...
5 x 10 = 50

Deseja repetir processo?
Digite 1 para SIM ou 0 para NÃO: 0

Encerrando o programa. Até mais!
```

---

## 🧱 Conceitos Utilizados
- Estrutura de repetição `while`
- Validação com `int.TryParse()`
- Métodos e classes
- Responsabilidade única (cada classe tem sua função específica)
- Boas práticas de legibilidade e modularização

---

## 🧑‍💻 Autor
**Gustavo Canhan**  
Projeto de aprendizado em C# — foco em estruturação, organização e boas práticas de programação em console.
