using Android.Content;
using Android.Net;
using Android.Telephony;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Contacts;
using XF.Contatos.Contato;
using XF.Contatos.Models;

[assembly: Dependency(typeof(Contato_Android))]
namespace XF.Contatos.Droid
{
    class Contato_Android : IContato
    {
        public void GetAll()
        {
            List<Contato> contatos = new List<Contato>();

            var book = new Xamarin.Contacts.AddressBook();
            book.RequestPermission().ContinueWith(t => {
                if (!t.Result)
                {
                    Console.WriteLine("Acesso negado à lista de contatos.");
                    return;
                }

                foreach (Contact contact in book.OrderBy(c => c.LastName))
                {
                    contatos.Add(new Contato() { Nome = c.FirstName + " " + c.LastName})
                }
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}