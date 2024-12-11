public class Strength(string name, int score) : Attribute(name, score){
    string athlProf = " ";
    int athlScore;
    public override string GetSkill(int skillNum, int prof)
    {
        if (athlProf == "x"){
            athlScore = mod + (prof * 2);
        }else if (athlProf == "o"){
            athlScore = mod + prof;
        }else{
            athlScore = mod;
        }
        if (athlScore >= 0){
            return $"{athlProf} Athletics : {athlScore}\n";
        }else{
            return $"{athlProf} Athletics : {athlScore}\n";
        }
    }
    public void AddSkillProf(string profType){
        athlProf = profType;
    }
}