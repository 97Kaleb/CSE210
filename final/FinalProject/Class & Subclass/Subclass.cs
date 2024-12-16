using System.Text.Json.Nodes;

public class Subclass : CharClass{
    string subclassName;
    List<int> subclassFeatureLvs = new List<int>();
    string[] subclassProg;
    public Subclass(Dictionary<string, string> classInfo) : base(classInfo){
        className = classInfo["className"];
        hitDie = Int32.Parse(classInfo["hitDie"]);
        classSkills = classInfo["classSkills"].Split(',');
        skillChoices = Int32.Parse(classInfo["skillChoices"]);
        int i = 0;
        foreach (string item in classInfo["classSaves"].Split(',')){
            if (item == "true"){
                classSaves[i] = true;
            }else if (item == "false"){
                classSaves[i] = false;
            }
            i++;
        }
        foreach (string item in classInfo["subclassFeatureLvs"].Split(',')){
            subclassFeatureLvs.Add(Int32.Parse(item));
        }
        classProg = classInfo["classProg"].Split(',');
        int scN = 0;
        foreach (string item in classInfo["subclasses"].Split(',')){
            Console.WriteLine(item);
            scN++;
        }
        int selection = Int32.Parse(Console.ReadLine());
        while (selection > scN || selection <= 0) {
            Console.WriteLine("Invalid input. Choose again.");
            selection = Int32.Parse(Console.ReadLine());
        }
        string subclassSelection = classInfo["subclasses"].Split(',')[selection - 1];
        subclassName = subclassSelection.Split(':')[1].Trim(' ');
        subclassProg = classInfo[selection.ToString()].Split(',');
    }
    public override string GainLv(){
        classLv++;
        int x = 0;
        foreach (int i in subclassFeatureLvs){
            if (i == classLv){
                break;
            }
            x++;
        }
        if (subclassFeatureLvs.Contains(classLv)){
            return $"{classProg[classLv - 1]}|{subclassProg[x]}~{hitDie}";
        }else{
            return $"{classProg[classLv - 1]}~{hitDie}";
        }
    }
    public override string DispClasses(){
        if (classLv >= subclassFeatureLvs[0]){
            return $"{subclassName} {classLv}";
        }else{
            return $"{className} {classLv}";
        }
    }
    public override List<string> DispFeatures(){
        List<string> obtainedFeatures = new List<string>();
        for (int i = 0; i < classLv; i++){
            int x = 0;
            foreach(int j in subclassFeatureLvs){
                if (j == i + 1){
                    break;
                }
                x++;
            }
            if (subclassFeatureLvs.Contains(i + 1)){
                if (subclassProg[x].Contains('|')){
                    foreach (string s in subclassProg[x].Split('|')){
                        if (!s.Contains("Bonus Proficiency") && !s.Contains("Expertise") && !s.Contains("Bonus Save") && !s.Contains("ASI")){
                            obtainedFeatures.Add(s);
                        }
                    }
                }else{
                    if (!subclassProg[x].Contains("Bonus Proficiency") && !subclassProg[x].Contains("Expertise") && !subclassProg[x].Contains("Bonus Save") && !subclassProg[x].Contains("ASI")){
                        obtainedFeatures.Add(subclassProg[x]);
                    }
                }
            }
            if (classProg[i].Contains('|')){
                foreach (string s in classProg[i].Split('|')){
                    if (!s.Contains("Bonus Proficiency") && !s.Contains("Expertise") && !s.Contains("Bonus Save") && !s.Contains("ASI")){
                            obtainedFeatures.Add(s);
                    }
                }
            }else{
                if (!classProg[i].Contains("Bonus Proficiency") && !classProg[i].Contains("Expertise") && !classProg[i].Contains("Bonus Save") && !classProg[i].Contains("ASI")){
                    obtainedFeatures.Add(classProg[i]);
                }
            }
        }
        return obtainedFeatures;
    }
}