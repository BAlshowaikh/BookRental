using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace FormApp.Controllers
{
        public static class HelperFunctions {
        // Create a method that set up the new form design
        public static void setUpFormDesign(Form form)
        {
            // Remove default controls and set the the screen to be in the center
            form.ControlBox = false;
            form.StartPosition = FormStartPosition.CenterScreen;


            // Adjust the form size
            form.Width = 1000;
            form.Height = 700;
            form.Size = new Size(1000, 700);

            // Prevent any resizing
            form.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Set image layout to strech so it doesn't messed up
            form.BackgroundImageLayout = ImageLayout.Stretch;

            // Function to specify the size for (Add, edit, delete) buttons
            
        }


    }
}
