using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class MyFunctions
    {
        ArrayList Functions;

        public MyFunctions()
        {
            Functions = new ArrayList();
        }

        public void AddList(ArrayList qiymetler)
        {
            Functions = qiymetler;
        }

        public void Show()
        {
            foreach (var i in Functions)
            {
                Console.WriteLine($"{i}");
            }
        }

        public void ShowMaxVaule()
        {
            int s = 0;
            foreach (int i in Functions)
            {
                if (i > s)
                {
                    s = i;
                }
            }
            Console.WriteLine($"En boyuk eded: {s}");
        }
        public void MyAddRange(ArrayList Test)
        {
            string[] List = new string[Test.Count];

            int index = 0;
            foreach (var i in Test)
            {
                if (i is string)
                {
                    List[index] = (string)i;
                    index++;
                }
            }

            int say = Functions.Count;
            foreach (var str in List)
            {
                if (!string.IsNullOrEmpty(str)) 
                {
                    Functions.Add(str); 
                }
            }

        }
        public void MyInsertManual(int index, string value)
        {
            
            Functions.Add(null); 

           
            for (int i = Functions.Count - 2; i >= index; i--)
            {
                Functions[i + 1] = Functions[i]; 
            }

            
            Functions[index] = value;
        }
        public void MyInsertRange(int index, ArrayList Test)
        {
            
            for (int i = 0; i < Test.Count; i++)
            {
                Functions.Add(null);
            }

            
            for (int i = Functions.Count - Test.Count - 1; i >= index; i--)
            {
                Functions[i + Test.Count] = Functions[i];
            }

            
            for (int i = 0; i < Test.Count; i++)
            {
                Functions[index + i] = Test[i];
            }
        }
        public void MyRemove(string value)
        {
            for(int i = 0; i < Functions.Count; i++)
            {
                if (Functions[i] == value)
                {
                    Functions[i] = null;

                    for(int j = i; j < Functions.Count - 1; j++)
                    {
                        Functions[j] = Functions[j + 1];
                    }

                    Functions[Functions.Count - 1] = null;

                }
            }
        }
        public void MyRemoveAt(int index)
        {
            
            Functions[index - 1] = null;

            
            for (int i = index - 1 ; i < Functions.Count - 1; i++)
            {
                Functions[i] = Functions[i + 1];
            }

            
            Functions[Functions.Count - 1] = null;
        }
        public void MyRemoveAll(ArrayList Test, string value)
        {
            int say = 0;
            for (int i = 0; i < Functions.Count; i++)
            {
                if (Functions[i] == value)
                {
                    Functions[i] = null;
                    say++;
                }
            }
        }
        public void MyClear()
        {
            for (int i = 0; i < Functions.Count; i++)
            {
                Functions[i] = null;
            }
        }
        public void MyCount()
        {
            int s = 0;
            for (int i = 0; i < Functions.Count; i++)
            {
                s = i;
            }
            Console.WriteLine(s + 1);
        }
        public void MyCapacity()
        {
            int currentCount = Functions.Count; 
            int capacity = 4; 

            while (capacity < currentCount) 
            {
                capacity *= 2; 
            }

            Console.WriteLine("Capacity: " + capacity); 
        }
        public void MyTrimExcess()
        {
            int currentCapacity = Functions.Count;
            if(currentCapacity > 4)
            {
                Console.WriteLine(currentCapacity);
            }
            else
            {
                Console.WriteLine(4);
            }
        }
        public void MySort()
        {
           
            for (int i = 0; i < Functions.Count - 1; i++)
            {
                
                int minIndex = i;

                for (int j = i + 1; j < Functions.Count; j++)
                {
                    
                    if ((int)Functions[j] < (int)Functions[minIndex])
                    {
                        minIndex = j;
                    }
                }

                
                if (minIndex != i)
                {
                    var temp = Functions[i];
                    Functions[i] = Functions[minIndex];
                    Functions[minIndex] = temp;
                }
            }
        }
        public void MyReverse()
        {
            ArrayList NewReversedList = new ArrayList();

            
            for (int i = Functions.Count - 1; i >= 0; i--)
            {
                NewReversedList.Add(Functions[i]);
            }

           
            Functions = NewReversedList;
        }
        public void MyMin()
        {
            if (Functions.Count == 0) 
            {
                Console.WriteLine("Siyahı boşdur.");
                return;
            }

           
            int minValue = (int)Functions[0];

            
            for (int i = 1; i < Functions.Count; i++)
            {
                if ((int)Functions[i] < minValue)
                {
                    minValue = (int)Functions[i];
                }
            }

            Console.WriteLine($"Ən kiçik dəyər: {minValue}"); 
        }
        public void MySum()
        {
            int sum = 0;
            for (int i = 0; i < Functions.Count; i++)
            {
                sum = sum + (int)Functions[i];
            }
            Console.WriteLine(sum);
        }


    }
}

