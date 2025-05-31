namespace RestaurantApp
{ 
    public static class Program
    {
        public static RestaurantManagement.Models.ApplicationUser CurrentUser { get; set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RestaurantManagementApp.Forms.LoginForm());
        }
    }
}