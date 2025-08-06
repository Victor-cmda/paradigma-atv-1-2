Tarefa 1

Escreva uma consulta usando linguagem SQL para encontrar os colaboradores que tem o salário mais alto em cada um dos departamentos.

A tabela Pessoa possui a relação de todos os colaboradores de uma empresa. Cada pessoa tem um Id, um salário, e também uma coluna para o ID do departamento.

Id	Nome	Salario	DeptId
1	Joe	70000	1
2	Henry	80000	2
3	Sam	60000	2
4	Max	90000	1

A tabela Departamento contém a lista de departamentos da empresa.

Id	Nome
1	TI
2	Vendas

Resultado esperado:
Departamento	Pessoa	Salario
xxxx	xxxxx	?
yyyy	yyyy	?

Tarefa 2

Dado um array inteiro sem duplicidade, construa um algoritmo de uma árvore a partir das seguintes regras:
•	A raiz da árvore deve ser o maior valor do array
•	Os galhos da esquerda devem ser compostos somente por números à esquerda do valor raiz, na ordem decrescente
•	Os galhos da direita devem ser compostos somente por número à direita do valor raiz, na ordem decrescente

Você pode apresentar um algoritmo em pseudo-código ou em qualquer linguagem de programação moderna.
Seu algoritmo deve ser capaz de resolver os dois cenários abaixo:

Cenario 1
Array de entrada: [3, 2, 1, 6, 0, 5]
Raiz: 6
Galhos da esquerda: 3, 2, 1
Galhos da direita: 5, 0
         6
       /    \
     3       5
    /          \
  2             0
 /
1

Cenario 2
Array de entrada: [7, 5, 13, 9, 1, 6, 4]
Raiz: 13
Galhos da esquerda: 7, 5
Galhos da direita: 9, 6, 4, 1
       13
     /     \
   7        9
  /           \
5              6
                  \
                    4
                      \
                        1

