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
                return $"{score} {name}{String.Concat(Enumerable.Repeat(' ', 15 - name.Length - score.ToString().Length))}Mod:  +{mod} Save: +{save}";
            }else{
                return $"{score} {name}{String.Concat(Enumerable.Repeat(' ', 15 - name.Length - score.ToString().Length))}Mod:  +{mod} Save: {save}";
            }
        }else{
            if (save >= 0){
                return $"{score} {name}{String.Concat(Enumerable.Repeat(' ', 15 - name.Length - score.ToString().Length))}Mod:  {mod} Save: +{save}";
            }else{
                return $"{score} {name}{String.Concat(Enumerable.Repeat(' ', 15 - name.Length - score.ToString().Length))}Mod:  {mod} Save: {save}";
            }
        }
    }
    public int GetMod(){
        return mod;
    }
    public void IncreaseScore(int increase){
        score += increase;
        mod = (score - 10) / 2;
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
        List<int> results = new List<int>();
        for (int i = 0; i < 6; i++){
            int s1 = random.Next(0, 6);
            int s2 = random.Next(0,6);
            int s3 = random.Next(0,6);
            int s4 = random.Next(0,6);
            if (s1 <= s2 && s1 <= s3 && s1 <= s4){
                results.Add(s2 + s3 + s4);
            }else if (s2 <= s3 && s2 <= s4){
                results.Add(s1 + s3 + s4);
            }else if (s3 <= s4){
                results.Add(s1 + s2 + s4);
            }else{
                results.Add(s1 + s2 + s3);
            }
        }
        return results;
    }
    public Attribute(string name, int score){
        this.name = name;
        this.score = score;
        mod = (score - 10) / 2;
    }
}