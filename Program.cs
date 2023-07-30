using OrientacaoObjetos.ContentContext;
using OrientacaoObjetos.NotificationContext;
using OrientacaoObjetos.SubscriptionContext;

var articles= new List<Article>();

articles.Add(new Article("Artigo sobre OOP", "orinetacao-objetos"));
articles.Add(new Article("Artigo sobre C#", "csharp"));
articles.Add(new Article("Artigo sobre .net", "dotnet"));

var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");



var courses = new List<Course>();
courses.Add(courseOOP);
courses.Add(courseCsharp);
courses.Add(courseAspNet);

courseAspNet.AddNotification(new Notification());



var careers = new List<Career>();

var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");

var careerItem1 = new CareerItem(2, "Aprenda OOP", "", null);
var careerItem2 = new CareerItem(1, "Comece por aqui", "", courseCsharp);
var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);

careerDotNet.Items.Add(careerItem2);
careerDotNet.Items.Add(careerItem1);
careerDotNet.Items.Add(careerItem3);

careers.Add(careerDotNet);

foreach (var career in careers)
{
    Console.WriteLine(career.Title);

	//Colocado em ordem usando o Linq
	foreach (var item in career.Items.OrderBy(x => x.Ordem))
	{
		Console.WriteLine($"{item.Ordem} - {item.Title}");
		Console.WriteLine(item.Course?.Title);
		Console.WriteLine(item.Course?.Level);

		foreach (var notification in item.Notifications)
		{
			Console.WriteLine($"{notification.Property} - {notification.Message}");
		}
	}
}

var payPalSubscription = new PayPalSubscription();
var student = new Student();
student.Subscriptions.Add(payPalSubscription);









