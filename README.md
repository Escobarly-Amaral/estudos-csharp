# Estudos de C#

Repositório dedicado aos meus estudos práticos da linguagem C#, organizado de forma temática por conceitos fundamentais e mini-projetos integrados.

---

## 📁 Estrutura do Repositório

### 🔹 1. Arrays (`arrays/`)
Exercícios focados em declaração, navegação e manipulação de arrays unidimensionais.
- [`arrays/01_maior_numero_array.cs`](file:///c:/Users/escob/OneDrive/Desktop/Dev/Linguagens/C%23/arrays/01_maior_numero_array.cs): Algoritmo para encontrar o maior número em um array usando laço `for` e condicionais `if`.
- [`arrays/02_filtrar_nomes_array.cs`](file:///c:/Users/escob/OneDrive/Desktop/Dev/Linguagens/C%23/arrays/02_filtrar_nomes_array.cs): Filtragem de elementos em array de strings com `foreach` e propriedade `Length`.

### 🔹 2. Coleções (`colecoes/`)
Exercícios envolvendo estruturas de dados mais avançadas como `List<T>` e `Dictionary<K, V>`.
- [`colecoes/01_lista_compras_procedural.cs`](file:///c:/Users/escob/OneDrive/Desktop/Dev/Linguagens/C%23/colecoes/01_lista_compras_procedural.cs): Gerenciador de lista de compras estilo CRUD usando `List<string>`, menu interativo e `switch`.
- [`colecoes/02_cadastro_alunos_dictionary.cs`](file:///c:/Users/escob/OneDrive/Desktop/Dev/Linguagens/C%23/colecoes/02_cadastro_alunos_dictionary.cs): Sistema de cadastro de alunos utilizando `Dictionary` aninhado (`Dictionary<string, Dictionary<string, string>>`).

### 🔹 3. Métodos (`metodos/`)
Conceitos de criação, assinatura e passagem de parâmetros em métodos.
- [`metodos/01_parametros_valor_ref.cs`](file:///c:/Users/escob/OneDrive/Desktop/Dev/Linguagens/C%23/metodos/01_parametros_valor_ref.cs): Comparação entre passagem de parâmetros por valor vs. por referência (modificador `ref`).
- [`metodos/02_sobrecarga_metodos.cs`](file:///c:/Users/escob/OneDrive/Desktop/Dev/Linguagens/C%23/metodos/02_sobrecarga_metodos.cs): Demonstração de sobrecarga de métodos (Method Overloading) com quantidade variante de argumentos.

### 🔹 4. Programação Orientada a Objetos (`poo/`)
Conceitos de POO em C#, incluindo classes, atributos, métodos, getters/setters e classes parciais.
- [`poo/01_classe_pessoa_basica.cs`](file:///c:/Users/escob/OneDrive/Desktop/Dev/Linguagens/C%23/poo/01_classe_pessoa_basica.cs): Definição de classe `Pessoa`, atributos públicos e métodos de instância.
- [`poo/02_classes_parciais/`](file:///c:/Users/escob/OneDrive/Desktop/Dev/Linguagens/C%23/poo/02_classes_parciais): Organização de uma mesma classe (`Pessoa`) dividida em múltiplos arquivos através da palavra-chave `partial`.

### 🔹 5. Delegates (`delegates/`)
Recursos avançados de ponteiros de função em C#.
- [`delegates/01_uso_delegates.cs`](file:///c:/Users/escob/OneDrive/Desktop/Dev/Linguagens/C%23/delegates/01_uso_delegates.cs): Criação e invocação de multicast `delegate` para executar múltiplas operações matemáticas.

---

## 🎮 Projetos (Múltiplos Temas)

Aplicações completas no console que combinam laços de repetição (`while`, `do-while`), estruturas condicionais (`if/else`, `switch`), tratamento de exceção/validação (`int.TryParse`) e POO.

1. [`projetos/01_numero_secreto_1p/`](file:///c:/Users/escob/OneDrive/Desktop/Dev/Linguagens/C%23/projetos/01_numero_secreto_1p): Jogo de adivinhação single-player com números aleatórios gerados pela classe `Random`.
2. [`projetos/02_jokenpo/`](file:///c:/Users/escob/OneDrive/Desktop/Dev/Linguagens/C%23/projetos/02_jokenpo): Jogo clássico de Pedra, Papel e Tesoura com controle de turnos e repetição de partida.
3. [`projetos/03_numero_secreto_2p/`](file:///c:/Users/escob/OneDrive/Desktop/Dev/Linguagens/C%23/projetos/03_numero_secreto_2p): Jogo do Número Secreto para 2 jogadores (um escolhe o número e o outro adivinha).
4. [`projetos/04_sistema_alunos_poo/`](file:///c:/Users/escob/OneDrive/Desktop/Dev/Linguagens/C%23/projetos/04_sistema_alunos_poo): Sistema de gestão de alunos utilizando arquitetura POO com classe de domínio `Aluno` e classe utilitária estática `AlunoManager`.

---

## 📝 Registro de Progresso Pessoal
Consulte o arquivo [`NOTAS.md`](file:///c:/Users/escob/OneDrive/Desktop/Dev/Linguagens/C%23/NOTAS.md) para acompanhar o histórico de repetições por tema, dificuldades enfrentadas e a trilha de evolução nos estudos de C#.