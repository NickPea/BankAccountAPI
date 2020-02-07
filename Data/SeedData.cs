using BankApi.Data;
using BankApi.Models;
using BankApi.ModelEnums;
using BankApi.ModelContext;
using System;
using System.Linq;
using System.Collections.Generic;
namespace BankApi.Data
{
    public static class SeedData
    {
        public static void Initialize(BankApiContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Persons.Any())
            {
                return;   // DB has been seeded
            }

            var people = new Person[]
            {
                new Person{FirstName="Carson",LastName="Alexander", Address="over the rainbow", PhoneNumber="12345",
                    Accounts= new List<Account> {
                        new Account {Type=AccountType.Savings, Balance=500,
                            Transactions= new List<Transaction> {
                                new Transaction {Amount=500, Description="new account creation"}
                            }
                        }
                    }
                },
                new Person{FirstName="Dunkin",LastName="Dolittle", Address="under the bridge", PhoneNumber="49034",
                    Accounts= new List<Account> {
                        new Account {Type=AccountType.EveryDay, Balance=100,
                            Transactions= new List<Transaction> {
                                new Transaction {Amount=5, Description="7/11 Moorooka"}
                            }
                        }
                    }
                }

            };

            foreach (Person p in people)
            {
                context.Persons.Add(p);
            }
            context.SaveChanges();


        }//end method
    }//end class
}//end namespace