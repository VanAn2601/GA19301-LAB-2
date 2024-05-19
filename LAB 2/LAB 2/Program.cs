using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Collections.Generic;


public class LAB2
{
    public void bai1a()
    {
        dynamic x = 10;

        void bai1a()
        {
            Debug.WriteLine("x: " + x);
        }
    }
    public void bai1b()
    {
        getDetail(10);
        getDetail("games");
        getDetail(true);
        getDetail(9.5);
    }
    public void getDetail(dynamic value)
    {
        Debug.WriteLine("value: " + value);
    }
}
public class bai1c1
{
    public int id;
    public string name;
    public int level;

    public bai1c1()
    {
        id = 0;
        level = 0;
        name = "null";
    }
    public bai1c1(int id, string name, int level)
    {
        this.id = id;
        this.name = name;
        this.level = level;
    }
    public void getInfo()
    {
        Debug.WriteLine("id: " + id + "|Name: " + name + " |level: " + level);
    }
}
public class bai1c2
{
    public void bai1c1()
    {
        bai1c1 data = new bai1c1(007, "Drake", 200);
        data.getInfo();
    }
}