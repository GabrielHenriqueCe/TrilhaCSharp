# Rep3: Loja de itens

**Projeto:** `Fase1\ClasseListaMetodo\ClasseListaMetodo.Rep3.Loja`

## Parte 1: a classe do item

- [x] Crie uma classe que representa um item da loja, com nome, preço e quantidade em estoque.
- [x] O item nasce com nome, preço e estoque informados na criação.
- [x] Ninguém de fora da classe pode alterar o estoque direto.
- [x] O estoque nunca fica negativo.
- [x] O item sabe ser vendido numa quantidade:
  - se tem estoque suficiente, o estoque diminui;
  - se não tem, nada muda, e quem pediu a venda fica sabendo.
- [x] O item sabe ser reposto numa quantidade, e o estoque aumenta.
- [x] O item sabe montar a própria ficha: nome, preço e estoque.

## Parte 2: o programa

- [x] Ao abrir, a loja já tem 3 itens cadastrados no código, e um deles com estoque 0.
- [x] Menu em loop até sair: `1` Ver itens / `2` Comprar / `3` Repor estoque / `0` Sair.
- [x] **Ver itens:** lista numerada a partir de 1, com a ficha de cada item.
- [x] **Comprar:**
  - mostra a lista e pede o número do item e a quantidade;
  - texto pede de novo;
  - número fora da lista, ou quantidade 0 ou menos, mostra o motivo e volta para o menu;
  - se a venda aconteceu, mostra o nome, a quantidade e o total pago;
  - se não aconteceu, avisa que falta estoque e mostra quanto tem.
- [x] **Repor:** escolhe o item e a quantidade com as mesmas validações, e mostra o estoque novo.
- [x] Opção inválida no menu: avisa e volta para o menu.

## Partida de exemplo

O texto pode variar.

```
> 1
1 - Ração     Preço: 4,99     Estoque: 10
2 - Poção     Preço: 12,50    Estoque: 5
3 - Ovo Raro  Preço: 49,99    Estoque: 0

> 2
Item: abc
Item: 9
A escolha deve ser entre 1 e 3

> 2
Item: 2
Quantidade: 0
O valor não pode ser menor ou igual a Zero.

> 2
Item: 2
Quantidade: 6
Estoque insuficiente: Poção tem só 5.

> 2
Item: 2
Quantidade: 5
Você comprou 5 Poção por 62,50

> 3
Item: 3
Quantidade: 2
Você adicionou 2 Ovo Raro. Estoque: 2

> 7
Digite uma das opções do Menu

> 0
```

## Pronto

- [x] A partida acima sai igual.
- [x] A classe não usa `Console` em nenhum lugar.

**Fora do pronto:** cadastrar item novo pelo menu, saldo do jogador, salvar em arquivo.
