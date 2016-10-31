using System;
using System.Linq;
using static System.Console;
using NBitcoin;
using System.Globalization;

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
			if(command == "I want to create a transaction")
			{
				WriteLine("Great, here is a template for your transaction:");
				WriteLine();
				var tx = new Transaction();
				WriteLine(tx);
				WriteLine();

				WriteLine("Specify its inputs and outputs for me");
				WriteLine("First the inputs");

				WriteLine("What is the id of the transaction that you want to spend?");
				var prevOutTxId = new uint256(ReadLine());

				WriteLine("Which output of it do you want to spend? What is its id?");
				var prevOutN = int.Parse(ReadLine());
				var outPoint = new OutPoint(prevOutTxId, prevOutN);
				var txIn = new TxIn(outPoint);
				tx.Inputs.Add(txIn);

				WriteLine("Awesome, here is how your transaction looks like now:");
				WriteLine();
				WriteLine(tx);
				WriteLine();

				WriteLine("Now let's contruct the output");
				WriteLine("What is the scriptPubKey you want to send your bitcoins to?");
				var scriptPubKey = new Script(ReadLine());
				//var scriptPubKey = PayToPubkeyHashTemplate.Instance.GenerateScriptPubKey(new KeyId(.Split(' ')[2]));
				WriteLine("How much bitcoins you want to send there?");
				var amount = new Money(Convert.ToDecimal(ReadLine(), CultureInfo.InvariantCulture), MoneyUnit.BTC);
				tx.Outputs.Add(new TxOut(amount, scriptPubKey));

				WriteLine("Awesome, here is how your transaction looks like now:");
				WriteLine();
				WriteLine(tx);
				WriteLine();

				WriteLine("Now tell me your privateKey so I can sign the transaction:");
				var privKey = new BitcoinSecret(ReadLine());
				tx.Inputs.First().ScriptSig = privKey.ScriptPubKey;
				tx.Sign(privKey, assumeP2SH: false);
				WriteLine($"You signed your transaction on the {privKey.Network}");
				
				WriteLine("Here is how your final transaction looks like:");
				WriteLine();
				WriteLine(tx);
				WriteLine();

				WriteLine("Here is the hex of your transaction:");
				WriteLine();
				WriteLine(tx.ToHex());
				WriteLine();			
			}

			WriteLine("Press enter to exit...");
			ReadLine();
		}
    }
}
