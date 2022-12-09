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
            var Bobo = new Operator("Bobo");
            List<Operator> operators = new List<Operator>();
            operators.Add(Harry);
            operators.Add(Bobo);


            var lawnmower = new Equipment("Lawnmower");
            var weedeater = new Equipment("weedeater");

            Harry.CheckoutEquipment(lawnmower);
            Harry.CheckoutEquipment(weedeater);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Application.Run(new UserPage());
            string selectedUserName = "";
            using (var form = new UserPage(operators))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    selectedUserName = form.selectedUser;
                }
            }
            var SelectedUser = operators.Find(x => x.Name.Contains(selectedUserName));

            Application.Run(new UserInterface(SelectedUser));
            

        }
    }
}