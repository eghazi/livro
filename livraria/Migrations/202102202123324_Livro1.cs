namespace livraria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Livro1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.livroes",
                c => new
                    {
                        LivroID = c.Int(nullable: false, identity: true),
                        sISBN = c.String(),
                        sAutor = c.String(),
                        sNome = c.String(),
                        dPreco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        dtPublicacao = c.DateTime(),
                        sImagemCapa = c.String(),
                        sDescImagemCapa = c.String(),
                        dtCadastro = c.DateTime(),
                    })
                .PrimaryKey(t => t.LivroID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.livroes");
        }
    }
}
