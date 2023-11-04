
using IndexerException;
using IndexerException.Controllers;
using IndexerException.Exceptions;
using IndexerException.Helpers.Constants;

//Library library = new Library();

//Book book = new Book();

//book.Name = "Test1";

//library[0]=book;

//Console.WriteLine(library[0].Name);





//try
//{
//    int a = 5;
//    int b = 0;
//    int res = a / b;
//    Console.WriteLine(res);
//}
//catch (Exception ex)
//{

//    Console.WriteLine(ex.Message);
//}


static void Register(string userName, string password)
{
    bool isSuccess=false;
	try
	{
        if (userName == "Semed12")
        {
            Console.WriteLine();
            isSuccess = true;
        }
        else
        {
            throw new RegisterFailed();
        }

    }
	catch (Exception ex)
	{
        Console.WriteLine(ex.Message);
    }
    finally
    {
        SendEmail(isSuccess);
    }
}

//Register("Semed123", "123");

static void SendEmail(bool isSuccess)
{
    if(isSuccess)
    {
        Console.WriteLine(AccountMessages.EmailSuccess);
    }
    else
    {
        Console.WriteLine("failed");
    }
}


static void ShowText(string text)
{
    try
    {
        if (text is null)
        {
            throw new ArgumentNullException();
        }
        else
        {
            Console.WriteLine(text);
        }
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
    }
}

//ShowText(null);


PersonController personController = new PersonController();

personController.GetById();