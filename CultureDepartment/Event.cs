namespace CultureDepartment
{
    enum status { past,future,cancel};
    public class Event
    {
        private static int id = 0;
        public int Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }

        public Event()=>Id = id++;
    }
}
