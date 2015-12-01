namespace ReclamaPoa2015.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Models.PoaEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "ReclamaPoa2015.Models.PoaEntities";
        }

        protected override void Seed(ReclamaPoa2015.Models.PoaEntities context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Bairros.AddOrUpdate(x => x.BairroId,
               new Bairro { BairroId = 1, Nome = "Agronomia" },
                new Bairro { BairroId = 2, Nome = "Anchieta" },
                new Bairro { BairroId = 3, Nome = "Arquip�lago" },
                new Bairro { BairroId = 4, Nome = "Auxiliadora" },
                new Bairro { BairroId = 5, Nome = "Azenha" },
                new Bairro { BairroId = 6, Nome = "Bela Vista" },
                new Bairro { BairroId = 7, Nome = "Bel�m Novo" },
                new Bairro { BairroId = 8, Nome = "Bel�m Velho" },
                new Bairro { BairroId = 9, Nome = "Boa Vista" },
                new Bairro { BairroId = 10, Nome = "Bom Fim" },
                new Bairro { BairroId = 11, Nome = "Bom Jesus" },
                new Bairro { BairroId = 12, Nome = "Camaqu�" },
                new Bairro { BairroId = 13, Nome = "Campo Novo" },
                new Bairro { BairroId = 14, Nome = "Cascata" },
                new Bairro { BairroId = 15, Nome = "Cavalhada" },
                new Bairro { BairroId = 16, Nome = "Cel. Apar�cio Borges" },
                new Bairro { BairroId = 17, Nome = "Centro Hist�rico" },
                new Bairro { BairroId = 18, Nome = "Ch�cara das Pedras" },
                new Bairro { BairroId = 19, Nome = "Chap�u do Sol" },
                new Bairro { BairroId = 20, Nome = "Cidade Baixa" },
                new Bairro { BairroId = 21, Nome = "Cristal" },
                new Bairro { BairroId = 22, Nome = "Cristo Redentor" },
                new Bairro { BairroId = 23, Nome = "Esp�rito Santo" },
                new Bairro { BairroId = 24, Nome = "Farrapos" },
                new Bairro { BairroId = 25, Nome = "Farroupilha" },
                new Bairro { BairroId = 26, Nome = "Floresta" },
                new Bairro { BairroId = 27, Nome = "Gl�ria" },
                new Bairro { BairroId = 28, Nome = "Guaruj�" },
                new Bairro { BairroId = 29, Nome = "Higien�polis" },
                new Bairro { BairroId = 30, Nome = "H�pica" },
                new Bairro { BairroId = 31, Nome = "Humait�" },
                new Bairro { BairroId = 32, Nome = "Independ�ncia" },
                new Bairro { BairroId = 33, Nome = "Ipanema" },
                new Bairro { BairroId = 34, Nome = "Jardim Bot�nico" },
                new Bairro { BairroId = 35, Nome = "Jardim Carvalho" },
                new Bairro { BairroId = 36, Nome = "Jardim do Salso" },
                new Bairro { BairroId = 37, Nome = "Jardim Floresta" },
                new Bairro { BairroId = 38, Nome = "Jardim Isabel" },
                new Bairro { BairroId = 39, Nome = "Jardim Itu-Sabar�" },
                new Bairro { BairroId = 40, Nome = "Jardim Lind�ia" },
                new Bairro { BairroId = 41, Nome = "Jardim S�o Pedro" },
                new Bairro { BairroId = 42, Nome = "Lageado" },
                new Bairro { BairroId = 43, Nome = "Lami" },
                new Bairro { BairroId = 44, Nome = "Lomba do Pinheiro" },
                new Bairro { BairroId = 45, Nome = "Marc�lio Dias" },
                new Bairro { BairroId = 46, Nome = "M�rio Quintana" },
                new Bairro { BairroId = 47, Nome = "Medianeira" },
                new Bairro { BairroId = 48, Nome = "Menino Deus" },
                new Bairro { BairroId = 49, Nome = "Moinhos de Vento" },
                new Bairro { BairroId = 50, Nome = "Mont Serrat" },
                new Bairro { BairroId = 51, Nome = "Navegantes" },
                new Bairro { BairroId = 52, Nome = "Nonoai" },
                new Bairro { BairroId = 53, Nome = "Partenon" },
                new Bairro { BairroId = 54, Nome = "Passo da Areia" },
                new Bairro { BairroId = 55, Nome = "Pedra Redonda" },
                new Bairro { BairroId = 56, Nome = "Petr�polis" },
                new Bairro { BairroId = 57, Nome = "Ponta Grossa" },
                new Bairro { BairroId = 58, Nome = "Praia de Belas" },
                new Bairro { BairroId = 59, Nome = "Restinga" },
                new Bairro { BairroId = 60, Nome = "Rio Branco" },
                new Bairro { BairroId = 61, Nome = "Rubem Berta" },
                new Bairro { BairroId = 62, Nome = "Santa Cec�lia" },
                new Bairro { BairroId = 63, Nome = "Santa Maria Goretti" },
                new Bairro { BairroId = 64, Nome = "Santa Tereza" },
                new Bairro { BairroId = 65, Nome = "Santana" },
                new Bairro { BairroId = 66, Nome = "Santo Ant�nio" },
                new Bairro { BairroId = 67, Nome = "S�o Geraldo" },
                new Bairro { BairroId = 68, Nome = "S�o Jo�o" },
                new Bairro { BairroId = 69, Nome = "S�o Jos�" },
                new Bairro { BairroId = 70, Nome = "S�o Sebasti�o" },
                new Bairro { BairroId = 71, Nome = "Sarandi" },
                new Bairro { BairroId = 72, Nome = "Serraria" },
                new Bairro { BairroId = 73, Nome = "Teres�polis" },
                new Bairro { BairroId = 74, Nome = "Tr�s Figueiras" },
                new Bairro { BairroId = 75, Nome = "Tristeza" },
                new Bairro { BairroId = 76, Nome = "Vila Assun��o" },
                new Bairro { BairroId = 77, Nome = "Vila Concei��o" },
                new Bairro { BairroId = 78, Nome = "Vila Ipiranga" },
                new Bairro { BairroId = 79, Nome = "Vila Jardim" },
                new Bairro { BairroId = 80, Nome = "Vila Jo�o Pessoa" },
                new Bairro { BairroId = 81, Nome = "Vila Nova" }
            );

            context.Categorias.AddOrUpdate(x => x.CategoriaId,
                new Categoria { CategoriaId = 1, Cat_Titulo = "Acessibilidade", Cat_Descricao = "Falta de Acessibilidade" },
                new Categoria { CategoriaId = 2, Cat_Titulo = "�gua e Esgoto", Cat_Descricao = "Tratamento de esgoto inadequado,Falta de �gua,Esgoto a c�u aberto, etc. " },
                new Categoria { CategoriaId = 3, Cat_Titulo = "Alagamento", Cat_Descricao = "Alagamento" },
                new Categoria { CategoriaId = 4, Cat_Titulo = "Buraco", Cat_Descricao = "Buraco Asfalto, Ch�o, Rua Esburacada" },
                new Categoria { CategoriaId = 5, Cat_Titulo = "Ilumina��o", Cat_Descricao = "Falta Ilumina��o, Luz Queimada" },
                new Categoria { CategoriaId = 6, Cat_Titulo = "Lixo", Cat_Descricao = "Veiculo Abandonado, entulho de lixo" },
                new Categoria { CategoriaId = 7, Cat_Titulo = "Energia", Cat_Descricao = "Falta de Energia Eletrica" },
                new Categoria { CategoriaId = 8, Cat_Titulo = "Obra", Cat_Descricao = "Obra irregular, atrasada, parada, abandonada, etc" },
                new Categoria { CategoriaId = 9, Cat_Titulo = "Queimada", Cat_Descricao = "Queimada" },
                new Categoria { CategoriaId = 10, Cat_Titulo = "Seguran�a", Cat_Descricao = "Falta de Seguran�a" },
                new Categoria { CategoriaId = 11, Cat_Titulo = "Ciclovia", Cat_Descricao = "Ciclovia em mau estado, irregular, mal sinalizada" },
                new Categoria { CategoriaId = 12, Cat_Titulo = "Picha��o", Cat_Descricao = "Picha��o" },
                new Categoria { CategoriaId = 13, Cat_Titulo = "Polui��o do Ar", Cat_Descricao = "Polui��o do Ar" },
                new Categoria { CategoriaId = 14, Cat_Titulo = "Sa�de", Cat_Descricao = "Falta de profissionais, leitos, etc." },
                new Categoria { CategoriaId = 15, Cat_Titulo = "Tr�nsito", Cat_Descricao = "Falta de sinaliza��o, faixa de pedestre em mau estado" }                
                );

        }
}
}
