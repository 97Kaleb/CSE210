using System;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int charLv = 0;
        int hitPoints = 0;
        int prof = 2;

        Dictionary<string, string> classInfoF = new Dictionary<string, string>{
            {"className", "Fighter"},
            {"hitDie", "10"},
            {"classSkills", "1: Acrobatics,2: Animal Handling,4: Athletics,6: History,7: Insight,8: Intimidation,12: Perception,18: Survival"},
            {"skillChoices", "2"},
            {"classProf", "Light armor,Medium armor,Heavy armor,shields,Simple weapons,Martial weapons"},
            {"classSaves", "true,false,true,false,false,false"},
            {"subclassFeatureLvs", "3,7,10,15,18"},
            {"classProg", "Fighting Style|Second Wind,Action Surge,,ASI,Extra Attack (x1),ASI,,ASI,Indomitable (x1),,Extra Attack (x2),ASI,Indomitable (x2),ASI,,ASI,Action Surge (x2)|Indomitable (x3),,ASI,Extra Attack (x3)"},
            {"subclasses", "1: Banneret,2: Cavalier,3: Champion,4: Samurai"},
            {"1", "Rallying Cry,Bonus Proficiency>1>14|Expertise>1>14>,Inspiring Surge,Bulwark,Inspiring Surge+"},
            {"2", "Bonus Proficiency>1>2>6>7>13>14|Born to the Saddle|Unwavering Mark,Warding Maneuver,Hold the Line,Ferocious Charger,Vigilant Defender"},
            {"3", "Improved Critical,Remarkable Athlete,Additional Fighting Style,Superior Critical,Survivor"},
            {"4" , "Bonus Proficiency>1>6>7>13>14|Fighting Spirit,Elegant Courtier|Bonus Save>WIS,Tireless Spirit|Fighting Spirit+,Rapid Strike|Fighting Spirit ++,Strength Before Death"}
        };
        Dictionary<string, string> classInfoP = new Dictionary<string, string>{
            {"className", "Psion"},
            {"hitDie", "6"},
            {"classSkills", "2: Animal Handling,6: History,7: Insight,8: Intimidation,9: Investigation,11: Nature,14: Persuasion,12: Perception,18: Survival"},
            {"skillChoices", "2"},
            {"classProf", "Light armor,Simple weapons"},
            {"classSaves", "false,false,false,true,false,true"},
            {"subclassFeatureLvs", "2,6,10,14,18"},
            {"classProg", "Psionics,,Waveshaping,ASI,Waveshaping Options,,Waveshaping Points,ASI,Waveshaping Options,,Waveshaping Points,ASI,Waveshaping Options,,Waveshaping Points,ASI,Waveshaping Options,,ASI,Waveshaping Mastery"},
            {"subclasses", "1: High Mind,2: Ravager,3: Thought Shaper"},
            {"1", "Shielding Aura,Linked Minds,Phase Switch,Enhanced Shielding Aura,Hardlight Barrier"},
            {"2", "Thought-Rend,Mind Bleed,Psionic Leech,Shatter,Potent Psionics"},
            {"3", "Psionic Crystals,Crystal Construct,Warp,Improved Crystal Construct,Supreme Crystal Construct"}
        };
        List<int> generatedScores = Attribute.GenerateScore();
        Console.WriteLine("Please assign your Ability Scores");
        int scoreCounter = 0;
        foreach (int score in generatedScores){
            scoreCounter++;
            Console.WriteLine($"{scoreCounter}: {score}");
        }

        Console.WriteLine("Strength:");
        int assigningStat = Int32.Parse(Console.ReadLine()) - 1;
        int strS = generatedScores[assigningStat];
        generatedScores.RemoveAt(assigningStat);
        scoreCounter = 0;
        foreach (int score in generatedScores){
            scoreCounter++;
            Console.WriteLine($"{scoreCounter}: {score}");
        }

        Console.WriteLine("Dexterity:");
        assigningStat = Int32.Parse(Console.ReadLine()) - 1;
        int dexS = generatedScores[assigningStat];
        generatedScores.RemoveAt(assigningStat);
        scoreCounter = 0;
        foreach (int score in generatedScores){
            scoreCounter++;
            Console.WriteLine($"{scoreCounter}: {score}");
        }
        
        Console.WriteLine("Constitution:");
        assigningStat = Int32.Parse(Console.ReadLine()) - 1;
        int conS = generatedScores[assigningStat];
        generatedScores.RemoveAt(assigningStat);
        scoreCounter = 0;
        foreach (int score in generatedScores){
            scoreCounter++;
            Console.WriteLine($"{scoreCounter}: {score}");
        }
        
        Console.WriteLine("Intelligence:");
        assigningStat = Int32.Parse(Console.ReadLine()) - 1;
        int intS = generatedScores[assigningStat];
        generatedScores.RemoveAt(assigningStat);
        scoreCounter = 0;
        foreach (int score in generatedScores){
            scoreCounter++;
            Console.WriteLine($"{scoreCounter}: {score}");
        }
        
        Console.WriteLine("Wisdom:");
        assigningStat = Int32.Parse(Console.ReadLine()) - 1;
        int wisS = generatedScores[assigningStat];
        generatedScores.RemoveAt(assigningStat);
        scoreCounter = 0;
        foreach (int score in generatedScores){
            scoreCounter++;
            Console.WriteLine($"{scoreCounter}: {score}");
        }
        
        Console.WriteLine("Charisma:");
        int chaS = Int32.Parse(Console.ReadLine()) - 1;

        Strength str = new Strength("Strength", strS);
        Dexterity dex = new Dexterity("Dexterity", dexS);
        Constitution con = new Constitution("Constitution", conS);
        Intelligence smartness = new Intelligence("Intelligence", intS);
        Wisdom wis = new Wisdom("Wisdom", wisS);
        Charisma cha = new Charisma("Charisma", chaS);
        Subclass s1 = new Subclass(classInfoF);

        int x = 3;
        while (x > 0){
            string[] lvFeatures = s1.GainLv().Split('~');
            if (charLv == 0){
                hitPoints = hitPoints + Int32.Parse(lvFeatures[1]);
            }else{
                Random random = new Random();;
                hitPoints = hitPoints + random.Next(1, Int32.Parse(lvFeatures[1]));
            }
            charLv++;
            x--;
            lvFeatures = lvFeatures[0].Split('|');
            foreach (string item in lvFeatures){
                if (item.Contains("Bonus Proficiency")){
                    Console.WriteLine("Choose Bonus Proficiency");
                    string[] profChoices = item.Split('>');
                    for (int i = 1; i < profChoices.Count(); i++){
                        Console.WriteLine($"{i} {Attribute.GetSkillName(Int32.Parse(profChoices[i]))}");
                    }
                    int selection = Int32.Parse(Console.ReadLine());
                    str.AddSkillProf("o");
                    dex.AddSkillProf(Int32.Parse(profChoices[selection]), "o");
                    smartness.AddSkillProf(Int32.Parse(profChoices[selection]), "o");
                    wis.AddSkillProf(Int32.Parse(profChoices[selection]), "o");
                    cha.AddSkillProf(Int32.Parse(profChoices[selection]), "o");
                }else if (item.Contains("Expertise")){
                    Console.WriteLine("Choose Expertise");
                    string[] profChoices = item.Split('>');
                    for (int j = 0; j < Int32.Parse(profChoices[1]); j++){
                        for (int i = 1; i < profChoices.Count(); i++){
                            Console.WriteLine($"{i} {Attribute.GetSkillName(Int32.Parse(profChoices[i+1]))}");
                        }
                        int selection = Int32.Parse(Console.ReadLine());
                        if (Int32.Parse(profChoices[selection]) == 4){
                            str.AddSkillProf("x");
                        }
                        dex.AddSkillProf(Int32.Parse(profChoices[selection]), "x");
                        smartness.AddSkillProf(Int32.Parse(profChoices[selection]), "x");
                        wis.AddSkillProf(Int32.Parse(profChoices[selection]), "x");
                        cha.AddSkillProf(Int32.Parse(profChoices[selection]), "x");
                    }
                }else if (item.Contains("Bonus Save")){
                    string[] profGain = item.Split('>');
                    if (profGain[1] == "STR"){
                        str.AddSaveProf();
                    }else if (profGain[1] == "DEX"){
                        dex.AddSaveProf();
                    }else if (profGain[1] == "CON"){
                        con.AddSaveProf();
                    }else if (profGain[1] == "INT"){
                        smartness.AddSaveProf();
                    }else if (profGain[1] == "WIS"){
                        wis.AddSaveProf();
                    }else if (profGain[1] == "CHA"){
                        cha.AddSaveProf();
                    }
                }else{
                    Console.WriteLine(item);
                }
            }
        }
        Console.WriteLine($"Level {charLv} Character\nHit Points: {hitPoints}");
        Console.WriteLine(s1.DispClasses());
        Console.WriteLine(string.Join(", ", s1.DispFeatures().Where(f => !string.IsNullOrEmpty(f))).Trim(' ').Trim(','));

    }
}