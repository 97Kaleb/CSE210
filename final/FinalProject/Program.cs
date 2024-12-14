using System;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Collections.Generic;

class Program
{
    static int AssignStat(List<int> generatedScores){
        int scoreCounter = 0;
        foreach (int score in generatedScores){
            scoreCounter++;
            Console.WriteLine($"{scoreCounter}: {score}");
        }
        int assigningStat = Int32.Parse(Console.ReadLine()) - 1;
        int S = generatedScores[assigningStat];
        generatedScores.RemoveAt(assigningStat);
        return S;
    }
    static int Menu(){
        int menuSelect = 0;
        Console.WriteLine("MENU:\n1: Increase Character Level\n2: Display Character Sheet\n3: Exit");
        menuSelect = Int32.Parse(Console.ReadLine());
        while (3 < menuSelect && menuSelect < 1){
            Console.WriteLine("Invalid input.\nMENU:\n1: Increase Character Level\n2: Display Character Sheet\n3: Exit");
            menuSelect = Int32.Parse(Console.ReadLine());
        }
        return menuSelect;
    }
    static void BonusSkill(string mode, string[] profChoices, Strength str, Dexterity dex, Intelligence smartness, Wisdom wis, Charisma cha){
        for (int j = 0; j < Int32.Parse(profChoices[1]); j++){
                        for (int i = 2; i < profChoices.Length; i++){
                            if (!string.IsNullOrEmpty(profChoices[i])){
                                Console.WriteLine($"{i - 1} {Attribute.GetSkillName(Int32.Parse(profChoices[i]))}");
                            }
                        }
                        int selection = Int32.Parse(Console.ReadLine());
                        if (Int32.Parse(profChoices[selection]) == 4){
                            str.AddSkillProf(mode);
                        }
                        dex.AddSkillProf(Int32.Parse(profChoices[selection]), mode);
                        smartness.AddSkillProf(Int32.Parse(profChoices[selection]), mode);
                        wis.AddSkillProf(Int32.Parse(profChoices[selection]), mode);
                        cha.AddSkillProf(Int32.Parse(profChoices[selection]), mode);
                    }
    }
    static void BonusSave(string[] profGain, Strength str, Dexterity dex, Constitution con, Intelligence smartness, Wisdom wis, Charisma cha){
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
    }
    static void ASI(Strength str, Dexterity dex, Constitution con, Intelligence smartness, Wisdom wis, Charisma cha){
        for (int i = 0; i < 2; i++){
            if (i == 0){
                Console.WriteLine("Chosse where to place your first +1:\n1: STR\n2: DEX\n3: CON\n4: INT\n5: WIS\n6: CHA");
            }else{
                Console.WriteLine("Chosse where to place your other +1:\n1: STR\n2: DEX\n3: CON\n4: INT\n5: WIS\n6: CHA");
            }
            int selectionASI = Int32.Parse(Console.ReadLine());
            if (selectionASI == 1){
                str.IncreaseScore(1);
            }else if (selectionASI == 2){
                dex.IncreaseScore(1);
            }else if (selectionASI == 3){
                con.IncreaseScore(1);
            }else if (selectionASI == 4){
                smartness.IncreaseScore(1);
            }else if (selectionASI == 5){
                wis.IncreaseScore(1);
            }else if (selectionASI == 6){
                cha.IncreaseScore(1);
            }
        }
    }
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
        Console.WriteLine("Please assign your Ability Scores\nStrength:");
        int strS = AssignStat(generatedScores);
        Console.WriteLine("Dexterity:");
        int dexS = AssignStat(generatedScores);
        Console.WriteLine("Constitution:");
        int conS = AssignStat(generatedScores);
        Console.WriteLine("Intelligence:");
        int intS = AssignStat(generatedScores);
        Console.WriteLine("Wisdom:");
        int wisS = AssignStat(generatedScores);
        Console.WriteLine("Charisma:");
        int chaS = AssignStat(generatedScores);

        Strength str = new Strength("Strength", strS);
        Dexterity dex = new Dexterity("Dexterity", dexS);
        Constitution con = new Constitution("Constitution", conS);
        Intelligence smartness = new Intelligence("Intelligence", intS);
        Wisdom wis = new Wisdom("Wisdom", wisS);
        Charisma cha = new Charisma("Charisma", chaS);
        Subclass s1 = new Subclass(classInfoF);
        Subclass s2 = new Subclass(classInfoP);
        while (true){
            int menuSelect = Menu();
            if (menuSelect == 1){
                string[] lvFeatures = s1.GainLv().Split('~');
                if (charLv == 0){
                    hitPoints = hitPoints + Int32.Parse(lvFeatures[1]);
                    Boolean[] classSaves = s1.GetClassSaves();
                    for (int i = 0; i < 6; i++){
                        if (classSaves[i]){
                            if (i == 0){
                                str.AddSaveProf();
                            }else if (i == 1){
                                dex.AddSaveProf();
                            }else if (i == 2){
                                con.AddSaveProf();
                            }else if (i == 3){
                                smartness.AddSaveProf();
                            }else if (i == 4){
                                wis.AddSaveProf();
                            }else if (i == 5){
                                cha.AddSaveProf();
                            }
                        }
                    }
                }else{
                    Random random = new Random();;
                    hitPoints = hitPoints + random.Next(1, Int32.Parse(lvFeatures[1]));
                }
                charLv++;
                prof = 2 + (int)Math.Floor((double)(charLv - 1) / 4);
                lvFeatures = lvFeatures[0].Split('|');
                foreach (string item in lvFeatures){
                    if (item.Contains("Bonus Proficiency")){
                        Console.WriteLine("Choose Bonus Proficiency");
                        string[] profChoices = item.Split('>');
                        BonusSkill("o", profChoices, str, dex, smartness, wis, cha);
                    }else if (item.Contains("Expertise")){
                        Console.WriteLine("Choose Expertise");
                        string[] expChoices = item.Split('>');
                        BonusSkill("x", expChoices, str, dex, smartness, wis, cha);
                    }else if (item.Contains("Bonus Save")){
                        string[] profGain = item.Split('>');
                        BonusSave(profGain, str, dex, con, smartness, wis, cha);
                    }else if (item.Contains("ASI")){
                        ASI(str, dex, con, smartness, wis, cha);
                    }else{
                        Console.WriteLine(item);
                    }
                }
            }else if (menuSelect == 2){
                Console.WriteLine($"Level {charLv} Character\nHit Points: {hitPoints}");
                Console.WriteLine(s1.DispClasses());
                Console.WriteLine(string.Join(", ", s1.DispFeatures().Where(f => !string.IsNullOrEmpty(f))).Trim(' ').Trim(','));
            }else if (menuSelect == 3){
                break;
            }
        }
    }
}