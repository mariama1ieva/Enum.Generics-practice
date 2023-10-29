using Enum_Generics.Practice;
using Enum_Generics.Practice.Helpers;

//string email=Console.ReadLine();

//var result=email.CheckEmail();

//if (result == true)
//{
//    Console.WriteLine("success");
//}
//else
//{
//    Console.WriteLine("wrong");
//}

//Console.WriteLine("Please add your email:");
//string email=Console.ReadLine();

//var res = email.CheckTrim(@"\s");

//if(res == true)
//{
//    Console.WriteLine("yes");
//}
//else
//{
//    Console.WriteLine("no");
//}

//Person person   = new Person();
//person.Name = "Cavid";
//person.SurName = "Bashirov";

//Console.WriteLine(person.GetFullName());

//int[] numbers = { 1, 2, 3,4,5};
//Console.WriteLine(numbers.MultipleOfNums());


//IntList list = new IntList();  

//list.Add(1);
//list.Add(2);
//list.Add(100);

//list.GetAll();

//StringList list = new StringList();

//list.Add("Oruc");
//list.Add("Semed");
//list.Add("Nurlan");

//list.GettAll();

//PersonList list = new PersonList();

//list.Add(new Person { Id = 1, Name = "test1", SurName = "test1" });
//list.Add(new Person { Id = 2, Name = "test1", SurName = "test1" });
//list.Add(new Person { Id = 3, Name = "test1", SurName = "test1" });

//list.GetAll();


//DataList<int> datas = new();
//datas.Add(1);
//datas.Add(2);
//datas.Add(20);
//datas.GetAll();

//DataList<string> datas = new();
//datas.Add("fgbh");
//datas.Add("fghjkl");

//datas.GetAll();

//DataList<Person> students = new();

//students.Add(new Person { Id = 1, Name = "test1", SurName = "test1" });
//students.Add(new Person { Id = 2, Name = "test1", SurName = "test1" });

////students.GetAll();

//var res = students.GetAll();
//foreach (Person item in res)
//{
//    Console.WriteLine(item.Name);
////}

//Repository<string> repo1 = new Repository<string>();
//Repository<int> repo1 = new Repository<int>();
//Repository<Person> repo3 = new Repository<Person>();
//Repository<Person,string> test=new Repository<Person,string>();
//Repository<Person, BaseEntity> test = new Repository<Person, BaseEntity>();

//DataList<string> words=new DataList<string>();
//words.Add("salam1");
//words.Add("salam2");
//words.Add("salam3");

//var datas=words.GetAll();
//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}


//Repository<Person> repository = new Repository<Person>();
//repository.Add(new Person { Id = 1, Name = "test1", SurName = "test1" });

//Repository<Student> repository1 = new Repository<Student>();

//repository1.Add(new Student { Age = 23 });



string paymentType = "cash";

static void CheckPaymentType(string  type)
{
    switch(type)
    {
        case nameof(PaymentType.Card);
            Console.WriteLine("with card");
            break;
        case nameof(PaymentType.Cash);
            Console.WriteLine("with cash");
            break;

            default: Console.WriteLine("Payment type is wrong");
            break;

    }



    //if (type == PaymentType.Card.ToString())
    //{
    //    Console.WriteLine("with card");

    //}
    //else if(type== PaymentType.Cash.ToString())
    //{
    //    Console.WriteLine("with cash");
    //}
    //else
    //{
    //    Console.WriteLine("Payment type is wrong");
    //}

}
CheckPaymentType(paymentType);





