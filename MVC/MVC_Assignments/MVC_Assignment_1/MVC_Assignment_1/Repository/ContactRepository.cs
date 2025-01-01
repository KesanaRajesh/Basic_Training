﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using MVC_Assignment_1.Models;
using System.Data.Entity;
using MVC_Assignment_1.Repository;

namespace MVC_Assignment_1.Repository
{
    
    
        public class ContactRepository : IContactRepository
        {
            ContactContext db;
            public ContactRepository()
            {
                db = new ContactContext();

            }
            public async Task<List<Contact>> GetAllAsync()
            {
                return await db.Contacts.ToListAsync();
            }

            public async Task CreateAsync(Contact contact)
            {
                db.Contacts.Add(contact);
                await db.SaveChangesAsync();
            }

            public async Task DeleteAsync(long id)
            {
                var contact = await db.Contacts.FindAsync(id);
                if (contact != null)
                {
                    db.Contacts.Remove(contact);
                    await db.SaveChangesAsync();
                }
            }
        }
}
