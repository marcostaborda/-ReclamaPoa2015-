namespace ReclamaPoa2015.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bairroes",
                c => new
                    {
                        BairroId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.BairroId);
            
            CreateTable(
                "dbo.Reclamacaos",
                c => new
                    {
                        ReclamacaoId = c.Int(nullable: false, identity: true),
                        BairroId = c.Int(nullable: false),
                        CategoriaId = c.Int(nullable: false),
                        Titulo = c.String(),
                        Descricao = c.String(),
                        Endereco = c.String(),
                        Foto = c.String(),
                        Data = c.DateTime(nullable: false),
                        StatusId = c.Int(nullable: false),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.ReclamacaoId)
                .ForeignKey("dbo.Bairroes", t => t.BairroId, cascadeDelete: true)
                .ForeignKey("dbo.Categorias", t => t.CategoriaId, cascadeDelete: true)
                .Index(t => t.BairroId)
                .Index(t => t.CategoriaId);
            
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        CategoriaId = c.Int(nullable: false, identity: true),
                        Cat_Titulo = c.String(),
                        Cat_Descricao = c.String(),
                    })
                .PrimaryKey(t => t.CategoriaId);
            
            CreateTable(
                "dbo.Comentarios",
                c => new
                    {
                        ComentarioId = c.Int(nullable: false, identity: true),
                        ReclamacaoId = c.Int(nullable: false),
                        Foto = c.String(),
                        Data = c.DateTime(nullable: false),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.ComentarioId)
                .ForeignKey("dbo.Reclamacaos", t => t.ReclamacaoId, cascadeDelete: true)
                .Index(t => t.ReclamacaoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comentarios", "ReclamacaoId", "dbo.Reclamacaos");
            DropForeignKey("dbo.Reclamacaos", "CategoriaId", "dbo.Categorias");
            DropForeignKey("dbo.Reclamacaos", "BairroId", "dbo.Bairroes");
            DropIndex("dbo.Comentarios", new[] { "ReclamacaoId" });
            DropIndex("dbo.Reclamacaos", new[] { "CategoriaId" });
            DropIndex("dbo.Reclamacaos", new[] { "BairroId" });
            DropTable("dbo.Comentarios");
            DropTable("dbo.Categorias");
            DropTable("dbo.Reclamacaos");
            DropTable("dbo.Bairroes");
        }
    }
}
