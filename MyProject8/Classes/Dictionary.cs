using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace MyProject8.Classes
{
    class Dictionary
    {
        private bool rusCheck = false;
        private ListDictionary countries;
        public Dictionary()
        {
            this.countries = new ListDictionary();
        }

        public void PushToDictionary(string rus, string eng) 
        {
            this.countries.Add(rus, eng);
        }

        public void ChangeMode() 
        {
          this.rusCheck =  this.rusCheck ? this.rusCheck = false : this.rusCheck = true;
        }

        public bool GetMode() 
        {
            return this.rusCheck;
        }

        public string GetTranslate(string word) 
        {
            if (this.rusCheck)
            {
                foreach (var item in this.countries.Keys) 
                {
                    if ((string)this.countries[item] == word) 
                    {
                        return (string)item;
                    }
                }
            }
            else
            {
                foreach (var item in this.countries.Keys)
                {
                    if ((string)item == word)
                    {
                        return (string)this.countries[item];
                    }
                }
            }
            return "Вашого запиту не знайдено!";
        }

    }
}
