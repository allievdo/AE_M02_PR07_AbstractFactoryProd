using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAnimal
{
    public Sprite AddImage();
}

public class Cow : IAnimal 
{ 
    public Sprite AddImage()
    {
        return Resources.Load<Sprite>("Cow");
    }
} //cant swim, 4 legs, edible ??IGNORE OLD
public class Horse : IAnimal {
    public Sprite AddImage()
    {
        return Resources.Load<Sprite>("Horse");
    }
} //cant swim, 4 legs, non-edible
public class Dog : IAnimal {
    public Sprite AddImage()
    {
        return Resources.Load<Sprite>("Dog");
    }
} //can swim, 4 legs, non-edible
public class Duck : IAnimal {
    public Sprite AddImage()
    {
        return Resources.Load<Sprite>("Duck");
    }
} //swim, 2 legs, edible
public class Chicken : IAnimal {
    public Sprite AddImage()
    {
        return Resources.Load<Sprite>("Chicken");
    }
}
public class Rabbit : IAnimal {
    public Sprite AddImage()
    {
        return Resources.Load<Sprite>("Rabbit");
    }
}
public class Human : IAnimal {
    public Sprite AddImage()
    {
        return Resources.Load<Sprite>("Human");
    }
}
public class Worm : IAnimal {
    public Sprite AddImage()
    {
        return Resources.Load<Sprite>("Worm");
    }
}
public class Snake : IAnimal {
    public Sprite AddImage()
    {
        return Resources.Load<Sprite>("Snake");
    }
}
public class Ostrich : IAnimal {
    public Sprite AddImage()
    {
        return Resources.Load<Sprite>("Ostrich");
    }
}
public class Zebra : IAnimal {
    public Sprite AddImage()
    {
        return Resources.Load<Sprite>("Zebra");
    }
}
public class Snail : IAnimal {
    public Sprite AddImage()
    {
        return Resources.Load<Sprite>("Snail");
    }
}
public class Lizard : IAnimal {
    public Sprite AddImage()
    {
        return Resources.Load<Sprite>("Lizard");
    }
}
public class GardenSnake : IAnimal {
    public Sprite AddImage()
    {
        return Resources.Load<Sprite>("GardenSnake");
    }
}
public class Caterpillar : IAnimal {
    public Sprite AddImage()
    {
        return Resources.Load<Sprite>("Caterpillar");
    }
}
public class LiterallyNothing : IAnimal {
    public Sprite AddImage()
    {
        return Resources.Load<Sprite>("LiterallyNothing");
    }
}
public class Monkey : IAnimal {
    public Sprite AddImage()
    {
        return Resources.Load<Sprite>("Monkey");
    }
}
public class Crocodile : IAnimal {
    public Sprite AddImage()
    {
        return Resources.Load<Sprite>("Crocodile");
    }
}
public class Fox : IAnimal {
    public Sprite AddImage()
    {
        return Resources.Load<Sprite>("Fox");
    }
}
public class HairlessCat : IAnimal {
    public Sprite AddImage()
    {
        return Resources.Load<Sprite>("HairlessCat");
    }
}
public class Cat : IAnimal {
    public Sprite AddImage()
    {
        return Resources.Load<Sprite>("Cat");
    }
}
