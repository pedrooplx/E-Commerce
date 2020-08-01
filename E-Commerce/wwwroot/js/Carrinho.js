﻿class Carrinho {

    clickIncremento(btn) {
        debugger;
        let data = this.getData(btn);
        data.Quantidade++;
        this.postData(data);
    }

    clickDecremento(btn) {
        let data = this.getData(btn);
        data.Quantidade--;
        this.postData(data);
    }

    getData(elemento) {
        var linhaItem = $(elemento).parents('[item-id]'); //Capturar o elemento que tem "item-id"
        var itemId = $(linhaItem).attr('item-id'); //Acessando atributo item-id dentro de linhaItem
        var novaQtde = $(linhaItem).find('input').val();

        return {
            Id: itemId,
            Quantidade: novaQtde
        };
    }

    postData(data) {
        $.ajax({
            url: '/pedido/updatequantidade',
            method: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data)
        })
    }
}

var carrinho = new Carrinho();