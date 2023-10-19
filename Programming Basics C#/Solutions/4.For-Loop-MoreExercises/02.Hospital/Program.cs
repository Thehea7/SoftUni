

// Read Input

int days = int.Parse(Console.ReadLine());
int doctors = 7;
int treatedPatiens = 0;
int unTreatedPatiens = 0;

for (int i = 1; i <= days; i++)
{
    int patiens = int.Parse(Console.ReadLine());
    if (i % 3 == 0)
    {
        if (unTreatedPatiens > treatedPatiens) doctors++;
    }
    
    if (patiens <= doctors)
    {
        treatedPatiens += patiens;
    }
    else 
    {
        treatedPatiens += doctors;
        unTreatedPatiens += (patiens - doctors);

    }
        
       
    
}
Console.WriteLine($"Treated patients: {treatedPatiens}.");
Console.WriteLine($"Untreated patients: {unTreatedPatiens}.");