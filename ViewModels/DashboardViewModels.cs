namespace School_Management_System.ViewModels
{
    public class DashboardViewModel
    {
        // Các con số thống kê
        public int StudentCount { get; set; }
        public int TeacherCount { get; set; }
        public int ClassCount { get; set; }
        public int UserCount { get; set; }
        public int UnpaidFeesCount { get; set; }

        // Dữ liệu mảng để vẽ biểu đồ
        public List<string> ChartLabels { get; set; } = new List<string>();
        public List<int> ChartData { get; set; } = new List<int>();
    }
}