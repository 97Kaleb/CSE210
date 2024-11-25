public class Words{
    string[] words;
    public Words(string[] words){
        this.words = words;
    }
    public string DispText(){
        string dText ="";
        foreach (string s in words){
            dText = dText + s;
        }
        return dText;
    }
    public bool Empty(){
        bool empty = true;
        foreach (string s in words){
            if(s != " ??? "){
                empty = false;
            }
        }
        return empty;
    }
    public void Conceal(){
        Random random = new Random();
        int wIndNum = random.Next(1, 3);
        for(int i = 0; i < wIndNum; i++){
            int wInd = random.Next(0, words.Length);
            if (words[wInd] != " ??? "){
                words[wInd] = " ??? ";
            }else{
                for(i = 0; i < words.Length; i++){
                    if (words[i] != " ??? "){
                        words[i] = " ??? ";
                        break;
                    }
                }
            }
        }
    }
}