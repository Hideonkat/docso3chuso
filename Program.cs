using System;
using System.IO.Compression;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Dien so co 3 chu so:");
        Int32 a = Int32.Parse(Console.ReadLine());
        if(a<10)
        {
           switch(a%10)
        {
            case 1:
              Console.WriteLine("Mot");
              break;
            case 2:
              Console.WriteLine("Hai");
              break;
            case 3:
              Console.WriteLine("Ba");
              break;
            case 4:
              Console.WriteLine("Bon");
              break;
            case 5:
              Console.WriteLine("Nam");
              break;
            case 6:
              Console.WriteLine("Sau");
              break;
            case 7:  
                Console.WriteLine("Bay");
                break;
            case 8:
                Console.WriteLine("Tam");
                break;
            case 9:
              Console.WriteLine("Chin");
              break;
                                
        }
        }
       else if(a<20)
       {
        switch(a%10)
        {
          case 1:
           Console.WriteLine("Muoi mot");
           break;
          case 2:
           Console.WriteLine("Muoi hai");
           break;
          case 3:
           Console.WriteLine("Muoi ba");
           break;
          case 4:
          Console.WriteLine("Muoi bon");
          break;
          case 5:
          Console.WriteLine("Muoi lam");
          break;
          case 6:
          Console.WriteLine("Muoi sau");
          break;  
          case 7:
          Console.WriteLine("Muoi bay");
          break;
          case 8:
          Console.WriteLine("Muoi tam");
          break;
          case 9:
          Console.WriteLine("Muoi chin");
          break; 
        }
       }
       else if(a<100)
       {
        switch(a/10)
        {
        case 1:
        Console.WriteLine("Muoi");
        break;
        case 2:
        Console.WriteLine("Hai muoi");
        break;
        case 3:
        Console.WriteLine("Ba muoi");
        break;
        case 4:
        Console.WriteLine("Bon muoi");
        break;
        case 5:
        Console.WriteLine("Nam muoi");
        break;
        case 6:
        Console.WriteLine("Sau muoi");
        break;
        case 7:
        Console.WriteLine("Bay muoi");
        break;
        case 8:
        Console.WriteLine("Tam muoi");
        break;
        case 9:
        Console.WriteLine("Chin muoi");
        break;       
       }
        switch(a%10)
        {
        case 1:
              Console.WriteLine("Mot");
              break;
            case 2:
              Console.WriteLine("Hai");
              break;
            case 3:
              Console.WriteLine("Ba");
              break;
            case 4:
              Console.WriteLine("Bon");
              break;
            case 5:
              Console.WriteLine("Nam");
              break;
            case 6:
              Console.WriteLine("Sau");
              break;
            case 7:  
                Console.WriteLine("Bay");
                break;
            case 8:
                Console.WriteLine("Tam");
                break;
            case 9:
              Console.WriteLine("Chin");
                break;
              
        }
       }
       else if(a<999)
        {
          switch(a/100)
          {
            case 1:
            Console.WriteLine("Mot tram");
            break;
            case 2:
            Console.WriteLine("Hai tram");
            break;
            case 3:
            Console.WriteLine("Ba tram");
            break;
            case 4:
            Console.WriteLine("Bon tram");
            break;
            case 5:
            Console.WriteLine("Nam tram");
            break;
            case 6:
            Console.WriteLine("Sau tram");
            break;
            case 7:
            Console.WriteLine("Bay tram");
            break;
            case 8:
            Console.WriteLine("Tam tram");
            break;
            case 9:
            Console.WriteLine("Chin tram");
            break;
          }
  
          switch((a%100)/10)
          {
            case 1:
        Console.WriteLine("Muoi");
        break;
        case 2:
        Console.WriteLine("Hai muoi");
        break;
        case 3:
        Console.WriteLine("Ba muoi");
        break;
        case 4:
        Console.WriteLine("Bon muoi");
        break;
        case 5:
        Console.WriteLine("Nam muoi");
        break;
        case 6:
        Console.WriteLine("Sau muoi");
        break;
        case 7:
        Console.WriteLine("Bay muoi");
        break;
        case 8:
        Console.WriteLine("Tam muoi");
        break;
        case 9:
        Console.WriteLine("Chin muoi");
        break;       

          }
          switch(a%10)
          {
            case 1:
              Console.WriteLine("Mot");
              break;
            case 2:
              Console.WriteLine("Hai");
              break;
            case 3:
              Console.WriteLine("Ba");
              break;
            case 4:
              Console.WriteLine("Bon");
              break;
            case 5:
              Console.WriteLine("Nam");
              break;
            case 6:
              Console.WriteLine("Sau");
              break;
            case 7:  
                Console.WriteLine("Bay");
                break;
            case 8:
                Console.WriteLine("Tam");
                break;
            case 9:
              Console.WriteLine("Chin");
                break;
          }
        }
        else
        {
          Console.WriteLine("co nhin thay ghi gi ko?");
        }
        
}
}