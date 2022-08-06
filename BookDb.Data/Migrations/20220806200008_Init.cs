using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookDb.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Book");

            migrationBuilder.EnsureSchema(
                name: "People");

            migrationBuilder.CreateTable(
                name: "Books",
                schema: "Book",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CreatorTypes",
                schema: "Book",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatorTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Name",
                schema: "People",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Suffix = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Prefix = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Name", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                schema: "Book",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stories",
                schema: "Book",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Series = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SeriesOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Creators",
                schema: "Book",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Creators_Name_NameModelId",
                        column: x => x.NameModelId,
                        principalSchema: "People",
                        principalTable: "Name",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Editions",
                schema: "Book",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    PublishedById = table.Column<long>(type: "bigint", nullable: false),
                    PublishedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Editions_Publishers_PublishedById",
                        column: x => x.PublishedById,
                        principalSchema: "Book",
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookStories",
                schema: "Book",
                columns: table => new
                {
                    BooksId = table.Column<long>(type: "bigint", nullable: false),
                    StoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookStories", x => new { x.BooksId, x.StoriesId });
                    table.ForeignKey(
                        name: "FK_BookStories_Books_BooksId",
                        column: x => x.BooksId,
                        principalSchema: "Book",
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookStories_Stories_StoriesId",
                        column: x => x.StoriesId,
                        principalSchema: "Book",
                        principalTable: "Stories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                schema: "Book",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    StoryModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Genres_Stories_StoryModelId",
                        column: x => x.StoryModelId,
                        principalSchema: "Book",
                        principalTable: "Stories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BookCreators",
                schema: "Book",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatorModelId = table.Column<long>(type: "bigint", nullable: false),
                    TypeModelId = table.Column<long>(type: "bigint", nullable: false),
                    StoryModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCreators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookCreators_Creators_CreatorModelId",
                        column: x => x.CreatorModelId,
                        principalSchema: "Book",
                        principalTable: "Creators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCreators_CreatorTypes_TypeModelId",
                        column: x => x.TypeModelId,
                        principalSchema: "Book",
                        principalTable: "CreatorTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCreators_Stories_StoryModelId",
                        column: x => x.StoryModelId,
                        principalSchema: "Book",
                        principalTable: "Stories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookEditions",
                schema: "Book",
                columns: table => new
                {
                    BooksId = table.Column<long>(type: "bigint", nullable: false),
                    EditionsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookEditions", x => new { x.BooksId, x.EditionsId });
                    table.ForeignKey(
                        name: "FK_BookEditions_Books_BooksId",
                        column: x => x.BooksId,
                        principalSchema: "Book",
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookEditions_Editions_EditionsId",
                        column: x => x.EditionsId,
                        principalSchema: "Book",
                        principalTable: "Editions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookCreators_CreatorModelId",
                schema: "Book",
                table: "BookCreators",
                column: "CreatorModelId");

            migrationBuilder.CreateIndex(
                name: "IX_BookCreators_StoryModelId",
                schema: "Book",
                table: "BookCreators",
                column: "StoryModelId");

            migrationBuilder.CreateIndex(
                name: "IX_BookCreators_TypeModelId",
                schema: "Book",
                table: "BookCreators",
                column: "TypeModelId");

            migrationBuilder.CreateIndex(
                name: "IX_BookEditions_EditionsId",
                schema: "Book",
                table: "BookEditions",
                column: "EditionsId");

            migrationBuilder.CreateIndex(
                name: "IX_BookStories_StoriesId",
                schema: "Book",
                table: "BookStories",
                column: "StoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Creators_NameModelId",
                schema: "Book",
                table: "Creators",
                column: "NameModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Editions_PublishedById",
                schema: "Book",
                table: "Editions",
                column: "PublishedById");

            migrationBuilder.CreateIndex(
                name: "IX_Genres_StoryModelId",
                schema: "Book",
                table: "Genres",
                column: "StoryModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookCreators",
                schema: "Book");

            migrationBuilder.DropTable(
                name: "BookEditions",
                schema: "Book");

            migrationBuilder.DropTable(
                name: "BookStories",
                schema: "Book");

            migrationBuilder.DropTable(
                name: "Genres",
                schema: "Book");

            migrationBuilder.DropTable(
                name: "Creators",
                schema: "Book");

            migrationBuilder.DropTable(
                name: "CreatorTypes",
                schema: "Book");

            migrationBuilder.DropTable(
                name: "Editions",
                schema: "Book");

            migrationBuilder.DropTable(
                name: "Books",
                schema: "Book");

            migrationBuilder.DropTable(
                name: "Stories",
                schema: "Book");

            migrationBuilder.DropTable(
                name: "Name",
                schema: "People");

            migrationBuilder.DropTable(
                name: "Publishers",
                schema: "Book");
        }
    }
}
