namespace gluschKt_42_20.Model
{
    public class Grade
    {
        public int GradeId { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public string StudentGrade { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }
    }
}
