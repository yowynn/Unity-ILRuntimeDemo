using System;
using System.Collections.Generic;

namespace HotFix_Project
{
    public class InstanceClass
    {
        private int id;

        public InstanceClass()
        {
            UnityEngine.Debug.Log("!!! InstanceClass::InstanceClass()");
            this.id = 0;
        }

        public InstanceClass(int id)
        {
            UnityEngine.Debug.Log("!!! InstanceClass::InstanceClass() id = " + id);
            this.id = id;
        }

        public int ID
        {
            get { return id; }
        }

        // static method
        public static void StaticFunTest()
        {
            UnityEngine.Debug.Log("!!! InstanceClass.StaticFunTest()");
        }

        public static void StaticFunTest2(int a)
        {
            UnityEngine.Debug.Log("!!! InstanceClass.StaticFunTest2(), a=" + a);
        }

        public static void StaticFunTest3(string a)
        {
            switch (a)
            {
                case "A":
                    UnityEngine.Debug.Log("case A!!");
                    break;
                case "B":
                    UnityEngine.Debug.Log("case B!!");
                    break;
                case "C":
                    UnityEngine.Debug.Log("case C!!");
                    break;
                case "D":
                    UnityEngine.Debug.Log("case D!!");
                    break;
                case "E":
                    UnityEngine.Debug.Log("case E!!");
                    break;
                case "F":
                    UnityEngine.Debug.Log("case F!!");
                    break;
                case "G":
                    UnityEngine.Debug.Log("case G!!");
                    break;
                case "H":
                    UnityEngine.Debug.Log("case H!!");
                    break;
                case "I":
                    UnityEngine.Debug.Log("case I!!");
                    break;
                default:
                    UnityEngine.Debug.Log("case default!!");
                    break;
            }
            UnityEngine.Debug.Log("!!! InstanceClass.StaticFunTest3(), a=" + a);
        }

        public static void GenericMethod<T>(T a)
        {
            UnityEngine.Debug.Log("!!! InstanceClass.GenericMethod(), a=" + a);
        }

        public void RefOutMethod(int addition, out List<int> lst, ref int val)
        {
            val = val + addition + id;
            lst = new List<int>();
            lst.Add(id);
        }
    }


}
