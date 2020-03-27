using BusinessLayer.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Logic
{
    public class DataBaseSeed
    {
        public List<User> DB { get; set; }

        public DataBaseSeed()
        {
            DB = new List<User>
            {
                new User
                {
                    Name = "Gleb",
                    LastName = "Shalabotov",
                    Age = 23,
                    Mail = "gleb@be.be",
                    Password = "T"
                },

                new User
                {
                    Name = "Marlies",
                    LastName = "Goderis",
                    Age = 21,
                    Mail = "marlies@be.be",
                    Password = "t"
                }
            };
        }
    }
}
