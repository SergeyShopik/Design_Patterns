//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Pizza_Shop_Factory_
//{
//    public class CaliforniaPizzaStore : PizzaStore
//    {
//        public override Pizza CreatePizza(string type)
//        {
//            if (type.Equals("cheese"))
//            {
//                return new CaliforniaStyleCheesePizza();
//            }
//            else if (type.Equals("pepperoni"))
//            {
//                return new CaliforniaStylePepperoniPizza();
//            }
//            else if (type.Equals("clam"))
//            {
//                return new CaliforniaStyleClamPizza();
//            }
//            else if (type.Equals("veggie"))
//            {
//                return new CaliforniaStyleVeggiePizza();
//            }
//            else
//            {
//                return null;
//            }
//        }
//    }
//}
