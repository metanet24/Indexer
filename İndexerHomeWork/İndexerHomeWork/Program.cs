

using İndexerHomeWork;
using System.ComponentModel;

DataList<Person> person = new();

person.Add(new Person { Id = 1, Name = "Metanet", Surname = "Abbasova" });
person.Add(new Person { Id = 2, Name = "Cavid", Surname = "Bashirov" });
person.Add(new Person { Id = 3, Name = "Naide", Surname = "Basharatova" });

PersonList personList = new PersonList();

var res=personList.GetById(2);
Console.WriteLine(res);


