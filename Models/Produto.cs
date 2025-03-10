using SQLite;

namespace Minhas_Compras.Models
{
    public class Produto
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public required string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}