using System;

class World
{
    int i, j, k;
    public World()
    {
        i = j = k = 0;
    }
    public World(int a, int b, int c)
    {
        i = a;
        j = b;
        k = c;
    }

    public static World operator +(World ob1,World ob2)
    {
        
    } 
}