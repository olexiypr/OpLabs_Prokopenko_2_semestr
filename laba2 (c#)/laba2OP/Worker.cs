
using System;

namespace laba2OP
{
    [Serializable]
    struct Worker
    {
        public string name, birthday, dateStartWork;
        public Worker(string name, string birthday, string dateStartWork)
        {
            this.name = name;
            this.birthday = birthday;
            this.dateStartWork = dateStartWork;
        }
    }
}