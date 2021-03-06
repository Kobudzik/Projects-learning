﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Command
{
    public class Deposit : ITransaction
    {
        private readonly Account _account;
        private readonly decimal _amount;

        public int ID { get; set; }
        public DateTime CreatedOn { get; set; }
        public CommandState Status { get; set; }


        public Deposit(int id, Account account, decimal amount)
        {
            ID = id;
            CreatedOn = DateTime.UtcNow;

            _account = account;
            _amount = amount;

            Status = CommandState.Unprocessed;
        }

        public void Execute()
        {
            _account.Balance += _amount;

            Status = CommandState.ExecuteSucceeded;

        }

        public void Undo()
        {
            if (_account.Balance >= _amount)
            {
                _account.Balance -= _amount;

                Status = CommandState.UndoSucceeded;
            }
            else
            {
                Status = CommandState.UndoFailed;
            }
        }
    }
}
