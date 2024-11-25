public class WritingAssignment : Assignment{
    string title;
    string student;
    public WritingAssignment(string student, string topic, string title) : base(student, topic){
        this.title = title;
        this.student = student;
    }
    public string GetWriting(){
        return $"{title} by {student}";
    }
}