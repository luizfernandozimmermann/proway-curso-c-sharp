namespace WindowsFormsExemplos.Modelos
{
    internal class Carrinho: ModeloBase
    {
        public Pedido Venda { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
