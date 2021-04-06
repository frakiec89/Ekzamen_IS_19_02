using System;
using System.Collections.Generic;
using System.Linq;

namespace Ekzamen_IS_19_02
{
    public class Ekzamen
    {

        /// <summary>
        /// метод  подсчета площади треугольника по  стороне  и  синусу  угла  
        /// </summary>
        /// <param name="a">сторона a</param>
        /// <param name="b">сторона b</param>
        /// <param name="angle">угол</param>
        /// <returns></returns>
        public double GetAreaOfTriangle(double a, double b, double angle)
        {
            throw new Exception("");
        }

        /// <summary>
        /// метод возвращает  средний  возраст совершеннолетних пользователей  
        /// по возрастанию имени 
        /// </summary>
        public double   GetUsersAdultAgeSr (List<User> users)
        {
            throw new  Exception();
        }

        /// <summary>
        /// метод проверки Json
        /// </summary>
        /// <param name="j"></param>
        /// <returns></returns>
        public bool IsJson (string j)
        {
            throw new Exception();
        }

    }


    public class User 
    {
       public int  ID { get; set; }
       public string Name { get; set; }
       public int Age { get; set; }
    }


    /// <summary>
    /// кость  домино 
    /// </summary>
     public class Domino_bone
     {
        public int  PointOne { get; set; }
        public int PointTwo { get; set; }

        public Domino_bone(int pointOne, int pointTwo)
        {
            IsGoodPoint(pointOne, pointTwo);
            PointOne = pointOne;
            PointTwo = pointTwo;
        }

        private static void IsGoodPoint(int pointOne, int pointTwo)
        {
            if (pointOne < 0 || pointOne > 7)
            {
                throw new ArgumentException();
            }

            if (pointTwo < 0 || pointTwo > 7)
            {
                throw new ArgumentException();
            }
        }
        public static Domino_bone StartDomino ()
        { 
            return new Domino_bone( 1, 1);
        }
    }


     public class Domino
     {

        public List<Domino_bone> dominos { get; private set; }
        public int head { get; private set; }
        public int tail { get; private set; }

        public Domino()
        {
            if(dominos==null)
            {
                dominos = new List<Domino_bone>();
                dominos.Add(Domino_bone.StartDomino());
                head = dominos.First().PointOne;
                tail = dominos.First().PointTwo;
            }
        }

        /// <summary>
        /// проверяет возможность  хода костью
        /// если ход возможен добавляет  кость в  список 
        /// </summary>
        /// <param name="bone"></param>
        /// <returns></returns>
        public bool GoDomino(Domino_bone bone)
        {
            throw new Exception("");
        }
    }
    

}
