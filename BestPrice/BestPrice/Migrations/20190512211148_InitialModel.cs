using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BestPrice.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.EnsureSchema(
            //    name: "prj666_192a03");

            //migrationBuilder.CreateTable(
            //    name: "FAQs",
            //    schema: "prj666_192a03",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int(10)", nullable: false),
            //        Question = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        Answer = table.Column<string>(unicode: false, maxLength: 150, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FAQs", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Locations",
            //    schema: "prj666_192a03",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int(10)", nullable: false),
            //        Address = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        Province = table.Column<string>(unicode: false, maxLength: 25, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Locations", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Sellers",
            //    schema: "prj666_192a03",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int(10)", nullable: false),
            //        Name = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
            //        Link = table.Column<string>(unicode: false, maxLength: 200, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Sellers", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Users",
            //    schema: "prj666_192a03",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int(10)", nullable: false),
            //        Email = table.Column<string>(unicode: false, maxLength: 75, nullable: false),
            //        Password = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
            //        LocationId = table.Column<int>(type: "int(10)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Users", x => x.Id);
            //        table.ForeignKey(
            //            name: "User_LocationId_FK",
            //            column: x => x.LocationId,
            //            principalSchema: "prj666_192a03",
            //            principalTable: "Locations",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Products",
            //    schema: "prj666_192a03",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int(10)", nullable: false),
            //        Name = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
            //        CurrentPrice = table.Column<decimal>(type: "decimal(10,0)", nullable: false),
            //        BeforePrice = table.Column<decimal>(type: "decimal(10,0)", nullable: false),
            //        SellerId = table.Column<int>(type: "int(10)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Products", x => x.Id);
            //        table.ForeignKey(
            //            name: "Product_SellerId_FK",
            //            column: x => x.SellerId,
            //            principalSchema: "prj666_192a03",
            //            principalTable: "Sellers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SearchHistories",
            //    schema: "prj666_192a03",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int(10)", nullable: false),
            //        Name = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
            //        Date = table.Column<DateTime>(nullable: false),
            //        UserId = table.Column<int>(type: "int(10)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SearchHistories", x => x.Id);
            //        table.ForeignKey(
            //            name: "SearchHistory_UserId_FK",
            //            column: x => x.UserId,
            //            principalSchema: "prj666_192a03",
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Wishlists",
            //    schema: "prj666_192a03",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int(10)", nullable: false),
            //        UserId = table.Column<int>(type: "int(10)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Wishlists", x => x.Id);
            //        table.ForeignKey(
            //            name: "Wishlist_UserId_FK",
            //            column: x => x.UserId,
            //            principalSchema: "prj666_192a03",
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Notifications",
            //    schema: "prj666_192a03",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int(10)", nullable: false),
            //        TimeStamp = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "1970-01-01 00:00:01"),
            //        ProductId = table.Column<int>(type: "int(10)", nullable: false),
            //        UserId = table.Column<int>(type: "int(10)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Notifications", x => x.Id);
            //        table.ForeignKey(
            //            name: "Notification_ProductId_FK",
            //            column: x => x.ProductId,
            //            principalSchema: "prj666_192a03",
            //            principalTable: "Products",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "Notification_UserId_FK",
            //            column: x => x.UserId,
            //            principalSchema: "prj666_192a03",
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Reviews",
            //    schema: "prj666_192a03",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int(10)", nullable: false),
            //        Description = table.Column<string>(unicode: false, maxLength: 1500, nullable: false),
            //        Rating = table.Column<string>(type: "enum('1','2','3','4','5')", nullable: true),
            //        ProductId = table.Column<int>(type: "int(10)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Reviews", x => x.Id);
            //        table.ForeignKey(
            //            name: "Review_ProductId_FK",
            //            column: x => x.ProductId,
            //            principalSchema: "prj666_192a03",
            //            principalTable: "Products",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "WishlistProduct",
            //    schema: "prj666_192a03",
            //    columns: table => new
            //    {
            //        ProductId = table.Column<int>(type: "int(10)", nullable: false),
            //        WishlistId = table.Column<int>(type: "int(10)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_WishlistProduct", x => new { x.ProductId, x.WishlistId });
            //        table.ForeignKey(
            //            name: "WishlistProduct_ProductId_FK",
            //            column: x => x.ProductId,
            //            principalSchema: "prj666_192a03",
            //            principalTable: "Products",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "WishlistProduct_WishlistId_FK",
            //            column: x => x.WishlistId,
            //            principalSchema: "prj666_192a03",
            //            principalTable: "Wishlists",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "Address",
            //    schema: "prj666_192a03",
            //    table: "Locations",
            //    column: "Address",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "Notification_UserId_FK",
            //    schema: "prj666_192a03",
            //    table: "Notifications",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "ProductId",
            //    schema: "prj666_192a03",
            //    table: "Notifications",
            //    columns: new[] { "ProductId", "UserId" });

            //migrationBuilder.CreateIndex(
            //    name: "SellerId",
            //    schema: "prj666_192a03",
            //    table: "Products",
            //    column: "SellerId");

            //migrationBuilder.CreateIndex(
            //    name: "ProductId",
            //    schema: "prj666_192a03",
            //    table: "Reviews",
            //    column: "ProductId");

            //migrationBuilder.CreateIndex(
            //    name: "UserId",
            //    schema: "prj666_192a03",
            //    table: "SearchHistories",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "Name",
            //    schema: "prj666_192a03",
            //    table: "Sellers",
            //    column: "Name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "Email",
            //    schema: "prj666_192a03",
            //    table: "Users",
            //    column: "Email",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "NotificationId",
            //    schema: "prj666_192a03",
            //    table: "Users",
            //    column: "LocationId");

            //migrationBuilder.CreateIndex(
            //    name: "WishlistProduct_WishlistId_FK",
            //    schema: "prj666_192a03",
            //    table: "WishlistProduct",
            //    column: "WishlistId");

            //migrationBuilder.CreateIndex(
            //    name: "ProductId",
            //    schema: "prj666_192a03",
            //    table: "WishlistProduct",
            //    columns: new[] { "ProductId", "WishlistId" });

            //migrationBuilder.CreateIndex(
            //    name: "UserId",
            //    schema: "prj666_192a03",
            //    table: "Wishlists",
            //    column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "FAQs",
            //    schema: "prj666_192a03");

            //migrationBuilder.DropTable(
            //    name: "Notifications",
            //    schema: "prj666_192a03");

            //migrationBuilder.DropTable(
            //    name: "Reviews",
            //    schema: "prj666_192a03");

            //migrationBuilder.DropTable(
            //    name: "SearchHistories",
            //    schema: "prj666_192a03");

            //migrationBuilder.DropTable(
            //    name: "WishlistProduct",
            //    schema: "prj666_192a03");

            //migrationBuilder.DropTable(
            //    name: "Products",
            //    schema: "prj666_192a03");

            //migrationBuilder.DropTable(
            //    name: "Wishlists",
            //    schema: "prj666_192a03");

            //migrationBuilder.DropTable(
            //    name: "Sellers",
            //    schema: "prj666_192a03");

            //migrationBuilder.DropTable(
            //    name: "Users",
            //    schema: "prj666_192a03");

            //migrationBuilder.DropTable(
            //    name: "Locations",
            //    schema: "prj666_192a03");
        }
    }
}
