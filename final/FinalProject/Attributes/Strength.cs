public class Strength(string name, int score) : Attribute(name, score){
    string athlProf = " ";
    int athlScore;
    public override string GetSkill(int skillNum, int prof)
    {
        if (skillNum == 4){
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
        }else{
            return null;
        }
    }
    public void AddSkillProf(int skillNum, string profType){
        if (skillNum == 4){
            athlProf = profType;
        }
    }
}