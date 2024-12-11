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
    public Attribute(string name, int score){
        this.name = name;
        this.score = score;
        mod = (score - 10) / 2 - score % 2;
    }
}