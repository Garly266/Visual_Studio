bool HomeWork6 = true;

while (HomeWork6)
{
    string command = Console.ReadLine();

    switch (command)
    {
        case "task41": Task41(); break;
        case "task43": Task43(); break;
        case "exit": HomeWork6 = false; break;
    }
}

void Task41()
{
    Console.WriteLine(410);
}
void Task43()
{
    Console.WriteLine(430);
}