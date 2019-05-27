using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

/*   IdOrder: int.Random
+User : user
+Dish[] : dish
+Customer: customer
-Pay : pay
+Timer: timer
SeatOrGo:bool

--
+OrderService(IdOrder int.Random, User user, Dish[] dish, Customer customer, Pay pay, Table int, Timer timer, SearOrGo bool, IfMemberShip)
+OpenMenu()
+SeatOrGo() :bool
+IfMemberShip() :bool
+CallToEmploye()
+EditDish()
<<properties>>
*/
namespace main
{
    class OrderService
    {

       public int IdOrder;
       public User user;
       public List<Dish> dish;
       public Pay pay;
       public Stopwatch timer;
       public bool SeatOrGo;
       public int TableBnum;


        public OrderService(User user, List<Dish> dish,Pay pay, bool SeatOrGo, int TableBnum)/*בנאי להזמנה מהמסעדב*/
        {
            Random r = new Random();
            this.IdOrder = r.Next();
            this.user = user;
            this.dish = dish;
            this.pay = pay;
            this.SeatOrGo = SeatOrGo;
            this.TableBnum = TableBnum;
            this.timer = new Stopwatch();
            timer.Start();//הפעלת הטיימר

        }

        public OrderService(User user, List<Dish> dish, Pay pay, , bool SeatOrGo)
        {
            this.user = user;
            this.dish = dish;
            this.pay = pay;
            this.SeatOrGo = SeatOrGo;
            this.timer = new Stopwatch();
            timer.Start();//הפעלת הטיימר

        }

        public void InviteTable(DateTime date,DateTime time)
        {
            /*, עוברת על הרשימה של מאגר השולחנות ובודקת 
             * האם קיים בשירות עובד שולחן 
             * פעיל מהמאגר הנ"ל במידה ולא מוסיפה רשומה חדשה מעבירה את התאריך , משריינת את מספר השולחן ושמה '-' בשאר העמודות במידה וכן ת
             *  */
        }

        public User UserP { get { return this.user; } set { this.user = value; }}
        public int IdOrderP () { return  this.IdOrder; }
        public Pay PayP { get { return this.pay; } set { this.pay = value; }}
        public Stopwatch TimerP() { return this.timer;}
        public bool SeatOrGoP { get { return this.SeatOrGo; } set { this.SeatOrGo = value; }}
        public int TableBnumP { get { return this.TableBnum; } set { this.TableBnum = value; } }
        public int list<dish> DishP { get { return this.dish; } set { this.dish = value; } }









    }
}
