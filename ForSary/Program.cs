

//class Solution
//{
//    public string solution(string S)
//    {
//        // Implement your solution here
//        int[] counterArr = new int[27];
//        foreach (char c in S)
//        {
//            counterArr[c - 'a']++;
//        }
//        for (int i = 0; i < counterArr.Length; i++)
//        {
//            if (counterArr[i] > 1)
//            {
//                return ((char)(i + 'a')).ToString();
//            }
//        }
//        return "";
//    }

//    static void Main(string[] args)
//    {
//        Solution solution = new Solution();

//        // Example usage:
//        Console.WriteLine(solution.solution("abflouyrtnajnh")); // Output: 2
//    }
//}

//class Solution
//{
//    public bool solution(string S)
//    {
//        // Implement your solution here

//        foreach (char c in S)
//        {
//            if(!((c >=97 && c <= 122)|| (c  >= 65 && c  <= 90)))
//            {
//                return true;
//            }
//        }

//        return false;
//    }

//    static void Main(string[] args)
//    {
//        Solution solution = new Solution();

//        // Example usage:
//        Console.WriteLine(solution.solution("abflouyrAbJl)nh")); // Output: 2
//    }
//}

//using System;
//using System.Collections.Generic;

//public class PostOffice
//{
//    public static int CountPackagesOnShelf(int[] client)
// {
//int storedPackages = 0;
//    //Queue<int> clientQueue = new Queue<int>(client);
//HashSet<int> shelf = new HashSet<int>();
//int packageNumber = 1;

//while (clientQueue.Count > 0)
//{
//    int currentClient = clientQueue.Peek();

//    if (packageNumber == currentClient || shelf.Contains(currentClient))
//    {
//        clientQueue.Dequeue();
//        shelf.Remove(currentClient);
//    }
//    else
//    {
//        if (!shelf.Contains(packageNumber))
//        {
//            shelf.Add(packageNumber);
//            storedPackages++;
//        }
//    }

//    packageNumber++;
//}

//return storedPackages;


//  int n = client.Length;
//    int[] packages = new int[n + 1];
//    int shelfCount = 0;
//    int nextPackage = 1;

//    foreach (int c in client)
//    {
//        if (c == nextPackage)
//        {
//            nextPackage++;
//            while (shelfCount > 0 && packages[shelfCount] == nextPackage)
//            {
//                shelfCount--;
//                nextPackage++;
//            }
//        }
//        else
//        {
//            shelfCount++;
//            packages[shelfCount] = c;
//        }
//    }

//    return shelfCount;

//}

//public static void Main(string[] args)
//{
//    int[] client1 = { 3, 2, 4, 5, 1 };
//    int[] client2 = { 1, 2, 3, 4, 5 };
//    int[] client3 = { 3, 2, 7, 5, 4, 1, 6 };

//    Console.WriteLine(CountPackagesOnShelf(client1)); // Output: 2
//    Console.WriteLine(CountPackagesOnShelf(client2)); // Output: 0
//    Console.WriteLine(CountPackagesOnShelf(client3)); // Output: 4
//}
//}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Ayala
//{
//    internal class Program
//    {

//        static void Main(string[] args)

//        {
//            int width = 11, height = 12, countmid, modulmid, numbers;
//            numbers = (width / 2 - 1);//המיקום הראשון שבו תיהיה מודפסת הכוכבית הראשונה
//            //רוחב המגדל לחלק ל 2 כי הכוכבית צריכה להיות באמצע ופחות אחד כי הרווחים יודפסו עד האמצע באמצע תודפס הכוכבית 
//            countmid = (height - 2) / numbers;//גובה המגדל פחות 2 מפחיתים שורה ראשונה ואחרונה שמוצגות פעם אחת למסך
//                                              //לחלק למחצית מרוחב המגדל לבדוק כמה פעמים כל שורה תוכל להופיע
//            modulmid = (height - 2) % (numbers);//בודק את השארית עבור חלוקת הגובה ברוחב
//            //מספר השארית יתווסף כמספר שורות העודף לקבוצת השורות העליונה
//            //שורה ראשונה
//            for (int i = 0; i < numbers + 1; i++)
//            {
//                Console.Write(" ");//כותב למסך שורת רווחים עבור השורה הראשונה
//                //אורך השורה נקבע על פי רוחב המגדל לחלק ל 2 -1

