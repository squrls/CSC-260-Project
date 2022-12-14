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
            var Harry = new Operator("Harry", true);
            var Bobo = new Operator("Bobo");
            Operator Jimmy = new Operator("Jimmy");
            List<Operator> operators = new List<Operator>
            {
                Harry,
                Bobo,
                Jimmy
            };


            var lawnmower = new Equipment("Lawnmower");
            var weedeater = new Equipment("weedeater");
            var f150 = new Vehicle("f150");
            var powerglove = new Equipment("Power Glove 500000000");
            var potato = new Equipment("potato");
            var moreequip = new Equipment("moreequip");
            List<Equipment> equipments = new List<Equipment>
            {
                lawnmower,
                weedeater,
                f150,
                powerglove,
                potato, 
                moreequip
            };

            Harry.CheckoutEquipment(lawnmower);
            Harry.CheckoutEquipment(weedeater);
            Harry.CheckoutEquipment(f150);
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
            if (selectedUserName == "Admin")
            {
                System.Windows.Forms.MessageBox.Show("The admin features are not fully implemented");
            }
            var SelectedUser = operators.Find(x => x.Name.Contains(selectedUserName));

            Application.Run(new UserInterface(SelectedUser, equipments));
            

        }
    }
}