using Controle_Financeiro.data;
using Controle_Financeiro.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Financeiro.controller
{
    internal class UserController : DefaultController
    {
        private readonly DataContext _context;

        public UserController(DataContext context) {
            _context = context;
        }

        public void Create(string name, string password) {
            var user = new User {
                Name = name,
                Password = password
            };

            _context.Users.Add(user);
            _context.SaveChanges();
        }


    }
}
