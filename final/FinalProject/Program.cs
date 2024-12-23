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
        while (scoreCounter < assigningStat || assigningStat < 0){
            Console.WriteLine("Invalid input. Choose again.");
            assigningStat = Int32.Parse(Console.ReadLine());
        }
        int s = generatedScores[assigningStat];
        generatedScores.RemoveAt(assigningStat);
        return s;
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
        int sC = 0;
        for (int j = 0; j < Int32.Parse(profChoices[1]); j++){
            for (int i = 2; i < profChoices.Length; i++){
                if (!string.IsNullOrEmpty(profChoices[i])){
                    sC++;
                    Console.WriteLine($"{i - 1} {Attribute.GetSkillName(Int32.Parse(profChoices[i]))}");
                }
            }
            int selection = Int32.Parse(Console.ReadLine());
            while(selection > sC || selection <= 0){
                Console.WriteLine("Invalid input. Choose again.");
            }
            str.AddSkillProf(Int32.Parse(profChoices[selection + 1]), mode);
            dex.AddSkillProf(Int32.Parse(profChoices[selection + 1]), mode);
            smartness.AddSkillProf(Int32.Parse(profChoices[selection + 1]), mode);
            wis.AddSkillProf(Int32.Parse(profChoices[selection + 1]), mode);
            cha.AddSkillProf(Int32.Parse(profChoices[selection + 1]), mode);
            profChoices = profChoices.Where(o=> o != profChoices[selection + 1]).ToArray();
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
    static void ASIncrease(int selection, Strength str, Dexterity dex, Constitution con, Intelligence smartness, Wisdom wis, Charisma cha){
        if (selection == 1){
                str.IncreaseScore(1);
            }else if (selection == 2){
                dex.IncreaseScore(1);
            }else if (selection == 3){
                con.IncreaseScore(1);
            }else if (selection == 4){
                smartness.IncreaseScore(1);
            }else if (selection == 5){
                wis.IncreaseScore(1);
            }else if (selection == 6){
                cha.IncreaseScore(1);
            }else{
                Console.WriteLine("Invalid Input. Choose another Ability Score.");
                selection = Int32.Parse(Console.ReadLine());
                ASIncrease(selection, str, dex, con, smartness, wis, cha);
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
            ASIncrease(selectionASI, str, dex, con, smartness, wis, cha);
        }
    }
    static string GetSkills(int prof, Strength str, Dexterity dex, Intelligence smartness, Wisdom wis, Charisma cha){
        string skills = "";
        for (int i = 1; i <= 18; i++){
            skills += str.GetSkill(i, prof);
            skills += dex.GetSkill(i, prof);
            skills += smartness.GetSkill(i, prof);
            skills += wis.GetSkill(i, prof);
            skills += cha.GetSkill(i, prof);
        }
        return skills;
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
        Dictionary<string, string> raceInfo = new Dictionary<string, string>{
            {"raceName", "Minotaur"},
            {"speed", "40"},
            {"size", "M"},
            {"Racial Mods", "1+1"},
            {"Racial Features", "Superior Darkvision,Labyrinthine Mind,Minotaur's Horns"},
            {"subraces", "1: Flameheart Minotaur,2: Shadow Form Minotaur,3: Stone-Eye Minotaur"},
            {"1", "3+3,Volcanic Blood,Molten Swings"},
            {"2", "4+4,Shadow Form,Racial Spellcasting"},
            {"3", "5+5,Stone Armor,Mystic Vision"}
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
        Subclass s1 = new Subclass(classInfoP);
        Subrace r = new Subrace(raceInfo);

        int[] racialMods = r.GetMods();
        foreach (int mod in racialMods){
            ASIncrease(mod, str, dex, con, smartness, wis, cha);
        }
        
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

        while (true){
            int menuSelect = Menu();
            if (menuSelect == 1){
                string[] lvFeatures = s1.GainLv().Split('~');
                if (charLv == 0){
                    hitPoints = hitPoints + Int32.Parse(lvFeatures[1]);
                    string[] classSkills = s1.getClassSkills();
                    for (int i = 0; i < classSkills.Count() ; i++){
                        classSkills[i] = classSkills[i].Split(':')[0];
                    }
                    List<string> classSkillsList = [$"{s1.getSkillChoices}", .. classSkills];
                    string[] classSkillsArray = classSkillsList.ToArray();
                    Console.WriteLine("Choose Class Skill Proficiencies");
                    BonusSkill("o", classSkillsArray, str, dex, smartness, wis, cha);
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
                Console.WriteLine($"Level {charLv} Character\nHit Points: {hitPoints + (con.GetMod() * charLv)}\nSize: {r.GetSize()}\nSpeed: {r.GetSpeed()}'");
                Console.WriteLine(str.DispScore(prof));
                Console.WriteLine(dex.DispScore(prof));
                Console.WriteLine(con.DispScore(prof));
                Console.WriteLine(smartness.DispScore(prof));
                Console.WriteLine(wis.DispScore(prof));
                Console.WriteLine(cha.DispScore(prof));
                Console.WriteLine(s1.DispClasses());
                string[] raceFeats = r.GetFeatures();
                string[] subraceFeats = r.GetSubraceFeatures();
                foreach (string raceFeat in raceFeats){
                    Console.WriteLine(raceFeat);
                }
                foreach (string subraceFeat in subraceFeats){
                    Console.WriteLine(subraceFeat);
                }
                Console.WriteLine(string.Join(", ", r.GetFeatures().Where(f => !string.IsNullOrEmpty(f))).Trim(' ').Trim(','));
                Console.WriteLine(string.Join(", ", r.GetSubraceFeatures().Where(f => !string.IsNullOrEmpty(f))).Trim(' ').Trim(','));
                Console.WriteLine(string.Join(", ", s1.DispFeatures().Where(f => !string.IsNullOrEmpty(f))).Trim(' ').Trim(','));
                Console.WriteLine(GetSkills(prof, str, dex, smartness, wis, cha));
            }else if (menuSelect == 3){
                break;
            }
        }
    }
}