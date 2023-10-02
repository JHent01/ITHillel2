


class Adress
{
	private string Index;

	public string MyPropertyForIndex
	{
		get { return Index; }
		set { Index = value; }
	}


	private string Country;

    public string MyPropertyForCountry
    {
        get { return Country; }
        set { Country = value; }
    }

    private string City;

    public string MyPropertyForCity
    {
        get { return City; }
        set { City = value; }
    }
    private string Street;

    public string MyPropertyForStreet
    {
        get { return Street; }
        set { Street = value; }
    }
    private string House;

    public string MyPropertyForHouse
    {
        get { return House; }
        set { House = value; }
    }
    private string Apartment;

    public string MyPropertyForApartment
    {
        get { return Apartment; }
        set { Apartment = value; }
    }
    
          
            
              
}   

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;



        Adress adress = new Adress();
        
        string conti;
        do
        {
            Console.WriteLine("Введіть свою адрессу: Вулиця, Номер будинку, Номер квартири, Індекс, Країна, Місто ");


            string[] arrayAdress = new string[6];
            for (int i = 0; i < arrayAdress.Length; i++)
            {
                arrayAdress[i] = Console.ReadLine();





                if (arrayAdress[i] == "")
                {
                    Console.WriteLine("Ви неправильно вказали адресс ");
                }
            }
             
            // ydilit?
            for (int i = 0; i < arrayAdress.Length; i++)
            {
                Console.Write(arrayAdress[i] + "   ");
            }

            adress.MyPropertyForStreet = arrayAdress[0];
           
            adress.MyPropertyForHouse = arrayAdress[1];
            
            adress.MyPropertyForApartment = arrayAdress[2];
         
            adress.MyPropertyForIndex = arrayAdress[3];
           
            adress.MyPropertyForCountry = arrayAdress[4];
           
            adress.MyPropertyForCity = arrayAdress[5];
            
            adress.MyPropertyForCity = arrayAdress[0];

            Console.WriteLine("Все вірно? \n Так   Ні");
            conti=Console.ReadLine();

        }
        while (conti=="Н?");



        string a = adress.MyPropertyForStreet;
        Console.ReadKey();
    }

}