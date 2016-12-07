using System.Collections.Generic;
using System;
public class MagicBase {
// create different forms of magic//
    public List<Magic> listOfMagic;

    public void RunList () {
        listOfMagic = new List<Magic>();

    }

    private void ChangeList (string name, int power) {
        Console.WriteLine(listOfMagic.Count);
          foreach(Magic magic in listOfMagic) {
            Console.WriteLine(magic.name + " is the name of your weapon.");
            Console.WriteLine(magic.power + " is the power of your weapon.");
        }


    }

    Magic newMagic = new Magic();
    newMagic.name = Console.ReadLine();
    newMagic.power = int.Parse(Console.ReadLine());

    listOfMagic.Add(newMagic);

    ChangeList();
// create damage done by different forms of magic//
    
}