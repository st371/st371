namespace project
{
    public class Turn
    {
        public string ClinicName { get; set; }
        public DateTime StartHour { get; set; }
        public DateTime EndHour { get; set; }

        public int Day {  get; set; }

        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int TenantCode { get; set; }

        public Turn(string clinicName, TimeOnly startHour, TimeOnly endHour, int day, DateOnly dateStart, DateOnly dateEnd, int tenantCode)
        {
            ClinicName = clinicName;
            StartHour = startHour;
            EndHour = endHour;
            Day = day;
            DateStart = dateStart;
            DateEnd = dateEnd;
            TenantCode = tenantCode;
        }
    }
}
