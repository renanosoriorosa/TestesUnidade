﻿using NerdStore.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Vendas.Domain.Tests
{
    public class PedidoItemTests
    {
        [Fact(DisplayName = "Novo Item Pedido Com Unidades Abaixo do Permitido")]
        [Trait("Categoria", "Vendas - Pedido Item")]
        public void AdicionarItemPedido_UnidadesItemAbaixoDoPermitido_DeveRetornarException()
        {
            //Arrange, Act e Assert
            Assert.Throws<DomainException>(() => new PedidoItem(Guid.NewGuid(), "Produto Teste", Pedido.MIN_UNIDADES_ITEM - 1, 100));
        }
    }
}
