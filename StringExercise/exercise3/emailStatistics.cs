using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio3
{
    public class EmailsStatistics
    {
        private List<EmailAddress> _emails;
        private List<string> _doaminList;
        private List<int> _emailOfDomainsList;

        public List<EmailAddress> Email
        {
            get{ return _emails;}
        }
        public List<string> DomainList
        {
            get{ return _doaminList;}
        }
        
        public EmailsStatistics()
        {
            _emails = new List<EmailAddress>();
            _doaminList = new List<string>();
            _emailOfDomainsList = new List<int>();

        }

        public void Add(EmailAddress emailAddress)
        {
            bool thersDoamin=false;
            for(int i=0;i<_doaminList.Count;i++)
            {
                if(emailAddress.Domain == _doaminList[i])
                {
                    _emailOfDomainsList[i]++;
                    thersDoamin=true;
                    break;
                }
            }
            if(!thersDoamin)
            {
                _doaminList.Add(emailAddress.Domain);
                _emailOfDomainsList.Add(1);
            }
            _emails.Add(emailAddress);
        }
        
        public string[] toStringList()
        {
            List<string> domainStringList = new List<string>();
            for(int i=0; i<DomainList.Count;i++)
            {
                domainStringList.Add($"{DomainList[i]} = {_emailOfDomainsList[i]} email");
            }
            return domainStringList.ToArray();
        }
    }
}