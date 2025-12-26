using System.Collections;
using System.Security.Cryptography;

class Program
{
    public static void Main()
    {
        // int[] numbers;
        // int[] numbers=new int[5];
        int[] numbers={1,2,3,4,5,6,7};
        // int t=0;
        // foreach(int a in numbers)Console.WriteLine(a);
        //2d array
        // int [,] matrix=new int[2,3];
        int [,] matrix =
        {
            {1,2,3},
            {4,5,6}
        };
        // Console.WriteLine(matrix[1,0]);
        // for(int i = 0; i < matrix.GetLength(0); i++)
        // {
        //     for(int j=0;j<matrix.GetLength(1);j++)
        //     Console.Write(matrix[i,j]+" ");
        //     Console.WriteLine();
        // }




        ////--------------------------->JAgged _ARRAy ------------------------------------------------>
        /// 
        int[][] jagged=new int[2][];
        // initialization
        jagged[0]=new int[]{1,2};
        jagged[1]=new int[]{3,4,5};

        // Console.WriteLine(jagged[1][2]);
        // for(int i = 0; i < jagged.Length; i++)
        // {
        //     foreach(int x in jagged[i])
        //     {
        //         Console.Write(x+" ");
        //     }
        //     Console.WriteLine();
        // }

        ///         Array.clear          ////////!SECTION
        int[] data={10,20,30};
        Array.Clear(data,0,data.Length);
        // for (int i = 0; i < data.Length; i++)
        // {
        //     Console.WriteLine(data[i]);
        // }


        ////   Array.copy //////
        int [] src={1,2};
        int [] des1=new int[3];
        // Array.Copy(src,des,3);
        Array.Copy(src,des1,2);

        // for(int i = 0; i < src.Length; i++)
        // {
        //     Console.WriteLine(src[i]);
        // }
        ///         Array.resize()            ////!SECTION
        // int [] num={1,2};
        // Array.Resize(ref num,1);
        // Array.Resize(num,4);
        //  for(int i = 0; i < num.Length; i++)
        // {
        //     Console.WriteLine(num[i]);
        // }

        ///!SECTION             Array.exists                ///////////!SECTION
        int[] temp={1,2,3,4,5,6,6,7,8,9};
        bool find=Array.Exists(temp,x=>x>30);
        // Console.WriteLine(find);




        /////////////////////----------------   - = collections -------------------------------------->>>>>>>>>>>>>>>
        /// 
        ///   
        /// 
        /// 
        /// Generic collections
        List<int> numebrs1=new List<int>();
        numebrs1.Add(10);



        ////  Non generic collections ArrayList
        ArrayList l1=new ArrayList();
        l1.Add("hello");
        l1.Add(10);


        ////-----------> Hast table <---------------/////!SECTI
        Hashtable ht=new Hashtable();
        ht.Add(1,"vamsi");
        ht.Add(2,"fddf");
        ht.Add(3,45);
        ht.Add("sad",3434);
        // foreach(Hashtable j in ht)
        // {
            // Console.WriteLine(ht["sad"]);
        // }

        ///--------------------->stack<---------------------////////!SECTION
        Stack st=new Stack();
        st.Push(10);
        st.Push(20);
        st.Push(30);
        // Console.WriteLine(st.Peek());
        // Console.WriteLine(st.Pop());
        // Console.WriteLine(st.Peek());


        ///------------------------->queue<------------------------////!SECTION
        Queue q=new Queue();
        q.Enqueue(10);
        q.Enqueue("30");
        q.Enqueue('$');
        q.Enqueue(40.7);
        // Console.WriteLine(q.Peek());
        // Console.WriteLine(q.Dequeue());
        // Console.WriteLine(q.Dequeue());

        //// ------------------------------------------------------------------------------------------>Generic collections <--------------------------------------------------------------------------
        /// 
        /// 
        /// -------------------------------------------------------------------------->Dictionary<-------------------------------------------------------
       Dictionary<int, string> d = new Dictionary<int, string>();

        d.Add(1, "abcd");
        d.Add(2, "a");
        d.Add(5, "efrgrg");

        // Console.WriteLine(d[1]);  

        ///---------------------------------->HashSet<----------------------------------------
        
        HashSet<int> hs=new HashSet<int>();
        hs.Add(1);
        hs.Add(2);
        hs.Add(2);
        hs.Add(3);
        hs.Add(3);
        hs.Add(3);
        // foreach(int x in hs)
        // {
        //     Console.WriteLine(x);
        // }


        ///-------------------------------------------->SortedList<-----------------------------------------------------------------
        SortedList<string,string>sl=new SortedList<string, string>();
        sl.Add("a","A");
        sl.Add("b","B");
        sl.Add("c","C");
        // Console.WriteLine(sl["c"]);
        // for()
        foreach(KeyValuePair<string,string> t in sl)
        {
            // Console.WriteLine(t.Key+"->"+t.Value);
        }
        var desc = sl.OrderByDescending(x => x.Key);

        foreach (var item in desc)
        {
        // Console.WriteLine($"{item.Key} -> {item.Value}");
        }
        // if(sl.TryGetValue("a",out name))
        // {
        //     Console.WriteLine("Key found");
        // }else Console.WriteLine("Key not found");






        ///////////////Q1 find freq of elements in an array;
        /// 
        // int []arr=
        // Find the frequency of elements in an array using a Dictionary
            int[] arr = {1, 2, 3, 2, 1, 4, 2};
            Dictionary<int,int>dt=new Dictionary<int, int>();
            foreach(int x in arr)
        {
            if (dt.ContainsKey(x))
            {
                dt[x]++;
            }
            else
            {
                dt.Add(x,1);
            }
        }
        foreach(KeyValuePair<int,int> t in dt)
        {
            // Console.WriteLine($"{t.Key} -> {t.Value}");
        }
            ///2 
            /// 
            /// 
            /// 
            /// Merge 2 sorted arrays
            // Explanation: Demonstrates merging and sorting techniques.

            // using System;
            // using System.Linq;
            // class Program {
            //     static void Main() {
                    int[] arr1 = {1, 3, 5};
                    int[] arr2 = {2, 4, 6};
            int[] vec=new int[arr1.Length+arr2.Length];
            int i=0;
            int j=0;
            int k=0;
            while(i<arr1.Length && j < arr2.Length)
        {
            if (arr1[i] < arr2[j])
            {
                vec[k++]=arr1[i++];
                // i++;
            }
            else
            {
                vec[k++]=arr2[j++];
            }
        }
        while (i < arr1.Length)
        {
            vec[k++]=arr1[i++];
        }
        while (j < arr2.Length)
        {
            vec[k++]=arr2[j++];
        }
            
        foreach(int x in vec)
        {
            Console.WriteLine(x);
        }
    
    }
}