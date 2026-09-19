# Registro de Progresso & Notas de Estudo em C# 📝

Este arquivo é um diário de bordo para acompanhar a evolução nos estudos da linguagem C#, registrando a quantidade de **repetições**, **dificuldades encontradas** e **pontos de atenção**.

---

## 📊 Quadro de Exercícios & Repetições

| Tema / Exercício | Arquivo | Repetições | Conceitos Praticados |
| :--- | :--- | :---: | :--- |
| **POO Básica** | [`poo/01_classe_pessoa_basica.cs`](file:///c:/Users/escob/OneDrive/Desktop/Dev/Linguagens/C%23/poo/01_classe_pessoa_basica.cs) | **10** | Criação de classes, objetos, atributos e métodos. |
| **Delegates** | [`delegates/01_uso_delegates.cs`](file:///c:/Users/escob/OneDrive/Desktop/Dev/Linguagens/C%23/delegates/01_uso_delegates.cs) | **6** | Multicast Delegates e associação de métodos estáticos. |
| **Dictionaries** | [`colecoes/02_cadastro_alunos_dictionary.cs`](file:///c:/Users/escob/OneDrive/Desktop/Dev/Linguagens/C%23/colecoes/02_cadastro_alunos_dictionary.cs) | **4** | Coleções aninhadas, acesso por chave e CRUD. |
| **Parâmetros Ref** | [`metodos/01_parametros_valor_ref.cs`](file:///c:/Users/escob/OneDrive/Desktop/Dev/Linguagens/C%23/metodos/01_parametros_valor_ref.cs) | **2** | Passagem de parâmetros por valor vs. por referência (`ref`). |
| **Sobrecarga** | [`metodos/02_sobrecarga_metodos.cs`](file:///c:/Users/escob/OneDrive/Desktop/Dev/Linguagens/C%23/metodos/02_sobrecarga_metodos.cs) | **2** | Method overloading (mesmo nome, parâmetros diferentes). |
| **Sistema Alunos POO** | [`projetos/04_sistema_alunos_poo/Program.cs`](file:///c:/Users/escob/OneDrive/Desktop/Dev/Linguagens/C%23/projetos/04_sistema_alunos_poo/Program.cs) | **1** | POO completa, classes estáticas (`AlunoManager`), List<Aluno>. |
| **Arrays & Condicionais** | [`arrays/01_maior_numero_array.cs`](file:///c:/Users/escob/OneDrive/Desktop/Dev/Linguagens/C%23/arrays/01_maior_numero_array.cs) | Praticado | Busca de maior valor em arrays com laço `for`. |
| **Arrays & Strings** | [`arrays/02_filtrar_nomes_array.cs`](file:///c:/Users/escob/OneDrive/Desktop/Dev/Linguagens/C%23/arrays/02_filtrar_nomes_array.cs) | Praticado | Iteração com `foreach` e verificação de `Length`. |
| **Lista de Compras** | [`colecoes/01_lista_compras_procedural.cs`](file:///c:/Users/escob/OneDrive/Desktop/Dev/Linguagens/C%23/colecoes/01_lista_compras_procedural.cs) | Praticado | `List<string>`, menu interativo e estrutura `switch`. |
| **Número Secreto 1P** | [`projetos/01_numero_secreto_1p/Program.cs`](file:///c:/Users/escob/OneDrive/Desktop/Dev/Linguagens/C%23/projetos/01_numero_secreto_1p/Program.cs) | Praticado | `Random`, `while`, `int.TryParse` e controle de fluxo (`goto`). |
| **Jokenpô** | [`projetos/02_jokenpo/Program.cs`](file:///c:/Users/escob/OneDrive/Desktop/Dev/Linguagens/C%23/projetos/02_jokenpo/Program.cs) | Praticado | Loops do-while aninhados e condicionais complexas. |
| **Número Secreto 2P** | [`projetos/03_numero_secreto_2p/Program.cs`](file:///c:/Users/escob/OneDrive/Desktop/Dev/Linguagens/C%23/projetos/03_numero_secreto_2p/Program.cs) | Praticado | Entrada de 2 jogadores, validação e `Console.Clear()`. |

---

## 💡 Dificuldades Registradas & Aprendizados

### 1. Verificação de Nulo em C#
- **Erro cometidos:** `if (alunoSearched)`
- **Correção necessária:** `if (alunoSearched != null)`
- **Aprendizado:** Em C#, tipos de referência não são convertidos implicitamente em `bool` (diferente de JavaScript ou Python). Para testar se um objeto existe ou foi encontrado, é obrigatório usar a comparação explícita com `null`.

### 2. Passagem de Valor vs. Referência (`ref`)
- **Conceito:** Tipos de valor (como `int`, `float`, `struct`) são passados por cópia por padrão. Para alterar a variável original no escopo chamador, é necessário usar o modificador `ref` tanto na assinatura do método quanto na chamada: `Adicionar10Ref(ref valor)`.

### 3. Validação de Entrada Defensiva (`int.TryParse`)
- **Padrão Utilizado:** Evitar exceções em tempo de execução ao ler dados do teclado usando `int.TryParse(Console.ReadLine(), out int valor)`.

### 4. Modularização com Classes Parciais (`partial class`)
- **Conceito:** A palavra-chave `partial` permite dividir a estrutura de uma classe entre vários arquivos (ex.: atributos em um arquivo e métodos em outro), facilitando a organização de código grande.

---

## 📈 Trilha de Evolução

- [x] **Módulo 1:** Sintaxe básica, variáveis, laços de repetição (`for`, `while`, `do-while`) e condicionais (`if`, `switch`).
- [x] **Módulo 2:** Estruturas de dados sequenciais e chave-valor (`Array`, `List<T>`, `Dictionary<K,V>`).
- [x] **Módulo 3:** Métodos, sobrecarga e modadores de parâmetro (`ref`).
- [x] **Módulo 4:** POO (Classes, Atributos, Instanciação, Propriedades getters/setters, `partial class`).
- [x] **Módulo 5:** Delegates (ponteiros para métodos).
- [ ] **Módulo 6 (Próximos Passos):** Herança, Polimorfismo, Interfaces, LINQ e Tratamento de Exceções (`try/catch`).
