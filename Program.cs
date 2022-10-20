string? username = string.Empty;
string? password = string.Empty;
bool login = false;
while (true) 
{
    string? arg = Console.ReadLine();
    if (arg == "signup")
    {
        username = Console.ReadLine();
        password = Console.ReadLine();
        Console.WriteLine("Signup successful!");
        continue;
        
    }
    if (arg == "login")
    {
        string? username2 = Console.ReadLine();
        string? password2 = Console.ReadLine();
        if (username2 == username) 
        {
            
            if (password2 == password) 
            {
                Console.WriteLine($"Login successful!; Logged in as {username}!");
                login = true;
                continue;
            }
                
            
        }
        if (username2 != username)
        {
            Console.WriteLine($"Invalid username: {username2}");
        }

        if (password2!= password)
        {
            Console.WriteLine($"Invalid password: {password2}");
        }

    }
    if (arg == "exit")
    {
        break;
    }

    if (login == true) 
    {
        Console.Write("What do you want to do? ");
        string? answer = Console.ReadLine();
        if (answer == "logout")
        {
            login = false;
            Console.WriteLine("Logout successful!");
            
        }
        if (answer == "exit")
        {
            break;
        }
        if (answer == "hi") 
        {
            Console.WriteLine("Hi!");
            
        }
        if (answer == "hello") 
        {
            Console.WriteLine("Hello!");
        }
        if (answer == "time") 
        {
            Console.WriteLine($"The time is {DateTime.Now}");
        }
    }
    if (arg == "credentials") 
    {
        Console.WriteLine($"Username:{username} Password:{password}");
    }
    if (arg == "help") 
    {
        Console.WriteLine("Commands: #.signup, #.login, #.credentials #.exit #.help");
    }
}

/*
this is like my biggest project thats not python
like please help me.
yeetfuel
*/