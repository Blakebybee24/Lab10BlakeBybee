List<string>todolist;
todolist= new List<string>();
List<string>time;
time = new List<string>();
List <string> finished;
finished = new List<string>();
string[] questions = new string[10];
        questions[0] = "Hi";
        questions[1] = "How are you ";
        questions[2] = "Are you doing well";
        questions[3] = "hey";
        questions[4] = "yo";
        questions[5] = "whats up";
        questions[6] = "what you doin";
        questions[7] = "you look nice today";
        questions[8] = "greetings";
        questions[9] = "what a do";
        Random rnd = new Random();
        Console.WriteLine(questions[rnd.Next(0,9)]);
Console.WriteLine("what is the first item you want to do");
string Firsttodo = Console.ReadLine();
todolist.Add(Firsttodo);
Console.WriteLine("When would you like to do that");
string addtime = Console.ReadLine();
time.Add(addtime);
bool more = true;
while (more = true){
  Console.WriteLine("Is there anything else you want to do,Please say yes or no");
  string mas = Console.ReadLine();
  if (mas == "yes"){
    additem();
    continue;

  }
  if (mas =="no"){
    more = false;
    break;
  
  }
  else{
    Console.WriteLine("Sorry I don't understand. Please type yes or no");
  }

}
for(int x = 0; x < todolist.Count; x++){
  Console.WriteLine($"have you finished {todolist[x]} yes or no");
  string complete = Console.ReadLine();
  if (complete == "yes"){
    finished.Add("Finished");
    continue;
  }
  else {
    Console.WriteLine("sorry I don't understand. Please type yes or no");
continue;
  }
}
for(int x =0; x <todolist.Count; x++){
  Console.WriteLine($"{todolist[x]}:");
  Console.WriteLine($"{time[x]}");
  Console.WriteLine(finished[x]);
  File.WriteAllText("stats.csv", todolist[x]);
File.WriteAllText("stats.cvs", time[x]);
File.WriteAllText("stats.csv", finished[x]);
  File.ReadAllText("stats.csv");
}


Console.ReadKey();

void additem (){
  Console.WriteLine("what would you like to do");
  string addto = Console.ReadLine();
  todolist.Add(addto);
  Console.WriteLine("what time would you like to begin ");
  addtime = Console.ReadLine();
  time.Add(addtime);
}
if (File.Exists("stats.csv")){
  
 File.ReadAllText("stats.csv" );
Console.WriteLine("total amount of to do items : "+todolist.Count);
}
Console.Write("what do you want me to tell you next time");
string? Message = Console.ReadLine();


