
using IndexerExceptionHomeWork;
using IndexerExceptionHomeWork.Exceptions;
using IndexerExceptionHomeWork.Model;

//Generics<User> user = new();

//user.Add(new User {Id=1, FullName="Abbasova Metanet",Age=22});
//user.Add(new User {Id=2, FullName ="Bashirov Javid",Age = 30 });
//user.Add(new User {Id=3, FullName ="Basharatova Naida",Age = 41 });


//foreach (var item in user.ShowAll())
//{
//    //Console.WriteLine(item.FullName+" "+item.Age);
//}

////Console.WriteLine("Add id:");
////string Id = Console.ReadLine();
////int myId;
////int.TryParse(Id, out myId);
////Console.WriteLine(user.GetById(myId).FullName + " " + user.GetById(myId).Age);

////var res=user.Delete(myId);

//foreach (var item in res)
//{
//    //Console.WriteLine(item.FullName+" "+item.Age);
//}

try
{
    int num = 0;
        if (num <= 0)
        {
            throw new MathExceptions();
        }

        int factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }

    Console.WriteLine(factorial);


}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}

