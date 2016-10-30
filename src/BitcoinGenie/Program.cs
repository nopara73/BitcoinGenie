using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;
using NBitcoin;

namespace BitcoinGenie
{
    public class Program
    {
        public static void Main(string[] args)
        {
			WriteLine("Howdy friend, I am your Bitcoin genie. What's your wish?");
			var command = ReadLine();
			if (command == "I want to know a scriptPubKey")
			{
				WriteLine("Sure, I'll help you, what is the bitcoin address?");
				var addressString = ReadLine();
				var address = BitcoinAddress.Create(addressString);
				WriteLine(address.ScriptPubKey);
			}

			ReadLine();
		}
    }
}
