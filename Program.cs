List<string>todolist;
todolist= new List<string>();
List<string>time;
time = new List<string>();
List <string> finished;
finished = new List<string>();
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

  }
}
for(int x =0; x <todolist.Count; x++){
  Console.WriteLine($"{todolist[x]}:");
  Console.WriteLine($"{time[x]}");
  Console.WriteLine(finished[x]);
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
if (File.Exists("Message.txt")){
string previous = File.ReadAllText("Message.txt");
Console.WriteLine("Last time, you said this : "+previous);
}
Console.Write("what do you want me to tell you next time");
string message = Console.ReadLine();
File.WriteAllText("Message.txt", message);


