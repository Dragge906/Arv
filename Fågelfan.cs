using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
class Djur
{
    protected string Namn;
    protected int Ålder;
    protected string Färg;

    public Djur(string name, int age, string color)
    {
        Namn = name;
        Ålder = age;
        Färg = color;
    }

    public void Ät()
    {
        Console.WriteLine($"{Namn} äter fläsk.");
    }

    public void Ljud()
    {
        Console.WriteLine($"{Namn} Gör såna där djurljud för varför inte.");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Namn: {Namn}, Ålder: {Ålder}, Färg: {Färg}");
    }
}

class Fågel : Djur
{
    protected int Wingspan;

    public Fågel(string name, int age, string color, int wingspan) : base(name, age, color)
    {
        Wingspan = wingspan;
    }

    public void Flyg()
    {
        Console.WriteLine($"{Namn} flyger med vingbredden {Wingspan} centimeter.");
    }

    public void Kvitra()
    {
        Console.WriteLine($"{Namn} Säger Kaka! Kaka!");
    }
}

class Pingvin : Fågel
{
    protected bool CanDance;

    public Pingvin(string name, int age, string color, int wingspan, bool CanDance) : base(name, age, color, wingspan)
    {
        CanDance = CanDance;
    }

    public void Swim()
    {
        Console.WriteLine($"{Namn} simmar i det förbannat kalla vattnet.");
    }

    public void Honk()
    {
        Console.WriteLine($"{Namn} säger Honk! Honk!");
    }

    public void Dance()
    {
        if (CanDance)
            Console.WriteLine($"{Namn} dansar som ett proffs.");
        else
            Console.WriteLine($"{Namn} saknar mad skils.");
    }
}

class Program
{
    static void Main()
    {
        Fågel myBird = new Fågel("Robin", 3, "Röd", 12);
        Pingvin myPenguin = new Pingvin("Gunter", 5, "Svart och vit", 10, true);

        myBird.Ät();
        myBird.Ljud();
        myBird.Flyg();
        myBird.Kvitra();
        myBird.DisplayInfo();

        Console.WriteLine();

        myPenguin.Ät();
        myPenguin.Ljud();
        myPenguin.Flyg();
        myPenguin.Swim();
        myPenguin.Honk();
        myPenguin.Dance();
        myPenguin.DisplayInfo();
    }
}
