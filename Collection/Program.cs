//
//// Array
//
//using System.Collections;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Security.Cryptography.X509Certificates;
//using System.Transactions;
//
//public static class Program
//{
//    public static void Main()
//    {
//        var inta = new int[10];
//
//        var intb = new int[] { 1, 2, 3, 4, 5 };
//        var names = new string[]
//        {
//            "Alice",
//            "Bob",
//            "Kate",
//            "Linda"
//        };
//
//        
//
//
//
//        var ints = new int[10 , 20];
//        var intDynamic = new int[10][];
//        
//        for(int i = 0; i < intDynamic.Length; i++)
//        {
//            intDynamic[i] = new int[20];
//        }
//        // 배열의 길이 반환
//        Console.WriteLine(ints.Length);
//        // 이중배열의 길이 반환
//        Console.WriteLine(10 * 20);
//
//        // 모든 타입의 변수를 담고싶을떄 사용
//        var arr = Array.CreateInstance(typeof(object) , 10);
//        arr.SetValue("Myname", 0);
//        arr.SetValue(new int[10], 1);
//        arr.SetValue(1, 2);
//        arr.SetValue(1.0f, 3);
//
//        var name = (string)arr.GetValue(0)!;
//
//    }
//
//    public static void List()
//    {
//        // 10칸이 미리 만들어져있는 int 리스트 생성
//        List<int> list1 = new(10);  // Capacity
//        list1[3] = 3;
//        list1.Capacity = 20;
//
//        var bullets = new List<string>(20);
//        // 크기를 미리 설정을 하면, 공간이 부족했을 떄? (Add, AddRange 등등 공간이 부족한 상황에서 추가했을 때)
//        // 20칸일 떄 Add() 함수를 호출하여 요소를 추가한 경우,
//        // 기본 칸수 * 2 = 40
//
//        // new List<string>() ? 기본 칸수는 0
//        // Add()를 호출하였을 때는 4 값으로 확장됨.
//        // 2. int 리스트를 생설할떄 1,2,3,4,5 라는 값이 들어가있게 하기
//        var arr = new int[] { 1, 2, 3, 4, 5 };
//        
//        // 3. int 리스트를 생성할 떄 int[5] 배열의 값이 들어가있게 하기
//        List<int> list = new List<int>(arr);
//
//
//        // List 기능
//        // indexer 기능
//        var value = list[0];
//        list[0] = 1;
//        for(int i= 0; i< list.Count; ++i)
//        {
//            Console.WriteLine(list[i]);
//        }
//        // Collection
//        list.Add(0);                       // "마지막" 위치에 추가한다
//        bool isRemoved = list.Remove(2);   // 값(value)과 일치한 요소를 삭제한다
//        list.RemoveAt(0);                  // 특정 위치(index) 의 요소를 삭제한다
//        list.AddRange(new int[10]);        // 특정 배열 요소를 "마지막" 위치에서부터 추가한다.
//        list.Insert(0, 3);                 // 첫번쨰 위치에 3이라는 값을 넣는다
//
//        var lastElement = list[list.Count -1];  // 리스트의 마지막 값을 찾고싶을때
//
//
//        // ICollection
//        // A
//        foreach(var i in list)
//        {
//           
//        }
//
//        // B
//        var iterator = list.GetEnumerator();
//        while(iterator.MoveNext())
//        {
//            var value1 = iterator.Current;
//            Console.WriteLine(value1);
//        }
//
//        // Dictionary
//        // 1.선언과 동시에 초기화하기
//
//        Dictionary<string, int> dic = new Dictionary<string, int>() 
//        {
//            {"Anna", 1 },
//            {"Bob" , 2 },
//            {"Cassi" , 3 }
//        };
//        foreach(KeyValuePair<string, int> kvp in dic)
//        {
//
//        }
//            //KeyValuePair란? key 값과 value값을 직렬화 하게해준다. 물리 파일로 저장할수있게 한다.
//
//        // 물리 디스크( HDD , SSD , M.2 NVMe)
//        // 기억보조장치 ( USB,등등..)
//        // vs
//        // RAM(메모리에 저장하는 것, 프로그램 종료시 모두 초기화)
//
//        Dictionary<string,List<List<int>>> pairs = new();
//        {
//            var a = new List<List<int>>();
//            for(int i =0; i<6; ++i)
//            {
//                
//                for(int j =0; j<6;  ++j)
//                {
//                    
//                }
//            }
//
//
//
//
//
//
//
//
//            pairs.Add("Easy" , )
//        }
//        // 이름이 "5x5" 인 5 x5 지뢰찾기를 만들어주세요
//        // "Easy" -> 5x5
//        // "Normal" -> 7x7
//        // "Hard -> 10 x 10
//        
//
//    }
//    
//
//}
//[Serializable]
//public class Score
//{
//    public string Name { get; set; }
//    public int value { get; set; }
//
//    public void Save(string fileName)
//    {
//        using var fStream = new FileStream(fileName, FileMode.Create);
//        using var writer = new BinaryWriter(fStream);
//        writer.Write(Name);
//    }
//    public void Load(string fileName)
//    {
//        using var fStream = new FileStream(fileName, FileMode.Open);
//        using var reader = new BinaryReader(fStream);
//        Name = reader.ReadString();
//    }
//}