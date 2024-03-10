using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio3
{
    public class EmailAddress
    {
        private string _accountname;
        private string _domain;

        public string AccountName
        {
            get{ return _accountname; }
            private set{
                //if(value==null) throw new ArgumentException("the account name is invalid");
                _accountname = value;
            }
        }

        public string Domain
        {
            get{ return _domain; }
            private set{
                List<char> topLevelDoamin = new List<char>();
                for(int i=value.Length;i==0;i--)
                {
                    topLevelDoamin.Add(value[i]);
                    if(value[i]=='.') break;
                }
                //if(!IsTopLevelDoamin(topLevelDoamin.ToString()))throw new ArgumentException("invalid top level doamin");
                _domain = value;
            }
        }
        public EmailAddress(string email)
        {
            //if(!IsEmailAddress(email)) throw new ArgumentException("isn't an valid email address");
            AccountName=EmailToAccountname(email);
            Domain=EmailToDomain(email);
        }

        public string EmailToAccountname(string email)
        {
            List<char> accountname= new List<char>();
            foreach(char ch in email)
            {
                if(ch == '@') break;
                accountname.Add(ch);
            }
            return accountname.ToString();
        }

        public string EmailToDomain(string email)
        {
            List<char> doamin= new List<char>();
            for(int i=0; i<email.Length;i++)
            {
                if(email[i] != AccountName[i] || email[i]!='@')
                    doamin.Add(email[i]);
            }
            return doamin.ToString();
        }

        public bool IsEmailAddress(string email)
        {
            bool isEmail=false;
            int atPosition=0;
            foreach(char ch in email)
            {
                atPosition++;
                if(ch == '@')
                {
                    isEmail=true;
                    break;
                }
                if(ch== ' ' || (!Char.IsLetterOrDigit(ch) && ch!='-' && ch!='.'))
                {
                    isEmail=false;
                    break;
                }
            }
            if(atPosition==0 || atPosition<email.Length-3) isEmail=false;
            return isEmail;
        }

        public bool IsTopLevelDoamin(string toplevelDoamin)
        {
            string[] topLevelDomains= new string[]
            {
                ".ac",".ad",".ae",".af",".ag",".ai",".al",".am",".an",".ao",".aq",".ar",".as",".at",".au",".aw",".ax",".az",".ba",".bb",".bd",".be",".bf",".bg",".bh",".bi",".bj",".bm",".bn",".bo",".br",".bs",".bt",".bv",".bw",".by",".bz",".ca",".cc",".cd",".cf",".cg",".ch",".ci",".ck",".cl",".cm",".cn",".co",".cr",".cs",".cu",".cv",".cx",".cy",".cz",".dd",".de",".dj",".dk",".dm",".do",".dz",".ec",".ee",".eg",".eh",".er",".es",".et",".eu",".fi",".fj",".fk",".fm",".fo",".fr",".ga",".gb",".gd",".ge",".gf",".gg",".gh",".gi",".gl",".gm",".gn",".gp",".gq",".gr",".gs",".gt",".gu",".gw",".gy",".hk",".hm",".hn",".hr",".ht",".hu",".id",".ie",".il",".im",".in",".io",".iq",".ir",".is",".it",".je",".jm",".jo",".jp",".ke",".kg",".kh",".ki",".km",".kn",".kp",".kr",".kw",".ky",".kz",".la",".lb",".lc",".li",".lk",".lr",".ls",".lt",".lu",".lv",".ly",".ma",".mc",".md",".me",".mg",".mh",".mk",".ml",".mm",".mn",".mo",".mp",".mq",".mr",".ms",".mt",".mu",".mv",".mw",".mx",".my",".mz",".na",".nc",".ne",".nf",".ng",".ni",".nl",".no",".np",".nr",".nu",".nz",".om",".pa",".pe",".pf",".pg",".ph",".pk",".pl",".pm",".pn",".pr",".ps",".pt",".pw",".py",".qa",".re",".ro",".rs",".ru",".rw",".sa",".sb",".sc",".sd",".se",".sg",".sh",".si",".sj",".sk",".sl",".sm",".sn",".so",".sr",".st",".su",".sv",".sy",".sz",".tc",".td",".tf",".tg",".th",".tj",".tk",".tl",".tm",".tn",".to",".tp",".tr",".tt",".tv",".tw",".tz",".ua",".ug",".uk",".us",".uy",".uz",".va",".vc",".ve",".vg",".vi",".vn",".vu",".wf",".ws",".ye",".yt",".za",".zm",".zw",".aero",".asia",".biz",".cat",".com",".coop",".edu",".gov",".info",".int",".jobs",".mil",".mobi",".muse",".name",".net",".org",".pro",".tel",".trav",".xxx"
            };
            for(int j=0;j<=topLevelDomains.Length;j++)
            {
                if(toplevelDoamin==topLevelDomains[j]) return true;
            }
            return false;
        }

        public string ToString()
        {
            return $"{AccountName}@{Domain}";
        }

    }
}