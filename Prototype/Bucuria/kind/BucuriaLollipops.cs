﻿namespace AbstractFactory;

public class BucuriaLollipops : ILollipops
{
    public string Try()
    {
        return "Bucuria Lollipops";
    }

    public ILollipops Clone()
    {
        return new BucuriaLollipops();
    }
}