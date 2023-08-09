using System.Drawing;
using System.Runtime.Intrinsics;
using System.Security.Cryptography.X509Certificates;

namespace Test.Models
{
    
    public class Ball : SharedModel
    {
        #region ctor
        public Ball()
        {
            Type = "Foot Ball";
            Color = "Black";
            Size = "10";
        }
        private Ball(string type, string color, string size, string customerName)
        {
            Type = type;
            Color = color;
            Size = size;
            CustomerName = customerName;
        } 
        #endregion

        #region prop
        public string Type { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string CustomerName { get; set; }

        public string  ReturnBy { get; set; }
        public DateTime ReturnDate { get; set; }
        #endregion

        #region method
        #region public methods
        //public Ball Create(string createBy)
        //{
        //    this.CreatedBy(createBy);
        //    return this;
        //}
        //public Ball Return(string returnBy)
        //{
        //    this.ReturnedBy(returnBy);
        //    return this;
        //}
        #endregion


        #region private methods
        Ball CreatedBy(string createdBy)
        {
            this.CreateAt = DateTime.Now;
            this.CreateBy = createdBy; ;
            return this;
        }

        Ball ReturnedBy(string returnBy)
        {   //Return : 11-8-2023 
            //Create : 9-8-2023 -> 12-8-2023
            if(DateTime.Now > this.CreateAt.AddDays(3))
            {
               throw new Exception("تاريخ الارجاع اكبر من 3 ايام");
            }

            this.ReturnDate = DateTime.Now;
            this.ReturnBy = returnBy; ;
            return this;
        } 
        #endregion
        #endregion

    }

    class Car
    {
        #region prop
        public int ID { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Status { get; set; } = "Stop";
        public string DriverName { get; set; } = "Driver ";
        #endregion

        #region method - behavior
        public void Run(string driver)
        {
            Status = "RUN";
            DriverName += driver;
        }

        public void Stop()
        {
            Status = "Stop";
        }
        #endregion
    }

    class Table
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Note { get; set; }
    }
}
