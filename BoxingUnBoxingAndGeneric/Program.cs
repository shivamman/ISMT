// See https://aka.ms/new-console-template for more information

using BoxingUnBoxingAndGeneric;

Main();
Generics();


void Main()
{
  Console.WriteLine("Hello, World!");
  Boxing();
  Console.WriteLine(UnBoxing());  
}

void Boxing()
{
  List<string> list = new List<string>();
  List<int> intList = new List<int>();
  list.Add("Pawan");
  list.Add("Bijay");
  intList.Add(1);
  intList.Add(2);
  double data = 1000.50;
  int a = 100;
  object b = a;
  b = 200;
  Console.WriteLine(b);
  Console.WriteLine(Convert.ToInt32(data));
  foreach (var item in list)
  {
    Console.WriteLine(item);
  }
  foreach (var item in intList)
  {
    Console.WriteLine(item);
  }
}



void Generics()
{
  //IItem itemSevice = new ItemService();
  //ICategory catSevice = new CategoryService();

  IGenericrRepository<Item> itemRepo = new GenericRepository<Item>();
  itemRepo.Add(new Item());
  itemRepo.Update(new Item());

  IGenericrRepository<Category> catRepo = new GenericRepository<Category>();
  catRepo.Add(new Category());
  catRepo.Update(new Category());
}

int UnBoxing()
{
  object a = 100;
  int b = (int)a;
  return b;
}
