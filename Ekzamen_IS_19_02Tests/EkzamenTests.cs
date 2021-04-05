using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ekzamen_IS_19_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ekzamen_IS_19_02.Tests
{
    [TestClass()]
    public class EkzamenTests
    {
        private Ekzamen ekzamen = new Ekzamen();

        /// <summary>
        /// позитивный тест метода  GetAreaOfTriangle
        /// </summary>
        [TestMethod()]
        public void GetAreaOfTriangleTest_5_5_15_return_3_24()
        {
            double a = 5; // 
            double b = 5; // 
            double ange = 15; // градусов 
            double expected = 3.24;
            double actual = ekzamen.GetAreaOfTriangle(a, b, ange);
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// Негативный тест метода GetAreaOfTriangle
        /// </summary>
        [TestMethod()]
        public void GetAreaOfTriangleTest_0_50_15_return_ArgumentNullExeption()
        {
            double a = 0; // 
            double b = 50; // 
            double ange = 15; // градусов 
            Assert.ThrowsException<ArgumentNullException>
                (() => ekzamen.GetAreaOfTriangle(a, b, ange));
        }


        [TestMethod()]
        public void GetUsersAdultAgeSr_30_33()
        {
            List<User> users = new List<User>()
                {
                   new User{ ID=1 , Name= "Ivan" , Age= 20},
                   new User{ ID=2 , Name= "Lana" , Age= 15},
                   new User{ ID=3 , Name= "Катя" , Age= 2},
                   new User{ ID=4 , Name= "Женя" , Age= 3},
                   new User{ ID=5 , Name= "Лера" , Age= 1},
                   new User{ ID=6 , Name= "Petya" , Age= 13},
                   new User{ ID=7 , Name= "Саша" , Age= 20},
                   new User{ ID=8 , Name= "Sahsa" , Age= 51},
                   new User{ ID=1 , Name= "Ivan" , Age= 10}
                };

            var expected = 30.33;
            var actual = ekzamen.GetUsersAdultAgeSr(users);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void UsersAdultAgeSr_ArgumentNullException()
        {
            List<User> users = null;
            Assert.ThrowsException<ArgumentNullException>
                 (() => ekzamen.GetUsersAdultAgeSr(users));
        }

        [TestMethod()]
        public void UsersAdultAgeSr_ArgumentException()
        {
            List<User> users = new List<User>();
            Assert.ThrowsException<ArgumentException>
                 (() => ekzamen.GetUsersAdultAgeSr(users));
        }

        [TestMethod()]
        public void IsJsonTest_true()
        {
            var s = new Car() { name = "BMW" };
            string content = JsonConvert.SerializeObject(s);
            Assert.IsTrue(ekzamen.IsJson(content));
        }

        [TestMethod()]
        public void IsJsonTest_False()
        {

            string content = "dsdsds";
            Assert.IsFalse(ekzamen.IsJson(content));
        }


        [TestMethod()]
        public void IsJsonTest_Null_True()
        {
            var s = new Car() {};
            string content = JsonConvert.SerializeObject(s);
            Assert.IsTrue(ekzamen.IsJson(content));
        }

    }

    internal class Car
    {
        public string name { get; set; }
    }
}