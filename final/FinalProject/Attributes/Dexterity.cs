public class Dexterity(string name, int score) : Attribute(name, score){
    string acroProf = " ";
    int acroScore;
    string sleiProf = " ";
    int sleiScore;
    string steaProf = " ";
    int steaScore;
    public override string GetSkill(int skillNum, int prof)
    {
        if (skillNum == 1){
            if (acroProf == "x"){
                acroScore = mod + (prof * 2);
            }else if (acroProf == "o"){
                acroScore = mod + prof;
            }else{
                acroScore = mod;
            }
            if (acroScore >= 0){
                return $"{acroProf} Acrobatics: {acroScore}\n";
            }else{
                return $"{acroProf} Acrobatics: {acroScore}\n";
            }
        }else if (skillNum == 16){
            if (sleiProf == "x"){
                sleiScore = mod + (prof * 2);
            }else if (sleiProf == "o"){
                sleiScore = mod + prof;
            }else{
                sleiScore = mod;
            }
            if (sleiScore >= 0){
                return $"{sleiProf} Slight of Hand: {sleiScore}\n";
            }else{
                return $"{sleiProf} Slight of Hand: {sleiScore}\n";
            }
        }else if (skillNum == 17){
            if (steaProf == "x"){
                steaScore = mod + (prof * 2);
            }else if (steaProf == "o"){
                steaScore = mod + prof;
            }else{
                steaScore = mod;
            }
            if (steaScore >= 0){
                return $"{steaProf} Stealth: {steaScore}\n";
            }else{
                return $"{steaProf} Stealth: {steaScore}\n";
            }
        }else{
            return null;
        }
    }
    public void AddSkillProf(int skillNum, string profType){
        if (skillNum == 1){
            acroProf = profType;
        }else if (skillNum == 16){
            sleiProf = profType;
        }else if (skillNum == 17){
            steaProf = profType;
        }
    }
}