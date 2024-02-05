using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_9
{
    static class ObservCollectioncs
    {
        static public void StudentCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: 
                    if (e.NewItems[0] is Student newStudent)
                        Console.WriteLine($"Добавлен новый объект: {newStudent.Name}");
                    break;
                case NotifyCollectionChangedAction.Remove: 
                    if (e.OldItems[0] is Student oldStudent)
                        Console.WriteLine($"Удален объект: {oldStudent.Name}");
                    break;
            }
        }
    }
}
