namespace project
{
    public class Clinic
    {
        public string ClinicName { get; set; }

        public string ClinicAdress { get; set; }

        public int CostForHour { get; set; }

        public Clinic(string clinicName, string clinicAdress, int costForHour)
        {
            ClinicName = clinicName;
            ClinicAdress = clinicAdress;
            CostForHour = costForHour;
        }

    }
}
