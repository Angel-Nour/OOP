﻿namespace AbstractFactory;

public class RoshenChocolate : IChocolate
{
    public string Try()
    {
        return "Roshen Chocolate";
    }

    public IChocolate Clone()
    {
        return new RoshenChocolate();
    }
}