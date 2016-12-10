using System;
public class Drop
{

    int thatsNutty;

    public void Healthy()
    {
        PlayerBase.armor = Damage(PlayerBase.armor);
        Console.WriteLine(PlayerBase.armor);
    }

    public void nutCount(){
        thatsNutty = Nuts(thatsNutty);
        Console.WriteLine(thatsNutty);

    }

    int Damage(int number)
    {
        int ret;
        ret = number - 20;
        return ret;
    }

    int Nuts(int number){
        int rel;
        rel = number + 2;
        return rel;
    }

}