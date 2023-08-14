using Test.Models;//std

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentDatabase studentDatabase = new StudentDatabase();
            studentDatabase.ExecuteCode();
            //Car car = new Car();
            //Console.WriteLine($"Ball Status : {car.Status} {car.DriverName}");
            //car.Run("Ziad");
            //Console.WriteLine($"Ball Status : {car.Status} {car.DriverName}");

            //Ball ball = new Ball();
            //ball.Color = "Red";
            //ball.Size = "M";
            //ball.Type = "Foot";
            //ball.CustomerName = "Cusomer name";
            //ball.CreateBy = "Ahmed";
            //ball.CreateAt = DateTime.Now;

            //Ball ball2 = new Ball();
            //ball2.Color = "Red";
            //ball2.Size = "M";
            //ball2.Type = "Foot";
            //ball2.CustomerName = "Cusomer name";
            //ball2.CreateBy = "Ahmed";
            //ball2.CreateAt = DateTime.Now;

            //if (DateTime.Now > ball2.CreateAt.AddDays(3))
            //{
            //    throw new Exception("تاريخ الارجاع اكبر من 3 ايام");
            //}
            //ball.Create("Ahmed");
            //ball.Return("Salim");

            //Console.WriteLine($"Ball Data : {ball.Color} {car.DriverName}");



            //Employee
            //var emp = new Emploee("Ali");
            //emp.Create("Ahmed");

            ////if(emp.IsActive ==true)
            ////    emp.DeActivation("Ahmed");            
            ////else
            ////   emp.Activation("Ahmed");

            ////Short if statement
            //var x = emp.IsActive ? emp.DeActivation("Ahmed") : emp.Activation("Ahmed");

            //Console.WriteLine($"Name:{emp.Name} - IsActive:{emp.IsActive} - UpdateBy:{emp.GetUpdatedBy()} - UpdateAt:{emp.GetUpdatedAt()}");
        }
    }
}