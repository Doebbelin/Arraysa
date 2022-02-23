// See https://aka.ms/new-console-template for more information

// ERSTER PUNKT string eilesen und in int covert. 


int[] array2 = new int[]{ 2, 17, 10, 9, 16, 3, 9, 16, 5, 1, 17, 14 };


int eingabe = 0;
bool vorkomm = false;
// ZWEITER PUNKT forschleife alles Zahlen im Array auslesen.

Console.WriteLine(" Gebe bitte eine Zahl ein: ");

eingabe = Convert.ToInt32(Console.ReadLine());


 for (int i = 0; i < array2.Length; i++)
{

    
    

    //IF Abfrage
    if (array2[i] == eingabe)
    {
        Console.WriteLine("Wert {0} kommt im Array an Position Index {1} vor. Das ist das {2}" , eingabe, i, i+1); 
        vorkomm = true;
    }



}
while (vorkomm == false)
{

    if (vorkomm == false)
    {
        Console.WriteLine("Wert {0} kommt im Array nicht vor.", eingabe);
        
    }
    Console.ReadKey();
}




//DRITTER PUNKT Eine if abgrage erstellen ob die eingelsene Zahl im Array ist




