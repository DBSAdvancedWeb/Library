using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksApi.Migrations
{
    /// <inheritdoc />
    public partial class AddBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AuthorId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Isbn = table.Column<string>(type: "TEXT", nullable: true),
                    Category = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Name", "Isbn", "Category"},
                values: new object[,]
                {
                    { Guid.NewGuid(), Guid.Parse("39e15203-0b6f-4c36-ae77-f5d4cdd24e4c"), "Harry Potter and the Sorcerer's Stone", "9780590353427", "Fantasy" },
                    { Guid.NewGuid(), Guid.Parse("39e15203-0b6f-4c36-ae77-f5d4cdd24e4c"), "Harry Potter and the Chamber of Secrets", "9780439064873", "Fantasy" },
                    { Guid.NewGuid(), Guid.Parse("39e15203-0b6f-4c36-ae77-f5d4cdd24e4c"), "Harry Potter and the Prisoner of Azkaban", "9780439136358", "Fantasy" },
                    { Guid.NewGuid(), Guid.Parse("99cdd610-a7a9-4dc4-9324-5d6b871c64ac"), "Pride and Prejudice", "9780141439518", "Classic" },
                    { Guid.NewGuid(), Guid.Parse("99cdd610-a7a9-4dc4-9324-5d6b871c64ac"), "Sense and Sensibility", "9780141439662", "Classic" },
                    { Guid.NewGuid(), Guid.Parse("99cdd610-a7a9-4dc4-9324-5d6b871c64ac"), "Emma", "9780141439587", "Classic" },
                    { Guid.NewGuid(), Guid.Parse("e6f063cb-0037-44b1-84c4-0a4dcaaddfe3"), "1984", "9780451524935", "Dystopian" },
                    { Guid.NewGuid(), Guid.Parse("e6f063cb-0037-44b1-84c4-0a4dcaaddfe3"), "Animal Farm", "9780452284241", "Dystopian" },
                    { Guid.NewGuid(), Guid.Parse("e6f063cb-0037-44b1-84c4-0a4dcaaddfe3"), "Homage to Catalonia", "9780156421171", "Non-fiction" },
                    { Guid.NewGuid(), Guid.Parse("b6522647-aebe-4ffe-8454-8eabe315a820"), "To Kill a Mockingbird", "9780060935467", "Fiction" },
                    { Guid.NewGuid(), Guid.Parse("b6522647-aebe-4ffe-8454-8eabe315a820"), "Go Set a Watchman", "9780062409867", "Fiction" },
                    { Guid.NewGuid(), Guid.Parse("1727b992-997e-4b7e-b222-9d6cfcedbc5f"), "The Shining", "9780307743657", "Horror" },
                    { Guid.NewGuid(), Guid.Parse("1727b992-997e-4b7e-b222-9d6cfcedbc5f"), "It", "9781501175466", "Horror" },
                    { Guid.NewGuid(), Guid.Parse("1727b992-997e-4b7e-b222-9d6cfcedbc5f"), "The Stand", "9780307743688", "Horror" }
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
