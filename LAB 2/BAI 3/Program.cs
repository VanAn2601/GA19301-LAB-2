using System;

public class UserData
{
    public int? id;
    public string? name;
    public List<float> scores;


    public UserData()
    {
        id = null;
        name = null;
        scores = new List<float>();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        UserData userData = new UserData();
        Console.WriteLine("nhap ten: ");
        userData.name = Console.ReadLine();
        Console.WriteLine("Userdata.name : " + userData.name);

        Console.WriteLine("nhap id: ");
        string id = Console.ReadLine();
        userData.id = Convert.ToInt32(id);
        Console.WriteLine("Userdata.id :" + userData.id);

        Console.WriteLine("nhap danh sach diem. Nhap so luong diem can nhap: ");
        int soLuongDiem = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < soLuongDiem; i++)
        {
            userData.scores.Add(Convert.ToInt32(Console.ReadLine()));
        }
        Console.WriteLine("so luong diem can nhap la: ");
        //in ra cac phan tu trong list
        foreach (var i in userData.scores)
        {
            Console.WriteLine(" " + i);
        }
    }
}