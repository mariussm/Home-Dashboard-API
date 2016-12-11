using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Home_Dashboard_API.Models
{
    public class Task
    {
        public string title;
        public int id;

        public Task(String title, int id)
        {
            this.title = title;
            this.id = id;
        }
    }
}