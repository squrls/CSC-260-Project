namespace Equipment
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var Harry = new Operator("Harry");
            var lawnmower = new Equipment("Lawnmower");
            var weedeater = new Equipment("weedeater");

            Harry.CheckoutEquipment(lawnmower);
            Harry.CheckoutEquipment(weedeater);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Application.Run(new UserPage());
            string selectedUser = "";
            using (var form = new UserPage())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    selectedUser = form.selectedUser;
                }
            }

            Application.Run(new UserInterface(Harry));
            

        }
    }
}