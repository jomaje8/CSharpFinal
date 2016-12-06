using System.Collections.Generic;
using System;
public class MagicBase {
// create different forms of magic//
    public List<Magic> listOfMagic;

    public void RunList () {
        listOfMagic = new List<Magic>();

        ChangeList();
    }

    private void ChangeList () {
        Console.WriteLine(listOfMagic.Count);


    }

    Magic newMagic = new Magic();

    listOfMagic.Add(newMagic);

    ChangeList();
// create damage done by different forms of magic//
    
}