namespace IceTask3
{
    
            /*
             * Create a Shape Area Calculator Program that contains the following:
            - An Interface which contains one method to calculate the Area |
            - A abstract shape class containing a virtual display method
            - Contains one Property for Name
            - Constructor
            - Virtual Display Method
            - A Rectangle class that extends Shape and implements interface
            - Two Properties
            - Constructor
            - Calculate Area Method
            - A Circle class that extends Shape and implements interface
            */


  
        class Program
        {
            static void Main()
            {
                Rectangle rect = new Rectangle("Rectangle", 10, 5);
                rect.Display();

                Console.WriteLine();

                Circle circ = new Circle("Circle", 7);
                circ.Display();
            }
        }
    }
