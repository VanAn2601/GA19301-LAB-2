using System.Diagnostics;
using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Reflection.Metadata;

public class bai2
{
    public void bai2a()
    {
        var userInfp = new
        {
            id = "2024",
            name = "Faker",
            isplayer = false,
            bag = new
            {
                Skin = 0,
                cups = 200,
            }
        };
        Debug.WriteLine("id: " + userInfp.id);
        Debug.WriteLine("name: " + userInfp.name);
        Debug.WriteLine("isplayer: " + userInfp.isplayer);
        Debug.WriteLine("bag skin: " + userInfp.bag.Skin);
        Debug.WriteLine("bag cups: " + userInfp.bag.cups);
    }


    public void bai2b()
    {
        int y = 10;
        Action<int> AnonymousMethod = delegate (int x)
        {
            int sum = x + y;
            int sub = x - y;
            Debug.WriteLine("sum: " + sum);
            Debug.WriteLine("sub: " + sub);
        };
        AnonymousMethod(5);
    }
}