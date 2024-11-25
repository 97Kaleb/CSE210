public class Assignment{
    string student;
    string topic;
    public Assignment(string student, string topic){
        this.student = student;
        this.topic = topic;
    }
    public string GetSummary(){
        return $"{student} : {topic}";
    }
    public string GetStudent(){
        return student;
    }
}