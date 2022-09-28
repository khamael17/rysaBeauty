namespace rysaBeauty.Models
{
   
     public class Article
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Numero_ID { get; set; }
        public string Nom { get; set; }
        public string? Fournisseur { get; set; }
        public int Prix_Gros { get; set; }
        public int Prix_Vente { get; set; }
        public int Quantite_Stock { get; set; }
        public int Quantite_Vendu { get; set; }
        public enum Etat_stock { Bon, Moyen, Bas }
        public string? Client { get; set; }

        public Article() { }

        ////protected override void OnModelCreating(ModelBuilder modelBuilder)
        ////{
        ////    modelBuilder.Entity<Produit>().HasKey(c => new { Numero_ID });
        ////}

    }
}
