using BookRentalObject;
using FormApp.Controllers;
using FormApp.Views;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using ProjectFormApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace FormApp
{
    public partial class Login : Form
    {
        BookRentalDBContext context;
        private IServiceProvider serviceProvider;
        public Login()
        {
            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);

            BookRentalDBContext context = new BookRentalDBContext();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            //comment
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            var signInResults = await VerifyUserNamePassword(txtUserEmail.Text, txtPassword.Text);
            if (signInResults == true) //if user is verified
            {
                if (Global.RoleName == "Admin")
                {
                    homePageAdmin home = new homePageAdmin();
                    this.Hide();
                    home.Show();
                }
                else if (Global.RoleName == "Manager"|| Global.RoleName == "Technician")
                {
                    homePageStaff home = new homePageStaff();
                    this.Hide();
                    home.Show();
                }
                else {
                    MessageBox.Show("Error. You can not access this form app");

                }
            }
            else
            {
                MessageBox.Show("Error. The username or password are not correct");
            }

        }
        public async Task<bool> VerifyUserNamePassword(string userName, string password)
        {
            try
            {


                var services = new ServiceCollection();
                ConfigureServices(services);
                serviceProvider = services.BuildServiceProvider();

                var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
                var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                var founduser = await userManager.FindByEmailAsync(txtUserEmail.Text);

                if (founduser != null)
                {
                    var passCheck = await userManager.CheckPasswordAsync(founduser, password) == true;

                    if (passCheck)
                    {
                        var roles = await userManager.GetRolesAsync(founduser);

                        //save into global class
                        Global.identityUser = founduser;

                        Global.RoleName = roles.FirstOrDefault();

                        Global.user = context.Users.Where(x => x.Email == userName).FirstOrDefault();
                    }
                    return passCheck;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                return false;
            }
        }

        private void ConfigureServices(IServiceCollection services)
        {
            try
            {
                services.AddEntityFrameworkSqlServer()
                    .AddDbContext<FormsIdentityContext>();

                // Register UserManager & RoleManager
                services.AddIdentity<IdentityUser, IdentityRole>()
                   .AddEntityFrameworkStores<FormsIdentityContext>()
                   .AddDefaultTokenProviders();

                // UserManager & RoleManager require logging and HttpContext dependencies
                services.AddLogging();
                services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }
    }
}