using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookRentalObject.Migrations
{
    public partial class SyncDocuTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    authorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.authorId);
                });

            migrationBuilder.CreateTable(
                name: "Availability Status",
                columns: table => new
                {
                    availabiltyStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    availabilityStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Availability Status", x => x.availabiltyStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Book Condition",
                columns: table => new
                {
                    bookConditionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    returnCondition = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book Condition", x => x.bookConditionId);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    categoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.categoryId);
                });

            migrationBuilder.CreateTable(
                name: "Extra Charges",
                columns: table => new
                {
                    extraChargesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    extra_charge_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Extra_charge_rate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extra Charges", x => x.extraChargesId);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    imageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imageName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BLOB = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    imageType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.imageID);
                });

            migrationBuilder.CreateTable(
                name: "Payment Method",
                columns: table => new
                {
                    paymentMethodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paymentMethod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment Method", x => x.paymentMethodId);
                });

            migrationBuilder.CreateTable(
                name: "Payment Status",
                columns: table => new
                {
                    paymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paymentStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment Status", x => x.paymentId);
                });

            migrationBuilder.CreateTable(
                name: "Rental Request Status",
                columns: table => new
                {
                    rentalRequestStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rental Request Status", x => x.rentalRequestStatusId);
                });

            migrationBuilder.CreateTable(
                name: "User Role",
                columns: table => new
                {
                    userRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User Role", x => x.userRoleId);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    bookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    categoryId = table.Column<int>(type: "int", nullable: false),
                    rentalPrice = table.Column<double>(type: "float", nullable: false),
                    bookConditionId = table.Column<int>(type: "int", nullable: false),
                    availabilityStatusId = table.Column<int>(type: "int", nullable: false),
                    authorId = table.Column<int>(type: "int", nullable: false),
                    publishDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ISBN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    imageID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.bookId);
                    table.ForeignKey(
                        name: "FK_Book_Author",
                        column: x => x.authorId,
                        principalTable: "Author",
                        principalColumn: "authorId");
                    table.ForeignKey(
                        name: "FK_Book_Availability Status",
                        column: x => x.availabilityStatusId,
                        principalTable: "Availability Status",
                        principalColumn: "availabiltyStatusId");
                    table.ForeignKey(
                        name: "FK_Book_Category",
                        column: x => x.categoryId,
                        principalTable: "Category",
                        principalColumn: "categoryId");
                    table.ForeignKey(
                        name: "FK_Book_Image",
                        column: x => x.imageID,
                        principalTable: "Image",
                        principalColumn: "imageID");
                    table.ForeignKey(
                        name: "FK_Equipment_Equipment Condition",
                        column: x => x.bookConditionId,
                        principalTable: "Book Condition",
                        principalColumn: "bookConditionId");
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    userRoleId = table.Column<int>(type: "int", nullable: false),
                    contactNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.userId);
                    table.ForeignKey(
                        name: "FK_User_User Role",
                        column: x => x.userRoleId,
                        principalTable: "User Role",
                        principalColumn: "userRoleId");
                });

            migrationBuilder.CreateTable(
                name: "Audit Trails",
                columns: table => new
                {
                    auditId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    timestamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    oldValue = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    newValue = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AUDIT_TRAILS", x => x.auditId);
                    table.ForeignKey(
                        name: "FK_AUDIT_TRAILS_User",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    logId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<int>(type: "int", nullable: false),
                    timestamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    affectedData = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    source = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    exceptions = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.logId);
                    table.ForeignKey(
                        name: "FK_Log_User",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    notificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subject = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    message = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.notificationId);
                    table.ForeignKey(
                        name: "FK_Notification_User",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateTable(
                name: "Rental Request",
                columns: table => new
                {
                    requestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<int>(type: "int", nullable: false),
                    rentalRequestStatusId = table.Column<int>(type: "int", nullable: false),
                    bookId = table.Column<int>(type: "int", nullable: false),
                    rentalStartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    totalCost = table.Column<double>(type: "float", nullable: false),
                    returnDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rental Request", x => x.requestId);
                    table.ForeignKey(
                        name: "FK_Rental Request_Equipment",
                        column: x => x.bookId,
                        principalTable: "Book",
                        principalColumn: "bookId");
                    table.ForeignKey(
                        name: "FK_Rental Request_Rental Request Status",
                        column: x => x.rentalRequestStatusId,
                        principalTable: "Rental Request Status",
                        principalColumn: "rentalRequestStatusId");
                    table.ForeignKey(
                        name: "FK_Rental Request_User",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateTable(
                name: "Rental Transaction",
                columns: table => new
                {
                    transactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookId = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false),
                    rentalStartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    returnDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    rentalFee = table.Column<double>(type: "float", nullable: false),
                    paymentMethodId = table.Column<int>(type: "int", nullable: false),
                    paymentStatusId = table.Column<int>(type: "int", nullable: false),
                    rentalPeriod = table.Column<int>(type: "int", nullable: false),
                    isReturned = table.Column<bool>(type: "bit", nullable: false),
                    rentalRequestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rental Transaction", x => x.transactionId);
                    table.ForeignKey(
                        name: "FK_Rental Transaction_Book",
                        column: x => x.bookId,
                        principalTable: "Book",
                        principalColumn: "bookId");
                    table.ForeignKey(
                        name: "FK_Rental Transaction_Payment Method",
                        column: x => x.paymentMethodId,
                        principalTable: "Payment Method",
                        principalColumn: "paymentMethodId");
                    table.ForeignKey(
                        name: "FK_Rental Transaction_Payment Status",
                        column: x => x.paymentStatusId,
                        principalTable: "Payment Status",
                        principalColumn: "paymentId");
                    table.ForeignKey(
                        name: "FK_Rental Transaction_User",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateTable(
                name: "Suggestion",
                columns: table => new
                {
                    suggestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<int>(type: "int", nullable: false),
                    subject = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suggestion", x => x.suggestionId);
                    table.ForeignKey(
                        name: "FK_Suggestion_User",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    documentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    uploadDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    fileName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BLOB = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    rentalRequestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.documentId);
                    table.ForeignKey(
                        name: "FK_Document_RentalRequest2",
                        column: x => x.rentalRequestId,
                        principalTable: "Rental Request",
                        principalColumn: "requestId");
                });

            migrationBuilder.CreateTable(
                name: "Return Records",
                columns: table => new
                {
                    recordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    expectedReturnDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    actualReturnDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    totalAdditionalCharges = table.Column<double>(type: "float", nullable: false),
                    lateReturnFee = table.Column<double>(type: "float", nullable: false),
                    bookId = table.Column<int>(type: "int", nullable: false),
                    bookConditionId = table.Column<int>(type: "int", nullable: false),
                    transactionId = table.Column<int>(type: "int", nullable: false),
                    extraChargesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Return Records", x => x.recordId);
                    table.ForeignKey(
                        name: "FK_Return Records_Equipment",
                        column: x => x.bookId,
                        principalTable: "Book",
                        principalColumn: "bookId");
                    table.ForeignKey(
                        name: "FK_Return Records_Equipment Condition",
                        column: x => x.bookConditionId,
                        principalTable: "Book Condition",
                        principalColumn: "bookConditionId");
                    table.ForeignKey(
                        name: "FK_Return Records_Extra Charges",
                        column: x => x.extraChargesId,
                        principalTable: "Extra Charges",
                        principalColumn: "extraChargesId");
                    table.ForeignKey(
                        name: "FK_Return Records_Rental Transaction",
                        column: x => x.transactionId,
                        principalTable: "Rental Transaction",
                        principalColumn: "transactionId");
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    feedbackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    timestamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    comment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    rate = table.Column<int>(type: "int", nullable: false),
                    bookId = table.Column<int>(type: "int", nullable: false),
                    isHidden = table.Column<bool>(type: "bit", nullable: false),
                    returnRecordId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.feedbackId);
                    table.ForeignKey(
                        name: "FK_Feedback_Book",
                        column: x => x.bookId,
                        principalTable: "Book",
                        principalColumn: "bookId");
                    table.ForeignKey(
                        name: "FK_Feedback_ReturnRecords",
                        column: x => x.returnRecordId,
                        principalTable: "Return Records",
                        principalColumn: "recordId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Audit Trails_userId",
                table: "Audit Trails",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_authorId",
                table: "Book",
                column: "authorId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_availabilityStatusId",
                table: "Book",
                column: "availabilityStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_bookConditionId",
                table: "Book",
                column: "bookConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_categoryId",
                table: "Book",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_imageID",
                table: "Book",
                column: "imageID");

            migrationBuilder.CreateIndex(
                name: "IX_Document_rentalRequestId",
                table: "Document",
                column: "rentalRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_bookId",
                table: "Feedback",
                column: "bookId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_returnRecordId",
                table: "Feedback",
                column: "returnRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Log_userId",
                table: "Log",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_userId",
                table: "Notification",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Rental Request_bookId",
                table: "Rental Request",
                column: "bookId");

            migrationBuilder.CreateIndex(
                name: "IX_Rental Request_rentalRequestStatusId",
                table: "Rental Request",
                column: "rentalRequestStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Rental Request_userId",
                table: "Rental Request",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Rental Transaction_bookId",
                table: "Rental Transaction",
                column: "bookId");

            migrationBuilder.CreateIndex(
                name: "IX_Rental Transaction_paymentMethodId",
                table: "Rental Transaction",
                column: "paymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Rental Transaction_paymentStatusId",
                table: "Rental Transaction",
                column: "paymentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Rental Transaction_userId",
                table: "Rental Transaction",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Return Records_bookConditionId",
                table: "Return Records",
                column: "bookConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Return Records_bookId",
                table: "Return Records",
                column: "bookId");

            migrationBuilder.CreateIndex(
                name: "IX_Return Records_extraChargesId",
                table: "Return Records",
                column: "extraChargesId");

            migrationBuilder.CreateIndex(
                name: "IX_Return Records_transactionId",
                table: "Return Records",
                column: "transactionId");

            migrationBuilder.CreateIndex(
                name: "IX_Suggestion_userId",
                table: "Suggestion",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_User_userRoleId",
                table: "User",
                column: "userRoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Audit Trails");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "Suggestion");

            migrationBuilder.DropTable(
                name: "Rental Request");

            migrationBuilder.DropTable(
                name: "Return Records");

            migrationBuilder.DropTable(
                name: "Rental Request Status");

            migrationBuilder.DropTable(
                name: "Extra Charges");

            migrationBuilder.DropTable(
                name: "Rental Transaction");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Payment Method");

            migrationBuilder.DropTable(
                name: "Payment Status");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Availability Status");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Book Condition");

            migrationBuilder.DropTable(
                name: "User Role");
        }
    }
}
