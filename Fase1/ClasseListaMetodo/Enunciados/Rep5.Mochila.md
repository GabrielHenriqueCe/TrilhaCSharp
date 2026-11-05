# Rep5: A mochila do Arin

**Projeto:** `Fase1\ClasseListaMetodo\ClasseListaMetodo.Rep5.Mochila`

## Parte 1: as classes

- [x] Crie uma classe para o item, com nome e peso. O peso precisa ser maior que zero.
- [x] Crie uma classe para a mochila, com uma capacidade de peso e os itens guardados nela. Ela nasce vazia, com a capacidade informada.
- [x] Ninguém de fora altera a capacidade.
- [x] A mochila sabe guardar um item:
  - se o peso dos itens guardados mais o do item novo passa da capacidade, nada muda, e quem pediu fica sabendo por quê;
  - se fica exatamente igual à capacidade, o item cabe.
- [x] A mochila sabe tirar um item.
- [x] A mochila sabe dizer o peso atual e montar a própria ficha, com o peso atual sobre a capacidade.

## Parte 2: o programa

- [x] Ao abrir, existem a mochila do Arin, com capacidade 10, e 4 itens no chão:
  - Poção: peso 1
  - Espada: peso 4
  - Escudo: peso 5
  - Corda: peso 2
- [x] Menu em loop até sair: `1` Ver mochila / `2` Guardar item / `3` Tirar item / `0` Sair.
- [x] **Ver mochila:** mostra a ficha e os itens numerados.
- [x] **Guardar item:** mostra o chão numerado e pede o número. O item guardado sai do chão.
- [x] **Tirar item:** mostra a mochila e pede a posição, a partir de 1. O `Program` confere a posição. O item tirado volta para o chão.
- [x] Entrada inválida mostra o motivo e volta para o menu. Na recusa, mostra o motivo, e o item continua onde estava. No sucesso, mostra o que foi feito e o peso atual.

## Partida de exemplo

O texto pode variar.

```
> 1
Peso: 0 / 10
Nenhum item na mochila!

> 3
Nenhum item na mochila!

> 2
Item: 2
Guardou: Espada. Peso atual: 4

> 2
Item: 2
Guardou: Escudo. Peso atual: 9

> 2
Item: 2
Recusado: Corda pesa 2, só cabe mais 1

> 2
Item: 1
Guardou: Poção. Peso atual: 10

> 2
Item: 1
Recusado: Corda pesa 2, só cabe mais 0

> 2
Item: 2
Escolha entre 1 e 1

> 2
Item: abc
Digite um número.

> 3
Posição: 4
Escolha entre 1 e 3

> 3
Posição: 1
Retirou: Espada. Peso atual: 6

> 1
Peso: 6 / 10
1 - Escudo (5)
2 - Poção (1)

> 0
```

## Pronto

- [x] A partida acima sai igual.
- [x] Nenhuma classe usa `Console`.
- [x] Os números digitados foram testados com 0, 1, o último e o último + 1.
- [ ] Você explica o código em voz alta (oral pendente).

**Fora do pronto:** empilhar itens iguais, comprar com ouro, equipar, peso com casas decimais, salvar a mochila.
