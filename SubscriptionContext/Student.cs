using System.Collections.Generic;
using System.Linq;
using ProjBalta.NotificationContext;
using ProjBalta.SharedContext;

namespace ProjBalta.SubscriptionContext
{
    public class Student : Base 
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }

        public string Username { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscriptions { get; set; }

        public void CreateSubscription (Subscription subscription)
        {
            if(IsPremium)
            {
                AddNotification(new Notification("Premium", "O aluno já tem uma assinatura"));
                return;
            }

            Subscriptions.Add(subscription);
        }
        public bool IsPremium => Subscriptions.Any(x=> !x.IsInactive);
    }
}