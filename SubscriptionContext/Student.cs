using OrientacaoObjetos.NotificationContext;
using OrientacaoObjetos.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.SubscriptionContext;

public class Student : Base
{
    public string Name { get; set; }
    public string Email { get; set; }
    public User User { get; set; }
    public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);

    public IList<Subscription> Subscriptions { get;set; }

    public Student()
    {
        Subscriptions = new List<Subscription>();
    }

    public void CreateSubscription(Subscription subscription)
    {
        if(IsPremium)
        {
            AddNotification(new Notification("Premium", "O aluno já tem uma assinatura ativa"));
            return;
        }
        Subscriptions.Add(subscription);
    }
}
