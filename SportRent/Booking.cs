namespace SportRent.Models
{
    public class Booking
    {
        public string ItemName { get; set; }
        public System.DateTime Date { get; set; }
        public int Hours { get; set; }

        public override string ToString()
        {
            return $"{ItemName} - {Date.ToShortDateString()} на {Hours} ч.";
        }
    }
}
