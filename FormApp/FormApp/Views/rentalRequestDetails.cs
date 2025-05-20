using BookRentalObject;
using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using FormApp.Controllers;
using ProjectFormApp;

namespace FormApp.Views
{
    public partial class rentalRequestDetails : Form
    {
        private readonly BookRentalDBContext context = new BookRentalDBContext();
        private readonly int requestID;

        public rentalRequestDetails(int requestID)
        {
            this.requestID = requestID;
            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);
        }

        private async void rentalRequestDetails_Load(object sender, EventArgs e)
        {
            try
            {
                // Use separate context for loading to avoid conflicts
                using (var loadContext = new BookRentalDBContext())
                {
                    var request = await loadContext.RentalRequests
                        .Include(r => r.Book)
                        .ThenInclude(b => b.AvailabilityStatus)
                        .Include(r => r.User)
                        .FirstOrDefaultAsync(x => x.RequestId == requestID);

                    if (request == null) return;

                    txtRequestID.Text = requestID.ToString();
                    txtUserName.Text = request.User?.FullName;
                    lblUserID.Text = "User ID: " + request.UserId.ToString();
                    txtBookID.Text = request.BookId.ToString();
                    txtBookName.Text = request.Book?.Name;
                    lblBookStatus.Text = "This Book is " + request.Book?.AvailabilityStatus?.AvailabilityStatus1;
                    txtStartDate.Text = request.RentalStartDate.ToString();
                    txtReturnDate.Text = request.ReturnDate.ToString();
                    txtTotalCost.Text = request.TotalCost.ToString();

                    var status = await loadContext.RentalRequestStatuses
                        .FirstOrDefaultAsync(x => x.RentalRequestStatusId == request.RentalRequestStatusId);
                    txtStatus.Text = status?.Status;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading request details: " + ex.Message);
            }
        }

        private async void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                using (var approveContext = new BookRentalDBContext())
                {
                    var request = await approveContext.RentalRequests
                        .FirstOrDefaultAsync(x => x.RequestId == requestID);

                    if (request?.RentalRequestStatusId != 1)
                    {
                        MessageBox.Show("This request cannot be approved, it has been " +
                            await GetStatusName(approveContext, request?.RentalRequestStatusId ?? 0));
                        return;
                    }

                    if (MessageBox.Show("Are you sure you want to approve request ID:" + requestID + "?",
                        "Confirm Approval", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        request.RentalRequestStatusId = 2;
                        var statusName = await GetStatusName(approveContext, request.RentalRequestStatusId);

                        var notification = new Notification
                        {
                            UserId = request.UserId,
                            Subject = "Rental Request Update",
                            Message = $"Your rental request status has been updated to: {statusName}.",
                            Status = false
                        };

                        approveContext.Notifications.Add(notification);
                        await approveContext.SaveChangesAsync();

                        this.DialogResult = DialogResult.OK;
                        this.Close();

                        var editTransaction = new EditTransaction(requestID);
                        editTransaction.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                await LogError(ex, "approving rental request");
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnReject_Click(object sender, EventArgs e)
        {
            try
            {
                using (var rejectContext = new BookRentalDBContext())
                {
                    var request = await rejectContext.RentalRequests
                        .FirstOrDefaultAsync(x => x.RequestId == requestID);

                    if (request?.RentalRequestStatusId != 1)
                    {
                        MessageBox.Show("This request cannot be rejected, it has been " +
                            await GetStatusName(rejectContext, request?.RentalRequestStatusId ?? 0));
                        return;
                    }

                    if (MessageBox.Show("Are you sure you want to reject request ID:" + requestID + "?",
                        "Confirm Rejection", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        request.RentalRequestStatusId = 3;
                        var statusName = await GetStatusName(rejectContext, request.RentalRequestStatusId);

                        var notification = new Notification
                        {
                            UserId = request.UserId,
                            Subject = "Rental Request Update",
                            Message = $"Your rental request status has been updated to: {statusName}.",
                            Status = false
                        };

                        rejectContext.Notifications.Add(notification);
                        await rejectContext.SaveChangesAsync();

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                await LogError(ex, "rejecting rental request");
                MessageBox.Show(ex.Message);
            }
        }

        private async Task<string> GetStatusName(BookRentalDBContext dbContext, int statusId)
        {
            var status = await dbContext.RentalRequestStatuses
                .FirstOrDefaultAsync(x => x.RentalRequestStatusId == statusId);
            return status?.Status ?? "Unknown Status";
        }

        private async Task LogError(Exception ex, string action)
        {
            using (var logContext = new BookRentalDBContext())
            {
                var newLog = new Log
                {
                    UserId = Global.user.UserId,
                    Timestamp = DateTime.Now,
                    AffectedData = "rental request",
                    Source = "form app",
                    Exceptions = $"Error {action}: {ex.Message}"
                };

                logContext.Logs.Add(newLog);
                await logContext.SaveChangesAsync();
            }
        }

        private async void Save_Click(object sender, EventArgs e)
        {
            try
            {
                using (var saveContext = new BookRentalDBContext())
                {
                    var request = await saveContext.RentalRequests
                        .FirstOrDefaultAsync(x => x.RequestId == requestID);

                    if (request == null)
                    {
                        MessageBox.Show("Rental request not found.");
                        return;
                    }

                    var oldStartDate = request.RentalStartDate.ToString();
                    var oldReturnDate = request.ReturnDate.ToString();

                    request.RentalStartDate = DateTime.Parse(txtStartDate.Text);
                    request.ReturnDate = DateTime.Parse(txtReturnDate.Text);

                    TrackAuditChange(oldStartDate, request.RentalStartDate.ToString(), Global.user.UserId);
                    TrackAuditChange(oldReturnDate, request.ReturnDate.ToString(), Global.user.UserId);

                    await saveContext.SaveChangesAsync();
                    MessageBox.Show("Rental Request updated successfully.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid date formats.");
            }
            catch (Exception ex)
            {
                await LogError(ex, "saving rental request changes");
                MessageBox.Show("Failed to update: " + ex.Message);
            }
        }

        private void TrackAuditChange(string oldValue, string newValue, int userId)
        {
            if (oldValue != newValue)
            {
                context.AuditTrails.Add(new AuditTrail
                {
                    Timestamp = DateTime.Now,
                    OldValue = oldValue,
                    NewValue = newValue,
                    UserId = userId
                });
            }
        }

        private void homeIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.homePageBtn(this);
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.exitBtn();
        }

        private void userIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.ShowProfilePage(this);
        }
    }
}