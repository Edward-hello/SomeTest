using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeTest
{
    class Program
    {
        static void FirstTOGit()
        {
            Console.WriteLine("VSToGitHubComplete!!");
            Console.WriteLine("GitHubToVSComplete!!");
            Console.WriteLine("AgainVSToGitHub");
            Console.WriteLine("AgainGitHubToVS");
            Console.WriteLine("全部提交前的修改");
            Console.WriteLine("同步会造成冲突");
        }
        static void Print<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Swap(ref string str1, ref string str2)
        {
            string temp;
            temp = str1;
            str1 = str2;
            str2 = temp;
        }
        static void Swap<T>(T[] array1, T[] array2)
        {
            T temp;
            temp = array1[0];
            array1[0] = array2[0];
            array2[0] = temp;
        }
        static void Main(string[] args)
        {
            string a = "abc";
            string b = "abc";
            bool aEqualB = a.Equals(b);
            bool isRight = a == b;
            int num1 = 2;
            int num2 = 2;
            bool isnumEqual = num1.Equals(num2);

            System.Int32 num3 = 32;

            //People p1 = new People();
            //People p2 = new People();
            People.Instance[1, 2] = "hello";
            People p4 = new People();
            p4[4, 5] = "world";
            string str1 = People.Instance[1, 2];
            string str2 = p4[4, 5];
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(People.height);
            Console.WriteLine();

            //Console.WriteLine(People.num);

            Console.WriteLine("==================");

            //bool isTwoPEqual = p1.Equals(p2);

            //Console.WriteLine("aEqualB is {0}", aEqualB);
            //Console.WriteLine("isnumEqual is {0}",isnumEqual);
            //Console.WriteLine(num3);
            //Console.WriteLine(System.Int32.TryParse("123", out num3));
            //Console.WriteLine(num3);
            //num3 = 54;
            //Console.WriteLine(num3);
            //Console.WriteLine(1&5);
            //Console.WriteLine(1&4);
            //Console.WriteLine("isTwoPEqual is {0}", isTwoPEqual);

            //Console.WriteLine("p1为值类型么" + p1.GetType().IsValueType);

            Console.WriteLine("====================");

            IEnumerable<Animal> animalCat = new List<Cat>();
            List<Animal> listAnimals = new List<Animal>();
            //List<Animal> listAnimals2 = new List<Cat>();
            IZoo<Animal> zooAnimal = new Zoo<Cat>();
            
            Console.WriteLine(zooAnimal.GetAnimal());

            Console.WriteLine("==========================");
            // Unity中Vector3的实现
            Vector3D vec1 = new Vector3D(1, 2, 3);
            Vector3D vec2 =  vec1.Add(new Vector3D(2, 3, 4));
            Vector3D vec3 = vec1 + vec2;
            Console.WriteLine(vec2);
            Console.WriteLine(vec3);

            // 数组
            int[] array1 = new int[] { 3,4,5};
            int[] array2 = new int[3];
            array2[0] = 2;
            array2[1] = 3;
            array2[2] = 4;
            foreach (int item in array1)
            {
                Console.Write(item +" ");
            }
            Console.WriteLine();
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + " ");
            }
            Console.WriteLine("================");

            // 编码
            Console.WriteLine("编码");
            string enCodingTestText = "我爱你";
            Console.WriteLine("我爱你，Unicode也就是UTF16编码");
            byte[] enCodingTestUnicodeByte = Encoding.Unicode.GetBytes(enCodingTestText);
            Console.WriteLine("编码字节数:" + enCodingTestUnicodeByte.Length);
            foreach (var item in enCodingTestUnicodeByte)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("我爱你，UTF8编码");
            byte[] enCodingTestUTF8Byte = Encoding.UTF8.GetBytes(enCodingTestText);
            Console.WriteLine("编码字节数:" + enCodingTestUTF8Byte.Length);
            foreach (var item in enCodingTestUTF8Byte)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("我爱你，UTF32编码");
            byte[] enCodingTestUTF32Byte = Encoding.UTF32.GetBytes(enCodingTestText);
            Console.WriteLine("编码字节数:" + enCodingTestUTF32Byte.Length);
            foreach (var item in enCodingTestUTF32Byte)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("我爱你，在C#中默认的编码");
            byte[] enCodingTestDefaultByte = Encoding.Default.GetBytes(enCodingTestText);
            Console.WriteLine("编码字节数:" + enCodingTestDefaultByte.Length);
            foreach (var item in enCodingTestDefaultByte)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            char[] encoding1 = new char[] { '我','a','b','g' };
            char[] encoding2 = new char[] { 'i', 'a', 'b', 'g' };
            byte[] encodingIntToByte1 = Encoding.Default.GetBytes(encoding1);
            byte[] encodingIntToByte2 = Encoding.Default.GetBytes(encoding2);
            Console.WriteLine("编码字节数:" + encodingIntToByte1.Length);
            foreach (var item in encodingIntToByte1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in encodingIntToByte2)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("===============");

            string first = "hello";
            string second = "world";
            Swap(ref first, ref second);
            Console.WriteLine(first + ","+ second);
            char[] charList1 = new char[] { 'h', 'e', 'l', 'l', 'o' };
            char[] charList2 = new char[] { 'w', 'o', 'r', 'l', 'd' };
            Swap<char>(charList1, charList2);
            Print<char>(charList1);
            Print<char>(charList2);

            FirstTOGit();

            Console.ReadKey();
        }

        static Animal GetPat(Cat cat)
        {
            return cat;
        }
    }

    public class People : BaseManager<People>
    {
        int age = 8;
        static int num = 100;
        const float KalValue = 5.6f;
        readonly float weight;
        public float Weight 
        { 
            get { return weight; }
            
        }
        
        public static readonly float height;

        static People()
        {
            height = 10f;
        }
        public People(float ni)
        {
            weight = ni + weight * KalValue;
        }
        public People()
        {

        }
        public int MyAge
        {
            get { return age; }
            set { age = value; }
        }


        public float GetWeight()
        {
            return 0.1f;
        }

        // 索引器
        public string this[int x, int y] 
        {
            get 
            {
                return "" + x + y;
            }
            set 
            {
                Console.WriteLine("x = " + x + ",y = " + y + ",value = " + value);
            }
        }

    }

    public class BaseManager<T> where T : new()
    {
        private static T instance;
        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new T();
                }
                return instance;
            }
        }
    }

    public interface IZoo<out T>
    {
        T GetAnimal();
    }

    public class Zoo<T> : IZoo<Animal>
    {
        private Cat obj;
        public Animal GetAnimal()
        {
            return obj;
        }
    }

    public class Animal
    {

    }

    public class Cat : Animal
    {

    }
}
