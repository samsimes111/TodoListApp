namespace AppTodoList
{
    public class CustomTask
    {
        public int ID { get; set; }
        public required string ThongTin { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Done { get; set; }
    }
}
