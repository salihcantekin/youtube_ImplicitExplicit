using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitExplicit.Console;
public class Car
{
    
}


public class Mercedes : Car
{ 

}

public class Test
{
    public Test()
    {
        Car c1 = new Car();

        Mercedes m1 = new Mercedes();

        m1 = (Mercedes)c1;

        c1 = m1;
    }
}
