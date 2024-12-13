public abstract class Attribute{
    int score;
    protected int mod;
    string name;
    Boolean saveProf = false;
    public abstract string GetSkill(int skillNum, int prof);

    public string DispScore(int prof){
        int save = mod;
        if (saveProf){
            save += prof;
        }
        if (mod >= 0){
            if (save >= 0){
                return $"{score} {name}\nMod:  +{mod}\nSave: +{save}";
            }else{
                return $"{score} {name}\nMod:  +{mod}\nSave: {save}";
            }
        }else{
            if (save >= 0){
                return $"{score} {name}\nMod:  {mod}\nSave: +{save}";
            }else{
                return $"{score} {name}\nMod:  {mod}\nSave: {save}";
            }
        }
    }
    public int GetMod(){
        return mod;
    }
    public void IncreaseScore(int increase){
        score += increase;
    }
    public void AddSaveProf(){
        saveProf = true;
    }
    public static string GetSkillName(int skillNum){
        string[] skillNames = [
            "Acrobatics", "Animal Handling", "Arcana", "Athletics", "Deception", "History", "Insight", "Intimidation", "Investigation", "Medicine", "Nature", "Perception", "Performance", "Persuasion", "Religion", "Sleight of Hand", "Stealth", "Survival"
        ];
        return skillNames[skillNum - 1];
    }
    public static List<int> GenerateScore(){
        Random random= new Random();
        return [random.Next(1, 6) + random.Next(1, 6) + random.Next(1, 6) + random.Next(1, 6), random.Next(1, 6) + random.Next(1, 6) + random.Next(1, 6) + random.Next(1, 6), random.Next(1, 6) + random.Next(1, 6) + random.Next(1, 6) + random.Next(1, 6), random.Next(1, 6) + random.Next(1, 6) + random.Next(1, 6) + random.Next(1, 6), random.Next(1, 6) + random.Next(1, 6) + random.Next(1, 6) + random.Next(1, 6), random.Next(1, 6) + random.Next(1, 6) + random.Next(1, 6) + random.Next(1, 6),];
    }
    public Attribute(string name, int score){
        this.name = name;
        this.score = score;
        mod = (score - 10) / 2 - score % 2;
    }
}