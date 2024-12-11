public class Wisdom(string name, int score) : Attribute(name, score){
    string animProf = " ";
    int animScore;
    string insiProf = " ";
    int insiScore;
    string mediProf = " ";
    int mediScore;
    string percProf = " ";
    int percScore;
    string survProf = " ";
    int survScore;
    public override string GetSkill(int skillNum, int prof)
    {
        if (skillNum == 2){
            if (animProf == "x"){
                animScore = mod + (prof * 2);
            }else if (animProf == "o"){
                animScore = mod + prof;
            }else{
                animScore = mod;
            }
            if (animScore >= 0){
                return $"{animProf} Athletics : {animScore}\n";
            }else{
                return $"{animProf} Athletics : {animScore}\n";
            }
        }else if (skillNum == 7){
            if (insiProf == "x"){
                insiScore = mod + (prof * 2);
            }else if (insiProf == "o"){
                insiScore = mod + prof;
            }else{
                insiScore = mod;
            }
            if (insiScore >= 0){
                return $"{insiProf} Athletics : {insiScore}\n";
            }else{
                return $"{insiProf} Athletics : {insiScore}\n";
            }
        }else if (skillNum == 10){
            if (mediProf == "x"){
                mediScore = mod + (prof * 2);
            }else if (mediProf == "o"){
                mediScore = mod + prof;
            }else{
                mediScore = mod;
            }
            if (mediScore >= 0){
                return $"{mediProf} Athletics : {mediScore}\n";
            }else{
                return $"{mediProf} Athletics : {mediScore}\n";
            }
        }else if (skillNum == 12){
            if (percProf == "x"){
                percScore = mod + (prof * 2);
            }else if (percProf == "o"){
                percScore = mod + prof;
            }else{
                percScore = mod;
            }
            if (percScore >= 0){
                return $"{percProf} Athletics : {percScore}\n";
            }else{
                return $"{percProf} Athletics : {percScore}\n";
            }
        }else if (skillNum == 18){
            if (survProf == "x"){
                survScore = mod + (prof * 2);
            }else if (survProf == "o"){
                survScore = mod + prof;
            }else{
                survScore = mod;
            }
            if (survScore >= 0){
                return $"{survProf} Athletics : {survScore}\n";
            }else{
                return $"{survProf} Athletics : {survScore}\n";
            }
        }else{
            return null;
        }
    }
    public void AddSkillProf(int skillNum, string profType){
        if (skillNum == 2){
            animProf = profType;
        }else if (skillNum == 7){
            insiProf = profType;
        }else if (skillNum == 10){
            mediProf = profType;
        }else if (skillNum == 12){
            percProf = profType;
        }else if (skillNum == 18){
            survProf = profType;
        }
    }
}