namespace Online_Enrollment_System{



class Hide{


      public static string Tago()
{
      string pin = "";

    ConsoleKeyInfo keyInfo;
    do
    {
        keyInfo = Console.ReadKey(true);

        if (keyInfo.Key == ConsoleKey.Backspace && pin.Length > 0)
        {
            pin = pin.Substring(0, pin.Length - 1);
            Console.Write("\b \b");
        }
        else if (keyInfo.Key != ConsoleKey.Enter && !char.IsControl(keyInfo.KeyChar))
        {
            Console.Write("*");
            pin += keyInfo.KeyChar;
        }
    } while (keyInfo.Key != ConsoleKey.Enter);

    Console.WriteLine();

            return pin;
        }

}
}
/*
    The following Method / Function that is encoded isn't ours. 

    our thanks and acknowledgement to:

    https://stackoverflow.com/questions/29201697/hide-replace-when-typing-a-password-c



                - GROUP 2 | INOCANDO.
*/