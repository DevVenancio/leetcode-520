# Leetcode - 520. Detecção Captular

Definimos o uso de letras maiúsculas em uma palavra como válido quando um dos seguintes casos é válido:

- Todas as letras sejam maiúsculas, como "BRASIL".
- Todas as letras sejam minúsculas, como "github".
- Apenas a primeira letra seja maiúscula, como "Google".

Dado uma `string`, retorna-se `true` caso a palavra atenda a alguma dessas condições.

Exemplo 1:
`Input: word = "USA"
Output: true`

Exemplo 2:
`Input: word = "FlaG"
Output: false`
 
Restrições:
1. 1 <= word.length <= 100
2. A palavra precisa conter letras maiúsculas e minúsculas dentro da língua inglesa.
