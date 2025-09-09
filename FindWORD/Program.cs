using System;
using System.IO;
using System.Linq;
using System.Text;
class Program
{
    static void make_folder_of_files(string outputDir)
    {
        Directory.CreateDirectory(outputDir);

        string[] sSampleWords = {
    "computer","network","data","security","project","system","search","performance","cloud","server",
    "database","CSharp","OpenAI","machine","learning","hello","world","random","example","test",
    "application","software","hardware","internet","protocol","developer","engineer","programming","algorithm","function",
    "variable","constant","loop","condition","array","list","dictionary","hashset","stack","queue",
    "thread","process","parallel","asynchronous","synchronous","compile","execute","runtime","debug","error",
    "exception","message","signal","request","response","header","footer","body","packet","frame",
    "router","switch","firewall","gateway","proxy","cache","storage","memory","disk","drive",
    "keyboard","mouse","monitor","screen","display","window","button","menu","form","textbox",
    "label","grid","table","row","column","cell","chart","graph","plot","diagram",
    "number","integer","double","float","boolean","true","false","char","string","text",
    "letter","word","sentence","paragraph","document","file","folder","path","directory","location",
    "source","destination","origin","target","link","connection","relation","mapping","binding","association",
    "login","logout","register","signup","profile","account","password","username","email","phone",
    "address","city","country","region","state","zip","postal","code","id","identity",
    "session","cookie","token","key","value","pair","map","encrypt","decrypt","hash",
    "checksum","validate","verify","confirm","approve","reject","accept","decline","block","allow",
    "enable","disable","active","inactive","online","offline","available","busy","idle","away",
    "start","stop","pause","resume","play","record","save","load","open","close",
    "edit","update","modify","change","delete","remove","insert","append","add","replace",
    "search","find","lookup","scan","crawl","index","rank","sort","order","filter",
    "select","choose","pick","highlight","mark","tag","label","note","comment","review",
    "approve","deny","grant","revoke","issue","sign","stamp","print","publish","release",
    "draft","final","version","revision","history","backup","restore","recover","crash","failure",
    "success","win","lose","draw","match","game","score","goal","point","level",
    "stage","round","phase","step","task","job","work","duty","role","position",
    "office","desk","chair","table","room","house","building","floor","ceiling","wall",
    "door","window","roof","garden","yard","road","street","avenue","highway","bridge",
    "river","lake","sea","ocean","mountain","hill","valley","forest","tree","plant",
    "flower","grass","leaf","root","branch","fruit","seed","animal","dog","cat",
    "bird","fish","horse","cow","sheep","goat","chicken","duck","pig","lion",
    "tiger","bear","wolf","fox","monkey","elephant","giraffe","zebra","camel","deer",
    "energy","power","light","dark","day","night","sun","moon","star","planet",
    "earth","mars","venus","jupiter","saturn","uranus","neptune","pluto","galaxy","universe",
    "school","university","college","student","teacher","professor","class","lecture","course","subject",
    "exam","test","quiz","assignment","homework","project","report","thesis","paper","book",
    "library","chapter","section","page","line","title","heading","topic","content","summary",
    "introduction","conclusion","result","analysis","method","theory","model","concept","idea","design",
    "build","create","develop","invent","innovate","discover","explore","research","study","experiment",
    "science","math","physics","chemistry","biology","geology","astronomy","history","geography","language",
    "english","arabic","french","spanish","german","italian","russian","chinese","japanese","korean",
    "travel","trip","tour","journey","flight","plane","airport","train","station","bus",
    "car","taxi","bike","motorcycle","ship","boat","submarine","rocket","satellite","space",
    "movie","film","cinema","theater","actor","actress","director","producer","scene","camera",
    "music","song","album","track","band","singer","voice","sound","instrument","guitar",
    "piano","drum","violin","flute","trumpet","microphone","radio","tv","show","news",
    "sport","football","soccer","basketball","tennis","golf","cricket","hockey","rugby","boxing",
    "olympic","tournament","championship","league","cup","medal","trophy","award","prize","winner",
    "health","doctor","nurse","hospital","clinic","medicine","drug","pill","vaccine","surgery",
    "disease","virus","bacteria","infection","injury","pain","fever","cough","cold","flu",
    "economy","finance","money","bank","account","loan","credit","debit","cash","coin",
    "card","market","trade","stock","share","bond","fund","budget","tax","profit",
    "loss","income","salary","wage","bonus","payment","price","cost","value","worth",
    "politics","government","president","minister","parliament","law","rule","regulation","policy","decision",
    "vote","election","party","candidate","campaign","speech","debate","agreement","treaty","war",
    "peace","army","soldier","weapon","gun","tank","ship","plane","missile","bomb","abandon","ability","able","about","above","absorb","abstract","abuse","academic","accept",
    "access","accident","account","accurate","accuse","achieve","acid","acquire","across","act",
    "action","active","actor","actress","actual","adapt","add","address","admin","admit",
    "adult","advance","advice","aeroplane","affair","affect","afford","afraid","after","again",
    "agency","agenda","agent","agree","ahead","aid","aim","air","airline","airport",
    "alarm","album","alcohol","alive","all","alley","allow","almost","alone","along",
    "already","also","alter","always","amazing","ambition","amount","ancient","anger","angle",
    "animal","announce","annual","another","answer","anxiety","anyone","apart","apartment","apologize",
    "appeal","appear","apple","apply","appoint","approve","area","argue","arise","arm",
    "army","around","arrange","arrest","arrive","arrow","article","artist","artwork","aspect",
    "assault","assert","assess","asset","assign","assist","assume","athlete","atmosphere","attach",
    "attack","attempt","attend","attitude","attract","audience","author","authority","auto","autumn",
    "available","avenue","average","avoid","award","aware","away","awesome","awful","baby",
    "back","background","bacon","bad","bag","bake","balance","ball","banana","band",
    "bank","bar","bare","bargain","barrel","base","basic","basket","bath","battle",
    "beach","beam","bear","beard","beat","beauty","because","become","before","begin",
    "behavior","behind","belief","believe","bell","belong","below","belt","bench","benefit",
    "berry","beside","best","better","between","beyond","bicycle","bid","big","bike",
    "bill","binary","bind","bird","birth","biscuit","bit","bitter","black","blade",
    "blame","blank","blast","bleed","blend","bless","blind","block","blood","bloom",
    "blow","blue","board","boat","body","boil","bold","bomb","bond","bone",
    "bonus","book","boost","border","borrow","boss","both","bother","bottle","bottom",
    "bounce","bound","boundary","bow","bowl","box","boy","brain","branch","brand",
    "brave","bread","break","breast","breath","bridge","brief","bright","bring","broad",
    "broken","brother","brown","brush","bubble","budget","build","bulk","bullet","bunch",
    "burn","burst","bus","bush","business","busy","but","butter","button","buyer",
    "cabin","cabinet","cable","cake","calculate","call","calm","camera","camp","campaign",
    "campus","can","cancel","cancer","candidate","candle","candy","canvas","cap","capable",
    "capacity","capital","captain","capture","car","card","care","career","careful","cargo",
    "carpet","carry","cart","case","cash","casino","cast","castle","casual","cat",
    "catch","category","cattle","cause","cave","cease","ceiling","celebrate","cell","center",
    "century","ceremony","certain","chain","chair","chalk","challenge","champion","chance","change",
    "chaos","chapter","character","charge","charity","chart","chase","cheap","check","cheese",
    "chef","chemical","chest","chicken","chief","child","chimney","choice","choose","church",
    "circle","citizen","city","civil","claim","class","classic","clean","clear","clerk",
    "clever","click","client","climate","climb","clinic","clock","close","cloth","cloud",
    "club","clue","coach","coal","coast","coat","code","coffee","coin","cold",
    "collapse","collect","college","color","column","combat","combine","comedy","comfort","command",
    "comment","commit","common","company","compare","compete","complain","complete","complex","compose",
    "compute","concept","concern","concert","conclude","condition","conduct","conference","confirm","conflict",
    "confuse","connect","conscious","consider","consist","constant","construct","consume","contact","contain",
    "content","contest","context","continue","contract","control","convert","convince","cook","cool",
    "cooperate","cope","copy","core","corner","correct","cost","cotton","couch","could",
    "council","count","country","county","couple","course","court","cousin","cover","cow",
    "crack","craft","crash","crazy","cream","create","credit","crew","crime","crisis",
    "critic","crop","cross","crowd","crown","crucial","cruel","crush","cry","culture",
    "cup","curious","current","curve","custom","customer","cute","cycle","dad","daily",
    "damage","dance","danger","dare","dark","data","date","daughter","day","dead",
    "deal","dear","death","debate","debt","decade","decide","declare","decline","decorate",
    "decrease","dedicate","deep","deer","defeat","defend","define","degree","delay","deliver",
    "demand","democracy","deny","department","depend","deposit","describe","desert","design","desire",
    "desk","despite","destroy","detail","detect","develop","device","devote","dialogue","diamond",
    "diary","dictionary","die","diet","differ","difficult","dig","digital","dinner","direct",
    "dirty","disagree","disaster","discipline","discover","disease","dish","dismiss","disorder","display",
    "distance","district","divide","divorce","doctor","document","dog","dollar","domain","dominate",
    "door","double","doubt","down","dozen","draft","drag","drama","draw","dream",
    "dress","drink","drive","drop","drug","drum","dry","duck","due","dull",
    "during","dust","duty","each","eager","early","earn","earth","ease","east",
    "easy","eat","echo","economy","edge","edit","educate","effect","effort","egg",
    "eight","either","elbow","elder","elect","element","elevator","else","email","embarrass",
    "emerge","emotion","employ","empty","enable","encounter","encourage","end","enemy","energy",
    "engage","engine","enhance","enjoy","enormous","enough","ensure","enter","entire","entry",
    "envelope","environment","equal","equipment","error","escape","essay","essential","establish","estate",
    "estimate","ethics","evaluate","even","evening","event","ever","every","evidence","evil",
    "exact","exam","example","excellent","except","exchange","excite","exclude","excuse","exercise",
    "exist","exit","expand","expect","expense","experience","expert","explain","explore","export",
    "expose","express","extend","extra","eye","face","fact","factor","fail","fair",
    "faith","fall","false","familiar","family","famous","fan","fancy","far","farm"
};


        Random rand = new Random();
        int nNumFiles = 100;

        for (int i = 1; i <= nNumFiles; i++)
        {
            // File size in bytes (between 1MB and 5MB)
            int nSizeInBytes = rand.Next(1 * 1024 * 1024, 2 * 1024 * 1024);

            string sFilePath = Path.Combine(outputDir, $"file_{i}.txt");

            using (StreamWriter writer = new StreamWriter(sFilePath, false, Encoding.UTF8))
            {
                int nWritten = 0;
                while (nWritten < nSizeInBytes)
                {
                    // Generate a sentence of random words
                    string sSentence = string.Join(" ",
                        new string[10].Select(_ => sSampleWords[rand.Next(sSampleWords.Length)])
                    ) + Environment.NewLine;

                    writer.Write(sSentence);
                    nWritten += Encoding.UTF8.GetByteCount(sSentence);
                }
            }
        }

        Console.WriteLine($"✅ {nNumFiles} files have been created in the folder: {Path.GetFullPath(outputDir)}");
    }
    static void search_for_word(Dictionary<string, List<(string fileName, int lineNumber, int count)>> myDict,string word,string folder_path)
    {
        if (myDict.ContainsKey(word))
        {
            int nTotalCount = 0;
            Console.WriteLine($"word \"{word}\" found in lines :");
            foreach (var entry in myDict[word])
            {
                string[] fileLines = File.ReadAllLines(Path.Combine(folder_path, entry.fileName));
                string sLine = fileLines[entry.lineNumber - 1];

                // highlight word
                string sHighlighted = sLine.Replace(word, $"*{word}*");

                Console.WriteLine($"[{entry.fileName}] (line {entry.lineNumber}) {sHighlighted}");

                nTotalCount += entry.count;
            }

            Console.WriteLine($"word {word} appears {nTotalCount} times");
        }
        else
        {
            Console.WriteLine($"word \"{word}\" not found.");
        }
    }
    static void preprocessing(string[] files, Dictionary<string, List<(string fileName, int lineNumber, int count)>> myDict)
    {
        foreach (string file in files)
        {
            List<string> lines = File.ReadAllLines(file).ToList();
            int lineNumber = 1;
            foreach (string sLine in lines)
            {
                List<string> wordsInLine = sLine.Split(' ').ToList();
                foreach (string sOneWord in wordsInLine)
                {
                    if (!myDict.ContainsKey(sOneWord))
                    {
                        myDict[sOneWord] = new List<(string, int, int)>();
                    }
                    myDict[sOneWord].Add((Path.GetFileName(file), lineNumber, 1));
                }
                lineNumber++;
            }
        }
    }
    static void find_word(string word)
    {
        string sFolder_Path = @"C:\Users\MG13\source\repos\FindWORD\FindWORD\bin\Debug\net8.0\txt_files_with_text";
        string[] files = Directory.GetFiles(sFolder_Path, "*.txt"); // get all files in folder 
        Dictionary<string, List<(string fileName, int lineNumber, int count)>> myDict = new Dictionary<string, List<(string fileName, int lineNumber, int count)>>();
        preprocessing(files, myDict);
        search_for_word(myDict, word, sFolder_Path);
    }
    static void Print()
    {
        bool bChoose = true;
        while (bChoose)
        {
            Console.WriteLine("choose from the menu :");
            Console.WriteLine("1- for search");
            Console.WriteLine("0- for exit");
            int nInput = int.Parse(Console.ReadLine()!);
            if (nInput != 0)
            {
                Console.WriteLine("enter the word you want to search on it (example: data)");
                string sWord = Console.ReadLine()!;
                find_word(sWord); // example  (data)
            }
            else
            {
                bChoose = false;
            }
        }
    }
    static void Main()
    {
        make_folder_of_files("txt_files_with_text"); // call to make folder of 100 files to search in it (used only one time when you use the program for the first time)
        Print();
    }
}
