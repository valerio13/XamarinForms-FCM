using System;
namespace TestFCM
{
    public interface INotification
    {
        void CreateNotification(string title, string message);
    }
}