//            }
//            Console.Write("*");//כתיבת הכוכבית הראשונה  לאחר הדפסת שורת הרווחים
//            Console.WriteLine();
//            //לולאה שעוברת על מספר הקבוצות שיש במגדל
//            for (int k = 0; k < numbers; k++)
//            {
//                //שורות הלולאה הבאה עוברת על כל קבוצה ומדפיסה את השורות 
//                //countmid = מספר השורות שיש בכל קבוצה
//                //מספר השורות העודפות שיש להוסיף עבור הקבוצה הראשונה רלוונטי רק עבור הקבוצה העליונה במגדל
//                for (int i = 0; i < countmid + modulmid; i++)
//                {
//                    //מדפיס את הרווחים עבור כל שורה
//                    //K=מספר השורה הנוכחי ומסמן כמה רווחים יש להדפיס
//                    for (int j = 0; j < numbers - k; j++)
//                    {
//                        Console.Write(" ");
//                    }

//                    for (int j = 0; j < 3 + k * 2; j++)
//                    {
//                        Console.Write("*");

//                    }
//                    Console.WriteLine();

//                }
//                modulmid = 0;//איפוס המשתנב ששמר את מספר העודף של השורות שצריך להוסיף לקבוצה העליונה
//                //רלוונטי רק עבור הקבוצה הראשונה לכן בסוף הקבוצה הראשונה מתאפס
//            }
//            //הדפסת השורה האחרונה
//            for (int i = 0; i < width; i++)
//            {
//                Console.Write("*");
//            }
//            Console.ReadKey();
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {

        string firstFilePath = @"C:\Users\USER\Downloads\AAAAyesumonim.ini";
        string secondFilePath = @"C:\Users\USER\Downloads\yesumonim.ini";

        // Read the contents of the first file
        string[] firstLines = File.ReadAllLines(firstFilePath);

        // Read the contents of the second file
        string[] secondLines = File.ReadAllLines(secondFilePath);

        // Extract keys from the first file
        HashSet<string> firstKeys = ExtractKeys(firstLines);

        // Extract keys from the second file
        HashSet<string> secondKeys = ExtractKeys(secondLines);

        // Find keys in the first file that are not in the second file
        HashSet<string> keysNotInSecond = new HashSet<string>(firstKeys.Except(secondKeys));
        if (keysNotInSecond.Count == 0)
        {
            Console.WriteLine(" pppppppppppppppppppppppppppppppppp");
        }
        Console.WriteLine("");
        foreach (string key in keysNotInSecond)
        {
            Console.WriteLine(key);
        }
    }

    static HashSet<string> ExtractKeys(string[] lines)
    {
        HashSet<string> keys = new HashSet<string>();
        foreach (string line in lines)
        {
            // Skip empty lines and lines starting with semicolon
            if (!string.IsNullOrWhiteSpace(line) && !line.Trim().StartsWith(";"))
            {
                string key = line.Split('=')[0].Trim();
                keys.Add(key);
            }
        }
        return keys;
    }
}




string fileName = Client.Id + "_" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss_") + "CharavotBarzelSocialSecurityReport.csv";
string path = Environment.GetEnvironmentVariable("TEMP");
if (!path.EndsWith("\\")) path += "\\"; if (!path.EndsWith("\\")) path += "\\";

string title = Translation["BelReport.Report.ColumnsTitle"];

StreamWriter sw = System.IO.File.CreateText(path + fileName);
sw.WriteLine("");
sw.Close();
using (var w = new StreamWriter(path + fileName))
{
    string csv = "";

    table.AsEnumerable().ToList().ForEach(line =>
    {
        csv += string.Join(",", line.ItemArray) + "\n";
    });

    w.Close();
    csv = title + "\n" + csv;
    System.IO.File.WriteAllText(path + fileName, csv, TipulimConstants.CsvEncoding);
    var f_name = fileName.Split('.')[0];
    AmazonS3Client AmazonClient = new AmazonS3Client(RegionEndpoint.EUWest1);
    try
    {
        PutObjectRequest putRequest = new PutObjectRequest
        {
            BucketName = "tipulogfiles",
            Key = String.Format("{0}{1}{2}", Client.Id, "/", fileName),
            FilePath = path + fileName,
            CannedACL = S3CannedACL.PublicRead
        };

        PutObjectResponse response = AmazonClient.PutObject(putRequest);


        UnitOfWork.Current.TransactionalFlush();
        return Csv(table, fileName, new CsvWriterSettings { ReplaceNewLinesInValues = true }, TipulimConstants.CsvEncoding);
    }
    catch (AmazonS3Exception amazonS3Exception)
    {
        if (amazonS3Exception.ErrorCode != null &&
            (amazonS3Exception.ErrorCode.Equals("InvalidAccessKeyId")
             ||
             amazonS3Exception.ErrorCode.Equals("InvalidSecurity")))
        {
            throw new Exception("Check the provided AWS Credentials.");
        }

        throw new Exception("Error occurred: " + amazonS3Exception.Message);
    }
}