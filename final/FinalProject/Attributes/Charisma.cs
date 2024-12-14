public class Charisma(string name, int score) : Attribute(name, score){
    string deceProf = " ";
    int deceScore;
    string intiProf = " ";
    int intiScore;
    string perfProf = " ";
    int perfScore;
    string persProf = " ";
    int persScore;
    public override string GetSkill(int skillNum, int prof)
    {
        if (skillNum == 5){
            if (deceProf == "x"){
                deceScore = mod + (prof * 2);
            }else if (deceProf == "o"){
                deceScore = mod + prof;
            }else{
                deceScore = mod;
            }
            if (deceScore >= 0){
                return $"{deceProf} Deception: {deceScore}\n";
            }else{
                return $"{deceProf} Deception: {deceScore}\n";
            }
        }else if (skillNum == 6){
            if (intiProf == "x"){
                intiScore = mod + (prof * 2);
            }else if (intiProf == "o"){
                intiScore = mod + prof;
            }else{
                intiScore = mod;
            }
            if (intiScore >= 0){
                return $"{intiProf} Intimidation: {intiScore}\n";
            }else{
                return $"{intiProf} Intimidation: {intiScore}\n";
            }
        }else if (skillNum == 9){
            if (perfProf == "x"){
                perfScore = mod + (prof * 2);
            }else if (perfProf == "o"){
                perfScore = mod + prof;
            }else{
                perfScore = mod;
            }
            if (perfScore >= 0){
                return $"{perfProf} Performance: {perfScore}\n";
            }else{
                return $"{perfProf} Performance: {perfScore}\n";
            }
        }else if (skillNum == 11){
            if (persProf == "x"){
                persScore = mod + (prof * 2);
            }else if (persProf == "o"){
                persScore = mod + prof;
            }else{
                persScore = mod;
            }
            if (persScore >= 0){
                return $"{persProf} Persuasion: {persScore}\n";
            }else{
                return $"{persProf} Persuasion: {persScore}\n";
            }
        }else{
            return null;
        }
    }
    public void AddSkillProf(int skillNum, string profType){
        if (skillNum == 3){
            deceProf = profType;
        }else if (skillNum == 6){
            intiProf = profType;
        }else if (skillNum == 9){
            perfProf = profType;
        }else if (skillNum == 11){
            persProf = profType;
        }
    }
}