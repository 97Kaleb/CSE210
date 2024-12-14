public class Intelligence(string name, int score) : Attribute(name, score){
    string arcaProf = " ";
    int arcaScore;
    string histProf = " ";
    int histScore;
    string inveProf = " ";
    int inveScore;
    string natuProf = " ";
    int natuScore;
    string reliProf = " ";
    int reliScore;
    public override string GetSkill(int skillNum, int prof)
    {
        if (skillNum == 3){
            if (arcaProf == "x"){
                arcaScore = mod + (prof * 2);
            }else if (arcaProf == "o"){
                arcaScore = mod + prof;
            }else{
                arcaScore = mod;
            }
            if (arcaScore >= 0){
                return $"{arcaProf} Arcana: {arcaScore}\n";
            }else{
                return $"{arcaProf} Arcana: {arcaScore}\n";
            }
        }else if (skillNum == 6){
            if (histProf == "x"){
                histScore = mod + (prof * 2);
            }else if (histProf == "o"){
                histScore = mod + prof;
            }else{
                histScore = mod;
            }
            if (histScore >= 0){
                return $"{histProf} History: {histScore}\n";
            }else{
                return $"{histProf} History: {histScore}\n";
            }
        }else if (skillNum == 9){
            if (inveProf == "x"){
                inveScore = mod + (prof * 2);
            }else if (inveProf == "o"){
                inveScore = mod + prof;
            }else{
                inveScore = mod;
            }
            if (inveScore >= 0){
                return $"{inveProf} Investigation: {inveScore}\n";
            }else{
                return $"{inveProf} Investigation: {inveScore}\n";
            }
        }else if (skillNum == 11){
            if (natuProf == "x"){
                natuScore = mod + (prof * 2);
            }else if (natuProf == "o"){
                natuScore = mod + prof;
            }else{
                natuScore = mod;
            }
            if (natuScore >= 0){
                return $"{natuProf} Nature: {natuScore}\n";
            }else{
                return $"{natuProf} Nature: {natuScore}\n";
            }
        }else if (skillNum == 15){
            if (reliProf == "x"){
                reliScore = mod + (prof * 2);
            }else if (reliProf == "o"){
                reliScore = mod + prof;
            }else{
                reliScore = mod;
            }
            if (reliScore >= 0){
                return $"{reliProf} Religion: {reliScore}\n";
            }else{
                return $"{reliProf} Religion: {reliScore}\n";
            }
        }else{
            return null;
        }
    }
    public void AddSkillProf(int skillNum, string profType){
        if (skillNum == 3){
            arcaProf = profType;
        }else if (skillNum == 6){
            histProf = profType;
        }else if (skillNum == 9){
            inveProf = profType;
        }else if (skillNum == 11){
            natuProf = profType;
        }else if (skillNum == 15){
            reliProf = profType;
        }
    }
}
