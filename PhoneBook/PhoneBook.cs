using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    class PhoneBook
    {
        private List<Human> humans = new List<Human> ();
        public List<Human> Humans
        {
            get { return humans; }
        }
        public void AddHuman(string firsName, string lastName, long phoneNumber)
        {
            foreach (Human item in humans)
            {
                if (item.PhoneNumber == phoneNumber)
                {
                    return;
                }
            }
            humans.Add(new Human(firsName, lastName, phoneNumber)); 
        }
        public void DeleteHuman(long phoneNumber)
        {
            
            for (int i =0; i < humans.Count; i++)
            {
                if (humans[i].PhoneNumber == phoneNumber)
                {
                    humans.RemoveAt(i);
                }
            }
        }
        public IEnumerable<Human> Search(string searchAnswer, string searchType)
        {
            List<Human> newList = new List<Human>(); 
            foreach (Human item in humans)
            {
                switch (searchType)
                {
                    case "По имени":
                        if (item.FirstName == searchAnswer)
                        {
                            newList.Add(item);
                        }
                        break;
                    case "По фамилии":
                        if (item.LastName == searchAnswer)
                        {
                            newList.Add(item);
                        }
                        break;
                    case "По номеру телефона":
                        long phone;
                        long.TryParse(searchAnswer, out phone);
                        if (item.PhoneNumber == phone)
                        {
                            newList.Add(item);
                        }
                        break;
                }
            }
            if (newList.Count > 0)
            {
                return newList;
            }
            else
            {
                MessageBox.Show("Такого человека нет в справочнике");
                return humans;
            }
            
        }
    }
}
