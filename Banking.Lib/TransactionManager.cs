using System;
using System.Collections.Generic;

namespace Banking.Lib
{
    public struct Transaction
    {
        public DateTime TimeStamp { get; internal set; }
        public string AccountNumber { get; set; }
        public TransactionType Type { get; internal set; }
        public decimal Amount { get; internal set; }
    }

    public enum TransactionType { Withdraw, Deposit }

    public class FileTransactionLogger
    {
        public void Write(DateTime timestamp, string accountNumber, TransactionType type, decimal amount)
        {
            System.IO.File.AppendAllText("transaction.log", $"{timestamp},{accountNumber}, {(int)type}, {amount}\n");
        }
        public IEnumerable<Transaction> List()
        {
            foreach(string line in System.IO.File.ReadAllLines("transation.log"))
            {
                var lines = line.Split(',');
                yield return new Transaction
                {
                    TimeStamp = DateTime.Parse(lines[0]),
                    AccountNumber = lines[1],
                    Type = (TransactionType)int.Parse(lines[2]),
                    Amount = decimal.Parse(lines[3])
                };
            }
        }
    }
}
