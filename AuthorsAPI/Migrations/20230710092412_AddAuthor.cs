using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthorsAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddAuthor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Biography = table.Column<string>(type: "TEXT", nullable: true),
                    Born = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });


                migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "FirstName", "LastName", "Biography","Born" },
                values: new object[,]
                {
                    { Guid.NewGuid(), "JK", "Rowling", "Joanne Rowling CH OBE FRSL, best known by her pen name J. K. Rowling, is a British author and philanthropist. She wrote Harry Potter, a seven-volume childrens fantasy series published from 1997 to 2007.", new DateTime(1965, 06, 30)},
                    { Guid.NewGuid(), "Jane", "Austin", "Jane Austin was an English novelist known primarily for her six major novels, which implicitly interpret, critique, and comment upon the British landed gentry at the end of the 18th century. Austen's plots often explore the dependence of women on marriage for the pursuit of favourable social standing and economic security. Her works are an implicit critique of the novels of sensibility of the second half of the 18th century and are part of the transition to 19th-century literary realism.", new DateTime(1775, 12, 16)},
                    { Guid.NewGuid(), "George", "Orwell", "George Orwell, pseudonym of Eric Arthur Blair, (born June 25, 1903, Motihari, Bengal, India—died January 21, 1950, London, England), English novelist, essayist, and critic famous for his novels Animal Farm (1945) and Nineteen Eighty-four (1949), the latter a profound anti-utopian novel that examines the dangers of totalitarian rule.", new DateTime(1903, 06, 25)},
                    { Guid.NewGuid(), "Harper", "Lee", "“Nelle” Harper Lee was born on April 28, 1926, the youngest of four children of Amasa Coleman Lee and Frances Cunningham Finch Lee. She grew up in Monroeville, a small town in southwest Alabama. Her father was a lawyer who also served in the state legislature from 1926–1938.", new DateTime(1926, 04, 28)},
                    { Guid.NewGuid(), "Stephen", "King", "Stephen Edwin King was born in Portland, Maine in 1947, the second son of Donald and Nellie Ruth Pillsbury King. After his parents separated when Stephen was a toddler, he and his older brother, David, were raised by his mother. Parts of his childhood were spent in Fort Wayne, Indiana, where his father's family was at the time, and in Stratford, Connecticut.", new DateTime(1947, 09, 21)}
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Author");
        }
    }
}
